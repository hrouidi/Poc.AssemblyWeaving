using System;
using Math.Wrapper;

namespace Fody.Costura.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = MathWrapper.Add(1, 2);
            Console.WriteLine("1+2={0}", ret);
            Console.ReadLine();
        }
    }
}
