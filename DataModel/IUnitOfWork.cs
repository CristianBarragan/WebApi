﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}
