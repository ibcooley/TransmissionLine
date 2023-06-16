// Decompiled with JetBrains decompiler
// Type: TransmissionLine.DriverParameters
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

namespace TransmissionLine
{
  public struct DriverParameters
  {
    public string Title;
    public string FilePath;
    public double Sd;
    public double Qes;
    public double Qms;
    public double Lvc;
    public double Re;
    public double Fs;
    public double Vas;

    public double Qts => Functions.QtsCalc(this.Qms, this.Qes);

    public double get_Cms(double SpeedofSound) => Functions.CmsCalc(this.Vas, this.Sd, SpeedofSound);

    public double get_Mms(double SpeedofSound) => Functions.MmsCalc(this.Fs, this.get_Cms(SpeedofSound));

    public double get_Bl(double SpeedofSound) => Functions.BlCalc(this.get_Mms(SpeedofSound), this.Re, this.Fs, this.Qes);

    public double get_Rms(double SpeedofSound) => Functions.RmsCalc(this.get_Mms(SpeedofSound), this.Fs, this.Qms);
  }
}
