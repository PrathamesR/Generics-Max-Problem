using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxProblem
{
    public class GetMaxClass<T> where T : IComparable
    {
        public T[] nos;

        public GetMaxClass(T[] nos)
        {
            this.nos = nos;
        }

        public T GetMax()
        {
            return nos.Max();
        }
    }

    public class MainClass
    { 
        static void Main()
        {

        }
    }
}
