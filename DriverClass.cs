// Decompiled with JetBrains decompiler
// Type: TransmissionLine.DriverClass
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using TransmissionLine.My;

namespace TransmissionLine
{
  [DesignerGenerated]
  public class DriverClass : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("LvcBox")]
    private TextBox _LvcBox;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("SdBox")]
    private TextBox _SdBox;
    [AccessedThroughProperty("BlBox")]
    private TextBox _BlBox;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("MmsBox")]
    private TextBox _MmsBox;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("QesBox")]
    private TextBox _QesBox;
    [AccessedThroughProperty("CmsBox")]
    private TextBox _CmsBox;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("QmsBox")]
    private TextBox _QmsBox;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("ReBox")]
    private TextBox _ReBox;
    [AccessedThroughProperty("UpdateButton")]
    private Button _UpdateButton;
    [AccessedThroughProperty("QtsBox")]
    private TextBox _QtsBox;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("VasBox")]
    private TextBox _VasBox;
    [AccessedThroughProperty("FsBox")]
    private TextBox _FsBox;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("IsobaricBox")]
    private CheckBox _IsobaricBox;
    [AccessedThroughProperty("RmsBox")]
    private TextBox _RmsBox;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("IsobaricParallelBox")]
    private RadioButton _IsobaricParallelBox;
    [AccessedThroughProperty("IsobaricSeriesBox")]
    private RadioButton _IsobaricSeriesBox;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("DriverLibListbox")]
    private ListBox _DriverLibListbox;
    [AccessedThroughProperty("DriverTitleBox")]
    private TextBox _DriverTitleBox;
    [AccessedThroughProperty("DriverLibraryGroup")]
    private GroupBox _DriverLibraryGroup;
    [AccessedThroughProperty("SaveAsButton")]
    private Button _SaveAsButton;
    [AccessedThroughProperty("SaveButton")]
    private Button _SaveButton;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("VasUnitLabel")]
    private Label _VasUnitLabel;
    [AccessedThroughProperty("FsUnitLabel")]
    private Label _FsUnitLabel;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("MmsUnitLabel")]
    private Label _MmsUnitLabel;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("LvcUnitLabel")]
    private Label _LvcUnitLabel;
    [AccessedThroughProperty("SdUnitLabel")]
    private Label _SdUnitLabel;
    private bool FormShown;
    private int LvcUnit;
    private int FsUnit;
    private int SdUnit;
    private int VasUnit;
    private int MmsUnit;
    private DriverParameters[] DriverLibrary;
    private DriverParameters DriverParameterEdit;
    private DriverSetup DriverSetupParameterEdit;
    private SettingsParameters SettingsParameterEdit;

    [DebuggerNonUserCode]
    static DriverClass()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (DriverClass.__ENCList)
      {
        if (DriverClass.__ENCList.Count == DriverClass.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (DriverClass.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (DriverClass.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                DriverClass.__ENCList[index1] = DriverClass.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          DriverClass.__ENCList.RemoveRange(index1, checked (DriverClass.__ENCList.Count - index1));
          DriverClass.__ENCList.Capacity = DriverClass.__ENCList.Count;
        }
        DriverClass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.GroupBox1 = new GroupBox();
      this.DriverTitleBox = new TextBox();
      this.RmsBox = new TextBox();
      this.VasBox = new TextBox();
      this.FsBox = new TextBox();
      this.QtsBox = new TextBox();
      this.LvcBox = new TextBox();
      this.Label8 = new Label();
      this.SdBox = new TextBox();
      this.BlBox = new TextBox();
      this.Label23 = new Label();
      this.Label9 = new Label();
      this.MmsBox = new TextBox();
      this.VasUnitLabel = new Label();
      this.Label6 = new Label();
      this.FsUnitLabel = new Label();
      this.Label2 = new Label();
      this.Label20 = new Label();
      this.Label7 = new Label();
      this.QesBox = new TextBox();
      this.CmsBox = new TextBox();
      this.Label19 = new Label();
      this.Label12 = new Label();
      this.MmsUnitLabel = new Label();
      this.Label10 = new Label();
      this.Label17 = new Label();
      this.LvcUnitLabel = new Label();
      this.Label3 = new Label();
      this.Label11 = new Label();
      this.QmsBox = new TextBox();
      this.Label1 = new Label();
      this.SdUnitLabel = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.ReBox = new TextBox();
      this.IsobaricBox = new CheckBox();
      this.UpdateButton = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.IsobaricSeriesBox = new RadioButton();
      this.IsobaricParallelBox = new RadioButton();
      this.GroupBox2 = new GroupBox();
      this.DriverLibListbox = new ListBox();
      this.DriverLibraryGroup = new GroupBox();
      this.SaveAsButton = new Button();
      this.SaveButton = new Button();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.DriverLibraryGroup.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox1.Controls.Add((Control) this.DriverTitleBox);
      this.GroupBox1.Controls.Add((Control) this.RmsBox);
      this.GroupBox1.Controls.Add((Control) this.VasBox);
      this.GroupBox1.Controls.Add((Control) this.FsBox);
      this.GroupBox1.Controls.Add((Control) this.QtsBox);
      this.GroupBox1.Controls.Add((Control) this.LvcBox);
      this.GroupBox1.Controls.Add((Control) this.Label8);
      this.GroupBox1.Controls.Add((Control) this.SdBox);
      this.GroupBox1.Controls.Add((Control) this.BlBox);
      this.GroupBox1.Controls.Add((Control) this.Label23);
      this.GroupBox1.Controls.Add((Control) this.Label9);
      this.GroupBox1.Controls.Add((Control) this.MmsBox);
      this.GroupBox1.Controls.Add((Control) this.VasUnitLabel);
      this.GroupBox1.Controls.Add((Control) this.Label6);
      this.GroupBox1.Controls.Add((Control) this.FsUnitLabel);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.Label20);
      this.GroupBox1.Controls.Add((Control) this.Label7);
      this.GroupBox1.Controls.Add((Control) this.QesBox);
      this.GroupBox1.Controls.Add((Control) this.CmsBox);
      this.GroupBox1.Controls.Add((Control) this.Label19);
      this.GroupBox1.Controls.Add((Control) this.Label12);
      this.GroupBox1.Controls.Add((Control) this.MmsUnitLabel);
      this.GroupBox1.Controls.Add((Control) this.Label10);
      this.GroupBox1.Controls.Add((Control) this.Label17);
      this.GroupBox1.Controls.Add((Control) this.LvcUnitLabel);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Controls.Add((Control) this.Label11);
      this.GroupBox1.Controls.Add((Control) this.QmsBox);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.SdUnitLabel);
      this.GroupBox1.Controls.Add((Control) this.Label5);
      this.GroupBox1.Controls.Add((Control) this.Label4);
      this.GroupBox1.Controls.Add((Control) this.ReBox);
      GroupBox groupBox1_1 = this.GroupBox1;
      Point point1 = new Point(12, 12);
      Point point2 = point1;
      groupBox1_1.Location = point2;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      Size size1 = new Size(147, 362);
      Size size2 = size1;
      groupBox1_2.Size = size2;
      this.GroupBox1.TabIndex = 11;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Driver Parameters";
      TextBox driverTitleBox1 = this.DriverTitleBox;
      point1 = new Point(4, 19);
      Point point3 = point1;
      driverTitleBox1.Location = point3;
      this.DriverTitleBox.Name = "DriverTitleBox";
      TextBox driverTitleBox2 = this.DriverTitleBox;
      size1 = new Size(126, 20);
      Size size3 = size1;
      driverTitleBox2.Size = size3;
      this.DriverTitleBox.TabIndex = 0;
      this.DriverTitleBox.Text = "0";
      TextBox rmsBox1 = this.RmsBox;
      point1 = new Point(39, 334);
      Point point4 = point1;
      rmsBox1.Location = point4;
      this.RmsBox.Name = "RmsBox";
      this.RmsBox.ReadOnly = true;
      TextBox rmsBox2 = this.RmsBox;
      size1 = new Size(56, 20);
      Size size4 = size1;
      rmsBox2.Size = size4;
      this.RmsBox.TabIndex = 12;
      this.RmsBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.RmsBox, "Mechanical resistance of the driver's moving parts");
      TextBox vasBox1 = this.VasBox;
      point1 = new Point(39, 308);
      Point point5 = point1;
      vasBox1.Location = point5;
      this.VasBox.Name = "VasBox";
      TextBox vasBox2 = this.VasBox;
      size1 = new Size(56, 20);
      Size size5 = size1;
      vasBox2.Size = size5;
      this.VasBox.TabIndex = 11;
      this.VasBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.VasBox, "Volume of air having the same stiffness as the driver's suspension.");
      TextBox fsBox1 = this.FsBox;
      point1 = new Point(39, 281);
      Point point6 = point1;
      fsBox1.Location = point6;
      this.FsBox.Name = "FsBox";
      TextBox fsBox2 = this.FsBox;
      size1 = new Size(56, 20);
      Size size6 = size1;
      fsBox2.Size = size6;
      this.FsBox.TabIndex = 10;
      this.FsBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.FsBox, "Driver resonant frequency.");
      TextBox qtsBox1 = this.QtsBox;
      point1 = new Point(39, 149);
      Point point7 = point1;
      qtsBox1.Location = point7;
      this.QtsBox.Name = "QtsBox";
      this.QtsBox.ReadOnly = true;
      TextBox qtsBox2 = this.QtsBox;
      size1 = new Size(56, 20);
      Size size7 = size1;
      qtsBox2.Size = size7;
      this.QtsBox.TabIndex = 5;
      this.QtsBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.QtsBox, "Unitless measurement, describing the combined electric and mechanical damping");
      TextBox lvcBox1 = this.LvcBox;
      point1 = new Point(38, 228);
      Point point8 = point1;
      lvcBox1.Location = point8;
      this.LvcBox.Name = "LvcBox";
      TextBox lvcBox2 = this.LvcBox;
      size1 = new Size(57, 20);
      Size size8 = size1;
      lvcBox2.Size = size8;
      this.LvcBox.TabIndex = 8;
      this.LvcBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.LvcBox, "Voice coil inductance");
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label8_1 = this.Label8;
      point1 = new Point(6, 126);
      Point point9 = point1;
      label8_1.Location = point9;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(28, 13);
      Size size9 = size1;
      label8_2.Size = size9;
      this.Label8.TabIndex = 3;
      this.Label8.Text = "Qms";
      TextBox sdBox1 = this.SdBox;
      point1 = new Point(38, 71);
      Point point10 = point1;
      sdBox1.Location = point10;
      this.SdBox.Name = "SdBox";
      TextBox sdBox2 = this.SdBox;
      size1 = new Size(57, 20);
      Size size10 = size1;
      sdBox2.Size = size10;
      this.SdBox.TabIndex = 2;
      this.SdBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.SdBox, "Projected area of the driver diaphragm.");
      TextBox blBox1 = this.BlBox;
      point1 = new Point(38, 45);
      Point point11 = point1;
      blBox1.Location = point11;
      this.BlBox.Name = "BlBox";
      this.BlBox.ReadOnly = true;
      TextBox blBox2 = this.BlBox;
      size1 = new Size(57, 20);
      Size size11 = size1;
      blBox2.Size = size11;
      this.BlBox.TabIndex = 1;
      this.BlBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.BlBox, "Force Factor:\r\nProduct of the magnet field strength in the voice coil gap\r\n and the length of wire in the magnetic field.");
      this.Label23.AutoSize = true;
      this.Label23.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label23_1 = this.Label23;
      point1 = new Point(101, 178);
      Point point12 = point1;
      label23_1.Location = point12;
      this.Label23.Name = "Label23";
      Label label23_2 = this.Label23;
      size1 = new Size(27, 13);
      Size size12 = size1;
      label23_2.Size = size12;
      this.Label23.TabIndex = 3;
      this.Label23.Text = "m/N";
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label9_1 = this.Label9;
      point1 = new Point(6, 178);
      Point point13 = point1;
      label9_1.Location = point13;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(27, 13);
      Size size13 = size1;
      label9_2.Size = size13;
      this.Label9.TabIndex = 3;
      this.Label9.Text = "Cms";
      TextBox mmsBox1 = this.MmsBox;
      point1 = new Point(38, 201);
      Point point14 = point1;
      mmsBox1.Location = point14;
      this.MmsBox.Name = "MmsBox";
      this.MmsBox.ReadOnly = true;
      TextBox mmsBox2 = this.MmsBox;
      size1 = new Size(57, 20);
      Size size14 = size1;
      mmsBox2.Size = size14;
      this.MmsBox.TabIndex = 7;
      this.MmsBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.MmsBox, "Mechanical mass of the driver's moving parts");
      this.VasUnitLabel.AutoSize = true;
      this.VasUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label vasUnitLabel1 = this.VasUnitLabel;
      point1 = new Point(101, 312);
      Point point15 = point1;
      vasUnitLabel1.Location = point15;
      this.VasUnitLabel.Name = "VasUnitLabel";
      Label vasUnitLabel2 = this.VasUnitLabel;
      size1 = new Size(20, 13);
      Size size15 = size1;
      vasUnitLabel2.Size = size15;
      this.VasUnitLabel.TabIndex = 3;
      this.VasUnitLabel.Text = "m\u00B3";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label6_1 = this.Label6;
      point1 = new Point(6, 312);
      Point point16 = point1;
      label6_1.Location = point16;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(23, 13);
      Size size16 = size1;
      label6_2.Size = size16;
      this.Label6.TabIndex = 3;
      this.Label6.Text = "Vas";
      this.FsUnitLabel.AutoSize = true;
      this.FsUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label fsUnitLabel1 = this.FsUnitLabel;
      point1 = new Point(101, 285);
      Point point17 = point1;
      fsUnitLabel1.Location = point17;
      this.FsUnitLabel.Name = "FsUnitLabel";
      Label fsUnitLabel2 = this.FsUnitLabel;
      size1 = new Size(18, 13);
      Size size17 = size1;
      fsUnitLabel2.Size = size17;
      this.FsUnitLabel.TabIndex = 3;
      this.FsUnitLabel.Text = "Hz";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(6, 285);
      Point point18 = point1;
      label2_1.Location = point18;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(17, 13);
      Size size18 = size1;
      label2_2.Size = size18;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Fs";
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label20_1 = this.Label20;
      point1 = new Point(101, 257);
      Point point19 = point1;
      label20_1.Location = point19;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(14, 13);
      Size size19 = size1;
      label20_2.Size = size19;
      this.Label20.TabIndex = 3;
      this.Label20.Text = "Ω";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label7_1 = this.Label7;
      point1 = new Point(6, 257);
      Point point20 = point1;
      label7_1.Location = point20;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(19, 13);
      Size size20 = size1;
      label7_2.Size = size20;
      this.Label7.TabIndex = 3;
      this.Label7.Text = "Re";
      TextBox qesBox1 = this.QesBox;
      point1 = new Point(38, 97);
      Point point21 = point1;
      qesBox1.Location = point21;
      this.QesBox.Name = "QesBox";
      TextBox qesBox2 = this.QesBox;
      size1 = new Size(57, 20);
      Size size21 = size1;
      qesBox2.Size = size21;
      this.QesBox.TabIndex = 3;
      this.QesBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.QesBox, "Unitless measurement, describing electrical damping");
      TextBox cmsBox1 = this.CmsBox;
      point1 = new Point(38, 175);
      Point point22 = point1;
      cmsBox1.Location = point22;
      this.CmsBox.Name = "CmsBox";
      this.CmsBox.ReadOnly = true;
      TextBox cmsBox2 = this.CmsBox;
      size1 = new Size(57, 20);
      Size size22 = size1;
      cmsBox2.Size = size22;
      this.CmsBox.TabIndex = 6;
      this.CmsBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.CmsBox, "Mechanical compliance of the driver suspension.");
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label19_1 = this.Label19;
      point1 = new Point(101, 338);
      Point point23 = point1;
      label19_1.Location = point23;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(35, 13);
      Size size23 = size1;
      label19_2.Size = size23;
      this.Label19.TabIndex = 3;
      this.Label19.Text = "N.s/m";
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label12_1 = this.Label12;
      point1 = new Point(6, 338);
      Point point24 = point1;
      label12_1.Location = point24;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(27, 13);
      Size size24 = size1;
      label12_2.Size = size24;
      this.Label12.TabIndex = 3;
      this.Label12.Text = "Rms";
      this.MmsUnitLabel.AutoSize = true;
      this.MmsUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label mmsUnitLabel1 = this.MmsUnitLabel;
      point1 = new Point(101, 204);
      Point point25 = point1;
      mmsUnitLabel1.Location = point25;
      this.MmsUnitLabel.Name = "MmsUnitLabel";
      Label mmsUnitLabel2 = this.MmsUnitLabel;
      size1 = new Size(17, 13);
      Size size25 = size1;
      mmsUnitLabel2.Size = size25;
      this.MmsUnitLabel.TabIndex = 3;
      this.MmsUnitLabel.Text = "kg";
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label10_1 = this.Label10;
      point1 = new Point(6, 204);
      Point point26 = point1;
      label10_1.Location = point26;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(30, 13);
      Size size26 = size1;
      label10_2.Size = size26;
      this.Label10.TabIndex = 3;
      this.Label10.Text = "Mms";
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label17_1 = this.Label17;
      point1 = new Point(101, 52);
      Point point27 = point1;
      label17_1.Location = point27;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(23, 13);
      Size size27 = size1;
      label17_2.Size = size27;
      this.Label17.TabIndex = 3;
      this.Label17.Text = "T.m";
      this.LvcUnitLabel.AutoSize = true;
      this.LvcUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label lvcUnitLabel1 = this.LvcUnitLabel;
      point1 = new Point(101, 231);
      Point point28 = point1;
      lvcUnitLabel1.Location = point28;
      this.LvcUnitLabel.Name = "LvcUnitLabel";
      Label lvcUnitLabel2 = this.LvcUnitLabel;
      size1 = new Size(14, 13);
      Size size28 = size1;
      lvcUnitLabel2.Size = size28;
      this.LvcUnitLabel.TabIndex = 3;
      this.LvcUnitLabel.Text = "H";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(6, 52);
      Point point29 = point1;
      label3_1.Location = point29;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(16, 13);
      Size size29 = size1;
      label3_2.Size = size29;
      this.Label3.TabIndex = 3;
      this.Label3.Text = "Bl";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label11_1 = this.Label11;
      point1 = new Point(6, 231);
      Point point30 = point1;
      label11_1.Location = point30;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(22, 13);
      Size size30 = size1;
      label11_2.Size = size30;
      this.Label11.TabIndex = 3;
      this.Label11.Text = "Lvc";
      TextBox qmsBox1 = this.QmsBox;
      point1 = new Point(38, 123);
      Point point31 = point1;
      qmsBox1.Location = point31;
      this.QmsBox.Name = "QmsBox";
      TextBox qmsBox2 = this.QmsBox;
      size1 = new Size(57, 20);
      Size size31 = size1;
      qmsBox2.Size = size31;
      this.QmsBox.TabIndex = 4;
      this.QmsBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.QmsBox, "Unitless measurement, describing mechanical damping");
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(6, 153);
      Point point32 = point1;
      label1_1.Location = point32;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(23, 13);
      Size size32 = size1;
      label1_2.Size = size32;
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Qts";
      this.SdUnitLabel.AutoSize = true;
      this.SdUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label sdUnitLabel1 = this.SdUnitLabel;
      point1 = new Point(101, 74);
      Point point33 = point1;
      sdUnitLabel1.Location = point33;
      this.SdUnitLabel.Name = "SdUnitLabel";
      Label sdUnitLabel2 = this.SdUnitLabel;
      size1 = new Size(20, 13);
      Size size33 = size1;
      sdUnitLabel2.Size = size33;
      this.SdUnitLabel.TabIndex = 3;
      this.SdUnitLabel.Text = "m\u00B2";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label5_1 = this.Label5;
      point1 = new Point(6, 100);
      Point point34 = point1;
      label5_1.Location = point34;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(25, 13);
      Size size34 = size1;
      label5_2.Size = size34;
      this.Label5.TabIndex = 3;
      this.Label5.Text = "Qes";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(6, 74);
      Point point35 = point1;
      label4_1.Location = point35;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(18, 13);
      Size size35 = size1;
      label4_2.Size = size35;
      this.Label4.TabIndex = 3;
      this.Label4.Text = "Sd";
      TextBox reBox1 = this.ReBox;
      point1 = new Point(38, 254);
      Point point36 = point1;
      reBox1.Location = point36;
      this.ReBox.Name = "ReBox";
      TextBox reBox2 = this.ReBox;
      size1 = new Size(57, 20);
      Size size36 = size1;
      reBox2.Size = size36;
      this.ReBox.TabIndex = 9;
      this.ReBox.Text = "0";
      this.ToolTip1.SetToolTip((Control) this.ReBox, "DC resistance of the voice coil.");
      this.IsobaricBox.AutoSize = true;
      CheckBox isobaricBox1 = this.IsobaricBox;
      point1 = new Point(6, 19);
      Point point37 = point1;
      isobaricBox1.Location = point37;
      this.IsobaricBox.Name = "IsobaricBox";
      CheckBox isobaricBox2 = this.IsobaricBox;
      size1 = new Size(104, 17);
      Size size37 = size1;
      isobaricBox2.Size = size37;
      this.IsobaricBox.TabIndex = 13;
      this.IsobaricBox.Text = "Isobaric Loading";
      this.IsobaricBox.UseVisualStyleBackColor = true;
      Button updateButton1 = this.UpdateButton;
      point1 = new Point(12, 486);
      Point point38 = point1;
      updateButton1.Location = point38;
      this.UpdateButton.Name = "UpdateButton";
      Button updateButton2 = this.UpdateButton;
      size1 = new Size(75, 23);
      Size size38 = size1;
      updateButton2.Size = size38;
      this.UpdateButton.TabIndex = 17;
      this.UpdateButton.Text = "Update";
      this.UpdateButton.UseVisualStyleBackColor = true;
      this.IsobaricSeriesBox.AutoSize = true;
      this.IsobaricSeriesBox.Checked = true;
      RadioButton isobaricSeriesBox1 = this.IsobaricSeriesBox;
      point1 = new Point(6, 43);
      Point point39 = point1;
      isobaricSeriesBox1.Location = point39;
      this.IsobaricSeriesBox.Name = "IsobaricSeriesBox";
      RadioButton isobaricSeriesBox2 = this.IsobaricSeriesBox;
      size1 = new Size(54, 17);
      Size size39 = size1;
      isobaricSeriesBox2.Size = size39;
      this.IsobaricSeriesBox.TabIndex = 14;
      this.IsobaricSeriesBox.TabStop = true;
      this.IsobaricSeriesBox.Text = "Series";
      this.IsobaricSeriesBox.UseVisualStyleBackColor = true;
      this.IsobaricParallelBox.AutoSize = true;
      RadioButton isobaricParallelBox1 = this.IsobaricParallelBox;
      point1 = new Point(6, 66);
      Point point40 = point1;
      isobaricParallelBox1.Location = point40;
      this.IsobaricParallelBox.Name = "IsobaricParallelBox";
      RadioButton isobaricParallelBox2 = this.IsobaricParallelBox;
      size1 = new Size(59, 17);
      Size size40 = size1;
      isobaricParallelBox2.Size = size40;
      this.IsobaricParallelBox.TabIndex = 15;
      this.IsobaricParallelBox.Text = "Parallel";
      this.IsobaricParallelBox.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.IsobaricBox);
      this.GroupBox2.Controls.Add((Control) this.IsobaricParallelBox);
      this.GroupBox2.Controls.Add((Control) this.IsobaricSeriesBox);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(12, 380);
      Point point41 = point1;
      groupBox2_1.Location = point41;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(136, 100);
      Size size41 = size1;
      groupBox2_2.Size = size41;
      this.GroupBox2.TabIndex = 16;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Configuration";
      this.DriverLibListbox.FormattingEnabled = true;
      ListBox driverLibListbox1 = this.DriverLibListbox;
      point1 = new Point(6, 18);
      Point point42 = point1;
      driverLibListbox1.Location = point42;
      this.DriverLibListbox.Name = "DriverLibListbox";
      ListBox driverLibListbox2 = this.DriverLibListbox;
      size1 = new Size(124, 303);
      Size size42 = size1;
      driverLibListbox2.Size = size42;
      this.DriverLibListbox.TabIndex = 16;
      this.DriverLibraryGroup.Controls.Add((Control) this.SaveAsButton);
      this.DriverLibraryGroup.Controls.Add((Control) this.SaveButton);
      this.DriverLibraryGroup.Controls.Add((Control) this.DriverLibListbox);
      GroupBox driverLibraryGroup1 = this.DriverLibraryGroup;
      point1 = new Point(165, 13);
      Point point43 = point1;
      driverLibraryGroup1.Location = point43;
      this.DriverLibraryGroup.Name = "DriverLibraryGroup";
      GroupBox driverLibraryGroup2 = this.DriverLibraryGroup;
      size1 = new Size(136, 361);
      Size size43 = size1;
      driverLibraryGroup2.Size = size43;
      this.DriverLibraryGroup.TabIndex = 18;
      this.DriverLibraryGroup.TabStop = false;
      this.DriverLibraryGroup.Text = "Driver Library";
      Button saveAsButton1 = this.SaveAsButton;
      point1 = new Point(61, 327);
      Point point44 = point1;
      saveAsButton1.Location = point44;
      this.SaveAsButton.Name = "SaveAsButton";
      Button saveAsButton2 = this.SaveAsButton;
      size1 = new Size(69, 23);
      Size size44 = size1;
      saveAsButton2.Size = size44;
      this.SaveAsButton.TabIndex = 18;
      this.SaveAsButton.Text = "Save As";
      this.SaveAsButton.UseVisualStyleBackColor = true;
      Button saveButton1 = this.SaveButton;
      point1 = new Point(6, 327);
      Point point45 = point1;
      saveButton1.Location = point45;
      this.SaveButton.Name = "SaveButton";
      Button saveButton2 = this.SaveButton;
      size1 = new Size(49, 23);
      Size size45 = size1;
      saveButton2.Size = size45;
      this.SaveButton.TabIndex = 18;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(309, 520);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.DriverLibraryGroup);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.UpdateButton);
      this.Controls.Add((Control) this.GroupBox1);
      this.DataBindings.Add(new Binding("Location", (object) MySettings.Default, "DriverLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Location = MySettings.Default.DriverLocation;
      this.Name = nameof (DriverClass);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Driver";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.DriverLibraryGroup.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get => this._GroupBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal TextBox LvcBox
    {
      [DebuggerNonUserCode] get => this._LvcBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LvcBox_LostFocus);
        if (this._LvcBox != null)
          this._LvcBox.LostFocus -= eventHandler;
        this._LvcBox = value;
        if (this._LvcBox == null)
          return;
        this._LvcBox.LostFocus += eventHandler;
      }
    }

    internal Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal TextBox SdBox
    {
      [DebuggerNonUserCode] get => this._SdBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SdBox_LostFocus);
        if (this._SdBox != null)
          this._SdBox.LostFocus -= eventHandler;
        this._SdBox = value;
        if (this._SdBox == null)
          return;
        this._SdBox.LostFocus += eventHandler;
      }
    }

    internal TextBox BlBox
    {
      [DebuggerNonUserCode] get => this._BlBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._BlBox = value;
    }

    internal Label Label9
    {
      [DebuggerNonUserCode] get => this._Label9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
    }

    internal TextBox MmsBox
    {
      [DebuggerNonUserCode] get => this._MmsBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MmsBox = value;
    }

    internal Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal TextBox QesBox
    {
      [DebuggerNonUserCode] get => this._QesBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.QesBox_LostFocus);
        if (this._QesBox != null)
          this._QesBox.LostFocus -= eventHandler;
        this._QesBox = value;
        if (this._QesBox == null)
          return;
        this._QesBox.LostFocus += eventHandler;
      }
    }

    internal TextBox CmsBox
    {
      [DebuggerNonUserCode] get => this._CmsBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CmsBox = value;
    }

    internal Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal Label Label11
    {
      [DebuggerNonUserCode] get => this._Label11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
    }

    internal TextBox QmsBox
    {
      [DebuggerNonUserCode] get => this._QmsBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.QmsBox_LostFocus);
        if (this._QmsBox != null)
          this._QmsBox.LostFocus -= eventHandler;
        this._QmsBox = value;
        if (this._QmsBox == null)
          return;
        this._QmsBox.LostFocus += eventHandler;
      }
    }

    internal Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal TextBox ReBox
    {
      [DebuggerNonUserCode] get => this._ReBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ReBox_LostFocus);
        if (this._ReBox != null)
          this._ReBox.LostFocus -= eventHandler;
        this._ReBox = value;
        if (this._ReBox == null)
          return;
        this._ReBox.LostFocus += eventHandler;
      }
    }

    internal Button UpdateButton
    {
      [DebuggerNonUserCode] get => this._UpdateButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UpdateButton_Click);
        if (this._UpdateButton != null)
          this._UpdateButton.Click -= eventHandler;
        this._UpdateButton = value;
        if (this._UpdateButton == null)
          return;
        this._UpdateButton.Click += eventHandler;
      }
    }

    internal TextBox QtsBox
    {
      [DebuggerNonUserCode] get => this._QtsBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._QtsBox = value;
    }

    internal Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal TextBox VasBox
    {
      [DebuggerNonUserCode] get => this._VasBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VasBox_LostFocus);
        if (this._VasBox != null)
          this._VasBox.LostFocus -= eventHandler;
        this._VasBox = value;
        if (this._VasBox == null)
          return;
        this._VasBox.LostFocus += eventHandler;
      }
    }

    internal TextBox FsBox
    {
      [DebuggerNonUserCode] get => this._FsBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FsBox_LostFocus);
        if (this._FsBox != null)
          this._FsBox.LostFocus -= eventHandler;
        this._FsBox = value;
        if (this._FsBox == null)
          return;
        this._FsBox.LostFocus += eventHandler;
      }
    }

    internal Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal ToolTip ToolTip1
    {
      [DebuggerNonUserCode] get => this._ToolTip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolTip1 = value;
    }

    internal CheckBox IsobaricBox
    {
      [DebuggerNonUserCode] get => this._IsobaricBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.IsobaricBox_CheckedChanged);
        if (this._IsobaricBox != null)
          this._IsobaricBox.CheckedChanged -= eventHandler;
        this._IsobaricBox = value;
        if (this._IsobaricBox == null)
          return;
        this._IsobaricBox.CheckedChanged += eventHandler;
      }
    }

    internal TextBox RmsBox
    {
      [DebuggerNonUserCode] get => this._RmsBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._RmsBox = value;
    }

    internal Label Label12
    {
      [DebuggerNonUserCode] get => this._Label12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
    }

    internal RadioButton IsobaricParallelBox
    {
      [DebuggerNonUserCode] get => this._IsobaricParallelBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._IsobaricParallelBox = value;
    }

    internal RadioButton IsobaricSeriesBox
    {
      [DebuggerNonUserCode] get => this._IsobaricSeriesBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.IsobaricSeriesBox_CheckedChanged);
        if (this._IsobaricSeriesBox != null)
          this._IsobaricSeriesBox.CheckedChanged -= eventHandler;
        this._IsobaricSeriesBox = value;
        if (this._IsobaricSeriesBox == null)
          return;
        this._IsobaricSeriesBox.CheckedChanged += eventHandler;
      }
    }

    internal GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get => this._GroupBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox2 = value;
    }

    internal ListBox DriverLibListbox
    {
      [DebuggerNonUserCode] get => this._DriverLibListbox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DriverLibListbox_SelectedIndexChanged);
        if (this._DriverLibListbox != null)
          this._DriverLibListbox.SelectedIndexChanged -= eventHandler;
        this._DriverLibListbox = value;
        if (this._DriverLibListbox == null)
          return;
        this._DriverLibListbox.SelectedIndexChanged += eventHandler;
      }
    }

    internal TextBox DriverTitleBox
    {
      [DebuggerNonUserCode] get => this._DriverTitleBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DriverTitleBox = value;
    }

    internal GroupBox DriverLibraryGroup
    {
      [DebuggerNonUserCode] get => this._DriverLibraryGroup;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DriverLibraryGroup = value;
    }

    internal Button SaveAsButton
    {
      [DebuggerNonUserCode] get => this._SaveAsButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsButton_Click);
        if (this._SaveAsButton != null)
          this._SaveAsButton.Click -= eventHandler;
        this._SaveAsButton = value;
        if (this._SaveAsButton == null)
          return;
        this._SaveAsButton.Click += eventHandler;
      }
    }

    internal Button SaveButton
    {
      [DebuggerNonUserCode] get => this._SaveButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.SaveButton_Click());
        if (this._SaveButton != null)
          this._SaveButton.Click -= eventHandler;
        this._SaveButton = value;
        if (this._SaveButton == null)
          return;
        this._SaveButton.Click += eventHandler;
      }
    }

    internal Label Label23
    {
      [DebuggerNonUserCode] get => this._Label23;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
    }

    internal Label VasUnitLabel
    {
      [DebuggerNonUserCode] get => this._VasUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VasUnitLabel_Click);
        if (this._VasUnitLabel != null)
          this._VasUnitLabel.Click -= eventHandler;
        this._VasUnitLabel = value;
        if (this._VasUnitLabel == null)
          return;
        this._VasUnitLabel.Click += eventHandler;
      }
    }

    internal Label FsUnitLabel
    {
      [DebuggerNonUserCode] get => this._FsUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FsUnitLabel_Click);
        if (this._FsUnitLabel != null)
          this._FsUnitLabel.Click -= eventHandler;
        this._FsUnitLabel = value;
        if (this._FsUnitLabel == null)
          return;
        this._FsUnitLabel.Click += eventHandler;
      }
    }

    internal Label Label20
    {
      [DebuggerNonUserCode] get => this._Label20;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
    }

    internal Label Label19
    {
      [DebuggerNonUserCode] get => this._Label19;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
    }

    internal Label MmsUnitLabel
    {
      [DebuggerNonUserCode] get => this._MmsUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MmsUnitLabel_Click);
        if (this._MmsUnitLabel != null)
          this._MmsUnitLabel.Click -= eventHandler;
        this._MmsUnitLabel = value;
        if (this._MmsUnitLabel == null)
          return;
        this._MmsUnitLabel.Click += eventHandler;
      }
    }

    internal Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal Label LvcUnitLabel
    {
      [DebuggerNonUserCode] get => this._LvcUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LvcUnitLabel_Click);
        if (this._LvcUnitLabel != null)
          this._LvcUnitLabel.Click -= eventHandler;
        this._LvcUnitLabel = value;
        if (this._LvcUnitLabel == null)
          return;
        this._LvcUnitLabel.Click += eventHandler;
      }
    }

    internal Label SdUnitLabel
    {
      [DebuggerNonUserCode] get => this._SdUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SdUnitLabel_Click);
        if (this._SdUnitLabel != null)
          this._SdUnitLabel.Click -= eventHandler;
        this._SdUnitLabel = value;
        if (this._SdUnitLabel == null)
          return;
        this._SdUnitLabel.Click += eventHandler;
      }
    }

    public event DriverClass.DriverParameterUpdatedEventHandler DriverParameterUpdated;

    public DriverClass(
      DriverParameters DriverParameter,
      SettingsParameters SettingsParameter,
      DriverSetup DriverSetupParameter)
    {
      this.Shown += new EventHandler(this.DriverClass_Shown);
      DriverClass.__ENCAddToList((object) this);
      this.FormShown = false;
      this.LvcUnit = 1;
      this.FsUnit = 1;
      this.SdUnit = 1;
      this.VasUnit = 1;
      this.MmsUnit = 1;
      this.DriverLibrary = (DriverParameters[]) null;
      this.InitializeComponent();
      this.DriverSetupParameterFromParent = DriverSetupParameter;
      this.SettingsParameterFromParent = SettingsParameter;
      this.DriverParameterFromParent = DriverParameter;
      this.SetupUnits();
    }

    public void SetupUnits()
    {
      this.LvcUnitLabel.Text = Functions.UnitStringTens(this.LvcUnit) + "H";
      this.FsUnitLabel.Text = Functions.UnitStringTens(this.FsUnit) + "Hz";
      this.SdUnitLabel.Text = Functions.UnitStringLength(this.SdUnit) + "\u00B2";
      this.VasUnitLabel.Text = Functions.UnitStringVolume(this.VasUnit);
      this.MmsUnitLabel.Text = Functions.UnitStringMass(this.MmsUnit);
    }

    public DriverSetup DriverSetupParameterFromParent
    {
      set => this.DriverSetupParameterEdit = value;
    }

    public DriverParameters DriverParameterFromParent
    {
      set
      {
        this.DriverParameterEdit = value;
        this.UpdateValuesOnForm();
      }
    }

    public SettingsParameters SettingsParameterFromParent
    {
      set
      {
        this.SettingsParameterEdit = value;
        if (!this.FormShown)
          return;
        this.UpdateLibrary();
      }
    }

    private void SendValues()
    {
      DriverParameterUpdatedEventArgs e = new DriverParameterUpdatedEventArgs(this.DriverParameterEdit, this.DriverSetupParameterEdit);
      DriverClass.DriverParameterUpdatedEventHandler parameterUpdatedEvent = this.DriverParameterUpdated;
      if (parameterUpdatedEvent == null)
        return;
      parameterUpdatedEvent((object) this, e);
    }

    private void ImportDrivers()
    {
      FileInfo[] files = new DirectoryInfo(this.SettingsParameterEdit.DriverLibrary).GetFiles();
      int index1 = -1;
      FileInfo[] fileInfoArray = files;
      int index2 = 0;
      while (index2 < fileInfoArray.Length)
      {
        FileInfo fileInfo = fileInfoArray[index2];
        Application.DoEvents();
        if (!(Operators.CompareString(Strings.LCase(fileInfo.Extension), ".lsd", false) != 0 & Operators.CompareString(Strings.LCase(fileInfo.Extension), ".wdr", false) != 0))
        {
          string String2 = " ";
          if (Operators.CompareString(Strings.LCase(fileInfo.Extension), ".lsd", false) == 0)
            String2 = " ";
          else if (Operators.CompareString(Strings.LCase(fileInfo.Extension), ".wdr", false) == 0)
            String2 = "=";
          StreamReader streamReader = fileInfo.OpenText();
          DriverParameters driverParameters = new DriverParameters();
          bool[] flagArray1 = new bool[6];
          int index3 = 0;
          do
          {
            flagArray1[index3] = false;
            checked { ++index3; }
          }
          while (index3 <= 5);
          bool[] flagArray2 = new bool[8];
          int index4 = 0;
          do
          {
            flagArray2[index4] = false;
            checked { ++index4; }
          }
          while (index4 <= 7);
          string str1 = "";
          string str2 = "";
          double Bl = 0;
          double Rms = 0;
          double Mms = 0;
          double Cms = 0;
          while (!streamReader.EndOfStream)
          {
            string str3 = streamReader.ReadLine();
            if (Operators.CompareString(Strings.Left(str3, 1), "#", false) != 0)
            {
              int num = Strings.InStr(str3, String2);
              string str4;
              string str5;
              if (num == 0)
              {
                if (Strings.Len(str3) > 0)
                {
                  str4 = str3;
                  str5 = "";
                }
                else
                  continue;
              }
              else
              {
                str4 = Strings.Left(str3, checked (num - 1));
                str5 = Strings.Mid(str3, checked (num + 1));
              }
              string Left = str4;
              if (Operators.CompareString(Left, "Title", false) == 0)
              {
                driverParameters.Title = str5;
                flagArray2[0] = true;
              }
              else if (Operators.CompareString(Left, "Sd", false) == 0)
              {
                driverParameters.Sd = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[1] = true;
              }
              else if (Operators.CompareString(Left, "Qes", false) == 0)
              {
                driverParameters.Qes = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[2] = true;
              }
              else if (Operators.CompareString(Left, "Qms", false) == 0)
              {
                driverParameters.Qms = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[3] = true;
              }
              else if (Operators.CompareString(Left, "Lvc", false) == 0)
              {
                driverParameters.Lvc = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[4] = true;
              }
              else if (Operators.CompareString(Left, "Le", false) == 0)
              {
                driverParameters.Lvc = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[4] = true;
              }
              else if (Operators.CompareString(Left, "Re", false) == 0)
              {
                driverParameters.Re = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[5] = true;
              }
              else if (Operators.CompareString(Left, "Fs", false) == 0)
              {
                driverParameters.Fs = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[6] = true;
              }
              else if (Operators.CompareString(Left, "Vas", false) == 0)
              {
                driverParameters.Vas = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray2[7] = true;
              }
              else if (Operators.CompareString(Left, "Bl", false) == 0)
              {
                Bl = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray1[0] = true;
              }
              else if (Operators.CompareString(Left, "BL", false) == 0)
              {
                Bl = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray1[0] = true;
              }
              else if (Operators.CompareString(Left, "Rms", false) == 0)
              {
                Rms = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray1[1] = true;
              }
              else if (Operators.CompareString(Left, "Mms", false) == 0)
              {
                Mms = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray1[2] = true;
              }
              else if (Operators.CompareString(Left, "Cms", false) == 0)
              {
                Cms = double.Parse(str5.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
                flagArray1[3] = true;
              }
              else if (Operators.CompareString(Left, "Brand", false) == 0)
              {
                str1 = str5;
                flagArray1[4] = true;
              }
              else if (Operators.CompareString(Left, "Model", false) == 0)
              {
                str2 = str5;
                flagArray1[5] = true;
              }
            }
          }
          streamReader.Close();
          driverParameters.FilePath = fileInfo.FullName;
          if (!flagArray2[0])
          {
            driverParameters.Title = "";
            if (flagArray1[4])
              driverParameters.Title = str1;
            if (flagArray1[5])
              driverParameters.Title = driverParameters.Title + " " + str2;
          }
          if (!flagArray2[2] && flagArray1[3] & flagArray1[2] & flagArray2[5] & flagArray1[0])
          {
            driverParameters.Qes = Functions.QesCalc(Functions.FsCalc(Cms, Mms), Mms, driverParameters.Re, Bl);
            flagArray2[2] = true;
          }
          if (!flagArray2[3] && flagArray1[3] & flagArray1[2] & flagArray1[1])
          {
            driverParameters.Qms = Functions.QmsCalc(Functions.FsCalc(Cms, Mms), Mms, Rms);
            flagArray2[3] = true;
          }
          if (!flagArray2[6] && flagArray1[3] & flagArray1[2])
          {
            driverParameters.Fs = Functions.FsCalc(Cms, Mms);
            flagArray2[6] = true;
          }
          if (!flagArray2[7] && flagArray2[1] & flagArray1[3])
          {
            driverParameters.Vas = Functions.VasCalc(driverParameters.Sd, Cms, this.SettingsParameterEdit.SpeedOfSound);
            flagArray2[7] = true;
          }
          int index5 = 1;
          while (flagArray2[index5])
          {
            checked { ++index5; }
            if (index5 > 7)
            {
              checked { ++index1; }
              this.DriverLibrary = (DriverParameters[]) Utils.CopyArray((Array) this.DriverLibrary, (Array) new DriverParameters[checked (index1 + 1)]);
              this.DriverLibrary[index1] = driverParameters;
              break;
            }
          }
        }
        checked { ++index2; }
      }
    }

    private void UpdateLibrary()
    {
      if (!Directory.Exists(this.SettingsParameterEdit.DriverLibrary))
        return;
      this.DriverLibListbox.Enabled = false;
      this.ImportDrivers();
      this.PopulateListBox();
      this.DriverLibListbox.Enabled = true;
    }

    private void PopulateListBox()
    {
      this.DriverLibListbox.Items.Clear();
      this.DriverLibListbox.BeginUpdate();
      if (!Information.IsNothing((object) this.DriverLibrary))
      {
        int upperBound = this.DriverLibrary.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          this.DriverLibListbox.Items.Add((object) this.DriverLibrary[index].Title);
          checked { ++index; }
        }
      }
      this.DriverLibListbox.EndUpdate();
    }

    private void UpdateValuesOnForm()
    {
      this.DriverTitleBox.Text = this.DriverParameterEdit.Title.ToString();
      this.SdBox.Text = Functions.ConvertArea(1, this.SdUnit, this.DriverParameterEdit.Sd).ToString();
      this.QesBox.Text = this.DriverParameterEdit.Qes.ToString();
      this.QmsBox.Text = this.DriverParameterEdit.Qms.ToString();
      this.LvcBox.Text = Functions.ConvertTens(1, this.LvcUnit, this.DriverParameterEdit.Lvc).ToString();
      this.ReBox.Text = this.DriverParameterEdit.Re.ToString();
      this.FsBox.Text = Functions.ConvertTens(1, this.FsUnit, this.DriverParameterEdit.Fs).ToString();
      this.VasBox.Text = Functions.ConvertVolume(1, this.VasUnit, this.DriverParameterEdit.Vas).ToString();
      this.IsobaricBox.Checked = this.DriverSetupParameterEdit.Isobaric;
      this.IsobaricSeriesBox.Checked = this.DriverSetupParameterEdit.Series;
      this.IsobaricParallelBox.Checked = !this.DriverSetupParameterEdit.Series;
      this.CalculatedValues();
    }

    private void CalculatedValues()
    {
      double num1 = Functions.QtsCalc(Conversions.ToDouble(this.QmsBox.Text), Conversions.ToDouble(this.QesBox.Text));
      double Cms = Functions.CmsCalc(Functions.ConvertVolume(this.VasUnit, 1, Conversions.ToDouble(this.VasBox.Text)), Functions.ConvertArea(this.SdUnit, 1, Conversions.ToDouble(this.SdBox.Text)), this.SettingsParameterEdit.SpeedOfSound);
      double Mms = Functions.MmsCalc(Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text)), Cms);
      double num2 = Functions.RmsCalc(Mms, Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text)), Conversions.ToDouble(this.QmsBox.Text));
      double num3 = Functions.BlCalc(Mms, Conversions.ToDouble(this.ReBox.Text), Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text)), Conversions.ToDouble(this.QesBox.Text));
      this.QtsBox.Text = Math.Round(num1, 3).ToString();
      this.CmsBox.Text = Math.Round(Cms, 6).ToString();
      this.MmsBox.Text = Functions.ConvertMass(1, this.MmsUnit, Mms).ToString();
      this.RmsBox.Text = Math.Round(num2, 4).ToString();
      this.BlBox.Text = Math.Round(num3, 3).ToString();
      this.DriverParameterEdit.Qms = Conversions.ToDouble(this.QmsBox.Text);
      this.DriverParameterEdit.Fs = Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text));
      this.DriverParameterEdit.Vas = Functions.ConvertVolume(this.VasUnit, 1, Conversions.ToDouble(this.VasBox.Text));
      this.DriverParameterEdit.Re = Conversions.ToDouble(this.ReBox.Text);
      this.DriverParameterEdit.Sd = Functions.ConvertArea(this.SdUnit, 1, Conversions.ToDouble(this.SdBox.Text));
      this.DriverParameterEdit.Qes = Conversions.ToDouble(this.QesBox.Text);
      this.DriverParameterEdit.Lvc = Functions.ConvertTens(this.LvcUnit, 1, Conversions.ToDouble(this.LvcBox.Text));
      this.DriverSetupParameterEdit.Isobaric = this.IsobaricBox.Checked;
      this.DriverSetupParameterEdit.Series = this.IsobaricSeriesBox.Checked;
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
      this.CalculatedValues();
      this.SendValues();
    }

    private void QesBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.QesBox.Text, 1E-05, 10000.0))
        this.QesBox.Text = Functions.QesCalc(Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text)), Functions.ConvertTens(this.MmsUnit, 1, Conversions.ToDouble(this.MmsBox.Text)), Conversions.ToDouble(this.ReBox.Text), Conversions.ToDouble(this.BlBox.Text)).ToString();
      this.CalculatedValues();
    }

    private void QmsBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.QmsBox.Text, 1E-05, 10000.0))
        this.QmsBox.Text = Functions.QmsCalc(Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text)), Functions.ConvertTens(this.MmsUnit, 1, Conversions.ToDouble(this.MmsBox.Text)), Conversions.ToDouble(this.RmsBox.Text)).ToString();
      this.CalculatedValues();
    }

    private void FsBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.FsBox.Text, 1E-05, 100000.0))
        this.FsBox.Text = Functions.FsCalc(Conversions.ToDouble(this.CmsBox.Text), Functions.ConvertTens(this.MmsUnit, 1, Conversions.ToDouble(this.MmsBox.Text))).ToString();
      this.CalculatedValues();
    }

    private void VasBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.VasBox.Text, 1E-05, 10000.0))
        this.VasBox.Text = Functions.VasCalc(Functions.ConvertArea(this.SdUnit, 1, Conversions.ToDouble(this.SdBox.Text)), Conversions.ToDouble(this.CmsBox.Text), this.SettingsParameterEdit.SpeedOfSound).ToString();
      this.CalculatedValues();
    }

    private void LvcBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.LvcBox.Text, 0.0, 100.0))
        this.LvcBox.Text = Functions.ConvertTens(1, this.LvcUnit, this.DriverParameterEdit.Lvc).ToString();
      this.CalculatedValues();
    }

    private void ReBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.ReBox.Text, 1E-05, 10000.0))
        this.ReBox.Text = this.DriverParameterEdit.Re.ToString();
      this.CalculatedValues();
    }

    private void SdBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.SdBox.Text, 1E-05, 10000.0))
        this.SdBox.Text = Functions.ConvertArea(1, this.SdUnit, this.DriverParameterEdit.Sd).ToString();
      this.CalculatedValues();
    }

    private void IsobaricBox_CheckedChanged(object sender, EventArgs e) => this.DriverSetupParameterEdit.Isobaric = this.IsobaricBox.Checked;

    private void IsobaricSeriesBox_CheckedChanged(object sender, EventArgs e) => this.DriverSetupParameterEdit.Series = this.IsobaricSeriesBox.Checked;

    private void DriverLibListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.DriverLibListbox.SelectedIndex < 0)
        return;
      this.DriverParameterEdit = this.DriverLibrary[this.DriverLibListbox.SelectedIndex];
      this.UpdateValuesOnForm();
    }

    private void SaveToFile(string FILE_NAME)
    {
      try
      {
        string Left = Strings.LCase(new FileInfo(FILE_NAME).Extension);
        string str1;
        string str2;
        if (Operators.CompareString(Left, ".lsd", false) == 0)
        {
          str1 = " ";
          str2 = "#Loudspeaker Data File for use with Leonard Audio Transmission Line Software";
        }
        else
        {
          if (Operators.CompareString(Left, ".wdr", false) != 0)
            return;
          str1 = "=";
          str2 = "[Driver]";
        }
        StreamWriter streamWriter1 = new StreamWriter(FILE_NAME, false);
        streamWriter1.WriteLine(str2);
        streamWriter1.WriteLine("Title" + str1 + this.DriverTitleBox.Text);
        StreamWriter streamWriter2 = streamWriter1;
        string str3 = str1;
        double num = Conversions.ToDouble(this.BlBox.Text);
        string str4 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str5 = "BL" + str3 + str4;
        streamWriter2.WriteLine(str5);
        StreamWriter streamWriter3 = streamWriter1;
        string str6 = str1;
        num = Functions.ConvertArea(this.SdUnit, 1, Conversions.ToDouble(this.SdBox.Text));
        string str7 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str8 = "Sd" + str6 + str7;
        streamWriter3.WriteLine(str8);
        StreamWriter streamWriter4 = streamWriter1;
        string str9 = str1;
        num = Conversions.ToDouble(this.QesBox.Text);
        string str10 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str11 = "Qes" + str9 + str10;
        streamWriter4.WriteLine(str11);
        StreamWriter streamWriter5 = streamWriter1;
        string str12 = str1;
        num = Conversions.ToDouble(this.QmsBox.Text);
        string str13 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str14 = "Qms" + str12 + str13;
        streamWriter5.WriteLine(str14);
        StreamWriter streamWriter6 = streamWriter1;
        string str15 = str1;
        num = Conversions.ToDouble(this.RmsBox.Text);
        string str16 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str17 = "Rms" + str15 + str16;
        streamWriter6.WriteLine(str17);
        StreamWriter streamWriter7 = streamWriter1;
        string str18 = str1;
        num = Conversions.ToDouble(this.ReBox.Text);
        string str19 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str20 = "Re" + str18 + str19;
        streamWriter7.WriteLine(str20);
        StreamWriter streamWriter8 = streamWriter1;
        string str21 = str1;
        num = Functions.ConvertTens(this.FsUnit, 1, Conversions.ToDouble(this.FsBox.Text));
        string str22 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str23 = "Fs" + str21 + str22;
        streamWriter8.WriteLine(str23);
        StreamWriter streamWriter9 = streamWriter1;
        string str24 = str1;
        num = Functions.ConvertVolume(this.VasUnit, 1, Conversions.ToDouble(this.VasBox.Text));
        string str25 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str26 = "Vas" + str24 + str25;
        streamWriter9.WriteLine(str26);
        StreamWriter streamWriter10 = streamWriter1;
        string str27 = str1;
        num = Functions.ConvertMass(this.MmsUnit, 1, Conversions.ToDouble(this.MmsBox.Text));
        string str28 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str29 = "Mms" + str27 + str28;
        streamWriter10.WriteLine(str29);
        StreamWriter streamWriter11 = streamWriter1;
        string str30 = str1;
        num = Conversions.ToDouble(this.CmsBox.Text);
        string str31 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str32 = "Cms" + str30 + str31;
        streamWriter11.WriteLine(str32);
        StreamWriter streamWriter12 = streamWriter1;
        string str33 = str1;
        num = Functions.ConvertTens(this.LvcUnit, 1, Conversions.ToDouble(this.LvcBox.Text));
        string str34 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        string str35 = "Lvc" + str33 + str34;
        streamWriter12.WriteLine(str35);
        streamWriter1.Close();
      }
      catch (ObjectDisposedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "ObjectDisposedException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured writing to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "UnauthorizedAccessException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "Access to file has been denied. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "ArgumentNullException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "File path is nothing. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "ArgumentException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "Invalid File Path. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (DirectoryNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "DirectoryNotFoundException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "The specified path is invalid (for example, it is on an unmapped drive). Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "PathTooLongException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured writing to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "IOException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured writing to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (SecurityException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MyProject.Forms.Form1.ReportError((Exception) ex, "SecurityException during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "Access to file has been denied - Security Exception. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.Form1.ReportError(ex, "Exception during SaveToFile() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured attempting to write to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveToFile(FILE_NAME);
        ProjectData.ClearProjectError();
      }
    }

    private void SaveButton_Click()
    {
      if (this.DriverLibListbox.SelectedIndex >= 0)
        this.SaveToFile(this.DriverLibrary[this.DriverLibListbox.SelectedIndex].FilePath);
      else
        this.SaveAs();
      this.UpdateLibrary();
    }

    private void SaveAs()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Driver Data (*.lsd)|*.lsd";
      saveFileDialog.FilterIndex = 1;
      saveFileDialog.RestoreDirectory = true;
      saveFileDialog.InitialDirectory = this.SettingsParameterEdit.DriverLibrary;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.SaveToFile(saveFileDialog.FileName);
    }

    private void SaveAsButton_Click(object sender, EventArgs e) => this.SaveAs();

    private void LvcUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.LvcUnit < Functions.UnitNumberTens())
        checked { ++this.LvcUnit; }
      else
        this.LvcUnit = 1;
      this.SetupUnits();
      this.UpdateValuesOnForm();
    }

    private void FsUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.FsUnit < Functions.UnitNumberTens())
        checked { ++this.FsUnit; }
      else
        this.FsUnit = 1;
      this.SetupUnits();
      this.UpdateValuesOnForm();
    }

    private void SdUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.SdUnit < Functions.UnitNumberLength())
        checked { ++this.SdUnit; }
      else
        this.SdUnit = 1;
      this.SetupUnits();
      this.UpdateValuesOnForm();
    }

    private void VasUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.VasUnit < Functions.UnitNumberVolume())
        checked { ++this.VasUnit; }
      else
        this.VasUnit = 1;
      this.SetupUnits();
      this.UpdateValuesOnForm();
    }

    private void MmsUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.MmsUnit < Functions.UnitNumberMass())
        checked { ++this.MmsUnit; }
      else
        this.MmsUnit = 1;
      this.SetupUnits();
      this.UpdateValuesOnForm();
    }

    private void DriverClass_Shown(object sender, EventArgs e)
    {
      this.FormShown = true;
      this.UpdateLibrary();
    }

    public delegate void DriverParameterUpdatedEventHandler(
      object Sender,
      DriverParameterUpdatedEventArgs e);
  }
}
