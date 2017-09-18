using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    public class GenericMethod
    {
        public static void GenericShow<T>(T _tParameter)
        {
            Console.WriteLine("ShowObject:{0},type:{1}", _tParameter, _tParameter.GetType().Name);
        }
        public static void ObjectShow(object  _tParameter)
        {
            Console.WriteLine("ShowObject:{0},type:{1}", _tParameter, _tParameter.GetType().Name);
        }
    }
}
