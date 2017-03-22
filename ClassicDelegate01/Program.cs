using System;

namespace ClassicDelegate01
{
    public delegate int GetArea(int a);
    
    class Program
    {
        static void Main(string[] args)
        {
            GetArea A = CalculateAreaofSquare;
            int finalarea = A(4);
            Console.WriteLine(finalarea);
            Console.ReadLine();
            
        }

        public static int CalculateAreaofSquare(int a)
        {
            return a * a;
        }
    }
}
