// Decompiled with JetBrains decompiler
// Type: TransmissionLine.Functions
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransmissionLine
{
  [StandardModule]
  internal sealed class Functions
  {
    public static double Deg2Rad(double Deg) => Deg * (Math.PI / 180.0);

    public static double Rad2Deg(double Rad) => Rad * (180.0 / Math.PI);

    public static string UnitStringVolume(int Unit)
    {
      if (Unit < checked (Functions.UnitNumberLength() + 1))
        return Functions.UnitStringLength(Unit) + "\u00B3";
      return Unit == checked (Functions.UnitNumberLength() + 1) ? "l" : "Error";
    }

    public static string UnitStringLengthLong(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return "Meter";
        case 2:
          return "Feet";
        case 3:
          return "Inch";
        case 4:
          return "Yard";
        case 5:
          return "Centimeter";
        default:
          return "Error";
      }
    }

    public static string UnitStringLength(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return "m";
        case 2:
          return "ft";
        case 3:
          return "in";
        case 4:
          return "yd";
        case 5:
          return "cm";
        default:
          return "Error";
      }
    }

    public static double UnitFactorVolume(int Unit)
    {
      if (Unit < checked (Functions.UnitNumberLength() + 1))
        return Math.Pow(Functions.UnitFactorLength(Unit), 3.0);
      return Unit == checked (Functions.UnitNumberLength() + 1) ? 0.001 : 1.0;
    }

    public static double UnitFactorLength(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return 1.0;
        case 2:
          return 0.3048;
        case 3:
          return 0.0254;
        case 4:
          return 0.9144;
        case 5:
          return 0.01;
        default:
          return 1.0;
      }
    }

    public static int UnitNumberLength() => 5;

    public static int UnitNumberDensity() => 3;

    public static int UnitNumberVolume() => checked (Functions.UnitNumberLength() + 1);

    public static int UnitNumberTens() => 3;

    public static int UnitNumberMass() => 4;

    public static string UnitStringTens(int unit)
    {
      switch (unit)
      {
        case 1:
          return "";
        case 2:
          return "k";
        case 3:
          return "m";
        default:
          return "Error";
      }
    }

    public static string UnitStringMass(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return "kg";
        case 2:
          return "g";
        case 3:
          return "mg";
        case 4:
          return "lb";
        default:
          return "Error";
      }
    }

    public static string UnitStringDensity(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return Functions.UnitStringMass(1) + "/" + Functions.UnitStringVolume(1);
        case 2:
          return Functions.UnitStringMass(4) + "/" + Functions.UnitStringVolume(2);
        case 3:
          return Functions.UnitStringMass(2) + "/" + Functions.UnitStringVolume(5);
        default:
          return "Error";
      }
    }

    public static double UnitFactorMass(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return 1.0;
        case 2:
          return 0.001;
        case 3:
          return 1E-06;
        case 4:
          return 0.453592;
        default:
          return 1.0;
      }
    }

    public static double UnitFactorTens(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return 1.0;
        case 2:
          return 1000.0;
        case 3:
          return 0.001;
        default:
          return 1.0;
      }
    }

    public static double UnitFactorDensity(int Unit)
    {
      switch (Unit)
      {
        case 1:
          return Functions.UnitFactorMass(1) / Functions.UnitFactorVolume(1);
        case 2:
          return Functions.UnitFactorMass(4) / Functions.UnitFactorVolume(2);
        case 3:
          return Functions.UnitFactorMass(2) / Functions.UnitFactorVolume(5);
        default:
          return 1.0;
      }
    }

    public static double ConvertDensity(int SourceUnit, int TargetUnit, double Value) => Value * (Functions.UnitFactorDensity(SourceUnit) / Functions.UnitFactorDensity(TargetUnit));

    public static double ConvertMass(int SourceUnit, int TargetUnit, double Value) => Value * (Functions.UnitFactorMass(SourceUnit) / Functions.UnitFactorMass(TargetUnit));

    public static double ConvertTens(int SourceUnit, int TargetUnit, double Value) => Value * (Functions.UnitFactorTens(SourceUnit) / Functions.UnitFactorTens(TargetUnit));

    public static double ConvertLength(int SourceUnit, int TargetUnit, double Length) => Length * (Functions.UnitFactorLength(SourceUnit) / Functions.UnitFactorLength(TargetUnit));

    public static double ConvertArea(int SourceUnit, int TargetUnit, double Area) => Area * (Math.Pow(Functions.UnitFactorLength(SourceUnit), 2.0) / Math.Pow(Functions.UnitFactorLength(TargetUnit), 2.0));

    public static double ConvertVolume(int SourceUnit, int TargetUnit, double Volume) => Volume * (Functions.UnitFactorVolume(SourceUnit) / Functions.UnitFactorVolume(TargetUnit));

    public static TLElement ElementMerge(TLElement Element1, TLElement Element2)
    {
      double endArea1 = Element1.EndArea;
      double endArea2 = Element2.EndArea;
      double num = Element1.Length + Element2.Length;
      return Element1 with
      {
        Length = num,
        EndArea = endArea2,
        OpenEnd = Element2.OpenEnd
      };
    }

    public static bool ElementMergeBool(TLElement Element1, TLElement Element2)
    {
      bool flag = false;
      if (Element2.StuffingDensity == Element1.StuffingDensity && Element2.Taper == Element1.Taper)
      {
        double endArea1 = Element1.EndArea;
        double endArea2 = Element2.EndArea;
        double length = Element1.Length;
        double L = length + Element2.Length;
        double num = Functions.PipeArea(endArea1, endArea2, L, length, Element2.Taper, Element2.HypExpT);
        if (Math.Round(num, 4) == Math.Round(Element1.StartArea, 4) & Math.Round(num, 4) == Math.Round(Element2.StartArea, 4))
          flag = true;
      }
      return flag;
    }

    public static bool BranchTaperBool(TLElement FirstElement, TLElement BranchElement)
    {
      bool flag = false;
      if (FirstElement.StuffingDensity == BranchElement.StuffingDensity && FirstElement.Taper == BranchElement.Taper)
      {
        double endArea1 = BranchElement.EndArea;
        double endArea2 = FirstElement.EndArea;
        double length = BranchElement.Length;
        double L = length + FirstElement.Length;
        double num = Functions.PipeArea(endArea1, endArea2, L, length, BranchElement.Taper, BranchElement.HypExpT);
        if (Math.Round(num, 4) == Math.Round(BranchElement.StartArea, 4) & Math.Round(num, 4) == Math.Round(FirstElement.StartArea, 4))
          flag = true;
      }
      return flag;
    }

    public static TLElement ElementMergeSibling(TLElement Element1, TLElement Element2)
    {
      double startArea = Element1.StartArea;
      double endArea = Element2.EndArea;
      double num = Element1.Length + Element2.Length;
      return Element1 with
      {
        Length = num,
        EndArea = endArea,
        OpenEnd = Element2.OpenEnd
      };
    }

    public static bool ElementMergeBoolSibling(TLElement Element1, TLElement Element2)
    {
      bool flag = false;
      if (Element2.Taper == Element1.Taper)
      {
        double startArea = Element1.StartArea;
        double endArea = Element2.EndArea;
        double length = Element1.Length;
        double L = length + Element2.Length;
        double num = Functions.PipeArea(startArea, endArea, L, length, Element2.Taper, Element2.HypExpT);
        if (Math.Round(num, 4) == Math.Round(Element1.EndArea, 4) & Math.Round(num, 4) == Math.Round(Element2.StartArea, 4))
          flag = true;
      }
      return flag;
    }

    public static PointF NewGetPosition(TreeNode Node, TLParameters TLParameter)
    {
      string[] strArray = Functions.GetTreeString(Node).Split('.');
      TreeNode treeNode = Operators.CompareString(strArray[0], "Rear", false) != 0 ? TLParameter.FrontEnclosure : TLParameter.RearEnclosure;
      int upperBound = strArray.GetUpperBound(0);
      int index1 = 1;
      PointF position = default;
      while (index1 <= upperBound)
      {
        int num1 = checked (Conversions.ToInteger(strArray[index1]) - 1);
        int index2 = 0;
        while (index2 <= num1)
        {
          object tag1 = treeNode.Nodes[index2].Tag;
          TLElement tlElement = default;
          double angle = (tag1 != null ? (TLElement) tag1 : tlElement).Angle;
          ref PointF local1 = ref position;
          double x = (double) position.X;
          object tag2 = treeNode.Nodes[index2].Tag;
          double num2 = (tag2 != null ? (TLElement) tag2 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
          double num3 = x + num2;
          local1.X = (float) num3;
          ref PointF local2 = ref position;
          double y = (double) position.Y;
          object tag3 = treeNode.Nodes[index2].Tag;
          double num4 = (tag3 != null ? (TLElement) tag3 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
          double num5 = y + num4;
          local2.Y = (float) num5;
          checked { ++index2; }
        }
        if (index1 < strArray.GetUpperBound(0))
          treeNode = treeNode.Nodes[Conversions.ToInteger(strArray[index1])];
        checked { ++index1; }
      }
      return position;
    }

    public static Complex ClosedRadiationImpedance() => new Complex(3000000.0, 0.0);

    public static string TreeFullPath(TreeNode n)
    {
      string str = n.Index.ToString();
      TreeNode treeNode = n;
      int num1 = checked (n.Level - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        str = treeNode.Parent.Index.ToString() + "/" + str;
        treeNode = treeNode.Parent;
        checked { ++num2; }
      }
      return str;
    }

    public static string GetTreeString(TreeNode n)
    {
      string str = "";
      int num1 = checked (n.Level - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        int index;
        if (num2 > 0)
        {
          index = n.Index;
          str = index.ToString() + "." + str;
        }
        else
        {
          index = n.Index;
          str = index.ToString();
        }
        n = n.Parent;
        checked { ++num2; }
      }
      string treeString;
      try
      {
        treeString = Conversions.ToString(n.Tag) + "." + str;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        treeString = "Error";
        ProjectData.ClearProjectError();
      }
      return treeString;
    }

    public static Complex BranchInputImpedance(TreeNode TheTree)
    {
      TreeNode treeNode = TheTree;
      bool flag = true;
      object tag1 = treeNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
      Complex complex = tlElement2.Zi;
      while (flag)
      {
        if (treeNode.Nodes.Count > 0)
        {
          treeNode = treeNode.Nodes[0];
          Complex Z1 = complex;
          object tag2 = treeNode.Tag;
          tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
          Complex zi = tlElement2.Zi;
          complex = Functions.ImpedanceParallel(Z1, zi);
        }
        else
          flag = false;
      }
      return complex;
    }

    public static Complex TreeURatioFromPath(TreeNode TheTree, string Path)
    {
      Complex complex1 = new Complex(1.0, 0.0);
      string[] strArray = Path.Split('/');
      TreeNode treeNode = TheTree;
      int upperBound = strArray.GetUpperBound(0);
      int index1 = 1;
      while (index1 <= upperBound)
      {
        int integer = Conversions.ToInteger(strArray[index1]);
        int index2 = 0;
        while (index2 <= integer)
        {
          TLElement tlElement = default;
          if (treeNode.Nodes[index2].Nodes.Count > 0)
          {
            if (index2 == Conversions.ToInteger(strArray[index1]) & index1 < strArray.GetUpperBound(0))
            {
              Complex complex2 = complex1;
              object tag1 = treeNode.Nodes[index2].Tag;
              Complex zi1 = (tag1 != null ? (TLElement) tag1 : tlElement).Zi;
              Complex complex3 = Functions.BranchInputImpedance(treeNode.Nodes[index2].Nodes[0]);
              object tag2 = treeNode.Nodes[index2].Tag;
              Complex zi2 = (tag2 != null ? (TLElement) tag2 : tlElement).Zi;
              Complex complex4 = complex3 + zi2;
              Complex complex5 = zi1 / complex4;
              complex1 = complex2 * complex5;
              treeNode = treeNode.Nodes[index2];
            }
            else
            {
              Complex complex6 = complex1;
              Complex complex7 = Functions.BranchInputImpedance(treeNode.Nodes[index2].Nodes[0]);
              Complex complex8 = Functions.BranchInputImpedance(treeNode.Nodes[index2].Nodes[0]);
              object tag3 = treeNode.Nodes[index2].Tag;
              Complex zi = (tag3 != null ? (TLElement) tag3 : tlElement).Zi;
              Complex complex9 = complex8 + zi;
              Complex complex10 = complex7 / complex9;
              Complex complex11 = complex6 * complex10;
              object tag4 = treeNode.Nodes[index2].Tag;
              Complex ratio = (tag4 != null ? (TLElement) tag4 : tlElement).Ratio;
              complex1 = complex11 * ratio;
            }
          }
          else if (index2 == 0)
          {
            Complex complex12 = complex1;
            object tag = treeNode.Nodes[index2].Tag;
            Complex ratio = (tag != null ? (TLElement) tag : tlElement).Ratio;
            complex1 = complex12 * ratio;
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      return complex1;
    }

    public static double HypExpXo(double So, double Sl, double L, double T) => L / Math.Log(Math.Sqrt(Math.Pow(T, 2.0) + Sl / So - 1.0) / (T + 1.0) + Math.Sqrt(Sl / So) / (T + 1.0));

    public static double HypExpPipeArea(double So, double Sl, double L, double x, double T)
    {
      if (L <= 0.0)
        return So;
      if (So > Sl)
      {
        double num = So;
        So = Sl;
        Sl = num;
        x = L - x;
      }
      double num1 = Functions.HypExpXo(So, Sl, L, T);
      return So * Math.Pow(Math.Cosh(x / num1) + T * Math.Sinh(x / num1), 2.0);
    }

    public static double HypExpPipeLength(double So, double Sl, double L, double Sx, double T)
    {
      if (So > Sl)
      {
        double num = So;
        So = Sl;
        Sl = num;
      }
      double num1 = Functions.HypExpXo(So, Sl, L, T) * Math.Log(Math.Sqrt(Math.Pow(T, 2.0) + Sx / So - 1.0) / (T + 1.0) + Math.Sqrt(Sx / So) / (T + 1.0));
      return L - num1;
    }

    public static double HypExpPipeVolume(double So, double Sl, double L, double T)
    {
      if (So > Sl)
      {
        double num = So;
        So = Sl;
        Sl = num;
      }
      double num1 = Functions.HypExpXo(So, Sl, L, T);
      return 0.25 * So * (num1 * (Math.Pow(T, 2.0) + 1.0) * Math.Sinh(2.0 * L / num1) + 2.0 * num1 * T * (Math.Cosh(2.0 * L / num1) - 1.0) - 2.0 * (Math.Pow(T, 2.0) - 1.0) * L);
    }

    public static double ParabolicPipeArea(double So, double Sl, double L, double x) => (Sl * x - So * x + So * L) / L;

    public static double PipeArea(double So, double Sl, double L, double x, int Taper, double T)
    {
      if (L <= 0.0)
        return So;
      switch (Taper)
      {
        case 2:
          return Functions.HypExpPipeArea(So, Sl, L, x, 1.0);
        case 3:
          return Functions.HypExpPipeArea(So, Sl, L, x, 1000000.0);
        case 4:
          return Functions.HypExpPipeArea(So, Sl, L, x, T);
        default:
          return Functions.ParabolicPipeArea(So, Sl, L, x);
      }
    }

    public static double PipeLength(
      double So,
      double Sl,
      double Length,
      double Sx,
      int Taper,
      double T)
    {
      switch (Taper)
      {
        case 2:
          return Functions.HypExpPipeLength(So, Sl, Length, Sx, 1.0);
        case 3:
          return Functions.HypExpPipeLength(So, Sl, Length, Sx, 1000000.0);
        case 4:
          return Functions.HypExpPipeLength(So, Sl, Length, Sx, T);
        default:
          return Functions.ParabolicPipeLength(So, Sl, Length, Sx);
      }
    }

    public static double ParabolicPipeLength(double So, double Sl, double Length, double Sx)
    {
      double x1 = Math.Sqrt(So / Math.PI);
      double x2 = Math.Sqrt(Sl / Math.PI);
      return Length * ((Sx / Math.PI - Math.Pow(x1, 2.0)) / (Math.Pow(x2, 2.0) - Math.Pow(x1, 2.0)));
    }

    public static double Log(double X, double Base) => Math.Log10(X) / Math.Log10(Base);

    public static Complex ElectricalImpedance(Complex AcousticImpedance, double Bl, double Sd) => AcousticImpedance.Real == 0.0 & AcousticImpedance.Imaginary == 0.0 ? new Complex(999999999999.0, 999999999999.0) : Math.Pow(Bl, 2.0) / (Math.Pow(Sd, 2.0) * AcousticImpedance);

    public static Complex ImpedanceParallel(Complex Z1, Complex Z2)
    {
      Complex complex = default;
      return complex + Z1 * Z2 / (Z1 + Z2);
    }

    public static Complex CapacitorImpedance(double C, double f) => new Complex(0.0, -1.0 / (2.0 * Math.PI * f * C));

    public static Complex InductorImpedance(double L, double f) => new Complex(0.0, 2.0 * Math.PI * f * L);

    public static Complex ResistorImpedance(double R) => new Complex(R, 0.0);

    public static Bitmap BitMapRegionFill(Rectangle Section, Bitmap SourceImage)
    {
      Bitmap bitmap = new Bitmap(Section.Width, Section.Height);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      graphics.DrawImage((Image) SourceImage, 0, 0, Section, GraphicsUnit.Pixel);
      graphics.Dispose();
      return bitmap;
    }

    public static Complex ZesCalc(
      double frequency,
      double Rg,
      double Re,
      double Lvc,
      double Lces,
      double Cmes,
      double Res)
    {
      return Functions.ResistorImpedance(Rg) + Functions.ResistorImpedance(Re) + Functions.InductorImpedance(Lvc, frequency) + Functions.ImpedanceParallel(Functions.ImpedanceParallel(Functions.InductorImpedance(Lces, frequency), Functions.CapacitorImpedance(Cmes, frequency)), Functions.ResistorImpedance(Res));
    }

    public static Complex ZetCalc(
      double frequency,
      double Rg,
      double Re,
      double Lvc,
      double Lces,
      double Cmes,
      double Res,
      Complex Zel,
      Complex Zeb)
    {
      return Rg + Re + Functions.InductorImpedance(Lvc, frequency) + Functions.ImpedanceParallel(Functions.ImpedanceParallel(Functions.ImpedanceParallel(Functions.ImpedanceParallel(Functions.InductorImpedance(Lces, frequency), Functions.CapacitorImpedance(Cmes, frequency)), Functions.ResistorImpedance(Res)), Zel), Zeb);
    }

    public static Complex RadiationImpedance(
      double frequency,
      double PistonRadius,
      double SpeedOfSound)
    {
      double num = Math.PI * Math.Pow(PistonRadius, 2.0);
      double x = 2.0 * (2.0 * Math.PI * frequency / SpeedOfSound) * PistonRadius;
      return new Complex(Functions.DensityofAir() * SpeedOfSound / num, 0.0) * new Complex(1.0 - 2.0 * Functions.Jn(1, x) / x, 2.0 * Functions.H1(x) / x);
    }

    public static Complex RadiationPressure(
      Complex VolumeVelocity,
      double RadiationArea,
      double Distance,
      double SpeedOfSound,
      double Frequency)
    {
      double num = 2.0 * Math.PI * Frequency / SpeedOfSound;
      Complex complex = new Complex(0.0, 1.0);
      return Functions.DensityofAir() * SpeedOfSound * (VolumeVelocity / RadiationArea) * (Complex.Exp(0.0 - complex * num * Distance) - Complex.Exp(0.0 - complex * num * Math.Sqrt(Math.Pow(Distance, 2.0) + RadiationArea / Math.PI)));
    }

    public static double DensityofAir() => 1.21;

    public static double H1(double x) => 2.0 / Math.PI - Functions.Jn(0, x) + 0.092958178940651059 * (Math.Sin(x) / x) + 0.54084409738353578 * ((1.0 - Math.Cos(x)) / Math.Pow(x, 2.0));

    public static double Jn(int n, double x)
    {
      switch (n)
      {
        case 0:
          if (x > 10.0)
            return Math.Sqrt(2.0 / (Math.PI * x)) * (1.0 - 1.0 / (16.0 * Math.Pow(x, 2.0)) + 53.0 / (512.0 * Math.Pow(x, 4.0))) * Math.Cos(x - Math.PI / 4.0 - 1.0 / (8.0 * x) + 25.0 / (384.0 * Math.Pow(x, 3.0)));
          break;
        case 1:
          if (x > 10.0)
            return Math.Sqrt(2.0 / (Math.PI * x)) * (1.0 + 3.0 / (16.0 * Math.Pow(x, 2.0)) + 99.0 / (512.0 * Math.Pow(x, 4.0))) * Math.Cos(x - 3.0 * Math.PI / 4.0 + 3.0 / (8.0 * x) - 21.0 / (128.0 * Math.Pow(x, 3.0)));
          break;
        default:
          if (x > 40.0)
            return 0.0;
          break;
      }
      int num1 = 0;
      double num2 = 0;
      do
      {
        double num3 = Math.Pow(-1.0, (double) num1) * Math.Pow(x / 2.0, (double) checked (2 * num1 + n)) / (Functions.Factorial(num1) * Functions.Factorial(checked (num1 + n)));
        num2 += num3;
        checked { ++num1; }
      }
      while (num1 <= 55);
      return num2;
    }

    public static double Factorial(int bNum) => bNum <= 0 ? 1.0 : (double) bNum * Functions.Factorial(checked (bNum - 1));

    public static bool ErrorCheckNum(string Value, double Min, double Max) => Versioned.IsNumeric((object) Value) && Conversions.ToDouble(Value) >= Min & Conversions.ToDouble(Value) <= Max;

    public static double BlCalc(double Mms, double Re, double Fs, double Qes) => Math.Sqrt(Mms * Re * 2.0 * Math.PI * Fs / Qes);

    public static double CmsCalc(double Vas, double Sd, double SpeedOfSound) => Vas / (Functions.DensityofAir() * Math.Pow(SpeedOfSound, 2.0) * Math.Pow(Sd, 2.0));

    public static double RmsCalc(double Mms, double Fs, double Qms) => 2.0 * Math.PI * Fs * Mms / Qms;

    public static double MmsCalc(double Fs, double Cms) => Math.Pow(1.0 / (2.0 * Math.PI * Fs), 2.0) / Cms;

    public static double QtsCalc(double Qms, double Qes) => Qms * Qes / (Qms + Qes);

    public static double FsCalc(double Cms, double Mms) => 1.0 / (2.0 * Math.PI * Math.Sqrt(Cms * Mms));

    public static double VasCalc(double Sd, double Cms, double SpeedOfSound) => Functions.DensityofAir() * Math.Pow(SpeedOfSound, 2.0) * Math.Pow(Sd, 2.0) * Cms;

    public static double QesCalc(double Fs, double Mms, double Re, double Bl) => 2.0 * Math.PI * Fs * Mms * Re / Math.Pow(Bl, 2.0);

    public static double QmsCalc(double Fs, double Mms, double Rms) => 2.0 * Math.PI * Fs * Mms / Rms;

    public static double ResCalc(double Re, double Qms, double Qes, double Rg) => (Re + Rg) * (Qms / Qes);

    public static double LcesCalc(double Cas, double Bl, double Sd) => Cas * Math.Pow(Bl, 2.0) / Math.Pow(Sd, 2.0);

    public static double CmesCalc(double Mas, double Sd, double Bl) => Mas * Math.Pow(Sd, 2.0) / Math.Pow(Bl, 2.0);

    public static double RasCalc(
      double Bl,
      double Sd,
      double Qes,
      double Rg,
      double Re,
      double Qms)
    {
      return Math.Pow(Bl, 2.0) / Math.Pow(Sd, 2.0) * (Qes / (Qms * (Rg + Re)));
    }

    public static Complex RatCalc(
      double Frequency,
      double Lvc,
      double Ras,
      double Bl,
      double Sd,
      double Rg,
      double Re)
    {
      double num = 2.0 * Math.PI * Frequency;
      return Ras + Math.Pow(Bl, 2.0) / (Math.Pow(Sd, 2.0) * (Rg + Re + Functions.InductorImpedance(Lvc, Frequency)));
    }

    public enum Distance
    {
      Meter = 1,
      Feet = 2,
      Inch = 3,
      Yard = 4,
      Centimeter = 5,
    }

    public enum Mass
    {
      Kilogram = 1,
      Gram = 2,
      Milligram = 3,
      Pound = 4,
    }
  }
}
