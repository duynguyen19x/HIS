﻿using AutoMapper;
using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace HIS.Application.Core.Services
{
    public abstract class BaseAppService : IBaseAppService
    {
        public virtual HISDbContext Context { get; set; }
        public virtual IMapper ObjectMapper { get; set; }

        public BaseAppService(HISDbContext context, IMapper mapper) 
        {
            Context = context;
            ObjectMapper = mapper;
        }

        public virtual IDbContextTransaction BeginTransaction()
        {
            return Context.BeginTransaction();
        }

        public virtual void SaveChanges() 
        {
            Context.SaveChanges();
        }

        public virtual async Task SaveChangesAsync() 
        {
            await Context.SaveChangesAsync();
        }

    }
}
