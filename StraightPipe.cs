// Decompiled with JetBrains decompiler
// Type: TransmissionLine.StraightPipe
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System;

namespace TransmissionLine
{
  public struct StraightPipe
  {
    public double Length;
    public double S;
    public double StuffingDensity;
    public Complex LoadImpedance;

    public double get_C(double Co) => this.StuffingDensity >= 10.0 ? 319.0 : Co + 0.0347 * Math.Pow(this.StuffingDensity, 3.0) - 0.4356 * Math.Pow(this.StuffingDensity, 2.0) - 1.3624 * this.StuffingDensity;

    public StraightPipe(double L, double So, double SD, Complex Zr)
      : this()
    {
      this.Length = L;
      this.S = So;
      this.StuffingDensity = SD;
      this.LoadImpedance = Zr;
    }

    public double get_FlowResistivity(double f) => 90.0 * Math.Pow(this.StuffingDensity, 1.5) * Math.Pow(f / 90.0, 2.8) * Math.Pow(1.0 + Math.Pow(f / 90.0, 2.8), -1.0);

    public Complex get_ComplexPropagation(double f, double SpeedOfSound)
    {
      double x = 2.0 * Math.PI * f;
      Complex complex = new Complex(0.0, 1.0);
      return complex * Complex.Sqrt(Math.Pow(x, 2.0) / Math.Pow(SpeedOfSound, 2.0) - complex * this.get_FlowResistivity(f) * x / (Functions.DensityofAir() * Math.Pow(SpeedOfSound, 2.0)));
    }

    public Complex get_r(double f, double SpeedOfSound) => (this.LoadImpedance - this.get_Zo(f, SpeedOfSound)) / (this.LoadImpedance + this.get_Zo(f, SpeedOfSound));

    public Complex get_Zo(double f, double SpeedOfSound) => new Complex(0.0, 1.0) * (2.0 * Math.PI * f) * Functions.DensityofAir() / (this.S * this.get_ComplexPropagation(f, SpeedOfSound));

    public Complex get_Zi(double f, double Co)
    {
      Complex complex1 = this.get_r(f, this.get_C(Co));
      Complex complex2 = this.get_ComplexPropagation(f, this.get_C(Co));
      Complex complex3 = new Complex(0.0, 1.0);
      return this.get_Zo(f, this.get_C(Co)) * ((Complex.Exp(complex2 * this.Length) + complex1 * Complex.Exp(0.0 - complex2 * this.Length)) / (Complex.Exp(complex2 * this.Length) - complex1 * Complex.Exp(0.0 - complex2 * this.Length)));
    }

    public Complex get_Ratio(double f, double Co)
    {
      Complex complex1 = this.get_r(f, this.get_C(Co));
      Complex complex2 = this.get_ComplexPropagation(f, this.get_C(Co));
      Complex complex3 = new Complex(0.0, 1.0);
      return (1.0 - complex1) / (Complex.Exp(complex2 * this.Length) - complex1 * Complex.Exp(0.0 - complex2 * this.Length));
    }
  }
}
