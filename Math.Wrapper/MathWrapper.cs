using System.Runtime.InteropServices;

namespace Math.Wrapper
{
    public class MathWrapper
    {
        private const string DllName = "Math.Native.dll";

        [DllImport(DllName, EntryPoint = "?Add@MyMathFuncs@MathFuncs@@SANNN@Z")]
        public static extern double Add(double a, double b);

        [DllImport(DllName)]
        public static extern double Subtract(double a, double b);

        [DllImport(DllName)]
        public static extern double Multiply(double a, double b);

        [DllImport(DllName)]
        public static extern double Divide(double a, double b);

    }
}
