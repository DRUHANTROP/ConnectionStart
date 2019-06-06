using System;
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
