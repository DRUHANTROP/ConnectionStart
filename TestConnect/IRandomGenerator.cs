
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    public interface IRandomGenerator
    {

        /// <summary>
        /// Returns column name
        /// </summary>
        string ColumnName { get; set; }

        /// <summary>
        /// Returns unique name of this generator
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Returns type of this generator
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Create a new copy of this generator 
        /// </summary>
        /// <returns></returns>
        IRandomGenerator Create();

        ///<summary>
        ///Возвращает следующую случайную величину.
        /// </summary>
        object Next();

    }
}
