using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonMethod
{
    public class CommonMethod
    {
        public static void ShowInt(int _parameter)
        {
            Console.WriteLine("ShowInt:{0},type:{1}", _parameter, _parameter .GetType ().Name);
        }
        public static void ShowString(string  _parameter)
        {
            Console.WriteLine("ShowString:{0},type:{1}", _parameter, _parameter.GetType().Name);
        }
        public static void ShowDateTime(DateTime  _parameter)
        {
            Console.WriteLine("ShowDateTime:{0},type:{1}", _parameter, _parameter.GetType().Name);
        }
        public static void ShowObject(Object _parameter)
        {
            Console.WriteLine("ShowObject:{0},type:{1}", _parameter, _parameter.GetType().Name);
        }

    }
}
