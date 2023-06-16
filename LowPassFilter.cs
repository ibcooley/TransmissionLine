// Decompiled with JetBrains decompiler
// Type: TransmissionLine.LowPassFilter
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System;

namespace TransmissionLine
{
  public struct LowPassFilter
  {
    public bool Active;
    public double fo;
    public double Q;
    public int Order;

    public Complex Response(double f)
    {
      if (!this.Active)
        return new Complex(1.0, 0.0);
      Complex complex1;
      complex1.Real = 0.0;
      complex1.Imaginary = 1.0;
      Complex complex2 = complex1 * (2.0 * Math.PI * f);
      double x = 2.0 * Math.PI * this.fo;
      Complex complex3 = Math.Pow(x, 2.0) / (complex2 * complex2 + x / this.Q * complex2 + Math.Pow(x, 2.0));
      return this.Order == 2 || this.Order != 4 ? complex3 : complex3 * complex3;
    }
  }
}
