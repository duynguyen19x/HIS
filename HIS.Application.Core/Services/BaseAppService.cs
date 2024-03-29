﻿using AutoMapper;
using HIS.Core.Domain.Uow;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace HIS.Application.Core.Services
{
    public abstract class BaseAppService : IBaseAppService
    {
        private IUnitOfWorkManager _unitOfWorkManager;

        public virtual HISDbContext Context { get; set; }
        public virtual IMapper ObjectMapper { get; set; }
        public virtual IUnitOfWorkManager UnitOfWorkManager 
        { 
            get
            {
                if (_unitOfWorkManager == null)
                {
                    throw new Exception("Must set UnitOfWorkManager before use it.");
                }

                return _unitOfWorkManager;
            }   
            set { _unitOfWorkManager = value; }
        }

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
