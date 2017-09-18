using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonMethod;
using GenericMethod;
using System.Diagnostics;
using GnericClass;
using GenericInterface;

namespace Generic
{
    /// <summary>
    /// 1、引入范型，延迟声明
    /// </summary>
    class Program
    {
        public static  int iValue = 123;
        public static string sValue = "456";
        public static DateTime dValue = DateTime.Now;
        public static object oValue = new object();
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("*********************************");
                CommonMethod.CommonMethod.ShowInt(iValue);
                CommonMethod.CommonMethod.ShowString(sValue );
                CommonMethod.CommonMethod.ShowDateTime (dValue );
                CommonMethod.CommonMethod.ShowObject (oValue );
            }
            {
                Console.WriteLine("*********************************");
                GenericMethod.GenericMethod .GenericShow(iValue);
                GenericMethod.GenericMethod.GenericShow(sValue);
                GenericMethod.GenericMethod.GenericShow(dValue);
                GenericMethod.GenericMethod.GenericShow(oValue);
            }
            {
                long _commonMethodTime = 0;
                long _objectMethodTime = 0;
                long _genericMethodTime = 0;
                
                //Console.WriteLine("*********************************");
                //{
                //    Stopwatch sw = new Stopwatch();
                //    sw.Start();
                //    for (int i = 0; i < 10000; i++)
                //    {
                //        CommonMethod.CommonMethod.ShowInt(iValue);
                //        CommonMethod.CommonMethod.ShowString(sValue);
                //        CommonMethod.CommonMethod.ShowDateTime(dValue);
                //    }
                //    sw.Stop();
                //    _commonMethodTime = sw.ElapsedMilliseconds;
                //}
                //{
                //    Stopwatch sw = new Stopwatch();
                //    sw.Start();
                //    for (int i = 0; i < 10000; i++)
                //    {
                //        CommonMethod.CommonMethod.ShowObject (iValue);
                //        CommonMethod.CommonMethod.ShowObject(sValue);
                //        CommonMethod.CommonMethod.ShowObject(dValue);
                //    }
                //    sw.Stop();
                //    _objectMethodTime = sw.ElapsedMilliseconds;
                //}
                //{
                //    Stopwatch sw = new Stopwatch();
                //    sw.Start();
                //    for (int i = 0; i < 10000; i++)
                //    {
                //        GenericMethod.GenericMethod.GenericShow<int>(iValue);
                //        GenericMethod.GenericMethod.GenericShow<string>(sValue);
                //        GenericMethod.GenericMethod.GenericShow<DateTime>(dValue);
                //    }
                //    sw.Stop();
                //    _genericMethodTime = sw.ElapsedMilliseconds;
                //}
                //Console.WriteLine("_commonMethodTime:{0},_objectMethodTime:{1},_genericMethodTime:{2}", _commonMethodTime, _objectMethodTime, _genericMethodTime);

            }
            {
                Console.WriteLine("*********************************");
                GenericClass<int>.ShowGenericClass(123);
                GenericClass<string>.ShowGenericClass("456");
                GenericClass<DateTime>.ShowGenericClass(DateTime .Now);
            }
            {
                Console.WriteLine("*********************************");

            }
        }
       
    }
}
