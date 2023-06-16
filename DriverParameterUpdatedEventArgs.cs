// Decompiled with JetBrains decompiler
// Type: TransmissionLine.DriverParameterUpdatedEventArgs
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System;

namespace TransmissionLine
{
  public class DriverParameterUpdatedEventArgs : EventArgs
  {
    private DriverParameters NewDriverParameter;
    private DriverSetup NewDriverSetupParameter;

    public DriverParameterUpdatedEventArgs(
      DriverParameters DriverParameter,
      DriverSetup DriverSetupParameter)
    {
      this.NewDriverParameter = DriverParameter;
      this.NewDriverSetupParameter = DriverSetupParameter;
    }

    public DriverParameters ReturnDriverParameter => this.NewDriverParameter;

    public DriverSetup ReturnDriverSetupParameter => this.NewDriverSetupParameter;
  }
}
