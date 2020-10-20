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

        public void PrintMax()
        {
            Console.WriteLine(GetMax());
        }
    }

    public class MainClass
    { 
        static void Main()
        {
            new GetMaxClass<int>(new int[] { 5, 6, 7 }).PrintMax();
        }
    }
}
