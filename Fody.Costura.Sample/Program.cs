using System;
using Math.Wrapper;

namespace Fody.Costura.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = MathWrapper.Add(1, 2);
            Console.WriteLine("Add ret ={0}", ret);

            ret = MathWrapper.Subtract(Double.MaxValue, Double.Epsilon);
            Console.WriteLine("Subtract ret ={0}", ret);

            ret = MathWrapper.Multiply(12.51, 52);
            Console.WriteLine("Multiply ret ={0}", ret);

            ret = MathWrapper.Divide(99, 11);
            Console.WriteLine("Devide ret ={0}", ret);

            Console.ReadLine();
        }
    }
}
