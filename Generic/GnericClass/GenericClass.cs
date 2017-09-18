using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnericClass
{
    public class GenericClass<T> 
    {
        public static void ShowGenericClass(T t)
        {
            Console.WriteLine("这是范型类！{0}",t .GetType ().Name );
        }
    }
    public class ABC:GenericClass <int >
    {

    }
}
