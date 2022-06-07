using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int k1 = 11;
            int k2 = 120;
            Console.WriteLine("{0}", Program.gcd(k1, k2));
        }

        public static int gcd(int k1, int k2)
            {
           
            while (k1 != k2)
            {
                if (k1 > k2) k1 -= k2;
                else k2 -= k1;
            }
            int k3 = k1;
            return k3;
        }


    }
}
