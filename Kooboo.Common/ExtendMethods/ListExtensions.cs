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

namespace System.Collections.Generic
{
    public static class ListExtensions
    {
        #region Add
        public static List<T> Add<T>(this List<T> list, T item, IEqualityComparer<T> comparer)
        {
            if (!list.Contains(item, comparer))
            {
                list.Add(item);
            }
            return list;
        } 
        #endregion

        #region AddRange
        public static List<T> AddRange<T>(this List<T> list, IEnumerable<T> items, IEqualityComparer<T> comparer)
        {
            foreach (var item in items)
            {
                list.Add(item, comparer);
            }
            return list;
        } 
        #endregion
    }
}
