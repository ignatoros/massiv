using System;

namespace massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] june = new int[1000];
            int[] jule = new int[1000];
            int sum = 0;
            Random h = new Random();
            for (int i = 0; i < june.Length; i++)
            {
                june[i] = h.Next();
            }
            for (int i = 0; i < jule.Length; i++)
            {
                jule[i] = h.Next();
            }
            for (int i = 0; i < jule.Length; i++)
            {
                sum = jule[i] + june[i];
            }
            Console.WriteLine(sum);
        }
    }
}
