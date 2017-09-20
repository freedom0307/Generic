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
using Model;
using GenericConstraint;

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
        public static string[] _str = new string[] {"1231","23534","高中生","大邪神" };//值类型
        public static People _People = new People() { _id = 13243345, _number = "SAADGJHKHK" };//类
        public static Chinese _Chinese = new Chinese() { _id = 2354456, _fee = 12800 };//类和接口
        public static DefaultConst _DefaultConst = new DefaultConst();
        public static DefaultConstParameter _DefaultConstParameter = new DefaultConstParameter();
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

                Constraint.ShowConstraintStruct(iValue);
                Constraint.ShowConstraintClass(_str);
                Constraint.ShowConstraintNew(_DefaultConst);
                Constraint.ShowConstraintBaseClass(_People);
                
                Constraint.ShowConstraintInterface(_Chinese);
                Constraint.ShowConstraintBaseClass(_Chinese);
            }
        }
        public class Chinese : People, IDdance
        {
            public double _fee
            {
                get;set;
            }

            public void Ballet()
            {
                Console .WriteLine ("中国人跳芭蕾舞！");
            }

            public void LatinDancing()
            {
                Console.WriteLine("中国人跳拉丁舞！");
            }

            public void PoleDancing()
            {
                Console.WriteLine("中国人跳钢管舞！");
            }
        }
        public class DefaultConst
        {
            public DefaultConst ()
            {
                Console.WriteLine("调用了共有的无参的构造函数！");
            }
        }
        public class DefaultConstParameter
        {
            public DefaultConstParameter(int a=1000) 
            {
                Console.WriteLine("调用了共有的有参的构造函数！，参数为{0}",a );
            }
        }

    }
}
