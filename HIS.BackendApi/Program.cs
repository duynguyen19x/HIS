using HIS.ApplicationService;
using HIS.Core.Domain.EntityFramework;
using HIS.Core.Domain.Repositories;
using HIS.Core.Domain.Uow;
using HIS.Core.ObjectMapping;
using HIS.Core.WebApi;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.EntityFrameworkCore.Repositories;
using HIS.EntityFrameworkCore.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
ConfigureService();
var app = builder.Build();
Configure();
app.Run();

void ConfigureService()
{
    builder.Services.AddDbContext<HISDbContext>(options
        => options.UseSqlServer(builder.Configuration["ConnectionStrings:HIS"]));

    // auto mapper
    builder.Services.AddAutoMapper(typeof(MapProfile));
    builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    }));

    builder.Services.AddSingleton(typeof(IObjectMapper), typeof(AutoMapperObjectMapper));
    builder.Services.AddScoped(typeof(IDbContextProvider<>), typeof(DbContextProvider<>));
    builder.Services.AddTransient(typeof(ICurrentUnitOfWorkProvider), typeof(CurrentUnitOfWorkProvider));
    builder.Services.AddTransient(typeof(IUnitOfWorkManager), typeof(UnitOfWorkManager));
    builder.Services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork<HISDbContext>));
    builder.Services.AddTransient(typeof(IRepository<,>), typeof(HISRepository<,>));
    builder.Services.AddTransient(typeof(IBulkRepository<,>), typeof(HISBulkRepository<,>));
    
    builder.Services.ServiceCollection();

    string issuer = builder.Configuration.GetValue<string>("Tokens:Issuer");
    string signingKey = builder.Configuration.GetValue<string>("Tokens:Key");
    byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

    builder.Services.AddAuthentication(opt =>
    {
        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidIssuer = issuer,
            ValidateAudience = true,
            ValidAudience = issuer,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ClockSkew = System.TimeSpan.Zero,
            IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
        };
    });
    // Add services to the container.
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hospital Infomation System", Version = "v1" });

        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });

        c.AddSecurityRequirement(new OpenApiSecurityRequirement()
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header,
                },
                new List<string>()
            }
        });
    });


    builder.Services.AddDynamicWebApi();
}

void Configure()
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseCors("CorsPolicy");
    app.UseAuthentication();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
}
