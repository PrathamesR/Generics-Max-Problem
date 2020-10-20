using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxProblem
{
    public class Program
    {
        public static int GetMax(int a, int b, int c)
        {
            int temp = a > b ? a : b;
            return temp > c ? temp : c;
        }

        public static float GetMax(float a, float b, float c)
        {
            float temp = a > b ? a : b;
            return temp > c ? temp : c;
        }

        public static string GetMax(string a, string b, string c)
        {
            string temp = a.CompareTo(b) > 0 ? a : b;
            return temp.CompareTo(c) > 0 ? temp : c;
        }


        static void Main(string[] args)
        {
            GetMax("a", "b", "c");
        }
    }
}
