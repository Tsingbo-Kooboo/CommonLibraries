﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Common.Web.Metadata
{

    [AttributeUsage(AttributeTargets.Property)]
    public class DataSourceAttribute : Attribute
    {
        public DataSourceAttribute(Type dataSourceType)
        {
            this.DataSourceType = dataSourceType;
        }
        public Type DataSourceType { get; private set; }
    }
}
