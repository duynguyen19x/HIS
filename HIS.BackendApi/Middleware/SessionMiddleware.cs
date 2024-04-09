using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HIS.BackendApi.Middleware
{
    public class SessionMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (Utilities.Sections.SessionExtensions.Login != null)
            {
                await _next(context);
            }
            else
            {
                // Login thì không kiểm tra đăng nhập
                if (context.Request.Path.StartsWithSegments(@"/api/Login/Authenticate") 
                    || context.Request.Path.StartsWithSegments(@"/api/Authorization/Login"))
                {
                    await _next(context);
                }

                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Miss session");
            }
        }
    }
}
