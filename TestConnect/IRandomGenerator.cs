<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{

    public interface IRandomGenerator
    {
        string Name { get; set; }
        ///<summary>
        ///Возвращает следующую случайную величину.
        /// </summary>
        object Next();
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    interface IRandomGenerator
    {
        string Name { get; set; }
        ///<summary>
        ///Возвращает следующую случайную величину.
        /// </summary>
        object Next();
    }
}
>>>>>>> 0c7653ce58b613fb77733e43695e44721ddfed95
