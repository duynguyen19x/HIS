﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.Core.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
        Task SaveChangesAsync();
    }
}