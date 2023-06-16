// Decompiled with JetBrains decompiler
// Type: TransmissionLine.TLElement
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System;

namespace TransmissionLine
{
  public struct TLElement
  {
    public double Length;
    public double StartArea;
    public double EndArea;
    public int Taper;
    public double HypExpT;
    public double StuffingDensity;
    public Complex Zi;
    public Complex Ratio;
    public bool OpenEnd;
    public double Angle;

    public double Volume
    {
      get
      {
        if (this.EndArea == this.StartArea)
          return this.Length * this.StartArea;
        switch (this.Taper)
        {
          case 2:
            return Functions.HypExpPipeVolume(this.StartArea, this.EndArea, this.Length, 1.0);
          case 3:
            return Functions.HypExpPipeVolume(this.StartArea, this.EndArea, this.Length, 1000000.0);
          case 4:
            return Functions.HypExpPipeVolume(this.StartArea, this.EndArea, this.Length, this.HypExpT);
          default:
            return this.Length * ((this.StartArea + this.EndArea) / 2.0);
        }
      }
    }

    public double get_Area(double x)
    {
      if (this.Length <= 0.0)
        return this.StartArea;
      switch (this.Taper)
      {
        case 2:
          return Functions.HypExpPipeArea(this.StartArea, this.EndArea, this.Length, x, 1.0);
        case 3:
          return Functions.HypExpPipeArea(this.StartArea, this.EndArea, this.Length, x, 1000000.0);
        case 4:
          return Functions.HypExpPipeArea(this.StartArea, this.EndArea, this.Length, x, this.HypExpT);
        default:
          return Functions.ParabolicPipeArea(this.StartArea, this.EndArea, this.Length, x);
      }
    }

    public Complex get_InputImpedance(Complex ZRadiation, double Frequency, double SpeedOfSound)
    {
      double num1 = 0.005;
      int num2 = checked ((int) Math.Round(Math.Ceiling(unchecked (Math.Sqrt(Math.Pow(this.StartArea - this.EndArea, 2.0)) / num1))) + 1);
      Complex[] complexArray = new Complex[checked (num2 + 1)];
      double L = this.Length / (double) num2;
      double length = this.Length;
      int index = num2;
      while (index >= 1)
      {
        length -= L;
        Complex Zr = index != num2 ? complexArray[checked (index + 1)] : ZRadiation;
        StraightPipe straightPipe = new StraightPipe(L, this.get_Area(length), this.StuffingDensity, Zr);
        complexArray[index] = straightPipe.get_Zi(Frequency, SpeedOfSound);
        checked { index += -1; }
      }
      return complexArray[1];
    }

    public Complex get_FERatio(Complex ZRadiation, double Frequency, double SpeedOfSound)
    {
      Complex feRatio = new Complex(1.0, 0.0);
      double num1 = 0.005;
      int num2 = checked ((int) Math.Round(Math.Ceiling(unchecked (Math.Sqrt(Math.Pow(this.StartArea - this.EndArea, 2.0)) / num1))) + 1);
      Complex[] complexArray = new Complex[checked (num2 + 1)];
      double L = this.Length / (double) num2;
      double length = this.Length;
      int index = num2;
      while (index >= 1)
      {
        length -= L;
        Complex Zr = index != num2 ? complexArray[checked (index + 1)] : ZRadiation;
        StraightPipe straightPipe = new StraightPipe(L, this.get_Area(length), this.StuffingDensity, Zr);
        complexArray[index] = straightPipe.get_Zi(Frequency, SpeedOfSound);
        feRatio *= straightPipe.get_Ratio(Frequency, SpeedOfSound);
        checked { index += -1; }
      }
      return feRatio;
    }
  }
}
