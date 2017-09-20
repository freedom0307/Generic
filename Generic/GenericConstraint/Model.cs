using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model 
{
    public class People 
    {
        public int _id { get; set; }
        public string _number { get; set; } 
        public void Play()
        {
            Console.WriteLine("哈哈哈哈哈！");
        }
        public void Sing()
        {
            Console.WriteLine("凉凉夜色为你思念成河！");
        }
    }
    public interface IDdance
    {
        int _id { get; set; }
        double _fee { get; set; }
        void Ballet();
        void PoleDancing();
        void LatinDancing();
    }
}
