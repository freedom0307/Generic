using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public interface  GenericInterface<T>
    {
        int ID { get; set; }
        void Show<W>(W w);
        void Show1(T t);
    }
    public class BaseOnGnericInterface : GenericInterface<int>
    {
        public int ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Show<W>(W w)
        {
            throw new NotImplementedException();
        }

        public void Show1(int t)
        {
            throw new NotImplementedException();
        }
    }
    public class BaseOnGnericInterfaceDouble : GenericInterface<double>
    {
        public int ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Show<W>(W w)
        {
            throw new NotImplementedException();
        }

        public void Show1(double t)
        {
            throw new NotImplementedException();
        }
    }
}
