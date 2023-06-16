// Decompiled with JetBrains decompiler
// Type: TransmissionLine.myGraph
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System.Drawing;

namespace TransmissionLine
{
  public struct myGraph
  {
    public string Title;
    public string XLabel;
    public string YLabel;
    public double Xmin;
    public double Xmax;
    public double Ymin;
    public double Ymax;
    public bool XLog;
    public bool YLog;
    public int TopMargin;
    public int BottomMargin;
    public int LeftMargin;
    public int RightMargin;
    public GraphSeries Data;
    public Bitmap GraphImage;
    public int PreviousXLine;
    public int[] PreviousYLine;
  }
}
