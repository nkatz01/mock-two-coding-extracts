using System;
using System.Threading;

namespace Q3
{
    public readonly struct Complex
    {
        private double Real { get; }
        private double Imag { get; }

        public static Complex FromCartesian(double real, double imaginary) =>
            new Complex(real, imaginary);

        public static Complex FromPolar(double modulus, double angle) =>
            new Complex(modulus * Math.Cos(angle), modulus * Math.Sin(angle));

        private Complex(double a, double b)
        {
            Real = a;
            Imag = b;
        }

        public override string ToString() => $"Real: {Real}, Imag: {Imag}";
    }
}