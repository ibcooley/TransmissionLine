// Decompiled with JetBrains decompiler
// Type: TransmissionLine.SettingsParameters
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System.Windows.Forms;

namespace TransmissionLine
{
  public struct SettingsParameters
  {
    public string DriverLibrary;
    public double StartFreq;
    public double EndFreq;
    public bool FrequencyLog;
    public double RadiationImpedanceMax;
    public double RadiationImpedanceMin;
    public bool RadiationImpedanceLog;
    public double DriverImpedanceMax;
    public double DriverImpedanceMin;
    public bool DriverImpedanceLog;
    public double InputImpedanceMax;
    public double InputImpedanceMin;
    public bool InputImpedanceLog;
    public double SystemImpedanceMin;
    public double SystemImpedanceMax;
    public bool SystemImpedanceLog;
    public double LwMin;
    public double LwMax;
    public bool LwLog;
    public double PhaseMin;
    public double PhaseMax;
    public bool PhaseLog;
    public double DisplaceMin;
    public double DisplaceMax;
    public bool DisplaceLog;
    public double VelocityMin;
    public double VelocityMax;
    public bool VelocityLog;
    public double GroupDelayMin;
    public double GroupDelayMax;
    public bool GroupDelayLog;
    public int LengthUnit;
    public int StartAreaUnit;
    public int EndAreaUnit;
    public int VolumeUnit;
    public int ElementVolumeUnit;
    public int TotalLengthUnit;
    public int EnclosureDepthUnit;
    public int DensityUnit;
    public bool AutoUpdate;
    public int DisplayLengthUnit;
    public int DisplayAreaUnit;
    public int DisplayAngleUnit;
    public int DisplayLengthPrecision;
    public int DisplayAreaPrecision;
    public int DisplayAnglePrecision;
    public int GeometrySplitterDistance;
    public int GeometryHeight;
    public int GeometryWidth;
    public float GeometryPanUp;
    public float GeometryPanRight;
    public float GeometryScale;
    public bool ShowFront;
    public bool ShowRear;
    public MouseButtons PanMouseButton;
    public int UndoRedoHistory;
    public double SpeedOfSound;
  }
}
