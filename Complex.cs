// Decompiled with JetBrains decompiler
// Type: TransmissionLine.Complex
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System;

namespace TransmissionLine
{
  public struct Complex
  {
    public double Real;
    public double Imaginary;

    public Complex(double r, double i)
      : this()
    {
      this.Real = r;
      this.Imaginary = i;
    }

    public double Magnitude => Math.Sqrt(Math.Pow(this.Real, 2.0) + Math.Pow(this.Imaginary, 2.0));

    public static Complex Sqrt(Complex z)
    {
      Complex complex;
      if (z.Imaginary == 0.0)
      {
        complex.Real = Math.Sqrt(z.Real);
        complex.Imaginary = 0.0;
      }
      else
      {
        complex.Real = 1.0 / Math.Sqrt(2.0) * Math.Sqrt(z.Real + Math.Sqrt(Math.Pow(z.Real, 2.0) + Math.Pow(z.Imaginary, 2.0)));
        complex.Imaginary = (double) Math.Sign(z.Imaginary) / Math.Sqrt(2.0) * Math.Sqrt(Math.Sqrt(Math.Pow(z.Real, 2.0) + Math.Pow(z.Imaginary, 2.0)) - z.Real);
      }
      return complex;
    }

    public static Complex Exp(Complex z) => new Complex(Math.Exp(z.Real) * Math.Cos(z.Imaginary), Math.Exp(z.Real) * Math.Sin(z.Imaginary));

    public double Arg
    {
      get
      {
        double num = 0;
        if (this.Real > 0.0)
          num = Math.Atan(this.Imaginary / this.Real);
        else if (this.Real == 0.0)
        {
          if (this.Imaginary > 0.0)
            num = Math.PI / 2.0;
          else if (this.Imaginary < 0.0)
            num = -1.0 * Math.PI / 2.0;
        }
        else
          num = this.Imaginary >= 0.0 ? Math.Atan(this.Imaginary / this.Real) + Math.PI : Math.Atan(this.Imaginary / this.Real) - Math.PI;
        return num;
      }
    }

    public static Complex operator -(Complex N1, Complex N2) => new Complex(N1.Real - N2.Real, N1.Imaginary - N2.Imaginary);

    public static Complex operator -(Complex N1, double N2) => new Complex(N1.Real - N2, N1.Imaginary);

    public static Complex operator -(double N1, Complex N2) => new Complex(N1 - N2.Real, 0.0 - N2.Imaginary);

    public static Complex operator +(Complex N1, Complex N2) => new Complex(N1.Real + N2.Real, N1.Imaginary + N2.Imaginary);

    public static Complex operator +(Complex N1, double N2) => new Complex(N1.Real + N2, N1.Imaginary);

    public static Complex operator +(double N1, Complex N2) => new Complex(N1 + N2.Real, N2.Imaginary);

    public static bool operator ==(Complex N1, Complex N2) => N1.Real == N2.Real & N1.Imaginary == N2.Imaginary;

    public static bool operator !=(Complex N1, Complex N2) => !(N1.Real == N2.Real & N1.Imaginary == N2.Imaginary);

    public static Complex operator *(Complex N1, Complex N2) => new Complex(N1.Real * N2.Real - N1.Imaginary * N2.Imaginary, N1.Imaginary * N2.Real + N1.Real * N2.Imaginary);

    public static Complex operator *(Complex N1, double N2) => new Complex(N1.Real * N2, N1.Imaginary * N2);

    public static Complex operator *(double N1, Complex N2) => new Complex(N1 * N2.Real, N1 * N2.Imaginary);

    public static Complex operator /(Complex N1, Complex N2) => new Complex((N1.Real * N2.Real + N1.Imaginary * N2.Imaginary) / (Math.Pow(N2.Real, 2.0) + Math.Pow(N2.Imaginary, 2.0)), (N1.Imaginary * N2.Real - N1.Real * N2.Imaginary) / (Math.Pow(N2.Real, 2.0) + Math.Pow(N2.Imaginary, 2.0)));

    public static Complex operator /(Complex N1, double N2) => new Complex(N1.Real * N2 / Math.Pow(N2, 2.0), N1.Imaginary * N2 / Math.Pow(N2, 2.0));

    public static Complex operator /(double N1, Complex N2) => new Complex(N1 * N2.Real / (Math.Pow(N2.Real, 2.0) + Math.Pow(N2.Imaginary, 2.0)), (0.0 - N1 * N2.Imaginary) / (Math.Pow(N2.Real, 2.0) + Math.Pow(N2.Imaginary, 2.0)));
  }
}
