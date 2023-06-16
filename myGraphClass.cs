// Decompiled with JetBrains decompiler
// Type: TransmissionLine.myGraphClass
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace TransmissionLine
{
  public class myGraphClass
  {
    private string Title;
    private string XLabel;
    private string YLabel;
    private double Xmin;
    private double Xmax;
    private double Ymin;
    private double Ymax;
    private bool XLog;
    private bool YLog;
    private int TopMargin;
    private int BottomMargin;
    private int LeftMargin;
    private int RightMargin;
    private GraphSeries Data;
    private Bitmap GraphImage;
    private int PreviousXLine;
    private int[] PreviousYLine;
    private Font TitleFont;
    private Font LabelFont;

    public myGraphClass(
      string vTitle,
      string vXLabel,
      string vYLabel,
      double vXmin,
      double vXmax,
      double vYmin,
      double vYMax,
      bool vXLog,
      bool vYLog,
      int vTopMargin,
      int vBottomMargin,
      int vLeftMargin,
      int vRightMargin)
    {
      this.Title = vTitle;
      this.XLabel = vXLabel;
      this.YLabel = vYLabel;
      this.Xmin = vXmin;
      this.Xmax = vXmax;
      this.Ymin = vYmin;
      this.Ymax = vYMax;
      this.XLog = vXLog;
      this.YLog = vYLog;
      this.TopMargin = vTopMargin;
      this.BottomMargin = vBottomMargin;
      this.LeftMargin = vLeftMargin;
      this.RightMargin = vRightMargin;
      this.TitleFont = new Font("Calibri", 15f, FontStyle.Bold, GraphicsUnit.Pixel);
      this.LabelFont = new Font("Calibri", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
    }

    public GraphSeries SetData
    {
      set => this.Data = value;
    }

    public Bitmap GetImage => this.GraphImage;

    public double get_GetXValue(Point MousePosition, int DisplayWidth, int DisplayHeight)
    {
      Graphics gr = Graphics.FromImage((Image) this.GraphImage);
      int num1 = this.GraphMarginTop(this.TopMargin, this.Title, gr, this.TitleFont, this.LabelFont);
      int num2 = this.GraphMarginBottom(this.BottomMargin, this.Xmax, this.XLabel, gr, this.TitleFont, this.LabelFont);
      int num3 = this.GraphMarginLeft(this.LeftMargin, this.Ymax, this.YLabel, gr, this.TitleFont, this.LabelFont);
      if (!(MousePosition.X > num3 & MousePosition.X < checked (DisplayWidth - this.RightMargin) & MousePosition.Y > num1 & MousePosition.Y < checked (DisplayHeight - num2)))
        return 0.0;
      int num4 = checked (MousePosition.X - num3);
      return !this.XLog ? ((double) num4 - this.Xmin) / (this.Xmax - this.Xmin) * (double) checked (DisplayWidth - num3 - this.RightMargin) : this.Xmin * Math.Pow(2.0, (double) num4 * (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0)) / (double) checked (DisplayWidth - num3 - this.RightMargin));
    }

    public double get_GetYValue(
      Point MousePosition,
      int DisplayWidth,
      int DisplayHeight,
      int YIndex)
    {
      Graphics gr = Graphics.FromImage((Image) this.GraphImage);
      int num1 = this.GraphMarginTop(this.TopMargin, this.Title, gr, this.TitleFont, this.LabelFont);
      int num2 = this.GraphMarginBottom(this.BottomMargin, this.Xmax, this.XLabel, gr, this.TitleFont, this.LabelFont);
      int num3 = this.GraphMarginLeft(this.LeftMargin, this.Ymax, this.YLabel, gr, this.TitleFont, this.LabelFont);
      if (!(MousePosition.X > num3 & MousePosition.X < checked (DisplayWidth - this.RightMargin) & MousePosition.Y > num1 & MousePosition.Y < checked (DisplayHeight - num2)))
        return 0.0;
      int num4 = checked (MousePosition.X - num3);
      double num5 = !this.XLog ? ((double) num4 - this.Xmin) / (this.Xmax - this.Xmin) * (double) checked (DisplayWidth - num3 - this.RightMargin) : this.Xmin * Math.Pow(2.0, (double) num4 * (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0)) / (double) checked (DisplayWidth - num3 - this.RightMargin));
      if (Information.IsNothing((object) this.Data.XSeries))
        return 0.0;
      double d = (double) this.Data.XSeries.GetUpperBound(0) * (Math.Log10(num5 / this.Xmin) / Math.Log10(2.0)) / (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0));
      return this.Data.YSeries[YIndex].Points[checked ((int) Math.Round(Math.Floor(d)))];
    }

    public int NumSeries => this.Data.YSeries.GetUpperBound(0);

    public string get_GetSeriesName(int Index) => this.Data.YSeries[Index].Name;

    private Bitmap DrawDataFunction(int DisplayWidth, int DisplayHeight)
    {
      Bitmap bitmap = new Bitmap(DisplayWidth, DisplayHeight);
      Graphics gr = Graphics.FromImage((Image) bitmap);
      gr.SmoothingMode = SmoothingMode.HighQuality;
      gr.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
      gr.FillRectangle(Brushes.White, 0, 0, DisplayWidth, DisplayHeight);
      gr.DrawImage((Image) this.DrawAxisFunction(DisplayWidth, DisplayHeight), 0, 0);
      int num1 = this.GraphMarginTop(this.TopMargin, this.Title, gr, this.TitleFont, this.LabelFont);
      int num2 = this.GraphMarginBottom(this.BottomMargin, this.Xmax, this.XLabel, gr, this.TitleFont, this.LabelFont);
      int num3 = this.GraphMarginLeft(this.LeftMargin, this.Ymax, this.YLabel, gr, this.TitleFont, this.LabelFont);
      Pen pen1 = new Pen(Brushes.Red);
      int upperBound1 = this.Data.YSeries.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound1)
      {
        pen1.Color = this.Data.YSeries[index1].Color;
        string name = this.Data.YSeries[index1].Name;
        int num4;
        SizeF sizeF;
        int num5 = 0;
        if (index1 == 0)
        {
          num4 = num3;
          int num6 = num3;
          sizeF = gr.MeasureString(name, this.LabelFont);
          int num7 = checked ((int) Math.Round((double) sizeF.Width));
          num5 = checked (num6 + num7);
        }
        else
        {
          num4 = checked (num5 + 5);
          int num8 = checked (num5 + 5);
          sizeF = gr.MeasureString(name, this.LabelFont);
          int num9 = checked ((int) Math.Round((double) sizeF.Width));
          num5 = checked (num8 + num9);
        }
        Graphics graphics1 = gr;
        string s = name;
        Font labelFont = this.LabelFont;
        Brush black = Brushes.Black;
        double x = (double) num4;
        sizeF = gr.MeasureString(this.Title, this.TitleFont);
        double y = (double) sizeF.Height + 1.0;
        graphics1.DrawString(s, labelFont, black, (float) x, (float) y);
        Graphics graphics2 = gr;
        Pen pen2 = pen1;
        double x1 = (double) num4;
        double num10 = (double) gr.MeasureString(this.Title, this.TitleFont).Height + 1.0;
        sizeF = gr.MeasureString(name, this.LabelFont);
        double height = (double) sizeF.Height;
        double y1 = num10 + height;
        double x2 = (double) num5;
        double y2 = (double) gr.MeasureString(this.Title, this.TitleFont).Height + 1.0 + (double) gr.MeasureString(name, this.LabelFont).Height;
        graphics2.DrawLine(pen2, (float) x1, (float) y1, (float) x2, (float) y2);
        checked { ++index1; }
      }
      int upperBound2 = this.Data.YSeries.GetUpperBound(0);
      int index2 = 0;
      while (index2 <= upperBound2)
      {
        pen1.Color = this.Data.YSeries[index2].Color;
        int num11 = checked (this.Data.XSeries.GetUpperBound(0) - 1);
        int index3 = 0;
        while (index3 <= num11)
        {
          if (!(this.Data.YSeries[index2].Points[index3] > this.Ymax | this.Data.YSeries[index2].Points[index3] < this.Ymin | this.Data.YSeries[index2].Points[checked (index3 + 1)] > this.Ymax | this.Data.YSeries[index2].Points[checked (index3 + 1)] < this.Ymin))
          {
            int num12;
            int num13;
            if (this.YLog)
            {
              double num14 = (this.Ymax - this.Ymin) * (Math.Log10(this.Data.YSeries[index2].Points[index3] / this.Ymin) / Math.Log10(2.0)) / (Math.Log10(this.Ymax / this.Ymin) / Math.Log10(2.0));
              num12 = checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num2 - num1) * num14 / (this.Ymax - this.Ymin))));
              double num15 = (this.Ymax - this.Ymin) * (Math.Log10(this.Data.YSeries[index2].Points[checked (index3 + 1)] / this.Ymin) / Math.Log10(2.0)) / (Math.Log10(this.Ymax / this.Ymin) / Math.Log10(2.0));
              num13 = checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num2 - num1) * num15 / (this.Ymax - this.Ymin))));
            }
            else
            {
              double point1 = this.Data.YSeries[index2].Points[index3];
              num12 = checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num2 - num1) * (point1 - this.Ymin) / (this.Ymax - this.Ymin))));
              double point2 = this.Data.YSeries[index2].Points[checked (index3 + 1)];
              num13 = checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num2 - num1) * (point2 - this.Ymin) / (this.Ymax - this.Ymin))));
            }
            int num16;
            int num17;
            if (this.XLog)
            {
              double num18 = (this.Xmax - this.Xmin) * (Math.Log10(this.Data.XSeries[index3] / this.Xmin) / Math.Log10(2.0)) / (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0));
              num16 = checked ((int) Math.Round(unchecked ((double) checked (DisplayWidth - num3 - this.RightMargin) * num18 / (this.Xmax - this.Xmin))));
              double num19 = (this.Xmax - this.Xmin) * (Math.Log10(this.Data.XSeries[checked (index3 + 1)] / this.Xmin) / Math.Log10(2.0)) / (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0));
              num17 = checked ((int) Math.Round(unchecked ((double) checked (DisplayWidth - num3 - this.RightMargin) * num19 / (this.Xmax - this.Xmin))));
            }
            else
            {
              double xsery1 = this.Data.XSeries[index3];
              num16 = checked ((int) Math.Round(unchecked ((double) checked (DisplayWidth - num3 - this.RightMargin) * (xsery1 - this.Xmin) / (this.Xmax - this.Xmin))));
              double xsery2 = this.Data.XSeries[checked (index3 + 1)];
              num17 = checked ((int) Math.Round(unchecked ((double) checked (DisplayWidth - num3 - this.RightMargin) * (xsery2 - this.Xmin) / (this.Xmax - this.Xmin))));
            }
            gr.DrawLine(pen1, checked (num16 + num3), checked (DisplayHeight - num12 - num2), checked (num17 + num3), checked (DisplayHeight - num13 - num2));
          }
          checked { ++index3; }
        }
        checked { ++index2; }
      }
      return bitmap;
    }

    private Bitmap DrawAxisFunction(int DisplayWidth, int DisplayHeight)
    {
      Bitmap bitmap = new Bitmap(DisplayWidth, DisplayHeight);
      Graphics gr = Graphics.FromImage((Image) bitmap);
      gr.SmoothingMode = SmoothingMode.HighQuality;
      gr.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
      gr.FillRectangle(Brushes.White, 0, 0, DisplayWidth, DisplayHeight);
      int y1 = this.GraphMarginTop(this.TopMargin, this.Title, gr, this.TitleFont, this.LabelFont);
      int num1 = this.GraphMarginBottom(this.BottomMargin, this.Xmax, this.XLabel, gr, this.TitleFont, this.LabelFont);
      int num2 = this.GraphMarginLeft(this.LeftMargin, this.Ymax, this.YLabel, gr, this.TitleFont, this.LabelFont);
      gr.DrawString(this.XLabel, this.LabelFont, Brushes.Black, (float) (((double) checked (DisplayWidth - num2 - this.RightMargin) - (double) gr.MeasureString(this.XLabel, this.LabelFont).Width) / 2.0) + (float) num2, (float) checked (DisplayHeight - num1 + 5) + gr.MeasureString(this.XLabel, this.LabelFont).Height);
      gr.TranslateTransform((float) this.LeftMargin, (float) checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num1 - y1) / 2.0)) + num1));
      gr.RotateTransform(-90f);
      gr.DrawString(this.YLabel, this.LabelFont, Brushes.Black, -0.5f * gr.MeasureString(this.YLabel, this.LabelFont).Width, 0.0f * gr.MeasureString(this.YLabel, this.LabelFont).Height);
      gr.ResetTransform();
      gr.DrawString(this.Title, this.TitleFont, Brushes.Black, (float) (((double) DisplayWidth - (double) gr.MeasureString(this.Title, this.TitleFont).Width) / 2.0), 3f);
      SizeF sizeF;
      if (this.YLog)
      {
        double num3 = 0.01;
        double num4 = 0.01;
        double num5 = 0.1;
        while (this.Ymax > num5)
        {
          num3 *= 10.0;
          num4 *= 10.0;
          num5 *= 10.0;
          if (this.Ymin < num5 & this.Ymax > num4)
          {
            int num6 = checked ((int) Math.Round(Math.Floor(unchecked (num5 - num4 / num3))));
            int num7 = 0;
            while (num7 <= num6)
            {
              double num8 = num4 + (double) num7 * num3;
              if (num8 >= this.Ymin & num8 <= this.Ymax)
              {
                double num9 = (this.Ymax - this.Ymin) * (Math.Log10(num8 / this.Ymin) / Math.Log10(2.0)) / (Math.Log10(this.Ymax / this.Ymin) / Math.Log10(2.0));
                int num10 = checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num1 - y1) * num9 / (this.Ymax - this.Ymin))));
                gr.DrawLine(Pens.Gray, checked (num2 - 5), checked (DisplayHeight - num1 - num10), checked (DisplayWidth - this.RightMargin), checked (DisplayHeight - num1 - num10));
                if (num7 == 0)
                {
                  Graphics graphics = gr;
                  string s = Conversions.ToString(num4);
                  Font labelFont = this.LabelFont;
                  Brush gray = Brushes.Gray;
                  double num11 = (double) num2;
                  sizeF = gr.MeasureString(Conversions.ToString(num4), this.LabelFont);
                  double width = (double) sizeF.Width;
                  double x = num11 - width - 5.0;
                  double y = (double) checked (DisplayHeight - num1 - num10) - 0.5 * (double) gr.MeasureString(Conversions.ToString(num4), this.LabelFont).Height;
                  graphics.DrawString(s, labelFont, gray, (float) x, (float) y);
                }
              }
              checked { ++num7; }
            }
          }
        }
      }
      else
      {
        double num12 = Math.Ceiling((this.Ymax - this.Ymin) / 10.0);
        int num13 = checked ((int) Math.Round(Math.Ceiling(unchecked (this.Ymax - this.Ymin / num12))));
        int num14 = 0;
        while (num14 <= num13)
        {
          double num15 = this.Ymin + (double) num14 * num12;
          if (num15 > this.Ymax)
            num15 = this.Ymax;
          int num16 = checked ((int) Math.Round(unchecked ((double) checked (DisplayHeight - num1 - y1) * (num15 - this.Ymin) / (this.Ymax - this.Ymin))));
          gr.DrawLine(Pens.Gray, checked (num2 - 5), checked (DisplayHeight - num1 - num16), checked (DisplayWidth - this.RightMargin), checked (DisplayHeight - num1 - num16));
          gr.DrawString(Conversions.ToString(num15), this.LabelFont, Brushes.Gray, (float) ((double) num2 - (double) gr.MeasureString(Conversions.ToString(num15), this.LabelFont).Width - 5.0), (float) checked (DisplayHeight - num1 - num16) - 0.5f * gr.MeasureString(Conversions.ToString(num15), this.LabelFont).Height);
          checked { ++num14; }
        }
      }
      if (this.XLog)
      {
        double num17 = 0.01;
        double num18 = 0.01;
        double num19 = 0.1;
        while (this.Xmax > num19)
        {
          num17 *= 10.0;
          num18 *= 10.0;
          num19 *= 10.0;
          if (this.Xmin < num19 & this.Xmax > num18)
          {
            int num20 = checked ((int) Math.Round(Math.Floor(unchecked (num19 - num18 / num17))));
            int num21 = 0;
            while (num21 <= num20)
            {
              double num22 = num18 + (double) num21 * num17;
              if (num22 >= this.Xmin & num22 <= this.Xmax)
              {
                double num23 = (this.Xmax - this.Xmin) * (Math.Log10(num22 / this.Xmin) / Math.Log10(2.0)) / (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0));
                int num24 = checked ((int) Math.Round(unchecked ((double) checked (DisplayWidth - num2 - this.RightMargin) * num23 / (this.Xmax - this.Xmin))));
                gr.DrawLine(Pens.Gray, checked (num24 + num2), y1, checked (num24 + num2), checked (DisplayHeight - num1 + 5));
                if (num21 == 0 | num21 == 4)
                {
                  Graphics graphics = gr;
                  string s = Conversions.ToString(num22);
                  Font labelFont = this.LabelFont;
                  Brush gray = Brushes.Gray;
                  double num25 = (double) checked (num24 + num2);
                  sizeF = gr.MeasureString(Conversions.ToString(num18), this.LabelFont);
                  double num26 = -0.5 * (double) sizeF.Width;
                  double x = num25 + num26;
                  double y = (double) checked (DisplayHeight - num1 + 5);
                  graphics.DrawString(s, labelFont, gray, (float) x, (float) y);
                }
              }
              checked { ++num21; }
            }
          }
        }
      }
      else
      {
        double num27 = Math.Ceiling((this.Xmax - this.Xmin) / 10.0);
        int num28 = checked ((int) Math.Round(Math.Ceiling(unchecked (this.Xmax - this.Xmin / num27))));
        int num29 = 0;
        while (num29 <= num28)
        {
          double num30 = this.Xmin + (double) num29 * num27;
          if (num30 > this.Xmax)
            num30 = this.Xmax;
          int num31 = checked ((int) Math.Round(unchecked ((double) checked (DisplayWidth - num2 - this.RightMargin) * (num30 - this.Xmin) / (this.Xmax - this.Xmin))));
          gr.DrawLine(Pens.Gray, checked (num31 + num2), y1, checked (num31 + num2), checked (DisplayHeight - num1 + 5));
          Graphics graphics = gr;
          string s = Conversions.ToString(num30);
          Font labelFont = this.LabelFont;
          Brush gray = Brushes.Gray;
          double num32 = (double) checked (num31 + num2);
          sizeF = gr.MeasureString(Conversions.ToString(num30), this.LabelFont);
          double num33 = -0.5 * (double) sizeF.Width;
          double x = num32 + num33;
          double y = (double) checked (DisplayHeight - num1 + 5);
          graphics.DrawString(s, labelFont, gray, (float) x, (float) y);
          checked { ++num29; }
        }
      }
      return bitmap;
    }

    private int GraphMarginTop(
      int TopMargin,
      string Title,
      Graphics gr,
      Font TitleFont,
      Font LabelFont)
    {
      return checked (TopMargin + (int) Math.Round((double) gr.MeasureString(Title, TitleFont).Height) + (int) Math.Round((double) gr.MeasureString("blah", LabelFont).Height) + 6);
    }

    private int GraphMarginBottom(
      int BottomMargin,
      double Xmax,
      string XLabel,
      Graphics gr,
      Font TitleFont,
      Font LabelFont)
    {
      return checked (BottomMargin + (int) Math.Round((double) gr.MeasureString(Xmax.ToString(), TitleFont).Height) + 5 + (int) Math.Round((double) gr.MeasureString(XLabel, LabelFont).Height));
    }

    private int GraphMarginLeft(
      int LeftMargin,
      double Ymax,
      string YLabel,
      Graphics gr,
      Font TitleFont,
      Font LabelFont)
    {
      return checked (LeftMargin + (int) Math.Round((double) gr.MeasureString(Ymax.ToString(), TitleFont).Width) + 5 + (int) Math.Round((double) gr.MeasureString(YLabel, LabelFont).Height));
    }

    public void DrawCursorLine(Point MousePosition, ref PictureBox DisplayBox)
    {
      Graphics gr = Graphics.FromImage(DisplayBox.Image);
      int y1 = this.GraphMarginTop(this.TopMargin, this.Title, gr, this.TitleFont, this.LabelFont);
      int num1 = this.GraphMarginBottom(this.BottomMargin, this.Xmax, this.XLabel, gr, this.TitleFont, this.LabelFont);
      int x1 = this.GraphMarginLeft(this.LeftMargin, this.Ymax, this.YLabel, gr, this.TitleFont, this.LabelFont);
      if (this.PreviousXLine > x1 & this.PreviousXLine < checked (DisplayBox.Width - this.RightMargin))
      {
        Rectangle rectangle = default;
        rectangle.X = this.PreviousXLine;
        rectangle.Y = y1;
        rectangle.Width = 1;
        rectangle.Height = checked (DisplayBox.Height - num1);
        gr.DrawImage((Image) Functions.BitMapRegionFill(rectangle, this.GraphImage), rectangle.X, rectangle.Y);
        DisplayBox.Invalidate(rectangle);
      }
      int num2 = !Information.IsNothing((object) this.PreviousYLine) ? this.PreviousYLine.GetUpperBound(0) : -1;
      int index1 = 0;
      while (index1 <= num2)
      {
        if (this.PreviousYLine[index1] > y1 & this.PreviousYLine[index1] < checked (DisplayBox.Height - num1))
        {
          Rectangle rectangle = default;
          rectangle.X = x1;
          rectangle.Y = this.PreviousYLine[index1];
          rectangle.Width = checked (DisplayBox.Width - this.RightMargin);
          rectangle.Height = 1;
          gr.DrawImage((Image) Functions.BitMapRegionFill(rectangle, this.GraphImage), rectangle.X, rectangle.Y);
          DisplayBox.Invalidate(rectangle);
        }
        checked { ++index1; }
      }
      if (MousePosition.X > x1 & MousePosition.X < checked (DisplayBox.Width - this.RightMargin) & MousePosition.Y > y1 & MousePosition.Y < checked (DisplayBox.Height - num1))
      {
        Pen pen = new Pen(Brushes.Red);
        int num3 = checked (MousePosition.X - x1);
        double num4 = !this.XLog ? ((double) num3 - this.Xmin) / (this.Xmax - this.Xmin) * (double) checked (DisplayBox.Width - x1 - this.RightMargin) : this.Xmin * Math.Pow(2.0, (double) num3 * (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0)) / (double) checked (DisplayBox.Width - x1 - this.RightMargin));
        if (!Information.IsNothing((object) this.Data.XSeries))
        {
          double d1 = (double) this.Data.XSeries.GetUpperBound(0) * (Math.Log10(num4 / this.Xmin) / Math.Log10(2.0)) / (Math.Log10(this.Xmax / this.Xmin) / Math.Log10(2.0));
          this.PreviousYLine = new int[checked (this.Data.YSeries.GetUpperBound(0) + 1)];
          int upperBound = this.Data.YSeries.GetUpperBound(0);
          int index2 = 0;
          while (index2 <= upperBound)
          {
            double d2 = this.Data.YSeries[index2].Points[checked ((int) Math.Round(Math.Floor(d1)))];
            if (double.IsNegativeInfinity(d2))
              d2 = -1000.0;
            else if (double.IsPositiveInfinity(d2))
              d2 = 1000.0;
            int num5 = !this.YLog ? checked ((int) Math.Round(unchecked ((d2 - this.Ymin) / (this.Ymax - this.Ymin) * (double) checked (DisplayBox.Height - y1 - num1)))) : checked ((int) Math.Round(unchecked (Math.Log10(d2 / this.Ymin) / Math.Log10(2.0) / (Math.Log10(this.Ymax / this.Ymin) / Math.Log10(2.0)) * (double) checked (DisplayBox.Height - y1 - num1))));
            if (num5 > 0 & num5 < checked (DisplayBox.Height - y1 - num1))
            {
              pen.Color = this.Data.YSeries[index2].Color;
              gr.DrawLine(pen, x1, checked (DisplayBox.Height - num1 - num5), checked (DisplayBox.Width - this.RightMargin), checked (DisplayBox.Height - num1 - num5));
              Rectangle rc = default;
              rc.X = x1;
              rc.Y = checked (DisplayBox.Height - num1 - num5);
              rc.Width = checked (DisplayBox.Width - this.RightMargin);
              rc.Height = 1;
              DisplayBox.Invalidate(rc);
            }
            this.PreviousYLine[index2] = checked (DisplayBox.Height - num1 - num5);
            checked { ++index2; }
          }
        }
        pen.Dispose();
        gr.DrawLine(Pens.Red, MousePosition.X, y1, MousePosition.X, checked (DisplayBox.Height - num1));
        Rectangle rc1 = default;
        rc1.X = MousePosition.X;
        rc1.Y = y1;
        rc1.Width = 1;
        rc1.Height = checked (DisplayBox.Height - num1);
        DisplayBox.Invalidate(rc1);
      }
      gr.Dispose();
      this.PreviousXLine = MousePosition.X;
    }

    public void DrawAxis(int DisplayWidth, int DisplayHeight) => this.GraphImage = this.DrawAxisFunction(DisplayWidth, DisplayHeight);

    public void DrawData(int DisplayWidth, int DisplayHeight) => this.GraphImage = this.DrawDataFunction(DisplayWidth, DisplayHeight);
  }
}
