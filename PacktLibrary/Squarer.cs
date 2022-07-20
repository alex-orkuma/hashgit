using System;
using System.Threading;


namespace Packt.Shared
{
    public static class Squarer
    {
        public static double Square<T>(T input) where T : IConvertible
        {
            double result = input.ToDouble(Thread.CurrentThread.CurrentCulture);

            return result * result;
        }
    }
}