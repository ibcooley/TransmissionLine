// Decompiled with JetBrains decompiler
// Type: TransmissionLine.SettingsClass
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TransmissionLine.My;

namespace TransmissionLine
{
  [DesignerGenerated]
  public class SettingsClass : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("GeneralTab")]
    private TabPage _GeneralTab;
    [AccessedThroughProperty("DriverLibBrowseButton")]
    private Button _DriverLibBrowseButton;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("DriverLibraryBox")]
    private TextBox _DriverLibraryBox;
    [AccessedThroughProperty("ApplyButton")]
    private Button _ApplyButton;
    [AccessedThroughProperty("GraphTab")]
    private TabPage _GraphTab;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("StartFreqBox")]
    private TextBox _StartFreqBox;
    [AccessedThroughProperty("EndFreqBox")]
    private TextBox _EndFreqBox;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("RadImpMinBox")]
    private TextBox _RadImpMinBox;
    [AccessedThroughProperty("RadImpMaxBox")]
    private TextBox _RadImpMaxBox;
    [AccessedThroughProperty("DriverImpMinBox")]
    private TextBox _DriverImpMinBox;
    [AccessedThroughProperty("DriverImpMaxBox")]
    private TextBox _DriverImpMaxBox;
    [AccessedThroughProperty("InputImpMinBox")]
    private TextBox _InputImpMinBox;
    [AccessedThroughProperty("InputImpMaxBox")]
    private TextBox _InputImpMaxBox;
    [AccessedThroughProperty("SystemImpMaxBox")]
    private TextBox _SystemImpMaxBox;
    [AccessedThroughProperty("LpMinBox")]
    private TextBox _LpMinBox;
    [AccessedThroughProperty("LpMaxBox")]
    private TextBox _LpMaxBox;
    [AccessedThroughProperty("DispMinBox")]
    private TextBox _DispMinBox;
    [AccessedThroughProperty("DispMaxBox")]
    private TextBox _DispMaxBox;
    [AccessedThroughProperty("VelMinBox")]
    private TextBox _VelMinBox;
    [AccessedThroughProperty("VelMaxBox")]
    private TextBox _VelMaxBox;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("Label25")]
    private Label _Label25;
    [AccessedThroughProperty("Label27")]
    private Label _Label27;
    [AccessedThroughProperty("Label29")]
    private Label _Label29;
    [AccessedThroughProperty("Label31")]
    private Label _Label31;
    [AccessedThroughProperty("Label33")]
    private Label _Label33;
    [AccessedThroughProperty("Label34")]
    private Label _Label34;
    [AccessedThroughProperty("Label37")]
    private Label _Label37;
    [AccessedThroughProperty("GroupDelayMaxBox")]
    private TextBox _GroupDelayMaxBox;
    [AccessedThroughProperty("SystemImpMinBox")]
    private TextBox _SystemImpMinBox;
    [AccessedThroughProperty("GroupDelayMinBox")]
    private TextBox _GroupDelayMinBox;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("Label38")]
    private Label _Label38;
    [AccessedThroughProperty("Label39")]
    private Label _Label39;
    [AccessedThroughProperty("LpLogBox")]
    private CheckBox _LpLogBox;
    [AccessedThroughProperty("RadImpLogBox")]
    private CheckBox _RadImpLogBox;
    [AccessedThroughProperty("DispLogBox")]
    private CheckBox _DispLogBox;
    [AccessedThroughProperty("DriverImpLogBox")]
    private CheckBox _DriverImpLogBox;
    [AccessedThroughProperty("VelocityLogBox")]
    private CheckBox _VelocityLogBox;
    [AccessedThroughProperty("InputImplogbox")]
    private CheckBox _InputImplogbox;
    [AccessedThroughProperty("GroupDelayLogbox")]
    private CheckBox _GroupDelayLogbox;
    [AccessedThroughProperty("SystemImpLogbox")]
    private CheckBox _SystemImpLogbox;
    [AccessedThroughProperty("FreqLogbox")]
    private CheckBox _FreqLogbox;
    [AccessedThroughProperty("UnitsTabPage")]
    private TabPage _UnitsTabPage;
    [AccessedThroughProperty("AreaPrecisionBox")]
    private ComboBox _AreaPrecisionBox;
    [AccessedThroughProperty("LengthPrecisionBox")]
    private ComboBox _LengthPrecisionBox;
    [AccessedThroughProperty("AreaUnitbox")]
    private ComboBox _AreaUnitbox;
    [AccessedThroughProperty("LengthUnitBox")]
    private ComboBox _LengthUnitBox;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("AnglePrecisionBox")]
    private ComboBox _AnglePrecisionBox;
    [AccessedThroughProperty("AngleUnitBox")]
    private ComboBox _AngleUnitBox;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label24")]
    private Label _Label24;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("Label26")]
    private Label _Label26;
    [AccessedThroughProperty("PanButtonBox")]
    private ComboBox _PanButtonBox;
    [AccessedThroughProperty("UndoRedoHistoryUpDown")]
    private NumericUpDown _UndoRedoHistoryUpDown;
    [AccessedThroughProperty("Label28")]
    private Label _Label28;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _TabPage2;
    [AccessedThroughProperty("TableLayoutPanel2")]
    private TableLayoutPanel _TableLayoutPanel2;
    [AccessedThroughProperty("Label30")]
    private Label _Label30;
    [AccessedThroughProperty("SpeedOfSoundBox")]
    private TextBox _SpeedOfSoundBox;
    [AccessedThroughProperty("SoSUnit")]
    private Label _SoSUnit;
    private SettingsParameters SettingsEdit;

    [DebuggerNonUserCode]
    static SettingsClass()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (SettingsClass.__ENCList)
      {
        if (SettingsClass.__ENCList.Count == SettingsClass.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (SettingsClass.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (SettingsClass.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                SettingsClass.__ENCList[index1] = SettingsClass.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          SettingsClass.__ENCList.RemoveRange(index1, checked (SettingsClass.__ENCList.Count - index1));
          SettingsClass.__ENCList.Capacity = SettingsClass.__ENCList.Count;
        }
        SettingsClass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.TabControl1 = new TabControl();
      this.GeneralTab = new TabPage();
      this.UndoRedoHistoryUpDown = new NumericUpDown();
      this.DriverLibBrowseButton = new Button();
      this.Label28 = new Label();
      this.Label1 = new Label();
      this.DriverLibraryBox = new TextBox();
      this.GraphTab = new TabPage();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.Label6 = new Label();
      this.Label8 = new Label();
      this.Label10 = new Label();
      this.RadImpMinBox = new TextBox();
      this.DriverImpMinBox = new TextBox();
      this.InputImpMinBox = new TextBox();
      this.Label29 = new Label();
      this.Label31 = new Label();
      this.Label33 = new Label();
      this.VelMaxBox = new TextBox();
      this.DispMaxBox = new TextBox();
      this.Label37 = new Label();
      this.GroupDelayMaxBox = new TextBox();
      this.Label14 = new Label();
      this.LpMinBox = new TextBox();
      this.Label21 = new Label();
      this.Label16 = new Label();
      this.DispMinBox = new TextBox();
      this.DriverImpMaxBox = new TextBox();
      this.Label18 = new Label();
      this.VelMinBox = new TextBox();
      this.InputImpMaxBox = new TextBox();
      this.Label25 = new Label();
      this.Label34 = new Label();
      this.SystemImpMaxBox = new TextBox();
      this.Label27 = new Label();
      this.Label13 = new Label();
      this.Label2 = new Label();
      this.LpMaxBox = new TextBox();
      this.SystemImpMinBox = new TextBox();
      this.StartFreqBox = new TextBox();
      this.RadImpMaxBox = new TextBox();
      this.GroupDelayMinBox = new TextBox();
      this.EndFreqBox = new TextBox();
      this.Label23 = new Label();
      this.Label5 = new Label();
      this.Label38 = new Label();
      this.Label39 = new Label();
      this.RadImpLogBox = new CheckBox();
      this.DispLogBox = new CheckBox();
      this.DriverImpLogBox = new CheckBox();
      this.VelocityLogBox = new CheckBox();
      this.InputImplogbox = new CheckBox();
      this.GroupDelayLogbox = new CheckBox();
      this.SystemImpLogbox = new CheckBox();
      this.FreqLogbox = new CheckBox();
      this.LpLogBox = new CheckBox();
      this.UnitsTabPage = new TabPage();
      this.AnglePrecisionBox = new ComboBox();
      this.AreaPrecisionBox = new ComboBox();
      this.LengthPrecisionBox = new ComboBox();
      this.AngleUnitBox = new ComboBox();
      this.AreaUnitbox = new ComboBox();
      this.LengthUnitBox = new ComboBox();
      this.Label20 = new Label();
      this.Label12 = new Label();
      this.Label24 = new Label();
      this.Label4 = new Label();
      this.Label17 = new Label();
      this.Label22 = new Label();
      this.Label9 = new Label();
      this.Label15 = new Label();
      this.Label7 = new Label();
      this.Label19 = new Label();
      this.Label11 = new Label();
      this.Label3 = new Label();
      this.TabPage1 = new TabPage();
      this.Label26 = new Label();
      this.PanButtonBox = new ComboBox();
      this.ApplyButton = new Button();
      this.TabPage2 = new TabPage();
      this.TableLayoutPanel2 = new TableLayoutPanel();
      this.Label30 = new Label();
      this.SpeedOfSoundBox = new TextBox();
      this.SoSUnit = new Label();
      this.TabControl1.SuspendLayout();
      this.GeneralTab.SuspendLayout();
      this.UndoRedoHistoryUpDown.BeginInit();
      this.GraphTab.SuspendLayout();
      this.TableLayoutPanel1.SuspendLayout();
      this.UnitsTabPage.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.TabPage2.SuspendLayout();
      this.TableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      this.TabControl1.Controls.Add((Control) this.GeneralTab);
      this.TabControl1.Controls.Add((Control) this.GraphTab);
      this.TabControl1.Controls.Add((Control) this.UnitsTabPage);
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      TabControl tabControl1_1 = this.TabControl1;
      Point point1 = new Point(12, 12);
      Point point2 = point1;
      tabControl1_1.Location = point2;
      this.TabControl1.Multiline = true;
      this.TabControl1.Name = "TabControl1";
      TabControl tabControl1_2 = this.TabControl1;
      point1 = new Point(3, 3);
      Point point3 = point1;
      tabControl1_2.Padding = point3;
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = this.TabControl1;
      Size size1 = new Size(343, 293);
      Size size2 = size1;
      tabControl1_3.Size = size2;
      this.TabControl1.TabIndex = 0;
      this.GeneralTab.Controls.Add((Control) this.UndoRedoHistoryUpDown);
      this.GeneralTab.Controls.Add((Control) this.DriverLibBrowseButton);
      this.GeneralTab.Controls.Add((Control) this.Label28);
      this.GeneralTab.Controls.Add((Control) this.Label1);
      this.GeneralTab.Controls.Add((Control) this.DriverLibraryBox);
      TabPage generalTab1 = this.GeneralTab;
      point1 = new Point(4, 22);
      Point point4 = point1;
      generalTab1.Location = point4;
      this.GeneralTab.Name = "GeneralTab";
      TabPage generalTab2 = this.GeneralTab;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      generalTab2.Padding = padding2;
      TabPage generalTab3 = this.GeneralTab;
      size1 = new Size(335, 267);
      Size size3 = size1;
      generalTab3.Size = size3;
      this.GeneralTab.TabIndex = 0;
      this.GeneralTab.Text = "General";
      this.GeneralTab.UseVisualStyleBackColor = true;
      NumericUpDown redoHistoryUpDown1 = this.UndoRedoHistoryUpDown;
      point1 = new Point(130, 32);
      Point point5 = point1;
      redoHistoryUpDown1.Location = point5;
      NumericUpDown redoHistoryUpDown2 = this.UndoRedoHistoryUpDown;
      Decimal num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num2 = num1;
      redoHistoryUpDown2.Minimum = num2;
      this.UndoRedoHistoryUpDown.Name = "UndoRedoHistoryUpDown";
      NumericUpDown redoHistoryUpDown3 = this.UndoRedoHistoryUpDown;
      size1 = new Size(132, 20);
      Size size4 = size1;
      redoHistoryUpDown3.Size = size4;
      this.UndoRedoHistoryUpDown.TabIndex = 3;
      NumericUpDown redoHistoryUpDown4 = this.UndoRedoHistoryUpDown;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      redoHistoryUpDown4.Value = num3;
      Button driverLibBrowseButton1 = this.DriverLibBrowseButton;
      point1 = new Point(268, 6);
      Point point6 = point1;
      driverLibBrowseButton1.Location = point6;
      this.DriverLibBrowseButton.Name = "DriverLibBrowseButton";
      Button driverLibBrowseButton2 = this.DriverLibBrowseButton;
      size1 = new Size(59, 20);
      Size size5 = size1;
      driverLibBrowseButton2.Size = size5;
      this.DriverLibBrowseButton.TabIndex = 2;
      this.DriverLibBrowseButton.Text = "Browse...";
      this.DriverLibBrowseButton.UseVisualStyleBackColor = true;
      Label label28_1 = this.Label28;
      point1 = new Point(7, 32);
      Point point7 = point1;
      label28_1.Location = point7;
      this.Label28.Name = "Label28";
      Label label28_2 = this.Label28;
      size1 = new Size(121, 20);
      Size size6 = size1;
      label28_2.Size = size6;
      this.Label28.TabIndex = 1;
      this.Label28.Text = "Undo/Redo History:";
      this.Label28.TextAlign = ContentAlignment.MiddleLeft;
      Label label1_1 = this.Label1;
      point1 = new Point(7, 6);
      Point point8 = point1;
      label1_1.Location = point8;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(121, 20);
      Size size7 = size1;
      label1_2.Size = size7;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Driver Library Location:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      TextBox driverLibraryBox1 = this.DriverLibraryBox;
      point1 = new Point(130, 6);
      Point point9 = point1;
      driverLibraryBox1.Location = point9;
      this.DriverLibraryBox.Name = "DriverLibraryBox";
      this.DriverLibraryBox.ReadOnly = true;
      TextBox driverLibraryBox2 = this.DriverLibraryBox;
      size1 = new Size(132, 20);
      Size size8 = size1;
      driverLibraryBox2.Size = size8;
      this.DriverLibraryBox.TabIndex = 0;
      this.GraphTab.Controls.Add((Control) this.TableLayoutPanel1);
      TabPage graphTab1 = this.GraphTab;
      point1 = new Point(4, 22);
      Point point10 = point1;
      graphTab1.Location = point10;
      this.GraphTab.Name = "GraphTab";
      TabPage graphTab2 = this.GraphTab;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      graphTab2.Padding = padding3;
      TabPage graphTab3 = this.GraphTab;
      size1 = new Size(335, 267);
      Size size9 = size1;
      graphTab3.Size = size9;
      this.GraphTab.TabIndex = 1;
      this.GraphTab.Text = "Graphs";
      this.GraphTab.UseVisualStyleBackColor = true;
      this.TableLayoutPanel1.ColumnCount = 5;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel1.Controls.Add((Control) this.Label6, 0, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label8, 0, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label10, 0, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.RadImpMinBox, 1, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.DriverImpMinBox, 1, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.InputImpMinBox, 1, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label29, 3, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label31, 3, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label33, 3, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.VelMaxBox, 2, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.DispMaxBox, 2, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label37, 3, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.GroupDelayMaxBox, 2, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label14, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.LpMinBox, 1, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label21, 3, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label16, 0, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.DispMinBox, 1, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.DriverImpMaxBox, 2, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label18, 0, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.VelMinBox, 1, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.InputImpMaxBox, 2, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label25, 3, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label34, 0, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.SystemImpMaxBox, 2, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label27, 3, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label13, 0, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label2, 0, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.LpMaxBox, 2, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.SystemImpMinBox, 1, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.StartFreqBox, 1, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.RadImpMaxBox, 2, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.GroupDelayMinBox, 1, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.EndFreqBox, 2, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label23, 3, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label5, 3, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label38, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label39, 4, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.RadImpLogBox, 4, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.DispLogBox, 4, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.DriverImpLogBox, 4, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.VelocityLogBox, 4, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.InputImplogbox, 4, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.GroupDelayLogbox, 4, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.SystemImpLogbox, 4, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.FreqLogbox, 4, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.LpLogBox, 4, 1);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      point1 = new Point(3, 3);
      Point point11 = point1;
      tableLayoutPanel1_1.Location = point11;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 10;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      size1 = new Size(329, 261);
      Size size10 = size1;
      tableLayoutPanel1_2.Size = size10;
      this.TableLayoutPanel1.TabIndex = 0;
      this.Label6.Dock = DockStyle.Fill;
      Label label6_1 = this.Label6;
      point1 = new Point(3, 55);
      Point point12 = point1;
      label6_1.Location = point12;
      Label label6_2 = this.Label6;
      padding1 = new Padding(3);
      Padding padding4 = padding1;
      label6_2.Margin = padding4;
      this.Label6.Name = "Label6";
      Label label6_3 = this.Label6;
      size1 = new Size(108, 20);
      Size size11 = size1;
      label6_3.Size = size11;
      this.Label6.TabIndex = 2;
      this.Label6.Text = "Radiation Impedance";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      Label label8_1 = this.Label8;
      point1 = new Point(3, 107);
      Point point13 = point1;
      label8_1.Location = point13;
      Label label8_2 = this.Label8;
      padding1 = new Padding(3);
      Padding padding5 = padding1;
      label8_2.Margin = padding5;
      this.Label8.Name = "Label8";
      Label label8_3 = this.Label8;
      size1 = new Size(108, 20);
      Size size12 = size1;
      label8_3.Size = size12;
      this.Label8.TabIndex = 2;
      this.Label8.Text = "Driver Impedance";
      this.Label8.TextAlign = ContentAlignment.MiddleLeft;
      Label label10_1 = this.Label10;
      point1 = new Point(3, 159);
      Point point14 = point1;
      label10_1.Location = point14;
      Label label10_2 = this.Label10;
      padding1 = new Padding(3);
      Padding padding6 = padding1;
      label10_2.Margin = padding6;
      this.Label10.Name = "Label10";
      Label label10_3 = this.Label10;
      size1 = new Size(108, 20);
      Size size13 = size1;
      label10_3.Size = size13;
      this.Label10.TabIndex = 2;
      this.Label10.Text = "Input Impedance";
      this.Label10.TextAlign = ContentAlignment.MiddleLeft;
      this.RadImpMinBox.Anchor = AnchorStyles.Top;
      TextBox radImpMinBox1 = this.RadImpMinBox;
      point1 = new Point(117, 55);
      Point point15 = point1;
      radImpMinBox1.Location = point15;
      this.RadImpMinBox.Name = "RadImpMinBox";
      TextBox radImpMinBox2 = this.RadImpMinBox;
      size1 = new Size(43, 20);
      Size size14 = size1;
      radImpMinBox2.Size = size14;
      this.RadImpMinBox.TabIndex = 1;
      this.RadImpMinBox.Text = "0";
      this.DriverImpMinBox.Anchor = AnchorStyles.Top;
      TextBox driverImpMinBox1 = this.DriverImpMinBox;
      point1 = new Point(117, 107);
      Point point16 = point1;
      driverImpMinBox1.Location = point16;
      this.DriverImpMinBox.Name = "DriverImpMinBox";
      TextBox driverImpMinBox2 = this.DriverImpMinBox;
      size1 = new Size(43, 20);
      Size size15 = size1;
      driverImpMinBox2.Size = size15;
      this.DriverImpMinBox.TabIndex = 1;
      this.DriverImpMinBox.Text = "0";
      this.InputImpMinBox.Anchor = AnchorStyles.Top;
      TextBox inputImpMinBox1 = this.InputImpMinBox;
      point1 = new Point(117, 159);
      Point point17 = point1;
      inputImpMinBox1.Location = point17;
      this.InputImpMinBox.Name = "InputImpMinBox";
      TextBox inputImpMinBox2 = this.InputImpMinBox;
      size1 = new Size(43, 20);
      Size size16 = size1;
      inputImpMinBox2.Size = size16;
      this.InputImpMinBox.TabIndex = 1;
      this.InputImpMinBox.Text = "0";
      Label label29_1 = this.Label29;
      point1 = new Point(218, 29);
      Point point18 = point1;
      label29_1.Location = point18;
      Label label29_2 = this.Label29;
      padding1 = new Padding(3);
      Padding padding7 = padding1;
      label29_2.Margin = padding7;
      this.Label29.Name = "Label29";
      Label label29_3 = this.Label29;
      size1 = new Size(41, 20);
      Size size17 = size1;
      label29_3.Size = size17;
      this.Label29.TabIndex = 0;
      this.Label29.Text = "dB";
      this.Label29.TextAlign = ContentAlignment.MiddleLeft;
      Label label31_1 = this.Label31;
      point1 = new Point(218, 81);
      Point point19 = point1;
      label31_1.Location = point19;
      Label label31_2 = this.Label31;
      padding1 = new Padding(3);
      Padding padding8 = padding1;
      label31_2.Margin = padding8;
      this.Label31.Name = "Label31";
      Label label31_3 = this.Label31;
      size1 = new Size(41, 20);
      Size size18 = size1;
      label31_3.Size = size18;
      this.Label31.TabIndex = 0;
      this.Label31.Text = "mm";
      this.Label31.TextAlign = ContentAlignment.MiddleLeft;
      Label label33_1 = this.Label33;
      point1 = new Point(218, 133);
      Point point20 = point1;
      label33_1.Location = point20;
      Label label33_2 = this.Label33;
      padding1 = new Padding(3);
      Padding padding9 = padding1;
      label33_2.Margin = padding9;
      this.Label33.Name = "Label33";
      Label label33_3 = this.Label33;
      size1 = new Size(41, 20);
      Size size19 = size1;
      label33_3.Size = size19;
      this.Label33.TabIndex = 0;
      this.Label33.Text = "m/s";
      this.Label33.TextAlign = ContentAlignment.MiddleLeft;
      this.VelMaxBox.Anchor = AnchorStyles.Top;
      TextBox velMaxBox1 = this.VelMaxBox;
      point1 = new Point(166, 133);
      Point point21 = point1;
      velMaxBox1.Location = point21;
      this.VelMaxBox.Name = "VelMaxBox";
      TextBox velMaxBox2 = this.VelMaxBox;
      size1 = new Size(46, 20);
      Size size20 = size1;
      velMaxBox2.Size = size20;
      this.VelMaxBox.TabIndex = 1;
      this.VelMaxBox.Text = "1";
      this.DispMaxBox.Anchor = AnchorStyles.Top;
      TextBox dispMaxBox1 = this.DispMaxBox;
      point1 = new Point(166, 81);
      Point point22 = point1;
      dispMaxBox1.Location = point22;
      this.DispMaxBox.Name = "DispMaxBox";
      TextBox dispMaxBox2 = this.DispMaxBox;
      size1 = new Size(46, 20);
      Size size21 = size1;
      dispMaxBox2.Size = size21;
      this.DispMaxBox.TabIndex = 1;
      this.DispMaxBox.Text = "1";
      Label label37_1 = this.Label37;
      point1 = new Point(218, 185);
      Point point23 = point1;
      label37_1.Location = point23;
      Label label37_2 = this.Label37;
      padding1 = new Padding(3);
      Padding padding10 = padding1;
      label37_2.Margin = padding10;
      this.Label37.Name = "Label37";
      Label label37_3 = this.Label37;
      size1 = new Size(41, 20);
      Size size22 = size1;
      label37_3.Size = size22;
      this.Label37.TabIndex = 0;
      this.Label37.Text = "ms";
      this.Label37.TextAlign = ContentAlignment.MiddleLeft;
      this.GroupDelayMaxBox.Anchor = AnchorStyles.Top;
      TextBox groupDelayMaxBox1 = this.GroupDelayMaxBox;
      point1 = new Point(166, 185);
      Point point24 = point1;
      groupDelayMaxBox1.Location = point24;
      this.GroupDelayMaxBox.Name = "GroupDelayMaxBox";
      TextBox groupDelayMaxBox2 = this.GroupDelayMaxBox;
      size1 = new Size(46, 20);
      Size size23 = size1;
      groupDelayMaxBox2.Size = size23;
      this.GroupDelayMaxBox.TabIndex = 1;
      this.GroupDelayMaxBox.Text = "1";
      Label label14_1 = this.Label14;
      point1 = new Point(3, 29);
      Point point25 = point1;
      label14_1.Location = point25;
      Label label14_2 = this.Label14;
      padding1 = new Padding(3);
      Padding padding11 = padding1;
      label14_2.Margin = padding11;
      this.Label14.Name = "Label14";
      Label label14_3 = this.Label14;
      size1 = new Size(108, 20);
      Size size24 = size1;
      label14_3.Size = size24;
      this.Label14.TabIndex = 2;
      this.Label14.Text = "Sound Pressure";
      this.Label14.TextAlign = ContentAlignment.MiddleLeft;
      this.LpMinBox.Anchor = AnchorStyles.Top;
      TextBox lpMinBox1 = this.LpMinBox;
      point1 = new Point(117, 29);
      Point point26 = point1;
      lpMinBox1.Location = point26;
      this.LpMinBox.Name = "LpMinBox";
      TextBox lpMinBox2 = this.LpMinBox;
      size1 = new Size(43, 20);
      Size size25 = size1;
      lpMinBox2.Size = size25;
      this.LpMinBox.TabIndex = 1;
      this.LpMinBox.Text = "0";
      Label label21_1 = this.Label21;
      point1 = new Point(218, 55);
      Point point27 = point1;
      label21_1.Location = point27;
      Label label21_2 = this.Label21;
      padding1 = new Padding(3);
      Padding padding12 = padding1;
      label21_2.Margin = padding12;
      this.Label21.Name = "Label21";
      Label label21_3 = this.Label21;
      size1 = new Size(41, 20);
      Size size26 = size1;
      label21_3.Size = size26;
      this.Label21.TabIndex = 0;
      this.Label21.Text = "N.s/m\u00B3";
      this.Label21.TextAlign = ContentAlignment.MiddleLeft;
      Label label16_1 = this.Label16;
      point1 = new Point(3, 81);
      Point point28 = point1;
      label16_1.Location = point28;
      Label label16_2 = this.Label16;
      padding1 = new Padding(3);
      Padding padding13 = padding1;
      label16_2.Margin = padding13;
      this.Label16.Name = "Label16";
      Label label16_3 = this.Label16;
      size1 = new Size(108, 20);
      Size size27 = size1;
      label16_3.Size = size27;
      this.Label16.TabIndex = 2;
      this.Label16.Text = "Displacement";
      this.Label16.TextAlign = ContentAlignment.MiddleLeft;
      this.DispMinBox.Anchor = AnchorStyles.Top;
      TextBox dispMinBox1 = this.DispMinBox;
      point1 = new Point(117, 81);
      Point point29 = point1;
      dispMinBox1.Location = point29;
      this.DispMinBox.Name = "DispMinBox";
      TextBox dispMinBox2 = this.DispMinBox;
      size1 = new Size(43, 20);
      Size size28 = size1;
      dispMinBox2.Size = size28;
      this.DispMinBox.TabIndex = 1;
      this.DispMinBox.Text = "0";
      this.DriverImpMaxBox.Anchor = AnchorStyles.Top;
      TextBox driverImpMaxBox1 = this.DriverImpMaxBox;
      point1 = new Point(166, 107);
      Point point30 = point1;
      driverImpMaxBox1.Location = point30;
      this.DriverImpMaxBox.Name = "DriverImpMaxBox";
      TextBox driverImpMaxBox2 = this.DriverImpMaxBox;
      size1 = new Size(46, 20);
      Size size29 = size1;
      driverImpMaxBox2.Size = size29;
      this.DriverImpMaxBox.TabIndex = 1;
      this.DriverImpMaxBox.Text = "1";
      Label label18_1 = this.Label18;
      point1 = new Point(3, 133);
      Point point31 = point1;
      label18_1.Location = point31;
      Label label18_2 = this.Label18;
      padding1 = new Padding(3);
      Padding padding14 = padding1;
      label18_2.Margin = padding14;
      this.Label18.Name = "Label18";
      Label label18_3 = this.Label18;
      size1 = new Size(108, 20);
      Size size30 = size1;
      label18_3.Size = size30;
      this.Label18.TabIndex = 2;
      this.Label18.Text = "Velocity";
      this.Label18.TextAlign = ContentAlignment.MiddleLeft;
      this.VelMinBox.Anchor = AnchorStyles.Top;
      TextBox velMinBox1 = this.VelMinBox;
      point1 = new Point(117, 133);
      Point point32 = point1;
      velMinBox1.Location = point32;
      this.VelMinBox.Name = "VelMinBox";
      TextBox velMinBox2 = this.VelMinBox;
      size1 = new Size(43, 20);
      Size size31 = size1;
      velMinBox2.Size = size31;
      this.VelMinBox.TabIndex = 1;
      this.VelMinBox.Text = "0";
      this.InputImpMaxBox.Anchor = AnchorStyles.Top;
      TextBox inputImpMaxBox1 = this.InputImpMaxBox;
      point1 = new Point(166, 159);
      Point point33 = point1;
      inputImpMaxBox1.Location = point33;
      this.InputImpMaxBox.Name = "InputImpMaxBox";
      TextBox inputImpMaxBox2 = this.InputImpMaxBox;
      size1 = new Size(46, 20);
      Size size32 = size1;
      inputImpMaxBox2.Size = size32;
      this.InputImpMaxBox.TabIndex = 1;
      this.InputImpMaxBox.Text = "1";
      Label label25_1 = this.Label25;
      point1 = new Point(218, 159);
      Point point34 = point1;
      label25_1.Location = point34;
      Label label25_2 = this.Label25;
      padding1 = new Padding(3);
      Padding padding15 = padding1;
      label25_2.Margin = padding15;
      this.Label25.Name = "Label25";
      Label label25_3 = this.Label25;
      size1 = new Size(41, 20);
      Size size33 = size1;
      label25_3.Size = size33;
      this.Label25.TabIndex = 0;
      this.Label25.Text = "N.s/m\u00B3";
      this.Label25.TextAlign = ContentAlignment.MiddleLeft;
      Label label34_1 = this.Label34;
      point1 = new Point(3, 185);
      Point point35 = point1;
      label34_1.Location = point35;
      Label label34_2 = this.Label34;
      padding1 = new Padding(3);
      Padding padding16 = padding1;
      label34_2.Margin = padding16;
      this.Label34.Name = "Label34";
      Label label34_3 = this.Label34;
      size1 = new Size(108, 20);
      Size size34 = size1;
      label34_3.Size = size34;
      this.Label34.TabIndex = 2;
      this.Label34.Text = "Group Delay";
      this.Label34.TextAlign = ContentAlignment.MiddleLeft;
      this.SystemImpMaxBox.Anchor = AnchorStyles.Top;
      TextBox systemImpMaxBox1 = this.SystemImpMaxBox;
      point1 = new Point(166, 211);
      Point point36 = point1;
      systemImpMaxBox1.Location = point36;
      this.SystemImpMaxBox.Name = "SystemImpMaxBox";
      TextBox systemImpMaxBox2 = this.SystemImpMaxBox;
      size1 = new Size(46, 20);
      Size size35 = size1;
      systemImpMaxBox2.Size = size35;
      this.SystemImpMaxBox.TabIndex = 1;
      this.SystemImpMaxBox.Text = "1";
      Label label27_1 = this.Label27;
      point1 = new Point(218, 211);
      Point point37 = point1;
      label27_1.Location = point37;
      Label label27_2 = this.Label27;
      padding1 = new Padding(3);
      Padding padding17 = padding1;
      label27_2.Margin = padding17;
      this.Label27.Name = "Label27";
      Label label27_3 = this.Label27;
      size1 = new Size(41, 20);
      Size size36 = size1;
      label27_3.Size = size36;
      this.Label27.TabIndex = 0;
      this.Label27.Text = "Ω";
      this.Label27.TextAlign = ContentAlignment.MiddleLeft;
      Label label13_1 = this.Label13;
      point1 = new Point(3, 211);
      Point point38 = point1;
      label13_1.Location = point38;
      Label label13_2 = this.Label13;
      padding1 = new Padding(3);
      Padding padding18 = padding1;
      label13_2.Margin = padding18;
      this.Label13.Name = "Label13";
      Label label13_3 = this.Label13;
      size1 = new Size(108, 20);
      Size size37 = size1;
      label13_3.Size = size37;
      this.Label13.TabIndex = 2;
      this.Label13.Text = "System Impedance";
      this.Label13.TextAlign = ContentAlignment.MiddleLeft;
      Label label2_1 = this.Label2;
      point1 = new Point(3, 237);
      Point point39 = point1;
      label2_1.Location = point39;
      Label label2_2 = this.Label2;
      padding1 = new Padding(3);
      Padding padding19 = padding1;
      label2_2.Margin = padding19;
      this.Label2.Name = "Label2";
      Label label2_3 = this.Label2;
      size1 = new Size(82, 20);
      Size size38 = size1;
      label2_3.Size = size38;
      this.Label2.TabIndex = 0;
      this.Label2.Text = "Frequency";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.LpMaxBox.Anchor = AnchorStyles.Top;
      TextBox lpMaxBox1 = this.LpMaxBox;
      point1 = new Point(166, 29);
      Point point40 = point1;
      lpMaxBox1.Location = point40;
      this.LpMaxBox.Name = "LpMaxBox";
      TextBox lpMaxBox2 = this.LpMaxBox;
      size1 = new Size(46, 20);
      Size size39 = size1;
      lpMaxBox2.Size = size39;
      this.LpMaxBox.TabIndex = 1;
      this.LpMaxBox.Text = "1";
      this.SystemImpMinBox.Anchor = AnchorStyles.Top;
      TextBox systemImpMinBox1 = this.SystemImpMinBox;
      point1 = new Point(117, 211);
      Point point41 = point1;
      systemImpMinBox1.Location = point41;
      this.SystemImpMinBox.Name = "SystemImpMinBox";
      TextBox systemImpMinBox2 = this.SystemImpMinBox;
      size1 = new Size(43, 20);
      Size size40 = size1;
      systemImpMinBox2.Size = size40;
      this.SystemImpMinBox.TabIndex = 1;
      this.SystemImpMinBox.Text = "0";
      this.StartFreqBox.Anchor = AnchorStyles.Top;
      TextBox startFreqBox1 = this.StartFreqBox;
      point1 = new Point(117, 237);
      Point point42 = point1;
      startFreqBox1.Location = point42;
      this.StartFreqBox.Name = "StartFreqBox";
      TextBox startFreqBox2 = this.StartFreqBox;
      size1 = new Size(43, 20);
      Size size41 = size1;
      startFreqBox2.Size = size41;
      this.StartFreqBox.TabIndex = 1;
      this.StartFreqBox.Text = "0";
      this.RadImpMaxBox.Anchor = AnchorStyles.Top;
      TextBox radImpMaxBox1 = this.RadImpMaxBox;
      point1 = new Point(166, 55);
      Point point43 = point1;
      radImpMaxBox1.Location = point43;
      this.RadImpMaxBox.Name = "RadImpMaxBox";
      TextBox radImpMaxBox2 = this.RadImpMaxBox;
      size1 = new Size(46, 20);
      Size size42 = size1;
      radImpMaxBox2.Size = size42;
      this.RadImpMaxBox.TabIndex = 1;
      this.RadImpMaxBox.Text = "1";
      this.GroupDelayMinBox.Anchor = AnchorStyles.Top;
      TextBox groupDelayMinBox1 = this.GroupDelayMinBox;
      point1 = new Point(117, 185);
      Point point44 = point1;
      groupDelayMinBox1.Location = point44;
      this.GroupDelayMinBox.Name = "GroupDelayMinBox";
      TextBox groupDelayMinBox2 = this.GroupDelayMinBox;
      size1 = new Size(43, 20);
      Size size43 = size1;
      groupDelayMinBox2.Size = size43;
      this.GroupDelayMinBox.TabIndex = 1;
      this.GroupDelayMinBox.Text = "0";
      this.EndFreqBox.Anchor = AnchorStyles.Top;
      TextBox endFreqBox1 = this.EndFreqBox;
      point1 = new Point(166, 237);
      Point point45 = point1;
      endFreqBox1.Location = point45;
      this.EndFreqBox.Name = "EndFreqBox";
      TextBox endFreqBox2 = this.EndFreqBox;
      size1 = new Size(46, 20);
      Size size44 = size1;
      endFreqBox2.Size = size44;
      this.EndFreqBox.TabIndex = 1;
      this.EndFreqBox.Text = "1";
      Label label23_1 = this.Label23;
      point1 = new Point(218, 107);
      Point point46 = point1;
      label23_1.Location = point46;
      Label label23_2 = this.Label23;
      padding1 = new Padding(3);
      Padding padding20 = padding1;
      label23_2.Margin = padding20;
      this.Label23.Name = "Label23";
      Label label23_3 = this.Label23;
      size1 = new Size(41, 20);
      Size size45 = size1;
      label23_3.Size = size45;
      this.Label23.TabIndex = 0;
      this.Label23.Text = "Ω";
      this.Label23.TextAlign = ContentAlignment.MiddleLeft;
      Label label5_1 = this.Label5;
      point1 = new Point(218, 237);
      Point point47 = point1;
      label5_1.Location = point47;
      Label label5_2 = this.Label5;
      padding1 = new Padding(3);
      Padding padding21 = padding1;
      label5_2.Margin = padding21;
      this.Label5.Name = "Label5";
      Label label5_3 = this.Label5;
      size1 = new Size(30, 20);
      Size size46 = size1;
      label5_3.Size = size46;
      this.Label5.TabIndex = 0;
      this.Label5.Text = "Hz";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.Label38, 4);
      this.Label38.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label38_1 = this.Label38;
      point1 = new Point(3, 3);
      Point point48 = point1;
      label38_1.Location = point48;
      Label label38_2 = this.Label38;
      padding1 = new Padding(3);
      Padding padding22 = padding1;
      label38_2.Margin = padding22;
      this.Label38.Name = "Label38";
      Label label38_3 = this.Label38;
      size1 = new Size(256, 20);
      Size size47 = size1;
      label38_3.Size = size47;
      this.Label38.TabIndex = 0;
      this.Label38.Text = "Axis Minimum and Maximum Values";
      this.Label38.TextAlign = ContentAlignment.MiddleCenter;
      this.Label39.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label39_1 = this.Label39;
      point1 = new Point(265, 3);
      Point point49 = point1;
      label39_1.Location = point49;
      Label label39_2 = this.Label39;
      padding1 = new Padding(3);
      Padding padding23 = padding1;
      label39_2.Margin = padding23;
      this.Label39.Name = "Label39";
      Label label39_3 = this.Label39;
      size1 = new Size(64, 20);
      Size size48 = size1;
      label39_3.Size = size48;
      this.Label39.TabIndex = 0;
      this.Label39.Text = "Log Scale";
      this.Label39.TextAlign = ContentAlignment.MiddleLeft;
      this.RadImpLogBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.RadImpLogBox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox radImpLogBox1 = this.RadImpLogBox;
      point1 = new Point(265, 55);
      Point point50 = point1;
      radImpLogBox1.Location = point50;
      this.RadImpLogBox.Name = "RadImpLogBox";
      CheckBox radImpLogBox2 = this.RadImpLogBox;
      size1 = new Size(61, 20);
      Size size49 = size1;
      radImpLogBox2.Size = size49;
      this.RadImpLogBox.TabIndex = 3;
      this.RadImpLogBox.UseVisualStyleBackColor = true;
      this.DispLogBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.DispLogBox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox dispLogBox1 = this.DispLogBox;
      point1 = new Point(265, 81);
      Point point51 = point1;
      dispLogBox1.Location = point51;
      this.DispLogBox.Name = "DispLogBox";
      CheckBox dispLogBox2 = this.DispLogBox;
      size1 = new Size(61, 20);
      Size size50 = size1;
      dispLogBox2.Size = size50;
      this.DispLogBox.TabIndex = 3;
      this.DispLogBox.UseVisualStyleBackColor = true;
      this.DriverImpLogBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.DriverImpLogBox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox driverImpLogBox1 = this.DriverImpLogBox;
      point1 = new Point(265, 107);
      Point point52 = point1;
      driverImpLogBox1.Location = point52;
      this.DriverImpLogBox.Name = "DriverImpLogBox";
      CheckBox driverImpLogBox2 = this.DriverImpLogBox;
      size1 = new Size(61, 20);
      Size size51 = size1;
      driverImpLogBox2.Size = size51;
      this.DriverImpLogBox.TabIndex = 3;
      this.DriverImpLogBox.UseVisualStyleBackColor = true;
      this.VelocityLogBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.VelocityLogBox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox velocityLogBox1 = this.VelocityLogBox;
      point1 = new Point(265, 133);
      Point point53 = point1;
      velocityLogBox1.Location = point53;
      this.VelocityLogBox.Name = "VelocityLogBox";
      CheckBox velocityLogBox2 = this.VelocityLogBox;
      size1 = new Size(61, 20);
      Size size52 = size1;
      velocityLogBox2.Size = size52;
      this.VelocityLogBox.TabIndex = 3;
      this.VelocityLogBox.UseVisualStyleBackColor = true;
      this.InputImplogbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.InputImplogbox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox inputImplogbox1 = this.InputImplogbox;
      point1 = new Point(265, 159);
      Point point54 = point1;
      inputImplogbox1.Location = point54;
      this.InputImplogbox.Name = "InputImplogbox";
      CheckBox inputImplogbox2 = this.InputImplogbox;
      size1 = new Size(61, 20);
      Size size53 = size1;
      inputImplogbox2.Size = size53;
      this.InputImplogbox.TabIndex = 3;
      this.InputImplogbox.UseVisualStyleBackColor = true;
      this.GroupDelayLogbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.GroupDelayLogbox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox groupDelayLogbox1 = this.GroupDelayLogbox;
      point1 = new Point(265, 185);
      Point point55 = point1;
      groupDelayLogbox1.Location = point55;
      this.GroupDelayLogbox.Name = "GroupDelayLogbox";
      CheckBox groupDelayLogbox2 = this.GroupDelayLogbox;
      size1 = new Size(61, 20);
      Size size54 = size1;
      groupDelayLogbox2.Size = size54;
      this.GroupDelayLogbox.TabIndex = 3;
      this.GroupDelayLogbox.UseVisualStyleBackColor = true;
      this.SystemImpLogbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.SystemImpLogbox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox systemImpLogbox1 = this.SystemImpLogbox;
      point1 = new Point(265, 211);
      Point point56 = point1;
      systemImpLogbox1.Location = point56;
      this.SystemImpLogbox.Name = "SystemImpLogbox";
      CheckBox systemImpLogbox2 = this.SystemImpLogbox;
      size1 = new Size(61, 20);
      Size size55 = size1;
      systemImpLogbox2.Size = size55;
      this.SystemImpLogbox.TabIndex = 3;
      this.SystemImpLogbox.UseVisualStyleBackColor = true;
      this.FreqLogbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.FreqLogbox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox freqLogbox1 = this.FreqLogbox;
      point1 = new Point(265, 237);
      Point point57 = point1;
      freqLogbox1.Location = point57;
      this.FreqLogbox.Name = "FreqLogbox";
      CheckBox freqLogbox2 = this.FreqLogbox;
      size1 = new Size(61, 21);
      Size size56 = size1;
      freqLogbox2.Size = size56;
      this.FreqLogbox.TabIndex = 3;
      this.FreqLogbox.UseVisualStyleBackColor = true;
      this.LpLogBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.LpLogBox.CheckAlign = ContentAlignment.MiddleCenter;
      CheckBox lpLogBox1 = this.LpLogBox;
      point1 = new Point(265, 29);
      Point point58 = point1;
      lpLogBox1.Location = point58;
      this.LpLogBox.Name = "LpLogBox";
      CheckBox lpLogBox2 = this.LpLogBox;
      size1 = new Size(61, 20);
      Size size57 = size1;
      lpLogBox2.Size = size57;
      this.LpLogBox.TabIndex = 3;
      this.LpLogBox.UseVisualStyleBackColor = true;
      this.UnitsTabPage.Controls.Add((Control) this.AnglePrecisionBox);
      this.UnitsTabPage.Controls.Add((Control) this.AreaPrecisionBox);
      this.UnitsTabPage.Controls.Add((Control) this.LengthPrecisionBox);
      this.UnitsTabPage.Controls.Add((Control) this.AngleUnitBox);
      this.UnitsTabPage.Controls.Add((Control) this.AreaUnitbox);
      this.UnitsTabPage.Controls.Add((Control) this.LengthUnitBox);
      this.UnitsTabPage.Controls.Add((Control) this.Label20);
      this.UnitsTabPage.Controls.Add((Control) this.Label12);
      this.UnitsTabPage.Controls.Add((Control) this.Label24);
      this.UnitsTabPage.Controls.Add((Control) this.Label4);
      this.UnitsTabPage.Controls.Add((Control) this.Label17);
      this.UnitsTabPage.Controls.Add((Control) this.Label22);
      this.UnitsTabPage.Controls.Add((Control) this.Label9);
      this.UnitsTabPage.Controls.Add((Control) this.Label15);
      this.UnitsTabPage.Controls.Add((Control) this.Label7);
      this.UnitsTabPage.Controls.Add((Control) this.Label19);
      this.UnitsTabPage.Controls.Add((Control) this.Label11);
      this.UnitsTabPage.Controls.Add((Control) this.Label3);
      TabPage unitsTabPage1 = this.UnitsTabPage;
      point1 = new Point(4, 22);
      Point point59 = point1;
      unitsTabPage1.Location = point59;
      this.UnitsTabPage.Name = "UnitsTabPage";
      TabPage unitsTabPage2 = this.UnitsTabPage;
      padding1 = new Padding(3);
      Padding padding24 = padding1;
      unitsTabPage2.Padding = padding24;
      TabPage unitsTabPage3 = this.UnitsTabPage;
      size1 = new Size(335, 267);
      Size size58 = size1;
      unitsTabPage3.Size = size58;
      this.UnitsTabPage.TabIndex = 2;
      this.UnitsTabPage.Text = "Units";
      this.UnitsTabPage.UseVisualStyleBackColor = true;
      this.AnglePrecisionBox.FormattingEnabled = true;
      ComboBox anglePrecisionBox1 = this.AnglePrecisionBox;
      point1 = new Point(92, 225);
      Point point60 = point1;
      anglePrecisionBox1.Location = point60;
      this.AnglePrecisionBox.Name = "AnglePrecisionBox";
      ComboBox anglePrecisionBox2 = this.AnglePrecisionBox;
      size1 = new Size(121, 21);
      Size size59 = size1;
      anglePrecisionBox2.Size = size59;
      this.AnglePrecisionBox.TabIndex = 2;
      this.AreaPrecisionBox.FormattingEnabled = true;
      ComboBox areaPrecisionBox1 = this.AreaPrecisionBox;
      point1 = new Point(92, 143);
      Point point61 = point1;
      areaPrecisionBox1.Location = point61;
      this.AreaPrecisionBox.Name = "AreaPrecisionBox";
      ComboBox areaPrecisionBox2 = this.AreaPrecisionBox;
      size1 = new Size(121, 21);
      Size size60 = size1;
      areaPrecisionBox2.Size = size60;
      this.AreaPrecisionBox.TabIndex = 2;
      this.LengthPrecisionBox.FormattingEnabled = true;
      ComboBox lengthPrecisionBox1 = this.LengthPrecisionBox;
      point1 = new Point(92, 61);
      Point point62 = point1;
      lengthPrecisionBox1.Location = point62;
      this.LengthPrecisionBox.Name = "LengthPrecisionBox";
      ComboBox lengthPrecisionBox2 = this.LengthPrecisionBox;
      size1 = new Size(121, 21);
      Size size61 = size1;
      lengthPrecisionBox2.Size = size61;
      this.LengthPrecisionBox.TabIndex = 2;
      this.AngleUnitBox.FormattingEnabled = true;
      ComboBox angleUnitBox1 = this.AngleUnitBox;
      point1 = new Point(92, 199);
      Point point63 = point1;
      angleUnitBox1.Location = point63;
      this.AngleUnitBox.Name = "AngleUnitBox";
      ComboBox angleUnitBox2 = this.AngleUnitBox;
      size1 = new Size(121, 21);
      Size size62 = size1;
      angleUnitBox2.Size = size62;
      this.AngleUnitBox.TabIndex = 2;
      this.AreaUnitbox.FormattingEnabled = true;
      ComboBox areaUnitbox1 = this.AreaUnitbox;
      point1 = new Point(92, 117);
      Point point64 = point1;
      areaUnitbox1.Location = point64;
      this.AreaUnitbox.Name = "AreaUnitbox";
      ComboBox areaUnitbox2 = this.AreaUnitbox;
      size1 = new Size(121, 21);
      Size size63 = size1;
      areaUnitbox2.Size = size63;
      this.AreaUnitbox.TabIndex = 2;
      this.LengthUnitBox.FormattingEnabled = true;
      ComboBox lengthUnitBox1 = this.LengthUnitBox;
      point1 = new Point(92, 35);
      Point point65 = point1;
      lengthUnitBox1.Location = point65;
      this.LengthUnitBox.Name = "LengthUnitBox";
      ComboBox lengthUnitBox2 = this.LengthUnitBox;
      size1 = new Size(121, 21);
      Size size64 = size1;
      lengthUnitBox2.Size = size64;
      this.LengthUnitBox.TabIndex = 2;
      this.Label20.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.Label20.BorderStyle = BorderStyle.Fixed3D;
      Label label20_1 = this.Label20;
      point1 = new Point(3, 192);
      Point point66 = point1;
      label20_1.Location = point66;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(317, 2);
      Size size65 = size1;
      label20_2.Size = size65;
      this.Label20.TabIndex = 1;
      this.Label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.Label12.BorderStyle = BorderStyle.Fixed3D;
      Label label12_1 = this.Label12;
      point1 = new Point(8, 110);
      Point point67 = point1;
      label12_1.Location = point67;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(317, 2);
      Size size66 = size1;
      label12_2.Size = size66;
      this.Label12.TabIndex = 1;
      this.Label24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label24_1 = this.Label24;
      point1 = new Point(7, 225);
      Point point68 = point1;
      label24_1.Location = point68;
      this.Label24.Name = "Label24";
      Label label24_2 = this.Label24;
      size1 = new Size(79, 21);
      Size size67 = size1;
      label24_2.Size = size67;
      this.Label24.TabIndex = 0;
      this.Label24.Text = "Precision:";
      this.Label24.TextAlign = ContentAlignment.MiddleRight;
      this.Label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.Label4.BorderStyle = BorderStyle.Fixed3D;
      Label label4_1 = this.Label4;
      point1 = new Point(9, 25);
      Point point69 = point1;
      label4_1.Location = point69;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(317, 2);
      Size size68 = size1;
      label4_2.Size = size68;
      this.Label4.TabIndex = 1;
      this.Label17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label17_1 = this.Label17;
      point1 = new Point(7, 143);
      Point point70 = point1;
      label17_1.Location = point70;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(79, 21);
      Size size69 = size1;
      label17_2.Size = size69;
      this.Label17.TabIndex = 0;
      this.Label17.Text = "Precision:";
      this.Label17.TextAlign = ContentAlignment.MiddleRight;
      this.Label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label22_1 = this.Label22;
      point1 = new Point(7, 199);
      Point point71 = point1;
      label22_1.Location = point71;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(79, 21);
      Size size70 = size1;
      label22_2.Size = size70;
      this.Label22.TabIndex = 0;
      this.Label22.Text = "Unit:";
      this.Label22.TextAlign = ContentAlignment.MiddleRight;
      this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label9_1 = this.Label9;
      point1 = new Point(7, 61);
      Point point72 = point1;
      label9_1.Location = point72;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(79, 21);
      Size size71 = size1;
      label9_2.Size = size71;
      this.Label9.TabIndex = 0;
      this.Label9.Text = "Precision:";
      this.Label9.TextAlign = ContentAlignment.MiddleRight;
      this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label15_1 = this.Label15;
      point1 = new Point(7, 117);
      Point point73 = point1;
      label15_1.Location = point73;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(79, 21);
      Size size72 = size1;
      label15_2.Size = size72;
      this.Label15.TabIndex = 0;
      this.Label15.Text = "Unit:";
      this.Label15.TextAlign = ContentAlignment.MiddleRight;
      this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label7_1 = this.Label7;
      point1 = new Point(7, 35);
      Point point74 = point1;
      label7_1.Location = point74;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(79, 21);
      Size size73 = size1;
      label7_2.Size = size73;
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Unit:";
      this.Label7.TextAlign = ContentAlignment.MiddleRight;
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label19_1 = this.Label19;
      point1 = new Point(7, 174);
      Point point75 = point1;
      label19_1.Location = point75;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(72, 13);
      Size size74 = size1;
      label19_2.Size = size74;
      this.Label19.TabIndex = 0;
      this.Label19.Text = "Angle Units";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label11_1 = this.Label11;
      point1 = new Point(6, 92);
      Point point76 = point1;
      label11_1.Location = point76;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(66, 13);
      Size size75 = size1;
      label11_2.Size = size75;
      this.Label11.TabIndex = 0;
      this.Label11.Text = "Area Units";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(7, 7);
      Point point77 = point1;
      label3_1.Location = point77;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(79, 13);
      Size size76 = size1;
      label3_2.Size = size76;
      this.Label3.TabIndex = 0;
      this.Label3.Text = "Length Units";
      this.TabPage1.Controls.Add((Control) this.Label26);
      this.TabPage1.Controls.Add((Control) this.PanButtonBox);
      TabPage tabPage1_1 = this.TabPage1;
      point1 = new Point(4, 22);
      Point point78 = point1;
      tabPage1_1.Location = point78;
      this.TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = this.TabPage1;
      padding1 = new Padding(3);
      Padding padding25 = padding1;
      tabPage1_2.Padding = padding25;
      TabPage tabPage1_3 = this.TabPage1;
      size1 = new Size(335, 267);
      Size size77 = size1;
      tabPage1_3.Size = size77;
      this.TabPage1.TabIndex = 3;
      this.TabPage1.Text = "Mouse";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.Label26.AutoSize = true;
      Label label26_1 = this.Label26;
      point1 = new Point(7, 13);
      Point point79 = point1;
      label26_1.Location = point79;
      this.Label26.Name = "Label26";
      Label label26_2 = this.Label26;
      size1 = new Size(148, 13);
      Size size78 = size1;
      label26_2.Size = size78;
      this.Label26.TabIndex = 1;
      this.Label26.Text = "Geometry Display Pan Button:";
      this.PanButtonBox.FormattingEnabled = true;
      this.PanButtonBox.Items.AddRange(new object[2]
      {
        (object) "Middle Mouse Button",
        (object) "Right Mouse Button"
      });
      ComboBox panButtonBox1 = this.PanButtonBox;
      point1 = new Point(158, 10);
      Point point80 = point1;
      panButtonBox1.Location = point80;
      this.PanButtonBox.Name = "PanButtonBox";
      ComboBox panButtonBox2 = this.PanButtonBox;
      size1 = new Size(171, 21);
      Size size79 = size1;
      panButtonBox2.Size = size79;
      this.PanButtonBox.TabIndex = 0;
      Button applyButton1 = this.ApplyButton;
      point1 = new Point(280, 307);
      Point point81 = point1;
      applyButton1.Location = point81;
      this.ApplyButton.Name = "ApplyButton";
      Button applyButton2 = this.ApplyButton;
      size1 = new Size(75, 23);
      Size size80 = size1;
      applyButton2.Size = size80;
      this.ApplyButton.TabIndex = 1;
      this.ApplyButton.Text = "Apply";
      this.ApplyButton.UseVisualStyleBackColor = true;
      this.TabPage2.Controls.Add((Control) this.TableLayoutPanel2);
      TabPage tabPage2_1 = this.TabPage2;
      point1 = new Point(4, 22);
      Point point82 = point1;
      tabPage2_1.Location = point82;
      this.TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = this.TabPage2;
      padding1 = new Padding(3);
      Padding padding26 = padding1;
      tabPage2_2.Padding = padding26;
      TabPage tabPage2_3 = this.TabPage2;
      size1 = new Size(335, 267);
      Size size81 = size1;
      tabPage2_3.Size = size81;
      this.TabPage2.TabIndex = 4;
      this.TabPage2.Text = "Environment";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.TableLayoutPanel2.AutoSize = true;
      this.TableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.TableLayoutPanel2.ColumnCount = 3;
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44f));
      this.TableLayoutPanel2.Controls.Add((Control) this.Label30, 0, 0);
      this.TableLayoutPanel2.Controls.Add((Control) this.SpeedOfSoundBox, 1, 0);
      this.TableLayoutPanel2.Controls.Add((Control) this.SoSUnit, 2, 0);
      TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
      point1 = new Point(6, 6);
      Point point83 = point1;
      tableLayoutPanel2_1.Location = point83;
      this.TableLayoutPanel2.Name = "TableLayoutPanel2";
      this.TableLayoutPanel2.RowCount = 2;
      this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
      this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
      TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
      size1 = new Size(320, 50);
      Size size82 = size1;
      tableLayoutPanel2_2.Size = size82;
      this.TableLayoutPanel2.TabIndex = 0;
      this.Label30.AutoSize = true;
      this.Label30.Dock = DockStyle.Fill;
      Label label30_1 = this.Label30;
      point1 = new Point(3, 0);
      Point point84 = point1;
      label30_1.Location = point84;
      this.Label30.Name = "Label30";
      Label label30_2 = this.Label30;
      size1 = new Size(108, 25);
      Size size83 = size1;
      label30_2.Size = size83;
      this.Label30.TabIndex = 0;
      this.Label30.Text = "Speed of Sound";
      this.Label30.TextAlign = ContentAlignment.MiddleLeft;
      this.SpeedOfSoundBox.Dock = DockStyle.Fill;
      TextBox speedOfSoundBox1 = this.SpeedOfSoundBox;
      point1 = new Point(117, 3);
      Point point85 = point1;
      speedOfSoundBox1.Location = point85;
      this.SpeedOfSoundBox.Name = "SpeedOfSoundBox";
      TextBox speedOfSoundBox2 = this.SpeedOfSoundBox;
      size1 = new Size(156, 20);
      Size size84 = size1;
      speedOfSoundBox2.Size = size84;
      this.SpeedOfSoundBox.TabIndex = 1;
      this.SoSUnit.AutoSize = true;
      this.SoSUnit.Dock = DockStyle.Fill;
      Label soSunit1 = this.SoSUnit;
      point1 = new Point(279, 0);
      Point point86 = point1;
      soSunit1.Location = point86;
      this.SoSUnit.Name = "SoSUnit";
      Label soSunit2 = this.SoSUnit;
      size1 = new Size(38, 25);
      Size size85 = size1;
      soSunit2.Size = size85;
      this.SoSUnit.TabIndex = 2;
      this.SoSUnit.Text = "m/s";
      this.SoSUnit.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(365, 336);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.ApplyButton);
      this.Controls.Add((Control) this.TabControl1);
      this.DataBindings.Add(new Binding("Location", (object) MySettings.Default, "SettingsLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Location = MySettings.Default.SettingsLocation;
      this.Name = nameof (SettingsClass);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Settings";
      this.TabControl1.ResumeLayout(false);
      this.GeneralTab.ResumeLayout(false);
      this.GeneralTab.PerformLayout();
      this.UndoRedoHistoryUpDown.EndInit();
      this.GraphTab.ResumeLayout(false);
      this.TableLayoutPanel1.ResumeLayout(false);
      this.TableLayoutPanel1.PerformLayout();
      this.UnitsTabPage.ResumeLayout(false);
      this.UnitsTabPage.PerformLayout();
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.TabPage2.ResumeLayout(false);
      this.TabPage2.PerformLayout();
      this.TableLayoutPanel2.ResumeLayout(false);
      this.TableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);
    }

    internal TabControl TabControl1
    {
      [DebuggerNonUserCode] get => this._TabControl1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabControl1 = value;
    }

    internal TabPage GeneralTab
    {
      [DebuggerNonUserCode] get => this._GeneralTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GeneralTab = value;
    }

    internal Button DriverLibBrowseButton
    {
      [DebuggerNonUserCode] get => this._DriverLibBrowseButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DriverLibBrowseButton_Click);
        if (this._DriverLibBrowseButton != null)
          this._DriverLibBrowseButton.Click -= eventHandler;
        this._DriverLibBrowseButton = value;
        if (this._DriverLibBrowseButton == null)
          return;
        this._DriverLibBrowseButton.Click += eventHandler;
      }
    }

    internal Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal TextBox DriverLibraryBox
    {
      [DebuggerNonUserCode] get => this._DriverLibraryBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DriverLibraryBox = value;
    }

    internal Button ApplyButton
    {
      [DebuggerNonUserCode] get => this._ApplyButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ApplyButton_Click);
        if (this._ApplyButton != null)
          this._ApplyButton.Click -= eventHandler;
        this._ApplyButton = value;
        if (this._ApplyButton == null)
          return;
        this._ApplyButton.Click += eventHandler;
      }
    }

    internal TabPage GraphTab
    {
      [DebuggerNonUserCode] get => this._GraphTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GraphTab = value;
    }

    internal TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel1 = value;
    }

    internal TextBox StartFreqBox
    {
      [DebuggerNonUserCode] get => this._StartFreqBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StartFreqBox_LostFocus);
        if (this._StartFreqBox != null)
          this._StartFreqBox.LostFocus -= eventHandler;
        this._StartFreqBox = value;
        if (this._StartFreqBox == null)
          return;
        this._StartFreqBox.LostFocus += eventHandler;
      }
    }

    internal TextBox EndFreqBox
    {
      [DebuggerNonUserCode] get => this._EndFreqBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EndFreqBox_LostFocus);
        if (this._EndFreqBox != null)
          this._EndFreqBox.LostFocus -= eventHandler;
        this._EndFreqBox = value;
        if (this._EndFreqBox == null)
          return;
        this._EndFreqBox.LostFocus += eventHandler;
      }
    }

    internal Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal Label Label13
    {
      [DebuggerNonUserCode] get => this._Label13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
    }

    internal Label Label14
    {
      [DebuggerNonUserCode] get => this._Label14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
    }

    internal Label Label16
    {
      [DebuggerNonUserCode] get => this._Label16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
    }

    internal Label Label18
    {
      [DebuggerNonUserCode] get => this._Label18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
    }

    internal TextBox RadImpMinBox
    {
      [DebuggerNonUserCode] get => this._RadImpMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadImpMinBox_LostFocus);
        if (this._RadImpMinBox != null)
          this._RadImpMinBox.LostFocus -= eventHandler;
        this._RadImpMinBox = value;
        if (this._RadImpMinBox == null)
          return;
        this._RadImpMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox RadImpMaxBox
    {
      [DebuggerNonUserCode] get => this._RadImpMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadImpMaxBox_LostFocus);
        if (this._RadImpMaxBox != null)
          this._RadImpMaxBox.LostFocus -= eventHandler;
        this._RadImpMaxBox = value;
        if (this._RadImpMaxBox == null)
          return;
        this._RadImpMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox DriverImpMinBox
    {
      [DebuggerNonUserCode] get => this._DriverImpMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DriverImpMinBox_LostFocus);
        if (this._DriverImpMinBox != null)
          this._DriverImpMinBox.LostFocus -= eventHandler;
        this._DriverImpMinBox = value;
        if (this._DriverImpMinBox == null)
          return;
        this._DriverImpMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox DriverImpMaxBox
    {
      [DebuggerNonUserCode] get => this._DriverImpMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DriverImpMaxBox_LostFocus);
        if (this._DriverImpMaxBox != null)
          this._DriverImpMaxBox.LostFocus -= eventHandler;
        this._DriverImpMaxBox = value;
        if (this._DriverImpMaxBox == null)
          return;
        this._DriverImpMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox InputImpMinBox
    {
      [DebuggerNonUserCode] get => this._InputImpMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InputImpMinBox_LostFocus);
        if (this._InputImpMinBox != null)
          this._InputImpMinBox.LostFocus -= eventHandler;
        this._InputImpMinBox = value;
        if (this._InputImpMinBox == null)
          return;
        this._InputImpMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox InputImpMaxBox
    {
      [DebuggerNonUserCode] get => this._InputImpMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InputImpMaxBox_LostFocus);
        if (this._InputImpMaxBox != null)
          this._InputImpMaxBox.LostFocus -= eventHandler;
        this._InputImpMaxBox = value;
        if (this._InputImpMaxBox == null)
          return;
        this._InputImpMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox SystemImpMaxBox
    {
      [DebuggerNonUserCode] get => this._SystemImpMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SystemImpMaxBox_LostFocus);
        if (this._SystemImpMaxBox != null)
          this._SystemImpMaxBox.LostFocus -= eventHandler;
        this._SystemImpMaxBox = value;
        if (this._SystemImpMaxBox == null)
          return;
        this._SystemImpMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox LpMinBox
    {
      [DebuggerNonUserCode] get => this._LpMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LpMinBox_LostFocus);
        if (this._LpMinBox != null)
          this._LpMinBox.LostFocus -= eventHandler;
        this._LpMinBox = value;
        if (this._LpMinBox == null)
          return;
        this._LpMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox LpMaxBox
    {
      [DebuggerNonUserCode] get => this._LpMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LpMaxBox_LostFocus);
        if (this._LpMaxBox != null)
          this._LpMaxBox.LostFocus -= eventHandler;
        this._LpMaxBox = value;
        if (this._LpMaxBox == null)
          return;
        this._LpMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox DispMinBox
    {
      [DebuggerNonUserCode] get => this._DispMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DispMinBox_LostFocus);
        if (this._DispMinBox != null)
          this._DispMinBox.LostFocus -= eventHandler;
        this._DispMinBox = value;
        if (this._DispMinBox == null)
          return;
        this._DispMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox DispMaxBox
    {
      [DebuggerNonUserCode] get => this._DispMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DispMaxBox_LostFocus);
        if (this._DispMaxBox != null)
          this._DispMaxBox.LostFocus -= eventHandler;
        this._DispMaxBox = value;
        if (this._DispMaxBox == null)
          return;
        this._DispMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox VelMinBox
    {
      [DebuggerNonUserCode] get => this._VelMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VelMinBox_LostFocus);
        if (this._VelMinBox != null)
          this._VelMinBox.LostFocus -= eventHandler;
        this._VelMinBox = value;
        if (this._VelMinBox == null)
          return;
        this._VelMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox VelMaxBox
    {
      [DebuggerNonUserCode] get => this._VelMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VelMaxBox_LostFocus);
        if (this._VelMaxBox != null)
          this._VelMaxBox.LostFocus -= eventHandler;
        this._VelMaxBox = value;
        if (this._VelMaxBox == null)
          return;
        this._VelMaxBox.LostFocus += eventHandler;
      }
    }

    internal Label Label21
    {
      [DebuggerNonUserCode] get => this._Label21;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
    }

    internal Label Label25
    {
      [DebuggerNonUserCode] get => this._Label25;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
    }

    internal Label Label27
    {
      [DebuggerNonUserCode] get => this._Label27;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
    }

    internal Label Label29
    {
      [DebuggerNonUserCode] get => this._Label29;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
    }

    internal Label Label31
    {
      [DebuggerNonUserCode] get => this._Label31;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
    }

    internal Label Label33
    {
      [DebuggerNonUserCode] get => this._Label33;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
    }

    internal Label Label34
    {
      [DebuggerNonUserCode] get => this._Label34;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
    }

    internal Label Label37
    {
      [DebuggerNonUserCode] get => this._Label37;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label37 = value;
    }

    internal TextBox GroupDelayMaxBox
    {
      [DebuggerNonUserCode] get => this._GroupDelayMaxBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GroupDelayMaxBox_LostFocus);
        if (this._GroupDelayMaxBox != null)
          this._GroupDelayMaxBox.LostFocus -= eventHandler;
        this._GroupDelayMaxBox = value;
        if (this._GroupDelayMaxBox == null)
          return;
        this._GroupDelayMaxBox.LostFocus += eventHandler;
      }
    }

    internal TextBox SystemImpMinBox
    {
      [DebuggerNonUserCode] get => this._SystemImpMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SystemImpMinBox_LostFocus);
        if (this._SystemImpMinBox != null)
          this._SystemImpMinBox.LostFocus -= eventHandler;
        this._SystemImpMinBox = value;
        if (this._SystemImpMinBox == null)
          return;
        this._SystemImpMinBox.LostFocus += eventHandler;
      }
    }

    internal TextBox GroupDelayMinBox
    {
      [DebuggerNonUserCode] get => this._GroupDelayMinBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GroupDelayMinBox_LostFocus);
        if (this._GroupDelayMinBox != null)
          this._GroupDelayMinBox.LostFocus -= eventHandler;
        this._GroupDelayMinBox = value;
        if (this._GroupDelayMinBox == null)
          return;
        this._GroupDelayMinBox.LostFocus += eventHandler;
      }
    }

    internal Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal Label Label23
    {
      [DebuggerNonUserCode] get => this._Label23;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
    }

    internal Label Label38
    {
      [DebuggerNonUserCode] get => this._Label38;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
    }

    internal Label Label39
    {
      [DebuggerNonUserCode] get => this._Label39;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label39 = value;
    }

    internal CheckBox LpLogBox
    {
      [DebuggerNonUserCode] get => this._LpLogBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LpLogBox_CheckedChanged);
        if (this._LpLogBox != null)
          this._LpLogBox.CheckedChanged -= eventHandler;
        this._LpLogBox = value;
        if (this._LpLogBox == null)
          return;
        this._LpLogBox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox RadImpLogBox
    {
      [DebuggerNonUserCode] get => this._RadImpLogBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadImpLogBox_CheckedChanged);
        if (this._RadImpLogBox != null)
          this._RadImpLogBox.CheckedChanged -= eventHandler;
        this._RadImpLogBox = value;
        if (this._RadImpLogBox == null)
          return;
        this._RadImpLogBox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox DispLogBox
    {
      [DebuggerNonUserCode] get => this._DispLogBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DispLogBox_CheckedChanged);
        if (this._DispLogBox != null)
          this._DispLogBox.CheckedChanged -= eventHandler;
        this._DispLogBox = value;
        if (this._DispLogBox == null)
          return;
        this._DispLogBox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox DriverImpLogBox
    {
      [DebuggerNonUserCode] get => this._DriverImpLogBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DriverImpLogBox_CheckedChanged);
        if (this._DriverImpLogBox != null)
          this._DriverImpLogBox.CheckedChanged -= eventHandler;
        this._DriverImpLogBox = value;
        if (this._DriverImpLogBox == null)
          return;
        this._DriverImpLogBox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox VelocityLogBox
    {
      [DebuggerNonUserCode] get => this._VelocityLogBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VelocityLogBox_CheckedChanged);
        if (this._VelocityLogBox != null)
          this._VelocityLogBox.CheckedChanged -= eventHandler;
        this._VelocityLogBox = value;
        if (this._VelocityLogBox == null)
          return;
        this._VelocityLogBox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox InputImplogbox
    {
      [DebuggerNonUserCode] get => this._InputImplogbox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InputImplogbox_CheckedChanged);
        if (this._InputImplogbox != null)
          this._InputImplogbox.CheckedChanged -= eventHandler;
        this._InputImplogbox = value;
        if (this._InputImplogbox == null)
          return;
        this._InputImplogbox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox GroupDelayLogbox
    {
      [DebuggerNonUserCode] get => this._GroupDelayLogbox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GroupDelayLogbox_CheckedChanged);
        if (this._GroupDelayLogbox != null)
          this._GroupDelayLogbox.CheckedChanged -= eventHandler;
        this._GroupDelayLogbox = value;
        if (this._GroupDelayLogbox == null)
          return;
        this._GroupDelayLogbox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox SystemImpLogbox
    {
      [DebuggerNonUserCode] get => this._SystemImpLogbox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SystemImpLogbox_CheckedChanged);
        if (this._SystemImpLogbox != null)
          this._SystemImpLogbox.CheckedChanged -= eventHandler;
        this._SystemImpLogbox = value;
        if (this._SystemImpLogbox == null)
          return;
        this._SystemImpLogbox.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox FreqLogbox
    {
      [DebuggerNonUserCode] get => this._FreqLogbox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FreqLogbox_CheckedChanged);
        if (this._FreqLogbox != null)
          this._FreqLogbox.CheckedChanged -= eventHandler;
        this._FreqLogbox = value;
        if (this._FreqLogbox == null)
          return;
        this._FreqLogbox.CheckedChanged += eventHandler;
      }
    }

    internal TabPage UnitsTabPage
    {
      [DebuggerNonUserCode] get => this._UnitsTabPage;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._UnitsTabPage = value;
    }

    internal ComboBox AreaPrecisionBox
    {
      [DebuggerNonUserCode] get => this._AreaPrecisionBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AreaPrecisionBox_SelectedIndexChanged);
        if (this._AreaPrecisionBox != null)
          this._AreaPrecisionBox.SelectedIndexChanged -= eventHandler;
        this._AreaPrecisionBox = value;
        if (this._AreaPrecisionBox == null)
          return;
        this._AreaPrecisionBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal ComboBox LengthPrecisionBox
    {
      [DebuggerNonUserCode] get => this._LengthPrecisionBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LengthPrecisionBox_SelectedIndexChanged);
        if (this._LengthPrecisionBox != null)
          this._LengthPrecisionBox.SelectedIndexChanged -= eventHandler;
        this._LengthPrecisionBox = value;
        if (this._LengthPrecisionBox == null)
          return;
        this._LengthPrecisionBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal ComboBox AreaUnitbox
    {
      [DebuggerNonUserCode] get => this._AreaUnitbox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AreaUnitbox_SelectedIndexChanged);
        if (this._AreaUnitbox != null)
          this._AreaUnitbox.SelectedIndexChanged -= eventHandler;
        this._AreaUnitbox = value;
        if (this._AreaUnitbox == null)
          return;
        this._AreaUnitbox.SelectedIndexChanged += eventHandler;
      }
    }

    internal ComboBox LengthUnitBox
    {
      [DebuggerNonUserCode] get => this._LengthUnitBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LengthUnitBox_SelectedIndexChanged);
        if (this._LengthUnitBox != null)
          this._LengthUnitBox.SelectedIndexChanged -= eventHandler;
        this._LengthUnitBox = value;
        if (this._LengthUnitBox == null)
          return;
        this._LengthUnitBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal Label Label12
    {
      [DebuggerNonUserCode] get => this._Label12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
    }

    internal Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal Label Label9
    {
      [DebuggerNonUserCode] get => this._Label9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
    }

    internal Label Label15
    {
      [DebuggerNonUserCode] get => this._Label15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
    }

    internal Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal Label Label11
    {
      [DebuggerNonUserCode] get => this._Label11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
    }

    internal Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal ComboBox AnglePrecisionBox
    {
      [DebuggerNonUserCode] get => this._AnglePrecisionBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AnglePrecisionBox_SelectedIndexChanged);
        if (this._AnglePrecisionBox != null)
          this._AnglePrecisionBox.SelectedIndexChanged -= eventHandler;
        this._AnglePrecisionBox = value;
        if (this._AnglePrecisionBox == null)
          return;
        this._AnglePrecisionBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal ComboBox AngleUnitBox
    {
      [DebuggerNonUserCode] get => this._AngleUnitBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AngleUnitBox_SelectedIndexChanged);
        if (this._AngleUnitBox != null)
          this._AngleUnitBox.SelectedIndexChanged -= eventHandler;
        this._AngleUnitBox = value;
        if (this._AngleUnitBox == null)
          return;
        this._AngleUnitBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal Label Label20
    {
      [DebuggerNonUserCode] get => this._Label20;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
    }

    internal Label Label24
    {
      [DebuggerNonUserCode] get => this._Label24;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
    }

    internal Label Label22
    {
      [DebuggerNonUserCode] get => this._Label22;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
    }

    internal Label Label19
    {
      [DebuggerNonUserCode] get => this._Label19;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
    }

    internal TabPage TabPage1
    {
      [DebuggerNonUserCode] get => this._TabPage1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage1 = value;
    }

    internal Label Label26
    {
      [DebuggerNonUserCode] get => this._Label26;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
    }

    internal ComboBox PanButtonBox
    {
      [DebuggerNonUserCode] get => this._PanButtonBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PanButtonBox_SelectedIndexChanged);
        if (this._PanButtonBox != null)
          this._PanButtonBox.SelectedIndexChanged -= eventHandler;
        this._PanButtonBox = value;
        if (this._PanButtonBox == null)
          return;
        this._PanButtonBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal NumericUpDown UndoRedoHistoryUpDown
    {
      [DebuggerNonUserCode] get => this._UndoRedoHistoryUpDown;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UndoRedoHistoryUpDown_ValueChanged);
        if (this._UndoRedoHistoryUpDown != null)
          this._UndoRedoHistoryUpDown.ValueChanged -= eventHandler;
        this._UndoRedoHistoryUpDown = value;
        if (this._UndoRedoHistoryUpDown == null)
          return;
        this._UndoRedoHistoryUpDown.ValueChanged += eventHandler;
      }
    }

    internal Label Label28
    {
      [DebuggerNonUserCode] get => this._Label28;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
    }

    internal TabPage TabPage2
    {
      [DebuggerNonUserCode] get => this._TabPage2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage2 = value;
    }

    internal TableLayoutPanel TableLayoutPanel2
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel2 = value;
    }

    internal Label Label30
    {
      [DebuggerNonUserCode] get => this._Label30;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
    }

    internal TextBox SpeedOfSoundBox
    {
      [DebuggerNonUserCode] get => this._SpeedOfSoundBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SpeedOfSoundBox = value;
    }

    internal Label SoSUnit
    {
      [DebuggerNonUserCode] get => this._SoSUnit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SoSUnit = value;
    }

    public event SettingsClass.SettingsParameterUpdatedEventHandler SettingsParameterUpdated;

    public SettingsClass(SettingsParameters Settings)
    {
      SettingsClass.__ENCAddToList((object) this);
      this.InitializeComponent();
      this.SettingsFromParent = Settings;
    }

    public SettingsParameters SettingsFromParent
    {
      set
      {
        this.SettingsEdit = value;
        this.UpdateValues();
      }
    }

    private void SendValues()
    {
      SettingsParameterUpdatedEventArgs e = new SettingsParameterUpdatedEventArgs(this.SettingsEdit);
      SettingsClass.SettingsParameterUpdatedEventHandler parameterUpdatedEvent = this.SettingsParameterUpdated;
      if (parameterUpdatedEvent == null)
        return;
      parameterUpdatedEvent((object) this, e);
    }

    private void UpdateValues()
    {
      this.DriverLibraryBox.Text = this.SettingsEdit.DriverLibrary;
      this.StartFreqBox.Text = this.SettingsEdit.StartFreq.ToString();
      this.EndFreqBox.Text = this.SettingsEdit.EndFreq.ToString();
      this.RadImpMinBox.Text = this.SettingsEdit.RadiationImpedanceMin.ToString();
      this.RadImpMaxBox.Text = this.SettingsEdit.RadiationImpedanceMax.ToString();
      this.DriverImpMinBox.Text = this.SettingsEdit.DriverImpedanceMin.ToString();
      this.DriverImpMaxBox.Text = this.SettingsEdit.DriverImpedanceMax.ToString();
      this.InputImpMinBox.Text = this.SettingsEdit.InputImpedanceMin.ToString();
      this.InputImpMaxBox.Text = this.SettingsEdit.InputImpedanceMax.ToString();
      this.SystemImpMinBox.Text = this.SettingsEdit.SystemImpedanceMin.ToString();
      this.SystemImpMaxBox.Text = this.SettingsEdit.SystemImpedanceMax.ToString();
      this.LpMinBox.Text = this.SettingsEdit.LwMin.ToString();
      this.LpMaxBox.Text = this.SettingsEdit.LwMax.ToString();
      this.DispMinBox.Text = this.SettingsEdit.DisplaceMin.ToString();
      this.DispMaxBox.Text = this.SettingsEdit.DisplaceMax.ToString();
      this.VelMinBox.Text = this.SettingsEdit.VelocityMin.ToString();
      this.VelMaxBox.Text = this.SettingsEdit.VelocityMax.ToString();
      this.GroupDelayMinBox.Text = this.SettingsEdit.GroupDelayMin.ToString();
      this.GroupDelayMaxBox.Text = this.SettingsEdit.GroupDelayMax.ToString();
      this.FreqLogbox.Checked = this.SettingsEdit.FrequencyLog;
      this.RadImpLogBox.Checked = this.SettingsEdit.RadiationImpedanceLog;
      this.DriverImpLogBox.Checked = this.SettingsEdit.DriverImpedanceLog;
      this.InputImplogbox.Checked = this.SettingsEdit.InputImpedanceLog;
      this.SystemImpLogbox.Checked = this.SettingsEdit.SystemImpedanceLog;
      this.LpLogBox.Checked = this.SettingsEdit.LwLog;
      this.DispLogBox.Checked = this.SettingsEdit.DisplaceLog;
      this.VelocityLogBox.Checked = this.SettingsEdit.VelocityLog;
      this.GroupDelayLogbox.Checked = this.SettingsEdit.GroupDelayLog;
      this.LengthUnitBox.Items.Clear();
      int num1 = Functions.UnitNumberLength();
      int Unit1 = 1;
      while (Unit1 <= num1)
      {
        this.LengthUnitBox.Items.Add((object) Functions.UnitStringLengthLong(Unit1));
        checked { ++Unit1; }
      }
      this.AreaUnitbox.Items.Clear();
      int num2 = Functions.UnitNumberLength();
      int Unit2 = 1;
      while (Unit2 <= num2)
      {
        this.AreaUnitbox.Items.Add((object) (Functions.UnitStringLengthLong(Unit2) + "\u00B2"));
        checked { ++Unit2; }
      }
      this.AngleUnitBox.Items.Clear();
      this.AngleUnitBox.Items.Add((object) "Degrees");
      this.LengthPrecisionBox.Items.Clear();
      int y1 = 0;
      do
      {
        this.LengthPrecisionBox.Items.Add((object) (100.0 / Math.Pow(10.0, (double) y1)));
        checked { ++y1; }
      }
      while (y1 <= 6);
      this.AreaPrecisionBox.Items.Clear();
      int y2 = 0;
      do
      {
        this.AreaPrecisionBox.Items.Add((object) (100.0 / Math.Pow(10.0, (double) y2)));
        checked { ++y2; }
      }
      while (y2 <= 6);
      this.AnglePrecisionBox.Items.Clear();
      int y3 = 0;
      do
      {
        this.AnglePrecisionBox.Items.Add((object) (100.0 / Math.Pow(10.0, (double) y3)));
        checked { ++y3; }
      }
      while (y3 <= 6);
      this.LengthUnitBox.SelectedIndex = checked (this.SettingsEdit.DisplayLengthUnit - 1);
      this.AreaUnitbox.SelectedIndex = checked (this.SettingsEdit.DisplayAreaUnit - 1);
      this.AngleUnitBox.SelectedIndex = checked (this.SettingsEdit.DisplayAngleUnit - 1);
      this.LengthPrecisionBox.SelectedIndex = this.SettingsEdit.DisplayLengthPrecision;
      this.AreaPrecisionBox.SelectedIndex = this.SettingsEdit.DisplayAreaPrecision;
      this.AnglePrecisionBox.SelectedIndex = this.SettingsEdit.DisplayAnglePrecision;
      if (this.SettingsEdit.PanMouseButton == MouseButtons.Middle)
        this.PanButtonBox.SelectedIndex = 0;
      else if (this.SettingsEdit.PanMouseButton == MouseButtons.Right)
        this.PanButtonBox.SelectedIndex = 1;
      this.UndoRedoHistoryUpDown.Value = new Decimal(this.SettingsEdit.UndoRedoHistory);
      this.SpeedOfSoundBox.Text = this.SettingsEdit.SpeedOfSound.ToString();
    }

    private void DriverLibBrowseButton_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Select Driver Library Location";
      folderBrowserDialog.ShowNewFolderButton = true;
      folderBrowserDialog.SelectedPath = "C:\\";
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.DriverLibraryBox.Text = folderBrowserDialog.SelectedPath;
    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
      this.SettingsEdit.DriverLibrary = this.DriverLibraryBox.Text;
      this.SettingsEdit.StartFreq = Conversions.ToDouble(this.StartFreqBox.Text);
      this.SettingsEdit.EndFreq = Conversions.ToDouble(this.EndFreqBox.Text);
      this.SettingsEdit.RadiationImpedanceMin = Conversions.ToDouble(this.RadImpMinBox.Text);
      this.SettingsEdit.RadiationImpedanceMax = Conversions.ToDouble(this.RadImpMaxBox.Text);
      this.SettingsEdit.DriverImpedanceMin = Conversions.ToDouble(this.DriverImpMinBox.Text);
      this.SettingsEdit.DriverImpedanceMax = Conversions.ToDouble(this.DriverImpMaxBox.Text);
      this.SettingsEdit.InputImpedanceMin = Conversions.ToDouble(this.InputImpMinBox.Text);
      this.SettingsEdit.InputImpedanceMax = Conversions.ToDouble(this.InputImpMaxBox.Text);
      this.SettingsEdit.SystemImpedanceMin = Conversions.ToDouble(this.SystemImpMinBox.Text);
      this.SettingsEdit.SystemImpedanceMax = Conversions.ToDouble(this.SystemImpMaxBox.Text);
      this.SettingsEdit.LwMin = Conversions.ToDouble(this.LpMinBox.Text);
      this.SettingsEdit.LwMax = Conversions.ToDouble(this.LpMaxBox.Text);
      this.SettingsEdit.DisplaceMin = Conversions.ToDouble(this.DispMinBox.Text);
      this.SettingsEdit.DisplaceMax = Conversions.ToDouble(this.DispMaxBox.Text);
      this.SettingsEdit.VelocityMin = Conversions.ToDouble(this.VelMinBox.Text);
      this.SettingsEdit.VelocityMax = Conversions.ToDouble(this.VelMaxBox.Text);
      this.SettingsEdit.GroupDelayMin = Conversions.ToDouble(this.GroupDelayMinBox.Text);
      this.SettingsEdit.GroupDelayMax = Conversions.ToDouble(this.GroupDelayMaxBox.Text);
      this.SettingsEdit.FrequencyLog = this.FreqLogbox.Checked;
      this.SettingsEdit.RadiationImpedanceLog = this.RadImpLogBox.Checked;
      this.SettingsEdit.DriverImpedanceLog = this.DriverImpLogBox.Checked;
      this.SettingsEdit.InputImpedanceLog = this.InputImplogbox.Checked;
      this.SettingsEdit.SystemImpedanceLog = this.SystemImpLogbox.Checked;
      this.SettingsEdit.LwLog = this.LpLogBox.Checked;
      this.SettingsEdit.DisplaceLog = this.DispLogBox.Checked;
      this.SettingsEdit.VelocityLog = this.VelocityLogBox.Checked;
      this.SettingsEdit.GroupDelayLog = this.GroupDelayLogbox.Checked;
      this.SettingsEdit.SpeedOfSound = Conversions.ToDouble(this.SpeedOfSoundBox.Text);
      this.SendValues();
    }

    private void LpLogBox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.LpLogBox.Checked || Conversions.ToDouble(this.LpMinBox.Text) > 0.0)
        return;
      this.LpMinBox.Text = "0.1";
    }

    private void RadImpLogBox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadImpLogBox.Checked || Conversions.ToDouble(this.RadImpMinBox.Text) > 0.0)
        return;
      this.RadImpMinBox.Text = "0.1";
    }

    private void DispLogBox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.DispLogBox.Checked || Conversions.ToDouble(this.DispMinBox.Text) > 0.0)
        return;
      this.DispMinBox.Text = "0.1";
    }

    private void DriverImpLogBox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.DriverImpLogBox.Checked || Conversions.ToDouble(this.DriverImpMinBox.Text) > 0.0)
        return;
      this.DriverImpMinBox.Text = "0.1";
    }

    private void VelocityLogBox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.VelocityLogBox.Checked || Conversions.ToDouble(this.VelMinBox.Text) > 0.0)
        return;
      this.VelMinBox.Text = "0.1";
    }

    private void InputImplogbox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.InputImplogbox.Checked || Conversions.ToDouble(this.InputImpMinBox.Text) > 0.0)
        return;
      this.InputImpMinBox.Text = "0.1";
    }

    private void GroupDelayLogbox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.GroupDelayLogbox.Checked || Conversions.ToDouble(this.GroupDelayMinBox.Text) > 0.0)
        return;
      this.GroupDelayMinBox.Text = "0.1";
    }

    private void SystemImpLogbox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SystemImpLogbox.Checked || Conversions.ToDouble(this.SystemImpMinBox.Text) > 0.0)
        return;
      this.SystemImpMinBox.Text = "0.1";
    }

    private void FreqLogbox_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.FreqLogbox.Checked || Conversions.ToDouble(this.StartFreqBox.Text) > 0.0)
        return;
      this.StartFreqBox.Text = "0.1";
    }

    private void LpMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.LpLogBox.Checked ? -1000000.0 : 0.1;
      double lwMax = this.SettingsEdit.LwMax;
      if (Functions.ErrorCheckNum(this.LpMinBox.Text, Min, lwMax))
        return;
      this.LpMinBox.Text = Min.ToString();
    }

    private void RadImpMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.RadImpLogBox.Checked ? -1000000.0 : 0.1;
      double radiationImpedanceMax = this.SettingsEdit.RadiationImpedanceMax;
      if (Functions.ErrorCheckNum(this.RadImpMinBox.Text, Min, radiationImpedanceMax))
        return;
      this.RadImpMinBox.Text = Min.ToString();
    }

    private void DispMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.DispLogBox.Checked ? -1000000.0 : 0.1;
      double displaceMax = this.SettingsEdit.DisplaceMax;
      if (Functions.ErrorCheckNum(this.DispMinBox.Text, Min, displaceMax))
        return;
      this.DispMinBox.Text = Min.ToString();
    }

    private void DriverImpMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.DriverImpLogBox.Checked ? -1000000.0 : 0.1;
      double driverImpedanceMax = this.SettingsEdit.DriverImpedanceMax;
      if (Functions.ErrorCheckNum(this.DriverImpMinBox.Text, Min, driverImpedanceMax))
        return;
      this.DriverImpMinBox.Text = Min.ToString();
    }

    private void VelMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.VelocityLogBox.Checked ? -1000000.0 : 0.1;
      double velocityMax = this.SettingsEdit.VelocityMax;
      if (Functions.ErrorCheckNum(this.VelMinBox.Text, Min, velocityMax))
        return;
      this.VelMinBox.Text = Min.ToString();
    }

    private void InputImpMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.InputImplogbox.Checked ? -1000000.0 : 0.1;
      double inputImpedanceMax = this.SettingsEdit.InputImpedanceMax;
      if (Functions.ErrorCheckNum(this.InputImpMinBox.Text, Min, inputImpedanceMax))
        return;
      this.InputImpMinBox.Text = Min.ToString();
    }

    private void GroupDelayMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.GroupDelayLogbox.Checked ? -1000000.0 : 0.1;
      double groupDelayMax = this.SettingsEdit.GroupDelayMax;
      if (Functions.ErrorCheckNum(this.GroupDelayMinBox.Text, Min, groupDelayMax))
        return;
      this.GroupDelayMinBox.Text = Min.ToString();
    }

    private void SystemImpMinBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.SystemImpLogbox.Checked ? -1000000.0 : 0.1;
      double systemImpedanceMax = this.SettingsEdit.SystemImpedanceMax;
      if (Functions.ErrorCheckNum(this.SystemImpMinBox.Text, Min, systemImpedanceMax))
        return;
      this.SystemImpMinBox.Text = Min.ToString();
    }

    private void StartFreqBox_LostFocus(object sender, EventArgs e)
    {
      double Min = !this.FreqLogbox.Checked ? 0.0 : 0.1;
      double endFreq = this.SettingsEdit.EndFreq;
      if (Functions.ErrorCheckNum(this.StartFreqBox.Text, Min, endFreq))
        return;
      this.StartFreqBox.Text = Min.ToString();
    }

    private void LpMaxBox_LostFocus(object sender, EventArgs e)
    {
      if (Functions.ErrorCheckNum(this.LpMaxBox.Text, this.SettingsEdit.LwMin, 1000000.0))
        return;
      this.LpMaxBox.Text = (Conversions.ToDouble(this.LpMinBox.Text) * 10.0).ToString();
    }

    private void RadImpMaxBox_LostFocus(object sender, EventArgs e)
    {
      if (Functions.ErrorCheckNum(this.RadImpMaxBox.Text, this.SettingsEdit.RadiationImpedanceMin, 1000000.0))
        return;
      this.RadImpMaxBox.Text = (Conversions.ToDouble(this.RadImpMinBox.Text) * 10.0).ToString();
    }

    private void DispMaxBox_LostFocus(object sender, EventArgs e)
    {
      if (Functions.ErrorCheckNum(this.DispMaxBox.Text, this.SettingsEdit.DisplaceMin, 1000000.0))
        return;
      this.DispMaxBox.Text = (Conversions.ToDouble(this.DispMinBox.Text) * 10.0).ToString();
    }

    private void DriverImpMaxBox_LostFocus(object sender, EventArgs e)
    {
      if (Functions.ErrorCheckNum(this.DriverImpMaxBox.Text, this.SettingsEdit.DriverImpedanceMin, 1000000.0))
        return;
      this.DriverImpMaxBox.Text = (Conversions.ToDouble(this.DriverImpMinBox.Text) * 10.0).ToString();
    }

    private void VelMaxBox_LostFocus(object sender, EventArgs e)
    {
      if (Functions.ErrorCheckNum(this.VelMaxBox.Text, this.SettingsEdit.VelocityMin, 1000000.0))
        return;
      this.VelMaxBox.Text = (Conversions.ToDouble(this.VelMinBox.Text) * 10.0).ToString();
    }

    private void InputImpMaxBox_LostFocus(object sender, EventArgs e)
    {
      double inputImpedanceMin = this.SettingsEdit.InputImpedanceMin;
      double Max = 1000000.0;
      if (Functions.ErrorCheckNum(this.InputImpMaxBox.Text, inputImpedanceMin, Max))
        return;
      this.InputImpMaxBox.Text = (inputImpedanceMin * 10.0).ToString();
    }

    private void GroupDelayMaxBox_LostFocus(object sender, EventArgs e)
    {
      double groupDelayMin = this.SettingsEdit.GroupDelayMin;
      double Max = 1000000.0;
      if (Functions.ErrorCheckNum(this.GroupDelayMaxBox.Text, groupDelayMin, Max))
        return;
      this.GroupDelayMaxBox.Text = (groupDelayMin * 10.0).ToString();
    }

    private void SystemImpMaxBox_LostFocus(object sender, EventArgs e)
    {
      double systemImpedanceMin = this.SettingsEdit.SystemImpedanceMin;
      double Max = 1000000.0;
      if (Functions.ErrorCheckNum(this.SystemImpMaxBox.Text, systemImpedanceMin, Max))
        return;
      this.SystemImpMaxBox.Text = (systemImpedanceMin * 10.0).ToString();
    }

    private void EndFreqBox_LostFocus(object sender, EventArgs e)
    {
      double startFreq = this.SettingsEdit.StartFreq;
      double Max = 1000000.0;
      if (Functions.ErrorCheckNum(this.EndFreqBox.Text, startFreq, Max))
        return;
      this.EndFreqBox.Text = (startFreq * 10.0).ToString();
    }

    private void LengthUnitBox_SelectedIndexChanged(object sender, EventArgs e) => this.SettingsEdit.DisplayLengthUnit = checked (this.LengthUnitBox.SelectedIndex + 1);

    private void LengthPrecisionBox_SelectedIndexChanged(object sender, EventArgs e) => this.SettingsEdit.DisplayLengthPrecision = this.LengthPrecisionBox.SelectedIndex;

    private void AreaUnitbox_SelectedIndexChanged(object sender, EventArgs e) => this.SettingsEdit.DisplayAreaUnit = checked (this.AreaUnitbox.SelectedIndex + 1);

    private void AreaPrecisionBox_SelectedIndexChanged(object sender, EventArgs e) => this.SettingsEdit.DisplayAreaPrecision = this.AreaPrecisionBox.SelectedIndex;

    private void AngleUnitBox_SelectedIndexChanged(object sender, EventArgs e) => this.SettingsEdit.DisplayAngleUnit = checked (this.AngleUnitBox.SelectedIndex + 1);

    private void AnglePrecisionBox_SelectedIndexChanged(object sender, EventArgs e) => this.SettingsEdit.DisplayAnglePrecision = this.AnglePrecisionBox.SelectedIndex;

    private void PanButtonBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.PanButtonBox.SelectedIndex == 0)
        this.SettingsEdit.PanMouseButton = MouseButtons.Middle;
      else if (this.PanButtonBox.SelectedIndex == 1)
        this.SettingsEdit.PanMouseButton = MouseButtons.Right;
      else
        this.SettingsEdit.PanMouseButton = MouseButtons.Middle;
    }

    private void UndoRedoHistoryUpDown_ValueChanged(object sender, EventArgs e) => this.SettingsEdit.UndoRedoHistory = Convert.ToInt32(this.UndoRedoHistoryUpDown.Value);

    public delegate void SettingsParameterUpdatedEventHandler(
      object Sender,
      SettingsParameterUpdatedEventArgs e);
  }
}
