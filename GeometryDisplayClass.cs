// Decompiled with JetBrains decompiler
// Type: TransmissionLine.GeometryDisplayClass
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TransmissionLine.My;

namespace TransmissionLine
{
  [DesignerGenerated]
  public class GeometryDisplayClass : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("SplitContainer1")]
    private SplitContainer _SplitContainer1;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("RearModelTitle")]
    private Label _RearModelTitle;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("StartAreaUnitLabel")]
    private Label _StartAreaUnitLabel;
    [AccessedThroughProperty("EndAreaUnitLabel")]
    private Label _EndAreaUnitLabel;
    [AccessedThroughProperty("LengthUnitLabel")]
    private Label _LengthUnitLabel;
    [AccessedThroughProperty("LengthBox")]
    private TextBox _LengthBox;
    [AccessedThroughProperty("EndAreaBox")]
    private TextBox _EndAreaBox;
    [AccessedThroughProperty("StartAreaBox")]
    private TextBox _StartAreaBox;
    [AccessedThroughProperty("ElementTitleLabel")]
    private Label _ElementTitleLabel;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("TaperRatioBox")]
    private TextBox _TaperRatioBox;
    [AccessedThroughProperty("StartAreaCheck")]
    private CheckBox _StartAreaCheck;
    [AccessedThroughProperty("EndAreaCheck")]
    private CheckBox _EndAreaCheck;
    [AccessedThroughProperty("TaperRatioCheck")]
    private CheckBox _TaperRatioCheck;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("AngleBox")]
    private TextBox _AngleBox;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("EnclosureDepthLabel")]
    private Label _EnclosureDepthLabel;
    [AccessedThroughProperty("EnclosureVolumeLabel")]
    private Label _EnclosureVolumeLabel;
    [AccessedThroughProperty("TotalLengthLabel")]
    private Label _TotalLengthLabel;
    [AccessedThroughProperty("VolumeLabel")]
    private Label _VolumeLabel;
    [AccessedThroughProperty("LengthLabel")]
    private Label _LengthLabel;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("ToolStripStatusLabel1")]
    private ToolStripStatusLabel _ToolStripStatusLabel1;
    [AccessedThroughProperty("ToolStrip1")]
    private ToolStrip _ToolStrip1;
    [AccessedThroughProperty("ToolStripRunButton")]
    private ToolStripButton _ToolStripRunButton;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("TaperTypeBox")]
    private ComboBox _TaperTypeBox;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("StuffingBox")]
    private TextBox _StuffingBox;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("ElementVolumeLabel")]
    private Label _ElementVolumeLabel;
    [AccessedThroughProperty("ElementVolumeUnitLabel")]
    private Label _ElementVolumeUnitLabel;
    [AccessedThroughProperty("AutoUpdateButton")]
    private ToolStripButton _AutoUpdateButton;
    [AccessedThroughProperty("GeometryDisplayBox")]
    private PictureBox _GeometryDisplayBox;
    [AccessedThroughProperty("CollapseButton")]
    private Button _CollapseButton;
    [AccessedThroughProperty("ToolStripSeparator1")]
    private ToolStripSeparator _ToolStripSeparator1;
    [AccessedThroughProperty("ToolStripFrontButton")]
    private ToolStripButton _ToolStripFrontButton;
    [AccessedThroughProperty("ToolStripRearButton")]
    private ToolStripButton _ToolStripRearButton;
    [AccessedThroughProperty("FrontModelTitle")]
    private Label _FrontModelTitle;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("VolumeLabel1")]
    private Label _VolumeLabel1;
    [AccessedThroughProperty("LengthLabel1")]
    private Label _LengthLabel1;
    [AccessedThroughProperty("EnclosureVolumeLabel1")]
    private Label _EnclosureVolumeLabel1;
    [AccessedThroughProperty("TotalLengthLabel1")]
    private Label _TotalLengthLabel1;
    [AccessedThroughProperty("WidthBox")]
    private TextBox _WidthBox;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("OpenCheckBox")]
    private CheckBox _OpenCheckBox;
    [AccessedThroughProperty("ToolStripSeparator2")]
    private ToolStripSeparator _ToolStripSeparator2;
    [AccessedThroughProperty("THButton")]
    private ToolStripButton _THButton;
    [AccessedThroughProperty("ToolStripSeparator3")]
    private ToolStripSeparator _ToolStripSeparator3;
    [AccessedThroughProperty("DriverLabel")]
    private ToolStripLabel _DriverLabel;
    [AccessedThroughProperty("DriverPositionUnitLabel")]
    private Label _DriverPositionUnitLabel;
    [AccessedThroughProperty("DriverPositionBox")]
    private TextBox _DriverPositionBox;
    [AccessedThroughProperty("DensityUnitLabel")]
    private Label _DensityUnitLabel;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("TapPositionBox")]
    private TextBox _TapPositionBox;
    [AccessedThroughProperty("TapPositionUnitLabel")]
    private Label _TapPositionUnitLabel;
    [AccessedThroughProperty("ToolStripDropDownButton1")]
    private ToolStripDropDownButton _ToolStripDropDownButton1;
    [AccessedThroughProperty("TransmissionLineToolStripMenuItem")]
    private ToolStripMenuItem _TransmissionLineToolStripMenuItem;
    [AccessedThroughProperty("TaperedToolStripMenuItem")]
    private ToolStripMenuItem _TaperedToolStripMenuItem;
    [AccessedThroughProperty("StraightToolStripMenuItem")]
    private ToolStripMenuItem _StraightToolStripMenuItem;
    [AccessedThroughProperty("ExpandingToolStripMenuItem")]
    private ToolStripMenuItem _ExpandingToolStripMenuItem;
    [AccessedThroughProperty("SealedToolStripMenuItem")]
    private ToolStripMenuItem _SealedToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSeparator4")]
    private ToolStripSeparator _ToolStripSeparator4;
    [AccessedThroughProperty("PortedToolStripMenuItem")]
    private ToolStripMenuItem _PortedToolStripMenuItem;
    [AccessedThroughProperty("BandPassToolStripMenuItem")]
    private ToolStripMenuItem _BandPassToolStripMenuItem;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("HypExpTBox")]
    private TextBox _HypExpTBox;
    private GeometryDisplayClass.HandleStruct HandleInfo;
    private TLParameters TLGeometryEdit;
    private DriverParameters DriverEdit;
    private DriverSetup DriverSetupEdit;
    private Point MouseStartLocation;
    private Point MouseCurrentLocation;
    private float ScaleDivide;
    private bool ShowRearModelInfo;
    private bool ShowFrontModelInfo;
    private bool ShowElementInfo;
    private int SelectCount;
    private TreeNode[] SelectedNodeArray;
    private TreeNode SelectedNode;
    private Point RightClickMenuLocation;
    private TLElement DefaultElement;
    private int HandleSize;
    private double LightStuffing;
    private double MediumStuffing;
    private double HeavyStuffing;
    private SettingsParameters SettingsEdit;
    private double Volume;
    private double Length;
    private TreeNode CopyNode;
    private bool SupressFormChangeDetection;
    private TLElement OriginalElement;
    private TLElement OriginalNextElement;
    private TLElement OriginalPrevElement;
    private TLElement OriginalChildElement;
    private TLElement OriginalParentElement;
    private MouseButtons SelectMouseButton;
    private MouseButtons OptionMouseButton;
    private MouseButtons MouseButtonPressed;
    private bool MouseHasMoved;

    [DebuggerNonUserCode]
    static GeometryDisplayClass()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (GeometryDisplayClass.__ENCList)
      {
        if (GeometryDisplayClass.__ENCList.Count == GeometryDisplayClass.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (GeometryDisplayClass.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (GeometryDisplayClass.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                GeometryDisplayClass.__ENCList[index1] = GeometryDisplayClass.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          GeometryDisplayClass.__ENCList.RemoveRange(index1, checked (GeometryDisplayClass.__ENCList.Count - index1));
          GeometryDisplayClass.__ENCList.Capacity = GeometryDisplayClass.__ENCList.Count;
        }
        GeometryDisplayClass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GeometryDisplayClass));
      this.SplitContainer1 = new SplitContainer();
      this.CollapseButton = new Button();
      this.GeometryDisplayBox = new PictureBox();
      this.StatusStrip1 = new StatusStrip();
      this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
      this.ToolStrip1 = new ToolStrip();
      this.ToolStripRunButton = new ToolStripButton();
      this.AutoUpdateButton = new ToolStripButton();
      this.ToolStripSeparator1 = new ToolStripSeparator();
      this.ToolStripFrontButton = new ToolStripButton();
      this.ToolStripRearButton = new ToolStripButton();
      this.ToolStripSeparator4 = new ToolStripSeparator();
      this.ToolStripDropDownButton1 = new ToolStripDropDownButton();
      this.TransmissionLineToolStripMenuItem = new ToolStripMenuItem();
      this.TaperedToolStripMenuItem = new ToolStripMenuItem();
      this.StraightToolStripMenuItem = new ToolStripMenuItem();
      this.ExpandingToolStripMenuItem = new ToolStripMenuItem();
      this.SealedToolStripMenuItem = new ToolStripMenuItem();
      this.PortedToolStripMenuItem = new ToolStripMenuItem();
      this.BandPassToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator2 = new ToolStripSeparator();
      this.THButton = new ToolStripButton();
      this.ToolStripSeparator3 = new ToolStripSeparator();
      this.DriverLabel = new ToolStripLabel();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.EnclosureDepthLabel = new Label();
      this.VolumeLabel = new Label();
      this.LengthLabel = new Label();
      this.RearModelTitle = new Label();
      this.Label3 = new Label();
      this.EnclosureVolumeLabel = new Label();
      this.TotalLengthLabel = new Label();
      this.Label2 = new Label();
      this.StartAreaUnitLabel = new Label();
      this.EndAreaUnitLabel = new Label();
      this.LengthUnitLabel = new Label();
      this.EndAreaBox = new TextBox();
      this.StartAreaBox = new TextBox();
      this.ElementTitleLabel = new Label();
      this.Label6 = new Label();
      this.TaperRatioBox = new TextBox();
      this.StartAreaCheck = new CheckBox();
      this.EndAreaCheck = new CheckBox();
      this.TaperRatioCheck = new CheckBox();
      this.Label8 = new Label();
      this.Label7 = new Label();
      this.Label9 = new Label();
      this.Label11 = new Label();
      this.LengthBox = new TextBox();
      this.AngleBox = new TextBox();
      this.Label12 = new Label();
      this.TaperTypeBox = new ComboBox();
      this.Label1 = new Label();
      this.Label13 = new Label();
      this.StuffingBox = new TextBox();
      this.Label14 = new Label();
      this.ElementVolumeLabel = new Label();
      this.ElementVolumeUnitLabel = new Label();
      this.FrontModelTitle = new Label();
      this.Label15 = new Label();
      this.Label16 = new Label();
      this.VolumeLabel1 = new Label();
      this.LengthLabel1 = new Label();
      this.EnclosureVolumeLabel1 = new Label();
      this.TotalLengthLabel1 = new Label();
      this.WidthBox = new TextBox();
      this.Label5 = new Label();
      this.Panel1 = new Panel();
      this.OpenCheckBox = new CheckBox();
      this.DriverPositionUnitLabel = new Label();
      this.DriverPositionBox = new TextBox();
      this.DensityUnitLabel = new Label();
      this.Label10 = new Label();
      this.Label17 = new Label();
      this.TapPositionBox = new TextBox();
      this.TapPositionUnitLabel = new Label();
      this.Label4 = new Label();
      this.Label18 = new Label();
      this.HypExpTBox = new TextBox();
      this.SplitContainer1.BeginInit();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      ((ISupportInitialize) this.GeometryDisplayBox).BeginInit();
      this.StatusStrip1.SuspendLayout();
      this.ToolStrip1.SuspendLayout();
      this.TableLayoutPanel1.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.SplitContainer1.BorderStyle = BorderStyle.FixedSingle;
      this.SplitContainer1.Dock = DockStyle.Fill;
      this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
      SplitContainer splitContainer1_1 = this.SplitContainer1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      splitContainer1_1.Location = point2;
      SplitContainer splitContainer1_2 = this.SplitContainer1;
      Padding padding1 = new Padding(0);
      Padding padding2 = padding1;
      splitContainer1_2.Margin = padding2;
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Panel1.Controls.Add((Control) this.CollapseButton);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.GeometryDisplayBox);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.StatusStrip1);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.ToolStrip1);
      this.SplitContainer1.Panel2.AutoScroll = true;
      this.SplitContainer1.Panel2.Controls.Add((Control) this.TableLayoutPanel1);
      SplitContainer splitContainer1_3 = this.SplitContainer1;
      Size size1 = new Size(729, 454);
      Size size2 = size1;
      splitContainer1_3.Size = size2;
      this.SplitContainer1.SplitterDistance = 572;
      this.SplitContainer1.SplitterWidth = 3;
      this.SplitContainer1.TabIndex = 3;
      this.CollapseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.CollapseButton.BackColor = SystemColors.Control;
      this.CollapseButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
      this.CollapseButton.FlatStyle = FlatStyle.Flat;
      Button collapseButton1 = this.CollapseButton;
      point1 = new Point(494, 140);
      Point point3 = point1;
      collapseButton1.Location = point3;
      Button collapseButton2 = this.CollapseButton;
      padding1 = new Padding(0);
      Padding padding3 = padding1;
      collapseButton2.Margin = padding3;
      this.CollapseButton.Name = "CollapseButton";
      Button collapseButton3 = this.CollapseButton;
      size1 = new Size(16, 51);
      Size size3 = size1;
      collapseButton3.Size = size3;
      this.CollapseButton.TabIndex = 26;
      this.CollapseButton.Text = ">";
      this.CollapseButton.UseVisualStyleBackColor = false;
      this.GeometryDisplayBox.BackColor = Color.White;
      this.GeometryDisplayBox.Dock = DockStyle.Fill;
      PictureBox geometryDisplayBox1 = this.GeometryDisplayBox;
      point1 = new Point(0, 25);
      Point point4 = point1;
      geometryDisplayBox1.Location = point4;
      this.GeometryDisplayBox.Name = "GeometryDisplayBox";
      PictureBox geometryDisplayBox2 = this.GeometryDisplayBox;
      size1 = new Size(570, 405);
      Size size4 = size1;
      geometryDisplayBox2.Size = size4;
      this.GeometryDisplayBox.TabIndex = 24;
      this.GeometryDisplayBox.TabStop = false;
      this.StatusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ToolStripStatusLabel1
      });
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      point1 = new Point(0, 430);
      Point point5 = point1;
      statusStrip1_1.Location = point5;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      size1 = new Size(570, 22);
      Size size5 = size1;
      statusStrip1_2.Size = size5;
      this.StatusStrip1.TabIndex = 23;
      this.StatusStrip1.Text = "StatusStrip1";
      this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
      ToolStripStatusLabel stripStatusLabel1 = this.ToolStripStatusLabel1;
      size1 = new Size(0, 17);
      Size size6 = size1;
      stripStatusLabel1.Size = size6;
      this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.ToolStrip1.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.ToolStripRunButton,
        (ToolStripItem) this.AutoUpdateButton,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.ToolStripFrontButton,
        (ToolStripItem) this.ToolStripRearButton,
        (ToolStripItem) this.ToolStripSeparator4,
        (ToolStripItem) this.ToolStripDropDownButton1,
        (ToolStripItem) this.ToolStripSeparator2,
        (ToolStripItem) this.THButton,
        (ToolStripItem) this.ToolStripSeparator3,
        (ToolStripItem) this.DriverLabel
      });
      ToolStrip toolStrip1_1 = this.ToolStrip1;
      point1 = new Point(0, 0);
      Point point6 = point1;
      toolStrip1_1.Location = point6;
      this.ToolStrip1.Name = "ToolStrip1";
      ToolStrip toolStrip1_2 = this.ToolStrip1;
      padding1 = new Padding(0);
      Padding padding4 = padding1;
      toolStrip1_2.Padding = padding4;
      ToolStrip toolStrip1_3 = this.ToolStrip1;
      size1 = new Size(570, 25);
      Size size7 = size1;
      toolStrip1_3.Size = size7;
      this.ToolStrip1.TabIndex = 22;
      this.ToolStrip1.Text = "ToolStrip1";
      this.ToolStripRunButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripRunButton.Image = (Image) TransmissionLine.My.Resources.Resources._0run;
      this.ToolStripRunButton.ImageTransparentColor = Color.Magenta;
      this.ToolStripRunButton.Name = "ToolStripRunButton";
      ToolStripButton toolStripRunButton = this.ToolStripRunButton;
      size1 = new Size(23, 22);
      Size size8 = size1;
      toolStripRunButton.Size = size8;
      this.ToolStripRunButton.Text = "Update Model";
      this.AutoUpdateButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.AutoUpdateButton.Image = (Image) TransmissionLine.My.Resources.Resources.tools;
      this.AutoUpdateButton.ImageTransparentColor = Color.Magenta;
      this.AutoUpdateButton.Name = "AutoUpdateButton";
      ToolStripButton autoUpdateButton = this.AutoUpdateButton;
      size1 = new Size(23, 22);
      Size size9 = size1;
      autoUpdateButton.Size = size9;
      this.AutoUpdateButton.Text = "Auto Update on Changes";
      this.AutoUpdateButton.ToolTipText = "Auto Update on Changes";
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
      size1 = new Size(6, 25);
      Size size10 = size1;
      toolStripSeparator1.Size = size10;
      this.ToolStripFrontButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripFrontButton.Image = (Image) componentResourceManager.GetObject("ToolStripFrontButton.Image");
      this.ToolStripFrontButton.ImageTransparentColor = Color.Magenta;
      this.ToolStripFrontButton.Name = "ToolStripFrontButton";
      ToolStripButton stripFrontButton = this.ToolStripFrontButton;
      size1 = new Size(39, 22);
      Size size11 = size1;
      stripFrontButton.Size = size11;
      this.ToolStripFrontButton.Text = "Front";
      this.ToolStripFrontButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.ToolStripFrontButton.ToolTipText = "Show Front Enclosure";
      this.ToolStripRearButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripRearButton.Image = (Image) componentResourceManager.GetObject("ToolStripRearButton.Image");
      this.ToolStripRearButton.ImageTransparentColor = Color.Magenta;
      this.ToolStripRearButton.Name = "ToolStripRearButton";
      ToolStripButton toolStripRearButton = this.ToolStripRearButton;
      size1 = new Size(34, 22);
      Size size12 = size1;
      toolStripRearButton.Size = size12;
      this.ToolStripRearButton.Text = "Rear";
      this.ToolStripRearButton.ToolTipText = "Show Rear Enclosure";
      this.ToolStripSeparator4.Name = "ToolStripSeparator4";
      ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
      size1 = new Size(6, 25);
      Size size13 = size1;
      toolStripSeparator4.Size = size13;
      this.ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.TransmissionLineToolStripMenuItem,
        (ToolStripItem) this.SealedToolStripMenuItem,
        (ToolStripItem) this.PortedToolStripMenuItem,
        (ToolStripItem) this.BandPassToolStripMenuItem
      });
      this.ToolStripDropDownButton1.Image = (Image) componentResourceManager.GetObject("ToolStripDropDownButton1.Image");
      this.ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
      this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
      ToolStripDropDownButton stripDropDownButton1 = this.ToolStripDropDownButton1;
      size1 = new Size(56, 22);
      Size size14 = size1;
      stripDropDownButton1.Size = size14;
      this.ToolStripDropDownButton1.Text = "Wizard";
      this.TransmissionLineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.TaperedToolStripMenuItem,
        (ToolStripItem) this.StraightToolStripMenuItem,
        (ToolStripItem) this.ExpandingToolStripMenuItem
      });
      this.TransmissionLineToolStripMenuItem.Name = "TransmissionLineToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.TransmissionLineToolStripMenuItem;
      size1 = new Size(169, 22);
      Size size15 = size1;
      toolStripMenuItem1.Size = size15;
      this.TransmissionLineToolStripMenuItem.Text = "Transmission Line";
      this.TaperedToolStripMenuItem.Name = "TaperedToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem2 = this.TaperedToolStripMenuItem;
      size1 = new Size(129, 22);
      Size size16 = size1;
      toolStripMenuItem2.Size = size16;
      this.TaperedToolStripMenuItem.Text = "Tapered";
      this.StraightToolStripMenuItem.Name = "StraightToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem3 = this.StraightToolStripMenuItem;
      size1 = new Size(129, 22);
      Size size17 = size1;
      toolStripMenuItem3.Size = size17;
      this.StraightToolStripMenuItem.Text = "Straight";
      this.ExpandingToolStripMenuItem.Name = "ExpandingToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem4 = this.ExpandingToolStripMenuItem;
      size1 = new Size(129, 22);
      Size size18 = size1;
      toolStripMenuItem4.Size = size18;
      this.ExpandingToolStripMenuItem.Text = "Expanding";
      this.SealedToolStripMenuItem.Name = "SealedToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem5 = this.SealedToolStripMenuItem;
      size1 = new Size(169, 22);
      Size size19 = size1;
      toolStripMenuItem5.Size = size19;
      this.SealedToolStripMenuItem.Text = "Sealed";
      this.PortedToolStripMenuItem.Name = "PortedToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem6 = this.PortedToolStripMenuItem;
      size1 = new Size(169, 22);
      Size size20 = size1;
      toolStripMenuItem6.Size = size20;
      this.PortedToolStripMenuItem.Text = "Ported";
      this.BandPassToolStripMenuItem.Name = "BandPassToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem7 = this.BandPassToolStripMenuItem;
      size1 = new Size(169, 22);
      Size size21 = size1;
      toolStripMenuItem7.Size = size21;
      this.BandPassToolStripMenuItem.Text = "Band-Pass";
      this.ToolStripSeparator2.Name = "ToolStripSeparator2";
      ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
      size1 = new Size(6, 25);
      Size size22 = size1;
      toolStripSeparator2.Size = size22;
      this.THButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.THButton.Image = (Image) componentResourceManager.GetObject("THButton.Image");
      this.THButton.ImageTransparentColor = Color.Magenta;
      this.THButton.Name = "THButton";
      ToolStripButton thButton = this.THButton;
      size1 = new Size(81, 22);
      Size size23 = size1;
      thButton.Size = size23;
      this.THButton.Text = "Tapped Horn";
      this.THButton.ToolTipText = "Toggle Tapped Horn Link";
      this.ToolStripSeparator3.Name = "ToolStripSeparator3";
      ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
      size1 = new Size(6, 25);
      Size size24 = size1;
      toolStripSeparator3.Size = size24;
      this.DriverLabel.Name = "DriverLabel";
      ToolStripLabel driverLabel = this.DriverLabel;
      size1 = new Size(0, 22);
      Size size25 = size1;
      driverLabel.Size = size25;
      this.TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.TableLayoutPanel1.AutoSize = true;
      this.TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.TableLayoutPanel1.ColumnCount = 4;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86f));
      this.TableLayoutPanel1.Controls.Add((Control) this.EnclosureDepthLabel, 3, 12);
      this.TableLayoutPanel1.Controls.Add((Control) this.VolumeLabel, 1, 13);
      this.TableLayoutPanel1.Controls.Add((Control) this.LengthLabel, 1, 14);
      this.TableLayoutPanel1.Controls.Add((Control) this.RearModelTitle, 0, 11);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label3, 0, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.EnclosureVolumeLabel, 3, 13);
      this.TableLayoutPanel1.Controls.Add((Control) this.TotalLengthLabel, 3, 14);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label2, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.StartAreaUnitLabel, 3, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.EndAreaUnitLabel, 3, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.LengthUnitLabel, 3, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.EndAreaBox, 1, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.StartAreaBox, 1, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.ElementTitleLabel, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label6, 0, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.TaperRatioBox, 1, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.StartAreaCheck, 2, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.EndAreaCheck, 2, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.TaperRatioCheck, 2, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label8, 3, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label7, 0, 12);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label9, 0, 13);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label11, 0, 14);
      this.TableLayoutPanel1.Controls.Add((Control) this.LengthBox, 1, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.AngleBox, 1, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label12, 0, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.TaperTypeBox, 1, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label1, 0, 7);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label13, 0, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.StuffingBox, 1, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label14, 0, 10);
      this.TableLayoutPanel1.Controls.Add((Control) this.ElementVolumeLabel, 1, 10);
      this.TableLayoutPanel1.Controls.Add((Control) this.ElementVolumeUnitLabel, 3, 10);
      this.TableLayoutPanel1.Controls.Add((Control) this.FrontModelTitle, 0, 17);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label15, 0, 18);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label16, 0, 19);
      this.TableLayoutPanel1.Controls.Add((Control) this.VolumeLabel1, 1, 18);
      this.TableLayoutPanel1.Controls.Add((Control) this.LengthLabel1, 1, 19);
      this.TableLayoutPanel1.Controls.Add((Control) this.EnclosureVolumeLabel1, 3, 18);
      this.TableLayoutPanel1.Controls.Add((Control) this.TotalLengthLabel1, 3, 19);
      this.TableLayoutPanel1.Controls.Add((Control) this.WidthBox, 1, 12);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label5, 0, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel1, 1, 8);
      this.TableLayoutPanel1.Controls.Add((Control) this.DriverPositionUnitLabel, 3, 16);
      this.TableLayoutPanel1.Controls.Add((Control) this.DriverPositionBox, 1, 16);
      this.TableLayoutPanel1.Controls.Add((Control) this.DensityUnitLabel, 3, 9);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label10, 0, 16);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label17, 0, 15);
      this.TableLayoutPanel1.Controls.Add((Control) this.TapPositionBox, 1, 15);
      this.TableLayoutPanel1.Controls.Add((Control) this.TapPositionUnitLabel, 3, 15);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label4, 0, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label18, 0, 6);
      this.TableLayoutPanel1.Controls.Add((Control) this.HypExpTBox, 1, 5);
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      point1 = new Point(0, 0);
      Point point7 = point1;
      tableLayoutPanel1_1.Location = point7;
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      padding1 = new Padding(0);
      Padding padding5 = padding1;
      tableLayoutPanel1_2.Margin = padding5;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 20;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      TableLayoutPanel tableLayoutPanel1_3 = this.TableLayoutPanel1;
      size1 = new Size(208, 440);
      Size size26 = size1;
      tableLayoutPanel1_3.Size = size26;
      this.TableLayoutPanel1.TabIndex = 21;
      this.EnclosureDepthLabel.AutoSize = true;
      this.EnclosureDepthLabel.Dock = DockStyle.Fill;
      this.EnclosureDepthLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label enclosureDepthLabel1 = this.EnclosureDepthLabel;
      point1 = new Point(122, 264);
      Point point8 = point1;
      enclosureDepthLabel1.Location = point8;
      Label enclosureDepthLabel2 = this.EnclosureDepthLabel;
      padding1 = new Padding(0);
      Padding padding6 = padding1;
      enclosureDepthLabel2.Margin = padding6;
      this.EnclosureDepthLabel.Name = "EnclosureDepthLabel";
      Label enclosureDepthLabel3 = this.EnclosureDepthLabel;
      size1 = new Size(86, 22);
      Size size27 = size1;
      enclosureDepthLabel3.Size = size27;
      this.EnclosureDepthLabel.TabIndex = 3;
      this.EnclosureDepthLabel.Text = "m";
      this.EnclosureDepthLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.VolumeLabel, 2);
      this.VolumeLabel.Dock = DockStyle.Fill;
      Label volumeLabel1 = this.VolumeLabel;
      point1 = new Point(63, 286);
      Point point9 = point1;
      volumeLabel1.Location = point9;
      Label volumeLabel2 = this.VolumeLabel;
      padding1 = new Padding(0);
      Padding padding7 = padding1;
      volumeLabel2.Margin = padding7;
      this.VolumeLabel.Name = "VolumeLabel";
      Label volumeLabel3 = this.VolumeLabel;
      size1 = new Size(59, 22);
      Size size28 = size1;
      volumeLabel3.Size = size28;
      this.VolumeLabel.TabIndex = 13;
      this.VolumeLabel.Text = "Label2";
      this.VolumeLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.LengthLabel, 2);
      this.LengthLabel.Dock = DockStyle.Fill;
      Label lengthLabel1 = this.LengthLabel;
      point1 = new Point(63, 308);
      Point point10 = point1;
      lengthLabel1.Location = point10;
      Label lengthLabel2 = this.LengthLabel;
      padding1 = new Padding(0);
      Padding padding8 = padding1;
      lengthLabel2.Margin = padding8;
      this.LengthLabel.Name = "LengthLabel";
      Label lengthLabel3 = this.LengthLabel;
      size1 = new Size(59, 22);
      Size size29 = size1;
      lengthLabel3.Size = size29;
      this.LengthLabel.TabIndex = 14;
      this.LengthLabel.Text = "Label2";
      this.LengthLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.RearModelTitle.BackColor = Color.DarkGray;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.RearModelTitle, 4);
      this.RearModelTitle.Dock = DockStyle.Fill;
      this.RearModelTitle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.RearModelTitle.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_down;
      this.RearModelTitle.ImageAlign = ContentAlignment.MiddleLeft;
      Label rearModelTitle1 = this.RearModelTitle;
      point1 = new Point(0, 242);
      Point point11 = point1;
      rearModelTitle1.Location = point11;
      Label rearModelTitle2 = this.RearModelTitle;
      padding1 = new Padding(0);
      Padding padding9 = padding1;
      rearModelTitle2.Margin = padding9;
      this.RearModelTitle.Name = "RearModelTitle";
      Label rearModelTitle3 = this.RearModelTitle;
      size1 = new Size(208, 22);
      Size size30 = size1;
      rearModelTitle3.Size = size30;
      this.RearModelTitle.TabIndex = 28;
      this.RearModelTitle.Text = "    Model Info - Rear";
      this.RearModelTitle.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.Dock = DockStyle.Fill;
      Label label3_1 = this.Label3;
      point1 = new Point(0, 44);
      Point point12 = point1;
      label3_1.Location = point12;
      Label label3_2 = this.Label3;
      padding1 = new Padding(0);
      Padding padding10 = padding1;
      label3_2.Margin = padding10;
      this.Label3.Name = "Label3";
      Label label3_3 = this.Label3;
      size1 = new Size(63, 22);
      Size size31 = size1;
      label3_3.Size = size31;
      this.Label3.TabIndex = 21;
      this.Label3.Text = "End Area";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.EnclosureVolumeLabel.AutoSize = true;
      this.EnclosureVolumeLabel.Dock = DockStyle.Fill;
      this.EnclosureVolumeLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label enclosureVolumeLabel1 = this.EnclosureVolumeLabel;
      point1 = new Point(122, 286);
      Point point13 = point1;
      enclosureVolumeLabel1.Location = point13;
      Label enclosureVolumeLabel2 = this.EnclosureVolumeLabel;
      padding1 = new Padding(0);
      Padding padding11 = padding1;
      enclosureVolumeLabel2.Margin = padding11;
      this.EnclosureVolumeLabel.Name = "EnclosureVolumeLabel";
      Label enclosureVolumeLabel3 = this.EnclosureVolumeLabel;
      size1 = new Size(86, 22);
      Size size32 = size1;
      enclosureVolumeLabel3.Size = size32;
      this.EnclosureVolumeLabel.TabIndex = 3;
      this.EnclosureVolumeLabel.Text = "m\u00B3";
      this.EnclosureVolumeLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.TotalLengthLabel.AutoSize = true;
      this.TotalLengthLabel.Dock = DockStyle.Fill;
      this.TotalLengthLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label totalLengthLabel1 = this.TotalLengthLabel;
      point1 = new Point(122, 308);
      Point point14 = point1;
      totalLengthLabel1.Location = point14;
      Label totalLengthLabel2 = this.TotalLengthLabel;
      padding1 = new Padding(0);
      Padding padding12 = padding1;
      totalLengthLabel2.Margin = padding12;
      this.TotalLengthLabel.Name = "TotalLengthLabel";
      Label totalLengthLabel3 = this.TotalLengthLabel;
      size1 = new Size(86, 22);
      Size size33 = size1;
      totalLengthLabel3.Size = size33;
      this.TotalLengthLabel.TabIndex = 3;
      this.TotalLengthLabel.Text = "m";
      this.TotalLengthLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.Dock = DockStyle.Fill;
      Label label2_1 = this.Label2;
      point1 = new Point(0, 22);
      Point point15 = point1;
      label2_1.Location = point15;
      Label label2_2 = this.Label2;
      padding1 = new Padding(0);
      Padding padding13 = padding1;
      label2_2.Margin = padding13;
      this.Label2.Name = "Label2";
      Label label2_3 = this.Label2;
      size1 = new Size(63, 22);
      Size size34 = size1;
      label2_3.Size = size34;
      this.Label2.TabIndex = 21;
      this.Label2.Text = "Start Area";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.StartAreaUnitLabel.Dock = DockStyle.Fill;
      Label startAreaUnitLabel1 = this.StartAreaUnitLabel;
      point1 = new Point(122, 22);
      Point point16 = point1;
      startAreaUnitLabel1.Location = point16;
      Label startAreaUnitLabel2 = this.StartAreaUnitLabel;
      padding1 = new Padding(0);
      Padding padding14 = padding1;
      startAreaUnitLabel2.Margin = padding14;
      this.StartAreaUnitLabel.Name = "StartAreaUnitLabel";
      Label startAreaUnitLabel3 = this.StartAreaUnitLabel;
      size1 = new Size(86, 22);
      Size size35 = size1;
      startAreaUnitLabel3.Size = size35;
      this.StartAreaUnitLabel.TabIndex = 22;
      this.StartAreaUnitLabel.Text = "m\u00B2";
      this.StartAreaUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.EndAreaUnitLabel.Dock = DockStyle.Fill;
      Label endAreaUnitLabel1 = this.EndAreaUnitLabel;
      point1 = new Point(122, 44);
      Point point17 = point1;
      endAreaUnitLabel1.Location = point17;
      Label endAreaUnitLabel2 = this.EndAreaUnitLabel;
      padding1 = new Padding(0);
      Padding padding15 = padding1;
      endAreaUnitLabel2.Margin = padding15;
      this.EndAreaUnitLabel.Name = "EndAreaUnitLabel";
      Label endAreaUnitLabel3 = this.EndAreaUnitLabel;
      size1 = new Size(86, 22);
      Size size36 = size1;
      endAreaUnitLabel3.Size = size36;
      this.EndAreaUnitLabel.TabIndex = 22;
      this.EndAreaUnitLabel.Text = "m\u00B2";
      this.EndAreaUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.LengthUnitLabel.Dock = DockStyle.Fill;
      Label lengthUnitLabel1 = this.LengthUnitLabel;
      point1 = new Point(122, 132);
      Point point18 = point1;
      lengthUnitLabel1.Location = point18;
      Label lengthUnitLabel2 = this.LengthUnitLabel;
      padding1 = new Padding(0);
      Padding padding16 = padding1;
      lengthUnitLabel2.Margin = padding16;
      this.LengthUnitLabel.Name = "LengthUnitLabel";
      Label lengthUnitLabel3 = this.LengthUnitLabel;
      size1 = new Size(86, 22);
      Size size37 = size1;
      lengthUnitLabel3.Size = size37;
      this.LengthUnitLabel.TabIndex = 22;
      this.LengthUnitLabel.Text = "m";
      this.LengthUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.EndAreaBox.Dock = DockStyle.Fill;
      TextBox endAreaBox1 = this.EndAreaBox;
      point1 = new Point(63, 44);
      Point point19 = point1;
      endAreaBox1.Location = point19;
      TextBox endAreaBox2 = this.EndAreaBox;
      padding1 = new Padding(0);
      Padding padding17 = padding1;
      endAreaBox2.Margin = padding17;
      this.EndAreaBox.Name = "EndAreaBox";
      TextBox endAreaBox3 = this.EndAreaBox;
      size1 = new Size(39, 20);
      Size size38 = size1;
      endAreaBox3.Size = size38;
      this.EndAreaBox.TabIndex = 2;
      this.StartAreaBox.Dock = DockStyle.Fill;
      TextBox startAreaBox1 = this.StartAreaBox;
      point1 = new Point(63, 22);
      Point point20 = point1;
      startAreaBox1.Location = point20;
      TextBox startAreaBox2 = this.StartAreaBox;
      padding1 = new Padding(0);
      Padding padding18 = padding1;
      startAreaBox2.Margin = padding18;
      this.StartAreaBox.Name = "StartAreaBox";
      TextBox startAreaBox3 = this.StartAreaBox;
      size1 = new Size(39, 20);
      Size size39 = size1;
      startAreaBox3.Size = size39;
      this.StartAreaBox.TabIndex = 0;
      this.ElementTitleLabel.BackColor = Color.DarkGray;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.ElementTitleLabel, 4);
      this.ElementTitleLabel.Dock = DockStyle.Fill;
      this.ElementTitleLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ElementTitleLabel.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_down;
      this.ElementTitleLabel.ImageAlign = ContentAlignment.MiddleLeft;
      Label elementTitleLabel1 = this.ElementTitleLabel;
      point1 = new Point(0, 0);
      Point point21 = point1;
      elementTitleLabel1.Location = point21;
      Label elementTitleLabel2 = this.ElementTitleLabel;
      padding1 = new Padding(0);
      Padding padding19 = padding1;
      elementTitleLabel2.Margin = padding19;
      this.ElementTitleLabel.Name = "ElementTitleLabel";
      Label elementTitleLabel3 = this.ElementTitleLabel;
      size1 = new Size(208, 22);
      Size size40 = size1;
      elementTitleLabel3.Size = size40;
      this.ElementTitleLabel.TabIndex = 23;
      this.ElementTitleLabel.Text = "    Element:";
      this.ElementTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.Label6.Dock = DockStyle.Fill;
      Label label6_1 = this.Label6;
      point1 = new Point(0, 66);
      Point point22 = point1;
      label6_1.Location = point22;
      Label label6_2 = this.Label6;
      padding1 = new Padding(0);
      Padding padding20 = padding1;
      label6_2.Margin = padding20;
      this.Label6.Name = "Label6";
      Label label6_3 = this.Label6;
      size1 = new Size(63, 22);
      Size size41 = size1;
      label6_3.Size = size41;
      this.Label6.TabIndex = 24;
      this.Label6.Text = "Taper Ratio";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      this.TaperRatioBox.Dock = DockStyle.Fill;
      TextBox taperRatioBox1 = this.TaperRatioBox;
      point1 = new Point(63, 66);
      Point point23 = point1;
      taperRatioBox1.Location = point23;
      TextBox taperRatioBox2 = this.TaperRatioBox;
      padding1 = new Padding(0);
      Padding padding21 = padding1;
      taperRatioBox2.Margin = padding21;
      this.TaperRatioBox.Name = "TaperRatioBox";
      TextBox taperRatioBox3 = this.TaperRatioBox;
      size1 = new Size(39, 20);
      Size size42 = size1;
      taperRatioBox3.Size = size42;
      this.TaperRatioBox.TabIndex = 4;
      this.StartAreaCheck.AutoSize = true;
      this.StartAreaCheck.Dock = DockStyle.Fill;
      CheckBox startAreaCheck1 = this.StartAreaCheck;
      point1 = new Point(105, 22);
      Point point24 = point1;
      startAreaCheck1.Location = point24;
      CheckBox startAreaCheck2 = this.StartAreaCheck;
      padding1 = new Padding(3, 0, 0, 0);
      Padding padding22 = padding1;
      startAreaCheck2.Margin = padding22;
      this.StartAreaCheck.Name = "StartAreaCheck";
      CheckBox startAreaCheck3 = this.StartAreaCheck;
      size1 = new Size(17, 22);
      Size size43 = size1;
      startAreaCheck3.Size = size43;
      this.StartAreaCheck.TabIndex = 1;
      this.StartAreaCheck.TextAlign = ContentAlignment.MiddleCenter;
      this.StartAreaCheck.UseVisualStyleBackColor = true;
      this.EndAreaCheck.AutoSize = true;
      this.EndAreaCheck.Dock = DockStyle.Fill;
      CheckBox endAreaCheck1 = this.EndAreaCheck;
      point1 = new Point(105, 44);
      Point point25 = point1;
      endAreaCheck1.Location = point25;
      CheckBox endAreaCheck2 = this.EndAreaCheck;
      padding1 = new Padding(3, 0, 0, 0);
      Padding padding23 = padding1;
      endAreaCheck2.Margin = padding23;
      this.EndAreaCheck.Name = "EndAreaCheck";
      CheckBox endAreaCheck3 = this.EndAreaCheck;
      size1 = new Size(17, 22);
      Size size44 = size1;
      endAreaCheck3.Size = size44;
      this.EndAreaCheck.TabIndex = 3;
      this.EndAreaCheck.TextAlign = ContentAlignment.MiddleCenter;
      this.EndAreaCheck.UseVisualStyleBackColor = true;
      this.TaperRatioCheck.AutoSize = true;
      this.TaperRatioCheck.Checked = true;
      this.TaperRatioCheck.CheckState = CheckState.Checked;
      this.TaperRatioCheck.Dock = DockStyle.Fill;
      CheckBox taperRatioCheck1 = this.TaperRatioCheck;
      point1 = new Point(105, 66);
      Point point26 = point1;
      taperRatioCheck1.Location = point26;
      CheckBox taperRatioCheck2 = this.TaperRatioCheck;
      padding1 = new Padding(3, 0, 0, 0);
      Padding padding24 = padding1;
      taperRatioCheck2.Margin = padding24;
      this.TaperRatioCheck.Name = "TaperRatioCheck";
      CheckBox taperRatioCheck3 = this.TaperRatioCheck;
      size1 = new Size(17, 22);
      Size size45 = size1;
      taperRatioCheck3.Size = size45;
      this.TaperRatioCheck.TabIndex = 5;
      this.TaperRatioCheck.TextAlign = ContentAlignment.MiddleCenter;
      this.TaperRatioCheck.UseVisualStyleBackColor = true;
      this.Label8.Dock = DockStyle.Fill;
      Label label8_1 = this.Label8;
      point1 = new Point(122, 154);
      Point point27 = point1;
      label8_1.Location = point27;
      Label label8_2 = this.Label8;
      padding1 = new Padding(0);
      Padding padding25 = padding1;
      label8_2.Margin = padding25;
      this.Label8.Name = "Label8";
      Label label8_3 = this.Label8;
      size1 = new Size(86, 22);
      Size size46 = size1;
      label8_3.Size = size46;
      this.Label8.TabIndex = 24;
      this.Label8.Text = "Deg";
      this.Label8.TextAlign = ContentAlignment.MiddleLeft;
      this.Label7.Dock = DockStyle.Fill;
      Label label7_1 = this.Label7;
      point1 = new Point(0, 264);
      Point point28 = point1;
      label7_1.Location = point28;
      Label label7_2 = this.Label7;
      padding1 = new Padding(0);
      Padding padding26 = padding1;
      label7_2.Margin = padding26;
      this.Label7.Name = "Label7";
      Label label7_3 = this.Label7;
      size1 = new Size(63, 22);
      Size size47 = size1;
      label7_3.Size = size47;
      this.Label7.TabIndex = 24;
      this.Label7.Text = "Depth";
      this.Label7.TextAlign = ContentAlignment.MiddleLeft;
      this.Label9.Dock = DockStyle.Fill;
      Label label9_1 = this.Label9;
      point1 = new Point(0, 286);
      Point point29 = point1;
      label9_1.Location = point29;
      Label label9_2 = this.Label9;
      padding1 = new Padding(0);
      Padding padding27 = padding1;
      label9_2.Margin = padding27;
      this.Label9.Name = "Label9";
      Label label9_3 = this.Label9;
      size1 = new Size(63, 22);
      Size size48 = size1;
      label9_3.Size = size48;
      this.Label9.TabIndex = 24;
      this.Label9.Text = "Volume";
      this.Label9.TextAlign = ContentAlignment.MiddleLeft;
      Label label11_1 = this.Label11;
      point1 = new Point(0, 308);
      Point point30 = point1;
      label11_1.Location = point30;
      Label label11_2 = this.Label11;
      padding1 = new Padding(0);
      Padding padding28 = padding1;
      label11_2.Margin = padding28;
      this.Label11.Name = "Label11";
      Label label11_3 = this.Label11;
      size1 = new Size(63, 22);
      Size size49 = size1;
      label11_3.Size = size49;
      this.Label11.TabIndex = 24;
      this.Label11.Text = "Length";
      this.Label11.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.LengthBox, 2);
      this.LengthBox.Dock = DockStyle.Fill;
      TextBox lengthBox1 = this.LengthBox;
      point1 = new Point(63, 132);
      Point point31 = point1;
      lengthBox1.Location = point31;
      TextBox lengthBox2 = this.LengthBox;
      padding1 = new Padding(0);
      Padding padding29 = padding1;
      lengthBox2.Margin = padding29;
      this.LengthBox.Name = "LengthBox";
      TextBox lengthBox3 = this.LengthBox;
      size1 = new Size(59, 20);
      Size size50 = size1;
      lengthBox3.Size = size50;
      this.LengthBox.TabIndex = 7;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.AngleBox, 2);
      this.AngleBox.Dock = DockStyle.Fill;
      TextBox angleBox1 = this.AngleBox;
      point1 = new Point(63, 154);
      Point point32 = point1;
      angleBox1.Location = point32;
      TextBox angleBox2 = this.AngleBox;
      padding1 = new Padding(0);
      Padding padding30 = padding1;
      angleBox2.Margin = padding30;
      this.AngleBox.Name = "AngleBox";
      TextBox angleBox3 = this.AngleBox;
      size1 = new Size(59, 20);
      Size size51 = size1;
      angleBox3.Size = size51;
      this.AngleBox.TabIndex = 8;
      this.Label12.Dock = DockStyle.Fill;
      Label label12_1 = this.Label12;
      point1 = new Point(0, 88);
      Point point33 = point1;
      label12_1.Location = point33;
      Label label12_2 = this.Label12;
      padding1 = new Padding(0);
      Padding padding31 = padding1;
      label12_2.Margin = padding31;
      this.Label12.Name = "Label12";
      Label label12_3 = this.Label12;
      size1 = new Size(63, 22);
      Size size52 = size1;
      label12_3.Size = size52;
      this.Label12.TabIndex = 24;
      this.Label12.Text = "Taper Type";
      this.Label12.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.TaperTypeBox, 2);
      this.TaperTypeBox.Dock = DockStyle.Fill;
      this.TaperTypeBox.FormattingEnabled = true;
      this.TaperTypeBox.Items.AddRange(new object[4]
      {
        (object) "Parabolic",
        (object) "Exponential",
        (object) "Conical",
        (object) "Hyp-Exp"
      });
      ComboBox taperTypeBox1 = this.TaperTypeBox;
      point1 = new Point(63, 88);
      Point point34 = point1;
      taperTypeBox1.Location = point34;
      ComboBox taperTypeBox2 = this.TaperTypeBox;
      padding1 = new Padding(0);
      Padding padding32 = padding1;
      taperTypeBox2.Margin = padding32;
      this.TaperTypeBox.Name = "TaperTypeBox";
      ComboBox taperTypeBox3 = this.TaperTypeBox;
      size1 = new Size(59, 21);
      Size size53 = size1;
      taperTypeBox3.Size = size53;
      this.TaperTypeBox.TabIndex = 6;
      this.Label1.Dock = DockStyle.Fill;
      Label label1_1 = this.Label1;
      point1 = new Point(0, 154);
      Point point35 = point1;
      label1_1.Location = point35;
      Label label1_2 = this.Label1;
      padding1 = new Padding(0);
      Padding padding33 = padding1;
      label1_2.Margin = padding33;
      this.Label1.Name = "Label1";
      Label label1_3 = this.Label1;
      size1 = new Size(63, 22);
      Size size54 = size1;
      label1_3.Size = size54;
      this.Label1.TabIndex = 24;
      this.Label1.Text = "Angle";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label13.Dock = DockStyle.Fill;
      Label label13_1 = this.Label13;
      point1 = new Point(0, 198);
      Point point36 = point1;
      label13_1.Location = point36;
      Label label13_2 = this.Label13;
      padding1 = new Padding(0);
      Padding padding34 = padding1;
      label13_2.Margin = padding34;
      this.Label13.Name = "Label13";
      Label label13_3 = this.Label13;
      size1 = new Size(63, 22);
      Size size55 = size1;
      label13_3.Size = size55;
      this.Label13.TabIndex = 24;
      this.Label13.Text = "Stuffing";
      this.Label13.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.StuffingBox, 2);
      this.StuffingBox.Dock = DockStyle.Fill;
      TextBox stuffingBox1 = this.StuffingBox;
      point1 = new Point(63, 198);
      Point point37 = point1;
      stuffingBox1.Location = point37;
      TextBox stuffingBox2 = this.StuffingBox;
      padding1 = new Padding(0);
      Padding padding35 = padding1;
      stuffingBox2.Margin = padding35;
      this.StuffingBox.Name = "StuffingBox";
      TextBox stuffingBox3 = this.StuffingBox;
      size1 = new Size(59, 20);
      Size size56 = size1;
      stuffingBox3.Size = size56;
      this.StuffingBox.TabIndex = 10;
      this.Label14.Dock = DockStyle.Fill;
      Label label14_1 = this.Label14;
      point1 = new Point(0, 220);
      Point point38 = point1;
      label14_1.Location = point38;
      Label label14_2 = this.Label14;
      padding1 = new Padding(0);
      Padding padding36 = padding1;
      label14_2.Margin = padding36;
      this.Label14.Name = "Label14";
      Label label14_3 = this.Label14;
      size1 = new Size(63, 22);
      Size size57 = size1;
      label14_3.Size = size57;
      this.Label14.TabIndex = 24;
      this.Label14.Text = "Volume";
      this.Label14.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.ElementVolumeLabel, 2);
      this.ElementVolumeLabel.Dock = DockStyle.Fill;
      Label elementVolumeLabel1 = this.ElementVolumeLabel;
      point1 = new Point(63, 220);
      Point point39 = point1;
      elementVolumeLabel1.Location = point39;
      Label elementVolumeLabel2 = this.ElementVolumeLabel;
      padding1 = new Padding(0);
      Padding padding37 = padding1;
      elementVolumeLabel2.Margin = padding37;
      this.ElementVolumeLabel.Name = "ElementVolumeLabel";
      Label elementVolumeLabel3 = this.ElementVolumeLabel;
      size1 = new Size(59, 22);
      Size size58 = size1;
      elementVolumeLabel3.Size = size58;
      this.ElementVolumeLabel.TabIndex = 11;
      this.ElementVolumeLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.ElementVolumeUnitLabel.AutoSize = true;
      this.ElementVolumeUnitLabel.Dock = DockStyle.Fill;
      this.ElementVolumeUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label elementVolumeUnitLabel1 = this.ElementVolumeUnitLabel;
      point1 = new Point(122, 220);
      Point point40 = point1;
      elementVolumeUnitLabel1.Location = point40;
      Label elementVolumeUnitLabel2 = this.ElementVolumeUnitLabel;
      padding1 = new Padding(0);
      Padding padding38 = padding1;
      elementVolumeUnitLabel2.Margin = padding38;
      this.ElementVolumeUnitLabel.Name = "ElementVolumeUnitLabel";
      Label elementVolumeUnitLabel3 = this.ElementVolumeUnitLabel;
      size1 = new Size(86, 22);
      Size size59 = size1;
      elementVolumeUnitLabel3.Size = size59;
      this.ElementVolumeUnitLabel.TabIndex = 3;
      this.ElementVolumeUnitLabel.Text = "m\u00B3";
      this.ElementVolumeUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.FrontModelTitle.BackColor = Color.DarkGray;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.FrontModelTitle, 4);
      this.FrontModelTitle.Dock = DockStyle.Fill;
      this.FrontModelTitle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FrontModelTitle.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_down;
      this.FrontModelTitle.ImageAlign = ContentAlignment.MiddleLeft;
      Label frontModelTitle1 = this.FrontModelTitle;
      point1 = new Point(0, 374);
      Point point41 = point1;
      frontModelTitle1.Location = point41;
      Label frontModelTitle2 = this.FrontModelTitle;
      padding1 = new Padding(0);
      Padding padding39 = padding1;
      frontModelTitle2.Margin = padding39;
      this.FrontModelTitle.Name = "FrontModelTitle";
      Label frontModelTitle3 = this.FrontModelTitle;
      size1 = new Size(208, 22);
      Size size60 = size1;
      frontModelTitle3.Size = size60;
      this.FrontModelTitle.TabIndex = 28;
      this.FrontModelTitle.Text = "    Model Info - Front";
      this.FrontModelTitle.TextAlign = ContentAlignment.MiddleLeft;
      this.Label15.Dock = DockStyle.Fill;
      Label label15_1 = this.Label15;
      point1 = new Point(0, 396);
      Point point42 = point1;
      label15_1.Location = point42;
      Label label15_2 = this.Label15;
      padding1 = new Padding(0);
      Padding padding40 = padding1;
      label15_2.Margin = padding40;
      this.Label15.Name = "Label15";
      Label label15_3 = this.Label15;
      size1 = new Size(63, 22);
      Size size61 = size1;
      label15_3.Size = size61;
      this.Label15.TabIndex = 24;
      this.Label15.Text = "Volume";
      this.Label15.TextAlign = ContentAlignment.MiddleLeft;
      this.Label16.Dock = DockStyle.Fill;
      Label label16_1 = this.Label16;
      point1 = new Point(0, 418);
      Point point43 = point1;
      label16_1.Location = point43;
      Label label16_2 = this.Label16;
      padding1 = new Padding(0);
      Padding padding41 = padding1;
      label16_2.Margin = padding41;
      this.Label16.Name = "Label16";
      Label label16_3 = this.Label16;
      size1 = new Size(63, 22);
      Size size62 = size1;
      label16_3.Size = size62;
      this.Label16.TabIndex = 24;
      this.Label16.Text = "Length";
      this.Label16.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.VolumeLabel1, 2);
      this.VolumeLabel1.Dock = DockStyle.Fill;
      Label volumeLabel1_1 = this.VolumeLabel1;
      point1 = new Point(63, 396);
      Point point44 = point1;
      volumeLabel1_1.Location = point44;
      Label volumeLabel1_2 = this.VolumeLabel1;
      padding1 = new Padding(0);
      Padding padding42 = padding1;
      volumeLabel1_2.Margin = padding42;
      this.VolumeLabel1.Name = "VolumeLabel1";
      Label volumeLabel1_3 = this.VolumeLabel1;
      size1 = new Size(59, 22);
      Size size63 = size1;
      volumeLabel1_3.Size = size63;
      this.VolumeLabel1.TabIndex = 15;
      this.VolumeLabel1.Text = "Label2";
      this.VolumeLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.LengthLabel1, 2);
      this.LengthLabel1.Dock = DockStyle.Fill;
      Label lengthLabel1_1 = this.LengthLabel1;
      point1 = new Point(63, 418);
      Point point45 = point1;
      lengthLabel1_1.Location = point45;
      Label lengthLabel1_2 = this.LengthLabel1;
      padding1 = new Padding(0);
      Padding padding43 = padding1;
      lengthLabel1_2.Margin = padding43;
      this.LengthLabel1.Name = "LengthLabel1";
      Label lengthLabel1_3 = this.LengthLabel1;
      size1 = new Size(59, 22);
      Size size64 = size1;
      lengthLabel1_3.Size = size64;
      this.LengthLabel1.TabIndex = 15;
      this.LengthLabel1.Text = "Label2";
      this.LengthLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.EnclosureVolumeLabel1.AutoSize = true;
      this.EnclosureVolumeLabel1.Dock = DockStyle.Fill;
      this.EnclosureVolumeLabel1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label enclosureVolumeLabel1_1 = this.EnclosureVolumeLabel1;
      point1 = new Point(122, 396);
      Point point46 = point1;
      enclosureVolumeLabel1_1.Location = point46;
      Label enclosureVolumeLabel1_2 = this.EnclosureVolumeLabel1;
      padding1 = new Padding(0);
      Padding padding44 = padding1;
      enclosureVolumeLabel1_2.Margin = padding44;
      this.EnclosureVolumeLabel1.Name = "EnclosureVolumeLabel1";
      Label enclosureVolumeLabel1_3 = this.EnclosureVolumeLabel1;
      size1 = new Size(86, 22);
      Size size65 = size1;
      enclosureVolumeLabel1_3.Size = size65;
      this.EnclosureVolumeLabel1.TabIndex = 3;
      this.EnclosureVolumeLabel1.Text = "m\u00B3";
      this.EnclosureVolumeLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.TotalLengthLabel1.AutoSize = true;
      this.TotalLengthLabel1.Dock = DockStyle.Fill;
      this.TotalLengthLabel1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label totalLengthLabel1_1 = this.TotalLengthLabel1;
      point1 = new Point(122, 418);
      Point point47 = point1;
      totalLengthLabel1_1.Location = point47;
      Label totalLengthLabel1_2 = this.TotalLengthLabel1;
      padding1 = new Padding(0);
      Padding padding45 = padding1;
      totalLengthLabel1_2.Margin = padding45;
      this.TotalLengthLabel1.Name = "TotalLengthLabel1";
      Label totalLengthLabel1_3 = this.TotalLengthLabel1;
      size1 = new Size(86, 22);
      Size size66 = size1;
      totalLengthLabel1_3.Size = size66;
      this.TotalLengthLabel1.TabIndex = 3;
      this.TotalLengthLabel1.Text = "m";
      this.TotalLengthLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.WidthBox, 2);
      this.WidthBox.Dock = DockStyle.Fill;
      TextBox widthBox1 = this.WidthBox;
      point1 = new Point(63, 264);
      Point point48 = point1;
      widthBox1.Location = point48;
      TextBox widthBox2 = this.WidthBox;
      padding1 = new Padding(0);
      Padding padding46 = padding1;
      widthBox2.Margin = padding46;
      this.WidthBox.Name = "WidthBox";
      TextBox widthBox3 = this.WidthBox;
      size1 = new Size(59, 20);
      Size size67 = size1;
      widthBox3.Size = size67;
      this.WidthBox.TabIndex = 12;
      this.Label5.Dock = DockStyle.Fill;
      Label label5_1 = this.Label5;
      point1 = new Point(0, 176);
      Point point49 = point1;
      label5_1.Location = point49;
      Label label5_2 = this.Label5;
      padding1 = new Padding(0);
      Padding padding47 = padding1;
      label5_2.Margin = padding47;
      this.Label5.Name = "Label5";
      Label label5_3 = this.Label5;
      size1 = new Size(63, 22);
      Size size68 = size1;
      label5_3.Size = size68;
      this.Label5.TabIndex = 24;
      this.Label5.Text = "Boundary";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.Panel1, 3);
      this.Panel1.Controls.Add((Control) this.OpenCheckBox);
      this.Panel1.Dock = DockStyle.Fill;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(63, 176);
      Point point50 = point1;
      panel1_1.Location = point50;
      Panel panel1_2 = this.Panel1;
      padding1 = new Padding(0);
      Padding padding48 = padding1;
      panel1_2.Margin = padding48;
      this.Panel1.Name = "Panel1";
      Panel panel1_3 = this.Panel1;
      size1 = new Size(145, 22);
      Size size69 = size1;
      panel1_3.Size = size69;
      this.Panel1.TabIndex = 29;
      this.OpenCheckBox.AutoSize = true;
      this.OpenCheckBox.Dock = DockStyle.Fill;
      CheckBox openCheckBox1 = this.OpenCheckBox;
      point1 = new Point(0, 0);
      Point point51 = point1;
      openCheckBox1.Location = point51;
      CheckBox openCheckBox2 = this.OpenCheckBox;
      padding1 = new Padding(0);
      Padding padding49 = padding1;
      openCheckBox2.Margin = padding49;
      this.OpenCheckBox.Name = "OpenCheckBox";
      CheckBox openCheckBox3 = this.OpenCheckBox;
      size1 = new Size(145, 22);
      Size size70 = size1;
      openCheckBox3.Size = size70;
      this.OpenCheckBox.TabIndex = 9;
      this.OpenCheckBox.Text = "Open";
      this.OpenCheckBox.UseVisualStyleBackColor = true;
      this.DriverPositionUnitLabel.AutoSize = true;
      this.DriverPositionUnitLabel.Dock = DockStyle.Fill;
      this.DriverPositionUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label positionUnitLabel1 = this.DriverPositionUnitLabel;
      point1 = new Point(122, 352);
      Point point52 = point1;
      positionUnitLabel1.Location = point52;
      Label positionUnitLabel2 = this.DriverPositionUnitLabel;
      padding1 = new Padding(0);
      Padding padding50 = padding1;
      positionUnitLabel2.Margin = padding50;
      this.DriverPositionUnitLabel.Name = "DriverPositionUnitLabel";
      Label positionUnitLabel3 = this.DriverPositionUnitLabel;
      size1 = new Size(86, 22);
      Size size71 = size1;
      positionUnitLabel3.Size = size71;
      this.DriverPositionUnitLabel.TabIndex = 3;
      this.DriverPositionUnitLabel.Text = "m";
      this.DriverPositionUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.DriverPositionBox, 2);
      this.DriverPositionBox.Dock = DockStyle.Fill;
      TextBox driverPositionBox1 = this.DriverPositionBox;
      point1 = new Point(63, 352);
      Point point53 = point1;
      driverPositionBox1.Location = point53;
      TextBox driverPositionBox2 = this.DriverPositionBox;
      padding1 = new Padding(0);
      Padding padding51 = padding1;
      driverPositionBox2.Margin = padding51;
      this.DriverPositionBox.Name = "DriverPositionBox";
      TextBox driverPositionBox3 = this.DriverPositionBox;
      size1 = new Size(59, 20);
      Size size72 = size1;
      driverPositionBox3.Size = size72;
      this.DriverPositionBox.TabIndex = 15;
      this.DensityUnitLabel.AutoSize = true;
      this.DensityUnitLabel.Dock = DockStyle.Fill;
      Label densityUnitLabel1 = this.DensityUnitLabel;
      point1 = new Point(122, 198);
      Point point54 = point1;
      densityUnitLabel1.Location = point54;
      Label densityUnitLabel2 = this.DensityUnitLabel;
      padding1 = new Padding(0);
      Padding padding52 = padding1;
      densityUnitLabel2.Margin = padding52;
      this.DensityUnitLabel.Name = "DensityUnitLabel";
      Label densityUnitLabel3 = this.DensityUnitLabel;
      size1 = new Size(86, 22);
      Size size73 = size1;
      densityUnitLabel3.Size = size73;
      this.DensityUnitLabel.TabIndex = 30;
      this.DensityUnitLabel.Text = "kg/m\u00B3";
      this.DensityUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      Label label10_1 = this.Label10;
      point1 = new Point(0, 352);
      Point point55 = point1;
      label10_1.Location = point55;
      Label label10_2 = this.Label10;
      padding1 = new Padding(0);
      Padding padding53 = padding1;
      label10_2.Margin = padding53;
      this.Label10.Name = "Label10";
      Label label10_3 = this.Label10;
      size1 = new Size(63, 22);
      Size size74 = size1;
      label10_3.Size = size74;
      this.Label10.TabIndex = 24;
      this.Label10.Text = "Driver Pos.";
      this.Label10.TextAlign = ContentAlignment.MiddleLeft;
      Label label17_1 = this.Label17;
      point1 = new Point(0, 330);
      Point point56 = point1;
      label17_1.Location = point56;
      Label label17_2 = this.Label17;
      padding1 = new Padding(0);
      Padding padding54 = padding1;
      label17_2.Margin = padding54;
      this.Label17.Name = "Label17";
      Label label17_3 = this.Label17;
      size1 = new Size(63, 20);
      Size size75 = size1;
      label17_3.Size = size75;
      this.Label17.TabIndex = 24;
      this.Label17.Text = "Tap Pos.";
      this.Label17.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.TapPositionBox, 2);
      this.TapPositionBox.Dock = DockStyle.Fill;
      TextBox tapPositionBox1 = this.TapPositionBox;
      point1 = new Point(63, 330);
      Point point57 = point1;
      tapPositionBox1.Location = point57;
      TextBox tapPositionBox2 = this.TapPositionBox;
      padding1 = new Padding(0);
      Padding padding55 = padding1;
      tapPositionBox2.Margin = padding55;
      this.TapPositionBox.Name = "TapPositionBox";
      TextBox tapPositionBox3 = this.TapPositionBox;
      size1 = new Size(59, 20);
      Size size76 = size1;
      tapPositionBox3.Size = size76;
      this.TapPositionBox.TabIndex = 31;
      this.TapPositionUnitLabel.AutoSize = true;
      this.TapPositionUnitLabel.Dock = DockStyle.Fill;
      this.TapPositionUnitLabel.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label positionUnitLabel4 = this.TapPositionUnitLabel;
      point1 = new Point(122, 330);
      Point point58 = point1;
      positionUnitLabel4.Location = point58;
      Label positionUnitLabel5 = this.TapPositionUnitLabel;
      padding1 = new Padding(0);
      Padding padding56 = padding1;
      positionUnitLabel5.Margin = padding56;
      this.TapPositionUnitLabel.Name = "TapPositionUnitLabel";
      Label positionUnitLabel6 = this.TapPositionUnitLabel;
      size1 = new Size(86, 22);
      Size size77 = size1;
      positionUnitLabel6.Size = size77;
      this.TapPositionUnitLabel.TabIndex = 32;
      this.TapPositionUnitLabel.Text = "m";
      this.TapPositionUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.AutoSize = true;
      this.Label4.Dock = DockStyle.Fill;
      Label label4_1 = this.Label4;
      point1 = new Point(0, 110);
      Point point59 = point1;
      label4_1.Location = point59;
      Label label4_2 = this.Label4;
      padding1 = new Padding(0);
      Padding padding57 = padding1;
      label4_2.Margin = padding57;
      this.Label4.Name = "Label4";
      Label label4_3 = this.Label4;
      size1 = new Size(63, 22);
      Size size78 = size1;
      label4_3.Size = size78;
      this.Label4.TabIndex = 33;
      this.Label4.Text = "Hyp-Exp T";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label18.AutoSize = true;
      this.Label18.Dock = DockStyle.Fill;
      Label label18_1 = this.Label18;
      point1 = new Point(0, 132);
      Point point60 = point1;
      label18_1.Location = point60;
      Label label18_2 = this.Label18;
      padding1 = new Padding(0);
      Padding padding58 = padding1;
      label18_2.Margin = padding58;
      this.Label18.Name = "Label18";
      Label label18_3 = this.Label18;
      size1 = new Size(63, 22);
      Size size79 = size1;
      label18_3.Size = size79;
      this.Label18.TabIndex = 33;
      this.Label18.Text = "Length";
      this.Label18.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.HypExpTBox, 2);
      this.HypExpTBox.Dock = DockStyle.Fill;
      TextBox hypExpTbox1 = this.HypExpTBox;
      point1 = new Point(63, 110);
      Point point61 = point1;
      hypExpTbox1.Location = point61;
      TextBox hypExpTbox2 = this.HypExpTBox;
      padding1 = new Padding(0);
      Padding padding59 = padding1;
      hypExpTbox2.Margin = padding59;
      this.HypExpTBox.Name = "HypExpTBox";
      TextBox hypExpTbox3 = this.HypExpTBox;
      size1 = new Size(59, 20);
      Size size80 = size1;
      hypExpTbox3.Size = size80;
      this.HypExpTBox.TabIndex = 34;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(729, 454);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.SplitContainer1);
      this.DataBindings.Add(new Binding("Location", (object) MySettings.Default, "GeometryDisplayLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.KeyPreview = true;
      this.Location = MySettings.Default.GeometryDisplayLocation;
      this.Name = nameof (GeometryDisplayClass);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Enclosure";
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel1.PerformLayout();
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.Panel2.PerformLayout();
      this.SplitContainer1.EndInit();
      this.SplitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.GeometryDisplayBox).EndInit();
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.ToolStrip1.ResumeLayout(false);
      this.ToolStrip1.PerformLayout();
      this.TableLayoutPanel1.ResumeLayout(false);
      this.TableLayoutPanel1.PerformLayout();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal SplitContainer SplitContainer1
    {
      [DebuggerNonUserCode] get => this._SplitContainer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SplitContainer1 = value;
    }

    internal TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel1 = value;
    }

    internal Label RearModelTitle
    {
      [DebuggerNonUserCode] get => this._RearModelTitle;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RearModelTitle_Click);
        if (this._RearModelTitle != null)
          this._RearModelTitle.Click -= eventHandler;
        this._RearModelTitle = value;
        if (this._RearModelTitle == null)
          return;
        this._RearModelTitle.Click += eventHandler;
      }
    }

    internal Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal Label StartAreaUnitLabel
    {
      [DebuggerNonUserCode] get => this._StartAreaUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StartAreaUnitLabel_Click);
        if (this._StartAreaUnitLabel != null)
          this._StartAreaUnitLabel.Click -= eventHandler;
        this._StartAreaUnitLabel = value;
        if (this._StartAreaUnitLabel == null)
          return;
        this._StartAreaUnitLabel.Click += eventHandler;
      }
    }

    internal Label EndAreaUnitLabel
    {
      [DebuggerNonUserCode] get => this._EndAreaUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EndAreaUnitLabel_Click);
        if (this._EndAreaUnitLabel != null)
          this._EndAreaUnitLabel.Click -= eventHandler;
        this._EndAreaUnitLabel = value;
        if (this._EndAreaUnitLabel == null)
          return;
        this._EndAreaUnitLabel.Click += eventHandler;
      }
    }

    internal Label LengthUnitLabel
    {
      [DebuggerNonUserCode] get => this._LengthUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LengthUnitLabel_Click);
        if (this._LengthUnitLabel != null)
          this._LengthUnitLabel.Click -= eventHandler;
        this._LengthUnitLabel = value;
        if (this._LengthUnitLabel == null)
          return;
        this._LengthUnitLabel.Click += eventHandler;
      }
    }

    internal TextBox LengthBox
    {
      [DebuggerNonUserCode] get => this._LengthBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEventForm);
        EventHandler eventHandler = new EventHandler(this.LengthBox_LostFocus);
        if (this._LengthBox != null)
        {
          this._LengthBox.KeyDown -= keyEventHandler;
          this._LengthBox.LostFocus -= eventHandler;
        }
        this._LengthBox = value;
        if (this._LengthBox == null)
          return;
        this._LengthBox.KeyDown += keyEventHandler;
        this._LengthBox.LostFocus += eventHandler;
      }
    }

    internal TextBox EndAreaBox
    {
      [DebuggerNonUserCode] get => this._EndAreaBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEventForm);
        EventHandler eventHandler = new EventHandler(this.EndAreaBox_LostFocus);
        if (this._EndAreaBox != null)
        {
          this._EndAreaBox.KeyDown -= keyEventHandler;
          this._EndAreaBox.LostFocus -= eventHandler;
        }
        this._EndAreaBox = value;
        if (this._EndAreaBox == null)
          return;
        this._EndAreaBox.KeyDown += keyEventHandler;
        this._EndAreaBox.LostFocus += eventHandler;
      }
    }

    internal TextBox StartAreaBox
    {
      [DebuggerNonUserCode] get => this._StartAreaBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEventForm);
        EventHandler eventHandler = new EventHandler(this.StartAreaBox_LostFocus);
        if (this._StartAreaBox != null)
        {
          this._StartAreaBox.KeyDown -= keyEventHandler;
          this._StartAreaBox.LostFocus -= eventHandler;
        }
        this._StartAreaBox = value;
        if (this._StartAreaBox == null)
          return;
        this._StartAreaBox.KeyDown += keyEventHandler;
        this._StartAreaBox.LostFocus += eventHandler;
      }
    }

    internal Label ElementTitleLabel
    {
      [DebuggerNonUserCode] get => this._ElementTitleLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ElementTitleLabel_Click);
        if (this._ElementTitleLabel != null)
          this._ElementTitleLabel.Click -= eventHandler;
        this._ElementTitleLabel = value;
        if (this._ElementTitleLabel == null)
          return;
        this._ElementTitleLabel.Click += eventHandler;
      }
    }

    internal Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal TextBox TaperRatioBox
    {
      [DebuggerNonUserCode] get => this._TaperRatioBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEventForm);
        EventHandler eventHandler = new EventHandler(this.TaperRatioBox_LostFocus);
        if (this._TaperRatioBox != null)
        {
          this._TaperRatioBox.KeyDown -= keyEventHandler;
          this._TaperRatioBox.LostFocus -= eventHandler;
        }
        this._TaperRatioBox = value;
        if (this._TaperRatioBox == null)
          return;
        this._TaperRatioBox.KeyDown += keyEventHandler;
        this._TaperRatioBox.LostFocus += eventHandler;
      }
    }

    internal CheckBox StartAreaCheck
    {
      [DebuggerNonUserCode] get => this._StartAreaCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StartAreaCheck_CheckedChanged);
        if (this._StartAreaCheck != null)
          this._StartAreaCheck.CheckedChanged -= eventHandler;
        this._StartAreaCheck = value;
        if (this._StartAreaCheck == null)
          return;
        this._StartAreaCheck.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox EndAreaCheck
    {
      [DebuggerNonUserCode] get => this._EndAreaCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EndAreaCheck_CheckedChanged);
        if (this._EndAreaCheck != null)
          this._EndAreaCheck.CheckedChanged -= eventHandler;
        this._EndAreaCheck = value;
        if (this._EndAreaCheck == null)
          return;
        this._EndAreaCheck.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox TaperRatioCheck
    {
      [DebuggerNonUserCode] get => this._TaperRatioCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TaperRatioCheck_CheckedChanged);
        if (this._TaperRatioCheck != null)
          this._TaperRatioCheck.CheckedChanged -= eventHandler;
        this._TaperRatioCheck = value;
        if (this._TaperRatioCheck == null)
          return;
        this._TaperRatioCheck.CheckedChanged += eventHandler;
      }
    }

    internal Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal TextBox AngleBox
    {
      [DebuggerNonUserCode] get => this._AngleBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEventForm);
        EventHandler eventHandler = new EventHandler(this.AngleBox_LostFocus);
        if (this._AngleBox != null)
        {
          this._AngleBox.KeyDown -= keyEventHandler;
          this._AngleBox.LostFocus -= eventHandler;
        }
        this._AngleBox = value;
        if (this._AngleBox == null)
          return;
        this._AngleBox.KeyDown += keyEventHandler;
        this._AngleBox.LostFocus += eventHandler;
      }
    }

    internal Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal Label Label9
    {
      [DebuggerNonUserCode] get => this._Label9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
    }

    internal Label Label11
    {
      [DebuggerNonUserCode] get => this._Label11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
    }

    internal Label EnclosureDepthLabel
    {
      [DebuggerNonUserCode] get => this._EnclosureDepthLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EnclosureDepthLabel_Click);
        if (this._EnclosureDepthLabel != null)
          this._EnclosureDepthLabel.Click -= eventHandler;
        this._EnclosureDepthLabel = value;
        if (this._EnclosureDepthLabel == null)
          return;
        this._EnclosureDepthLabel.Click += eventHandler;
      }
    }

    internal Label EnclosureVolumeLabel
    {
      [DebuggerNonUserCode] get => this._EnclosureVolumeLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EnclosureVolumeLabel_Click);
        if (this._EnclosureVolumeLabel != null)
          this._EnclosureVolumeLabel.Click -= eventHandler;
        this._EnclosureVolumeLabel = value;
        if (this._EnclosureVolumeLabel == null)
          return;
        this._EnclosureVolumeLabel.Click += eventHandler;
      }
    }

    internal Label TotalLengthLabel
    {
      [DebuggerNonUserCode] get => this._TotalLengthLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TotalLengthLabel_Click);
        if (this._TotalLengthLabel != null)
          this._TotalLengthLabel.Click -= eventHandler;
        this._TotalLengthLabel = value;
        if (this._TotalLengthLabel == null)
          return;
        this._TotalLengthLabel.Click += eventHandler;
      }
    }

    internal Label VolumeLabel
    {
      [DebuggerNonUserCode] get => this._VolumeLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VolumeLabel = value;
    }

    internal Label LengthLabel
    {
      [DebuggerNonUserCode] get => this._LengthLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LengthLabel = value;
    }

    internal StatusStrip StatusStrip1
    {
      [DebuggerNonUserCode] get => this._StatusStrip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._StatusStrip1 = value;
    }

    internal ToolStripStatusLabel ToolStripStatusLabel1
    {
      [DebuggerNonUserCode] get => this._ToolStripStatusLabel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripStatusLabel1 = value;
    }

    internal ToolStrip ToolStrip1
    {
      [DebuggerNonUserCode] get => this._ToolStrip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStrip1 = value;
    }

    internal ToolStripButton ToolStripRunButton
    {
      [DebuggerNonUserCode] get => this._ToolStripRunButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripRunButton_Click);
        if (this._ToolStripRunButton != null)
          this._ToolStripRunButton.Click -= eventHandler;
        this._ToolStripRunButton = value;
        if (this._ToolStripRunButton == null)
          return;
        this._ToolStripRunButton.Click += eventHandler;
      }
    }

    internal Label Label12
    {
      [DebuggerNonUserCode] get => this._Label12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
    }

    internal ComboBox TaperTypeBox
    {
      [DebuggerNonUserCode] get => this._TaperTypeBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TaperTypeBox_SelectedIndexChanged);
        if (this._TaperTypeBox != null)
          this._TaperTypeBox.SelectedIndexChanged -= eventHandler;
        this._TaperTypeBox = value;
        if (this._TaperTypeBox == null)
          return;
        this._TaperTypeBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal Label Label13
    {
      [DebuggerNonUserCode] get => this._Label13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
    }

    internal TextBox StuffingBox
    {
      [DebuggerNonUserCode] get => this._StuffingBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEventForm);
        EventHandler eventHandler = new EventHandler(this.StuffingBox_LostFocus);
        if (this._StuffingBox != null)
        {
          this._StuffingBox.KeyDown -= keyEventHandler;
          this._StuffingBox.LostFocus -= eventHandler;
        }
        this._StuffingBox = value;
        if (this._StuffingBox == null)
          return;
        this._StuffingBox.KeyDown += keyEventHandler;
        this._StuffingBox.LostFocus += eventHandler;
      }
    }

    internal Label Label14
    {
      [DebuggerNonUserCode] get => this._Label14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
    }

    internal Label ElementVolumeLabel
    {
      [DebuggerNonUserCode] get => this._ElementVolumeLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ElementVolumeLabel = value;
    }

    internal Label ElementVolumeUnitLabel
    {
      [DebuggerNonUserCode] get => this._ElementVolumeUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ElementVolumeLabel_Click);
        if (this._ElementVolumeUnitLabel != null)
          this._ElementVolumeUnitLabel.Click -= eventHandler;
        this._ElementVolumeUnitLabel = value;
        if (this._ElementVolumeUnitLabel == null)
          return;
        this._ElementVolumeUnitLabel.Click += eventHandler;
      }
    }

    internal ToolStripButton AutoUpdateButton
    {
      [DebuggerNonUserCode] get => this._AutoUpdateButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AutoUpdateButton_Click);
        if (this._AutoUpdateButton != null)
          this._AutoUpdateButton.Click -= eventHandler;
        this._AutoUpdateButton = value;
        if (this._AutoUpdateButton == null)
          return;
        this._AutoUpdateButton.Click += eventHandler;
      }
    }

    internal PictureBox GeometryDisplayBox
    {
      [DebuggerNonUserCode] get => this._GeometryDisplayBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GeometryDisplayBox_MouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GeometryDisplayBox_MouseUp);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GeometryDisplayBox_MouseDown);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.KeyDownEvent);
        EventHandler eventHandler = new EventHandler(this.GeometryDisplayBox_Resize);
        if (this._GeometryDisplayBox != null)
        {
          this._GeometryDisplayBox.MouseMove -= mouseEventHandler1;
          this._GeometryDisplayBox.MouseUp -= mouseEventHandler2;
          this._GeometryDisplayBox.MouseDown -= mouseEventHandler3;
          this._GeometryDisplayBox.KeyDown -= keyEventHandler;
          this._GeometryDisplayBox.Resize -= eventHandler;
        }
        this._GeometryDisplayBox = value;
        if (this._GeometryDisplayBox == null)
          return;
        this._GeometryDisplayBox.MouseMove += mouseEventHandler1;
        this._GeometryDisplayBox.MouseUp += mouseEventHandler2;
        this._GeometryDisplayBox.MouseDown += mouseEventHandler3;
        this._GeometryDisplayBox.KeyDown += keyEventHandler;
        this._GeometryDisplayBox.Resize += eventHandler;
      }
    }

    internal Button CollapseButton
    {
      [DebuggerNonUserCode] get => this._CollapseButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CollapseButton_Click);
        if (this._CollapseButton != null)
          this._CollapseButton.Click -= eventHandler;
        this._CollapseButton = value;
        if (this._CollapseButton == null)
          return;
        this._CollapseButton.Click += eventHandler;
      }
    }

    internal ToolStripSeparator ToolStripSeparator1
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator1 = value;
    }

    internal ToolStripButton ToolStripFrontButton
    {
      [DebuggerNonUserCode] get => this._ToolStripFrontButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripFrontButton_Click);
        if (this._ToolStripFrontButton != null)
          this._ToolStripFrontButton.Click -= eventHandler;
        this._ToolStripFrontButton = value;
        if (this._ToolStripFrontButton == null)
          return;
        this._ToolStripFrontButton.Click += eventHandler;
      }
    }

    internal ToolStripButton ToolStripRearButton
    {
      [DebuggerNonUserCode] get => this._ToolStripRearButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripRearButton_Click);
        if (this._ToolStripRearButton != null)
          this._ToolStripRearButton.Click -= eventHandler;
        this._ToolStripRearButton = value;
        if (this._ToolStripRearButton == null)
          return;
        this._ToolStripRearButton.Click += eventHandler;
      }
    }

    internal Label FrontModelTitle
    {
      [DebuggerNonUserCode] get => this._FrontModelTitle;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FrontModelTitle_Click);
        if (this._FrontModelTitle != null)
          this._FrontModelTitle.Click -= eventHandler;
        this._FrontModelTitle = value;
        if (this._FrontModelTitle == null)
          return;
        this._FrontModelTitle.Click += eventHandler;
      }
    }

    internal Label Label15
    {
      [DebuggerNonUserCode] get => this._Label15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
    }

    internal Label Label16
    {
      [DebuggerNonUserCode] get => this._Label16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
    }

    internal Label VolumeLabel1
    {
      [DebuggerNonUserCode] get => this._VolumeLabel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VolumeLabel1 = value;
    }

    internal Label LengthLabel1
    {
      [DebuggerNonUserCode] get => this._LengthLabel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LengthLabel1 = value;
    }

    internal Label EnclosureVolumeLabel1
    {
      [DebuggerNonUserCode] get => this._EnclosureVolumeLabel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EnclosureVolumeLabel_Click);
        if (this._EnclosureVolumeLabel1 != null)
          this._EnclosureVolumeLabel1.Click -= eventHandler;
        this._EnclosureVolumeLabel1 = value;
        if (this._EnclosureVolumeLabel1 == null)
          return;
        this._EnclosureVolumeLabel1.Click += eventHandler;
      }
    }

    internal Label TotalLengthLabel1
    {
      [DebuggerNonUserCode] get => this._TotalLengthLabel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TotalLengthLabel_Click);
        if (this._TotalLengthLabel1 != null)
          this._TotalLengthLabel1.Click -= eventHandler;
        this._TotalLengthLabel1 = value;
        if (this._TotalLengthLabel1 == null)
          return;
        this._TotalLengthLabel1.Click += eventHandler;
      }
    }

    internal TextBox WidthBox
    {
      [DebuggerNonUserCode] get => this._WidthBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.WidthKeyDownEvent);
        EventHandler eventHandler = new EventHandler(this.WidthBox_LostFocus);
        if (this._WidthBox != null)
        {
          this._WidthBox.KeyDown -= keyEventHandler;
          this._WidthBox.LostFocus -= eventHandler;
        }
        this._WidthBox = value;
        if (this._WidthBox == null)
          return;
        this._WidthBox.KeyDown += keyEventHandler;
        this._WidthBox.LostFocus += eventHandler;
      }
    }

    internal Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal Panel Panel1
    {
      [DebuggerNonUserCode] get => this._Panel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
    }

    internal CheckBox OpenCheckBox
    {
      [DebuggerNonUserCode] get => this._OpenCheckBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenCheckBox_CheckedChanged);
        if (this._OpenCheckBox != null)
          this._OpenCheckBox.CheckedChanged -= eventHandler;
        this._OpenCheckBox = value;
        if (this._OpenCheckBox == null)
          return;
        this._OpenCheckBox.CheckedChanged += eventHandler;
      }
    }

    internal ToolStripSeparator ToolStripSeparator2
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator2 = value;
    }

    internal ToolStripButton THButton
    {
      [DebuggerNonUserCode] get => this._THButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.THButton_Click);
        if (this._THButton != null)
          this._THButton.Click -= eventHandler;
        this._THButton = value;
        if (this._THButton == null)
          return;
        this._THButton.Click += eventHandler;
      }
    }

    internal ToolStripSeparator ToolStripSeparator3
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator3 = value;
    }

    internal ToolStripLabel DriverLabel
    {
      [DebuggerNonUserCode] get => this._DriverLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DriverLabel = value;
    }

    internal Label DriverPositionUnitLabel
    {
      [DebuggerNonUserCode] get => this._DriverPositionUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LengthUnitLabel_Click);
        if (this._DriverPositionUnitLabel != null)
          this._DriverPositionUnitLabel.Click -= eventHandler;
        this._DriverPositionUnitLabel = value;
        if (this._DriverPositionUnitLabel == null)
          return;
        this._DriverPositionUnitLabel.Click += eventHandler;
      }
    }

    internal TextBox DriverPositionBox
    {
      [DebuggerNonUserCode] get => this._DriverPositionBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.DriverPositionKeyDownEvent);
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.DriverPositionBox_LostFocus());
        if (this._DriverPositionBox != null)
        {
          this._DriverPositionBox.KeyDown -= keyEventHandler;
          this._DriverPositionBox.LostFocus -= eventHandler;
        }
        this._DriverPositionBox = value;
        if (this._DriverPositionBox == null)
          return;
        this._DriverPositionBox.KeyDown += keyEventHandler;
        this._DriverPositionBox.LostFocus += eventHandler;
      }
    }

    internal Label DensityUnitLabel
    {
      [DebuggerNonUserCode] get => this._DensityUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DensityUnitLabel_Click);
        if (this._DensityUnitLabel != null)
          this._DensityUnitLabel.Click -= eventHandler;
        this._DensityUnitLabel = value;
        if (this._DensityUnitLabel == null)
          return;
        this._DensityUnitLabel.Click += eventHandler;
      }
    }

    internal Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal TextBox TapPositionBox
    {
      [DebuggerNonUserCode] get => this._TapPositionBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.TapPositionKeyDownEvent);
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.TapPositionBox_LostFocus());
        if (this._TapPositionBox != null)
        {
          this._TapPositionBox.KeyDown -= keyEventHandler;
          this._TapPositionBox.LostFocus -= eventHandler;
        }
        this._TapPositionBox = value;
        if (this._TapPositionBox == null)
          return;
        this._TapPositionBox.KeyDown += keyEventHandler;
        this._TapPositionBox.LostFocus += eventHandler;
      }
    }

    internal Label TapPositionUnitLabel
    {
      [DebuggerNonUserCode] get => this._TapPositionUnitLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LengthUnitLabel_Click);
        if (this._TapPositionUnitLabel != null)
          this._TapPositionUnitLabel.Click -= eventHandler;
        this._TapPositionUnitLabel = value;
        if (this._TapPositionUnitLabel == null)
          return;
        this._TapPositionUnitLabel.Click += eventHandler;
      }
    }

    internal ToolStripDropDownButton ToolStripDropDownButton1
    {
      [DebuggerNonUserCode] get => this._ToolStripDropDownButton1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripDropDownButton1 = value;
    }

    internal ToolStripMenuItem TransmissionLineToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._TransmissionLineToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TransmissionLineToolStripMenuItem = value;
    }

    internal ToolStripMenuItem TaperedToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._TaperedToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TaperedToolStripMenuItem_Click);
        if (this._TaperedToolStripMenuItem != null)
          this._TaperedToolStripMenuItem.Click -= eventHandler;
        this._TaperedToolStripMenuItem = value;
        if (this._TaperedToolStripMenuItem == null)
          return;
        this._TaperedToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem StraightToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._StraightToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StraightToolStripMenuItem_Click);
        if (this._StraightToolStripMenuItem != null)
          this._StraightToolStripMenuItem.Click -= eventHandler;
        this._StraightToolStripMenuItem = value;
        if (this._StraightToolStripMenuItem == null)
          return;
        this._StraightToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem ExpandingToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ExpandingToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExpandingToolStripMenuItem_Click);
        if (this._ExpandingToolStripMenuItem != null)
          this._ExpandingToolStripMenuItem.Click -= eventHandler;
        this._ExpandingToolStripMenuItem = value;
        if (this._ExpandingToolStripMenuItem == null)
          return;
        this._ExpandingToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem SealedToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._SealedToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SealedToolStripMenuItem_Click);
        if (this._SealedToolStripMenuItem != null)
          this._SealedToolStripMenuItem.Click -= eventHandler;
        this._SealedToolStripMenuItem = value;
        if (this._SealedToolStripMenuItem == null)
          return;
        this._SealedToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripSeparator ToolStripSeparator4
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator4 = value;
    }

    internal ToolStripMenuItem PortedToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._PortedToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PortedToolStripMenuItem_Click);
        if (this._PortedToolStripMenuItem != null)
          this._PortedToolStripMenuItem.Click -= eventHandler;
        this._PortedToolStripMenuItem = value;
        if (this._PortedToolStripMenuItem == null)
          return;
        this._PortedToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem BandPassToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._BandPassToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BandPassToolStripMenuItem_Click);
        if (this._BandPassToolStripMenuItem != null)
          this._BandPassToolStripMenuItem.Click -= eventHandler;
        this._BandPassToolStripMenuItem = value;
        if (this._BandPassToolStripMenuItem == null)
          return;
        this._BandPassToolStripMenuItem.Click += eventHandler;
      }
    }

    internal Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal Label Label18
    {
      [DebuggerNonUserCode] get => this._Label18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
    }

    internal TextBox HypExpTBox
    {
      [DebuggerNonUserCode] get => this._HypExpTBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HypExpTBox_LostFocus);
        if (this._HypExpTBox != null)
          this._HypExpTBox.LostFocus -= eventHandler;
        this._HypExpTBox = value;
        if (this._HypExpTBox == null)
          return;
        this._HypExpTBox.LostFocus += eventHandler;
      }
    }

    public event GeometryDisplayClass.TLParameterUpdatedEventHandler TLParameterUpdated;

    public event GeometryDisplayClass.SettingsUpdatedEventHandler SettingsUpdated;

    public GeometryDisplayClass(
      TLParameters TLGeometry,
      SettingsParameters Settings,
      DriverParameters DriverParameter,
      DriverSetup DriverSetupParameter)
    {
      this.Load += new EventHandler(this.GeometryDisplayClass_Load);
      this.FormClosing += new FormClosingEventHandler(this.GeometryDisplayClass_FormClosing);
      this.GotFocus += new EventHandler(this.GeometryDisplayClass_GotFocus);
      this.LostFocus += new EventHandler(this.GeometryDisplayBox_LostFocus);
      this.MouseWheel += new MouseEventHandler(this.GeometryDisplayBox_MouseWheel);
      GeometryDisplayClass.__ENCAddToList((object) this);
      this.HandleInfo = new GeometryDisplayClass.HandleStruct(false, false, GeometryDisplayClass.HandleType.EndArea);
      this.ShowRearModelInfo = true;
      this.ShowFrontModelInfo = true;
      this.ShowElementInfo = true;
      this.SelectCount = 0;
      this.SelectedNode = (TreeNode) null;
      this.HandleSize = 3;
      this.LightStuffing = 0.16;
      this.MediumStuffing = 1.0;
      this.HeavyStuffing = 2.0;
      this.CopyNode = (TreeNode) null;
      this.SupressFormChangeDetection = false;
      this.SelectMouseButton = MouseButtons.Left;
      this.OptionMouseButton = MouseButtons.Right;
      this.MouseButtonPressed = MouseButtons.None;
      this.MouseHasMoved = false;
      this.InitializeComponent();
      this.DriverSetupFromParent = DriverSetupParameter;
      this.TLGeometryFromParent = TLGeometry;
      this.SettingsFromParent = Settings;
      this.DriverFromParent = DriverParameter;
      this.DefaultElement.Length = 0.5;
      this.DefaultElement.StartArea = 0.05;
      this.DefaultElement.EndArea = 0.05;
      this.DefaultElement.Taper = 1;
      this.DefaultElement.StuffingDensity = 0.16;
      this.DefaultElement.Angle = 0.0;
      this.UpdateUnits();
    }

    public DriverSetup DriverSetupFromParent
    {
      set
      {
        this.DriverSetupEdit = value;
        this.THButton.Checked = this.DriverSetupEdit.Tapped;
        this.ToolStripFrontButton.Enabled = !this.DriverSetupEdit.Tapped;
        this.TapPositionBox.Enabled = this.DriverSetupEdit.Tapped;
        if (!this.DriverSetupEdit.Tapped)
          return;
        this.ToolStripFrontButton.Checked = false;
        this.SettingsEdit.ShowFront = false;
      }
    }

    public DriverParameters DriverFromParent
    {
      set
      {
        this.DriverEdit = value;
        this.DriverLabel.Text = "Driver: " + this.DriverEdit.Title;
        this.UpdateImage();
      }
    }

    public SettingsParameters SettingsFromParent
    {
      set
      {
        this.SettingsEdit = value;
        this.AutoUpdateButton.Checked = this.SettingsEdit.AutoUpdate;
        this.UpdateModelForm();
      }
    }

    public TLParameters TLGeometryFromParent
    {
      set
      {
        this.SelectedNode = (TreeNode) null;
        this.TLGeometryEdit.Width = value.Width;
        if (!Information.IsNothing((object) this.TLGeometryEdit.RearEnclosure))
          this.TLGeometryEdit.RearEnclosure.Nodes.Clear();
        else
          this.TLGeometryEdit.RearEnclosure = new TreeNode();
        this.TLGeometryEdit.RearEnclosure.Tag = (object) "Rear";
        if (!Information.IsNothing((object) value.RearEnclosure))
        {
          int num = checked (value.RearEnclosure.Nodes.Count - 1);
          int index = 0;
          while (index <= num)
          {
            this.TLGeometryEdit.RearEnclosure.Nodes.Add((TreeNode) value.RearEnclosure.Nodes[index].Clone());
            checked { ++index; }
          }
        }
        if (!Information.IsNothing((object) this.TLGeometryEdit.FrontEnclosure))
          this.TLGeometryEdit.FrontEnclosure.Nodes.Clear();
        else
          this.TLGeometryEdit.FrontEnclosure = new TreeNode();
        this.TLGeometryEdit.FrontEnclosure.Tag = (object) "Front";
        if (!Information.IsNothing((object) value.FrontEnclosure))
        {
          int num = checked (value.FrontEnclosure.Nodes.Count - 1);
          int index = 0;
          while (index <= num)
          {
            this.TLGeometryEdit.FrontEnclosure.Nodes.Add((TreeNode) value.FrontEnclosure.Nodes[index].Clone());
            checked { ++index; }
          }
        }
        this.UpdateImage();
        this.UpdateModelForm();
        this.UpdateElementForm();
      }
    }

    private void UpdateElementForm()
    {
      this.SupressFormChangeDetection = true;
      if (Information.IsNothing((object) this.SelectedNode))
      {
        this.ElementTitleLabel.Text = "    Element: No Selection";
        this.LengthBox.Text = "";
        this.StartAreaBox.Text = "";
        this.EndAreaBox.Text = "";
        this.TaperRatioBox.Text = "";
        this.TaperTypeBox.SelectedIndex = -1;
        this.HypExpTBox.Text = "";
        this.AngleBox.Text = "";
        this.StuffingBox.Text = "";
        this.ElementVolumeLabel.Text = "";
        this.OpenCheckBox.Checked = false;
        this.OpenCheckBox.Enabled = false;
      }
      else
      {
        this.ElementTitleLabel.Text = "    Element: " + Functions.GetTreeString(this.SelectedNode);
        TextBox lengthBox = this.LengthBox;
        int lengthUnit = this.SettingsEdit.LengthUnit;
        object tag1 = this.SelectedNode.Tag;
        TLElement tlElement = default;
        double length = (tag1 != null ? (TLElement) tag1 : tlElement).Length;
        string str1 = Functions.ConvertLength(1, lengthUnit, length).ToString();
        lengthBox.Text = str1;
        TextBox startAreaBox = this.StartAreaBox;
        int startAreaUnit = this.SettingsEdit.StartAreaUnit;
        object tag2 = this.SelectedNode.Tag;
        double startArea1 = (tag2 != null ? (TLElement) tag2 : tlElement).StartArea;
        string str2 = Functions.ConvertArea(1, startAreaUnit, startArea1).ToString();
        startAreaBox.Text = str2;
        TextBox endAreaBox = this.EndAreaBox;
        int endAreaUnit = this.SettingsEdit.EndAreaUnit;
        object tag3 = this.SelectedNode.Tag;
        double endArea1 = (tag3 != null ? (TLElement) tag3 : tlElement).EndArea;
        string str3 = Functions.ConvertArea(1, endAreaUnit, endArea1).ToString();
        endAreaBox.Text = str3;
        TextBox taperRatioBox = this.TaperRatioBox;
        object tag4 = this.SelectedNode.Tag;
        double endArea2 = (tag4 != null ? (TLElement) tag4 : tlElement).EndArea;
        object tag5 = this.SelectedNode.Tag;
        double startArea2 = (tag5 != null ? (TLElement) tag5 : tlElement).StartArea;
        string str4 = (endArea2 / startArea2).ToString();
        taperRatioBox.Text = str4;
        ComboBox taperTypeBox = this.TaperTypeBox;
        object tag6 = this.SelectedNode.Tag;
        int num1 = checked ((unchecked (tag6 != null) ? (TLElement) tag6 : tlElement).Taper - 1);
        taperTypeBox.SelectedIndex = num1;
        object tag7 = this.SelectedNode.Tag;
        switch ((tag7 != null ? (TLElement) tag7 : tlElement).Taper)
        {
          case 1:
            this.HypExpTBox.Text = "";
            this.HypExpTBox.Enabled = false;
            break;
          case 2:
            this.HypExpTBox.Text = "1";
            this.HypExpTBox.Enabled = false;
            break;
          case 3:
            this.HypExpTBox.Text = "1000000";
            this.HypExpTBox.Enabled = false;
            break;
          case 4:
            TextBox hypExpTbox = this.HypExpTBox;
            object tag8 = this.SelectedNode.Tag;
            string str5 = (tag8 != null ? (TLElement) tag8 : tlElement).HypExpT.ToString();
            hypExpTbox.Text = str5;
            this.HypExpTBox.Enabled = true;
            break;
          default:
            this.HypExpTBox.Text = "";
            break;
        }
        TextBox angleBox = this.AngleBox;
        object tag9 = this.SelectedNode.Tag;
        string str6 = (tag9 != null ? (TLElement) tag9 : tlElement).Angle.ToString();
        angleBox.Text = str6;
        TextBox stuffingBox = this.StuffingBox;
        int densityUnit = this.SettingsEdit.DensityUnit;
        object tag10 = this.SelectedNode.Tag;
        double stuffingDensity = (tag10 != null ? (TLElement) tag10 : tlElement).StuffingDensity;
        string str7 = Functions.ConvertDensity(1, densityUnit, stuffingDensity).ToString();
        stuffingBox.Text = str7;
        Label elementVolumeLabel = this.ElementVolumeLabel;
        int elementVolumeUnit = this.SettingsEdit.ElementVolumeUnit;
        object tag11 = this.SelectedNode.Tag;
        double volume = (tag11 != null ? (TLElement) tag11 : tlElement).Volume;
        string str8 = Functions.ConvertVolume(1, elementVolumeUnit, volume).ToString();
        elementVolumeLabel.Text = str8;
        if (this.SelectedNode.Index == checked (this.SelectedNode.Parent.Nodes.Count - 1))
        {
          this.OpenCheckBox.Enabled = true;
          CheckBox openCheckBox = this.OpenCheckBox;
          object tag12 = this.SelectedNode.Tag;
          int num2 = (tag12 != null ? (TLElement) tag12 : tlElement).OpenEnd ? 1 : 0;
          openCheckBox.Checked = num2 != 0;
        }
        else
        {
          this.OpenCheckBox.Checked = false;
          this.OpenCheckBox.Enabled = false;
        }
      }
      this.SupressFormChangeDetection = false;
    }

    private void UpdateUnits()
    {
      this.LengthUnitLabel.Text = Functions.UnitStringLength(this.SettingsEdit.LengthUnit);
      this.DensityUnitLabel.Text = Functions.UnitStringDensity(this.SettingsEdit.DensityUnit);
      this.StartAreaUnitLabel.Text = Functions.UnitStringLength(this.SettingsEdit.StartAreaUnit) + "\u00B2";
      this.EndAreaUnitLabel.Text = Functions.UnitStringLength(this.SettingsEdit.EndAreaUnit) + "\u00B2";
      this.EnclosureVolumeLabel.Text = Functions.UnitStringVolume(this.SettingsEdit.VolumeUnit);
      this.ElementVolumeUnitLabel.Text = Functions.UnitStringVolume(this.SettingsEdit.ElementVolumeUnit);
      this.TotalLengthLabel.Text = Functions.UnitStringLength(this.SettingsEdit.TotalLengthUnit);
      this.EnclosureVolumeLabel1.Text = Functions.UnitStringVolume(this.SettingsEdit.VolumeUnit);
      this.TotalLengthLabel1.Text = Functions.UnitStringLength(this.SettingsEdit.TotalLengthUnit);
      this.EnclosureDepthLabel.Text = Functions.UnitStringLength(this.SettingsEdit.EnclosureDepthUnit);
      this.DriverPositionUnitLabel.Text = Functions.UnitStringLength(this.SettingsEdit.LengthUnit);
      this.TapPositionUnitLabel.Text = Functions.UnitStringLength(this.SettingsEdit.LengthUnit);
    }

    private void UpdateModelForm()
    {
      this.RefreshVolumeLength();
      this.WidthBox.Text = Functions.ConvertLength(1, this.SettingsEdit.EnclosureDepthUnit, this.TLGeometryEdit.Width).ToString();
      this.DriverPositionBox.Text = Functions.ConvertLength(1, this.SettingsEdit.LengthUnit, this.DriverSetupEdit.DriverPosition).ToString();
      this.TapPositionBox.Text = Functions.ConvertLength(1, this.SettingsEdit.LengthUnit, this.DriverSetupEdit.TapPosition).ToString();
    }

    private void RefreshVolumeLength()
    {
      this.Volume = 0.0;
      this.Length = 0.0;
      try
      {
        foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
          this.RecursiveVolumeLength(node);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.VolumeLabel.Text = Functions.ConvertVolume(1, this.SettingsEdit.VolumeUnit, this.Volume).ToString();
      this.LengthLabel.Text = Functions.ConvertLength(1, this.SettingsEdit.TotalLengthUnit, this.Length).ToString();
      this.Volume = 0.0;
      this.Length = 0.0;
      try
      {
        foreach (TreeNode node in this.TLGeometryEdit.FrontEnclosure.Nodes)
          this.RecursiveVolumeLength(node);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.VolumeLabel1.Text = Functions.ConvertVolume(1, this.SettingsEdit.VolumeUnit, this.Volume).ToString();
      this.LengthLabel1.Text = Functions.ConvertLength(1, this.SettingsEdit.TotalLengthUnit, this.Length).ToString();
    }

    private void RecursiveVolumeLength(TreeNode n)
    {
      double volume1 = this.Volume;
      object tag1 = n.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
      double volume2 = tlElement2.Volume;
      this.Volume = volume1 + volume2;
      double length1 = this.Length;
      object tag2 = n.Tag;
      tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
      double length2 = tlElement2.Length;
      this.Length = length1 + length2;
      try
      {
        foreach (TreeNode node in n.Nodes)
          this.RecursiveVolumeLength(node);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private PointF DriverPosition(int driver)
    {
      double num1 = driver != 1 ? this.DriverSetupEdit.TapPosition : this.DriverSetupEdit.DriverPosition;
      PointF pointF1 = default;
      pointF1.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF1.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      double num2 = 0.0;
      PointF position = default;
      double angle = 0;
      double num3 = 0;
      try
      {
        foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
        {
          int num4 = num1 >= num2 ? 1 : 0;
          double num5 = num1;
          double num6 = num2;
          object tag1 = node.Tag;
          TLElement tlElement = default;
          double length1 = (tag1 != null ? (TLElement) tag1 : tlElement).Length;
          double num7 = num6 + length1;
          int num8 = num5 <= num7 ? 1 : 0;
          if ((num4 & num8) != 0)
          {
            position = Functions.NewGetPosition(node, this.TLGeometryEdit);
            object tag2 = node.Tag;
            angle = (tag2 != null ? (TLElement) tag2 : tlElement).Angle;
            num3 = num1 - num2;
          }
          double num9 = num2;
          object tag3 = node.Tag;
          double length2 = (tag3 != null ? (TLElement) tag3 : tlElement).Length;
          num2 = num9 + length2;
        }
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      PointF pointF2 = default;
      pointF2.X = this.ScaleDivide * (pointF1.X + position.X + (float) (num3 * Math.Cos(Functions.Deg2Rad(angle))));
      pointF2.Y = this.ScaleDivide * (pointF1.Y + position.Y + (float) (num3 * Math.Sin(Functions.Deg2Rad(angle))));
      return pointF2;
    }

    private void DrawDriver()
    {
      Graphics graphics = Graphics.FromImage(this.GeometryDisplayBox.Image);
      Pen pen1 = new Pen(Color.Black, 1f);
      pen1.DashStyle = DashStyle.Dash;
      Pen pen2 = new Pen(Color.DarkGray, 1f);
      pen2.DashStyle = DashStyle.Dash;
      double num = Math.Sqrt(this.DriverEdit.Sd / Math.PI);
      PointF pointF1 = this.DriverPosition(1);
      graphics.DrawEllipse(pen1, pointF1.X - this.ScaleDivide * (float) num, pointF1.Y - this.ScaleDivide * (float) num, this.ScaleDivide * (float) (num * 2.0), this.ScaleDivide * (float) (num * 2.0));
      graphics.FillRectangle(Brushes.Blue, pointF1.X - (float) this.HandleSize, pointF1.Y - (float) this.HandleSize, (float) checked (this.HandleSize * 2), (float) checked (this.HandleSize * 2));
      if (!this.DriverSetupEdit.Tapped)
        return;
      PointF pointF2 = this.DriverPosition(2);
      graphics.DrawEllipse(pen2, pointF2.X - this.ScaleDivide * (float) num, pointF2.Y - this.ScaleDivide * (float) num, this.ScaleDivide * (float) (num * 2.0), this.ScaleDivide * (float) (num * 2.0));
      graphics.FillRectangle(Brushes.Red, pointF2.X - (float) this.HandleSize, pointF2.Y - (float) this.HandleSize, (float) checked (this.HandleSize * 2), (float) checked (this.HandleSize * 2));
    }

    private void DrawSelectionBox()
    {
      Graphics graphics = Graphics.FromImage(this.GeometryDisplayBox.Image);
      Pen pen = new Pen(Color.Gray, 1f);
      pen.DashStyle = DashStyle.Dash;
      if (!(this.MouseCurrentLocation != this.MouseStartLocation))
        return;
      float width = (float) checked (this.MouseCurrentLocation.X - this.MouseStartLocation.X);
      float height = (float) checked (this.MouseCurrentLocation.Y - this.MouseStartLocation.Y);
      Point point = default;
      if ((double) height < 0.0)
      {
        point.Y = this.MouseCurrentLocation.Y;
        height = -1f * height;
      }
      else
        point.Y = this.MouseStartLocation.Y;
      if ((double) width < 0.0)
      {
        point.X = this.MouseCurrentLocation.X;
        width = -1f * width;
      }
      else
        point.X = this.MouseStartLocation.X;
      graphics.DrawRectangle(pen, (float) point.X, (float) point.Y, width, height);
    }

    private void DrawElement()
    {
      this.ScaleDivide = (double) this.SettingsEdit.GeometryScale <= 0.0 ? 250f : 1000f / this.SettingsEdit.GeometryScale;
      if (this.MouseButtonPressed == MouseButtons.Left)
        this.DrawSelectionBox();
      this.DrawDriver();
      if (this.SettingsEdit.ShowRear)
      {
        try
        {
          foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
            this.DrawElementRecursive(node, this.TLGeometryEdit.RearEnclosure);
        }
        finally
        {
          IEnumerator enumerator = null;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (this.SettingsEdit.ShowFront)
      {
        try
        {
          foreach (TreeNode node in this.TLGeometryEdit.FrontEnclosure.Nodes)
            this.DrawElementRecursive(node, this.TLGeometryEdit.FrontEnclosure);
        }
        finally
        {
          IEnumerator enumerator = null;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      this.GeometryDisplayBox.Invalidate();
    }

    private void DrawElementRecursive(TreeNode Node, TreeNode Tree)
    {
      Graphics graphics = Graphics.FromImage(this.GeometryDisplayBox.Image);
      Pen pen1 = new Pen(Color.Red, 1f);
      pen1.DashStyle = DashStyle.Dash;
      Pen pen2 = new Pen(Color.Gray, 1f);
      pen2.DashStyle = DashStyle.Dot;
      PointF pointF1 = default;
      pointF1.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF1.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      Pen pen3 = new Pen(Color.Black, 1f);
      string[] strArray = Strings.Split(Functions.GetTreeString(Node), ".");
      if (Operators.CompareString(strArray[0], "Rear", false) == 0)
      {
        pen3.Color = Color.Black;
      }
      else
      {
        pen3.Color = Color.Green;
        pointF1 = this.DriverPosition(1);
        pointF1.X /= this.ScaleDivide;
        pointF1.Y /= this.ScaleDivide;
      }
      if (!Information.IsNothing((object) this.SelectedNode))
        pen3.Color = Operators.CompareString(Functions.GetTreeString(Node), Functions.GetTreeString(this.SelectedNode), false) != 0 ? (Operators.CompareString(strArray[0], "Rear", false) != 0 ? Color.Green : Color.Black) : Color.Blue;
      PointF position = Functions.NewGetPosition(Node, this.TLGeometryEdit);
      object tag1 = Node.Tag;
      TLElement tlElement = default;
      double angle = (tag1 != null ? (TLElement) tag1 : tlElement).Angle;
      PointF pointF2 = default;
      ref PointF local1 = ref pointF2;
      double x1 = (double) pointF1.X;
      double x2 = (double) position.X;
      object tag2 = Node.Tag;
      double num1 = 0.5 * ((tag2 != null ? (TLElement) tag2 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num2 = x2 - num1;
      double num3 = x1 + num2;
      local1.X = (float) num3;
      ref PointF local2 = ref pointF2;
      double y1 = (double) pointF1.Y;
      double y2 = (double) position.Y;
      object tag3 = Node.Tag;
      double num4 = 0.5 * ((tag3 != null ? (TLElement) tag3 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num5 = y2 + num4;
      double num6 = y1 + num5;
      local2.Y = (float) num6;
      PointF pointF3 = default;
      ref PointF local3 = ref pointF3;
      double x3 = (double) pointF1.X;
      double x4 = (double) position.X;
      object tag4 = Node.Tag;
      double num7 = 0.5 * ((tag4 != null ? (TLElement) tag4 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num8 = x4 + num7;
      double num9 = x3 + num8;
      local3.X = (float) num9;
      ref PointF local4 = ref pointF3;
      double y3 = (double) pointF1.Y;
      double y4 = (double) position.Y;
      object tag5 = Node.Tag;
      double num10 = 0.5 * ((tag5 != null ? (TLElement) tag5 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num11 = y4 - num10;
      double num12 = y3 + num11;
      local4.Y = (float) num12;
      PointF pointF4 = default;
      ref PointF local5 = ref pointF4;
      double x5 = (double) pointF1.X;
      double x6 = (double) position.X;
      object tag6 = Node.Tag;
      double num13 = (tag6 != null ? (TLElement) tag6 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
      double num14 = x6 + num13;
      object tag7 = Node.Tag;
      double num15 = 0.5 * ((tag7 != null ? (TLElement) tag7 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num16 = num14 + num15;
      double num17 = x5 + num16;
      local5.X = (float) num17;
      ref PointF local6 = ref pointF4;
      double y5 = (double) pointF1.Y;
      double y6 = (double) position.Y;
      object tag8 = Node.Tag;
      double num18 = (tag8 != null ? (TLElement) tag8 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
      double num19 = y6 + num18;
      object tag9 = Node.Tag;
      double num20 = 0.5 * ((tag9 != null ? (TLElement) tag9 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num21 = num19 - num20;
      double num22 = y5 + num21;
      local6.Y = (float) num22;
      PointF pointF5 = default;
      ref PointF local7 = ref pointF5;
      double x7 = (double) pointF1.X;
      double x8 = (double) position.X;
      object tag10 = Node.Tag;
      double num23 = (tag10 != null ? (TLElement) tag10 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
      double num24 = x8 + num23;
      object tag11 = Node.Tag;
      double num25 = 0.5 * ((tag11 != null ? (TLElement) tag11 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num26 = num24 - num25;
      double num27 = x7 + num26;
      local7.X = (float) num27;
      ref PointF local8 = ref pointF5;
      double y7 = (double) pointF1.Y;
      double y8 = (double) position.Y;
      object tag12 = Node.Tag;
      double num28 = (tag12 != null ? (TLElement) tag12 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
      double num29 = y8 + num28;
      object tag13 = Node.Tag;
      double num30 = 0.5 * ((tag13 != null ? (TLElement) tag13 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num31 = num29 + num30;
      double num32 = y7 + num31;
      local8.Y = (float) num32;
      PointF[] pointFArray = new PointF[1];
      object tag14 = Node.Tag;
      int num33 = (tag14 != null ? (TLElement) tag14 : tlElement).Taper == 2 ? 1 : 0;
      object tag15 = Node.Tag;
      int num34 = (tag15 != null ? (TLElement) tag15 : tlElement).Taper == 3 ? 1 : 0;
      int num35 = num33 | num34;
      object tag16 = Node.Tag;
      int num36 = (tag16 != null ? (TLElement) tag16 : tlElement).Taper == 4 ? 1 : 0;
      PointF[] points;
      if ((num35 | num36) != 0)
      {
        points = new PointF[202];
        int index = 0;
        do
        {
          double num37 = (double) index;
          object tag17 = Node.Tag;
          double num38 = (tag17 != null ? (TLElement) tag17 : tlElement).Length / 100.0;
          double x9 = num37 * num38;
          double num39 = (double) checked (index + 1);
          object tag18 = Node.Tag;
          double num40 = (tag18 != null ? (TLElement) tag18 : tlElement).Length / 100.0;
          double x10 = num39 * num40;
          object tag19 = Node.Tag;
          double num41 = (tag19 != null ? (TLElement) tag19 : tlElement).get_Area(x9);
          object tag20 = Node.Tag;
          double num42 = (tag20 != null ? (TLElement) tag20 : tlElement).get_Area(x10);
          PointF pointF6 = default;
          pointF6.X = pointF1.X + (float) ((double) position.X + x9 * Math.Cos(Functions.Deg2Rad(angle)) - 0.5 * (num41 / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle)));
          pointF6.Y = pointF1.Y + (float) ((double) position.Y + x9 * Math.Sin(Functions.Deg2Rad(angle)) + 0.5 * (num41 / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle)));
          PointF pointF7 = default;
          pointF7.X = pointF1.X + (float) ((double) position.X + x9 * Math.Cos(Functions.Deg2Rad(angle)) + 0.5 * (num41 / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle)));
          pointF7.Y = pointF1.Y + (float) ((double) position.Y + x9 * Math.Sin(Functions.Deg2Rad(angle)) - 0.5 * (num41 / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle)));
          PointF pointF8 = default;
          pointF8.X = pointF1.X + (float) ((double) position.X + x10 * Math.Cos(Functions.Deg2Rad(angle)) + 0.5 * (num42 / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle)));
          pointF8.Y = pointF1.Y + (float) ((double) position.Y + x10 * Math.Sin(Functions.Deg2Rad(angle)) - 0.5 * (num42 / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle)));
          PointF pointF9 = default;
          pointF9.X = pointF1.X + (float) ((double) position.X + x10 * Math.Cos(Functions.Deg2Rad(angle)) - 0.5 * (num42 / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle)));
          pointF9.Y = pointF1.Y + (float) ((double) position.Y + x10 * Math.Sin(Functions.Deg2Rad(angle)) + 0.5 * (num42 / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle)));
          points[index].X = pointF7.X * this.ScaleDivide;
          points[index].Y = pointF7.Y * this.ScaleDivide;
          points[checked (201 - index)].X = pointF6.X * this.ScaleDivide;
          points[checked (201 - index)].Y = pointF6.Y * this.ScaleDivide;
          if (index == 99)
          {
            points[100].X = pointF8.X * this.ScaleDivide;
            points[100].Y = pointF8.Y * this.ScaleDivide;
            points[101].X = pointF9.X * this.ScaleDivide;
            points[101].Y = pointF9.Y * this.ScaleDivide;
          }
          graphics.DrawLine(pen3, pointF7.X * this.ScaleDivide, pointF7.Y * this.ScaleDivide, pointF8.X * this.ScaleDivide, pointF8.Y * this.ScaleDivide);
          graphics.DrawLine(pen3, pointF6.X * this.ScaleDivide, pointF6.Y * this.ScaleDivide, pointF9.X * this.ScaleDivide, pointF9.Y * this.ScaleDivide);
          checked { ++index; }
        }
        while (index <= 99);
      }
      else
      {
        points = new PointF[4];
        points[0].X = pointF2.X * this.ScaleDivide;
        points[0].Y = pointF2.Y * this.ScaleDivide;
        points[1].X = pointF3.X * this.ScaleDivide;
        points[1].Y = pointF3.Y * this.ScaleDivide;
        points[2].X = pointF4.X * this.ScaleDivide;
        points[2].Y = pointF4.Y * this.ScaleDivide;
        points[3].X = pointF5.X * this.ScaleDivide;
        points[3].Y = pointF5.Y * this.ScaleDivide;
        graphics.DrawLine(pen3, pointF3.X * this.ScaleDivide, pointF3.Y * this.ScaleDivide, pointF4.X * this.ScaleDivide, pointF4.Y * this.ScaleDivide);
        graphics.DrawLine(pen3, pointF2.X * this.ScaleDivide, pointF2.Y * this.ScaleDivide, pointF5.X * this.ScaleDivide, pointF5.Y * this.ScaleDivide);
      }
      SolidBrush solidBrush = new SolidBrush(Color.Black);
      object tag21 = Node.Tag;
      double num43 = (tag21 != null ? (TLElement) tag21 : tlElement).StuffingDensity / 3.0;
      if (num43 > 1.0)
        num43 = 1.0;
      double a = (1.0 - num43) * (double) byte.MaxValue;
      solidBrush.Color = Color.FromArgb(100, checked ((int) Math.Round(a)), checked ((int) Math.Round(a)), checked ((int) Math.Round(a)));
      graphics.FillPolygon((Brush) solidBrush, points);
      Pen pen4 = pen1;
      if (Node.Index == checked (Node.Parent.Nodes.Count - 1))
      {
        object tag22 = Node.Tag;
        if ((tag22 != null ? (TLElement) tag22 : tlElement).OpenEnd)
          pen4.Width = 0.0f;
        else
          pen4 = pen3;
      }
      else if (!Information.IsNothing((object) Node.NextNode))
      {
        object tag23 = Node.Tag;
        TLElement Element1 = tag23 != null ? (TLElement) tag23 : tlElement;
        object tag24 = Node.NextNode.Tag;
        TLElement Element2 = tag24 != null ? (TLElement) tag24 : tlElement;
        if (Functions.ElementMergeBoolSibling(Element1, Element2))
          pen4 = Pens.DarkOrange;
      }
      graphics.DrawLine(pen4, pointF5.X * this.ScaleDivide, pointF5.Y * this.ScaleDivide, pointF4.X * this.ScaleDivide, pointF4.Y * this.ScaleDivide);
      Pen pen5 = pen1;
      if (Node.Level == 1 & Node.Index == 0 & Node.Nodes.Count == 0)
        pen5 = pen3;
      else if (!Information.IsNothing((object) Node.PrevNode))
      {
        object tag25 = Node.PrevNode.Tag;
        TLElement Element1 = tag25 != null ? (TLElement) tag25 : tlElement;
        object tag26 = Node.Tag;
        TLElement Element2 = tag26 != null ? (TLElement) tag26 : tlElement;
        if (Functions.ElementMergeBoolSibling(Element1, Element2))
          pen5 = Pens.DarkOrange;
      }
      graphics.DrawLine(pen5, pointF2.X * this.ScaleDivide, pointF2.Y * this.ScaleDivide, pointF3.X * this.ScaleDivide, pointF3.Y * this.ScaleDivide);
      if (!Information.IsNothing((object) this.SelectedNode) && Operators.CompareString(Functions.GetTreeString(Node), Functions.GetTreeString(this.SelectedNode), false) == 0)
      {
        PointF pt1 = default;
        pt1.X = this.ScaleDivide * (pointF1.X + position.X);
        pt1.Y = this.ScaleDivide * (pointF1.Y + position.Y);
        PointF pt2 = default;
        pt2.X = pt1.X + (float) (25.0 * Math.Cos(Functions.Deg2Rad(angle)));
        pt2.Y = pt1.Y + (float) (25.0 * Math.Sin(Functions.Deg2Rad(angle)));
        graphics.DrawLine(pen2, pt1, pt2);
        graphics.FillEllipse(Brushes.Red, pt2.X - (float) this.HandleSize, pt2.Y - (float) this.HandleSize, (float) checked (this.HandleSize * 2), (float) checked (this.HandleSize * 2));
        PointF pointF10 = default;
        ref PointF local9 = ref pointF10;
        double scaleDivide1 = (double) this.ScaleDivide;
        double num44 = (double) pointF1.X + (double) position.X;
        object tag27 = Node.Tag;
        double num45 = (tag27 != null ? (TLElement) tag27 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
        double num46 = num44 + num45;
        double num47 = scaleDivide1 * num46;
        local9.X = (float) num47;
        ref PointF local10 = ref pointF10;
        double scaleDivide2 = (double) this.ScaleDivide;
        double num48 = (double) pointF1.Y + (double) position.Y;
        object tag28 = Node.Tag;
        double num49 = (tag28 != null ? (TLElement) tag28 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
        double num50 = num48 + num49;
        double num51 = scaleDivide2 * num50;
        local10.Y = (float) num51;
        graphics.FillRectangle(Brushes.Red, pointF10.X - (float) this.HandleSize, pointF10.Y - (float) this.HandleSize, (float) checked (this.HandleSize * 2), (float) checked (this.HandleSize * 2));
        PointF pointF11 = default;
        ref PointF local11 = ref pointF11;
        double scaleDivide3 = (double) this.ScaleDivide;
        double x11 = (double) pointF1.X;
        double x12 = (double) position.X;
        object tag29 = Node.Tag;
        double num52 = 0.5 * ((tag29 != null ? (TLElement) tag29 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
        double num53 = x12 + num52;
        double num54 = x11 + num53;
        double num55 = scaleDivide3 * num54;
        local11.X = (float) num55;
        ref PointF local12 = ref pointF11;
        double scaleDivide4 = (double) this.ScaleDivide;
        double y9 = (double) pointF1.Y;
        double y10 = (double) position.Y;
        object tag30 = Node.Tag;
        double num56 = 0.5 * ((tag30 != null ? (TLElement) tag30 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
        double num57 = y10 - num56;
        double num58 = y9 + num57;
        double num59 = scaleDivide4 * num58;
        local12.Y = (float) num59;
        graphics.FillRectangle(Brushes.Red, pointF11.X - (float) this.HandleSize, pointF11.Y - (float) this.HandleSize, (float) checked (this.HandleSize * 2), (float) checked (this.HandleSize * 2));
        PointF pointF12 = default;
        ref PointF local13 = ref pointF12;
        double scaleDivide5 = (double) this.ScaleDivide;
        double x13 = (double) pointF1.X;
        double x14 = (double) position.X;
        object tag31 = Node.Tag;
        double num60 = (tag31 != null ? (TLElement) tag31 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
        double num61 = x14 + num60;
        object tag32 = Node.Tag;
        double num62 = 0.5 * ((tag32 != null ? (TLElement) tag32 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
        double num63 = num61 + num62;
        double num64 = x13 + num63;
        double num65 = scaleDivide5 * num64;
        local13.X = (float) num65;
        ref PointF local14 = ref pointF12;
        double scaleDivide6 = (double) this.ScaleDivide;
        double y11 = (double) pointF1.Y;
        double y12 = (double) position.Y;
        object tag33 = Node.Tag;
        double num66 = (tag33 != null ? (TLElement) tag33 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
        double num67 = y12 + num66;
        object tag34 = Node.Tag;
        double num68 = 0.5 * ((tag34 != null ? (TLElement) tag34 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
        double num69 = num67 - num68;
        double num70 = y11 + num69;
        double num71 = scaleDivide6 * num70;
        local14.Y = (float) num71;
        graphics.FillRectangle(Brushes.Red, pointF12.X - (float) this.HandleSize, pointF12.Y - (float) this.HandleSize, (float) checked (this.HandleSize * 2), (float) checked (this.HandleSize * 2));
      }
      try
      {
        foreach (TreeNode node in Node.Nodes)
          this.DrawElementRecursive(node, Tree);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void UpdateImage()
    {
      this.CheckDriverPosition();
      if (!(!Information.IsNothing((object) this.TLGeometryEdit.RearEnclosure) & this.GeometryDisplayBox.Width > 0 & this.GeometryDisplayBox.Height > 0))
        return;
      this.GeometryDisplayBox.Image = (Image) new Bitmap(this.GeometryDisplayBox.Width, this.GeometryDisplayBox.Height);
      this.DrawElement();
    }

    private void GeometryDisplayClass_GotFocus(object sender, EventArgs e) => this.UpdateImage();

    private void GeometryDisplayBox_LostFocus(object sender, EventArgs e) => this.UpdateImage();

    public Cursor getLengthCursor(TreeNode n)
    {
      double num = 45.0;
      object tag = n.Tag;
      TLElement tlElement = default;
      double angle = (tag != null ? (TLElement) tag : tlElement).Angle;
      Cursor sizeWe = Cursors.SizeWE;
      Cursor sizeNwse = Cursors.SizeNWSE;
      Cursor sizeNs = Cursors.SizeNS;
      Cursor sizeNesw = Cursors.SizeNESW;
      if (angle > 0.5 * num & angle <= 1.5 * num)
        return sizeNwse;
      if (angle > 1.5 * num & angle <= 2.5 * num)
        return sizeNs;
      if (angle > 2.5 * num & angle <= 3.5 * num)
        return sizeNesw;
      if (angle > 3.5 * num & angle <= 4.5 * num)
        return sizeWe;
      if (angle > 4.5 * num & angle <= 5.5 * num)
        return sizeNwse;
      if (angle > 5.5 * num & angle <= 6.5 * num)
        return sizeNs;
      return angle > 6.5 * num & angle <= 7.5 * num ? sizeNesw : sizeWe;
    }

    public Cursor getAreaCursor(TreeNode n)
    {
      double num = 45.0;
      object tag = n.Tag;
      TLElement tlElement = default;
      double angle = (tag != null ? (TLElement) tag : tlElement).Angle;
      Cursor sizeNs = Cursors.SizeNS;
      Cursor sizeNesw = Cursors.SizeNESW;
      Cursor sizeWe = Cursors.SizeWE;
      Cursor sizeNwse = Cursors.SizeNWSE;
      if (angle > 0.5 * num & angle <= 1.5 * num)
        return sizeNesw;
      if (angle > 1.5 * num & angle <= 2.5 * num)
        return sizeWe;
      if (angle > 2.5 * num & angle <= 3.5 * num)
        return sizeNwse;
      if (angle > 3.5 * num & angle <= 4.5 * num)
        return sizeNs;
      if (angle > 4.5 * num & angle <= 5.5 * num)
        return sizeNesw;
      if (angle > 5.5 * num & angle <= 6.5 * num)
        return sizeWe;
      return angle > 6.5 * num & angle <= 7.5 * num ? sizeNwse : sizeNs;
    }

    public Cursor getSplitCursor(TreeNode n)
    {
      double num = 90.0;
      object tag = n.Tag;
      TLElement tlElement = default;
      double angle = (tag != null ? (TLElement) tag : tlElement).Angle;
      Cursor vsplit = Cursors.VSplit;
      Cursor hsplit = Cursors.HSplit;
      return angle > 0.5 * num & angle <= 1.5 * num || !(angle > 1.5 * num & angle <= 2.5 * num) && angle > 2.5 * num & angle <= 3.5 * num ? hsplit : vsplit;
    }

    private void GeometryDisplayBox_MouseDown(object sender, MouseEventArgs e)
    {
      this.GeometryDisplayBox.Focus();
      this.MouseButtonPressed = MouseButtons.None;
      this.MouseHasMoved = false;
      this.HandleInfo.Bool = false;
      this.CheckHandleLocation((PointF) e.Location);
      TLElement tlElement = default;
      if (this.HandleInfo.Bool)
      {
        switch (this.HandleInfo.HandleType)
        {
          case GeometryDisplayClass.HandleType.StartArea:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            object tag1 = this.SelectedNode.Tag;
            this.OriginalElement = tag1 != null ? (TLElement) tag1 : tlElement;
            if (!Information.IsNothing((object) this.SelectedNode.PrevNode))
            {
              object tag2 = this.SelectedNode.PrevNode.Tag;
              this.OriginalPrevElement = tag2 != null ? (TLElement) tag2 : tlElement;
            }
            if (this.SelectedNode.Level > 1)
            {
              object tag3 = this.SelectedNode.Parent.Tag;
              this.OriginalParentElement = tag3 != null ? (TLElement) tag3 : tlElement;
            }
            if (this.SelectedNode.Nodes.Count > 0)
            {
              object tag4 = this.SelectedNode.Nodes[0].Tag;
              this.OriginalChildElement = tag4 != null ? (TLElement) tag4 : tlElement;
            }
            this.MouseStartLocation = e.Location;
            this.GeometryDisplayBox.Cursor = this.getAreaCursor(this.SelectedNode);
            break;
          case GeometryDisplayClass.HandleType.EndArea:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            object tag5 = this.SelectedNode.Tag;
            this.OriginalElement = tag5 != null ? (TLElement) tag5 : tlElement;
            if (!Information.IsNothing((object) this.SelectedNode.NextNode))
            {
              object tag6 = this.SelectedNode.NextNode.Tag;
              this.OriginalNextElement = tag6 != null ? (TLElement) tag6 : tlElement;
            }
            this.MouseStartLocation = e.Location;
            this.GeometryDisplayBox.Cursor = this.getAreaCursor(this.SelectedNode);
            break;
          case GeometryDisplayClass.HandleType.Rotate:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            object tag7 = this.SelectedNode.Tag;
            this.OriginalElement = tag7 != null ? (TLElement) tag7 : tlElement;
            this.MouseStartLocation = e.Location;
            this.GeometryDisplayBox.Cursor = Cursors.Hand;
            break;
          case GeometryDisplayClass.HandleType.Length:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            object tag8 = this.SelectedNode.Tag;
            this.OriginalElement = tag8 != null ? (TLElement) tag8 : tlElement;
            this.MouseStartLocation = e.Location;
            this.GeometryDisplayBox.Cursor = this.getLengthCursor(this.SelectedNode);
            break;
          case GeometryDisplayClass.HandleType.SplitRight:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            object tag9 = this.SelectedNode.Tag;
            this.OriginalElement = tag9 != null ? (TLElement) tag9 : tlElement;
            object tag10 = this.SelectedNode.NextNode.Tag;
            this.OriginalNextElement = tag10 != null ? (TLElement) tag10 : tlElement;
            this.MouseStartLocation = e.Location;
            this.GeometryDisplayBox.Cursor = this.getSplitCursor(this.SelectedNode);
            break;
          case GeometryDisplayClass.HandleType.SplitLeft:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            object tag11 = this.SelectedNode.Tag;
            this.OriginalElement = tag11 != null ? (TLElement) tag11 : tlElement;
            object tag12 = this.SelectedNode.PrevNode.Tag;
            this.OriginalPrevElement = tag12 != null ? (TLElement) tag12 : tlElement;
            this.MouseStartLocation = e.Location;
            this.GeometryDisplayBox.Cursor = this.getSplitCursor(this.SelectedNode);
            break;
          case GeometryDisplayClass.HandleType.Driver:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            this.MouseStartLocation = e.Location;
            double num1 = 0.0;
            try
            {
              foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
              {
                int num2 = this.DriverSetupEdit.DriverPosition >= num1 ? 1 : 0;
                double driverPosition = this.DriverSetupEdit.DriverPosition;
                double num3 = num1;
                object tag13 = node.Tag;
                double length1 = (tag13 != null ? (TLElement) tag13 : tlElement).Length;
                double num4 = num3 + length1;
                int num5 = driverPosition <= num4 ? 1 : 0;
                if ((num2 & num5) != 0)
                  this.GeometryDisplayBox.Cursor = this.getLengthCursor(node);
                double num6 = num1;
                object tag14 = node.Tag;
                double length2 = (tag14 != null ? (TLElement) tag14 : tlElement).Length;
                num1 = num6 + length2;
              }
              break;
            }
            finally
            {
              IEnumerator enumerator = null;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          case GeometryDisplayClass.HandleType.Tap:
            if (e.Button != MouseButtons.Left)
              break;
            this.HandleInfo.BoolClick = true;
            this.MouseStartLocation = e.Location;
            double num7 = 0.0;
            try
            {
              foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
              {
                int num8 = this.DriverSetupEdit.TapPosition >= num7 ? 1 : 0;
                double tapPosition = this.DriverSetupEdit.TapPosition;
                double num9 = num7;
                object tag15 = node.Tag;
                double length3 = (tag15 != null ? (TLElement) tag15 : tlElement).Length;
                double num10 = num9 + length3;
                int num11 = tapPosition <= num10 ? 1 : 0;
                if ((num8 & num11) != 0)
                  this.GeometryDisplayBox.Cursor = this.getLengthCursor(node);
                double num12 = num7;
                object tag16 = node.Tag;
                double length4 = (tag16 != null ? (TLElement) tag16 : tlElement).Length;
                num7 = num12 + length4;
              }
              break;
            }
            finally
            {
              IEnumerator enumerator = null;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          default:
            this.GeometryDisplayBox.Cursor = Cursors.Arrow;
            this.MouseButtonPressed = e.Button;
            this.MouseStartLocation = e.Location;
            break;
        }
      }
      else
      {
        this.GeometryDisplayBox.Cursor = Cursors.Arrow;
        this.MouseButtonPressed = e.Button;
        this.MouseStartLocation = e.Location;
      }
    }

    private void menuChoiceSelectElement(object sender, EventArgs e)
    {
      this.SelectedNode = (TreeNode) ((ToolStripItem) sender).Tag;
      this.UpdateElementForm();
      this.UpdateImage();
    }

    private void menuChoiceSelectElementRightClick(object sender, EventArgs e)
    {
      this.SelectedNode = (TreeNode) ((ToolStripItem) sender).Tag;
      this.UpdateElementForm();
      this.UpdateImage();
      this.CreateRightClickMenu(this.RightClickMenuLocation);
    }

    private void menuChoiceSelectElementHover(object sender, EventArgs e)
    {
      this.SelectedNode = (TreeNode) ((ToolStripItem) sender).Tag;
      this.UpdateElementForm();
      this.UpdateImage();
    }

    private void CreateRightClickMenu(Point MouseLocation)
    {
      ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
      if (Information.IsNothing((object) this.SelectedNode))
      {
        ToolStripItem toolStripItem1 = contextMenuStrip.Items.Add("Add Rear Element");
        toolStripItem1.Tag = (object) 1;
        toolStripItem1.Click += new EventHandler(this.menuChoice);
        ToolStripItem toolStripItem2 = contextMenuStrip.Items.Add("Add Front Element");
        toolStripItem2.Tag = (object) 19;
        toolStripItem2.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) new ToolStripSeparator());
        ToolStripItem toolStripItem3 = contextMenuStrip.Items.Add("Reset View");
        toolStripItem3.Tag = (object) 24;
        toolStripItem3.Click += new EventHandler(this.menuChoice);
      }
      else
      {
        ToolStripItem toolStripItem4 = contextMenuStrip.Items.Add("Insert Element");
        toolStripItem4.Tag = (object) 16;
        toolStripItem4.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem("Copy Element");
        toolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+C";
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem1);
        toolStripMenuItem1.Tag = (object) 17;
        toolStripMenuItem1.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Paste Element");
        ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("Paste After Selection");
        toolStripMenuItem3.ShortcutKeyDisplayString = "Ctrl+V";
        toolStripMenuItem2.DropDownItems.Add((ToolStripItem) toolStripMenuItem3);
        toolStripMenuItem3.Tag = (object) 18;
        if (Information.IsNothing((object) this.CopyNode))
          toolStripMenuItem3.Enabled = false;
        toolStripMenuItem3.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem("Paste Before Selection");
        toolStripMenuItem2.DropDownItems.Add((ToolStripItem) toolStripMenuItem4);
        toolStripMenuItem4.Tag = (object) 21;
        if (Information.IsNothing((object) this.CopyNode))
          toolStripMenuItem4.Enabled = false;
        toolStripMenuItem4.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem("Paste As Branch");
        toolStripMenuItem2.DropDownItems.Add((ToolStripItem) toolStripMenuItem5);
        toolStripMenuItem5.Tag = (object) 22;
        if (Information.IsNothing((object) this.CopyNode) | this.SelectedNode.Nodes.Count > 0)
          toolStripMenuItem5.Enabled = false;
        toolStripMenuItem5.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem2);
        ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem("Delete Element");
        toolStripMenuItem6.ShortcutKeyDisplayString = "Del";
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem6);
        toolStripMenuItem6.Tag = (object) 2;
        toolStripMenuItem6.Click += new EventHandler(this.menuChoice);
        ToolStripItem toolStripItem5 = contextMenuStrip.Items.Add("Add Branch");
        toolStripItem5.Tag = (object) 3;
        toolStripItem5.Click += new EventHandler(this.menuChoice);
        if (this.SelectedNode.Nodes.Count > 0)
          toolStripItem5.Enabled = false;
        contextMenuStrip.Items.Add((ToolStripItem) new ToolStripSeparator());
        ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem("Reverse Element");
        toolStripMenuItem7.ShortcutKeyDisplayString = "R";
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem7);
        toolStripMenuItem7.Tag = (object) 20;
        toolStripMenuItem7.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) new ToolStripSeparator());
        ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem("Taper");
        ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem("Parabolic");
        toolStripMenuItem8.DropDownItems.Add((ToolStripItem) toolStripMenuItem9);
        toolStripMenuItem9.Tag = (object) 4;
        object tag1 = this.SelectedNode.Tag;
        TLElement tlElement1 = default;
        TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
        if (tlElement2.Taper == 1)
          toolStripMenuItem9.Checked = true;
        toolStripMenuItem9.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem("Exponential");
        toolStripMenuItem8.DropDownItems.Add((ToolStripItem) toolStripMenuItem10);
        toolStripMenuItem10.Tag = (object) 5;
        object tag2 = this.SelectedNode.Tag;
        tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
        if (tlElement2.Taper == 2)
          toolStripMenuItem10.Checked = true;
        toolStripMenuItem10.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem11 = new ToolStripMenuItem("Conical");
        toolStripMenuItem8.DropDownItems.Add((ToolStripItem) toolStripMenuItem11);
        toolStripMenuItem11.Tag = (object) 6;
        object tag3 = this.SelectedNode.Tag;
        tlElement2 = tag3 != null ? (TLElement) tag3 : tlElement1;
        if (tlElement2.Taper == 3)
          toolStripMenuItem11.Checked = true;
        toolStripMenuItem11.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem8);
        contextMenuStrip.Items.Add((ToolStripItem) new ToolStripSeparator());
        ToolStripMenuItem toolStripMenuItem12 = new ToolStripMenuItem("Split Element");
        toolStripMenuItem12.ShortcutKeyDisplayString = "S";
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem12);
        toolStripMenuItem12.Tag = (object) 7;
        toolStripMenuItem12.Click += new EventHandler(this.menuChoice);
        ToolStripItem toolStripItem6 = contextMenuStrip.Items.Add("Join Element");
        toolStripItem6.Tag = (object) 8;
        toolStripItem6.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) new ToolStripSeparator());
        ToolStripMenuItem toolStripMenuItem13 = new ToolStripMenuItem("Boundary");
        ToolStripMenuItem toolStripMenuItem14 = new ToolStripMenuItem("Open");
        toolStripMenuItem14.ShortcutKeyDisplayString = "O";
        toolStripMenuItem13.DropDownItems.Add((ToolStripItem) toolStripMenuItem14);
        toolStripMenuItem14.Tag = (object) 9;
        object tag4 = this.SelectedNode.Tag;
        tlElement2 = tag4 != null ? (TLElement) tag4 : tlElement1;
        if (tlElement2.OpenEnd)
          toolStripMenuItem14.Checked = true;
        toolStripMenuItem14.Click += new EventHandler(this.menuChoice);
        ToolStripMenuItem toolStripMenuItem15 = new ToolStripMenuItem("Closed");
        toolStripMenuItem15.ShortcutKeyDisplayString = "C";
        toolStripMenuItem13.DropDownItems.Add((ToolStripItem) toolStripMenuItem15);
        toolStripMenuItem15.Tag = (object) 10;
        object tag5 = this.SelectedNode.Tag;
        tlElement2 = tag5 != null ? (TLElement) tag5 : tlElement1;
        if (!tlElement2.OpenEnd)
          toolStripMenuItem15.Checked = true;
        toolStripMenuItem15.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem13);
        if (this.SelectedNode.Index < checked (this.SelectedNode.Parent.Nodes.Count - 1))
          toolStripMenuItem13.Enabled = false;
        ToolStripMenuItem toolStripMenuItem16 = new ToolStripMenuItem("Stuffing");
        ToolStripMenuItem toolStripMenuItem17 = new ToolStripMenuItem("None");
        toolStripMenuItem16.DropDownItems.Add((ToolStripItem) toolStripMenuItem17);
        toolStripMenuItem17.Tag = (object) 11;
        toolStripMenuItem17.Click += new EventHandler(this.menuChoice);
        object tag6 = this.SelectedNode.Tag;
        tlElement2 = tag6 != null ? (TLElement) tag6 : tlElement1;
        if (tlElement2.StuffingDensity == 0.0)
          toolStripMenuItem17.Checked = true;
        ToolStripMenuItem toolStripMenuItem18 = new ToolStripMenuItem("Light");
        toolStripMenuItem16.DropDownItems.Add((ToolStripItem) toolStripMenuItem18);
        toolStripMenuItem18.Tag = (object) 12;
        toolStripMenuItem18.Click += new EventHandler(this.menuChoice);
        object tag7 = this.SelectedNode.Tag;
        tlElement2 = tag7 != null ? (TLElement) tag7 : tlElement1;
        if (tlElement2.StuffingDensity == this.LightStuffing)
          toolStripMenuItem18.Checked = true;
        ToolStripMenuItem toolStripMenuItem19 = new ToolStripMenuItem("Medium");
        toolStripMenuItem16.DropDownItems.Add((ToolStripItem) toolStripMenuItem19);
        toolStripMenuItem19.Tag = (object) 13;
        toolStripMenuItem19.Click += new EventHandler(this.menuChoice);
        object tag8 = this.SelectedNode.Tag;
        tlElement2 = tag8 != null ? (TLElement) tag8 : tlElement1;
        if (tlElement2.StuffingDensity == this.MediumStuffing)
          toolStripMenuItem19.Checked = true;
        ToolStripMenuItem toolStripMenuItem20 = new ToolStripMenuItem("Heavy");
        toolStripMenuItem16.DropDownItems.Add((ToolStripItem) toolStripMenuItem20);
        toolStripMenuItem20.Tag = (object) 14;
        toolStripMenuItem20.Click += new EventHandler(this.menuChoice);
        object tag9 = this.SelectedNode.Tag;
        tlElement2 = tag9 != null ? (TLElement) tag9 : tlElement1;
        if (tlElement2.StuffingDensity == this.HeavyStuffing)
          toolStripMenuItem20.Checked = true;
        ToolStripMenuItem toolStripMenuItem21 = new ToolStripMenuItem("Custom");
        toolStripMenuItem16.DropDownItems.Add((ToolStripItem) toolStripMenuItem21);
        toolStripMenuItem21.Tag = (object) 15;
        toolStripMenuItem21.Click += new EventHandler(this.menuChoice);
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem16);
        contextMenuStrip.Items.Add((ToolStripItem) new ToolStripSeparator());
        ToolStripItem toolStripItem7 = contextMenuStrip.Items.Add("Reset View");
        toolStripItem7.Tag = (object) 24;
        toolStripItem7.Click += new EventHandler(this.menuChoice);
      }
      contextMenuStrip.Show((Control) this.GeometryDisplayBox, MouseLocation);
    }

    private void SelectNodeRoutine(Point MouseLocation, int Action)
    {
      if (this.SelectCount <= 1)
      {
        this.UpdateElementForm();
        this.UpdateImage();
        if (Action != 2)
          return;
        this.CreateRightClickMenu(MouseLocation);
      }
      else
      {
        if (this.SelectCount <= 1)
          return;
        this.SelectedNode = (TreeNode) null;
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        int selectCount = this.SelectCount;
        int index = 1;
        while (index <= selectCount)
        {
          ToolStripItem toolStripItem = contextMenuStrip.Items.Add("Select " + Functions.GetTreeString(this.SelectedNodeArray[index]));
          toolStripItem.Tag = (object) this.SelectedNodeArray[index];
          switch (Action)
          {
            case 1:
              toolStripItem.Click += new EventHandler(this.menuChoiceSelectElement);
              break;
            case 2:
              toolStripItem.Click += new EventHandler(this.menuChoiceSelectElementRightClick);
              break;
          }
          toolStripItem.MouseEnter += new EventHandler(this.menuChoiceSelectElementHover);
          checked { ++index; }
        }
        contextMenuStrip.Show((Control) this.GeometryDisplayBox, MouseLocation);
        this.RightClickMenuLocation = MouseLocation;
      }
    }

    private void GeometryDisplayBox_MouseUp(object sender, MouseEventArgs e)
    {
      this.GeometryDisplayBox.Cursor = Cursors.Arrow;
      if (this.HandleInfo.BoolClick)
      {
        this.HandleInfo.BoolClick = false;
        this.SendValues();
        this.ToolStripStatusLabel1.Text = "";
      }
      if (e.Button == this.MouseButtonPressed & this.MouseButtonPressed == this.SelectMouseButton)
      {
        if (!this.MouseHasMoved)
        {
          this.SelectNode((PointF) e.Location);
          this.SelectNodeRoutine(e.Location, 1);
        }
        else
        {
          this.MouseCurrentLocation = e.Location;
          this.RectangleSelectNode();
          this.SelectNodeRoutine(e.Location, 1);
        }
      }
      if (e.Button == this.MouseButtonPressed & this.MouseButtonPressed == this.OptionMouseButton && !this.MouseHasMoved)
      {
        if (Information.IsNothing((object) this.SelectedNode))
        {
          this.SelectNode((PointF) e.Location);
          this.SelectNodeRoutine(e.Location, 2);
        }
        else if (this.CheckClickInElement(this.SelectedNode, (PointF) e.Location))
        {
          this.CreateRightClickMenu(e.Location);
        }
        else
        {
          this.SelectNode((PointF) e.Location);
          this.SelectNodeRoutine(e.Location, 2);
        }
      }
      this.MouseButtonPressed = MouseButtons.None;
      this.MouseHasMoved = false;
      this.UpdateImage();
    }

    private void menuChoice(object sender, EventArgs e)
    {
      int integer = Conversions.ToInteger(((ToolStripItem) sender).Tag);
      if (integer == 1)
        this.NewRearElement();
      if (integer == 19)
        this.NewFrontElement();
      if (integer == 2)
        this.DeleteElement();
      if (integer == 3)
        this.NewBranch();
      TLElement tlElement1 = default;
      if (integer > 3 & integer < 7 && !Information.IsNothing((object) this.SelectedNode))
      {
        object tag = this.SelectedNode.Tag;
        this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement1) with
        {
          Taper = checked (integer - 3)
        });
        this.UpdateImage();
        this.SendValues();
      }
      if (integer == 7)
        this.SplitElement();
      if (integer == 8)
      {
        if (!Information.IsNothing((object) this.SelectedNode))
        {
          if (!Information.IsNothing((object) this.SelectedNode.NextNode))
          {
            object tag1 = this.SelectedNode.Tag;
            TLElement Element1_1 = tag1 != null ? (TLElement) tag1 : tlElement1;
            object tag2 = this.SelectedNode.NextNode.Tag;
            TLElement Element2_1 = tag2 != null ? (TLElement) tag2 : tlElement1;
            if (Functions.ElementMergeBoolSibling(Element1_1, Element2_1) & this.SelectedNode.NextNode.Nodes.Count == 0)
            {
              TreeNode selectedNode = this.SelectedNode;
              object tag3 = this.SelectedNode.Tag;
              TLElement Element1_2 = tag3 != null ? (TLElement) tag3 : tlElement1;
              object tag4 = this.SelectedNode.NextNode.Tag;
              TLElement Element2_2 = tag4 != null ? (TLElement) tag4 : tlElement1;
              // ISSUE: variable of a boxed type
              var local = (ValueType) Functions.ElementMergeSibling(Element1_2, Element2_2);
              selectedNode.Tag = (object) local;
              this.SelectedNode.NextNode.Parent.Nodes.RemoveAt(this.SelectedNode.NextNode.Index);
            }
          }
          if (!Information.IsNothing((object) this.SelectedNode.PrevNode))
          {
            object tag5 = this.SelectedNode.PrevNode.Tag;
            TLElement Element1_3 = tag5 != null ? (TLElement) tag5 : tlElement1;
            object tag6 = this.SelectedNode.Tag;
            TLElement Element2_3 = tag6 != null ? (TLElement) tag6 : tlElement1;
            if (Functions.ElementMergeBoolSibling(Element1_3, Element2_3) & this.SelectedNode.Nodes.Count == 0)
            {
              TreeNode prevNode = this.SelectedNode.PrevNode;
              object tag7 = this.SelectedNode.PrevNode.Tag;
              TLElement Element1_4 = tag7 != null ? (TLElement) tag7 : tlElement1;
              object tag8 = this.SelectedNode.Tag;
              TLElement Element2_4 = tag8 != null ? (TLElement) tag8 : tlElement1;
              // ISSUE: variable of a boxed type
              var local = (ValueType) Functions.ElementMergeSibling(Element1_4, Element2_4);
              prevNode.Tag = (object) local;
              this.SelectedNode.Parent.Nodes.RemoveAt(this.SelectedNode.Index);
              this.SelectedNode = (TreeNode) null;
            }
          }
        }
        this.UpdateImage();
        this.SendValues();
      }
      if (integer == 9)
        this.OpenBoundaryElement();
      if (integer == 10)
        this.ClosedBoundaryElement();
      if (integer == 11)
      {
        object tag = this.SelectedNode.Tag;
        this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement1) with
        {
          StuffingDensity = 0.0
        });
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
      if (integer == 12)
      {
        object tag = this.SelectedNode.Tag;
        this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement1) with
        {
          StuffingDensity = this.LightStuffing
        });
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
      if (integer == 13)
      {
        object tag = this.SelectedNode.Tag;
        this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement1) with
        {
          StuffingDensity = this.MediumStuffing
        });
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
      if (integer == 14)
      {
        object tag = this.SelectedNode.Tag;
        this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement1) with
        {
          StuffingDensity = this.HeavyStuffing
        });
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
      if (integer == 15)
      {
        object tag = this.SelectedNode.Tag;
        TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
        string Left = "";
        while (!Functions.ErrorCheckNum(Left, 0.0, 100.0))
        {
          Left = Interaction.InputBox("Define stuffing density " + Functions.UnitStringDensity(this.SettingsEdit.DensityUnit), "Stuffing Density", Functions.ConvertDensity(1, this.SettingsEdit.DensityUnit, tlElement2.StuffingDensity).ToString());
          if (Operators.CompareString(Left, "", false) == 0)
            return;
        }
        tlElement2.StuffingDensity = Functions.ConvertDensity(this.SettingsEdit.DensityUnit, 1, Conversions.ToDouble(Left));
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
      if (integer == 16)
      {
        TreeNode n = this.SelectedNode.Parent.Nodes.Insert(checked (this.SelectedNode.Index + 1), "New Node");
        TLElement tlElement3 = default;
        ref TLElement local1 = ref tlElement3;
        object tag9 = n.PrevNode.Tag;
        double endArea = (tag9 != null ? (TLElement) tag9 : tlElement1).EndArea;
        local1.StartArea = endArea;
        tlElement3.EndArea = tlElement3.StartArea;
        ref TLElement local2 = ref tlElement3;
        object tag10 = n.PrevNode.Tag;
        double length = (tag10 != null ? (TLElement) tag10 : tlElement1).Length;
        local2.Length = length;
        ref TLElement local3 = ref tlElement3;
        object tag11 = n.PrevNode.Tag;
        int num = (tag11 != null ? (TLElement) tag11 : tlElement1).OpenEnd ? 1 : 0;
        local3.OpenEnd = num != 0;
        ref TLElement local4 = ref tlElement3;
        object tag12 = n.PrevNode.Tag;
        int taper = (tag12 != null ? (TLElement) tag12 : tlElement1).Taper;
        local4.Taper = taper;
        ref TLElement local5 = ref tlElement3;
        object tag13 = n.PrevNode.Tag;
        double stuffingDensity = (tag13 != null ? (TLElement) tag13 : tlElement1).StuffingDensity;
        local5.StuffingDensity = stuffingDensity;
        tlElement3.Angle = n.Level % 2 != 0 ? 0.0 : 90.0;
        n.Tag = (object) tlElement3;
        n.Text = Functions.GetTreeString(n);
        this.SelectedNode = n;
        this.UpdateImage();
        this.SendValues();
      }
      if (integer == 17)
        this.CopyNodeSub();
      if (integer == 18)
        this.PasteAfter();
      if (integer == 21)
        this.PasteBefore();
      if (integer == 22 && !Information.IsNothing((object) this.SelectedNode) & !Information.IsNothing((object) this.CopyNode) & this.SelectedNode.Nodes.Count == 0)
      {
        TreeNode treeNode = this.SelectedNode.Nodes.Add("-");
        treeNode.Tag = RuntimeHelpers.GetObjectValue(this.CopyNode.Tag);
        this.SelectedNode = treeNode;
        this.UpdateImage();
        this.SendValues();
      }
      if (integer == 20)
        this.ReverseElement();
      if (integer == 24)
        this.ResetView();
    }

    private void RectangleSelectNode()
    {
      this.SelectCount = 0;
      this.SelectedNode = (TreeNode) null;
      this.SelectedNodeArray = new TreeNode[1];
      this.ScaleDivide = 1000f / this.SettingsEdit.GeometryScale;
      if (this.SettingsEdit.ShowRear)
      {
        try
        {
          foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
            this.RectangleSelectNodeRecursive(node, this.TLGeometryEdit.RearEnclosure);
        }
        finally
        {
          IEnumerator enumerator = null;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (!(this.SettingsEdit.ShowFront & !this.DriverSetupEdit.Tapped))
        return;
      try
      {
        foreach (TreeNode node in this.TLGeometryEdit.FrontEnclosure.Nodes)
          this.RectangleSelectNodeRecursive(node, this.TLGeometryEdit.FrontEnclosure);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void RectangleSelectNodeRecursive(TreeNode Node, TreeNode Tree)
    {
      PointF[] pointFArray = new PointF[4];
      PointF[] Polygon = new PointF[4];
      float num1 = (float) checked (this.MouseCurrentLocation.X - this.MouseStartLocation.X);
      float num2 = (float) checked (this.MouseCurrentLocation.Y - this.MouseStartLocation.Y);
      Point point = default;
      if ((double) num2 < 0.0)
      {
        point.Y = this.MouseCurrentLocation.Y;
        num2 = -1f * num2;
      }
      else
        point.Y = this.MouseStartLocation.Y;
      if ((double) num1 < 0.0)
      {
        point.X = this.MouseCurrentLocation.X;
        num1 = -1f * num1;
      }
      else
        point.X = this.MouseStartLocation.X;
      Polygon[0] = (PointF) point;
      Polygon[1].X = (float) point.X + num1;
      Polygon[1].Y = (float) point.Y;
      Polygon[2].X = (float) point.X + num1;
      Polygon[2].Y = (float) point.Y + num2;
      Polygon[3].X = (float) point.X;
      Polygon[3].Y = (float) point.Y + num2;
      PointF pointF = default;
      pointF.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      PointF position = Functions.NewGetPosition(Node, this.TLGeometryEdit);
      object tag1 = Node.Tag;
      TLElement tlElement = default;
      double angle = (tag1 != null ? (TLElement) tag1 : tlElement).Angle;
      ref PointF local1 = ref pointFArray[0];
      double scaleDivide1 = (double) this.ScaleDivide;
      double x1 = (double) pointF.X;
      double x2 = (double) position.X;
      object tag2 = Node.Tag;
      double num3 = 0.5 * ((tag2 != null ? (TLElement) tag2 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num4 = x2 - num3;
      double num5 = x1 + num4;
      double num6 = scaleDivide1 * num5;
      local1.X = (float) num6;
      ref PointF local2 = ref pointFArray[0];
      double scaleDivide2 = (double) this.ScaleDivide;
      double y1 = (double) pointF.Y;
      double y2 = (double) position.Y;
      object tag3 = Node.Tag;
      double num7 = 0.5 * ((tag3 != null ? (TLElement) tag3 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num8 = y2 + num7;
      double num9 = y1 + num8;
      double num10 = scaleDivide2 * num9;
      local2.Y = (float) num10;
      ref PointF local3 = ref pointFArray[1];
      double scaleDivide3 = (double) this.ScaleDivide;
      double x3 = (double) pointF.X;
      double x4 = (double) position.X;
      object tag4 = Node.Tag;
      double num11 = 0.5 * ((tag4 != null ? (TLElement) tag4 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num12 = x4 + num11;
      double num13 = x3 + num12;
      double num14 = scaleDivide3 * num13;
      local3.X = (float) num14;
      ref PointF local4 = ref pointFArray[1];
      double scaleDivide4 = (double) this.ScaleDivide;
      double y3 = (double) pointF.Y;
      double y4 = (double) position.Y;
      object tag5 = Node.Tag;
      double num15 = 0.5 * ((tag5 != null ? (TLElement) tag5 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num16 = y4 - num15;
      double num17 = y3 + num16;
      double num18 = scaleDivide4 * num17;
      local4.Y = (float) num18;
      ref PointF local5 = ref pointFArray[2];
      double scaleDivide5 = (double) this.ScaleDivide;
      double x5 = (double) pointF.X;
      double x6 = (double) position.X;
      object tag6 = Node.Tag;
      double num19 = (tag6 != null ? (TLElement) tag6 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
      double num20 = x6 + num19;
      object tag7 = Node.Tag;
      double num21 = 0.5 * ((tag7 != null ? (TLElement) tag7 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num22 = num20 + num21;
      double num23 = x5 + num22;
      double num24 = scaleDivide5 * num23;
      local5.X = (float) num24;
      ref PointF local6 = ref pointFArray[2];
      double scaleDivide6 = (double) this.ScaleDivide;
      double y5 = (double) pointF.Y;
      double y6 = (double) position.Y;
      object tag8 = Node.Tag;
      double num25 = (tag8 != null ? (TLElement) tag8 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
      double num26 = y6 + num25;
      object tag9 = Node.Tag;
      double num27 = 0.5 * ((tag9 != null ? (TLElement) tag9 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num28 = num26 - num27;
      double num29 = y5 + num28;
      double num30 = scaleDivide6 * num29;
      local6.Y = (float) num30;
      ref PointF local7 = ref pointFArray[3];
      double scaleDivide7 = (double) this.ScaleDivide;
      double x7 = (double) pointF.X;
      double x8 = (double) position.X;
      object tag10 = Node.Tag;
      double num31 = (tag10 != null ? (TLElement) tag10 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
      double num32 = x8 + num31;
      object tag11 = Node.Tag;
      double num33 = 0.5 * ((tag11 != null ? (TLElement) tag11 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num34 = num32 - num33;
      double num35 = x7 + num34;
      double num36 = scaleDivide7 * num35;
      local7.X = (float) num36;
      ref PointF local8 = ref pointFArray[3];
      double scaleDivide8 = (double) this.ScaleDivide;
      double y7 = (double) pointF.Y;
      double y8 = (double) position.Y;
      object tag12 = Node.Tag;
      double num37 = (tag12 != null ? (TLElement) tag12 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
      double num38 = y8 + num37;
      object tag13 = Node.Tag;
      double num39 = 0.5 * ((tag13 != null ? (TLElement) tag13 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num40 = num38 + num39;
      double num41 = y7 + num40;
      double num42 = scaleDivide8 * num41;
      local8.Y = (float) num42;
      if (VectorFunctions.PointInPolygonNew2D(Polygon, pointFArray[0]) & VectorFunctions.PointInPolygonNew2D(Polygon, pointFArray[1]) & VectorFunctions.PointInPolygonNew2D(Polygon, pointFArray[2]) & VectorFunctions.PointInPolygonNew2D(Polygon, pointFArray[3]))
      {
        checked { ++this.SelectCount; }
        this.SelectedNodeArray = (TreeNode[]) Utils.CopyArray((Array) this.SelectedNodeArray, (Array) new TreeNode[checked (this.SelectCount + 1)]);
        this.SelectedNodeArray[this.SelectCount] = Node;
        this.SelectedNode = Node;
      }
      try
      {
        foreach (TreeNode node in Node.Nodes)
          this.RectangleSelectNodeRecursive(node, Tree);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void SelectNode(PointF Mouse)
    {
      this.SelectCount = 0;
      this.SelectedNode = (TreeNode) null;
      this.SelectedNodeArray = new TreeNode[1];
      this.ScaleDivide = 1000f / this.SettingsEdit.GeometryScale;
      if (this.SettingsEdit.ShowRear)
      {
        try
        {
          foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
            this.SelectNodeRecursive(node, this.TLGeometryEdit.RearEnclosure, Mouse);
        }
        finally
        {
          IEnumerator enumerator = null;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (!(this.SettingsEdit.ShowFront & !this.DriverSetupEdit.Tapped))
        return;
      try
      {
        foreach (TreeNode node in this.TLGeometryEdit.FrontEnclosure.Nodes)
          this.SelectNodeRecursive(node, this.TLGeometryEdit.FrontEnclosure, Mouse);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void SelectNodeRecursive(TreeNode Node, TreeNode Tree, PointF Mouse)
    {
      if (this.CheckClickInElement(Node, Mouse))
      {
        checked { ++this.SelectCount; }
        this.SelectedNodeArray = (TreeNode[]) Utils.CopyArray((Array) this.SelectedNodeArray, (Array) new TreeNode[checked (this.SelectCount + 1)]);
        this.SelectedNodeArray[this.SelectCount] = Node;
        this.SelectedNode = Node;
      }
      try
      {
        foreach (TreeNode node in Node.Nodes)
          this.SelectNodeRecursive(node, Tree, Mouse);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    public bool CheckClickInElement(TreeNode Node, PointF Mouse)
    {
      PointF[] Polygon = new PointF[4];
      PointF pointF = default;
      pointF.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      if (Operators.CompareString(Strings.Split(Functions.GetTreeString(Node), ".")[0], "Front", false) == 0)
      {
        pointF = this.DriverPosition(1);
        pointF.X /= this.ScaleDivide;
        pointF.Y /= this.ScaleDivide;
      }
      PointF position = Functions.NewGetPosition(Node, this.TLGeometryEdit);
      object tag1 = Node.Tag;
      TLElement tlElement = default;
      double angle = (tag1 != null ? (TLElement) tag1 : tlElement).Angle;
      ref PointF local1 = ref Polygon[0];
      double scaleDivide1 = (double) this.ScaleDivide;
      double x1 = (double) pointF.X;
      double x2 = (double) position.X;
      object tag2 = Node.Tag;
      double num1 = 0.5 * ((tag2 != null ? (TLElement) tag2 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num2 = x2 - num1;
      double num3 = x1 + num2;
      double num4 = scaleDivide1 * num3;
      local1.X = (float) num4;
      ref PointF local2 = ref Polygon[0];
      double scaleDivide2 = (double) this.ScaleDivide;
      double y1 = (double) pointF.Y;
      double y2 = (double) position.Y;
      object tag3 = Node.Tag;
      double num5 = 0.5 * ((tag3 != null ? (TLElement) tag3 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num6 = y2 + num5;
      double num7 = y1 + num6;
      double num8 = scaleDivide2 * num7;
      local2.Y = (float) num8;
      ref PointF local3 = ref Polygon[1];
      double scaleDivide3 = (double) this.ScaleDivide;
      double x3 = (double) pointF.X;
      double x4 = (double) position.X;
      object tag4 = Node.Tag;
      double num9 = 0.5 * ((tag4 != null ? (TLElement) tag4 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num10 = x4 + num9;
      double num11 = x3 + num10;
      double num12 = scaleDivide3 * num11;
      local3.X = (float) num12;
      ref PointF local4 = ref Polygon[1];
      double scaleDivide4 = (double) this.ScaleDivide;
      double y3 = (double) pointF.Y;
      double y4 = (double) position.Y;
      object tag5 = Node.Tag;
      double num13 = 0.5 * ((tag5 != null ? (TLElement) tag5 : tlElement).StartArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num14 = y4 - num13;
      double num15 = y3 + num14;
      double num16 = scaleDivide4 * num15;
      local4.Y = (float) num16;
      ref PointF local5 = ref Polygon[2];
      double scaleDivide5 = (double) this.ScaleDivide;
      double x5 = (double) pointF.X;
      double x6 = (double) position.X;
      object tag6 = Node.Tag;
      double num17 = (tag6 != null ? (TLElement) tag6 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
      double num18 = x6 + num17;
      object tag7 = Node.Tag;
      double num19 = 0.5 * ((tag7 != null ? (TLElement) tag7 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num20 = num18 + num19;
      double num21 = x5 + num20;
      double num22 = scaleDivide5 * num21;
      local5.X = (float) num22;
      ref PointF local6 = ref Polygon[2];
      double scaleDivide6 = (double) this.ScaleDivide;
      double y5 = (double) pointF.Y;
      double y6 = (double) position.Y;
      object tag8 = Node.Tag;
      double num23 = (tag8 != null ? (TLElement) tag8 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
      double num24 = y6 + num23;
      object tag9 = Node.Tag;
      double num25 = 0.5 * ((tag9 != null ? (TLElement) tag9 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num26 = num24 - num25;
      double num27 = y5 + num26;
      double num28 = scaleDivide6 * num27;
      local6.Y = (float) num28;
      ref PointF local7 = ref Polygon[3];
      double scaleDivide7 = (double) this.ScaleDivide;
      double x7 = (double) pointF.X;
      double x8 = (double) position.X;
      object tag10 = Node.Tag;
      double num29 = (tag10 != null ? (TLElement) tag10 : tlElement).Length * Math.Cos(Functions.Deg2Rad(angle));
      double num30 = x8 + num29;
      object tag11 = Node.Tag;
      double num31 = 0.5 * ((tag11 != null ? (TLElement) tag11 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Sin(Functions.Deg2Rad(angle));
      double num32 = num30 - num31;
      double num33 = x7 + num32;
      double num34 = scaleDivide7 * num33;
      local7.X = (float) num34;
      ref PointF local8 = ref Polygon[3];
      double scaleDivide8 = (double) this.ScaleDivide;
      double y7 = (double) pointF.Y;
      double y8 = (double) position.Y;
      object tag12 = Node.Tag;
      double num35 = (tag12 != null ? (TLElement) tag12 : tlElement).Length * Math.Sin(Functions.Deg2Rad(angle));
      double num36 = y8 + num35;
      object tag13 = Node.Tag;
      double num37 = 0.5 * ((tag13 != null ? (TLElement) tag13 : tlElement).EndArea / this.TLGeometryEdit.Width) * Math.Cos(Functions.Deg2Rad(angle));
      double num38 = num36 + num37;
      double num39 = y7 + num38;
      double num40 = scaleDivide8 * num39;
      local8.Y = (float) num40;
      return VectorFunctions.PointInPolygonNew2D(Polygon, Mouse);
    }

    private void GeometryDisplayBox_MouseMove(object sender, MouseEventArgs e)
    {
      this.MouseHasMoved = true;
      PointF location = (PointF) e.Location;
      PointF pointF1 = default;
      pointF1.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF1.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      PointF position = default;
      if (!Information.IsNothing((object) this.SelectedNode))
      {
        position = Functions.NewGetPosition(this.SelectedNode, this.TLGeometryEdit);
        if (Operators.CompareString(Strings.Split(Functions.GetTreeString(this.SelectedNode), ".")[0], "Front", false) == 0)
        {
          pointF1 = this.DriverPosition(1);
          pointF1.X /= this.ScaleDivide;
          pointF1.Y /= this.ScaleDivide;
        }
      }
      TLElement tlElement1 = default;
      if (this.HandleInfo.BoolClick)
      {
        switch (this.HandleInfo.HandleType)
        {
          case GeometryDisplayClass.HandleType.StartArea:
            this.GeometryDisplayBox.Cursor = this.getAreaCursor(this.SelectedNode);
            double num1 = Math.Sqrt(Math.Pow((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X), 2.0) + Math.Pow((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y), 2.0)) / (double) this.ScaleDivide;
            double num2 = Functions.Rad2Deg(Math.Atan(((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X)) / ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y))));
            if ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y) > 0.0)
              num2 += 180.0;
            else if ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X) > 0.0)
              num2 += 360.0;
            object tag1 = this.SelectedNode.Tag;
            double Deg1 = 360.0 - (tag1 != null ? (TLElement) tag1 : tlElement1).Angle - num2;
            double num3 = Functions.ConvertArea(1, this.SettingsEdit.DisplayAreaUnit, num1 * Math.Cos(Functions.Deg2Rad(Deg1)) * 2.0 * this.TLGeometryEdit.Width);
            double num4 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayAreaPrecision);
            double Area1 = Math.Round(num3 / num4, 0) * num4;
            if (Area1 <= num4)
              Area1 = num4;
            double num5 = Functions.ConvertArea(this.SettingsEdit.DisplayAreaUnit, 1, Area1);
            object tag2 = this.SelectedNode.Tag;
            TLElement tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
            if (num5 != tlElement2.StartArea)
            {
              tlElement2.StartArea = num5;
              tlElement2.EndArea = !MyProject.Computer.Keyboard.ShiftKeyDown ? this.OriginalElement.EndArea : tlElement2.StartArea;
              if (!Information.IsNothing((object) this.SelectedNode.PrevNode))
              {
                object tag3 = this.SelectedNode.PrevNode.Tag;
                TLElement tlElement3 = tag3 != null ? (TLElement) tag3 : tlElement1;
                if (MyProject.Computer.Keyboard.CtrlKeyDown)
                {
                  if (this.OriginalElement.StartArea == this.OriginalPrevElement.EndArea)
                    tlElement3.EndArea = num5;
                }
                else
                  tlElement3.EndArea = this.OriginalPrevElement.EndArea;
                this.SelectedNode.PrevNode.Tag = (object) tlElement3;
              }
              if (this.SelectedNode.Level > 1)
              {
                object tag4 = this.SelectedNode.Parent.Tag;
                TLElement tlElement4 = tag4 != null ? (TLElement) tag4 : tlElement1;
                if (MyProject.Computer.Keyboard.CtrlKeyDown)
                {
                  if (this.OriginalElement.StartArea == this.OriginalParentElement.StartArea)
                    tlElement4.StartArea = num5;
                }
                else
                  tlElement4.StartArea = this.OriginalParentElement.StartArea;
                this.SelectedNode.Parent.Tag = (object) tlElement4;
              }
              if (this.SelectedNode.Nodes.Count > 0)
              {
                object tag5 = this.SelectedNode.Nodes[0].Tag;
                TLElement tlElement5 = tag5 != null ? (TLElement) tag5 : tlElement1;
                if (MyProject.Computer.Keyboard.CtrlKeyDown)
                {
                  if (this.OriginalElement.StartArea == this.OriginalChildElement.StartArea)
                    tlElement5.StartArea = num5;
                }
                else
                  tlElement5.StartArea = this.OriginalChildElement.StartArea;
                this.SelectedNode.Nodes[0].Tag = (object) tlElement5;
              }
              this.SelectedNode.Tag = (object) tlElement2;
              this.ToolStripStatusLabel1.Text = "Area: " + Area1.ToString() + " " + Functions.UnitStringLength(this.SettingsEdit.DisplayAreaUnit) + "\u00B2";
              this.UpdateImage();
              break;
            }
            break;
          case GeometryDisplayClass.HandleType.EndArea:
            this.GeometryDisplayBox.Cursor = this.getAreaCursor(this.SelectedNode);
            PointF pointF2 = default;
            ref PointF local1 = ref pointF2;
            double x = (double) position.X;
            object tag6 = this.SelectedNode.Tag;
            double length1 = (tag6 != null ? (TLElement) tag6 : tlElement1).Length;
            object tag7 = this.SelectedNode.Tag;
            double num6 = Math.Cos(Functions.Deg2Rad((tag7 != null ? (TLElement) tag7 : tlElement1).Angle));
            double num7 = length1 * num6;
            double num8 = x + num7;
            local1.X = (float) num8;
            ref PointF local2 = ref pointF2;
            double y = (double) position.Y;
            object tag8 = this.SelectedNode.Tag;
            double length2 = (tag8 != null ? (TLElement) tag8 : tlElement1).Length;
            object tag9 = this.SelectedNode.Tag;
            double num9 = Math.Sin(Functions.Deg2Rad((tag9 != null ? (TLElement) tag9 : tlElement1).Angle));
            double num10 = length2 * num9;
            double num11 = y + num10;
            local2.Y = (float) num11;
            double num12 = Math.Sqrt(Math.Pow((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) pointF2.X), 2.0) + Math.Pow((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) pointF2.Y), 2.0)) / (double) this.ScaleDivide;
            double num13 = Functions.Rad2Deg(Math.Atan(((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) pointF2.X)) / ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) pointF2.Y))));
            if ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) pointF2.Y) > 0.0)
              num13 += 180.0;
            else if ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) pointF2.X) > 0.0)
              num13 += 360.0;
            double num14 = 360.0 - num13;
            object tag10 = this.SelectedNode.Tag;
            double angle1 = (tag10 != null ? (TLElement) tag10 : tlElement1).Angle;
            double Deg2 = num14 - angle1;
            double num15 = Functions.ConvertArea(1, this.SettingsEdit.DisplayAreaUnit, num12 * Math.Cos(Functions.Deg2Rad(Deg2)) * 2.0 * this.TLGeometryEdit.Width);
            double num16 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayAreaPrecision);
            double Area2 = Math.Round(num15 / num16, 0) * num16;
            if (Area2 <= num16)
              Area2 = num16;
            double num17 = Functions.ConvertArea(this.SettingsEdit.DisplayAreaUnit, 1, Area2);
            object tag11 = this.SelectedNode.Tag;
            TLElement tlElement6 = tag11 != null ? (TLElement) tag11 : tlElement1;
            if (num17 != tlElement6.EndArea)
            {
              tlElement6.EndArea = num17;
              tlElement6.StartArea = !MyProject.Computer.Keyboard.ShiftKeyDown ? this.OriginalElement.StartArea : tlElement6.EndArea;
              if (!Information.IsNothing((object) this.SelectedNode.NextNode))
              {
                object tag12 = this.SelectedNode.NextNode.Tag;
                TLElement tlElement7 = tag12 != null ? (TLElement) tag12 : tlElement1;
                if (MyProject.Computer.Keyboard.CtrlKeyDown)
                {
                  if (this.OriginalElement.EndArea == this.OriginalNextElement.StartArea)
                    tlElement7.StartArea = num17;
                }
                else
                  tlElement7.StartArea = this.OriginalNextElement.StartArea;
                this.SelectedNode.NextNode.Tag = (object) tlElement7;
              }
              this.SelectedNode.Tag = (object) tlElement6;
              this.ToolStripStatusLabel1.Text = "Area: " + Area2.ToString() + " " + Functions.UnitStringLength(this.SettingsEdit.DisplayAreaUnit) + "\u00B2";
              this.UpdateImage();
              break;
            }
            break;
          case GeometryDisplayClass.HandleType.Rotate:
            this.GeometryDisplayBox.Cursor = Cursors.Hand;
            double num18 = Functions.Rad2Deg(Math.Atan(((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y)) / ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X))));
            if ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X) < 0.0)
              num18 += 180.0;
            else if ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y) < 0.0)
              num18 += 360.0;
            object tag13 = this.SelectedNode.Tag;
            TLElement tlElement8 = tag13 != null ? (TLElement) tag13 : tlElement1;
            double num19 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayAnglePrecision);
            double num20 = Math.Round(num18 / num19, 0) * num19;
            if (num20 != tlElement8.Angle)
            {
              tlElement8.Angle = num20;
              this.SelectedNode.Tag = (object) tlElement8;
              this.ToolStripStatusLabel1.Text = "Angle: " + num20.ToString() + " Deg";
              this.UpdateImage();
              break;
            }
            break;
          case GeometryDisplayClass.HandleType.Length:
            this.GeometryDisplayBox.Cursor = this.getLengthCursor(this.SelectedNode);
            double num21 = Functions.Rad2Deg(Math.Atan(((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y)) / ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X))));
            if ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X) < 0.0)
              num21 += 180.0;
            else if ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y) < 0.0)
              num21 += 360.0;
            double num22 = Math.Sqrt(Math.Pow((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X), 2.0) + Math.Pow((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y), 2.0)) / (double) this.ScaleDivide;
            double num23 = num21;
            object tag14 = this.SelectedNode.Tag;
            double angle2 = (tag14 != null ? (TLElement) tag14 : tlElement1).Angle;
            double Deg3 = num23 - angle2;
            double num24 = Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, num22 * Math.Cos(Functions.Deg2Rad(Deg3)));
            double num25 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayLengthPrecision);
            double Length1 = Math.Round(num24 / num25, 0) * num25;
            if (Length1 <= num25)
              Length1 = num25;
            double num26 = Functions.ConvertLength(this.SettingsEdit.DisplayLengthUnit, 1, Length1);
            object tag15 = this.SelectedNode.Tag;
            TLElement tlElement9 = tag15 != null ? (TLElement) tag15 : tlElement1;
            if (num26 != tlElement9.Length)
            {
              tlElement9.Length = num26;
              if (MyProject.Computer.Keyboard.ShiftKeyDown)
              {
                tlElement9.EndArea = this.OriginalElement.get_Area(tlElement9.Length);
                double num27 = Functions.ConvertArea(1, this.SettingsEdit.DisplayAreaUnit, tlElement9.EndArea);
                double Area3 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayAreaPrecision);
                if (num27 <= Area3)
                {
                  tlElement9.EndArea = Functions.ConvertArea(this.SettingsEdit.DisplayAreaUnit, 1, Area3);
                  tlElement9.Length = Functions.PipeLength(this.OriginalElement.StartArea, this.OriginalElement.EndArea, this.OriginalElement.Length, tlElement9.EndArea, this.OriginalElement.Taper, this.OriginalElement.HypExpT);
                }
                tlElement9.StartArea = this.OriginalElement.StartArea;
              }
              else if (MyProject.Computer.Keyboard.CtrlKeyDown)
              {
                tlElement9.StartArea = Functions.PipeArea(this.OriginalElement.EndArea, this.OriginalElement.StartArea, this.OriginalElement.Length, tlElement9.Length, this.OriginalElement.Taper, this.OriginalElement.HypExpT);
                double num28 = Functions.ConvertArea(1, this.SettingsEdit.DisplayAreaUnit, tlElement9.StartArea);
                double Area4 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayAreaPrecision);
                if (num28 <= Area4)
                {
                  tlElement9.StartArea = Functions.ConvertArea(this.SettingsEdit.DisplayAreaUnit, 1, Area4);
                  tlElement9.Length = Functions.PipeLength(this.OriginalElement.EndArea, this.OriginalElement.StartArea, this.OriginalElement.Length, tlElement9.StartArea, this.OriginalElement.Taper, this.OriginalElement.HypExpT);
                }
                tlElement9.EndArea = this.OriginalElement.EndArea;
              }
              else
              {
                tlElement9.EndArea = this.OriginalElement.EndArea;
                tlElement9.StartArea = this.OriginalElement.StartArea;
              }
              this.SelectedNode.Tag = (object) tlElement9;
              this.ToolStripStatusLabel1.Text = "Length: " + Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, tlElement9.Length).ToString() + " " + Functions.UnitStringLength(this.SettingsEdit.DisplayLengthUnit);
              this.UpdateImage();
              break;
            }
            break;
          case GeometryDisplayClass.HandleType.SplitRight:
            this.GeometryDisplayBox.Cursor = this.getSplitCursor(this.SelectedNode);
            this.MoveSplit(this.SelectedNode, location, this.OriginalElement, this.OriginalNextElement);
            break;
          case GeometryDisplayClass.HandleType.SplitLeft:
            this.GeometryDisplayBox.Cursor = this.getSplitCursor(this.SelectedNode);
            this.MoveSplit(this.SelectedNode.PrevNode, location, this.OriginalPrevElement, this.OriginalElement);
            break;
          case GeometryDisplayClass.HandleType.Driver:
            pointF1.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
            pointF1.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
            double num29 = 0.0;
            double num30 = 0.0;
            double num31 = 0;
            try
            {
              foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
              {
                int num32 = this.DriverSetupEdit.DriverPosition >= num29 ? 1 : 0;
                double driverPosition = this.DriverSetupEdit.DriverPosition;
                double num33 = num29;
                object tag16 = node.Tag;
                double length3 = (tag16 != null ? (TLElement) tag16 : tlElement1).Length;
                double num34 = num33 + length3;
                int num35 = driverPosition <= num34 ? 1 : 0;
                if ((num32 & num35) != 0)
                {
                  position = Functions.NewGetPosition(node, this.TLGeometryEdit);
                  object tag17 = node.Tag;
                  num30 = (tag17 != null ? (TLElement) tag17 : tlElement1).Angle;
                  num31 = this.DriverSetupEdit.DriverPosition - num29;
                  this.GeometryDisplayBox.Cursor = this.getLengthCursor(node);
                }
                double num36 = num29;
                object tag18 = node.Tag;
                double length4 = (tag18 != null ? (TLElement) tag18 : tlElement1).Length;
                num29 = num36 + length4;
              }
            }
            finally
            {
              IEnumerator enumerator = null;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            double num37 = Functions.Rad2Deg(Math.Atan(((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y)) / ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X))));
            if ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X) < 0.0)
              num37 += 180.0;
            else if ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y) < 0.0)
              num37 += 360.0;
            double num38 = Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, this.DriverSetupEdit.DriverPosition + (Math.Sqrt(Math.Pow((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X), 2.0) + Math.Pow((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y), 2.0)) / (double) this.ScaleDivide * Math.Cos(Functions.Deg2Rad(num37 - num30)) - num31));
            double num39 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayLengthPrecision);
            double Length2 = Functions.ConvertLength(this.SettingsEdit.DisplayLengthUnit, 1, Math.Round(num38 / num39, 0) * num39);
            if (Length2 < 0.0)
              Length2 = 0.0;
            double num40 = 0.0;
            try
            {
              foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
              {
                double num41 = num40;
                object tag19 = node.Tag;
                double length5 = (tag19 != null ? (TLElement) tag19 : tlElement1).Length;
                num40 = num41 + length5;
              }
            }
            finally
            {
              IEnumerator enumerator = null;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            if (Length2 > num40)
              Length2 = num40;
            if (Length2 != this.DriverSetupEdit.DriverPosition)
            {
              this.ToolStripStatusLabel1.Text = "Driver Position: " + Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, Length2).ToString() + " " + Functions.UnitStringLength(this.SettingsEdit.DisplayLengthUnit);
              this.DriverSetupEdit.DriverPosition = Length2;
              this.UpdateImage();
              break;
            }
            break;
          case GeometryDisplayClass.HandleType.Tap:
            pointF1.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
            pointF1.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
            double num42 = 0.0;
            double num43 = 0.0;
            double num44 = 0;
            try
            {
              foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
              {
                int num45 = this.DriverSetupEdit.TapPosition >= num42 ? 1 : 0;
                double tapPosition = this.DriverSetupEdit.TapPosition;
                double num46 = num42;
                object tag20 = node.Tag;
                double length6 = (tag20 != null ? (TLElement) tag20 : tlElement1).Length;
                double num47 = num46 + length6;
                int num48 = tapPosition <= num47 ? 1 : 0;
                if ((num45 & num48) != 0)
                {
                  position = Functions.NewGetPosition(node, this.TLGeometryEdit);
                  object tag21 = node.Tag;
                  num43 = (tag21 != null ? (TLElement) tag21 : tlElement1).Angle;
                  num44 = this.DriverSetupEdit.TapPosition - num42;
                  this.GeometryDisplayBox.Cursor = this.getLengthCursor(node);
                }
                double num49 = num42;
                object tag22 = node.Tag;
                double length7 = (tag22 != null ? (TLElement) tag22 : tlElement1).Length;
                num42 = num49 + length7;
              }
            }
            finally
            {
              IEnumerator enumerator = null;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            double num50 = Functions.Rad2Deg(Math.Atan(((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y)) / ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X))));
            if ((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X) < 0.0)
              num50 += 180.0;
            else if ((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y) < 0.0)
              num50 += 360.0;
            double num51 = Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, this.DriverSetupEdit.TapPosition + (Math.Sqrt(Math.Pow((double) location.X - (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X), 2.0) + Math.Pow((double) location.Y - (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y), 2.0)) / (double) this.ScaleDivide * Math.Cos(Functions.Deg2Rad(num50 - num43)) - num44));
            double num52 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayLengthPrecision);
            double num53 = Functions.ConvertLength(this.SettingsEdit.DisplayLengthUnit, 1, Math.Round(num51 / num52, 0) * num52);
            if (num53 < 0.0)
              num53 = 0.0;
            double num54 = 0.0;
            try
            {
              foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
              {
                double num55 = num54;
                object tag23 = node.Tag;
                double length8 = (tag23 != null ? (TLElement) tag23 : tlElement1).Length;
                num54 = num55 + length8;
              }
            }
            finally
            {
              IEnumerator enumerator = null;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            if (num53 > num54)
              num53 = num54;
            if (num53 != this.DriverSetupEdit.TapPosition)
            {
              this.DriverSetupEdit.TapPosition = num53;
              this.ToolStripStatusLabel1.Text = "Tap Position: " + num53.ToString() + " " + Functions.UnitStringLength(this.SettingsEdit.DisplayLengthUnit);
              this.UpdateImage();
              break;
            }
            break;
        }
      }
      else
      {
        this.HandleInfo.Bool = false;
        this.CheckHandleLocation(location);
        this.GeometryDisplayBox.Cursor = Cursors.Arrow;
        this.ToolStripStatusLabel1.Text = "";
        if (this.HandleInfo.Bool)
        {
          switch (this.HandleInfo.HandleType)
          {
            case GeometryDisplayClass.HandleType.StartArea:
              this.GeometryDisplayBox.Cursor = this.getAreaCursor(this.SelectedNode);
              this.ToolStripStatusLabel1.Text = "Start Area";
              break;
            case GeometryDisplayClass.HandleType.EndArea:
              this.GeometryDisplayBox.Cursor = this.getAreaCursor(this.SelectedNode);
              this.ToolStripStatusLabel1.Text = "End Area";
              break;
            case GeometryDisplayClass.HandleType.Rotate:
              this.GeometryDisplayBox.Cursor = Cursors.Hand;
              this.ToolStripStatusLabel1.Text = "Angle";
              break;
            case GeometryDisplayClass.HandleType.Length:
              this.GeometryDisplayBox.Cursor = this.getLengthCursor(this.SelectedNode);
              this.ToolStripStatusLabel1.Text = "Length";
              break;
            case GeometryDisplayClass.HandleType.SplitRight:
              this.GeometryDisplayBox.Cursor = this.getSplitCursor(this.SelectedNode);
              this.ToolStripStatusLabel1.Text = "Split";
              break;
            case GeometryDisplayClass.HandleType.SplitLeft:
              this.GeometryDisplayBox.Cursor = this.getSplitCursor(this.SelectedNode);
              this.ToolStripStatusLabel1.Text = "Split";
              break;
            case GeometryDisplayClass.HandleType.Driver:
              double num56 = 0.0;
              try
              {
                foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
                {
                  int num57 = this.DriverSetupEdit.DriverPosition >= num56 ? 1 : 0;
                  double driverPosition = this.DriverSetupEdit.DriverPosition;
                  double num58 = num56;
                  object tag24 = node.Tag;
                  double length9 = (tag24 != null ? (TLElement) tag24 : tlElement1).Length;
                  double num59 = num58 + length9;
                  int num60 = driverPosition <= num59 ? 1 : 0;
                  if ((num57 & num60) != 0)
                    this.GeometryDisplayBox.Cursor = this.getLengthCursor(node);
                  double num61 = num56;
                  object tag25 = node.Tag;
                  double length10 = (tag25 != null ? (TLElement) tag25 : tlElement1).Length;
                  num56 = num61 + length10;
                }
              }
              finally
              {
                IEnumerator enumerator = null;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
              this.ToolStripStatusLabel1.Text = "Driver";
              break;
            case GeometryDisplayClass.HandleType.Tap:
              if (this.DriverSetupEdit.Tapped)
              {
                double num62 = 0.0;
                try
                {
                  foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
                  {
                    int num63 = this.DriverSetupEdit.TapPosition >= num62 ? 1 : 0;
                    double tapPosition = this.DriverSetupEdit.TapPosition;
                    double num64 = num62;
                    object tag26 = node.Tag;
                    double length11 = (tag26 != null ? (TLElement) tag26 : tlElement1).Length;
                    double num65 = num64 + length11;
                    int num66 = tapPosition <= num65 ? 1 : 0;
                    if ((num63 & num66) != 0)
                      this.GeometryDisplayBox.Cursor = this.getLengthCursor(node);
                    double num67 = num62;
                    object tag27 = node.Tag;
                    double length12 = (tag27 != null ? (TLElement) tag27 : tlElement1).Length;
                    num62 = num67 + length12;
                  }
                }
                finally
                {
                  IEnumerator enumerator = null;
                  if (enumerator is IDisposable)
                    (enumerator as IDisposable).Dispose();
                }
                this.ToolStripStatusLabel1.Text = "Tap";
                break;
              }
              break;
            default:
              this.GeometryDisplayBox.Cursor = Cursors.Arrow;
              this.ToolStripStatusLabel1.Text = "";
              break;
          }
        }
      }
      if (this.MouseButtonPressed == this.SelectMouseButton)
      {
        this.MouseCurrentLocation = e.Location;
        this.UpdateImage();
      }
      if (this.MouseButtonPressed != this.SettingsEdit.PanMouseButton)
        return;
      this.GeometryDisplayBox.Cursor = Cursors.Hand;
      this.SettingsEdit.GeometryPanRight += (float) checked (e.Location.X - this.MouseStartLocation.X);
      this.SettingsEdit.GeometryPanUp += (float) checked (e.Location.Y - this.MouseStartLocation.Y);
      this.MouseStartLocation = e.Location;
      this.UpdateImage();
      this.SendSettings();
    }

    private void MoveSplit(
      TreeNode FirstElement,
      PointF MouseCoords,
      TLElement OrigFirst,
      TLElement OrigSecond)
    {
      if (Information.IsNothing((object) FirstElement) | Information.IsNothing((object) FirstElement.NextNode))
        return;
      PointF pointF = default;
      pointF.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      PointF position = Functions.NewGetPosition(FirstElement, this.TLGeometryEdit);
      double num1 = Functions.Rad2Deg(Math.Atan(((double) MouseCoords.Y - (double) this.ScaleDivide * ((double) pointF.Y + (double) position.Y)) / ((double) MouseCoords.X - (double) this.ScaleDivide * ((double) pointF.X + (double) position.X))));
      if ((double) MouseCoords.X - (double) this.ScaleDivide * ((double) pointF.X + (double) position.X) < 0.0)
        num1 += 180.0;
      else if ((double) MouseCoords.Y - (double) this.ScaleDivide * ((double) pointF.Y + (double) position.Y) < 0.0)
        num1 += 360.0;
      double num2 = Math.Sqrt(Math.Pow((double) MouseCoords.X - (double) this.ScaleDivide * ((double) pointF.X + (double) position.X), 2.0) + Math.Pow((double) MouseCoords.Y - (double) this.ScaleDivide * ((double) pointF.Y + (double) position.Y), 2.0)) / (double) this.ScaleDivide;
      double num3 = num1;
      object tag1 = FirstElement.Tag;
      TLElement tlElement1 = default;
      double angle = (tag1 != null ? (TLElement) tag1 : tlElement1).Angle;
      double Deg = num3 - angle;
      double num4 = Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, num2 * Math.Cos(Functions.Deg2Rad(Deg)));
      double num5 = 100.0 / Math.Pow(10.0, (double) this.SettingsEdit.DisplayLengthPrecision);
      double Length = Math.Round(num4 / num5, 0) * num5;
      if (Length < num5)
        Length = num5;
      if (Length > Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, OrigFirst.Length) + Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, OrigSecond.Length) - num5)
        Length = Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, OrigFirst.Length) + Functions.ConvertLength(1, this.SettingsEdit.DisplayLengthUnit, OrigSecond.Length) - num5;
      double num6 = Functions.ConvertLength(this.SettingsEdit.DisplayLengthUnit, 1, Length);
      object tag2 = FirstElement.Tag;
      TLElement tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
      if (num6 != tlElement2.Length)
      {
        tlElement2.Length = num6;
        tlElement2.EndArea = Functions.PipeArea(OrigFirst.StartArea, OrigFirst.EndArea, OrigFirst.Length, tlElement2.Length, tlElement2.Taper, tlElement2.HypExpT);
        tlElement2.StartArea = OrigFirst.StartArea;
        FirstElement.Tag = (object) tlElement2;
        object tag3 = FirstElement.NextNode.Tag;
        TLElement tlElement3 = (tag3 != null ? (TLElement) tag3 : tlElement1) with
        {
          Length = OrigSecond.Length + OrigFirst.Length - tlElement2.Length
        };
        tlElement3.StartArea = Functions.PipeArea(OrigSecond.EndArea, OrigSecond.StartArea, OrigSecond.Length, tlElement3.Length, tlElement3.Taper, tlElement3.HypExpT);
        tlElement3.EndArea = OrigSecond.EndArea;
        FirstElement.NextNode.Tag = (object) tlElement3;
        this.ToolStripStatusLabel1.Text = "Length: " + Length.ToString() + " " + Functions.UnitStringLength(this.SettingsEdit.DisplayLengthUnit) + " Split Ratio: " + Conversions.ToString(Math.Round(tlElement2.Length / (tlElement2.Length + tlElement3.Length), 2));
        this.UpdateImage();
      }
    }

    private void CheckHandleLocation(PointF Mouse)
    {
      PointF pointF1 = default;
      pointF1.X = this.SettingsEdit.GeometryPanRight / this.ScaleDivide;
      pointF1.Y = this.SettingsEdit.GeometryPanUp / this.ScaleDivide;
      if (!Information.IsNothing((object) this.SelectedNode))
      {
        if (Operators.CompareString(Strings.Split(Functions.GetTreeString(this.SelectedNode), ".")[0], "Front", false) == 0)
        {
          pointF1 = this.DriverPosition(1);
          pointF1.X /= this.ScaleDivide;
          pointF1.Y /= this.ScaleDivide;
        }
        PointF position = Functions.NewGetPosition(this.SelectedNode, this.TLGeometryEdit);
        PointF pointF2 = default;
        ref PointF local1 = ref pointF2;
        double num1 = (double) this.ScaleDivide * ((double) pointF1.X + (double) position.X);
        object tag1 = this.SelectedNode.Tag;
        TLElement tlElement = default;
        double num2 = 25.0 * Math.Cos(Functions.Deg2Rad((tag1 != null ? (TLElement) tag1 : tlElement).Angle));
        double num3 = num1 + num2;
        local1.X = (float) num3;
        ref PointF local2 = ref pointF2;
        double num4 = (double) this.ScaleDivide * ((double) pointF1.Y + (double) position.Y);
        object tag2 = this.SelectedNode.Tag;
        double num5 = 25.0 * Math.Sin(Functions.Deg2Rad((tag2 != null ? (TLElement) tag2 : tlElement).Angle));
        double num6 = num4 + num5;
        local2.Y = (float) num6;
        PointF pointF3 = default;
        ref PointF local3 = ref pointF3;
        double scaleDivide1 = (double) this.ScaleDivide;
        double num7 = (double) pointF1.X + (double) position.X;
        object tag3 = this.SelectedNode.Tag;
        double length1 = (tag3 != null ? (TLElement) tag3 : tlElement).Length;
        object tag4 = this.SelectedNode.Tag;
        double num8 = Math.Cos(Functions.Deg2Rad((tag4 != null ? (TLElement) tag4 : tlElement).Angle));
        double num9 = length1 * num8;
        double num10 = num7 + num9;
        double num11 = scaleDivide1 * num10;
        local3.X = (float) num11;
        ref PointF local4 = ref pointF3;
        double scaleDivide2 = (double) this.ScaleDivide;
        double num12 = (double) pointF1.Y + (double) position.Y;
        object tag5 = this.SelectedNode.Tag;
        double length2 = (tag5 != null ? (TLElement) tag5 : tlElement).Length;
        object tag6 = this.SelectedNode.Tag;
        double num13 = Math.Sin(Functions.Deg2Rad((tag6 != null ? (TLElement) tag6 : tlElement).Angle));
        double num14 = length2 * num13;
        double num15 = num12 + num14;
        double num16 = scaleDivide2 * num15;
        local4.Y = (float) num16;
        PointF pointF4 = default;
        ref PointF local5 = ref pointF4;
        double scaleDivide3 = (double) this.ScaleDivide;
        double x1 = (double) pointF1.X;
        double x2 = (double) position.X;
        object tag7 = this.SelectedNode.Tag;
        double num17 = 0.5 * ((tag7 != null ? (TLElement) tag7 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag8 = this.SelectedNode.Tag;
        double num18 = Math.Sin(Functions.Deg2Rad((tag8 != null ? (TLElement) tag8 : tlElement).Angle));
        double num19 = num17 * num18;
        double num20 = x2 + num19;
        double num21 = x1 + num20;
        double num22 = scaleDivide3 * num21;
        local5.X = (float) num22;
        ref PointF local6 = ref pointF4;
        double scaleDivide4 = (double) this.ScaleDivide;
        double y1 = (double) pointF1.Y;
        double y2 = (double) position.Y;
        object tag9 = this.SelectedNode.Tag;
        double num23 = 0.5 * ((tag9 != null ? (TLElement) tag9 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag10 = this.SelectedNode.Tag;
        double num24 = Math.Cos(Functions.Deg2Rad((tag10 != null ? (TLElement) tag10 : tlElement).Angle));
        double num25 = num23 * num24;
        double num26 = y2 - num25;
        double num27 = y1 + num26;
        double num28 = scaleDivide4 * num27;
        local6.Y = (float) num28;
        PointF pointF5 = default;
        ref PointF local7 = ref pointF5;
        double scaleDivide5 = (double) this.ScaleDivide;
        double x3 = (double) pointF1.X;
        double x4 = (double) position.X;
        object tag11 = this.SelectedNode.Tag;
        double length3 = (tag11 != null ? (TLElement) tag11 : tlElement).Length;
        object tag12 = this.SelectedNode.Tag;
        double num29 = Math.Cos(Functions.Deg2Rad((tag12 != null ? (TLElement) tag12 : tlElement).Angle));
        double num30 = length3 * num29;
        double num31 = x4 + num30;
        object tag13 = this.SelectedNode.Tag;
        double num32 = 0.5 * ((tag13 != null ? (TLElement) tag13 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag14 = this.SelectedNode.Tag;
        double num33 = Math.Sin(Functions.Deg2Rad((tag14 != null ? (TLElement) tag14 : tlElement).Angle));
        double num34 = num32 * num33;
        double num35 = num31 + num34;
        double num36 = x3 + num35;
        double num37 = scaleDivide5 * num36;
        local7.X = (float) num37;
        ref PointF local8 = ref pointF5;
        double scaleDivide6 = (double) this.ScaleDivide;
        double y3 = (double) pointF1.Y;
        double y4 = (double) position.Y;
        object tag15 = this.SelectedNode.Tag;
        double length4 = (tag15 != null ? (TLElement) tag15 : tlElement).Length;
        object tag16 = this.SelectedNode.Tag;
        double num38 = Math.Sin(Functions.Deg2Rad((tag16 != null ? (TLElement) tag16 : tlElement).Angle));
        double num39 = length4 * num38;
        double num40 = y4 + num39;
        object tag17 = this.SelectedNode.Tag;
        double num41 = 0.5 * ((tag17 != null ? (TLElement) tag17 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag18 = this.SelectedNode.Tag;
        double num42 = Math.Cos(Functions.Deg2Rad((tag18 != null ? (TLElement) tag18 : tlElement).Angle));
        double num43 = num41 * num42;
        double num44 = num40 - num43;
        double num45 = y3 + num44;
        double num46 = scaleDivide6 * num45;
        local8.Y = (float) num46;
        PointF pointF6 = default;
        ref PointF local9 = ref pointF6;
        double scaleDivide7 = (double) this.ScaleDivide;
        double x5 = (double) pointF1.X;
        double x6 = (double) position.X;
        object tag19 = this.SelectedNode.Tag;
        double num47 = (tag19 != null ? (TLElement) tag19 : tlElement).Length - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag20 = this.SelectedNode.Tag;
        double num48 = Math.Cos(Functions.Deg2Rad((tag20 != null ? (TLElement) tag20 : tlElement).Angle));
        double num49 = num47 * num48;
        double num50 = x6 + num49;
        object tag21 = this.SelectedNode.Tag;
        double num51 = 0.5 * ((tag21 != null ? (TLElement) tag21 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag22 = this.SelectedNode.Tag;
        double num52 = Math.Sin(Functions.Deg2Rad((tag22 != null ? (TLElement) tag22 : tlElement).Angle));
        double num53 = num51 * num52;
        double num54 = num50 + num53;
        double num55 = x5 + num54;
        double num56 = scaleDivide7 * num55;
        local9.X = (float) num56;
        ref PointF local10 = ref pointF6;
        double scaleDivide8 = (double) this.ScaleDivide;
        double y5 = (double) pointF1.Y;
        double y6 = (double) position.Y;
        object tag23 = this.SelectedNode.Tag;
        double num57 = (tag23 != null ? (TLElement) tag23 : tlElement).Length - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag24 = this.SelectedNode.Tag;
        double num58 = Math.Sin(Functions.Deg2Rad((tag24 != null ? (TLElement) tag24 : tlElement).Angle));
        double num59 = num57 * num58;
        double num60 = y6 + num59;
        object tag25 = this.SelectedNode.Tag;
        double num61 = 0.5 * ((tag25 != null ? (TLElement) tag25 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag26 = this.SelectedNode.Tag;
        double num62 = Math.Cos(Functions.Deg2Rad((tag26 != null ? (TLElement) tag26 : tlElement).Angle));
        double num63 = num61 * num62;
        double num64 = num60 - num63;
        double num65 = y5 + num64;
        double num66 = scaleDivide8 * num65;
        local10.Y = (float) num66;
        PointF pointF7 = default;
        ref PointF local11 = ref pointF7;
        double scaleDivide9 = (double) this.ScaleDivide;
        double x7 = (double) pointF1.X;
        double x8 = (double) position.X;
        object tag27 = this.SelectedNode.Tag;
        double num67 = (tag27 != null ? (TLElement) tag27 : tlElement).Length + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag28 = this.SelectedNode.Tag;
        double num68 = Math.Cos(Functions.Deg2Rad((tag28 != null ? (TLElement) tag28 : tlElement).Angle));
        double num69 = num67 * num68;
        double num70 = x8 + num69;
        object tag29 = this.SelectedNode.Tag;
        double num71 = 0.5 * ((tag29 != null ? (TLElement) tag29 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag30 = this.SelectedNode.Tag;
        double num72 = Math.Sin(Functions.Deg2Rad((tag30 != null ? (TLElement) tag30 : tlElement).Angle));
        double num73 = num71 * num72;
        double num74 = num70 + num73;
        double num75 = x7 + num74;
        double num76 = scaleDivide9 * num75;
        local11.X = (float) num76;
        ref PointF local12 = ref pointF7;
        double scaleDivide10 = (double) this.ScaleDivide;
        double y7 = (double) pointF1.Y;
        double y8 = (double) position.Y;
        object tag31 = this.SelectedNode.Tag;
        double num77 = (tag31 != null ? (TLElement) tag31 : tlElement).Length + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag32 = this.SelectedNode.Tag;
        double num78 = Math.Sin(Functions.Deg2Rad((tag32 != null ? (TLElement) tag32 : tlElement).Angle));
        double num79 = num77 * num78;
        double num80 = y8 + num79;
        object tag33 = this.SelectedNode.Tag;
        double num81 = 0.5 * ((tag33 != null ? (TLElement) tag33 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag34 = this.SelectedNode.Tag;
        double num82 = Math.Cos(Functions.Deg2Rad((tag34 != null ? (TLElement) tag34 : tlElement).Angle));
        double num83 = num81 * num82;
        double num84 = num80 - num83;
        double num85 = y7 + num84;
        double num86 = scaleDivide10 * num85;
        local12.Y = (float) num86;
        PointF pointF8 = default;
        ref PointF local13 = ref pointF8;
        double scaleDivide11 = (double) this.ScaleDivide;
        double x9 = (double) pointF1.X;
        double x10 = (double) position.X;
        object tag35 = this.SelectedNode.Tag;
        double num87 = (tag35 != null ? (TLElement) tag35 : tlElement).Length - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag36 = this.SelectedNode.Tag;
        double num88 = Math.Cos(Functions.Deg2Rad((tag36 != null ? (TLElement) tag36 : tlElement).Angle));
        double num89 = num87 * num88;
        double num90 = x10 + num89;
        object tag37 = this.SelectedNode.Tag;
        double num91 = 0.5 * ((tag37 != null ? (TLElement) tag37 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag38 = this.SelectedNode.Tag;
        double num92 = Math.Sin(Functions.Deg2Rad((tag38 != null ? (TLElement) tag38 : tlElement).Angle));
        double num93 = num91 * num92;
        double num94 = num90 - num93;
        double num95 = x9 + num94;
        double num96 = scaleDivide11 * num95;
        local13.X = (float) num96;
        ref PointF local14 = ref pointF8;
        double scaleDivide12 = (double) this.ScaleDivide;
        double y9 = (double) pointF1.Y;
        double y10 = (double) position.Y;
        object tag39 = this.SelectedNode.Tag;
        double num97 = (tag39 != null ? (TLElement) tag39 : tlElement).Length - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag40 = this.SelectedNode.Tag;
        double num98 = Math.Sin(Functions.Deg2Rad((tag40 != null ? (TLElement) tag40 : tlElement).Angle));
        double num99 = num97 * num98;
        double num100 = y10 + num99;
        object tag41 = this.SelectedNode.Tag;
        double num101 = 0.5 * ((tag41 != null ? (TLElement) tag41 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag42 = this.SelectedNode.Tag;
        double num102 = Math.Cos(Functions.Deg2Rad((tag42 != null ? (TLElement) tag42 : tlElement).Angle));
        double num103 = num101 * num102;
        double num104 = num100 + num103;
        double num105 = y9 + num104;
        double num106 = scaleDivide12 * num105;
        local14.Y = (float) num106;
        PointF pointF9 = default;
        ref PointF local15 = ref pointF9;
        double scaleDivide13 = (double) this.ScaleDivide;
        double x11 = (double) pointF1.X;
        double x12 = (double) position.X;
        object tag43 = this.SelectedNode.Tag;
        double num107 = (tag43 != null ? (TLElement) tag43 : tlElement).Length + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag44 = this.SelectedNode.Tag;
        double num108 = Math.Cos(Functions.Deg2Rad((tag44 != null ? (TLElement) tag44 : tlElement).Angle));
        double num109 = num107 * num108;
        double num110 = x12 + num109;
        object tag45 = this.SelectedNode.Tag;
        double num111 = 0.5 * ((tag45 != null ? (TLElement) tag45 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag46 = this.SelectedNode.Tag;
        double num112 = Math.Sin(Functions.Deg2Rad((tag46 != null ? (TLElement) tag46 : tlElement).Angle));
        double num113 = num111 * num112;
        double num114 = num110 - num113;
        double num115 = x11 + num114;
        double num116 = scaleDivide13 * num115;
        local15.X = (float) num116;
        ref PointF local16 = ref pointF9;
        double scaleDivide14 = (double) this.ScaleDivide;
        double y11 = (double) pointF1.Y;
        double y12 = (double) position.Y;
        object tag47 = this.SelectedNode.Tag;
        double num117 = (tag47 != null ? (TLElement) tag47 : tlElement).Length + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag48 = this.SelectedNode.Tag;
        double num118 = Math.Sin(Functions.Deg2Rad((tag48 != null ? (TLElement) tag48 : tlElement).Angle));
        double num119 = num117 * num118;
        double num120 = y12 + num119;
        object tag49 = this.SelectedNode.Tag;
        double num121 = 0.5 * ((tag49 != null ? (TLElement) tag49 : tlElement).EndArea / this.TLGeometryEdit.Width);
        object tag50 = this.SelectedNode.Tag;
        double num122 = Math.Cos(Functions.Deg2Rad((tag50 != null ? (TLElement) tag50 : tlElement).Angle));
        double num123 = num121 * num122;
        double num124 = num120 + num123;
        double num125 = y11 + num124;
        double num126 = scaleDivide14 * num125;
        local16.Y = (float) num126;
        PointF[] Polygon1 = new PointF[4]
        {
          pointF6,
          pointF7,
          pointF9,
          pointF8
        };
        ref PointF local17 = ref pointF6;
        double scaleDivide15 = (double) this.ScaleDivide;
        double x13 = (double) pointF1.X;
        double x14 = (double) position.X;
        double num127 = 0.0 - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag51 = this.SelectedNode.Tag;
        double num128 = Math.Cos(Functions.Deg2Rad((tag51 != null ? (TLElement) tag51 : tlElement).Angle));
        double num129 = num127 * num128;
        double num130 = x14 + num129;
        object tag52 = this.SelectedNode.Tag;
        double num131 = 0.5 * ((tag52 != null ? (TLElement) tag52 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag53 = this.SelectedNode.Tag;
        double num132 = Math.Sin(Functions.Deg2Rad((tag53 != null ? (TLElement) tag53 : tlElement).Angle));
        double num133 = num131 * num132;
        double num134 = num130 + num133;
        double num135 = x13 + num134;
        double num136 = scaleDivide15 * num135;
        local17.X = (float) num136;
        ref PointF local18 = ref pointF6;
        double scaleDivide16 = (double) this.ScaleDivide;
        double y13 = (double) pointF1.Y;
        double y14 = (double) position.Y;
        double num137 = 0.0 - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag54 = this.SelectedNode.Tag;
        double num138 = Math.Sin(Functions.Deg2Rad((tag54 != null ? (TLElement) tag54 : tlElement).Angle));
        double num139 = num137 * num138;
        double num140 = y14 + num139;
        object tag55 = this.SelectedNode.Tag;
        double num141 = 0.5 * ((tag55 != null ? (TLElement) tag55 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag56 = this.SelectedNode.Tag;
        double num142 = Math.Cos(Functions.Deg2Rad((tag56 != null ? (TLElement) tag56 : tlElement).Angle));
        double num143 = num141 * num142;
        double num144 = num140 - num143;
        double num145 = y13 + num144;
        double num146 = scaleDivide16 * num145;
        local18.Y = (float) num146;
        ref PointF local19 = ref pointF7;
        double scaleDivide17 = (double) this.ScaleDivide;
        double x15 = (double) pointF1.X;
        double x16 = (double) position.X;
        double num147 = 0.0 + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag57 = this.SelectedNode.Tag;
        double num148 = Math.Cos(Functions.Deg2Rad((tag57 != null ? (TLElement) tag57 : tlElement).Angle));
        double num149 = num147 * num148;
        double num150 = x16 + num149;
        object tag58 = this.SelectedNode.Tag;
        double num151 = 0.5 * ((tag58 != null ? (TLElement) tag58 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag59 = this.SelectedNode.Tag;
        double num152 = Math.Sin(Functions.Deg2Rad((tag59 != null ? (TLElement) tag59 : tlElement).Angle));
        double num153 = num151 * num152;
        double num154 = num150 + num153;
        double num155 = x15 + num154;
        double num156 = scaleDivide17 * num155;
        local19.X = (float) num156;
        ref PointF local20 = ref pointF7;
        double scaleDivide18 = (double) this.ScaleDivide;
        double y15 = (double) pointF1.Y;
        double y16 = (double) position.Y;
        double num157 = 0.0 + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag60 = this.SelectedNode.Tag;
        double num158 = Math.Sin(Functions.Deg2Rad((tag60 != null ? (TLElement) tag60 : tlElement).Angle));
        double num159 = num157 * num158;
        double num160 = y16 + num159;
        object tag61 = this.SelectedNode.Tag;
        double num161 = 0.5 * ((tag61 != null ? (TLElement) tag61 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag62 = this.SelectedNode.Tag;
        double num162 = Math.Cos(Functions.Deg2Rad((tag62 != null ? (TLElement) tag62 : tlElement).Angle));
        double num163 = num161 * num162;
        double num164 = num160 - num163;
        double num165 = y15 + num164;
        double num166 = scaleDivide18 * num165;
        local20.Y = (float) num166;
        ref PointF local21 = ref pointF8;
        double scaleDivide19 = (double) this.ScaleDivide;
        double x17 = (double) pointF1.X;
        double x18 = (double) position.X;
        double num167 = 0.0 - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag63 = this.SelectedNode.Tag;
        double num168 = Math.Cos(Functions.Deg2Rad((tag63 != null ? (TLElement) tag63 : tlElement).Angle));
        double num169 = num167 * num168;
        double num170 = x18 + num169;
        object tag64 = this.SelectedNode.Tag;
        double num171 = 0.5 * ((tag64 != null ? (TLElement) tag64 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag65 = this.SelectedNode.Tag;
        double num172 = Math.Sin(Functions.Deg2Rad((tag65 != null ? (TLElement) tag65 : tlElement).Angle));
        double num173 = num171 * num172;
        double num174 = num170 - num173;
        double num175 = x17 + num174;
        double num176 = scaleDivide19 * num175;
        local21.X = (float) num176;
        ref PointF local22 = ref pointF8;
        double scaleDivide20 = (double) this.ScaleDivide;
        double y17 = (double) pointF1.Y;
        double y18 = (double) position.Y;
        double num177 = 0.0 - (double) this.HandleSize / (double) this.ScaleDivide;
        object tag66 = this.SelectedNode.Tag;
        double num178 = Math.Sin(Functions.Deg2Rad((tag66 != null ? (TLElement) tag66 : tlElement).Angle));
        double num179 = num177 * num178;
        double num180 = y18 + num179;
        object tag67 = this.SelectedNode.Tag;
        double num181 = 0.5 * ((tag67 != null ? (TLElement) tag67 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag68 = this.SelectedNode.Tag;
        double num182 = Math.Cos(Functions.Deg2Rad((tag68 != null ? (TLElement) tag68 : tlElement).Angle));
        double num183 = num181 * num182;
        double num184 = num180 + num183;
        double num185 = y17 + num184;
        double num186 = scaleDivide20 * num185;
        local22.Y = (float) num186;
        ref PointF local23 = ref pointF9;
        double scaleDivide21 = (double) this.ScaleDivide;
        double x19 = (double) pointF1.X;
        double x20 = (double) position.X;
        double num187 = 0.0 + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag69 = this.SelectedNode.Tag;
        double num188 = Math.Cos(Functions.Deg2Rad((tag69 != null ? (TLElement) tag69 : tlElement).Angle));
        double num189 = num187 * num188;
        double num190 = x20 + num189;
        object tag70 = this.SelectedNode.Tag;
        double num191 = 0.5 * ((tag70 != null ? (TLElement) tag70 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag71 = this.SelectedNode.Tag;
        double num192 = Math.Sin(Functions.Deg2Rad((tag71 != null ? (TLElement) tag71 : tlElement).Angle));
        double num193 = num191 * num192;
        double num194 = num190 - num193;
        double num195 = x19 + num194;
        double num196 = scaleDivide21 * num195;
        local23.X = (float) num196;
        ref PointF local24 = ref pointF9;
        double scaleDivide22 = (double) this.ScaleDivide;
        double y19 = (double) pointF1.Y;
        double y20 = (double) position.Y;
        double num197 = 0.0 + (double) this.HandleSize / (double) this.ScaleDivide;
        object tag72 = this.SelectedNode.Tag;
        double num198 = Math.Sin(Functions.Deg2Rad((tag72 != null ? (TLElement) tag72 : tlElement).Angle));
        double num199 = num197 * num198;
        double num200 = y20 + num199;
        object tag73 = this.SelectedNode.Tag;
        double num201 = 0.5 * ((tag73 != null ? (TLElement) tag73 : tlElement).StartArea / this.TLGeometryEdit.Width);
        object tag74 = this.SelectedNode.Tag;
        double num202 = Math.Cos(Functions.Deg2Rad((tag74 != null ? (TLElement) tag74 : tlElement).Angle));
        double num203 = num201 * num202;
        double num204 = num200 + num203;
        double num205 = y19 + num204;
        double num206 = scaleDivide22 * num205;
        local24.Y = (float) num206;
        PointF[] Polygon2 = new PointF[4]
        {
          pointF6,
          pointF7,
          pointF9,
          pointF8
        };
        if ((double) Mouse.X > (double) pointF3.X - (double) this.HandleSize & (double) Mouse.X < (double) pointF3.X + (double) this.HandleSize & (double) Mouse.Y > (double) pointF3.Y - (double) this.HandleSize & (double) Mouse.Y < (double) pointF3.Y + (double) this.HandleSize)
        {
          this.HandleInfo.Bool = true;
          this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.Length;
        }
        else if ((double) Mouse.X > (double) pointF2.X - (double) this.HandleSize & (double) Mouse.X < (double) pointF2.X + (double) this.HandleSize & (double) Mouse.Y > (double) pointF2.Y - (double) this.HandleSize & (double) Mouse.Y < (double) pointF2.Y + (double) this.HandleSize)
        {
          this.HandleInfo.Bool = true;
          this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.Rotate;
        }
        else if ((double) Mouse.X > (double) pointF4.X - (double) this.HandleSize & (double) Mouse.X < (double) pointF4.X + (double) this.HandleSize & (double) Mouse.Y > (double) pointF4.Y - (double) this.HandleSize & (double) Mouse.Y < (double) pointF4.Y + (double) this.HandleSize)
        {
          this.HandleInfo.Bool = true;
          this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.StartArea;
        }
        else if ((double) Mouse.X > (double) pointF5.X - (double) this.HandleSize & (double) Mouse.X < (double) pointF5.X + (double) this.HandleSize & (double) Mouse.Y > (double) pointF5.Y - (double) this.HandleSize & (double) Mouse.Y < (double) pointF5.Y + (double) this.HandleSize)
        {
          this.HandleInfo.Bool = true;
          this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.EndArea;
        }
        else if (VectorFunctions.PointInPolygonNew2D(Polygon1, Mouse))
        {
          if (!Information.IsNothing((object) this.SelectedNode.NextNode))
          {
            object tag75 = this.SelectedNode.Tag;
            TLElement Element1 = tag75 != null ? (TLElement) tag75 : tlElement;
            object tag76 = this.SelectedNode.NextNode.Tag;
            TLElement Element2 = tag76 != null ? (TLElement) tag76 : tlElement;
            if (Functions.ElementMergeBoolSibling(Element1, Element2))
            {
              this.HandleInfo.Bool = true;
              this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.SplitRight;
            }
          }
        }
        else if (VectorFunctions.PointInPolygonNew2D(Polygon2, Mouse) && !Information.IsNothing((object) this.SelectedNode.PrevNode))
        {
          object tag77 = this.SelectedNode.PrevNode.Tag;
          TLElement Element1 = tag77 != null ? (TLElement) tag77 : tlElement;
          object tag78 = this.SelectedNode.Tag;
          TLElement Element2 = tag78 != null ? (TLElement) tag78 : tlElement;
          if (Functions.ElementMergeBoolSibling(Element1, Element2))
          {
            this.HandleInfo.Bool = true;
            this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.SplitLeft;
          }
        }
      }
      PointF pointF10 = this.DriverPosition(1);
      if ((double) Mouse.X > (double) pointF10.X - (double) this.HandleSize & (double) Mouse.X < (double) pointF10.X + (double) this.HandleSize & (double) Mouse.Y > (double) pointF10.Y - (double) this.HandleSize & (double) Mouse.Y < (double) pointF10.Y + (double) this.HandleSize)
      {
        this.HandleInfo.Bool = true;
        this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.Driver;
      }
      if (!this.DriverSetupEdit.Tapped)
        return;
      pointF10 = this.DriverPosition(2);
      if ((double) Mouse.X > (double) pointF10.X - (double) this.HandleSize & (double) Mouse.X < (double) pointF10.X + (double) this.HandleSize & (double) Mouse.Y > (double) pointF10.Y - (double) this.HandleSize & (double) Mouse.Y < (double) pointF10.Y + (double) this.HandleSize)
      {
        this.HandleInfo.Bool = true;
        this.HandleInfo.HandleType = GeometryDisplayClass.HandleType.Tap;
      }
    }

    private void SendValues()
    {
      this.UpdateModelForm();
      this.UpdateElementForm();
      TLParameterUpdatedEventArgs e = new TLParameterUpdatedEventArgs(this.TLGeometryEdit, this.DriverSetupEdit);
      GeometryDisplayClass.TLParameterUpdatedEventHandler parameterUpdatedEvent = this.TLParameterUpdated;
      if (parameterUpdatedEvent == null)
        return;
      parameterUpdatedEvent((object) this, e);
    }

    private void SendSettings()
    {
      SettingsUpdatedEventArgs e = new SettingsUpdatedEventArgs(this.SettingsEdit);
      GeometryDisplayClass.SettingsUpdatedEventHandler settingsUpdatedEvent = this.SettingsUpdated;
      if (settingsUpdatedEvent == null)
        return;
      settingsUpdatedEvent((object) this, e);
    }

    private void EnclosureDepthLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.EnclosureDepthUnit < Functions.UnitNumberLength())
        checked { ++this.SettingsEdit.EnclosureDepthUnit; }
      else
        this.SettingsEdit.EnclosureDepthUnit = 1;
      this.UpdateUnits();
      this.UpdateModelForm();
      this.SendSettings();
    }

    private void ElementVolumeLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.ElementVolumeUnit < Functions.UnitNumberVolume())
        checked { ++this.SettingsEdit.ElementVolumeUnit; }
      else
        this.SettingsEdit.ElementVolumeUnit = 1;
      this.UpdateUnits();
      this.UpdateElementForm();
      this.SendSettings();
    }

    private void EnclosureVolumeLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.VolumeUnit < Functions.UnitNumberVolume())
        checked { ++this.SettingsEdit.VolumeUnit; }
      else
        this.SettingsEdit.VolumeUnit = 1;
      this.UpdateUnits();
      this.RefreshVolumeLength();
      this.SendSettings();
    }

    private void TotalLengthLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.TotalLengthUnit < Functions.UnitNumberLength())
        checked { ++this.SettingsEdit.TotalLengthUnit; }
      else
        this.SettingsEdit.TotalLengthUnit = 1;
      this.UpdateUnits();
      this.RefreshVolumeLength();
      this.SendSettings();
    }

    private void LengthUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.LengthUnit < Functions.UnitNumberLength())
        checked { ++this.SettingsEdit.LengthUnit; }
      else
        this.SettingsEdit.LengthUnit = 1;
      this.UpdateUnits();
      this.UpdateElementForm();
      this.UpdateModelForm();
      this.SendSettings();
    }

    private void DensityUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.DensityUnit < Functions.UnitNumberDensity())
        checked { ++this.SettingsEdit.DensityUnit; }
      else
        this.SettingsEdit.DensityUnit = 1;
      this.UpdateUnits();
      this.UpdateElementForm();
      this.UpdateModelForm();
      this.SendSettings();
    }

    private void StartAreaUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.StartAreaUnit < Functions.UnitNumberLength())
        checked { ++this.SettingsEdit.StartAreaUnit; }
      else
        this.SettingsEdit.StartAreaUnit = 1;
      this.UpdateUnits();
      this.UpdateElementForm();
      this.SendSettings();
    }

    private void EndAreaUnitLabel_Click(object sender, EventArgs e)
    {
      if (this.SettingsEdit.EndAreaUnit < Functions.UnitNumberLength())
        checked { ++this.SettingsEdit.EndAreaUnit; }
      else
        this.SettingsEdit.EndAreaUnit = 1;
      this.UpdateUnits();
      this.UpdateElementForm();
      this.SendSettings();
    }

    private void StartAreaCheck_CheckedChanged(object sender, EventArgs e)
    {
      if (this.StartAreaCheck.Checked)
      {
        this.EndAreaCheck.Checked = false;
        this.TaperRatioCheck.Checked = false;
      }
      this.StartAreaBox.Enabled = !this.StartAreaCheck.Checked;
      this.EndAreaBox.Enabled = !this.EndAreaCheck.Checked;
      this.TaperRatioBox.Enabled = !this.TaperRatioCheck.Checked;
      this.StartAreaCheck.Enabled = !this.StartAreaCheck.Checked;
      this.EndAreaCheck.Enabled = !this.EndAreaCheck.Checked;
      this.TaperRatioCheck.Enabled = !this.TaperRatioCheck.Checked;
    }

    private void EndAreaCheck_CheckedChanged(object sender, EventArgs e)
    {
      if (this.EndAreaCheck.Checked)
      {
        this.TaperRatioCheck.Checked = false;
        this.StartAreaCheck.Checked = false;
      }
      this.StartAreaBox.Enabled = !this.StartAreaCheck.Checked;
      this.EndAreaBox.Enabled = !this.EndAreaCheck.Checked;
      this.TaperRatioBox.Enabled = !this.TaperRatioCheck.Checked;
      this.StartAreaCheck.Enabled = !this.StartAreaCheck.Checked;
      this.EndAreaCheck.Enabled = !this.EndAreaCheck.Checked;
      this.TaperRatioCheck.Enabled = !this.TaperRatioCheck.Checked;
    }

    private void TaperRatioCheck_CheckedChanged(object sender, EventArgs e)
    {
      if (this.TaperRatioCheck.Checked)
      {
        this.EndAreaCheck.Checked = false;
        this.StartAreaCheck.Checked = false;
      }
      this.StartAreaBox.Enabled = !this.StartAreaCheck.Checked;
      this.EndAreaBox.Enabled = !this.EndAreaCheck.Checked;
      this.TaperRatioBox.Enabled = !this.TaperRatioCheck.Checked;
      this.StartAreaCheck.Enabled = !this.StartAreaCheck.Checked;
      this.EndAreaCheck.Enabled = !this.EndAreaCheck.Checked;
      this.TaperRatioCheck.Enabled = !this.TaperRatioCheck.Checked;
    }

    private void UpdateTaperRatio()
    {
      if (this.TaperRatioCheck.Checked)
        this.TaperRatioBox.Text = (Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text)) / Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text))).ToString();
      else if (this.StartAreaCheck.Checked)
      {
        this.StartAreaBox.Text = Functions.ConvertArea(1, this.SettingsEdit.StartAreaUnit, Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text)) / Conversions.ToDouble(this.TaperRatioBox.Text)).ToString();
      }
      else
      {
        if (!this.EndAreaCheck.Checked)
          return;
        this.EndAreaBox.Text = Functions.ConvertArea(1, this.SettingsEdit.EndAreaUnit, Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text)) * Conversions.ToDouble(this.TaperRatioBox.Text)).ToString();
      }
    }

    private void WidthBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.WidthBox.Text, 1E-05, 1000.0))
        return;
      this.TLGeometryEdit.Width = Functions.ConvertLength(this.SettingsEdit.EnclosureDepthUnit, 1, Conversions.ToDouble(this.WidthBox.Text));
      this.UpdateImage();
    }

    private void DriverPositionBox_LostFocus()
    {
      if (!Functions.ErrorCheckNum(this.DriverPositionBox.Text, 0.0, Functions.ConvertLength(1, this.SettingsEdit.LengthUnit, this.TotalLength_Main())) || this.DriverSetupEdit.DriverPosition == Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.DriverPositionBox.Text)))
        return;
      this.DriverSetupEdit.DriverPosition = Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.DriverPositionBox.Text));
      this.UpdateImage();
      this.SendValues();
    }

    private void TapPositionBox_LostFocus()
    {
      if (!Functions.ErrorCheckNum(this.DriverPositionBox.Text, 0.0, Functions.ConvertLength(1, this.SettingsEdit.LengthUnit, this.TotalLength_Main())) || this.DriverSetupEdit.TapPosition == Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.TapPositionBox.Text)))
        return;
      this.DriverSetupEdit.TapPosition = Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.TapPositionBox.Text));
      this.UpdateImage();
      this.SendValues();
    }

    private void StartAreaBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text)) != tlElement2.StartArea)
      {
        this.UpdateTaperRatio();
        tlElement2.StartArea = Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text));
        tlElement2.EndArea = Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text));
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    private void EndAreaBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text)) != tlElement2.EndArea & !Information.IsNothing((object) this.SelectedNode))
      {
        this.UpdateTaperRatio();
        tlElement2.StartArea = Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text));
        tlElement2.EndArea = Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text));
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    private void TaperRatioBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      this.UpdateTaperRatio();
      object tag = this.SelectedNode.Tag;
      TLElement tlElement = default;
      this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement) with
      {
        StartArea = Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text)),
        EndArea = Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text))
      });
      this.UpdateImage();
      this.SendValues();
      this.UpdateElementForm();
    }

    private void LengthBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.LengthBox.Text)) != tlElement2.Length & !Information.IsNothing((object) this.SelectedNode))
      {
        tlElement2.Length = Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.LengthBox.Text));
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    private void AngleBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (Conversions.ToDouble(this.AngleBox.Text) != tlElement2.Angle & !Information.IsNothing((object) this.SelectedNode))
      {
        tlElement2.Angle = Conversions.ToDouble(this.AngleBox.Text);
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    private void ToolStripRunButton_Click(object sender, EventArgs e)
    {
      this.UpdateElementFromActiveFormElement();
      MyProject.Forms.Form1.ReCalc();
    }

    private void UpdateElementFromActiveFormElement()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (this.LengthBox.Focused)
        tlElement2.Length = Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.LengthBox.Text));
      if (this.AngleBox.Focused)
        tlElement2.Angle = Conversions.ToDouble(this.AngleBox.Text);
      if (this.StartAreaBox.Focused | this.EndAreaBox.Focused | this.TaperRatioBox.Focused)
      {
        this.UpdateTaperRatio();
        tlElement2.StartArea = Functions.ConvertArea(this.SettingsEdit.StartAreaUnit, 1, Conversions.ToDouble(this.StartAreaBox.Text));
        tlElement2.EndArea = Functions.ConvertArea(this.SettingsEdit.EndAreaUnit, 1, Conversions.ToDouble(this.EndAreaBox.Text));
      }
      if (this.StuffingBox.Focused)
        tlElement2.StuffingDensity = Functions.ConvertDensity(this.SettingsEdit.DensityUnit, 1, Conversions.ToDouble(this.StuffingBox.Text));
      this.SelectedNode.Tag = (object) tlElement2;
      this.UpdateImage();
      this.SendValues();
      this.UpdateElementForm();
    }

    private void TaperTypeBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (this.TaperTypeBox.SelectedIndex >= 0 & this.TaperTypeBox.SelectedIndex <= 3)
      {
        tlElement2.Taper = checked (this.TaperTypeBox.SelectedIndex + 1);
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    private void StuffingBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (Conversions.ToDouble(this.StuffingBox.Text) != tlElement2.StuffingDensity)
      {
        tlElement2.StuffingDensity = Functions.ConvertDensity(this.SettingsEdit.DensityUnit, 1, Conversions.ToDouble(this.StuffingBox.Text));
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    private void GeometryDisplayClass_Load(object sender, EventArgs e)
    {
      this.ToolStripRearButton.Checked = this.SettingsEdit.ShowRear;
      this.ToolStripFrontButton.Checked = this.SettingsEdit.ShowFront;
      this.AutoUpdateButton.Checked = this.SettingsEdit.AutoUpdate;
      this.Width = this.SettingsEdit.GeometryWidth;
      this.Height = this.SettingsEdit.GeometryHeight;
      this.SplitContainer1.SplitterDistance = this.SettingsEdit.GeometrySplitterDistance;
      this.CollapseButton.Text = ">";
      this.CollapseButton.Location = new Point(checked (this.SplitContainer1.SplitterDistance - this.CollapseButton.Width), checked (25 + (int) Math.Round(unchecked ((double) checked (this.GeometryDisplayBox.Height - this.CollapseButton.Height) / 2.0))));
      this.UpdateImage();
    }

    private void GeometryDisplayBox_Resize(object sender, EventArgs e) => this.CollapseButton.Location = new Point(checked (0 + this.SplitContainer1.SplitterDistance - this.CollapseButton.Width), checked (25 + (int) Math.Round(unchecked ((double) checked (this.GeometryDisplayBox.Height - this.CollapseButton.Height) / 2.0))));

    private void GeometryDisplayClass_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.SettingsEdit.GeometryWidth = this.Width;
      this.SettingsEdit.GeometryHeight = this.Height;
      this.SettingsEdit.GeometrySplitterDistance = this.SplitContainer1.SplitterDistance;
      this.SendSettings();
    }

    private void AutoUpdateButton_Click(object sender, EventArgs e)
    {
      this.AutoUpdateButton.Checked = !this.AutoUpdateButton.Checked;
      this.SettingsEdit.AutoUpdate = this.AutoUpdateButton.Checked;
      this.SendSettings();
    }

    private void CollapseButton_Click(object sender, EventArgs e)
    {
      this.SplitContainer1.Panel2Collapsed = !this.SplitContainer1.Panel2Collapsed;
      if (this.SplitContainer1.Panel2Collapsed)
        this.CollapseButton.Text = "<";
      else
        this.CollapseButton.Text = ">";
    }

    private void RearModelTitle_Click(object sender, EventArgs e)
    {
      this.ShowRearModelInfo = !this.ShowRearModelInfo;
      if (this.ShowRearModelInfo)
      {
        this.RearModelTitle.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_down;
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.LengthLabel)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.VolumeLabel)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.WidthBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.DriverPositionBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.TapPositionBox)] = new RowStyle(SizeType.Absolute, 22f);
      }
      else
      {
        this.RearModelTitle.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_side;
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.LengthLabel)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.VolumeLabel)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.WidthBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.DriverPositionBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.TapPositionBox)] = new RowStyle(SizeType.Absolute, 0.0f);
      }
    }

    private void FrontModelTitle_Click(object sender, EventArgs e)
    {
      this.ShowFrontModelInfo = !this.ShowFrontModelInfo;
      if (this.ShowFrontModelInfo)
      {
        this.FrontModelTitle.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_down;
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.LengthLabel1)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.VolumeLabel1)] = new RowStyle(SizeType.Absolute, 22f);
      }
      else
      {
        this.FrontModelTitle.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_side;
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.LengthLabel1)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.VolumeLabel1)] = new RowStyle(SizeType.Absolute, 0.0f);
      }
    }

    private void ElementTitleLabel_Click(object sender, EventArgs e)
    {
      this.ShowElementInfo = !this.ShowElementInfo;
      if (this.ShowElementInfo)
      {
        this.ElementTitleLabel.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_down;
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.Label5)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.StartAreaBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.EndAreaBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.TaperRatioBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.TaperTypeBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.HypExpTBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.LengthBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.AngleBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.StuffingBox)] = new RowStyle(SizeType.Absolute, 22f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.ElementVolumeLabel)] = new RowStyle(SizeType.Absolute, 22f);
      }
      else
      {
        this.ElementTitleLabel.Image = (Image) TransmissionLine.My.Resources.Resources.blue_arrow_side;
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.Label5)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.StartAreaBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.EndAreaBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.TaperRatioBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.TaperTypeBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.HypExpTBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.LengthBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.AngleBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.StuffingBox)] = new RowStyle(SizeType.Absolute, 0.0f);
        this.TableLayoutPanel1.RowStyles[this.TableLayoutPanel1.GetRow((Control) this.ElementVolumeLabel)] = new RowStyle(SizeType.Absolute, 0.0f);
      }
    }

    private void ToolStripFrontButton_Click(object sender, EventArgs e)
    {
      this.ToolStripFrontButton.Checked = !this.ToolStripFrontButton.Checked;
      this.SettingsEdit.ShowFront = this.ToolStripFrontButton.Checked;
      this.UpdateImage();
    }

    private void ToolStripRearButton_Click(object sender, EventArgs e)
    {
      this.ToolStripRearButton.Checked = !this.ToolStripRearButton.Checked;
      this.SettingsEdit.ShowRear = this.ToolStripRearButton.Checked;
      this.UpdateImage();
    }

    private void KeyDownEvent(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Delete:
          e.Handled = true;
          this.DeleteElement();
          break;
        case Keys.C:
          e.Handled = true;
          if (MyProject.Computer.Keyboard.CtrlKeyDown)
          {
            this.CopyNodeSub();
            break;
          }
          this.ClosedBoundaryElement();
          break;
        case Keys.O:
          e.Handled = true;
          this.OpenBoundaryElement();
          break;
        case Keys.R:
          e.Handled = true;
          this.ReverseElement();
          break;
        case Keys.S:
          e.Handled = true;
          this.SplitElement();
          break;
        case Keys.V:
          if (!MyProject.Computer.Keyboard.CtrlKeyDown)
            break;
          e.Handled = true;
          this.PasteAfter();
          break;
        case Keys.Y:
          if (MyProject.Computer.Keyboard.CtrlKeyDown)
          {
            e.Handled = true;
            MyProject.Forms.Form1.Redo();
          }
          break;
        case Keys.Z:
          if (!MyProject.Computer.Keyboard.CtrlKeyDown)
            break;
          e.Handled = true;
          MyProject.Forms.Form1.Undo();
          break;
        case Keys.Add:
          this.SettingsEdit.GeometryScale -= 0.1f;
          e.Handled = true;
          this.UpdateImage();
          break;
        case Keys.Subtract:
          this.SettingsEdit.GeometryScale += 0.1f;
          e.Handled = true;
          this.UpdateImage();
          break;
      }
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      bool flag = false;
      if (this.GeometryDisplayBox.Focused)
      {
        switch (keyData)
        {
          case Keys.Left:
            this.SettingsEdit.GeometryPanRight -= 10f;
            flag = true;
            this.UpdateImage();
            break;
          case Keys.Up:
            this.SettingsEdit.GeometryPanUp -= 10f;
            flag = true;
            this.UpdateImage();
            break;
          case Keys.Right:
            this.SettingsEdit.GeometryPanRight += 10f;
            flag = true;
            this.UpdateImage();
            break;
          case Keys.Down:
            this.SettingsEdit.GeometryPanUp += 10f;
            flag = true;
            this.UpdateImage();
            break;
        }
      }
      return flag;
    }

    private void KeyDownEventForm(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.UpdateElementFromActiveFormElement();
      e.Handled = true;
    }

    private void WidthKeyDownEvent(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.TLGeometryEdit.Width = Functions.ConvertLength(this.SettingsEdit.EnclosureDepthUnit, 1, Conversions.ToDouble(this.WidthBox.Text));
      this.UpdateImage();
      e.Handled = true;
    }

    private void DriverPositionKeyDownEvent(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (Functions.ErrorCheckNum(this.DriverPositionBox.Text, 0.0, Functions.ConvertLength(1, this.SettingsEdit.LengthUnit, this.TotalLength_Main())) && this.DriverSetupEdit.DriverPosition != Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.DriverPositionBox.Text)))
      {
        this.DriverSetupEdit.DriverPosition = Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.DriverPositionBox.Text));
        this.UpdateImage();
        this.SendValues();
      }
      e.Handled = true;
    }

    private void TapPositionKeyDownEvent(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.DriverSetupEdit.TapPosition = Functions.ConvertLength(this.SettingsEdit.LengthUnit, 1, Conversions.ToDouble(this.TapPositionBox.Text));
      this.UpdateImage();
      e.Handled = true;
    }

    private void DeleteElement()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      this.SelectedNode.Parent.Nodes.RemoveAt(this.SelectedNode.Index);
      this.SelectedNode = (TreeNode) null;
      this.UpdateImage();
      this.SendValues();
    }

    private void OpenBoundaryElement()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement = default;
      this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement) with
      {
        OpenEnd = true
      });
      this.UpdateImage();
      this.SendValues();
    }

    private void ClosedBoundaryElement()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement = default;
      this.SelectedNode.Tag = (object) ((tag != null ? (TLElement) tag : tlElement) with
      {
        OpenEnd = false
      });
      this.UpdateImage();
      this.SendValues();
    }

    private void SplitElement()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      double num1 = 0.5;
      TreeNode treeNode = this.SelectedNode.Index != checked (this.SelectedNode.Parent.Nodes.Count - 1) ? this.SelectedNode.Parent.Nodes.Insert(checked (this.SelectedNode.Index + 1), "New Node") : this.SelectedNode.Parent.Nodes.Add("-");
      object tag1 = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
      TLElement tlElement3 = tlElement2;
      ref TLElement local1 = ref tlElement3;
      double num2 = 1.0 - num1;
      object tag2 = this.SelectedNode.Tag;
      double length1 = (tag2 != null ? (TLElement) tag2 : tlElement1).Length;
      double num3 = num2 * length1;
      local1.Length = num3;
      ref TLElement local2 = ref tlElement2;
      double num4 = num1;
      object tag3 = this.SelectedNode.Tag;
      double length2 = (tag3 != null ? (TLElement) tag3 : tlElement1).Length;
      double num5 = num4 * length2;
      local2.Length = num5;
      ref TLElement local3 = ref tlElement2;
      double startArea = tlElement2.StartArea;
      double endArea = tlElement3.EndArea;
      object tag4 = this.SelectedNode.Tag;
      double length3 = (tag4 != null ? (TLElement) tag4 : tlElement1).Length;
      double length4 = tlElement2.Length;
      int taper = tlElement2.Taper;
      double hypExpT = tlElement2.HypExpT;
      double num6 = Functions.PipeArea(startArea, endArea, length3, length4, taper, hypExpT);
      local3.EndArea = num6;
      tlElement3.StartArea = tlElement2.EndArea;
      treeNode.Tag = (object) tlElement3;
      this.SelectedNode.Tag = (object) tlElement2;
      this.UpdateImage();
      this.SendValues();
    }

    private void CopyNodeSub()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      this.CopyNode = (TreeNode) null;
      this.CopyNode = new TreeNode();
      this.CopyNode = (TreeNode) this.SelectedNode.Clone();
    }

    private void PasteAfter()
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !Information.IsNothing((object) this.CopyNode)))
        return;
      TreeNode treeNode = this.SelectedNode.Parent.Nodes.Insert(checked (this.SelectedNode.Index + 1), "New Node");
      treeNode.Tag = RuntimeHelpers.GetObjectValue(this.CopyNode.Tag);
      this.SelectedNode = treeNode;
      this.UpdateImage();
      this.SendValues();
    }

    private void PasteBefore()
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !Information.IsNothing((object) this.CopyNode)))
        return;
      TreeNode treeNode = this.SelectedNode.Parent.Nodes.Insert(this.SelectedNode.Index, "New Node");
      treeNode.Tag = RuntimeHelpers.GetObjectValue(this.CopyNode.Tag);
      this.SelectedNode = treeNode;
      this.UpdateImage();
      this.SendValues();
    }

    private void ReverseElement()
    {
      if (Information.IsNothing((object) this.SelectedNode))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      double startArea = tlElement2.StartArea;
      tlElement2.StartArea = tlElement2.EndArea;
      tlElement2.EndArea = startArea;
      this.SelectedNode.Tag = (object) tlElement2;
      this.UpdateImage();
      this.SendValues();
    }

    private void NewRearElement()
    {
      TreeNode n = this.TLGeometryEdit.RearEnclosure.Nodes.Add("-");
      TLElement defaultElement = this.DefaultElement;
      if (n.Index > 0)
      {
        ref TLElement local1 = ref defaultElement;
        object tag1 = n.PrevNode.Tag;
        TLElement tlElement = default;
        double endArea = (tag1 != null ? (TLElement) tag1 : tlElement).EndArea;
        local1.StartArea = endArea;
        defaultElement.EndArea = defaultElement.StartArea;
        ref TLElement local2 = ref defaultElement;
        object tag2 = n.PrevNode.Tag;
        double length = (tag2 != null ? (TLElement) tag2 : tlElement).Length;
        local2.Length = length;
        ref TLElement local3 = ref defaultElement;
        object tag3 = n.PrevNode.Tag;
        int num = (tag3 != null ? (TLElement) tag3 : tlElement).OpenEnd ? 1 : 0;
        local3.OpenEnd = num != 0;
        ref TLElement local4 = ref defaultElement;
        object tag4 = n.PrevNode.Tag;
        int taper = (tag4 != null ? (TLElement) tag4 : tlElement).Taper;
        local4.Taper = taper;
        ref TLElement local5 = ref defaultElement;
        object tag5 = n.PrevNode.Tag;
        double stuffingDensity = (tag5 != null ? (TLElement) tag5 : tlElement).StuffingDensity;
        local5.StuffingDensity = stuffingDensity;
      }
      defaultElement.Angle = n.Level % 2 != 0 ? 0.0 : 90.0;
      n.Tag = (object) defaultElement;
      n.Text = Functions.GetTreeString(n);
      this.SelectedNode = n;
      this.UpdateImage();
      this.SendValues();
    }

    private void NewFrontElement()
    {
      TreeNode n = this.TLGeometryEdit.FrontEnclosure.Nodes.Add("-");
      TLElement defaultElement = this.DefaultElement;
      if (n.Index > 0)
      {
        ref TLElement local1 = ref defaultElement;
        object tag1 = n.PrevNode.Tag;
        TLElement tlElement = default;
        double endArea = (tag1 != null ? (TLElement) tag1 : tlElement).EndArea;
        local1.StartArea = endArea;
        defaultElement.EndArea = defaultElement.StartArea;
        ref TLElement local2 = ref defaultElement;
        object tag2 = n.PrevNode.Tag;
        double length = (tag2 != null ? (TLElement) tag2 : tlElement).Length;
        local2.Length = length;
        ref TLElement local3 = ref defaultElement;
        object tag3 = n.PrevNode.Tag;
        int num = (tag3 != null ? (TLElement) tag3 : tlElement).OpenEnd ? 1 : 0;
        local3.OpenEnd = num != 0;
        ref TLElement local4 = ref defaultElement;
        object tag4 = n.PrevNode.Tag;
        int taper = (tag4 != null ? (TLElement) tag4 : tlElement).Taper;
        local4.Taper = taper;
        ref TLElement local5 = ref defaultElement;
        object tag5 = n.PrevNode.Tag;
        double stuffingDensity = (tag5 != null ? (TLElement) tag5 : tlElement).StuffingDensity;
        local5.StuffingDensity = stuffingDensity;
      }
      defaultElement.Angle = n.Level % 2 != 0 ? 0.0 : 90.0;
      n.Tag = (object) defaultElement;
      n.Text = Functions.GetTreeString(n);
      this.SelectedNode = n;
      this.UpdateImage();
      this.SendValues();
    }

    private void NewBranch()
    {
      if (Information.IsNothing((object) this.SelectedNode) || this.SelectedNode.Nodes.Count != 0)
        return;
      TreeNode treeNode = this.SelectedNode.Nodes.Add("-");
      object tag1 = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
      object tag2 = this.SelectedNode.Tag;
      if ((tag2 != null ? (TLElement) tag2 : tlElement1).Angle < 90.0)
      {
        ref TLElement local = ref tlElement2;
        object tag3 = this.SelectedNode.Tag;
        double num = (tag3 != null ? (TLElement) tag3 : tlElement1).Angle + 90.0;
        local.Angle = num;
      }
      else
      {
        ref TLElement local = ref tlElement2;
        object tag4 = this.SelectedNode.Tag;
        double num = (tag4 != null ? (TLElement) tag4 : tlElement1).Angle - 90.0;
        local.Angle = num;
      }
      treeNode.Tag = (object) tlElement2;
      this.SelectedNode = treeNode;
      this.UpdateImage();
      this.SendValues();
    }

    private void ResetView()
    {
      this.SettingsEdit.GeometryScale = 4f;
      this.SettingsEdit.GeometryPanUp = 170f;
      this.SettingsEdit.GeometryPanRight = 100f;
      this.SendSettings();
      this.UpdateImage();
    }

    private void OpenCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (this.SupressFormChangeDetection)
        return;
      if (this.OpenCheckBox.Checked)
        this.OpenBoundaryElement();
      else
        this.ClosedBoundaryElement();
    }

    private void GeometryDisplayBox_MouseWheel(object sender, MouseEventArgs e)
    {
      this.SettingsEdit.GeometryScale -= 0.005f * (float) e.Delta;
      if ((double) this.SettingsEdit.GeometryScale < 0.001)
        this.SettingsEdit.GeometryScale = 1f / 1000f;
      this.MouseStartLocation = e.Location;
      this.SendSettings();
      this.UpdateImage();
    }

    private void CheckDriverPosition()
    {
      double num = this.TotalLength_Main();
      if (num < this.DriverSetupEdit.DriverPosition)
        this.DriverSetupEdit.DriverPosition = num;
      if (num >= this.DriverSetupEdit.TapPosition)
        return;
      this.DriverSetupEdit.TapPosition = num;
    }

    public double TotalLength_Main()
    {
      double num1 = 0.0;
      try
      {
        foreach (TreeNode node in this.TLGeometryEdit.RearEnclosure.Nodes)
        {
          double num2 = num1;
          object tag = node.Tag;
          TLElement tlElement = default;
          double length = (tag != null ? (TLElement) tag : tlElement).Length;
          num1 = num2 + length;
        }
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return num1;
    }

    private void THButton_Click(object sender, EventArgs e)
    {
      this.THButton.Checked = !this.THButton.Checked;
      this.DriverSetupEdit.Tapped = this.THButton.Checked;
      this.ToolStripFrontButton.Enabled = !this.DriverSetupEdit.Tapped;
      this.TapPositionBox.Enabled = this.DriverSetupEdit.Tapped;
      if (this.DriverSetupEdit.Tapped)
      {
        this.ToolStripFrontButton.Checked = false;
        this.SettingsEdit.ShowFront = false;
      }
      this.UpdateImage();
      this.SendValues();
    }

    private void StraightToolStripMenuItem_Click(object sender, EventArgs e) => this.AutoTL(1.0);

    private void TaperedToolStripMenuItem_Click(object sender, EventArgs e) => this.AutoTL(0.2);

    private void ExpandingToolStripMenuItem_Click(object sender, EventArgs e) => this.AutoTL(5.0);

    private void SealedToolStripMenuItem_Click(object sender, EventArgs e) => this.AutoSealed(0.707);

    private void PortedToolStripMenuItem_Click(object sender, EventArgs e) => this.AutoPorted();

    private void AutoTL(double SlSo)
    {
      double num1 = 0.42 * this.DriverEdit.Fs * Math.Pow(this.DriverEdit.Qts, -0.9);
      double num2 = this.SettingsEdit.SpeedOfSound / (4.0 * num1);
      double num3 = (0.18 * Math.Log(SlSo) + 1.0) * num2;
      double num4 = 0.97144999999999992 * num1 * (-0.359 * Math.Log(SlSo) + 1.0);
      double num5 = -1.0574 * Math.Pow(this.DriverEdit.Qts, 3.0) + 2.0457 * Math.Pow(this.DriverEdit.Qts, 2.0) - 1.3797 * this.DriverEdit.Qts + 0.3886;
      double num6 = Functions.DensityofAir() * this.SettingsEdit.SpeedOfSound * Math.Pow(this.DriverEdit.Sd, 2.0) * num4 * num5 * this.DriverEdit.Re / Math.Pow(this.DriverEdit.get_Bl(this.SettingsEdit.SpeedOfSound), 2.0);
      double sl = SlSo * num6;
      double length = num3 - 0.6 * Math.Sqrt(sl / Math.PI);
      double depth = Math.Sqrt(num6);
      double driverpos = num3 / (0.0091 * Math.Pow(SlSo, 2.0) - 0.1314 * SlSo + 3.0988);
      this.Template(depth, length, num6, sl, driverpos, true);
    }

    private void AutoSealed(double Qtc)
    {
      if (Qtc < this.DriverEdit.Qts)
        Qtc = this.DriverEdit.Qts + 0.1;
      double num1 = Math.Pow(this.DriverEdit.Vas / (Math.Pow(Qtc / this.DriverEdit.Qts, 2.0) - 1.0), 1.0 / 3.0);
      double depth = num1;
      double num2 = Math.Pow(num1, 2.0);
      double driverpos = num1 / 2.0;
      this.Template(depth, num1, num2, num2, driverpos, false);
    }

    private void AutoBandPass()
    {
      double num1 = 0.707;
      double x1 = this.DriverEdit.Vas / (Math.Pow(num1 / this.DriverEdit.Qts, 2.0) - 1.0);
      this.SettingsEdit.ShowFront = true;
      this.SettingsEdit.ShowRear = true;
      this.THButton.Checked = false;
      this.DriverSetupEdit.Tapped = this.THButton.Checked;
      this.TapPositionBox.Enabled = this.DriverSetupEdit.Tapped;
      this.TLGeometryEdit.Width = Math.Pow(x1, 1.0 / 3.0);
      this.DriverSetupEdit.DriverPosition = 0.0;
      this.DriverSetupEdit.TapPosition = 1.0;
      TLElement tlElement1 = default;
      tlElement1.Length = Math.Pow(x1, 1.0 / 3.0);
      tlElement1.StartArea = Math.Pow(x1, 2.0 / 3.0);
      tlElement1.EndArea = Math.Pow(x1, 2.0 / 3.0);
      tlElement1.Taper = 1;
      tlElement1.StuffingDensity = 0.16;
      tlElement1.OpenEnd = false;
      tlElement1.Angle = 180.0;
      this.TLGeometryEdit.FrontEnclosure = new TreeNode();
      this.TLGeometryEdit.FrontEnclosure.Nodes.Clear();
      this.TLGeometryEdit.FrontEnclosure.Tag = (object) "Front";
      this.TLGeometryEdit.FrontEnclosure.Nodes.Add("").Tag = (object) tlElement1;
      double num2 = this.DriverEdit.Vas * Math.Pow(2.0 * num1 * this.DriverEdit.Qts, 2.0);
      double num3 = num1 * (this.DriverEdit.Fs / this.DriverEdit.Qts);
      TLElement tlElement2 = default;
      tlElement2.Length = num2 / Math.Pow(x1, 2.0 / 3.0);
      tlElement2.StartArea = Math.Pow(x1, 2.0 / 3.0);
      tlElement2.EndArea = Math.Pow(x1, 2.0 / 3.0);
      tlElement2.Taper = 1;
      tlElement2.StuffingDensity = 0.16;
      tlElement2.OpenEnd = false;
      double x2 = 0.5 * Math.Sqrt(this.DriverEdit.Sd / Math.PI);
      double num4 = Math.PI * Math.Pow(x2, 2.0);
      double num5 = Math.Pow(this.SettingsEdit.SpeedOfSound / (2.0 * Math.PI * num3), 2.0) * (num4 / num2) - 1.463 * x2;
      TLElement tlElement3 = default;
      tlElement3.Length = num5;
      tlElement3.StartArea = num4;
      tlElement3.EndArea = num4;
      tlElement3.Taper = 1;
      tlElement3.StuffingDensity = 0.16;
      tlElement3.OpenEnd = true;
      this.TLGeometryEdit.RearEnclosure = new TreeNode();
      this.TLGeometryEdit.RearEnclosure.Tag = (object) "Rear";
      this.TLGeometryEdit.RearEnclosure.Nodes.Clear();
      this.TLGeometryEdit.RearEnclosure.Nodes.Add("").Tag = (object) tlElement2;
      this.TLGeometryEdit.RearEnclosure.Nodes.Add("").Tag = (object) tlElement3;
      this.UpdateImage();
      this.SendValues();
    }

    private void AutoPorted()
    {
      double x1 = 15.0 * this.DriverEdit.Vas * Math.Pow(this.DriverEdit.Qts, 2.87);
      double num1 = 0.42 * this.DriverEdit.Fs * Math.Pow(this.DriverEdit.Qts, -0.9);
      double x2 = Math.Pow(x1, 1.0 / 3.0);
      double num2 = x2;
      double num3 = Math.Pow(x2, 2.0);
      double num4 = x2 / 2.0;
      this.THButton.Checked = false;
      this.DriverSetupEdit.Tapped = this.THButton.Checked;
      this.TapPositionBox.Enabled = this.DriverSetupEdit.Tapped;
      this.TLGeometryEdit.Width = num2;
      this.DriverSetupEdit.DriverPosition = num4;
      this.DriverSetupEdit.TapPosition = 1.0;
      TLElement tlElement = default;
      tlElement.Length = x2;
      tlElement.StartArea = num3;
      tlElement.EndArea = num3;
      tlElement.Taper = 1;
      tlElement.StuffingDensity = 0.16;
      tlElement.OpenEnd = false;
      this.TLGeometryEdit.FrontEnclosure = new TreeNode();
      this.TLGeometryEdit.FrontEnclosure.Nodes.Clear();
      this.TLGeometryEdit.FrontEnclosure.Tag = (object) "Front";
      this.TLGeometryEdit.RearEnclosure = new TreeNode();
      this.TLGeometryEdit.RearEnclosure.Tag = (object) "Rear";
      this.TLGeometryEdit.RearEnclosure.Nodes.Clear();
      this.TLGeometryEdit.RearEnclosure.Nodes.Add("").Tag = (object) tlElement;
      double x3 = Math.Sqrt(this.DriverEdit.Sd / Math.PI) * 0.5;
      double num5 = Math.PI * Math.Pow(x3, 2.0);
      double num6 = Math.Pow(this.SettingsEdit.SpeedOfSound / (2.0 * Math.PI * num1), 2.0) * (num5 / x1) - 1.463 * x3;
      tlElement.Length = num6;
      tlElement.StartArea = num5;
      tlElement.EndArea = num5;
      tlElement.Taper = 1;
      tlElement.StuffingDensity = 0.16;
      tlElement.OpenEnd = true;
      this.TLGeometryEdit.RearEnclosure.Nodes.Add("").Tag = (object) tlElement;
      this.UpdateImage();
      this.SendValues();
    }

    private void Template(
      double depth,
      double length,
      double so,
      double sl,
      double driverpos,
      bool open)
    {
      this.THButton.Checked = false;
      this.DriverSetupEdit.Tapped = this.THButton.Checked;
      this.TapPositionBox.Enabled = this.DriverSetupEdit.Tapped;
      this.TLGeometryEdit.Width = depth;
      this.DriverSetupEdit.DriverPosition = driverpos;
      this.DriverSetupEdit.TapPosition = 1.0;
      TLElement tlElement = default;
      tlElement.Length = length;
      tlElement.StartArea = so;
      tlElement.EndArea = sl;
      tlElement.Taper = 1;
      tlElement.HypExpT = 1.0;
      tlElement.StuffingDensity = 0.16;
      tlElement.OpenEnd = open;
      this.TLGeometryEdit.FrontEnclosure = new TreeNode();
      this.TLGeometryEdit.FrontEnclosure.Nodes.Clear();
      this.TLGeometryEdit.FrontEnclosure.Tag = (object) "Front";
      this.TLGeometryEdit.RearEnclosure = new TreeNode();
      this.TLGeometryEdit.RearEnclosure.Tag = (object) "Rear";
      this.TLGeometryEdit.RearEnclosure.Nodes.Clear();
      this.TLGeometryEdit.RearEnclosure.Nodes.Add("").Tag = (object) tlElement;
      this.UpdateImage();
      this.SendValues();
    }

    private void BandPassToolStripMenuItem_Click(object sender, EventArgs e) => this.AutoBandPass();

    private void HypExpTBox_LostFocus(object sender, EventArgs e)
    {
      if (!(!Information.IsNothing((object) this.SelectedNode) & !this.SupressFormChangeDetection))
        return;
      object tag = this.SelectedNode.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag != null ? (TLElement) tag : tlElement1;
      if (Conversions.ToDouble(this.HypExpTBox.Text) != tlElement2.HypExpT & !Information.IsNothing((object) this.SelectedNode))
      {
        tlElement2.HypExpT = Conversions.ToDouble(this.HypExpTBox.Text);
        this.SelectedNode.Tag = (object) tlElement2;
        this.UpdateImage();
        this.SendValues();
        this.UpdateElementForm();
      }
    }

    public enum HandleType
    {
      StartArea = 1,
      EndArea = 2,
      Rotate = 3,
      Length = 4,
      SplitRight = 5,
      SplitLeft = 6,
      Driver = 7,
      Tap = 8,
    }

    public struct HandleStruct
    {
      public bool Bool;
      public bool BoolClick;
      public GeometryDisplayClass.HandleType HandleType;

      public HandleStruct(
        bool myBool,
        bool myBoolClick,
        GeometryDisplayClass.HandleType myHandleType)
        : this()
      {
        this.Bool = myBool;
        this.BoolClick = myBoolClick;
        this.HandleType = myHandleType;
      }
    }

    public delegate void TLParameterUpdatedEventHandler(
      object Sender,
      TLParameterUpdatedEventArgs e);

    public delegate void SettingsUpdatedEventHandler(object Sender, SettingsUpdatedEventArgs e);
  }
}
