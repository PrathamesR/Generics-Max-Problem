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
            int a_val = int.Parse(a);
            int b_val = int.Parse(b);
            int c_val = int.Parse(c);
            float temp = a_val > b_val ? a_val : b_val;
            return (temp > c_val ? temp : c_val).ToString();
        }


        static void Main(string[] args)
        {
        }
    }
}
