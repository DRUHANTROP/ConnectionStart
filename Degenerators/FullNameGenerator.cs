﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degenerators
{
    [Serializable]
    public class FullNameGenerator : IRandomGenerator
    {
        string fullName;
        FirstNameGenerator fng = new FirstNameGenerator();
        LastNameGenerator lng = new LastNameGenerator();

        public string Name => "Full name";

        public Type Type => typeof(string);

        public string ColumnName { get; set; }

        public string Description => "Returns random pair of First Name + Last Name \nExample :" + Next();

        public IRandomGenerator Create()
        {
            return new FullNameGenerator();
        }

        public object Next()
        {
            fullName = fng.Next() + " " + lng.Next();
            return fullName;
        }
    }
}