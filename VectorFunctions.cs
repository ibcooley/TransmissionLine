// Decompiled with JetBrains decompiler
// Type: TransmissionLine.VectorFunctions
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace TransmissionLine
{
  [StandardModule]
  internal sealed class VectorFunctions
  {
    public static Point3D VectorCrossProduct(Point3D V1, Point3D V2)
    {
      Point3D point3D;
      point3D.X = (float) ((double) V1.Y * (double) V2.Z - (double) V2.Y * (double) V1.Z);
      point3D.Y = (float) ((double) V1.Z * (double) V2.X - (double) V2.Z * (double) V1.X);
      point3D.Z = (float) ((double) V1.X * (double) V2.Y - (double) V2.X * (double) V1.Y);
      return point3D;
    }

    public static bool PointInPolygonNew2D(PointF[] Polygon, PointF Point)
    {
      int num1 = 0;
      int upperBound = Polygon.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound)
      {
        int index2 = index1 != Polygon.GetUpperBound(0) ? checked (index1 + 1) : 0;
        if ((double) Polygon[index1].Y <= (double) Point.Y & (double) Polygon[index2].Y > (double) Point.Y | (double) Polygon[index1].Y > (double) Point.Y & (double) Polygon[index2].Y <= (double) Point.Y)
        {
          double num2 = ((double) Point.Y - (double) Polygon[index1].Y) / ((double) Polygon[index2].Y - (double) Polygon[index1].Y);
          if ((double) Point.X < (double) Polygon[index1].X + num2 * ((double) Polygon[index2].X - (double) Polygon[index1].X))
            checked { ++num1; }
        }
        checked { ++index1; }
      }
      return num1 % 2 != 0;
    }

    public static bool PointInPolygonNew3D(Point3D[] Polygon, Point3D Point, int n)
    {
      int num1 = 0;
      Point3D V1;
      V1.X = Polygon[2].X - Polygon[1].X;
      V1.Y = Polygon[2].Y - Polygon[1].Y;
      V1.Z = Polygon[2].Z - Polygon[1].Z;
      Point3D V2;
      V2.X = Polygon[3].X - Polygon[2].X;
      V2.Y = Polygon[3].Y - Polygon[2].Y;
      V2.Z = Polygon[3].Z - Polygon[2].Z;
      Point3D point3D = VectorFunctions.VectorCrossProduct(V1, V2);
      point3D.X = Math.Abs(point3D.X);
      point3D.Y = Math.Abs(point3D.Y);
      point3D.Z = Math.Abs(point3D.Z);
      int num2 = n;
      int index1 = 1;
      while (index1 <= num2)
      {
        int index2 = index1 != n ? checked (index1 + 1) : 1;
        PointF pointF1 = default;
        PointF pointF2 = default;
        PointF pointF3 = default;
        if ((double) point3D.X >= (double) point3D.Y & (double) point3D.X >= (double) point3D.Z)
        {
          pointF1.X = Point.Z;
          pointF1.Y = Point.Y;
          pointF2.X = Polygon[index1].Z;
          pointF2.Y = Polygon[index1].Y;
          pointF3.X = Polygon[index2].Z;
          pointF3.Y = Polygon[index2].Y;
        }
        if ((double) point3D.Y >= (double) point3D.X & (double) point3D.Y >= (double) point3D.Z)
        {
          pointF1.X = Point.X;
          pointF1.Y = Point.Z;
          pointF2.X = Polygon[index1].X;
          pointF2.Y = Polygon[index1].Z;
          pointF3.X = Polygon[index2].X;
          pointF3.Y = Polygon[index2].Z;
        }
        if ((double) point3D.Z >= (double) point3D.Y & (double) point3D.Z >= (double) point3D.X)
        {
          pointF1.X = Point.X;
          pointF1.Y = Point.Y;
          pointF2.X = Polygon[index1].X;
          pointF2.Y = Polygon[index1].Y;
          pointF3.X = Polygon[index2].X;
          pointF3.Y = Polygon[index2].Y;
        }
        if ((double) pointF2.Y <= (double) pointF1.Y & (double) pointF3.Y > (double) pointF1.Y | (double) pointF2.Y > (double) pointF1.Y & (double) pointF3.Y <= (double) pointF1.Y)
        {
          double num3 = ((double) pointF1.Y - (double) pointF2.Y) / ((double) pointF3.Y - (double) pointF2.Y);
          if ((double) pointF1.X < (double) pointF2.X + num3 * ((double) pointF3.X - (double) pointF2.X))
            checked { ++num1; }
        }
        checked { ++index1; }
      }
      return num1 % 2 != 0;
    }
  }
}
