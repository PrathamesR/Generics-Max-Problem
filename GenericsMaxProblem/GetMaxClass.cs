using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxProblem
{
    public class GetMaxClass<T> where T : IComparable
    {
        public T no1;
        public T no2;
        public T no3;

        public GetMaxClass(T no1, T no2, T no3)
        {
            this.no1 = no1;
            this.no2 = no2;
            this.no3 = no3;
        }

        public T GetMax()
        {
            T temp = no1.CompareTo(no2) > 0 ? no1 : no2;
            return temp.CompareTo(no3) > 0 ? temp : no3;
        }
    }
}
