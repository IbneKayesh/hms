﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUS_USERRepository US_USER { get; }
        void Save();
    }
}
