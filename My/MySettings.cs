// Decompiled with JetBrains decompiler
// Type: TransmissionLine.My.MySettings
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace TransmissionLine.My
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(handlerLockObject, ref lockTaken);
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(handlerLockObject);
          }
        }
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }

    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string DriverLibrary
    {
      get => Conversions.ToString(this[nameof (DriverLibrary)]);
      set => this[nameof (DriverLibrary)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("10")]
    public double StartFreq
    {
      get => Conversions.ToDouble(this[nameof (StartFreq)]);
      set => this[nameof (StartFreq)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("1000")]
    [UserScopedSetting]
    public double EndFreq
    {
      get => Conversions.ToDouble(this[nameof (EndFreq)]);
      set => this[nameof (EndFreq)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("12000")]
    public double RadImpMax
    {
      get => Conversions.ToDouble(this[nameof (RadImpMax)]);
      set => this[nameof (RadImpMax)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("0")]
    public double RadImpMin
    {
      get => Conversions.ToDouble(this[nameof (RadImpMin)]);
      set => this[nameof (RadImpMin)] = (object) value;
    }

    [DefaultSettingValue("150")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public double DriverImpMax
    {
      get => Conversions.ToDouble(this[nameof (DriverImpMax)]);
      set => this[nameof (DriverImpMax)] = (object) value;
    }

    [DefaultSettingValue("0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public double DriverImpMin
    {
      get => Conversions.ToDouble(this[nameof (DriverImpMin)]);
      set => this[nameof (DriverImpMin)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("1000")]
    public double InputImpMax
    {
      get => Conversions.ToDouble(this[nameof (InputImpMax)]);
      set => this[nameof (InputImpMax)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("0.1")]
    [DebuggerNonUserCode]
    public double InputImpMin
    {
      get => Conversions.ToDouble(this[nameof (InputImpMin)]);
      set => this[nameof (InputImpMin)] = (object) value;
    }

    [DefaultSettingValue("150")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public double SystemImpMax
    {
      get => Conversions.ToDouble(this[nameof (SystemImpMax)]);
      set => this[nameof (SystemImpMax)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    public double SystemImpMin
    {
      get => Conversions.ToDouble(this[nameof (SystemImpMin)]);
      set => this[nameof (SystemImpMin)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("120")]
    public double LwMax
    {
      get => Conversions.ToDouble(this[nameof (LwMax)]);
      set => this[nameof (LwMax)] = (object) value;
    }

    [DefaultSettingValue("60")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public double LwMin
    {
      get => Conversions.ToDouble(this[nameof (LwMin)]);
      set => this[nameof (LwMin)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("50")]
    [DebuggerNonUserCode]
    public double DisplaceMax
    {
      get => Conversions.ToDouble(this[nameof (DisplaceMax)]);
      set => this[nameof (DisplaceMax)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("0")]
    public double DisplaceMin
    {
      get => Conversions.ToDouble(this[nameof (DisplaceMin)]);
      set => this[nameof (DisplaceMin)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("10")]
    [DebuggerNonUserCode]
    public double VelocityMax
    {
      get => Conversions.ToDouble(this[nameof (VelocityMax)]);
      set => this[nameof (VelocityMax)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("0")]
    public double VelocityMin
    {
      get => Conversions.ToDouble(this[nameof (VelocityMin)]);
      set => this[nameof (VelocityMin)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("100")]
    [DebuggerNonUserCode]
    public double GroupDelayMax
    {
      get => Conversions.ToDouble(this[nameof (GroupDelayMax)]);
      set => this[nameof (GroupDelayMax)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("-100")]
    [UserScopedSetting]
    public double GroupDelayMin
    {
      get => Conversions.ToDouble(this[nameof (GroupDelayMin)]);
      set => this[nameof (GroupDelayMin)] = (object) value;
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("-180")]
    public double PhaseMin => Conversions.ToDouble(this[nameof (PhaseMin)]);

    [ApplicationScopedSetting]
    [DefaultSettingValue("180")]
    [DebuggerNonUserCode]
    public double PhaseMax => Conversions.ToDouble(this[nameof (PhaseMax)]);

    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool FrequencyLog
    {
      get => Conversions.ToBoolean(this[nameof (FrequencyLog)]);
      set => this[nameof (FrequencyLog)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("False")]
    public bool RadiationImpLog
    {
      get => Conversions.ToBoolean(this[nameof (RadiationImpLog)]);
      set => this[nameof (RadiationImpLog)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool DriverImpLog
    {
      get => Conversions.ToBoolean(this[nameof (DriverImpLog)]);
      set => this[nameof (DriverImpLog)] = (object) value;
    }

    [DefaultSettingValue("True")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool InputImpLog
    {
      get => Conversions.ToBoolean(this[nameof (InputImpLog)]);
      set => this[nameof (InputImpLog)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    [UserScopedSetting]
    public bool SystemImpLog
    {
      get => Conversions.ToBoolean(this[nameof (SystemImpLog)]);
      set => this[nameof (SystemImpLog)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    public bool LwLog
    {
      get => Conversions.ToBoolean(this[nameof (LwLog)]);
      set => this[nameof (LwLog)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool PhaseLog
    {
      get => Conversions.ToBoolean(this[nameof (PhaseLog)]);
      set => this[nameof (PhaseLog)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool DisplaceLog
    {
      get => Conversions.ToBoolean(this[nameof (DisplaceLog)]);
      set => this[nameof (DisplaceLog)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("False")]
    public bool VelocityLog
    {
      get => Conversions.ToBoolean(this[nameof (VelocityLog)]);
      set => this[nameof (VelocityLog)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    [UserScopedSetting]
    public bool GroupDelayLog
    {
      get => Conversions.ToBoolean(this[nameof (GroupDelayLog)]);
      set => this[nameof (GroupDelayLog)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    [UserScopedSetting]
    public int LengthUnit
    {
      get => Conversions.ToInteger(this[nameof (LengthUnit)]);
      set => this[nameof (LengthUnit)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int StartAreaUnit
    {
      get => Conversions.ToInteger(this[nameof (StartAreaUnit)]);
      set => this[nameof (StartAreaUnit)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int EndAreaUnit
    {
      get => Conversions.ToInteger(this[nameof (EndAreaUnit)]);
      set => this[nameof (EndAreaUnit)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int VolumeUnit
    {
      get => Conversions.ToInteger(this[nameof (VolumeUnit)]);
      set => this[nameof (VolumeUnit)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int TotalLengthUnit
    {
      get => Conversions.ToInteger(this[nameof (TotalLengthUnit)]);
      set => this[nameof (TotalLengthUnit)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("0, 0")]
    [UserScopedSetting]
    public Point FormLocation
    {
      get
      {
        object obj = this[nameof (FormLocation)];
        Point point = default;
        return obj != null ? (Point) obj : point;
      }
      set => this[nameof (FormLocation)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("1")]
    public int EnclosureDepthUnit
    {
      get => Conversions.ToInteger(this[nameof (EnclosureDepthUnit)]);
      set => this[nameof (EnclosureDepthUnit)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool AutoUpdate
    {
      get => Conversions.ToBoolean(this[nameof (AutoUpdate)]);
      set => this[nameof (AutoUpdate)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int DisplayLengthUnit
    {
      get => Conversions.ToInteger(this[nameof (DisplayLengthUnit)]);
      set => this[nameof (DisplayLengthUnit)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("1")]
    public int DisplayAreaUnit
    {
      get => Conversions.ToInteger(this[nameof (DisplayAreaUnit)]);
      set => this[nameof (DisplayAreaUnit)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    public int DisplayAngleUnit
    {
      get => Conversions.ToInteger(this[nameof (DisplayAngleUnit)]);
      set => this[nameof (DisplayAngleUnit)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("4")]
    [DebuggerNonUserCode]
    public int DisplayLengthPrecision
    {
      get => Conversions.ToInteger(this[nameof (DisplayLengthPrecision)]);
      set => this[nameof (DisplayLengthPrecision)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("4")]
    public int DisplayAreaPrecision
    {
      get => Conversions.ToInteger(this[nameof (DisplayAreaPrecision)]);
      set => this[nameof (DisplayAreaPrecision)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("4")]
    [UserScopedSetting]
    public int DisplayAnglePrecision
    {
      get => Conversions.ToInteger(this[nameof (DisplayAnglePrecision)]);
      set => this[nameof (DisplayAnglePrecision)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    public string LastVersion
    {
      get => Conversions.ToString(this[nameof (LastVersion)]);
      set => this[nameof (LastVersion)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("1")]
    public int ElementVolumeUnit
    {
      get => Conversions.ToInteger(this[nameof (ElementVolumeUnit)]);
      set => this[nameof (ElementVolumeUnit)] = (object) value;
    }

    [DefaultSettingValue("527")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int GeometrySplitterDistance
    {
      get => Conversions.ToInteger(this[nameof (GeometrySplitterDistance)]);
      set => this[nameof (GeometrySplitterDistance)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("0, 0")]
    public Point GeometryDisplayLocation
    {
      get
      {
        object obj = this[nameof (GeometryDisplayLocation)];
        Point point = default;
        return obj != null ? (Point) obj : point;
      }
      set => this[nameof (GeometryDisplayLocation)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("0, 0")]
    [UserScopedSetting]
    public Point AmplifierLocation
    {
      get
      {
        object obj = this[nameof (AmplifierLocation)];
        Point point = default;
        return obj != null ? (Point) obj : point;
      }
      set => this[nameof (AmplifierLocation)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0, 0")]
    public Point DriverLocation
    {
      get
      {
        object obj = this[nameof (DriverLocation)];
        Point point = default;
        return obj != null ? (Point) obj : point;
      }
      set => this[nameof (DriverLocation)] = (object) value;
    }

    [DefaultSettingValue("0, 0")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public Point SettingsLocation
    {
      get
      {
        object obj = this[nameof (SettingsLocation)];
        Point point = default;
        return obj != null ? (Point) obj : point;
      }
      set => this[nameof (SettingsLocation)] = (object) value;
    }

    [DefaultSettingValue("True")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool InfiniteBaffleCheck
    {
      get => Conversions.ToBoolean(this[nameof (InfiniteBaffleCheck)]);
      set => this[nameof (InfiniteBaffleCheck)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    public bool DriverCheck
    {
      get => Conversions.ToBoolean(this[nameof (DriverCheck)]);
      set => this[nameof (DriverCheck)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("False")]
    public bool TerminusCheck
    {
      get => Conversions.ToBoolean(this[nameof (TerminusCheck)]);
      set => this[nameof (TerminusCheck)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool SystemCheck
    {
      get => Conversions.ToBoolean(this[nameof (SystemCheck)]);
      set => this[nameof (SystemCheck)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("370")]
    [DebuggerNonUserCode]
    public int GeometryHeight
    {
      get => Conversions.ToInteger(this[nameof (GeometryHeight)]);
      set => this[nameof (GeometryHeight)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("700")]
    public int GeometryWidth
    {
      get => Conversions.ToInteger(this[nameof (GeometryWidth)]);
      set => this[nameof (GeometryWidth)] = (object) value;
    }

    [DefaultSettingValue("170")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public float GeometryPanUp
    {
      get => Conversions.ToSingle(this[nameof (GeometryPanUp)]);
      set => this[nameof (GeometryPanUp)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("100")]
    public float GeometryPanRight
    {
      get => Conversions.ToSingle(this[nameof (GeometryPanRight)]);
      set => this[nameof (GeometryPanRight)] = (object) value;
    }

    [DefaultSettingValue("4")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public float GeometryScale
    {
      get => Conversions.ToSingle(this[nameof (GeometryScale)]);
      set => this[nameof (GeometryScale)] = (object) value;
    }

    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool ShowFront
    {
      get => Conversions.ToBoolean(this[nameof (ShowFront)]);
      set => this[nameof (ShowFront)] = (object) value;
    }

    [DefaultSettingValue("True")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool ShowRear
    {
      get => Conversions.ToBoolean(this[nameof (ShowRear)]);
      set => this[nameof (ShowRear)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("Middle")]
    [UserScopedSetting]
    public MouseButtons PanMouseButton
    {
      get => (MouseButtons) Conversions.ToInteger(this[nameof (PanMouseButton)]);
      set => this[nameof (PanMouseButton)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    public StringCollection RecentFiles
    {
      get => (StringCollection) this[nameof (RecentFiles)];
      set => this[nameof (RecentFiles)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("4")]
    [DebuggerNonUserCode]
    public int UndoRedoHistory
    {
      get => Conversions.ToInteger(this[nameof (UndoRedoHistory)]);
      set => this[nameof (UndoRedoHistory)] = (object) value;
    }

    [DefaultSettingValue("700")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int Form1Width
    {
      get => Conversions.ToInteger(this[nameof (Form1Width)]);
      set => this[nameof (Form1Width)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("700")]
    [DebuggerNonUserCode]
    public int Form1Height
    {
      get => Conversions.ToInteger(this[nameof (Form1Height)]);
      set => this[nameof (Form1Height)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("343")]
    public double SpeedOfSound
    {
      get => Conversions.ToDouble(this[nameof (SpeedOfSound)]);
      set => this[nameof (SpeedOfSound)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int DensityUnit
    {
      get => Conversions.ToInteger(this[nameof (DensityUnit)]);
      set => this[nameof (DensityUnit)] = (object) value;
    }
  }
}
