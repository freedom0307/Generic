using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericConstraint;

namespace GenericConstraint
{
    /// <summary>
    /// 值类型、引用类型、构造函数
    /// </summary>
    public class Constraint 
    {
        public static void ShowConstraintBaseClass <T>(T t) where T :People
        {
            Console.WriteLine("****************范型约束之基类约束");
            Console.WriteLine("T的字段类型：{0}，{1}", t._id.GetType().Name, t._number.GetType().Name);
            t.Play();
            t.Sing();
        }
        public static void ShowConstraintInterface<T>(T t) where T : IDdance
        {
            Console.WriteLine("****************范型约束之接口约束");
            Console.WriteLine("T的字段类型：{0}，{1}", t._id.GetType().Name, t._fee. GetType().Name);
            t.PoleDancing();
            t.Ballet();
            t.LatinDancing();
        }
        public static void ShowConstraintStruct<T>(T t) where T : struct 
        {
            Console.WriteLine("****************范型约束之值类型约束");
            Console.WriteLine("T的字段类型：{0}", t.GetType ().Name);
        }
        public static void ShowConstraintNew<T>(T t) where T : new()
        {
            Console.WriteLine("****************范型约束之必须一个公有的无参的构造函数约束");
            Console.WriteLine("T的字段类型：{0}", t.GetType().Name);
        }
        public static void ShowConstraintClass<T>(T t) where T : class
        {
            Console.WriteLine("****************范型约束之引用类型约束");
            Console.WriteLine("T的字段类型：{0}", t.GetType().Name);
        }


    }
}
