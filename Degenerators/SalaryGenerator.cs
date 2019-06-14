﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Degenerators
{
    public class SalaryGenerator : IRandomGenerator
    {
        private Random r = new Random();
        public string ColumnName { get; set; }

        public string Name => "Salary ($)";

        public Type Type =>typeof(int);

        public IRandomGenerator Create()
        {
            return new SalaryGenerator();
        }

        public object Next()
        {
            return r.Next(3000,4500);
        }
    }
}
