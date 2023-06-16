// Decompiled with JetBrains decompiler
// Type: TransmissionLine.Form1
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using TransmissionLine.My;

namespace TransmissionLine
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("FileToolStripMenuItem")]
    private ToolStripMenuItem _FileToolStripMenuItem;
    [AccessedThroughProperty("HelpToolStripMenuItem")]
    private ToolStripMenuItem _HelpToolStripMenuItem;
    [AccessedThroughProperty("WindowToolStripMenuItem")]
    private ToolStripMenuItem _WindowToolStripMenuItem;
    [AccessedThroughProperty("DriverToolStripMenuItem")]
    private ToolStripMenuItem _DriverToolStripMenuItem;
    [AccessedThroughProperty("AmplifierToolStripMenuItem")]
    private ToolStripMenuItem _AmplifierToolStripMenuItem;
    [AccessedThroughProperty("AboutToolStripMenuItem")]
    private ToolStripMenuItem _AboutToolStripMenuItem;
    [AccessedThroughProperty("ExitToolStripMenuItem")]
    private ToolStripMenuItem _ExitToolStripMenuItem;
    [AccessedThroughProperty("GeometryViewerToolStripMenuItem")]
    private ToolStripMenuItem _GeometryViewerToolStripMenuItem;
    [AccessedThroughProperty("ToolsToolStripMenuItem")]
    private ToolStripMenuItem _ToolsToolStripMenuItem;
    [AccessedThroughProperty("SettingsToolStripMenuItem")]
    private ToolStripMenuItem _SettingsToolStripMenuItem;
    [AccessedThroughProperty("SaveProjectToolStripMenuItem")]
    private ToolStripMenuItem _SaveProjectToolStripMenuItem;
    [AccessedThroughProperty("SaveProjectAsToolStripMenuItem")]
    private ToolStripMenuItem _SaveProjectAsToolStripMenuItem;
    [AccessedThroughProperty("OpenProjectToolStripMenuItem")]
    private ToolStripMenuItem _OpenProjectToolStripMenuItem;
    [AccessedThroughProperty("NewProjectToolStripMenuItem")]
    private ToolStripMenuItem _NewProjectToolStripMenuItem;
    [AccessedThroughProperty("EditToolStripMenuItem")]
    private ToolStripMenuItem _EditToolStripMenuItem;
    [AccessedThroughProperty("UndoToolStripMenuItem")]
    private ToolStripMenuItem _UndoToolStripMenuItem;
    [AccessedThroughProperty("RedoToolStripMenuItem")]
    private ToolStripMenuItem _RedoToolStripMenuItem;
    [AccessedThroughProperty("GraphTab")]
    private TabControl _GraphTab;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("SystemCheck")]
    private CheckBox _SystemCheck;
    [AccessedThroughProperty("TerminusCheck")]
    private CheckBox _TerminusCheck;
    [AccessedThroughProperty("DriverCheck")]
    private CheckBox _DriverCheck;
    [AccessedThroughProperty("IBCheck")]
    private CheckBox _IBCheck;
    [AccessedThroughProperty("LpDisplay")]
    private PictureBox _LpDisplay;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _TabPage2;
    [AccessedThroughProperty("ZrDisplay")]
    private PictureBox _ZrDisplay;
    [AccessedThroughProperty("ZasDisplay")]
    private PictureBox _ZasDisplay;
    [AccessedThroughProperty("ZiDisplay")]
    private PictureBox _ZiDisplay;
    [AccessedThroughProperty("ZtDisplay")]
    private PictureBox _ZtDisplay;
    [AccessedThroughProperty("TabPage4")]
    private TabPage _TabPage4;
    [AccessedThroughProperty("DisplaceDisplay")]
    private PictureBox _DisplaceDisplay;
    [AccessedThroughProperty("TabPage5")]
    private TabPage _TabPage5;
    [AccessedThroughProperty("VelocityDisplay")]
    private PictureBox _VelocityDisplay;
    [AccessedThroughProperty("TabPage6")]
    private TabPage _TabPage6;
    [AccessedThroughProperty("GroupDelayDisplay")]
    private PictureBox _GroupDelayDisplay;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("ToolStripProgressBar")]
    private ToolStripProgressBar _ToolStripProgressBar;
    [AccessedThroughProperty("FrequencyLabel")]
    private ToolStripStatusLabel _FrequencyLabel;
    [AccessedThroughProperty("ToolStripFreqLabel")]
    private ToolStripStatusLabel _ToolStripFreqLabel;
    [AccessedThroughProperty("ToolStrip1")]
    private ToolStrip _ToolStrip1;
    [AccessedThroughProperty("ToolStripRunButton")]
    private ToolStripButton _ToolStripRunButton;
    [AccessedThroughProperty("ToolStripNewProject")]
    private ToolStripButton _ToolStripNewProject;
    [AccessedThroughProperty("ToolStripSave")]
    private ToolStripButton _ToolStripSave;
    [AccessedThroughProperty("ToolStripUndo")]
    private ToolStripButton _ToolStripUndo;
    [AccessedThroughProperty("ToolStripRedo")]
    private ToolStripButton _ToolStripRedo;
    [AccessedThroughProperty("ToolStripOpenProject")]
    private ToolStripButton _ToolStripOpenProject;
    [AccessedThroughProperty("ToolStripSaveAs")]
    private ToolStripButton _ToolStripSaveAs;
    [AccessedThroughProperty("MenuStrip1")]
    private MenuStrip _MenuStrip1;
    [AccessedThroughProperty("ToolStripMenuItem1")]
    private ToolStripMenuItem _ToolStripMenuItem1;
    [AccessedThroughProperty("ToolStripSeparator6")]
    private ToolStripSeparator _ToolStripSeparator6;
    [AccessedThroughProperty("ToolStripSeparator7")]
    private ToolStripSeparator _ToolStripSeparator7;
    [AccessedThroughProperty("ToolStripSeparator8")]
    private ToolStripSeparator _ToolStripSeparator8;
    [AccessedThroughProperty("ToolStripButton1")]
    private ToolStripButton _ToolStripButton1;
    [AccessedThroughProperty("ToolStripSeparator9")]
    private ToolStripSeparator _ToolStripSeparator9;
    [AccessedThroughProperty("ToolStripSeparator10")]
    private ToolStripSeparator _ToolStripSeparator10;
    [AccessedThroughProperty("ToolStripSeparator11")]
    private ToolStripSeparator _ToolStripSeparator11;
    [AccessedThroughProperty("ToolStripSeparator1")]
    private ToolStripSeparator _ToolStripSeparator1;
    [AccessedThroughProperty("RecentFilesToolStripMenuItem")]
    private ToolStripMenuItem _RecentFilesToolStripMenuItem;
    [AccessedThroughProperty("TabPage3")]
    private TabPage _TabPage3;
    [AccessedThroughProperty("LpPhaseDisplay")]
    private PictureBox _LpPhaseDisplay;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("FilterToolStripMenuItem")]
    private ToolStripMenuItem _FilterToolStripMenuItem;
    [AccessedThroughProperty("HelpToolStripMenuItem1")]
    private ToolStripMenuItem _HelpToolStripMenuItem1;
    private bool FormLoaded;
    private FormWindowState PreviousWindowState;
    private Complex[] UTerminus;
    private double[] TerminusArea;
    private bool Open;
    private bool Saved;
    private string SelectedElement;
    private TLParameters TLGeometryCalc;
    public double JHMin;
    public double JHMax;
    public int JHSteps;
    public double[] J1Array;
    public double[] H1Array;
    private bool LeftMouseButtonPress;
    private TLParameters TLParameter;
    private DriverParameters DriverParameter;
    private AmplifierParameters AmplifierParameter;
    private DriverSetup DriverSetupParameter;
    private SettingsParameters SettingsParameter;
    private FilterParameters FilterParameter;
    private bool DataBool;
    private int Points;
    private Complex[] Zr;
    private Complex[] ZiRear;
    private Complex[] ZiFront;
    private Complex[] Zes;
    private Complex[] Zt;
    private Complex[] pd;
    private Complex[] pl;
    private Complex[] pi;
    private double[] Displacei;
    private double[] Displaced;
    private double[,] VelocityMultiL;
    private myGraphClass SPLGraph;
    private myGraphClass ZiGraph;
    private myGraphClass ZesGraph;
    private myGraphClass ZrGraph;
    private myGraphClass ZtGraph;
    private myGraphClass PhaseGraph;
    private myGraphClass DisplaceGraph;
    private myGraphClass VelocityGraph;
    private myGraphClass GroupDelayGraph;
    private int LeftMargin;
    private int RightMargin;
    private int BottomMargin;
    private int TopMargin;
    private double[] XSeries;
    private GraphSeries ZiData;
    private GraphSeries ZesData;
    private GraphSeries ZrData;
    private GraphSeries ZtData;
    private GraphSeries PhaseData;
    private GraphSeries DisplaceData;
    private GraphSeries VelocityData;
    private GraphSeries GroupDelayData;
    private GraphSeries LPData;
    private int LpGraphNum;
    private int GroupDelayGraphNum;
    private int DisplaceGraphNum;
    [AccessedThroughProperty("uxEditDriver")]
    private DriverClass _uxEditDriver;
    [AccessedThroughProperty("uxEditAmplifier")]
    private AmplifierClass _uxEditAmplifier;
    [AccessedThroughProperty("uxGeometryDisplay")]
    private GeometryDisplayClass _uxGeometryDisplay;
    [AccessedThroughProperty("uxSettingsDialog")]
    private SettingsClass _uxSettingsDialog;
    [AccessedThroughProperty("uxEditFilter")]
    private FilterClass _uxEditFilter;
    private string CurrentFile;
    private string[] UndoStack;
    private string[] RedoStack;
    private int UndoStackPosition;
    private int RedoStackPosition;
    private string CurrentState;

    [DebuggerNonUserCode]
    static Form1()
    {
    }

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.Shown += new EventHandler(this.Form1_Shown);
      this.ResizeEnd += new EventHandler(this.Form1_ResizeEnd);
      this.Resize += new EventHandler(this.Form1_Resize);
      Form1.__ENCAddToList((object) this);
      this.FormLoaded = false;
      this.PreviousWindowState = FormWindowState.Normal;
      this.JHMin = 0.001;
      this.JHMax = 1000.0;
      this.JHSteps = 2000;
      this.J1Array = new double[checked (this.JHSteps + 1)];
      this.H1Array = new double[checked (this.JHSteps + 1)];
      this.LeftMouseButtonPress = false;
      this.DataBool = false;
      this.Points = 1000;
      this.Zr = new Complex[checked (this.Points + 1)];
      this.ZiRear = new Complex[checked (this.Points + 1)];
      this.ZiFront = new Complex[checked (this.Points + 1)];
      this.Zes = new Complex[checked (this.Points + 1)];
      this.Zt = new Complex[checked (this.Points + 1)];
      this.pd = new Complex[checked (this.Points + 1)];
      this.pl = new Complex[checked (this.Points + 1)];
      this.pi = new Complex[checked (this.Points + 1)];
      this.Displacei = new double[checked (this.Points + 1)];
      this.Displaced = new double[checked (this.Points + 1)];
      this.VelocityMultiL = new double[checked (this.Points + 1), 1];
      this.LeftMargin = 5;
      this.RightMargin = 15;
      this.BottomMargin = 10;
      this.TopMargin = 5;
      this.XSeries = new double[checked (this.Points + 1)];
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Form1.__ENCList)
      {
        if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (Form1.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (Form1.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Form1.__ENCList[index1] = Form1.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Form1.__ENCList.RemoveRange(index1, checked (Form1.__ENCList.Count - index1));
          Form1.__ENCList.Capacity = Form1.__ENCList.Count;
        }
        Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.FileToolStripMenuItem = new ToolStripMenuItem();
      this.NewProjectToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator6 = new ToolStripSeparator();
      this.OpenProjectToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator7 = new ToolStripSeparator();
      this.SaveProjectToolStripMenuItem = new ToolStripMenuItem();
      this.SaveProjectAsToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator1 = new ToolStripSeparator();
      this.RecentFilesToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator8 = new ToolStripSeparator();
      this.ExitToolStripMenuItem = new ToolStripMenuItem();
      this.EditToolStripMenuItem = new ToolStripMenuItem();
      this.UndoToolStripMenuItem = new ToolStripMenuItem();
      this.RedoToolStripMenuItem = new ToolStripMenuItem();
      this.ToolsToolStripMenuItem = new ToolStripMenuItem();
      this.SettingsToolStripMenuItem = new ToolStripMenuItem();
      this.WindowToolStripMenuItem = new ToolStripMenuItem();
      this.DriverToolStripMenuItem = new ToolStripMenuItem();
      this.AmplifierToolStripMenuItem = new ToolStripMenuItem();
      this.GeometryViewerToolStripMenuItem = new ToolStripMenuItem();
      this.FilterToolStripMenuItem = new ToolStripMenuItem();
      this.HelpToolStripMenuItem = new ToolStripMenuItem();
      this.AboutToolStripMenuItem = new ToolStripMenuItem();
      this.GraphTab = new TabControl();
      this.TabPage1 = new TabPage();
      this.LpDisplay = new PictureBox();
      this.TabPage3 = new TabPage();
      this.LpPhaseDisplay = new PictureBox();
      this.TabPage2 = new TabPage();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.ZasDisplay = new PictureBox();
      this.ZiDisplay = new PictureBox();
      this.ZtDisplay = new PictureBox();
      this.ZrDisplay = new PictureBox();
      this.TabPage4 = new TabPage();
      this.DisplaceDisplay = new PictureBox();
      this.TabPage5 = new TabPage();
      this.VelocityDisplay = new PictureBox();
      this.TabPage6 = new TabPage();
      this.GroupDelayDisplay = new PictureBox();
      this.SystemCheck = new CheckBox();
      this.TerminusCheck = new CheckBox();
      this.DriverCheck = new CheckBox();
      this.IBCheck = new CheckBox();
      this.StatusStrip1 = new StatusStrip();
      this.ToolStripProgressBar = new ToolStripProgressBar();
      this.ToolStripFreqLabel = new ToolStripStatusLabel();
      this.FrequencyLabel = new ToolStripStatusLabel();
      this.ToolStrip1 = new ToolStrip();
      this.ToolStripNewProject = new ToolStripButton();
      this.ToolStripOpenProject = new ToolStripButton();
      this.ToolStripSeparator9 = new ToolStripSeparator();
      this.ToolStripSave = new ToolStripButton();
      this.ToolStripSaveAs = new ToolStripButton();
      this.ToolStripSeparator10 = new ToolStripSeparator();
      this.ToolStripUndo = new ToolStripButton();
      this.ToolStripRedo = new ToolStripButton();
      this.ToolStripSeparator11 = new ToolStripSeparator();
      this.ToolStripRunButton = new ToolStripButton();
      this.MenuStrip1 = new MenuStrip();
      this.ToolStripMenuItem1 = new ToolStripMenuItem();
      this.ToolStripButton1 = new ToolStripButton();
      this.Panel1 = new Panel();
      this.HelpToolStripMenuItem1 = new ToolStripMenuItem();
      this.GraphTab.SuspendLayout();
      this.TabPage1.SuspendLayout();
      ((ISupportInitialize) this.LpDisplay).BeginInit();
      this.TabPage3.SuspendLayout();
      ((ISupportInitialize) this.LpPhaseDisplay).BeginInit();
      this.TabPage2.SuspendLayout();
      this.TableLayoutPanel1.SuspendLayout();
      ((ISupportInitialize) this.ZasDisplay).BeginInit();
      ((ISupportInitialize) this.ZiDisplay).BeginInit();
      ((ISupportInitialize) this.ZtDisplay).BeginInit();
      ((ISupportInitialize) this.ZrDisplay).BeginInit();
      this.TabPage4.SuspendLayout();
      ((ISupportInitialize) this.DisplaceDisplay).BeginInit();
      this.TabPage5.SuspendLayout();
      ((ISupportInitialize) this.VelocityDisplay).BeginInit();
      this.TabPage6.SuspendLayout();
      ((ISupportInitialize) this.GroupDelayDisplay).BeginInit();
      this.StatusStrip1.SuspendLayout();
      this.ToolStrip1.SuspendLayout();
      this.MenuStrip1.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.NewProjectToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator6,
        (ToolStripItem) this.OpenProjectToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator7,
        (ToolStripItem) this.SaveProjectToolStripMenuItem,
        (ToolStripItem) this.SaveProjectAsToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.RecentFilesToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator8,
        (ToolStripItem) this.ExitToolStripMenuItem
      });
      this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.FileToolStripMenuItem;
      Size size1 = new Size(37, 20);
      Size size2 = size1;
      toolStripMenuItem1.Size = size2;
      this.FileToolStripMenuItem.Text = "File";
      this.NewProjectToolStripMenuItem.BackColor = SystemColors.Control;
      this.NewProjectToolStripMenuItem.Image = (Image) TransmissionLine.My.Resources.Resources._new;
      this.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem";
      this.NewProjectToolStripMenuItem.ShortcutKeys = Keys.N | Keys.Control;
      ToolStripMenuItem toolStripMenuItem2 = this.NewProjectToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size3 = size1;
      toolStripMenuItem2.Size = size3;
      this.NewProjectToolStripMenuItem.Text = "New Project";
      this.ToolStripSeparator6.Name = "ToolStripSeparator6";
      ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator6;
      size1 = new Size(223, 6);
      Size size4 = size1;
      toolStripSeparator6.Size = size4;
      this.OpenProjectToolStripMenuItem.BackColor = SystemColors.Control;
      this.OpenProjectToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("OpenProjectToolStripMenuItem.Image");
      this.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
      this.OpenProjectToolStripMenuItem.ShortcutKeyDisplayString = "";
      this.OpenProjectToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Control;
      ToolStripMenuItem toolStripMenuItem3 = this.OpenProjectToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size5 = size1;
      toolStripMenuItem3.Size = size5;
      this.OpenProjectToolStripMenuItem.Text = "Open Project";
      this.ToolStripSeparator7.Name = "ToolStripSeparator7";
      ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator7;
      size1 = new Size(223, 6);
      Size size6 = size1;
      toolStripSeparator7.Size = size6;
      this.SaveProjectToolStripMenuItem.BackColor = SystemColors.Control;
      this.SaveProjectToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("SaveProjectToolStripMenuItem.Image");
      this.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem";
      this.SaveProjectToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Control;
      ToolStripMenuItem toolStripMenuItem4 = this.SaveProjectToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size7 = size1;
      toolStripMenuItem4.Size = size7;
      this.SaveProjectToolStripMenuItem.Text = "Save Project";
      this.SaveProjectAsToolStripMenuItem.BackColor = SystemColors.Control;
      this.SaveProjectAsToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("SaveProjectAsToolStripMenuItem.Image");
      this.SaveProjectAsToolStripMenuItem.Name = "SaveProjectAsToolStripMenuItem";
      this.SaveProjectAsToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Shift | Keys.Control;
      ToolStripMenuItem toolStripMenuItem5 = this.SaveProjectAsToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size8 = size1;
      toolStripMenuItem5.Size = size8;
      this.SaveProjectAsToolStripMenuItem.Text = "Save Project As";
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
      size1 = new Size(223, 6);
      Size size9 = size1;
      toolStripSeparator1.Size = size9;
      this.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem6 = this.RecentFilesToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size10 = size1;
      toolStripMenuItem6.Size = size10;
      this.RecentFilesToolStripMenuItem.Text = "Recent Files";
      this.ToolStripSeparator8.Name = "ToolStripSeparator8";
      ToolStripSeparator toolStripSeparator8 = this.ToolStripSeparator8;
      size1 = new Size(223, 6);
      Size size11 = size1;
      toolStripSeparator8.Size = size11;
      this.ExitToolStripMenuItem.BackColor = SystemColors.Control;
      this.ExitToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("ExitToolStripMenuItem.Image");
      this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
      this.ExitToolStripMenuItem.ShortcutKeys = Keys.F4 | Keys.Alt;
      ToolStripMenuItem toolStripMenuItem7 = this.ExitToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size12 = size1;
      toolStripMenuItem7.Size = size12;
      this.ExitToolStripMenuItem.Text = "Exit";
      this.EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.UndoToolStripMenuItem,
        (ToolStripItem) this.RedoToolStripMenuItem
      });
      this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem8 = this.EditToolStripMenuItem;
      size1 = new Size(39, 20);
      Size size13 = size1;
      toolStripMenuItem8.Size = size13;
      this.EditToolStripMenuItem.Text = "Edit";
      this.UndoToolStripMenuItem.BackColor = SystemColors.Control;
      this.UndoToolStripMenuItem.Image = (Image) TransmissionLine.My.Resources.Resources.undo;
      this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
      this.UndoToolStripMenuItem.ShortcutKeys = Keys.Z | Keys.Control;
      ToolStripMenuItem toolStripMenuItem9 = this.UndoToolStripMenuItem;
      size1 = new Size(144, 22);
      Size size14 = size1;
      toolStripMenuItem9.Size = size14;
      this.UndoToolStripMenuItem.Text = "Undo";
      this.RedoToolStripMenuItem.BackColor = SystemColors.Control;
      this.RedoToolStripMenuItem.Image = (Image) TransmissionLine.My.Resources.Resources.redo;
      this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
      this.RedoToolStripMenuItem.ShortcutKeys = Keys.Y | Keys.Control;
      ToolStripMenuItem toolStripMenuItem10 = this.RedoToolStripMenuItem;
      size1 = new Size(144, 22);
      Size size15 = size1;
      toolStripMenuItem10.Size = size15;
      this.RedoToolStripMenuItem.Text = "Redo";
      this.ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.SettingsToolStripMenuItem
      });
      this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem11 = this.ToolsToolStripMenuItem;
      size1 = new Size(48, 20);
      Size size16 = size1;
      toolStripMenuItem11.Size = size16;
      this.ToolsToolStripMenuItem.Text = "Tools";
      this.SettingsToolStripMenuItem.BackColor = SystemColors.Control;
      this.SettingsToolStripMenuItem.Image = (Image) TransmissionLine.My.Resources.Resources.settings;
      this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem12 = this.SettingsToolStripMenuItem;
      size1 = new Size(116, 22);
      Size size17 = size1;
      toolStripMenuItem12.Size = size17;
      this.SettingsToolStripMenuItem.Text = "Settings";
      this.WindowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.DriverToolStripMenuItem,
        (ToolStripItem) this.AmplifierToolStripMenuItem,
        (ToolStripItem) this.GeometryViewerToolStripMenuItem,
        (ToolStripItem) this.FilterToolStripMenuItem
      });
      this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem13 = this.WindowToolStripMenuItem;
      size1 = new Size(63, 20);
      Size size18 = size1;
      toolStripMenuItem13.Size = size18;
      this.WindowToolStripMenuItem.Text = "Window";
      this.DriverToolStripMenuItem.BackColor = SystemColors.Control;
      this.DriverToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("DriverToolStripMenuItem.Image");
      this.DriverToolStripMenuItem.Name = "DriverToolStripMenuItem";
      this.DriverToolStripMenuItem.ShortcutKeys = Keys.D | Keys.Control | Keys.Alt;
      ToolStripMenuItem toolStripMenuItem14 = this.DriverToolStripMenuItem;
      size1 = new Size(190, 22);
      Size size19 = size1;
      toolStripMenuItem14.Size = size19;
      this.DriverToolStripMenuItem.Text = "Driver";
      this.AmplifierToolStripMenuItem.BackColor = SystemColors.Control;
      this.AmplifierToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("AmplifierToolStripMenuItem.Image");
      this.AmplifierToolStripMenuItem.Name = "AmplifierToolStripMenuItem";
      this.AmplifierToolStripMenuItem.ShortcutKeys = Keys.A | Keys.Control | Keys.Alt;
      ToolStripMenuItem toolStripMenuItem15 = this.AmplifierToolStripMenuItem;
      size1 = new Size(190, 22);
      Size size20 = size1;
      toolStripMenuItem15.Size = size20;
      this.AmplifierToolStripMenuItem.Text = "Amplifier";
      this.GeometryViewerToolStripMenuItem.BackColor = SystemColors.Control;
      this.GeometryViewerToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("GeometryViewerToolStripMenuItem.Image");
      this.GeometryViewerToolStripMenuItem.Name = "GeometryViewerToolStripMenuItem";
      this.GeometryViewerToolStripMenuItem.ShortcutKeys = Keys.G | Keys.Control | Keys.Alt;
      ToolStripMenuItem toolStripMenuItem16 = this.GeometryViewerToolStripMenuItem;
      size1 = new Size(190, 22);
      Size size21 = size1;
      toolStripMenuItem16.Size = size21;
      this.GeometryViewerToolStripMenuItem.Text = "Enclosure";
      this.FilterToolStripMenuItem.Image = (Image) TransmissionLine.My.Resources.Resources.filter;
      this.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem";
      this.FilterToolStripMenuItem.ShortcutKeys = Keys.F | Keys.Control | Keys.Alt;
      ToolStripMenuItem toolStripMenuItem17 = this.FilterToolStripMenuItem;
      size1 = new Size(190, 22);
      Size size22 = size1;
      toolStripMenuItem17.Size = size22;
      this.FilterToolStripMenuItem.Text = "Filter";
      this.HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.HelpToolStripMenuItem1,
        (ToolStripItem) this.AboutToolStripMenuItem
      });
      this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem18 = this.HelpToolStripMenuItem;
      size1 = new Size(44, 20);
      Size size23 = size1;
      toolStripMenuItem18.Size = size23;
      this.HelpToolStripMenuItem.Text = "Help";
      this.AboutToolStripMenuItem.BackColor = SystemColors.Control;
      this.AboutToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("AboutToolStripMenuItem.Image");
      this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem19 = this.AboutToolStripMenuItem;
      size1 = new Size(152, 22);
      Size size24 = size1;
      toolStripMenuItem19.Size = size24;
      this.AboutToolStripMenuItem.Text = "About";
      this.GraphTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.GraphTab.Controls.Add((Control) this.TabPage1);
      this.GraphTab.Controls.Add((Control) this.TabPage3);
      this.GraphTab.Controls.Add((Control) this.TabPage2);
      this.GraphTab.Controls.Add((Control) this.TabPage4);
      this.GraphTab.Controls.Add((Control) this.TabPage5);
      this.GraphTab.Controls.Add((Control) this.TabPage6);
      TabControl graphTab1 = this.GraphTab;
      Point point1 = new Point(0, 75);
      Point point2 = point1;
      graphTab1.Location = point2;
      this.GraphTab.Name = "GraphTab";
      this.GraphTab.SelectedIndex = 0;
      TabControl graphTab2 = this.GraphTab;
      size1 = new Size(499, 399);
      Size size25 = size1;
      graphTab2.Size = size25;
      this.GraphTab.TabIndex = 13;
      this.TabPage1.Controls.Add((Control) this.LpDisplay);
      TabPage tabPage1_1 = this.TabPage1;
      point1 = new Point(4, 22);
      Point point3 = point1;
      tabPage1_1.Location = point3;
      this.TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = this.TabPage1;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      tabPage1_2.Padding = padding2;
      TabPage tabPage1_3 = this.TabPage1;
      size1 = new Size(491, 373);
      Size size26 = size1;
      tabPage1_3.Size = size26;
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "SPL";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.LpDisplay.BackColor = Color.White;
      this.LpDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.LpDisplay.Dock = DockStyle.Fill;
      PictureBox lpDisplay1 = this.LpDisplay;
      point1 = new Point(3, 3);
      Point point4 = point1;
      lpDisplay1.Location = point4;
      this.LpDisplay.Name = "LpDisplay";
      PictureBox lpDisplay2 = this.LpDisplay;
      size1 = new Size(485, 367);
      Size size27 = size1;
      lpDisplay2.Size = size27;
      this.LpDisplay.TabIndex = 10;
      this.LpDisplay.TabStop = false;
      this.TabPage3.Controls.Add((Control) this.LpPhaseDisplay);
      TabPage tabPage3_1 = this.TabPage3;
      point1 = new Point(4, 22);
      Point point5 = point1;
      tabPage3_1.Location = point5;
      this.TabPage3.Name = "TabPage3";
      TabPage tabPage3_2 = this.TabPage3;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      tabPage3_2.Padding = padding3;
      TabPage tabPage3_3 = this.TabPage3;
      size1 = new Size(491, 373);
      Size size28 = size1;
      tabPage3_3.Size = size28;
      this.TabPage3.TabIndex = 6;
      this.TabPage3.Text = "Phase";
      this.TabPage3.UseVisualStyleBackColor = true;
      this.LpPhaseDisplay.BackColor = Color.White;
      this.LpPhaseDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.LpPhaseDisplay.Dock = DockStyle.Fill;
      PictureBox lpPhaseDisplay1 = this.LpPhaseDisplay;
      point1 = new Point(3, 3);
      Point point6 = point1;
      lpPhaseDisplay1.Location = point6;
      this.LpPhaseDisplay.Name = "LpPhaseDisplay";
      PictureBox lpPhaseDisplay2 = this.LpPhaseDisplay;
      size1 = new Size(485, 367);
      Size size29 = size1;
      lpPhaseDisplay2.Size = size29;
      this.LpPhaseDisplay.TabIndex = 12;
      this.LpPhaseDisplay.TabStop = false;
      this.TabPage2.Controls.Add((Control) this.TableLayoutPanel1);
      TabPage tabPage2_1 = this.TabPage2;
      point1 = new Point(4, 22);
      Point point7 = point1;
      tabPage2_1.Location = point7;
      this.TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = this.TabPage2;
      padding1 = new Padding(3);
      Padding padding4 = padding1;
      tabPage2_2.Padding = padding4;
      TabPage tabPage2_3 = this.TabPage2;
      size1 = new Size(491, 373);
      Size size30 = size1;
      tabPage2_3.Size = size30;
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Impedance";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.Controls.Add((Control) this.ZasDisplay, 1, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.ZiDisplay, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.ZtDisplay, 1, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.ZrDisplay, 0, 0);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      point1 = new Point(3, 3);
      Point point8 = point1;
      tableLayoutPanel1_1.Location = point8;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 2;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      size1 = new Size(485, 367);
      Size size31 = size1;
      tableLayoutPanel1_2.Size = size31;
      this.TableLayoutPanel1.TabIndex = 0;
      this.ZasDisplay.BackColor = Color.White;
      this.ZasDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.ZasDisplay.Dock = DockStyle.Fill;
      PictureBox zasDisplay1 = this.ZasDisplay;
      point1 = new Point(245, 3);
      Point point9 = point1;
      zasDisplay1.Location = point9;
      this.ZasDisplay.Name = "ZasDisplay";
      PictureBox zasDisplay2 = this.ZasDisplay;
      size1 = new Size(237, 177);
      Size size32 = size1;
      zasDisplay2.Size = size32;
      this.ZasDisplay.TabIndex = 7;
      this.ZasDisplay.TabStop = false;
      this.ZiDisplay.BackColor = Color.White;
      this.ZiDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.ZiDisplay.Dock = DockStyle.Fill;
      PictureBox ziDisplay1 = this.ZiDisplay;
      point1 = new Point(3, 186);
      Point point10 = point1;
      ziDisplay1.Location = point10;
      this.ZiDisplay.Name = "ZiDisplay";
      PictureBox ziDisplay2 = this.ZiDisplay;
      size1 = new Size(236, 178);
      Size size33 = size1;
      ziDisplay2.Size = size33;
      this.ZiDisplay.TabIndex = 5;
      this.ZiDisplay.TabStop = false;
      this.ZtDisplay.BackColor = Color.White;
      this.ZtDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.ZtDisplay.Dock = DockStyle.Fill;
      PictureBox ztDisplay1 = this.ZtDisplay;
      point1 = new Point(245, 186);
      Point point11 = point1;
      ztDisplay1.Location = point11;
      this.ZtDisplay.Name = "ZtDisplay";
      PictureBox ztDisplay2 = this.ZtDisplay;
      size1 = new Size(237, 178);
      Size size34 = size1;
      ztDisplay2.Size = size34;
      this.ZtDisplay.TabIndex = 9;
      this.ZtDisplay.TabStop = false;
      this.ZrDisplay.BackColor = Color.White;
      this.ZrDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.ZrDisplay.Dock = DockStyle.Fill;
      PictureBox zrDisplay1 = this.ZrDisplay;
      point1 = new Point(3, 3);
      Point point12 = point1;
      zrDisplay1.Location = point12;
      this.ZrDisplay.Name = "ZrDisplay";
      PictureBox zrDisplay2 = this.ZrDisplay;
      size1 = new Size(236, 177);
      Size size35 = size1;
      zrDisplay2.Size = size35;
      this.ZrDisplay.TabIndex = 2;
      this.ZrDisplay.TabStop = false;
      this.TabPage4.Controls.Add((Control) this.DisplaceDisplay);
      TabPage tabPage4_1 = this.TabPage4;
      point1 = new Point(4, 22);
      Point point13 = point1;
      tabPage4_1.Location = point13;
      this.TabPage4.Name = "TabPage4";
      TabPage tabPage4_2 = this.TabPage4;
      padding1 = new Padding(3);
      Padding padding5 = padding1;
      tabPage4_2.Padding = padding5;
      TabPage tabPage4_3 = this.TabPage4;
      size1 = new Size(491, 373);
      Size size36 = size1;
      tabPage4_3.Size = size36;
      this.TabPage4.TabIndex = 3;
      this.TabPage4.Text = "Displacement";
      this.TabPage4.UseVisualStyleBackColor = true;
      this.DisplaceDisplay.BackColor = Color.White;
      this.DisplaceDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.DisplaceDisplay.Dock = DockStyle.Fill;
      PictureBox displaceDisplay1 = this.DisplaceDisplay;
      point1 = new Point(3, 3);
      Point point14 = point1;
      displaceDisplay1.Location = point14;
      this.DisplaceDisplay.Name = "DisplaceDisplay";
      PictureBox displaceDisplay2 = this.DisplaceDisplay;
      size1 = new Size(485, 367);
      Size size37 = size1;
      displaceDisplay2.Size = size37;
      this.DisplaceDisplay.TabIndex = 0;
      this.DisplaceDisplay.TabStop = false;
      this.TabPage5.Controls.Add((Control) this.VelocityDisplay);
      TabPage tabPage5_1 = this.TabPage5;
      point1 = new Point(4, 22);
      Point point15 = point1;
      tabPage5_1.Location = point15;
      this.TabPage5.Name = "TabPage5";
      TabPage tabPage5_2 = this.TabPage5;
      padding1 = new Padding(3);
      Padding padding6 = padding1;
      tabPage5_2.Padding = padding6;
      TabPage tabPage5_3 = this.TabPage5;
      size1 = new Size(491, 373);
      Size size38 = size1;
      tabPage5_3.Size = size38;
      this.TabPage5.TabIndex = 4;
      this.TabPage5.Text = "Velocity";
      this.TabPage5.UseVisualStyleBackColor = true;
      this.VelocityDisplay.BackColor = Color.White;
      this.VelocityDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.VelocityDisplay.Dock = DockStyle.Fill;
      PictureBox velocityDisplay1 = this.VelocityDisplay;
      point1 = new Point(3, 3);
      Point point16 = point1;
      velocityDisplay1.Location = point16;
      this.VelocityDisplay.Name = "VelocityDisplay";
      PictureBox velocityDisplay2 = this.VelocityDisplay;
      size1 = new Size(485, 367);
      Size size39 = size1;
      velocityDisplay2.Size = size39;
      this.VelocityDisplay.TabIndex = 0;
      this.VelocityDisplay.TabStop = false;
      this.TabPage6.Controls.Add((Control) this.GroupDelayDisplay);
      TabPage tabPage6_1 = this.TabPage6;
      point1 = new Point(4, 22);
      Point point17 = point1;
      tabPage6_1.Location = point17;
      this.TabPage6.Name = "TabPage6";
      TabPage tabPage6_2 = this.TabPage6;
      padding1 = new Padding(3);
      Padding padding7 = padding1;
      tabPage6_2.Padding = padding7;
      TabPage tabPage6_3 = this.TabPage6;
      size1 = new Size(491, 373);
      Size size40 = size1;
      tabPage6_3.Size = size40;
      this.TabPage6.TabIndex = 5;
      this.TabPage6.Text = "Group Delay";
      this.TabPage6.UseVisualStyleBackColor = true;
      this.GroupDelayDisplay.BackColor = Color.White;
      this.GroupDelayDisplay.BorderStyle = BorderStyle.FixedSingle;
      this.GroupDelayDisplay.Dock = DockStyle.Fill;
      PictureBox groupDelayDisplay1 = this.GroupDelayDisplay;
      point1 = new Point(3, 3);
      Point point18 = point1;
      groupDelayDisplay1.Location = point18;
      this.GroupDelayDisplay.Name = "GroupDelayDisplay";
      PictureBox groupDelayDisplay2 = this.GroupDelayDisplay;
      size1 = new Size(485, 367);
      Size size41 = size1;
      groupDelayDisplay2.Size = size41;
      this.GroupDelayDisplay.TabIndex = 0;
      this.GroupDelayDisplay.TabStop = false;
      this.SystemCheck.AutoSize = true;
      this.SystemCheck.Checked = MySettings.Default.SystemCheck;
      this.SystemCheck.CheckState = CheckState.Checked;
      this.SystemCheck.DataBindings.Add(new Binding("Checked", (object) MySettings.Default, "SystemCheck", true, DataSourceUpdateMode.OnPropertyChanged));
      CheckBox systemCheck1 = this.SystemCheck;
      point1 = new Point(232, 52);
      Point point19 = point1;
      systemCheck1.Location = point19;
      this.SystemCheck.Name = "SystemCheck";
      CheckBox systemCheck2 = this.SystemCheck;
      size1 = new Size(60, 17);
      Size size42 = size1;
      systemCheck2.Size = size42;
      this.SystemCheck.TabIndex = 3;
      this.SystemCheck.Text = "System";
      this.SystemCheck.UseVisualStyleBackColor = true;
      this.TerminusCheck.AutoSize = true;
      this.TerminusCheck.Checked = MySettings.Default.TerminusCheck;
      this.TerminusCheck.DataBindings.Add(new Binding("Checked", (object) MySettings.Default, "TerminusCheck", true, DataSourceUpdateMode.OnPropertyChanged));
      CheckBox terminusCheck1 = this.TerminusCheck;
      point1 = new Point(157, 52);
      Point point20 = point1;
      terminusCheck1.Location = point20;
      this.TerminusCheck.Name = "TerminusCheck";
      CheckBox terminusCheck2 = this.TerminusCheck;
      size1 = new Size(69, 17);
      Size size43 = size1;
      terminusCheck2.Size = size43;
      this.TerminusCheck.TabIndex = 2;
      this.TerminusCheck.Text = "Terminus";
      this.TerminusCheck.UseVisualStyleBackColor = true;
      this.DriverCheck.AutoSize = true;
      this.DriverCheck.Checked = MySettings.Default.DriverCheck;
      this.DriverCheck.DataBindings.Add(new Binding("Checked", (object) MySettings.Default, "DriverCheck", true, DataSourceUpdateMode.OnPropertyChanged));
      CheckBox driverCheck1 = this.DriverCheck;
      point1 = new Point(97, 52);
      Point point21 = point1;
      driverCheck1.Location = point21;
      this.DriverCheck.Name = "DriverCheck";
      CheckBox driverCheck2 = this.DriverCheck;
      size1 = new Size(54, 17);
      Size size44 = size1;
      driverCheck2.Size = size44;
      this.DriverCheck.TabIndex = 1;
      this.DriverCheck.Text = "Driver";
      this.DriverCheck.UseVisualStyleBackColor = true;
      this.IBCheck.AutoSize = true;
      this.IBCheck.Checked = MySettings.Default.InfiniteBaffleCheck;
      this.IBCheck.CheckState = CheckState.Checked;
      this.IBCheck.DataBindings.Add(new Binding("Checked", (object) MySettings.Default, "InfiniteBaffleCheck", true, DataSourceUpdateMode.OnPropertyChanged));
      CheckBox ibCheck1 = this.IBCheck;
      point1 = new Point(4, 52);
      Point point22 = point1;
      ibCheck1.Location = point22;
      this.IBCheck.Name = "IBCheck";
      CheckBox ibCheck2 = this.IBCheck;
      size1 = new Size(87, 17);
      Size size45 = size1;
      ibCheck2.Size = size45;
      this.IBCheck.TabIndex = 0;
      this.IBCheck.Text = "Infinite Baffle";
      this.IBCheck.UseVisualStyleBackColor = true;
      this.StatusStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripProgressBar,
        (ToolStripItem) this.ToolStripFreqLabel
      });
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      point1 = new Point(0, 477);
      Point point23 = point1;
      statusStrip1_1.Location = point23;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      size1 = new Size(499, 22);
      Size size46 = size1;
      statusStrip1_2.Size = size46;
      this.StatusStrip1.TabIndex = 14;
      this.StatusStrip1.Text = "StatusStrip1";
      this.ToolStripProgressBar.BackColor = Color.Black;
      this.ToolStripProgressBar.ForeColor = Color.White;
      this.ToolStripProgressBar.Name = "ToolStripProgressBar";
      ToolStripProgressBar stripProgressBar = this.ToolStripProgressBar;
      size1 = new Size(100, 16);
      Size size47 = size1;
      stripProgressBar.Size = size47;
      this.ToolStripFreqLabel.Name = "ToolStripFreqLabel";
      ToolStripStatusLabel toolStripFreqLabel = this.ToolStripFreqLabel;
      size1 = new Size(0, 17);
      Size size48 = size1;
      toolStripFreqLabel.Size = size48;
      this.FrequencyLabel.Name = "FrequencyLabel";
      ToolStripStatusLabel frequencyLabel = this.FrequencyLabel;
      size1 = new Size(0, 17);
      Size size49 = size1;
      frequencyLabel.Size = size49;
      this.ToolStrip1.BackColor = Color.LightGray;
      this.ToolStrip1.Dock = DockStyle.None;
      this.ToolStrip1.Items.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.ToolStripNewProject,
        (ToolStripItem) this.ToolStripOpenProject,
        (ToolStripItem) this.ToolStripSeparator9,
        (ToolStripItem) this.ToolStripSave,
        (ToolStripItem) this.ToolStripSaveAs,
        (ToolStripItem) this.ToolStripSeparator10,
        (ToolStripItem) this.ToolStripUndo,
        (ToolStripItem) this.ToolStripRedo,
        (ToolStripItem) this.ToolStripSeparator11,
        (ToolStripItem) this.ToolStripRunButton
      });
      ToolStrip toolStrip1_1 = this.ToolStrip1;
      point1 = new Point(0, 0);
      Point point24 = point1;
      toolStrip1_1.Location = point24;
      this.ToolStrip1.Name = "ToolStrip1";
      ToolStrip toolStrip1_2 = this.ToolStrip1;
      padding1 = new Padding(0);
      Padding padding8 = padding1;
      toolStrip1_2.Padding = padding8;
      ToolStrip toolStrip1_3 = this.ToolStrip1;
      size1 = new Size(190, 25);
      Size size50 = size1;
      toolStrip1_3.Size = size50;
      this.ToolStrip1.TabIndex = 15;
      this.ToolStrip1.Text = "ToolStrip1";
      this.ToolStripNewProject.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripNewProject.Image = (Image) TransmissionLine.My.Resources.Resources._0new;
      this.ToolStripNewProject.ImageTransparentColor = Color.Magenta;
      this.ToolStripNewProject.Name = "ToolStripNewProject";
      ToolStripButton toolStripNewProject = this.ToolStripNewProject;
      size1 = new Size(23, 22);
      Size size51 = size1;
      toolStripNewProject.Size = size51;
      this.ToolStripNewProject.Text = "Start New Project";
      this.ToolStripNewProject.ToolTipText = "Start New Project";
      this.ToolStripOpenProject.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripOpenProject.Image = (Image) TransmissionLine.My.Resources.Resources._0open;
      this.ToolStripOpenProject.ImageTransparentColor = Color.Magenta;
      this.ToolStripOpenProject.Name = "ToolStripOpenProject";
      ToolStripButton stripOpenProject = this.ToolStripOpenProject;
      size1 = new Size(23, 22);
      Size size52 = size1;
      stripOpenProject.Size = size52;
      this.ToolStripOpenProject.Text = "Open Project";
      this.ToolStripSeparator9.Name = "ToolStripSeparator9";
      ToolStripSeparator toolStripSeparator9 = this.ToolStripSeparator9;
      size1 = new Size(6, 25);
      Size size53 = size1;
      toolStripSeparator9.Size = size53;
      this.ToolStripSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripSave.Image = (Image) componentResourceManager.GetObject("ToolStripSave.Image");
      this.ToolStripSave.ImageTransparentColor = Color.Magenta;
      this.ToolStripSave.Name = "ToolStripSave";
      ToolStripButton toolStripSave = this.ToolStripSave;
      size1 = new Size(23, 22);
      Size size54 = size1;
      toolStripSave.Size = size54;
      this.ToolStripSave.Text = "Save Project";
      this.ToolStripSaveAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripSaveAs.Image = (Image) TransmissionLine.My.Resources.Resources._0save_as;
      this.ToolStripSaveAs.ImageTransparentColor = Color.Magenta;
      this.ToolStripSaveAs.Name = "ToolStripSaveAs";
      ToolStripButton toolStripSaveAs = this.ToolStripSaveAs;
      size1 = new Size(23, 22);
      Size size55 = size1;
      toolStripSaveAs.Size = size55;
      this.ToolStripSaveAs.Text = "Save Project As";
      this.ToolStripSaveAs.ToolTipText = "Save Project As";
      this.ToolStripSeparator10.Name = "ToolStripSeparator10";
      ToolStripSeparator stripSeparator10 = this.ToolStripSeparator10;
      size1 = new Size(6, 25);
      Size size56 = size1;
      stripSeparator10.Size = size56;
      this.ToolStripUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripUndo.Image = (Image) TransmissionLine.My.Resources.Resources._0undo;
      this.ToolStripUndo.ImageTransparentColor = Color.Magenta;
      this.ToolStripUndo.Name = "ToolStripUndo";
      ToolStripButton toolStripUndo = this.ToolStripUndo;
      size1 = new Size(23, 22);
      Size size57 = size1;
      toolStripUndo.Size = size57;
      this.ToolStripUndo.Text = "Undo";
      this.ToolStripRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripRedo.Image = (Image) TransmissionLine.My.Resources.Resources._0redo;
      this.ToolStripRedo.ImageTransparentColor = Color.Magenta;
      this.ToolStripRedo.Name = "ToolStripRedo";
      ToolStripButton toolStripRedo = this.ToolStripRedo;
      size1 = new Size(23, 22);
      Size size58 = size1;
      toolStripRedo.Size = size58;
      this.ToolStripRedo.Text = "Redo";
      this.ToolStripSeparator11.Name = "ToolStripSeparator11";
      ToolStripSeparator stripSeparator11 = this.ToolStripSeparator11;
      size1 = new Size(6, 25);
      Size size59 = size1;
      stripSeparator11.Size = size59;
      this.ToolStripRunButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripRunButton.Image = (Image) TransmissionLine.My.Resources.Resources._0run;
      this.ToolStripRunButton.ImageTransparentColor = Color.Magenta;
      this.ToolStripRunButton.Name = "ToolStripRunButton";
      ToolStripButton toolStripRunButton = this.ToolStripRunButton;
      size1 = new Size(23, 22);
      Size size60 = size1;
      toolStripRunButton.Size = size60;
      this.ToolStripRunButton.Text = "Run";
      this.ToolStripRunButton.ToolTipText = "Update Model";
      this.MenuStrip1.BackColor = Color.LightGray;
      this.MenuStrip1.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.FileToolStripMenuItem,
        (ToolStripItem) this.EditToolStripMenuItem,
        (ToolStripItem) this.ToolsToolStripMenuItem,
        (ToolStripItem) this.WindowToolStripMenuItem,
        (ToolStripItem) this.HelpToolStripMenuItem
      });
      MenuStrip menuStrip1_1 = this.MenuStrip1;
      point1 = new Point(0, 0);
      Point point25 = point1;
      menuStrip1_1.Location = point25;
      this.MenuStrip1.Name = "MenuStrip1";
      MenuStrip menuStrip1_2 = this.MenuStrip1;
      size1 = new Size(499, 24);
      Size size61 = size1;
      menuStrip1_2.Size = size61;
      this.MenuStrip1.TabIndex = 16;
      this.MenuStrip1.Text = "MenuStrip1";
      this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_1 = this.ToolStripMenuItem1;
      size1 = new Size(128, 20);
      Size size62 = size1;
      toolStripMenuItem1_1.Size = size62;
      this.ToolStripMenuItem1.Text = "ToolStripMenuItem1";
      this.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripButton1.Image = (Image) componentResourceManager.GetObject("ToolStripButton1.Image");
      this.ToolStripButton1.ImageTransparentColor = Color.Magenta;
      this.ToolStripButton1.Name = "ToolStripButton1";
      ToolStripButton toolStripButton1 = this.ToolStripButton1;
      size1 = new Size(23, 22);
      Size size63 = size1;
      toolStripButton1.Size = size63;
      this.ToolStripButton1.Text = "ToolStripButton1";
      this.Panel1.BackColor = Color.LightGray;
      this.Panel1.Controls.Add((Control) this.ToolStrip1);
      this.Panel1.Dock = DockStyle.Top;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 24);
      Point point26 = point1;
      panel1_1.Location = point26;
      Panel panel1_2 = this.Panel1;
      padding1 = new Padding(0);
      Padding padding9 = padding1;
      panel1_2.Margin = padding9;
      this.Panel1.Name = "Panel1";
      Panel panel1_3 = this.Panel1;
      size1 = new Size(499, 25);
      Size size64 = size1;
      panel1_3.Size = size64;
      this.Panel1.TabIndex = 17;
      this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_2 = this.HelpToolStripMenuItem1;
      size1 = new Size(152, 22);
      Size size65 = size1;
      toolStripMenuItem1_2.Size = size65;
      this.HelpToolStripMenuItem1.Text = "Help";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(499, 499);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.IBCheck);
      this.Controls.Add((Control) this.SystemCheck);
      this.Controls.Add((Control) this.DriverCheck);
      this.Controls.Add((Control) this.GraphTab);
      this.Controls.Add((Control) this.TerminusCheck);
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.MenuStrip1);
      this.DataBindings.Add(new Binding("Location", (object) MySettings.Default, "FormLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Location = MySettings.Default.FormLocation;
      this.MainMenuStrip = this.MenuStrip1;
      this.Name = nameof (Form1);
      this.Text = "Untitled";
      this.GraphTab.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      ((ISupportInitialize) this.LpDisplay).EndInit();
      this.TabPage3.ResumeLayout(false);
      ((ISupportInitialize) this.LpPhaseDisplay).EndInit();
      this.TabPage2.ResumeLayout(false);
      this.TableLayoutPanel1.ResumeLayout(false);
      ((ISupportInitialize) this.ZasDisplay).EndInit();
      ((ISupportInitialize) this.ZiDisplay).EndInit();
      ((ISupportInitialize) this.ZtDisplay).EndInit();
      ((ISupportInitialize) this.ZrDisplay).EndInit();
      this.TabPage4.ResumeLayout(false);
      ((ISupportInitialize) this.DisplaceDisplay).EndInit();
      this.TabPage5.ResumeLayout(false);
      ((ISupportInitialize) this.VelocityDisplay).EndInit();
      this.TabPage6.ResumeLayout(false);
      ((ISupportInitialize) this.GroupDelayDisplay).EndInit();
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.ToolStrip1.ResumeLayout(false);
      this.ToolStrip1.PerformLayout();
      this.MenuStrip1.ResumeLayout(false);
      this.MenuStrip1.PerformLayout();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal ToolStripMenuItem FileToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._FileToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._FileToolStripMenuItem = value;
    }

    internal ToolStripMenuItem HelpToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._HelpToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HelpToolStripMenuItem = value;
    }

    internal ToolStripMenuItem WindowToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._WindowToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._WindowToolStripMenuItem = value;
    }

    internal ToolStripMenuItem DriverToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._DriverToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DriverToolStripMenuItem_Click);
        if (this._DriverToolStripMenuItem != null)
          this._DriverToolStripMenuItem.Click -= eventHandler;
        this._DriverToolStripMenuItem = value;
        if (this._DriverToolStripMenuItem == null)
          return;
        this._DriverToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem AmplifierToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._AmplifierToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AmplifierToolStripMenuItem_Click);
        if (this._AmplifierToolStripMenuItem != null)
          this._AmplifierToolStripMenuItem.Click -= eventHandler;
        this._AmplifierToolStripMenuItem = value;
        if (this._AmplifierToolStripMenuItem == null)
          return;
        this._AmplifierToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem AboutToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._AboutToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AboutToolStripMenuItem_Click_1);
        if (this._AboutToolStripMenuItem != null)
          this._AboutToolStripMenuItem.Click -= eventHandler;
        this._AboutToolStripMenuItem = value;
        if (this._AboutToolStripMenuItem == null)
          return;
        this._AboutToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem ExitToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ExitToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click_1);
        if (this._ExitToolStripMenuItem != null)
          this._ExitToolStripMenuItem.Click -= eventHandler;
        this._ExitToolStripMenuItem = value;
        if (this._ExitToolStripMenuItem == null)
          return;
        this._ExitToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem GeometryViewerToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._GeometryViewerToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GeometryViewerToolStripMenuItem_Click);
        if (this._GeometryViewerToolStripMenuItem != null)
          this._GeometryViewerToolStripMenuItem.Click -= eventHandler;
        this._GeometryViewerToolStripMenuItem = value;
        if (this._GeometryViewerToolStripMenuItem == null)
          return;
        this._GeometryViewerToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem ToolsToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ToolsToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolsToolStripMenuItem = value;
    }

    internal ToolStripMenuItem SettingsToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._SettingsToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SettingsToolStripMenuItem_Click);
        if (this._SettingsToolStripMenuItem != null)
          this._SettingsToolStripMenuItem.Click -= eventHandler;
        this._SettingsToolStripMenuItem = value;
        if (this._SettingsToolStripMenuItem == null)
          return;
        this._SettingsToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem SaveProjectToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._SaveProjectToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveProjectToolStripMenuItem_Click);
        if (this._SaveProjectToolStripMenuItem != null)
          this._SaveProjectToolStripMenuItem.Click -= eventHandler;
        this._SaveProjectToolStripMenuItem = value;
        if (this._SaveProjectToolStripMenuItem == null)
          return;
        this._SaveProjectToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem SaveProjectAsToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._SaveProjectAsToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripSaveAs_Click);
        if (this._SaveProjectAsToolStripMenuItem != null)
          this._SaveProjectAsToolStripMenuItem.Click -= eventHandler;
        this._SaveProjectAsToolStripMenuItem = value;
        if (this._SaveProjectAsToolStripMenuItem == null)
          return;
        this._SaveProjectAsToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem OpenProjectToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._OpenProjectToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripOpenProject_Click);
        if (this._OpenProjectToolStripMenuItem != null)
          this._OpenProjectToolStripMenuItem.Click -= eventHandler;
        this._OpenProjectToolStripMenuItem = value;
        if (this._OpenProjectToolStripMenuItem == null)
          return;
        this._OpenProjectToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem NewProjectToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._NewProjectToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NewProjectToolStripMenuItem_Click);
        if (this._NewProjectToolStripMenuItem != null)
          this._NewProjectToolStripMenuItem.Click -= eventHandler;
        this._NewProjectToolStripMenuItem = value;
        if (this._NewProjectToolStripMenuItem == null)
          return;
        this._NewProjectToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem EditToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._EditToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EditToolStripMenuItem = value;
    }

    internal ToolStripMenuItem UndoToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._UndoToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UndoToolStripMenuItem_Click);
        if (this._UndoToolStripMenuItem != null)
          this._UndoToolStripMenuItem.Click -= eventHandler;
        this._UndoToolStripMenuItem = value;
        if (this._UndoToolStripMenuItem == null)
          return;
        this._UndoToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem RedoToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._RedoToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RedoToolStripMenuItem_Click);
        if (this._RedoToolStripMenuItem != null)
          this._RedoToolStripMenuItem.Click -= eventHandler;
        this._RedoToolStripMenuItem = value;
        if (this._RedoToolStripMenuItem == null)
          return;
        this._RedoToolStripMenuItem.Click += eventHandler;
      }
    }

    internal TabControl GraphTab
    {
      [DebuggerNonUserCode] get => this._GraphTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TabControl1_TabIndexChanged);
        if (this._GraphTab != null)
          this._GraphTab.SelectedIndexChanged -= eventHandler;
        this._GraphTab = value;
        if (this._GraphTab == null)
          return;
        this._GraphTab.SelectedIndexChanged += eventHandler;
      }
    }

    internal TabPage TabPage1
    {
      [DebuggerNonUserCode] get => this._TabPage1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage1 = value;
    }

    internal CheckBox SystemCheck
    {
      [DebuggerNonUserCode] get => this._SystemCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Graph_CheckedChanged);
        if (this._SystemCheck != null)
          this._SystemCheck.CheckedChanged -= eventHandler;
        this._SystemCheck = value;
        if (this._SystemCheck == null)
          return;
        this._SystemCheck.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox TerminusCheck
    {
      [DebuggerNonUserCode] get => this._TerminusCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Graph_CheckedChanged);
        if (this._TerminusCheck != null)
          this._TerminusCheck.CheckedChanged -= eventHandler;
        this._TerminusCheck = value;
        if (this._TerminusCheck == null)
          return;
        this._TerminusCheck.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox DriverCheck
    {
      [DebuggerNonUserCode] get => this._DriverCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Graph_CheckedChanged);
        if (this._DriverCheck != null)
          this._DriverCheck.CheckedChanged -= eventHandler;
        this._DriverCheck = value;
        if (this._DriverCheck == null)
          return;
        this._DriverCheck.CheckedChanged += eventHandler;
      }
    }

    internal CheckBox IBCheck
    {
      [DebuggerNonUserCode] get => this._IBCheck;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Graph_CheckedChanged);
        if (this._IBCheck != null)
          this._IBCheck.CheckedChanged -= eventHandler;
        this._IBCheck = value;
        if (this._IBCheck == null)
          return;
        this._IBCheck.CheckedChanged += eventHandler;
      }
    }

    internal PictureBox LpDisplay
    {
      [DebuggerNonUserCode] get => this._LpDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._LpDisplay != null)
        {
          this._LpDisplay.MouseLeave -= eventHandler;
          this._LpDisplay.MouseMove -= mouseEventHandler1;
          this._LpDisplay.MouseDown -= mouseEventHandler2;
          this._LpDisplay.MouseUp -= mouseEventHandler3;
        }
        this._LpDisplay = value;
        if (this._LpDisplay == null)
          return;
        this._LpDisplay.MouseLeave += eventHandler;
        this._LpDisplay.MouseMove += mouseEventHandler1;
        this._LpDisplay.MouseDown += mouseEventHandler2;
        this._LpDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal TabPage TabPage2
    {
      [DebuggerNonUserCode] get => this._TabPage2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage2 = value;
    }

    internal PictureBox ZrDisplay
    {
      [DebuggerNonUserCode] get => this._ZrDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._ZrDisplay != null)
        {
          this._ZrDisplay.MouseLeave -= eventHandler;
          this._ZrDisplay.MouseMove -= mouseEventHandler1;
          this._ZrDisplay.MouseDown -= mouseEventHandler2;
          this._ZrDisplay.MouseUp -= mouseEventHandler3;
        }
        this._ZrDisplay = value;
        if (this._ZrDisplay == null)
          return;
        this._ZrDisplay.MouseLeave += eventHandler;
        this._ZrDisplay.MouseMove += mouseEventHandler1;
        this._ZrDisplay.MouseDown += mouseEventHandler2;
        this._ZrDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal PictureBox ZasDisplay
    {
      [DebuggerNonUserCode] get => this._ZasDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._ZasDisplay != null)
        {
          this._ZasDisplay.MouseLeave -= eventHandler;
          this._ZasDisplay.MouseMove -= mouseEventHandler1;
          this._ZasDisplay.MouseDown -= mouseEventHandler2;
          this._ZasDisplay.MouseUp -= mouseEventHandler3;
        }
        this._ZasDisplay = value;
        if (this._ZasDisplay == null)
          return;
        this._ZasDisplay.MouseLeave += eventHandler;
        this._ZasDisplay.MouseMove += mouseEventHandler1;
        this._ZasDisplay.MouseDown += mouseEventHandler2;
        this._ZasDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal PictureBox ZiDisplay
    {
      [DebuggerNonUserCode] get => this._ZiDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._ZiDisplay != null)
        {
          this._ZiDisplay.MouseLeave -= eventHandler;
          this._ZiDisplay.MouseMove -= mouseEventHandler1;
          this._ZiDisplay.MouseDown -= mouseEventHandler2;
          this._ZiDisplay.MouseUp -= mouseEventHandler3;
        }
        this._ZiDisplay = value;
        if (this._ZiDisplay == null)
          return;
        this._ZiDisplay.MouseLeave += eventHandler;
        this._ZiDisplay.MouseMove += mouseEventHandler1;
        this._ZiDisplay.MouseDown += mouseEventHandler2;
        this._ZiDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal PictureBox ZtDisplay
    {
      [DebuggerNonUserCode] get => this._ZtDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._ZtDisplay != null)
        {
          this._ZtDisplay.MouseLeave -= eventHandler;
          this._ZtDisplay.MouseMove -= mouseEventHandler1;
          this._ZtDisplay.MouseDown -= mouseEventHandler2;
          this._ZtDisplay.MouseUp -= mouseEventHandler3;
        }
        this._ZtDisplay = value;
        if (this._ZtDisplay == null)
          return;
        this._ZtDisplay.MouseLeave += eventHandler;
        this._ZtDisplay.MouseMove += mouseEventHandler1;
        this._ZtDisplay.MouseDown += mouseEventHandler2;
        this._ZtDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal TabPage TabPage4
    {
      [DebuggerNonUserCode] get => this._TabPage4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage4 = value;
    }

    internal PictureBox DisplaceDisplay
    {
      [DebuggerNonUserCode] get => this._DisplaceDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._DisplaceDisplay != null)
        {
          this._DisplaceDisplay.MouseLeave -= eventHandler;
          this._DisplaceDisplay.MouseMove -= mouseEventHandler1;
          this._DisplaceDisplay.MouseDown -= mouseEventHandler2;
          this._DisplaceDisplay.MouseUp -= mouseEventHandler3;
        }
        this._DisplaceDisplay = value;
        if (this._DisplaceDisplay == null)
          return;
        this._DisplaceDisplay.MouseLeave += eventHandler;
        this._DisplaceDisplay.MouseMove += mouseEventHandler1;
        this._DisplaceDisplay.MouseDown += mouseEventHandler2;
        this._DisplaceDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal TabPage TabPage5
    {
      [DebuggerNonUserCode] get => this._TabPage5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage5 = value;
    }

    internal PictureBox VelocityDisplay
    {
      [DebuggerNonUserCode] get => this._VelocityDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._VelocityDisplay != null)
        {
          this._VelocityDisplay.MouseLeave -= eventHandler;
          this._VelocityDisplay.MouseMove -= mouseEventHandler1;
          this._VelocityDisplay.MouseDown -= mouseEventHandler2;
          this._VelocityDisplay.MouseUp -= mouseEventHandler3;
        }
        this._VelocityDisplay = value;
        if (this._VelocityDisplay == null)
          return;
        this._VelocityDisplay.MouseLeave += eventHandler;
        this._VelocityDisplay.MouseMove += mouseEventHandler1;
        this._VelocityDisplay.MouseDown += mouseEventHandler2;
        this._VelocityDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal TabPage TabPage6
    {
      [DebuggerNonUserCode] get => this._TabPage6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage6 = value;
    }

    internal PictureBox GroupDelayDisplay
    {
      [DebuggerNonUserCode] get => this._GroupDelayDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._GroupDelayDisplay != null)
        {
          this._GroupDelayDisplay.MouseLeave -= eventHandler;
          this._GroupDelayDisplay.MouseMove -= mouseEventHandler1;
          this._GroupDelayDisplay.MouseDown -= mouseEventHandler2;
          this._GroupDelayDisplay.MouseUp -= mouseEventHandler3;
        }
        this._GroupDelayDisplay = value;
        if (this._GroupDelayDisplay == null)
          return;
        this._GroupDelayDisplay.MouseLeave += eventHandler;
        this._GroupDelayDisplay.MouseMove += mouseEventHandler1;
        this._GroupDelayDisplay.MouseDown += mouseEventHandler2;
        this._GroupDelayDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal StatusStrip StatusStrip1
    {
      [DebuggerNonUserCode] get => this._StatusStrip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._StatusStrip1 = value;
    }

    internal ToolStripProgressBar ToolStripProgressBar
    {
      [DebuggerNonUserCode] get => this._ToolStripProgressBar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripProgressBar = value;
    }

    internal ToolStripStatusLabel FrequencyLabel
    {
      [DebuggerNonUserCode] get => this._FrequencyLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._FrequencyLabel = value;
    }

    internal ToolStripStatusLabel ToolStripFreqLabel
    {
      [DebuggerNonUserCode] get => this._ToolStripFreqLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripFreqLabel = value;
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

    internal ToolStripButton ToolStripNewProject
    {
      [DebuggerNonUserCode] get => this._ToolStripNewProject;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NewProjectToolStripMenuItem_Click);
        if (this._ToolStripNewProject != null)
          this._ToolStripNewProject.Click -= eventHandler;
        this._ToolStripNewProject = value;
        if (this._ToolStripNewProject == null)
          return;
        this._ToolStripNewProject.Click += eventHandler;
      }
    }

    internal ToolStripButton ToolStripSave
    {
      [DebuggerNonUserCode] get => this._ToolStripSave;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveProjectToolStripMenuItem_Click);
        if (this._ToolStripSave != null)
          this._ToolStripSave.Click -= eventHandler;
        this._ToolStripSave = value;
        if (this._ToolStripSave == null)
          return;
        this._ToolStripSave.Click += eventHandler;
      }
    }

    internal ToolStripButton ToolStripUndo
    {
      [DebuggerNonUserCode] get => this._ToolStripUndo;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UndoToolStripMenuItem_Click);
        if (this._ToolStripUndo != null)
          this._ToolStripUndo.Click -= eventHandler;
        this._ToolStripUndo = value;
        if (this._ToolStripUndo == null)
          return;
        this._ToolStripUndo.Click += eventHandler;
      }
    }

    internal ToolStripButton ToolStripRedo
    {
      [DebuggerNonUserCode] get => this._ToolStripRedo;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RedoToolStripMenuItem_Click);
        if (this._ToolStripRedo != null)
          this._ToolStripRedo.Click -= eventHandler;
        this._ToolStripRedo = value;
        if (this._ToolStripRedo == null)
          return;
        this._ToolStripRedo.Click += eventHandler;
      }
    }

    internal ToolStripButton ToolStripOpenProject
    {
      [DebuggerNonUserCode] get => this._ToolStripOpenProject;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripOpenProject_Click);
        if (this._ToolStripOpenProject != null)
          this._ToolStripOpenProject.Click -= eventHandler;
        this._ToolStripOpenProject = value;
        if (this._ToolStripOpenProject == null)
          return;
        this._ToolStripOpenProject.Click += eventHandler;
      }
    }

    internal ToolStripButton ToolStripSaveAs
    {
      [DebuggerNonUserCode] get => this._ToolStripSaveAs;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripSaveAs_Click);
        if (this._ToolStripSaveAs != null)
          this._ToolStripSaveAs.Click -= eventHandler;
        this._ToolStripSaveAs = value;
        if (this._ToolStripSaveAs == null)
          return;
        this._ToolStripSaveAs.Click += eventHandler;
      }
    }

    internal MenuStrip MenuStrip1
    {
      [DebuggerNonUserCode] get => this._MenuStrip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MenuStrip1 = value;
    }

    internal ToolStripMenuItem ToolStripMenuItem1
    {
      [DebuggerNonUserCode] get => this._ToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripMenuItem1 = value;
    }

    internal ToolStripSeparator ToolStripSeparator6
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator6 = value;
    }

    internal ToolStripSeparator ToolStripSeparator7
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator7 = value;
    }

    internal ToolStripSeparator ToolStripSeparator8
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator8 = value;
    }

    internal ToolStripButton ToolStripButton1
    {
      [DebuggerNonUserCode] get => this._ToolStripButton1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripButton1 = value;
    }

    internal ToolStripSeparator ToolStripSeparator9
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator9 = value;
    }

    internal ToolStripSeparator ToolStripSeparator10
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator10 = value;
    }

    internal ToolStripSeparator ToolStripSeparator11
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator11 = value;
    }

    internal ToolStripSeparator ToolStripSeparator1
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator1 = value;
    }

    internal ToolStripMenuItem RecentFilesToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._RecentFilesToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._RecentFilesToolStripMenuItem = value;
    }

    internal TabPage TabPage3
    {
      [DebuggerNonUserCode] get => this._TabPage3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage3 = value;
    }

    internal PictureBox LpPhaseDisplay
    {
      [DebuggerNonUserCode] get => this._LpPhaseDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphMouseLeave);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.GraphMouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.GraphMouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.GraphMouseUp);
        if (this._LpPhaseDisplay != null)
        {
          this._LpPhaseDisplay.MouseLeave -= eventHandler;
          this._LpPhaseDisplay.MouseMove -= mouseEventHandler1;
          this._LpPhaseDisplay.MouseDown -= mouseEventHandler2;
          this._LpPhaseDisplay.MouseUp -= mouseEventHandler3;
        }
        this._LpPhaseDisplay = value;
        if (this._LpPhaseDisplay == null)
          return;
        this._LpPhaseDisplay.MouseLeave += eventHandler;
        this._LpPhaseDisplay.MouseMove += mouseEventHandler1;
        this._LpPhaseDisplay.MouseDown += mouseEventHandler2;
        this._LpPhaseDisplay.MouseUp += mouseEventHandler3;
      }
    }

    internal TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel1 = value;
    }

    internal Panel Panel1
    {
      [DebuggerNonUserCode] get => this._Panel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
    }

    internal ToolStripMenuItem FilterToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._FilterToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FilterToolStripMenuItem_Click);
        if (this._FilterToolStripMenuItem != null)
          this._FilterToolStripMenuItem.Click -= eventHandler;
        this._FilterToolStripMenuItem = value;
        if (this._FilterToolStripMenuItem == null)
          return;
        this._FilterToolStripMenuItem.Click += eventHandler;
      }
    }

    internal ToolStripMenuItem HelpToolStripMenuItem1
    {
      [DebuggerNonUserCode] get => this._HelpToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HelpToolStripMenuItem1_Click);
        if (this._HelpToolStripMenuItem1 != null)
          this._HelpToolStripMenuItem1.Click -= eventHandler;
        this._HelpToolStripMenuItem1 = value;
        if (this._HelpToolStripMenuItem1 == null)
          return;
        this._HelpToolStripMenuItem1.Click += eventHandler;
      }
    }

    private void UpdateSettingsfromFile()
    {
      this.SettingsParameter.DriverLibrary = MySettingsProperty.Settings.DriverLibrary;
      this.SettingsParameter.StartFreq = MySettingsProperty.Settings.StartFreq;
      this.SettingsParameter.EndFreq = MySettingsProperty.Settings.EndFreq;
      this.SettingsParameter.RadiationImpedanceMax = MySettingsProperty.Settings.RadImpMax;
      this.SettingsParameter.RadiationImpedanceMin = MySettingsProperty.Settings.RadImpMin;
      this.SettingsParameter.DriverImpedanceMax = MySettingsProperty.Settings.DriverImpMax;
      this.SettingsParameter.DriverImpedanceMin = MySettingsProperty.Settings.DriverImpMin;
      this.SettingsParameter.InputImpedanceMax = MySettingsProperty.Settings.InputImpMax;
      this.SettingsParameter.InputImpedanceMin = MySettingsProperty.Settings.InputImpMin;
      this.SettingsParameter.SystemImpedanceMax = MySettingsProperty.Settings.SystemImpMax;
      this.SettingsParameter.SystemImpedanceMin = MySettingsProperty.Settings.SystemImpMin;
      this.SettingsParameter.LwMax = MySettingsProperty.Settings.LwMax;
      this.SettingsParameter.LwMin = MySettingsProperty.Settings.LwMin;
      this.SettingsParameter.DisplaceMax = MySettingsProperty.Settings.DisplaceMax;
      this.SettingsParameter.DisplaceMin = MySettingsProperty.Settings.DisplaceMin;
      this.SettingsParameter.VelocityMax = MySettingsProperty.Settings.VelocityMax;
      this.SettingsParameter.VelocityMin = MySettingsProperty.Settings.VelocityMin;
      this.SettingsParameter.GroupDelayMax = MySettingsProperty.Settings.GroupDelayMax;
      this.SettingsParameter.GroupDelayMin = MySettingsProperty.Settings.GroupDelayMin;
      this.SettingsParameter.PhaseMax = MySettingsProperty.Settings.PhaseMax;
      this.SettingsParameter.PhaseMin = MySettingsProperty.Settings.PhaseMin;
      this.SettingsParameter.FrequencyLog = MySettingsProperty.Settings.FrequencyLog;
      this.SettingsParameter.RadiationImpedanceLog = MySettingsProperty.Settings.RadiationImpLog;
      this.SettingsParameter.DriverImpedanceLog = MySettingsProperty.Settings.DriverImpLog;
      this.SettingsParameter.InputImpedanceLog = MySettingsProperty.Settings.InputImpLog;
      this.SettingsParameter.SystemImpedanceLog = MySettingsProperty.Settings.SystemImpLog;
      this.SettingsParameter.LwLog = MySettingsProperty.Settings.LwLog;
      this.SettingsParameter.DisplaceLog = MySettingsProperty.Settings.DriverImpLog;
      this.SettingsParameter.VelocityLog = MySettingsProperty.Settings.VelocityLog;
      this.SettingsParameter.GroupDelayLog = MySettingsProperty.Settings.GroupDelayLog;
      this.SettingsParameter.LengthUnit = MySettingsProperty.Settings.LengthUnit;
      this.SettingsParameter.StartAreaUnit = MySettingsProperty.Settings.StartAreaUnit;
      this.SettingsParameter.EndAreaUnit = MySettingsProperty.Settings.EndAreaUnit;
      this.SettingsParameter.VolumeUnit = MySettingsProperty.Settings.VolumeUnit;
      this.SettingsParameter.DensityUnit = MySettingsProperty.Settings.DensityUnit;
      this.SettingsParameter.TotalLengthUnit = MySettingsProperty.Settings.TotalLengthUnit;
      this.SettingsParameter.EnclosureDepthUnit = MySettingsProperty.Settings.EnclosureDepthUnit;
      this.SettingsParameter.AutoUpdate = MySettingsProperty.Settings.AutoUpdate;
      this.SettingsParameter.DisplayLengthUnit = MySettingsProperty.Settings.DisplayLengthUnit;
      this.SettingsParameter.DisplayAreaUnit = MySettingsProperty.Settings.DisplayAreaUnit;
      this.SettingsParameter.DisplayAngleUnit = MySettingsProperty.Settings.DisplayAngleUnit;
      this.SettingsParameter.DisplayLengthPrecision = MySettingsProperty.Settings.DisplayLengthPrecision;
      this.SettingsParameter.DisplayAreaPrecision = MySettingsProperty.Settings.DisplayAreaPrecision;
      this.SettingsParameter.DisplayAnglePrecision = MySettingsProperty.Settings.DisplayAnglePrecision;
      this.SettingsParameter.ElementVolumeUnit = MySettingsProperty.Settings.ElementVolumeUnit;
      this.SettingsParameter.GeometrySplitterDistance = MySettingsProperty.Settings.GeometrySplitterDistance;
      this.SettingsParameter.GeometryHeight = MySettingsProperty.Settings.GeometryHeight;
      this.SettingsParameter.GeometryWidth = MySettingsProperty.Settings.GeometryWidth;
      this.SettingsParameter.GeometryPanUp = MySettingsProperty.Settings.GeometryPanUp;
      this.SettingsParameter.GeometryPanRight = MySettingsProperty.Settings.GeometryPanRight;
      this.SettingsParameter.GeometryScale = MySettingsProperty.Settings.GeometryScale;
      this.SettingsParameter.ShowFront = MySettingsProperty.Settings.ShowFront;
      this.SettingsParameter.ShowRear = MySettingsProperty.Settings.ShowRear;
      this.SettingsParameter.PanMouseButton = MySettingsProperty.Settings.PanMouseButton;
      this.SettingsParameter.UndoRedoHistory = MySettingsProperty.Settings.UndoRedoHistory;
      this.SettingsParameter.SpeedOfSound = MySettingsProperty.Settings.SpeedOfSound;
    }

    private void UpdateSettingstoFile()
    {
      MySettingsProperty.Settings.DriverLibrary = this.SettingsParameter.DriverLibrary;
      MySettingsProperty.Settings.StartFreq = this.SettingsParameter.StartFreq;
      MySettingsProperty.Settings.EndFreq = this.SettingsParameter.EndFreq;
      MySettingsProperty.Settings.RadImpMax = this.SettingsParameter.RadiationImpedanceMax;
      MySettingsProperty.Settings.RadImpMin = this.SettingsParameter.RadiationImpedanceMin;
      MySettingsProperty.Settings.DriverImpMax = this.SettingsParameter.DriverImpedanceMax;
      MySettingsProperty.Settings.DriverImpMin = this.SettingsParameter.DriverImpedanceMin;
      MySettingsProperty.Settings.InputImpMax = this.SettingsParameter.InputImpedanceMax;
      MySettingsProperty.Settings.InputImpMin = this.SettingsParameter.InputImpedanceMin;
      MySettingsProperty.Settings.SystemImpMax = this.SettingsParameter.SystemImpedanceMax;
      MySettingsProperty.Settings.SystemImpMin = this.SettingsParameter.SystemImpedanceMin;
      MySettingsProperty.Settings.LwMax = this.SettingsParameter.LwMax;
      MySettingsProperty.Settings.LwMin = this.SettingsParameter.LwMin;
      MySettingsProperty.Settings.DisplaceMax = this.SettingsParameter.DisplaceMax;
      MySettingsProperty.Settings.DisplaceMin = this.SettingsParameter.DisplaceMin;
      MySettingsProperty.Settings.VelocityMax = this.SettingsParameter.VelocityMax;
      MySettingsProperty.Settings.VelocityMin = this.SettingsParameter.VelocityMin;
      MySettingsProperty.Settings.GroupDelayMax = this.SettingsParameter.GroupDelayMax;
      MySettingsProperty.Settings.GroupDelayMin = this.SettingsParameter.GroupDelayMin;
      MySettingsProperty.Settings.FrequencyLog = this.SettingsParameter.FrequencyLog;
      MySettingsProperty.Settings.RadiationImpLog = this.SettingsParameter.RadiationImpedanceLog;
      MySettingsProperty.Settings.DriverImpLog = this.SettingsParameter.DriverImpedanceLog;
      MySettingsProperty.Settings.InputImpLog = this.SettingsParameter.InputImpedanceLog;
      MySettingsProperty.Settings.SystemImpLog = this.SettingsParameter.SystemImpedanceLog;
      MySettingsProperty.Settings.LwLog = this.SettingsParameter.LwLog;
      MySettingsProperty.Settings.DriverImpLog = this.SettingsParameter.DisplaceLog;
      MySettingsProperty.Settings.VelocityLog = this.SettingsParameter.VelocityLog;
      MySettingsProperty.Settings.GroupDelayLog = this.SettingsParameter.GroupDelayLog;
      MySettingsProperty.Settings.LengthUnit = this.SettingsParameter.LengthUnit;
      MySettingsProperty.Settings.StartAreaUnit = this.SettingsParameter.StartAreaUnit;
      MySettingsProperty.Settings.EndAreaUnit = this.SettingsParameter.EndAreaUnit;
      MySettingsProperty.Settings.VolumeUnit = this.SettingsParameter.VolumeUnit;
      MySettingsProperty.Settings.TotalLengthUnit = this.SettingsParameter.TotalLengthUnit;
      MySettingsProperty.Settings.EnclosureDepthUnit = this.SettingsParameter.EnclosureDepthUnit;
      MySettingsProperty.Settings.AutoUpdate = this.SettingsParameter.AutoUpdate;
      MySettingsProperty.Settings.DisplayLengthUnit = this.SettingsParameter.DisplayLengthUnit;
      MySettingsProperty.Settings.DisplayAreaUnit = this.SettingsParameter.DisplayAreaUnit;
      MySettingsProperty.Settings.DisplayAngleUnit = this.SettingsParameter.DisplayAngleUnit;
      MySettingsProperty.Settings.DensityUnit = this.SettingsParameter.DensityUnit;
      MySettingsProperty.Settings.DisplayLengthPrecision = this.SettingsParameter.DisplayLengthPrecision;
      MySettingsProperty.Settings.DisplayAreaPrecision = this.SettingsParameter.DisplayAreaPrecision;
      MySettingsProperty.Settings.DisplayAnglePrecision = this.SettingsParameter.DisplayAnglePrecision;
      MySettingsProperty.Settings.ElementVolumeUnit = this.SettingsParameter.ElementVolumeUnit;
      MySettingsProperty.Settings.GeometrySplitterDistance = this.SettingsParameter.GeometrySplitterDistance;
      MySettingsProperty.Settings.GeometryHeight = this.SettingsParameter.GeometryHeight;
      MySettingsProperty.Settings.GeometryWidth = this.SettingsParameter.GeometryWidth;
      MySettingsProperty.Settings.GeometryPanUp = this.SettingsParameter.GeometryPanUp;
      MySettingsProperty.Settings.GeometryPanRight = this.SettingsParameter.GeometryPanRight;
      MySettingsProperty.Settings.GeometryScale = this.SettingsParameter.GeometryScale;
      MySettingsProperty.Settings.ShowFront = this.SettingsParameter.ShowFront;
      MySettingsProperty.Settings.ShowRear = this.SettingsParameter.ShowRear;
      MySettingsProperty.Settings.PanMouseButton = this.SettingsParameter.PanMouseButton;
      MySettingsProperty.Settings.UndoRedoHistory = this.SettingsParameter.UndoRedoHistory;
      MySettingsProperty.Settings.Form1Width = this.Width;
      MySettingsProperty.Settings.Form1Height = this.Height;
      MySettingsProperty.Settings.SpeedOfSound = this.SettingsParameter.SpeedOfSound;
    }

    private void UpdateImpedances(TreeNode TheTree, double f)
    {
      if (TheTree.Nodes.Count == 0)
        return;
      object tag1 = TheTree.Nodes[checked (TheTree.Nodes.Count - 1)].Tag;
      TLElement tlElement1 = default;
      Complex ZRadiation;
      if ((tag1 != null ? (TLElement) tag1 : tlElement1).OpenEnd)
      {
        double frequency = f;
        object tag2 = TheTree.Nodes[checked (TheTree.Nodes.Count - 1)].Tag;
        double PistonRadius = Math.Sqrt((tag2 != null ? (TLElement) tag2 : tlElement1).EndArea / Math.PI);
        double speedOfSound = this.SettingsParameter.SpeedOfSound;
        ZRadiation = Functions.RadiationImpedance(frequency, PistonRadius, speedOfSound);
      }
      else
        ZRadiation = Functions.ClosedRadiationImpedance();
      Complex Ratio = new Complex(1.0, 0.0);
      int index = checked (TheTree.Nodes.Count - 1);
      while (index >= 0)
      {
        this.RecursiveImpedance(TheTree.Nodes[index], ZRadiation, Ratio, f);
        if (TheTree.Nodes[index].Nodes.Count > 0)
        {
          Ratio.Real = 1.0;
          Ratio.Imaginary = 0.0;
          ZRadiation = Functions.BranchInputImpedance(TheTree.Nodes[index]);
        }
        else
        {
          object tag3 = TheTree.Nodes[index].Tag;
          TLElement tlElement2 = tag3 != null ? (TLElement) tag3 : tlElement1;
          Ratio = tlElement2.Ratio;
          object tag4 = TheTree.Nodes[index].Tag;
          tlElement2 = tag4 != null ? (TLElement) tag4 : tlElement1;
          ZRadiation = tlElement2.Zi;
        }
        checked { index += -1; }
      }
    }

    private void RecursiveImpedance(TreeNode n, Complex ZRadiation, Complex Ratio, double f)
    {
      object tag1 = n.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
      object tag2 = n.Tag;
      TLElement tlElement3 = (tag2 != null ? (TLElement) tag2 : tlElement1) with
      {
        Zi = tlElement2.get_InputImpedance(ZRadiation, f, this.SettingsParameter.SpeedOfSound),
        Ratio = Ratio * tlElement2.get_FERatio(ZRadiation, f, this.SettingsParameter.SpeedOfSound)
      };
      n.Tag = (object) tlElement3;
      if (n.Nodes.Count <= 0)
        return;
      object tag3 = n.Nodes[checked (n.Nodes.Count - 1)].Tag;
      Complex ZRadiation1;
      if ((tag3 != null ? (TLElement) tag3 : tlElement1).OpenEnd)
      {
        double frequency = f;
        object tag4 = n.Nodes[checked (n.Nodes.Count - 1)].Tag;
        double PistonRadius = Math.Sqrt((tag4 != null ? (TLElement) tag4 : tlElement1).EndArea / Math.PI);
        double speedOfSound = this.SettingsParameter.SpeedOfSound;
        ZRadiation1 = Functions.RadiationImpedance(frequency, PistonRadius, speedOfSound);
      }
      else
        ZRadiation1 = Functions.ClosedRadiationImpedance();
      Complex Ratio1 = new Complex(1.0, 0.0);
      int index = checked (n.Nodes.Count - 1);
      while (index >= 0)
      {
        this.RecursiveImpedance(n.Nodes[index], ZRadiation1, Ratio1, f);
        if (n.Nodes[index].Nodes.Count > 0)
        {
          Ratio1.Real = 1.0;
          Ratio1.Imaginary = 0.0;
          ZRadiation1 = Functions.BranchInputImpedance(n.Nodes[index]);
        }
        else
        {
          object tag5 = n.Nodes[index].Tag;
          TLElement tlElement4 = tag5 != null ? (TLElement) tag5 : tlElement1;
          Ratio1 = tlElement4.Ratio;
          object tag6 = n.Nodes[index].Tag;
          tlElement4 = tag6 != null ? (TLElement) tag6 : tlElement1;
          ZRadiation1 = tlElement4.Zi;
        }
        checked { index += -1; }
      }
    }

    private void ChangeRoutine()
    {
      if (this.UndoStackPosition < this.UndoStack.GetUpperBound(0))
      {
        checked { ++this.UndoStackPosition; }
        System.IO.File.Copy(this.CurrentState, this.UndoStack[this.UndoStackPosition], true);
      }
      else
      {
        int upperBound = this.UndoStack.GetUpperBound(0);
        int index = 1;
        while (index <= upperBound)
        {
          System.IO.File.Copy(this.UndoStack[index], this.UndoStack[checked (index - 1)], true);
          checked { ++index; }
        }
        System.IO.File.Copy(this.CurrentState, this.UndoStack[this.UndoStackPosition], true);
      }
      this.UndoEnable(true);
      this.RedoStackPosition = -1;
      this.RedoEnable(false);
      this.SaveFromPath(this.CurrentState);
      this.Saved = false;
      this.TitleChange();
    }

    public void CreateCalcTree()
    {
      this.TLGeometryCalc.Width = this.TLParameter.Width;
      if (!Information.IsNothing((object) this.TLGeometryCalc.FrontEnclosure))
        this.TLGeometryCalc.FrontEnclosure.Nodes.Clear();
      else
        this.TLGeometryCalc.FrontEnclosure = new TreeNode();
      this.TLGeometryCalc.FrontEnclosure.Tag = (object) "Front";
      TLElement tlElement1 = default;
      if (this.DriverSetupParameter.Tapped)
      {
        int num1 = 0;
        double num2 = 0.0;
        if (!Information.IsNothing((object) this.TLParameter.RearEnclosure))
        {
          double num3 = 0.0;
          int num4 = checked (this.TLParameter.RearEnclosure.Nodes.Count - 1);
          int index1 = 0;
          while (index1 <= num4)
          {
            int num5 = num3 <= this.DriverSetupParameter.TapPosition ? 1 : 0;
            double num6 = num3;
            object tag1 = this.TLParameter.RearEnclosure.Nodes[index1].Tag;
            double length1 = (tag1 != null ? (TLElement) tag1 : tlElement1).Length;
            int num7 = num6 + length1 > this.DriverSetupParameter.TapPosition ? 1 : 0;
            if ((num5 & num7) != 0)
            {
              num1 = index1;
              num2 = this.DriverSetupParameter.TapPosition - num3;
            }
            double num8 = num3;
            object tag2 = this.TLParameter.RearEnclosure.Nodes[index1].Tag;
            double length2 = (tag2 != null ? (TLElement) tag2 : tlElement1).Length;
            num3 = num8 + length2;
            checked { ++index1; }
          }
          int num9 = num1;
          int num10 = checked (this.TLParameter.RearEnclosure.Nodes.Count - 1);
          int index2 = num9;
          TLElement tlElement2;
          while (index2 <= num10)
          {
            if (index2 == num1)
            {
              TreeNode n = this.TLGeometryCalc.FrontEnclosure.Nodes.Add("-");
              object tag = this.TLParameter.RearEnclosure.Nodes[index2].Tag;
              tlElement2 = tag != null ? (TLElement) tag : tlElement1;
              tlElement2.StartArea = Functions.PipeArea(tlElement2.EndArea, tlElement2.StartArea, tlElement2.Length, tlElement2.Length - num2, tlElement2.Taper, tlElement2.HypExpT);
              tlElement2.Length -= num2;
              n.Tag = (object) tlElement2;
              n.Text = Functions.GetTreeString(n);
            }
            else
              this.TLGeometryCalc.FrontEnclosure.Nodes.Add((TreeNode) this.TLParameter.RearEnclosure.Nodes[index2].Clone());
            checked { ++index2; }
          }
          int index3 = 0;
          int index4 = num1;
          while (index4 >= 0)
          {
            if (index4 == num1)
            {
              TreeNode treeNode = this.TLGeometryCalc.FrontEnclosure.Nodes[0].Nodes.Add("-");
              object tag3 = this.TLParameter.RearEnclosure.Nodes[index4].Tag;
              tlElement2 = tag3 != null ? (TLElement) tag3 : tlElement1;
              tlElement2.EndArea = tlElement2.StartArea;
              tlElement2.Length = num2;
              ref TLElement local = ref tlElement2;
              object tag4 = this.TLGeometryCalc.FrontEnclosure.Nodes[0].Tag;
              double startArea = (tag4 != null ? (TLElement) tag4 : tlElement1).StartArea;
              local.StartArea = startArea;
              treeNode.Tag = (object) tlElement2;
            }
            else
            {
              this.TLGeometryCalc.FrontEnclosure.Nodes[0].Nodes.Add((TreeNode) this.TLParameter.RearEnclosure.Nodes[checked (index4 + 1)].Clone());
              object tag = this.TLParameter.RearEnclosure.Nodes[index4].Tag;
              tlElement2 = tag != null ? (TLElement) tag : tlElement1;
              double startArea = tlElement2.StartArea;
              tlElement2.StartArea = tlElement2.EndArea;
              tlElement2.EndArea = startArea;
              this.TLGeometryCalc.FrontEnclosure.Nodes[0].Nodes[index3].Tag = (object) tlElement2;
            }
            checked { ++index3; }
            checked { index4 += -1; }
          }
          object tag5 = this.TLGeometryCalc.FrontEnclosure.Nodes[0].Nodes[checked (index3 - 1)].Tag;
          tlElement2 = (tag5 != null ? (TLElement) tag5 : tlElement1) with
          {
            OpenEnd = false
          };
          this.TLGeometryCalc.FrontEnclosure.Nodes[0].Nodes[checked (index3 - 1)].Tag = (object) tlElement2;
          int num11 = checked (this.TLParameter.RearEnclosure.Nodes[0].Nodes.Count - 1);
          int index5 = 0;
          while (index5 <= num11)
          {
            this.TLGeometryCalc.FrontEnclosure.Nodes[0].Nodes.Add((TreeNode) this.TLParameter.RearEnclosure.Nodes[0].Nodes[index5].Clone());
            checked { ++index5; }
          }
        }
      }
      else if (!Information.IsNothing((object) this.TLParameter.FrontEnclosure))
      {
        int num = checked (this.TLParameter.FrontEnclosure.Nodes.Count - 1);
        int index = 0;
        while (index <= num)
        {
          this.TLGeometryCalc.FrontEnclosure.Nodes.Add((TreeNode) this.TLParameter.FrontEnclosure.Nodes[index].Clone());
          checked { ++index; }
        }
      }
      if (!Information.IsNothing((object) this.TLGeometryCalc.RearEnclosure))
        this.TLGeometryCalc.RearEnclosure.Nodes.Clear();
      else
        this.TLGeometryCalc.RearEnclosure = new TreeNode();
      this.TLGeometryCalc.RearEnclosure.Tag = (object) "Rear";
      int num12 = 0;
      double num13 = 0.0;
      if (Information.IsNothing((object) this.TLParameter.RearEnclosure))
        return;
      double num14 = 0.0;
      int num15 = checked (this.TLParameter.RearEnclosure.Nodes.Count - 1);
      int index6 = 0;
      while (index6 <= num15)
      {
        int num16 = num14 <= this.DriverSetupParameter.DriverPosition ? 1 : 0;
        double num17 = num14;
        object tag6 = this.TLParameter.RearEnclosure.Nodes[index6].Tag;
        double length3 = (tag6 != null ? (TLElement) tag6 : tlElement1).Length;
        int num18 = num17 + length3 > this.DriverSetupParameter.DriverPosition ? 1 : 0;
        if ((num16 & num18) != 0)
        {
          num12 = index6;
          num13 = this.DriverSetupParameter.DriverPosition - num14;
        }
        double num19 = num14;
        object tag7 = this.TLParameter.RearEnclosure.Nodes[index6].Tag;
        double length4 = (tag7 != null ? (TLElement) tag7 : tlElement1).Length;
        num14 = num19 + length4;
        checked { ++index6; }
      }
      int num20 = num12;
      int num21 = checked (this.TLParameter.RearEnclosure.Nodes.Count - 1);
      int index7 = num20;
      TLElement tlElement3;
      while (index7 <= num21)
      {
        if (index7 == num12)
        {
          TreeNode n = this.TLGeometryCalc.RearEnclosure.Nodes.Add("-");
          object tag = this.TLParameter.RearEnclosure.Nodes[index7].Tag;
          tlElement3 = tag != null ? (TLElement) tag : tlElement1;
          tlElement3.StartArea = Functions.PipeArea(tlElement3.EndArea, tlElement3.StartArea, tlElement3.Length, tlElement3.Length - num13, tlElement3.Taper, tlElement3.HypExpT);
          tlElement3.Length -= num13;
          n.Tag = (object) tlElement3;
          n.Text = Functions.GetTreeString(n);
        }
        else
          this.TLGeometryCalc.RearEnclosure.Nodes.Add((TreeNode) this.TLParameter.RearEnclosure.Nodes[index7].Clone());
        checked { ++index7; }
      }
      int index8 = 0;
      int index9 = num12;
      while (index9 >= 0)
      {
        if (index9 == num12)
        {
          TreeNode treeNode = this.TLGeometryCalc.RearEnclosure.Nodes[0].Nodes.Add("-");
          object tag8 = this.TLParameter.RearEnclosure.Nodes[index9].Tag;
          tlElement3 = tag8 != null ? (TLElement) tag8 : tlElement1;
          tlElement3.EndArea = tlElement3.StartArea;
          tlElement3.Length = num13;
          ref TLElement local = ref tlElement3;
          object tag9 = this.TLGeometryCalc.RearEnclosure.Nodes[0].Tag;
          double startArea = (tag9 != null ? (TLElement) tag9 : tlElement1).StartArea;
          local.StartArea = startArea;
          treeNode.Tag = (object) tlElement3;
        }
        else
        {
          this.TLGeometryCalc.RearEnclosure.Nodes[0].Nodes.Add((TreeNode) this.TLParameter.RearEnclosure.Nodes[checked (index9 + 1)].Clone());
          object tag = this.TLParameter.RearEnclosure.Nodes[index9].Tag;
          tlElement3 = tag != null ? (TLElement) tag : tlElement1;
          double startArea = tlElement3.StartArea;
          tlElement3.StartArea = tlElement3.EndArea;
          tlElement3.EndArea = startArea;
          this.TLGeometryCalc.RearEnclosure.Nodes[0].Nodes[index8].Tag = (object) tlElement3;
        }
        checked { ++index8; }
        checked { index9 += -1; }
      }
      object tag10 = this.TLGeometryCalc.RearEnclosure.Nodes[0].Nodes[checked (index8 - 1)].Tag;
      tlElement3 = (tag10 != null ? (TLElement) tag10 : tlElement1) with
      {
        OpenEnd = false
      };
      this.TLGeometryCalc.RearEnclosure.Nodes[0].Nodes[checked (index8 - 1)].Tag = (object) tlElement3;
      int num22 = checked (this.TLParameter.RearEnclosure.Nodes[0].Nodes.Count - 1);
      int index10 = 0;
      while (index10 <= num22)
      {
        this.TLGeometryCalc.RearEnclosure.Nodes[0].Nodes.Add((TreeNode) this.TLParameter.RearEnclosure.Nodes[0].Nodes[index10].Clone());
        checked { ++index10; }
      }
    }

    public void ReCalc(bool NoStackChange = false)
    {
      if (!NoStackChange)
        this.ChangeRoutine();
      else
        this.SaveFromPath(this.CurrentState);
      this.ToolStripProgressBar.Minimum = 0;
      this.ToolStripProgressBar.Maximum = this.Points;
      this.ToolStripProgressBar.Value = 0;
      double num1 = this.DriverParameter.get_Cms(this.SettingsParameter.SpeedOfSound);
      double num2 = this.DriverParameter.get_Mms(this.SettingsParameter.SpeedOfSound);
      double num3 = num2 - 2.0 * Math.Pow(this.DriverParameter.Sd, 2.0) * (8.0 / (29.608813203268074 * Math.Sqrt(this.DriverParameter.Sd / Math.PI))) * Functions.DensityofAir();
      double Bl = this.DriverParameter.get_Bl(this.SettingsParameter.SpeedOfSound);
      double num4 = this.DriverParameter.get_Rms(this.SettingsParameter.SpeedOfSound);
      double Re = this.DriverParameter.Re;
      double num5 = this.DriverParameter.Lvc;
      if (this.DriverSetupParameter.Isobaric)
      {
        num1 = 0.5 * num1;
        num3 = 2.0 * num3;
        double num6 = 2.0 * num4;
        if (this.DriverSetupParameter.Series)
        {
          Re = 2.0 * Re;
          Bl = 2.0 * Bl;
          num5 = 2.0 * num5;
        }
        else
        {
          Re = 0.5 * Re;
          Bl = 1.0 * Bl;
          num5 = 0.5 * num5;
        }
      }
      double Ras = Functions.RasCalc(Bl, this.DriverParameter.Sd, this.DriverParameter.Qes, this.AmplifierParameter.Rg, Re, this.DriverParameter.Qms);
      double num7 = num3 / Math.Pow(this.DriverParameter.Sd, 2.0);
      double Mas = num2 / Math.Pow(this.DriverParameter.Sd, 2.0);
      double Cas = num1 * Math.Pow(this.DriverParameter.Sd, 2.0);
      double Lces = Functions.LcesCalc(Cas, Bl, this.DriverParameter.Sd);
      double Cmes = Functions.CmesCalc(Mas, this.DriverParameter.Sd, Bl);
      double Res = Functions.ResCalc(Re, this.DriverParameter.Qms, this.DriverParameter.Qes, this.AmplifierParameter.Rg);
      double num8 = (double) this.Points / (Math.Log10(this.SettingsParameter.EndFreq / this.SettingsParameter.StartFreq) / Math.Log10(2.0));
      double num9 = Math.Sqrt(this.DriverParameter.Re * this.AmplifierParameter.Power);
      Complex complex1 = new Complex(0.0, 1.0);
      this.CreateCalcTree();
      int points = this.Points;
      int index1 = 0;
      while (index1 <= points)
      {
        double num10 = this.SettingsParameter.StartFreq * Math.Pow(2.0, (double) index1 / num8);
        Complex complex2 = this.FilterParameter.LowPass.Response(num10) * this.FilterParameter.HighPass.Response(num10) * (num9 * Bl) / (this.DriverParameter.Sd * (Re + this.AmplifierParameter.Rg + Functions.InductorImpedance(num5, num10)));
        Complex complex3 = Functions.RatCalc(num10, num5, Ras, Bl, this.DriverParameter.Sd, this.AmplifierParameter.Rg, Re);
        this.Zr[index1] = Functions.RadiationImpedance(num10, Math.Sqrt(this.DriverParameter.Sd / Math.PI), this.SettingsParameter.SpeedOfSound);
        this.UpdateImpedances(this.TLGeometryCalc.RearEnclosure, num10);
        this.UpdateImpedances(this.TLGeometryCalc.FrontEnclosure, num10);
        this.ZiRear[index1] = this.TLGeometryCalc.RearEnclosure.Nodes.Count <= 0 ? this.Zr[index1] : Functions.BranchInputImpedance(this.TLGeometryCalc.RearEnclosure.Nodes[0]);
        this.ZiFront[index1] = this.TLGeometryCalc.FrontEnclosure.Nodes.Count <= 0 ? this.Zr[index1] : Functions.BranchInputImpedance(this.TLGeometryCalc.FrontEnclosure.Nodes[0]);
        this.Zes[index1] = Functions.ZesCalc(num10, this.AmplifierParameter.Rg, Re, num5, Lces, Cmes, Res);
        this.Zt[index1] = Functions.ZetCalc(num10, this.AmplifierParameter.Rg, Re, num5, Lces, Cmes, Res, Functions.ElectricalImpedance(this.ZiRear[index1], Bl, this.DriverParameter.Sd), Functions.ElectricalImpedance(this.ZiFront[index1], Bl, this.DriverParameter.Sd));
        Complex complex4 = complex2 / (1.0 / (complex1 * 2.0 * Math.PI * num10 * Cas) + complex3 + complex1 * 2.0 * Math.PI * num10 * num7 + this.ZiRear[index1] + this.ZiFront[index1]);
        Complex VolumeVelocity = complex2 / (1.0 / (complex1 * 2.0 * Math.PI * num10 * Cas) + complex3 + complex1 * 2.0 * Math.PI * num10 * num7 + this.Zr[index1] + this.Zr[index1]);
        this.GetUTerminus(complex4);
        this.Displaced[index1] = complex4.Magnitude / this.DriverParameter.Sd / (2.0 * Math.PI * num10);
        this.Displacei[index1] = VolumeVelocity.Magnitude / this.DriverParameter.Sd / (2.0 * Math.PI * num10);
        this.pi[index1] = Functions.RadiationPressure(VolumeVelocity, this.DriverParameter.Sd, 1.0, this.SettingsParameter.SpeedOfSound, num10);
        this.pd[index1] = !(this.TLGeometryCalc.RearEnclosure.Nodes.Count == 0 | this.TLGeometryCalc.FrontEnclosure.Nodes.Count == 0) ? new Complex(0.0, 0.0) : Functions.RadiationPressure(complex4, this.DriverParameter.Sd, 1.0, this.SettingsParameter.SpeedOfSound, num10);
        this.pl[index1] = new Complex(0.0, 0.0);
        if (this.VelocityMultiL.GetUpperBound(1) != this.UTerminus.GetUpperBound(0))
          this.VelocityMultiL = (double[,]) Utils.CopyArray((Array) this.VelocityMultiL, (Array) new double[checked (this.Points + 1), checked (this.UTerminus.GetUpperBound(0) + 1)]);
        int upperBound = this.UTerminus.GetUpperBound(0);
        int index2 = 0;
        while (index2 <= upperBound)
        {
          this.VelocityMultiL[index1, index2] = this.UTerminus[index2].Magnitude / this.TerminusArea[index2];
          this.pl[index1] = this.pl[index1] + Functions.RadiationPressure(this.UTerminus[index2], this.TerminusArea[index2], 1.0, this.SettingsParameter.SpeedOfSound, num10);
          checked { ++index2; }
        }
        this.ToolStripProgressBar.Value = index1;
        Application.DoEvents();
        checked { ++index1; }
      }
      this.DataBool = true;
      this.UpDateDisplays();
      this.ToolStripProgressBar.Value = 0;
    }

    private void GetUTerminus(Complex UDriver)
    {
      this.UTerminus = new Complex[0];
      this.TerminusArea = new double[0];
      try
      {
        foreach (TreeNode node in this.TLGeometryCalc.RearEnclosure.Nodes)
          this.GetUTerminusRecursive(node, UDriver, this.TLGeometryCalc.RearEnclosure);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (TreeNode node in this.TLGeometryCalc.FrontEnclosure.Nodes)
          this.GetUTerminusRecursive(node, UDriver, this.TLGeometryCalc.FrontEnclosure);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void GetUTerminusRecursive(TreeNode n, Complex UDriver, TreeNode Tree)
    {
      if (checked (n.Parent.Nodes.Count - 1) == n.Index)
      {
        object tag1 = n.Tag;
        TLElement tlElement1 = default;
        TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
        if (tlElement2.OpenEnd)
        {
          this.UTerminus = (Complex[]) Utils.CopyArray((Array) this.UTerminus, (Array) new Complex[checked (this.UTerminus.GetUpperBound(0) + 1 + 1)]);
          Complex complex = Functions.TreeURatioFromPath(Tree, Functions.TreeFullPath(n));
          this.TerminusArea = (double[]) Utils.CopyArray((Array) this.TerminusArea, (Array) new double[checked (this.TerminusArea.GetUpperBound(0) + 1 + 1)]);
          double[] terminusArea = this.TerminusArea;
          int upperBound = this.TerminusArea.GetUpperBound(0);
          object tag2 = n.Tag;
          tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
          double endArea = tlElement2.EndArea;
          terminusArea[upperBound] = endArea;
          if (Operators.CompareString(Strings.Split(Functions.GetTreeString(n), ".")[0], "Rear", false) == 0)
            this.UTerminus[this.UTerminus.GetUpperBound(0)] = complex * (0.0 - UDriver);
          else
            this.UTerminus[this.UTerminus.GetUpperBound(0)] = complex * UDriver;
        }
      }
      try
      {
        foreach (TreeNode node in n.Nodes)
          this.GetUTerminusRecursive(node, UDriver, Tree);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void LoadDefault()
    {
      this.TLParameter.Width = 0.3;
      this.DriverSetupParameter.DriverPosition = 0.0;
      this.DriverSetupParameter.Tapped = false;
      this.DriverSetupParameter.TapPosition = 1.0;
      TLElement tlElement = default;
      tlElement.Length = 2.3;
      tlElement.StartArea = 0.152;
      tlElement.EndArea = 0.017;
      tlElement.Taper = 1;
      tlElement.HypExpT = 1.0;
      tlElement.StuffingDensity = 0.16;
      tlElement.OpenEnd = true;
      this.TLParameter.FrontEnclosure = new TreeNode();
      this.TLParameter.FrontEnclosure.Nodes.Clear();
      this.TLParameter.FrontEnclosure.Tag = (object) "Front";
      this.TLParameter.RearEnclosure = new TreeNode();
      this.TLParameter.RearEnclosure.Tag = (object) "Rear";
      this.TLParameter.RearEnclosure.Nodes.Clear();
      this.TLParameter.RearEnclosure.Nodes.Add("").Tag = (object) tlElement;
      this.DriverParameter.Title = "Default";
      this.DriverParameter.Sd = 0.05067;
      this.DriverParameter.Qes = 0.389;
      this.DriverParameter.Qms = 13.323;
      this.DriverParameter.Lvc = 0.00148;
      this.DriverParameter.Re = 4.29;
      this.DriverParameter.Fs = 22.264;
      this.DriverParameter.Vas = 0.127;
      this.DriverSetupParameter.Isobaric = false;
      this.DriverSetupParameter.Series = true;
      this.AmplifierParameter.Power = 1.0;
      this.AmplifierParameter.Rg = 0.1;
      this.FilterParameter.LowPass.Active = false;
      this.FilterParameter.LowPass.fo = 100.0;
      this.FilterParameter.LowPass.Q = 0.707;
      this.FilterParameter.HighPass.Active = false;
      this.FilterParameter.HighPass.fo = 20.0;
      this.FilterParameter.HighPass.Q = 0.707;
    }

    private void OpenRecentFile(object sender, EventArgs e) => this.OpenProjectFile(Conversions.ToString(((ToolStripItem) sender).Tag));

    private void UpdateRecentFiles()
    {
      if (!Information.IsNothing((object) MySettingsProperty.Settings.RecentFiles))
      {
        int index1 = 0;
        while (index1 < MySettingsProperty.Settings.RecentFiles.Count)
        {
          if (!System.IO.File.Exists(MySettingsProperty.Settings.RecentFiles[index1]))
            MySettingsProperty.Settings.RecentFiles.RemoveAt(index1);
          checked { ++index1; }
        }
        ToolStripMenuItem[] arySrc = new ToolStripMenuItem[0];
        this.RecentFilesToolStripMenuItem.DropDownItems.Clear();
        int num = checked (MySettingsProperty.Settings.RecentFiles.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          arySrc = (ToolStripMenuItem[]) Utils.CopyArray((Array) arySrc, (Array) new ToolStripMenuItem[checked (arySrc.GetUpperBound(0) + 1 + 1)]);
          arySrc[arySrc.GetUpperBound(0)] = new ToolStripMenuItem(MySettingsProperty.Settings.RecentFiles[index2]);
          arySrc[arySrc.GetUpperBound(0)].Tag = (object) MySettingsProperty.Settings.RecentFiles[index2];
          arySrc[arySrc.GetUpperBound(0)].Click += new EventHandler(this.OpenRecentFile);
          this.RecentFilesToolStripMenuItem.DropDownItems.Add((ToolStripItem) arySrc[arySrc.GetUpperBound(0)]);
          checked { ++index2; }
        }
      }
      else
        MySettingsProperty.Settings.RecentFiles = new StringCollection();
      if (this.RecentFilesToolStripMenuItem.DropDownItems.Count > 0)
        this.RecentFilesToolStripMenuItem.Enabled = true;
      else
        this.RecentFilesToolStripMenuItem.Enabled = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Width = MySettingsProperty.Settings.Form1Width;
      this.Height = MySettingsProperty.Settings.Form1Height;
      this.UpdateRecentFiles();
      this.ToolStripProgressBar.Minimum = 0;
      this.ToolStripProgressBar.Maximum = this.Points;
      this.UpdateSettingsfromFile();
      this.SetupGraphs();
      this.Saved = true;
      if (AppDomain.CurrentDomain.SetupInformation.ActivationArguments?.ActivationData != null)
      {
        string[] activationData = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
        int index = 0;
        while (index < activationData.Length)
        {
          string str1 = activationData[index];
          if (Operators.CompareString(Strings.Left(str1, 8), "file:///", false) == 0)
            str1 = Strings.Mid(str1, 9);
          string str2 = Strings.Replace(Strings.Replace(str1, "%20", " "), "/", "\\");
          if (System.IO.File.Exists(str2))
          {
            this.OpenProjectFile(str2);
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) ("Error opening file. Invalid Filepath\r\n" + str2 + "\r\nPlease report error to peter@leonardaudio.co.uk"));
            this.NewProject();
          }
          checked { ++index; }
        }
      }
      else
        this.NewProject();
    }

    private void TitleChange()
    {
      string str;
      if (this.Open & !Information.IsNothing((object) this.CurrentFile))
      {
        string[] strArray = Strings.Split(this.CurrentFile, "\\");
        str = Strings.Split(strArray[strArray.GetUpperBound(0)], ".")[0];
      }
      else
        str = "Untitled";
      this.Text = this.Saved ? str + " - Leonard Audio - Transmission Line [Beta]" : str + "* - Leonard Audio - Transmission Line [Beta]";
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!this.Saved)
      {
        switch (Interaction.MsgBox((object) "Do you want to save changes?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Exclamation, (object) "Transmission Line"))
        {
          case MsgBoxResult.Cancel:
            e.Cancel = true;
            break;
          case MsgBoxResult.Yes:
            if (this.Open)
              this.SaveFromPath(this.CurrentFile);
            else
              this.SaveProjectAs();
            e.Cancel = false;
            break;
          case MsgBoxResult.No:
            e.Cancel = false;
            break;
        }
      }
      this.DeleteTempFiles();
      this.UpdateSettingstoFile();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void Form1_Shown(object sender, EventArgs e)
    {
      this.FormLoaded = true;
      while (!Directory.Exists(MySettingsProperty.Settings.DriverLibrary))
      {
        int num = (int) Interaction.MsgBox((object) "Please specify or create a directory to store driver information");
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.Description = "Select Driver Library Location";
        folderBrowserDialog.ShowNewFolderButton = true;
        folderBrowserDialog.SelectedPath = "C:\\";
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
          MySettingsProperty.Settings.DriverLibrary = folderBrowserDialog.SelectedPath;
          this.SettingsParameter.DriverLibrary = MySettingsProperty.Settings.DriverLibrary;
        }
      }
      if (!Debugger.IsAttached)
      {
        if (Operators.CompareString(MySettingsProperty.Settings.LastVersion, MyProject.Application.Info.Version.ToString(), false) == 0)
          return;
        int num = (int) new UpdateInformationDialog(MySettingsProperty.Settings.LastVersion).ShowDialog();
        this.SendUsageReport();
      }
      else
      {
        int num = (int) new UpdateInformationDialog("3.6.2.0").ShowDialog();
        MySettingsProperty.Settings.LastVersion = MyProject.Application.Info.Version.ToString();
      }
    }

    private void NewProject()
    {
      if (!this.Saved)
      {
        switch (Interaction.MsgBox((object) "Do you want to save changes?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Exclamation, (object) "Transmission Line"))
        {
          case MsgBoxResult.Cancel:
            return;
          case MsgBoxResult.Yes:
            if (this.Open)
            {
              this.SaveFromPath(this.CurrentFile);
              break;
            }
            this.SaveProjectAs();
            break;
        }
      }
      this.DeleteTempFiles();
      this.SetupTempFiles();
      this.Open = false;
      this.Saved = true;
      this.CurrentFile = (string) null;
      this.LoadDefault();
      this.UpdateOpenWindows();
      this.ReCalc(true);
      this.TitleChange();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void ReportError(Exception ex, string Description)
    {
      clsComputerInfo clsComputerInfo = new clsComputerInfo();
      if (this.SendMail("Error Report" + "\r\nDate: " + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture) + "\r\nVersion: " + MyProject.Application.Info.Version.ToString() + "\r\nOS Version: " + Environment.OSVersion.ToString() + "\r\nUser Name: " + Environment.UserName.ToString() + "\r\nCPUID: " + clsComputerInfo.GetProcessorId() + "\r\nMOBOID: " + clsComputerInfo.GetMotherBoardID() + "\r\nMACAddress: " + clsComputerInfo.GetMACAddress() + "\r\nVolume Serial: " + clsComputerInfo.GetVolumeSerial() + "\r\nHardcoded Description: " + Description + "\r\nException Report: " + ex.ToString(), "Error Report"))
        return;
      int num = (int) Interaction.MsgBox((object) ("An error has occured and an error report cannot be submitted. Please email peter@leonardaudio.co.uk with the following error report:\r\n" + ex.Message));
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SendUsageReport()
    {
      try
      {
        clsComputerInfo clsComputerInfo = new clsComputerInfo();
        byte[] bytes = Encoding.ASCII.GetBytes("&Password=" + Uri.EscapeUriString("whodareswins") + "&Version=" + Uri.EscapeUriString(MyProject.Application.Info.Version.ToString()) + "&MachineName=" + Uri.EscapeUriString(Environment.MachineName.ToString()) + "&OSVersion=" + Uri.EscapeUriString(Environment.OSVersion.ToString()) + "&UserName=" + Uri.EscapeUriString(Environment.UserName.ToString()) + "&DotNetVersion=" + Uri.EscapeUriString(Environment.Version.ToString()) + "&Network=" + Uri.EscapeUriString(Environment.UserDomainName.ToString()) + "&Bit=" + Uri.EscapeUriString(Environment.Is64BitOperatingSystem.ToString()) + "&Screens=" + Uri.EscapeUriString(((IEnumerable<Screen>) Screen.AllScreens).Count<Screen>().ToString()) + "&ScreenWidth=" + Uri.EscapeUriString(Screen.PrimaryScreen.Bounds.Width.ToString()) + "&ScreenHeight=" + Uri.EscapeUriString(Screen.PrimaryScreen.Bounds.Height.ToString()) + "&CPUID=" + Uri.EscapeUriString(clsComputerInfo.GetProcessorId()) + "&MOBOID=" + Uri.EscapeUriString(clsComputerInfo.GetMotherBoardID()) + "&MACAddress=" + Uri.EscapeUriString(clsComputerInfo.GetMACAddress()) + "&VolumeSerial=" + Uri.EscapeUriString(clsComputerInfo.GetVolumeSerial()));
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create("http://www.leonardaudio.co.uk/LogData.php");
        httpWebRequest.UserAgent = "TL Application Agent";
        httpWebRequest.Method = "POST";
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        httpWebRequest.ContentLength = (long) bytes.Length;
        Stream requestStream = httpWebRequest.GetRequestStream();
        requestStream.Write(bytes, 0, bytes.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        MySettingsProperty.Settings.LastVersion = MyProject.Application.Info.Version.ToString();
      }
    }

    public bool SendMail(string Message, string Subject) => new Email("mail.leonardaudio.co.uk", "peter@leonardaudio.co.uk", "whodareswins")
    {
      SMTPPort = 525,
      UseEncryption = false,
      Tos = {
        "peter@leonardaudio.co.uk"
      },
      subject = Subject,
      message = Message
    }.sendEmail() == Email.sendEmailResult.successful;

    private void Form1_ResizeEnd(object sender, EventArgs e)
    {
      if (!(this.Width > 0 & this.Height > 0 & this.FormLoaded))
        return;
      this.DrawGraphAxis();
      this.UpdateGraphwithData();
      this.UpdateGraphDisplays();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      if (this.WindowState != this.PreviousWindowState & this.FormLoaded & this.WindowState != FormWindowState.Minimized)
      {
        this.DrawGraphAxis();
        this.UpdateGraphwithData();
        this.UpdateGraphDisplays();
      }
      this.PreviousWindowState = this.WindowState;
    }

    private void TabControl1_TabIndexChanged(object sender, EventArgs e)
    {
      if (!(this.Width > 0 & this.Height > 0 & this.FormLoaded))
        return;
      this.DrawGraphAxis();
      this.UpdateGraphwithData();
      this.UpdateGraphDisplays();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void HelpToolStripMenuItem1_Click(object sender, EventArgs e) => Process.Start(MyProject.Application.Info.DirectoryPath + "\\Resources\\TL-UserGuide.pdf");

    private void SetupGraphs()
    {
      this.SPLGraph = new myGraphClass("Sound Pressure Level", "Frequency (Hz)", "SPL (dB)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.LwMin, this.SettingsParameter.LwMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.LwLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.ZiGraph = new myGraphClass("TL Acoustic Input Impedance", "Frequency (Hz)", "Acoustic Impedance / pc", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.InputImpedanceMin, this.SettingsParameter.InputImpedanceMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.InputImpedanceLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.ZesGraph = new myGraphClass("Driver Electrical Impedance", "Frequency (Hz)", "Electrical Impedance (Ω)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.DriverImpedanceMin, this.SettingsParameter.DriverImpedanceMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.DriverImpedanceLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.ZtGraph = new myGraphClass("System Electrical Impedance", "Frequency (Hz)", "Electrical Impedance (Ω)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.SystemImpedanceMin, this.SettingsParameter.SystemImpedanceMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.SystemImpedanceLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.ZrGraph = new myGraphClass("Radiation Impedance", "Frequency (Hz)", "Acoustic Impedance (N.s.m⁻\u00B3)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.RadiationImpedanceMin, this.SettingsParameter.RadiationImpedanceMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.RadiationImpedanceLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.PhaseGraph = new myGraphClass("Phase", "Frequency (Hz)", "Phase (deg)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.PhaseMin, this.SettingsParameter.PhaseMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.PhaseLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.DisplaceGraph = new myGraphClass("Displacement", "Frequency (Hz)", "Displacement (mm)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.DisplaceMin, this.SettingsParameter.DisplaceMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.DisplaceLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.VelocityGraph = new myGraphClass("Velocity", "Frequency (Hz)", "Air Velocity (m.s⁻\u00B9)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.VelocityMin, this.SettingsParameter.VelocityMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.VelocityLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.GroupDelayGraph = new myGraphClass("Group Delay", "Frequency (Hz)", "Group Delay (ms)", this.SettingsParameter.StartFreq, this.SettingsParameter.EndFreq, this.SettingsParameter.GroupDelayMin, this.SettingsParameter.GroupDelayMax, this.SettingsParameter.FrequencyLog, this.SettingsParameter.GroupDelayLog, this.TopMargin, this.BottomMargin, this.LeftMargin, this.RightMargin);
      this.DrawGraphAxis();
    }

    private void DrawGraphAxis()
    {
      this.SPLGraph.DrawAxis(this.LpDisplay.Width, this.LpDisplay.Height);
      this.ZiGraph.DrawAxis(this.ZiDisplay.Width, this.ZiDisplay.Height);
      this.ZesGraph.DrawAxis(this.ZasDisplay.Width, this.ZasDisplay.Height);
      this.ZtGraph.DrawAxis(this.ZtDisplay.Width, this.ZtDisplay.Height);
      this.ZrGraph.DrawAxis(this.ZrDisplay.Width, this.ZrDisplay.Height);
      this.PhaseGraph.DrawAxis(this.LpPhaseDisplay.Width, this.LpPhaseDisplay.Height);
      this.DisplaceGraph.DrawAxis(this.DisplaceDisplay.Width, this.DisplaceDisplay.Height);
      this.VelocityGraph.DrawAxis(this.VelocityDisplay.Width, this.VelocityDisplay.Height);
      this.GroupDelayGraph.DrawAxis(this.GroupDelayDisplay.Width, this.GroupDelayDisplay.Height);
    }

    private void Graph_CheckedChanged(object sender, EventArgs e)
    {
      this.DisplaceGraphNum = 0;
      this.GroupDelayGraphNum = 0;
      this.LpGraphNum = 0;
      if (this.IBCheck.Checked)
      {
        checked { ++this.LpGraphNum; }
        checked { ++this.GroupDelayGraphNum; }
        checked { ++this.DisplaceGraphNum; }
      }
      if (this.DriverCheck.Checked)
      {
        checked { ++this.LpGraphNum; }
        checked { ++this.DisplaceGraphNum; }
      }
      if (this.TerminusCheck.Checked)
        checked { ++this.LpGraphNum; }
      if (this.SystemCheck.Checked)
      {
        checked { ++this.LpGraphNum; }
        checked { ++this.GroupDelayGraphNum; }
      }
      this.UpDateDisplays();
    }

    private void UpDateDisplays()
    {
      if (!this.DataBool)
        return;
      this.SetupDisplayVariables();
      double num1 = (double) this.Points / (Math.Log10(this.SettingsParameter.EndFreq / this.SettingsParameter.StartFreq) / Math.Log10(2.0));
      double startFreq = this.SettingsParameter.StartFreq;
      int points = this.Points;
      int index1 = 0;
      while (index1 <= points)
      {
        this.XSeries[index1] = startFreq;
        this.ZrData.YSeries[0].Points[index1] = this.Zr[index1].Real;
        this.ZrData.YSeries[1].Points[index1] = this.Zr[index1].Imaginary;
        this.ZiData.YSeries[0].Points[index1] = this.ZiRear[index1].Magnitude / (Functions.DensityofAir() * this.SettingsParameter.SpeedOfSound);
        this.ZesData.YSeries[0].Points[index1] = this.Zes[index1].Magnitude;
        this.ZtData.YSeries[0].Points[index1] = this.Zt[index1].Magnitude;
        int upperBound = this.VelocityMultiL.GetUpperBound(1);
        int index2 = 0;
        while (index2 <= upperBound)
        {
          this.VelocityData.YSeries[index2].Points[index1] = this.VelocityMultiL[index1, index2];
          checked { ++index2; }
        }
        int index3 = 0;
        int index4 = 0;
        if (this.IBCheck.Checked)
        {
          this.LPData.YSeries[index4].Points[index1] = 20.0 * Math.Log10(this.pi[index1].Magnitude / 2E-05);
          this.PhaseData.YSeries[index4].Points[index1] = this.pi[index1].Arg * (180.0 / Math.PI);
          this.DisplaceData.YSeries[index3].Points[index1] = this.Displacei[index1] * 1000.0;
          checked { ++index4; }
          checked { ++index3; }
        }
        if (this.DriverCheck.Checked)
        {
          this.LPData.YSeries[index4].Points[index1] = 20.0 * Math.Log10(this.pd[index1].Magnitude / 2E-05);
          this.PhaseData.YSeries[index4].Points[index1] = this.pd[index1].Arg * (180.0 / Math.PI);
          this.DisplaceData.YSeries[index3].Points[index1] = this.Displaced[index1] * 1000.0;
          checked { ++index4; }
          int num2 = checked (index3 + 1);
        }
        if (this.TerminusCheck.Checked)
        {
          this.LPData.YSeries[index4].Points[index1] = 20.0 * Math.Log10(this.pl[index1].Magnitude / 2E-05);
          this.PhaseData.YSeries[index4].Points[index1] = this.pl[index1].Arg * (180.0 / Math.PI);
          checked { ++index4; }
        }
        Complex complex = this.pd[index1] + this.pl[index1];
        if (this.SystemCheck.Checked)
        {
          this.LPData.YSeries[index4].Points[index1] = 20.0 * Math.Log10(complex.Magnitude / 2E-05);
          this.PhaseData.YSeries[index4].Points[index1] = complex.Arg * (180.0 / Math.PI);
          int num3 = checked (index4 + 1);
        }
        double num4 = 0;
        double num5 = 0;
        double num6 = 0;
        double num7 = 0;
        if (index1 > 0)
        {
          double num8 = num4 - num5;
          int index5 = 0;
          if (this.IBCheck.Checked)
          {
            double num9 = -((this.pi[index1].Arg - num6) / num8);
            this.GroupDelayData.YSeries[index5].Points[index1] = num9 * 1000.0;
            if (index1 == 1)
              this.GroupDelayData.YSeries[index5].Points[0] = this.GroupDelayData.YSeries[index5].Points[1];
            if (this.GroupDelayData.YSeries[index5].Points[index1] < -100.0 | this.GroupDelayData.YSeries[index5].Points[index1] > 100.0)
              this.GroupDelayData.YSeries[index5].Points[index1] = this.GroupDelayData.YSeries[index5].Points[checked (index1 - 1)];
            checked { ++index5; }
          }
          if (this.SystemCheck.Checked)
          {
            double num10 = -((complex.Arg - num7) / num8);
            this.GroupDelayData.YSeries[index5].Points[index1] = num10 * 1000.0;
            if (index1 == 1)
              this.GroupDelayData.YSeries[index5].Points[0] = this.GroupDelayData.YSeries[index5].Points[1];
            if (this.GroupDelayData.YSeries[index5].Points[index1] < -100.0 | this.GroupDelayData.YSeries[index5].Points[index1] > 100.0)
              this.GroupDelayData.YSeries[index5].Points[index1] = this.GroupDelayData.YSeries[index5].Points[checked (index1 - 1)];
            int num11 = checked (index5 + 1);
          }
        }
        num7 = complex.Arg;
        num6 = this.pi[index1].Arg;
        num5 = 2.0 * Math.PI * startFreq;
        startFreq *= Math.Pow(2.0, 1.0 / num1);
        num4 = 2.0 * Math.PI * startFreq;
        checked { ++index1; }
      }
      this.ZrData.XSeries = this.XSeries;
      this.ZiData.XSeries = this.XSeries;
      this.ZesData.XSeries = this.XSeries;
      this.ZtData.XSeries = this.XSeries;
      this.LPData.XSeries = this.XSeries;
      this.PhaseData.XSeries = this.XSeries;
      this.DisplaceData.XSeries = this.XSeries;
      this.VelocityData.XSeries = this.XSeries;
      this.GroupDelayData.XSeries = this.XSeries;
      this.SPLGraph.SetData = this.LPData;
      this.ZiGraph.SetData = this.ZiData;
      this.ZesGraph.SetData = this.ZesData;
      this.ZtGraph.SetData = this.ZtData;
      this.ZrGraph.SetData = this.ZrData;
      this.PhaseGraph.SetData = this.PhaseData;
      this.DisplaceGraph.SetData = this.DisplaceData;
      this.VelocityGraph.SetData = this.VelocityData;
      this.GroupDelayGraph.SetData = this.GroupDelayData;
      this.UpdateGraphwithData();
      this.UpdateGraphDisplays();
    }

    private void UpdateGraphwithData()
    {
      this.SPLGraph.DrawData(this.LpDisplay.Width, this.LpDisplay.Height);
      this.ZiGraph.DrawData(this.ZiDisplay.Width, this.ZiDisplay.Height);
      this.ZesGraph.DrawData(this.ZasDisplay.Width, this.ZasDisplay.Height);
      this.ZtGraph.DrawData(this.ZtDisplay.Width, this.ZtDisplay.Height);
      this.ZrGraph.DrawData(this.ZrDisplay.Width, this.ZrDisplay.Height);
      this.PhaseGraph.DrawData(this.LpPhaseDisplay.Width, this.LpPhaseDisplay.Height);
      this.DisplaceGraph.DrawData(this.DisplaceDisplay.Width, this.DisplaceDisplay.Height);
      this.VelocityGraph.DrawData(this.VelocityDisplay.Width, this.VelocityDisplay.Height);
      this.GroupDelayGraph.DrawData(this.GroupDelayDisplay.Width, this.GroupDelayDisplay.Height);
    }

    private void UpdateGraphDisplays()
    {
      PictureBox ziDisplay = this.ZiDisplay;
      this.UpdateGraph(ref ziDisplay, this.ZiGraph.GetImage);
      this.ZiDisplay = ziDisplay;
      PictureBox zasDisplay = this.ZasDisplay;
      this.UpdateGraph(ref zasDisplay, this.ZesGraph.GetImage);
      this.ZasDisplay = zasDisplay;
      PictureBox ztDisplay = this.ZtDisplay;
      this.UpdateGraph(ref ztDisplay, this.ZtGraph.GetImage);
      this.ZtDisplay = ztDisplay;
      PictureBox zrDisplay = this.ZrDisplay;
      this.UpdateGraph(ref zrDisplay, this.ZrGraph.GetImage);
      this.ZrDisplay = zrDisplay;
      PictureBox lpDisplay = this.LpDisplay;
      this.UpdateGraph(ref lpDisplay, this.SPLGraph.GetImage);
      this.LpDisplay = lpDisplay;
      PictureBox lpPhaseDisplay = this.LpPhaseDisplay;
      this.UpdateGraph(ref lpPhaseDisplay, this.PhaseGraph.GetImage);
      this.LpPhaseDisplay = lpPhaseDisplay;
      PictureBox displaceDisplay = this.DisplaceDisplay;
      this.UpdateGraph(ref displaceDisplay, this.DisplaceGraph.GetImage);
      this.DisplaceDisplay = displaceDisplay;
      PictureBox velocityDisplay = this.VelocityDisplay;
      this.UpdateGraph(ref velocityDisplay, this.VelocityGraph.GetImage);
      this.VelocityDisplay = velocityDisplay;
      PictureBox groupDelayDisplay = this.GroupDelayDisplay;
      this.UpdateGraph(ref groupDelayDisplay, this.GroupDelayGraph.GetImage);
      this.GroupDelayDisplay = groupDelayDisplay;
    }

    private void UpdateGraph(ref PictureBox Display, Bitmap GraphImage)
    {
      Display.Image = (Image) new Bitmap(Display.Width, Display.Height);
      Graphics graphics = Graphics.FromImage(Display.Image);
      graphics.DrawImage((Image) GraphImage, 0, 0);
      graphics.Dispose();
      Display.Invalidate();
    }

    private void SetupDisplayVariables()
    {
      this.VelocityData.YSeries = new Series[checked (this.VelocityMultiL.GetUpperBound(1) + 1)];
      int upperBound = this.VelocityMultiL.GetUpperBound(1);
      int index1 = 0;
      while (index1 <= upperBound)
      {
        this.VelocityData.YSeries[index1].Points = new double[checked (this.Points + 1)];
        this.VelocityData.YSeries[index1].Name = "Terminus " + index1.ToString();
        switch (index1)
        {
          case 0:
            this.VelocityData.YSeries[index1].Color = Color.Blue;
            break;
          case 1:
            this.VelocityData.YSeries[index1].Color = Color.Red;
            break;
          case 2:
            this.VelocityData.YSeries[index1].Color = Color.Green;
            break;
          case 3:
            this.VelocityData.YSeries[index1].Color = Color.Black;
            break;
          default:
            this.VelocityData.YSeries[index1].Color = Color.DarkBlue;
            break;
        }
        checked { ++index1; }
      }
      this.ZrData.YSeries = new Series[2];
      this.ZrData.YSeries[0].Points = new double[checked (this.Points + 1)];
      this.ZrData.YSeries[1].Points = new double[checked (this.Points + 1)];
      this.ZrData.YSeries[0].Name = "Resitance";
      this.ZrData.YSeries[0].Color = Color.Red;
      this.ZrData.YSeries[1].Name = "Reactance";
      this.ZrData.YSeries[1].Color = Color.Blue;
      this.ZiData.YSeries = new Series[1];
      this.ZiData.YSeries[0].Points = new double[checked (this.Points + 1)];
      this.ZiData.YSeries[0].Name = "Magnitude";
      this.ZiData.YSeries[0].Color = Color.Red;
      this.ZesData.YSeries = new Series[1];
      this.ZesData.YSeries[0].Points = new double[checked (this.Points + 1)];
      this.ZesData.YSeries[0].Name = "Magnitude";
      this.ZesData.YSeries[0].Color = Color.Red;
      this.ZtData.YSeries = new Series[1];
      this.ZtData.YSeries[0].Points = new double[checked (this.Points + 1)];
      this.ZtData.YSeries[0].Name = "Magnitude";
      this.ZtData.YSeries[0].Color = Color.Red;
      this.LPData.YSeries = new Series[checked (this.LpGraphNum - 1 + 1)];
      this.PhaseData.YSeries = new Series[checked (this.LpGraphNum - 1 + 1)];
      this.GroupDelayData.YSeries = new Series[checked (this.GroupDelayGraphNum - 1 + 1)];
      this.DisplaceData.YSeries = new Series[checked (this.DisplaceGraphNum - 1 + 1)];
      int index2 = 0;
      int index3 = 0;
      int index4 = 0;
      if (this.IBCheck.Checked)
      {
        this.LPData.YSeries[index2].Points = new double[checked (this.Points + 1)];
        this.LPData.YSeries[index2].Name = "Infinite Baffle";
        this.LPData.YSeries[index2].Color = Color.Blue;
        this.PhaseData.YSeries[index2].Points = new double[checked (this.Points + 1)];
        this.PhaseData.YSeries[index2].Name = "Infinite Baffle";
        this.PhaseData.YSeries[index2].Color = Color.Blue;
        this.GroupDelayData.YSeries[index3].Points = new double[checked (this.Points + 1)];
        this.GroupDelayData.YSeries[index3].Name = "Infinite Baffle";
        this.GroupDelayData.YSeries[index3].Color = Color.Blue;
        this.DisplaceData.YSeries[index4].Points = new double[checked (this.Points + 1)];
        this.DisplaceData.YSeries[index4].Name = "Infinite Baffle";
        this.DisplaceData.YSeries[index4].Color = Color.Blue;
        checked { ++index2; }
        checked { ++index3; }
        checked { ++index4; }
      }
      if (this.DriverCheck.Checked)
      {
        this.LPData.YSeries[index2].Points = new double[checked (this.Points + 1)];
        this.LPData.YSeries[index2].Name = "Driver";
        this.LPData.YSeries[index2].Color = Color.Red;
        this.PhaseData.YSeries[index2].Points = new double[checked (this.Points + 1)];
        this.PhaseData.YSeries[index2].Name = "Driver";
        this.PhaseData.YSeries[index2].Color = Color.Red;
        this.DisplaceData.YSeries[index4].Points = new double[checked (this.Points + 1)];
        this.DisplaceData.YSeries[index4].Name = "Driver";
        this.DisplaceData.YSeries[index4].Color = Color.Red;
        checked { ++index2; }
        int num = checked (index4 + 1);
      }
      if (this.TerminusCheck.Checked)
      {
        this.LPData.YSeries[index2].Points = new double[checked (this.Points + 1)];
        this.LPData.YSeries[index2].Name = "Terminus";
        this.LPData.YSeries[index2].Color = Color.Brown;
        this.PhaseData.YSeries[index2].Points = new double[checked (this.Points + 1)];
        this.PhaseData.YSeries[index2].Name = "Terminus";
        this.PhaseData.YSeries[index2].Color = Color.Brown;
        checked { ++index2; }
      }
      if (!this.SystemCheck.Checked)
        return;
      this.LPData.YSeries[index2].Points = new double[checked (this.Points + 1)];
      this.LPData.YSeries[index2].Name = "System";
      this.LPData.YSeries[index2].Color = Color.Black;
      this.PhaseData.YSeries[index2].Points = new double[checked (this.Points + 1)];
      this.PhaseData.YSeries[index2].Name = "System";
      this.PhaseData.YSeries[index2].Color = Color.Black;
      this.GroupDelayData.YSeries[index3].Points = new double[checked (this.Points + 1)];
      this.GroupDelayData.YSeries[index3].Name = "System";
      this.GroupDelayData.YSeries[index3].Color = Color.Black;
      int num1 = checked (index2 + 1);
      int num2 = checked (index3 + 1);
    }

    private void ImageToFile(object sender, EventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem) sender;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "GIF Graphics Interchange Format (*.gif)|*.gif|JPEG File Interchange Format (*.jpg)|*.jpg|PNG Portable Network Graphics Format (*.png)|*.png|TIFF Tag Image File Format (*.tif)|*.tif|Device Independednt Bitmap (*.bmp)|*.bmp";
      saveFileDialog.FilterIndex = 1;
      saveFileDialog.RestoreDirectory = true;
      saveFileDialog.OverwritePrompt = true;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
      string Left = Strings.LCase(new FileInfo(fileName).Extension);
      if (Operators.CompareString(Left, ".gif", false) == 0)
        ((Image) toolStripMenuItem.Tag).Save(fileName, ImageFormat.Gif);
      else if (Operators.CompareString(Left, ".jpg", false) == 0)
        ((Image) toolStripMenuItem.Tag).Save(fileName, ImageFormat.Jpeg);
      else if (Operators.CompareString(Left, ".png", false) == 0)
        ((Image) toolStripMenuItem.Tag).Save(fileName, ImageFormat.Png);
      else if (Operators.CompareString(Left, ".tif", false) == 0)
        ((Image) toolStripMenuItem.Tag).Save(fileName, ImageFormat.Tiff);
      else if (Operators.CompareString(Left, ".bmp", false) == 0)
        ((Image) toolStripMenuItem.Tag).Save(fileName, ImageFormat.Bmp);
      else if (Interaction.MsgBox((object) "you must select a valid filename extension. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
        this.ImageToFile(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void ImageToClipboard(object sender, EventArgs e) => Clipboard.SetImage((Image) ((ToolStripItem) sender).Tag);

    private void GraphMouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        PictureBox pictureBox = (PictureBox) sender;
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        ToolStripItem toolStripItem1 = contextMenuStrip.Items.Add("Copy Graph to Clipboard");
        toolStripItem1.Tag = (object) pictureBox.Image;
        toolStripItem1.Click += new EventHandler(this.ImageToClipboard);
        ToolStripItem toolStripItem2 = contextMenuStrip.Items.Add("Save Picture As");
        toolStripItem2.Tag = (object) pictureBox.Image;
        toolStripItem2.Click += new EventHandler(this.ImageToFile);
        contextMenuStrip.Show((Control) pictureBox, e.Location);
      }
      if (e.Button != MouseButtons.Left)
        return;
      this.LeftMouseButtonPress = false;
      this.UpdateGraphDisplays();
    }

    private void GraphMouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        PictureBox myDisplay = (PictureBox) sender;
        this.LeftMouseButtonPress = true;
        if (myDisplay == this.LpDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.SPLGraph);
        else if (myDisplay == this.LpPhaseDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.PhaseGraph);
        else if (myDisplay == this.ZtDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZtGraph);
        else if (myDisplay == this.ZrDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZrGraph);
        else if (myDisplay == this.ZiDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZiGraph);
        else if (myDisplay == this.ZasDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZesGraph);
        else if (myDisplay == this.VelocityDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.VelocityGraph);
        else if (myDisplay == this.DisplaceDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.DisplaceGraph);
        else if (myDisplay == this.GroupDelayDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.GroupDelayGraph);
        else
          this.LeftMouseButtonPress = false;
      }
    }

    private void GraphMouseMove(object sender, MouseEventArgs e)
    {
      if (this.LeftMouseButtonPress)
      {
        PictureBox myDisplay = (PictureBox) sender;
        if (myDisplay == this.LpDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.SPLGraph);
        else if (myDisplay == this.LpPhaseDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.PhaseGraph);
        else if (myDisplay == this.ZtDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZtGraph);
        else if (myDisplay == this.ZrDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZrGraph);
        else if (myDisplay == this.ZiDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZiGraph);
        else if (myDisplay == this.ZasDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.ZesGraph);
        else if (myDisplay == this.VelocityDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.VelocityGraph);
        else if (myDisplay == this.DisplaceDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.DisplaceGraph);
        else if (myDisplay == this.GroupDelayDisplay)
          this.GraphCursorLines(e.Location, ref myDisplay, ref this.GroupDelayGraph);
        else
          this.LeftMouseButtonPress = false;
      }
    }

    private void GraphMouseLeave(object sender, EventArgs e)
    {
      PictureBox Display = (PictureBox) sender;
      if (Display == this.LpDisplay)
        this.UpdateGraph(ref Display, this.SPLGraph.GetImage);
      else if (Display == this.LpPhaseDisplay)
        this.UpdateGraph(ref Display, this.PhaseGraph.GetImage);
      else if (Display == this.ZtDisplay)
        this.UpdateGraph(ref Display, this.ZtGraph.GetImage);
      else if (Display == this.ZrDisplay)
        this.UpdateGraph(ref Display, this.ZrGraph.GetImage);
      else if (Display == this.ZiDisplay)
        this.UpdateGraph(ref Display, this.ZiGraph.GetImage);
      else if (Display == this.ZasDisplay)
        this.UpdateGraph(ref Display, this.ZesGraph.GetImage);
      else if (Display == this.VelocityDisplay)
        this.UpdateGraph(ref Display, this.VelocityGraph.GetImage);
      else if (Display == this.DisplaceDisplay)
      {
        this.UpdateGraph(ref Display, this.DisplaceGraph.GetImage);
      }
      else
      {
        if (Display != this.GroupDelayDisplay)
          return;
        this.UpdateGraph(ref Display, this.GroupDelayGraph.GetImage);
      }
    }

    private void GraphCursorLines(Point Mouse, ref PictureBox myDisplay, ref myGraphClass Graph)
    {
      Graph.DrawCursorLine(Mouse, ref myDisplay);
      this.ToolStripFreqLabel.Text = "Freq: " + Math.Round(Graph.get_GetXValue(Mouse, myDisplay.Width, myDisplay.Height), 1).ToString("0.0") + " Hz";
      if (Graph.NumSeries < 0)
        return;
      this.ToolStripFreqLabel.Text += "   Value:";
      int numSeries = Graph.NumSeries;
      int num = 0;
      while (num <= numSeries)
      {
        this.ToolStripFreqLabel.Text = this.ToolStripFreqLabel.Text + " [" + Graph.get_GetSeriesName(num) + " = " + Math.Round(Graph.get_GetYValue(Mouse, myDisplay.Width, myDisplay.Height, num), 1).ToString("0.0") + "] ";
        checked { ++num; }
      }
    }

    private DriverClass uxEditDriver
    {
      [DebuggerNonUserCode] get => this._uxEditDriver;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DriverClass.DriverParameterUpdatedEventHandler updatedEventHandler = new DriverClass.DriverParameterUpdatedEventHandler(this.uxEditDriver_DriverParameterUpdated);
        FormClosingEventHandler closingEventHandler = new FormClosingEventHandler(this.uxEditDriver_FormClosing);
        if (this._uxEditDriver != null)
        {
          this._uxEditDriver.DriverParameterUpdated -= updatedEventHandler;
          this._uxEditDriver.FormClosing -= closingEventHandler;
        }
        this._uxEditDriver = value;
        if (this._uxEditDriver == null)
          return;
        this._uxEditDriver.DriverParameterUpdated += updatedEventHandler;
        this._uxEditDriver.FormClosing += closingEventHandler;
      }
    }

    private AmplifierClass uxEditAmplifier
    {
      [DebuggerNonUserCode] get => this._uxEditAmplifier;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        AmplifierClass.AmplifierParameterUpdatedEventHandler updatedEventHandler = new AmplifierClass.AmplifierParameterUpdatedEventHandler(this.uxEditAmplifier_AmplifierParameterUpdated);
        FormClosingEventHandler closingEventHandler = new FormClosingEventHandler(this.uxEditAmplifier_FormClosing);
        if (this._uxEditAmplifier != null)
        {
          this._uxEditAmplifier.AmplifierParameterUpdated -= updatedEventHandler;
          this._uxEditAmplifier.FormClosing -= closingEventHandler;
        }
        this._uxEditAmplifier = value;
        if (this._uxEditAmplifier == null)
          return;
        this._uxEditAmplifier.AmplifierParameterUpdated += updatedEventHandler;
        this._uxEditAmplifier.FormClosing += closingEventHandler;
      }
    }

    private GeometryDisplayClass uxGeometryDisplay
    {
      [DebuggerNonUserCode] get => this._uxGeometryDisplay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        GeometryDisplayClass.SettingsUpdatedEventHandler updatedEventHandler1 = new GeometryDisplayClass.SettingsUpdatedEventHandler(this.uXGeometryDisplay_SettingsUpdated);
        GeometryDisplayClass.TLParameterUpdatedEventHandler updatedEventHandler2 = new GeometryDisplayClass.TLParameterUpdatedEventHandler(this.uxGeometry_TLParameterUpdated);
        FormClosingEventHandler closingEventHandler = new FormClosingEventHandler(this.uxGeometryDisplay_FormClosing);
        if (this._uxGeometryDisplay != null)
        {
          this._uxGeometryDisplay.SettingsUpdated -= updatedEventHandler1;
          this._uxGeometryDisplay.TLParameterUpdated -= updatedEventHandler2;
          this._uxGeometryDisplay.FormClosing -= closingEventHandler;
        }
        this._uxGeometryDisplay = value;
        if (this._uxGeometryDisplay == null)
          return;
        this._uxGeometryDisplay.SettingsUpdated += updatedEventHandler1;
        this._uxGeometryDisplay.TLParameterUpdated += updatedEventHandler2;
        this._uxGeometryDisplay.FormClosing += closingEventHandler;
      }
    }

    private SettingsClass uxSettingsDialog
    {
      [DebuggerNonUserCode] get => this._uxSettingsDialog;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SettingsClass.SettingsParameterUpdatedEventHandler updatedEventHandler = new SettingsClass.SettingsParameterUpdatedEventHandler(this.uxSettingsDialog_SettingsParameterUpdated);
        FormClosingEventHandler closingEventHandler = new FormClosingEventHandler(this.uxSettingsDialog_FormClosing);
        if (this._uxSettingsDialog != null)
        {
          this._uxSettingsDialog.SettingsParameterUpdated -= updatedEventHandler;
          this._uxSettingsDialog.FormClosing -= closingEventHandler;
        }
        this._uxSettingsDialog = value;
        if (this._uxSettingsDialog == null)
          return;
        this._uxSettingsDialog.SettingsParameterUpdated += updatedEventHandler;
        this._uxSettingsDialog.FormClosing += closingEventHandler;
      }
    }

    private FilterClass uxEditFilter
    {
      [DebuggerNonUserCode] get => this._uxEditFilter;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        FilterClass.FilterParameterUpdatedEventHandler updatedEventHandler = new FilterClass.FilterParameterUpdatedEventHandler(this.uxEditFilter_FilterParameterUpdated);
        FormClosingEventHandler closingEventHandler = new FormClosingEventHandler(this.uxEditFilter_FormClosing);
        if (this._uxEditFilter != null)
        {
          this._uxEditFilter.FilterParameterUpdated -= updatedEventHandler;
          this._uxEditFilter.FormClosing -= closingEventHandler;
        }
        this._uxEditFilter = value;
        if (this._uxEditFilter == null)
          return;
        this._uxEditFilter.FilterParameterUpdated += updatedEventHandler;
        this._uxEditFilter.FormClosing += closingEventHandler;
      }
    }

    private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.uxSettingsDialog == null)
      {
        this.uxSettingsDialog = new SettingsClass(this.SettingsParameter);
        this.uxSettingsDialog.Show();
        this.SettingsToolStripMenuItem.Checked = true;
      }
      else
      {
        this.SettingsToolStripMenuItem.Checked = this.uxSettingsDialog.IsDisposed;
        if (this.uxSettingsDialog.IsDisposed)
        {
          this.uxSettingsDialog = new SettingsClass(this.SettingsParameter);
          this.uxSettingsDialog.Show();
        }
        else
          this.uxSettingsDialog.Close();
      }
    }

    private void DriverToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.uxEditDriver == null)
      {
        this.uxEditDriver = new DriverClass(this.DriverParameter, this.SettingsParameter, this.DriverSetupParameter);
        this.uxEditDriver.Show();
        this.DriverToolStripMenuItem.Checked = true;
      }
      else
      {
        this.DriverToolStripMenuItem.Checked = this.uxEditDriver.IsDisposed;
        if (this.uxEditDriver.IsDisposed)
        {
          this.uxEditDriver = new DriverClass(this.DriverParameter, this.SettingsParameter, this.DriverSetupParameter);
          this.uxEditDriver.Show();
        }
        else
          this.uxEditDriver.Close();
      }
    }

    private void AmplifierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.uxEditAmplifier == null)
      {
        this.uxEditAmplifier = new AmplifierClass(this.AmplifierParameter, this.DriverParameter.Re);
        this.uxEditAmplifier.Show();
        this.AmplifierToolStripMenuItem.Checked = true;
      }
      else
      {
        this.AmplifierToolStripMenuItem.Checked = this.uxEditAmplifier.IsDisposed;
        if (this.uxEditAmplifier.IsDisposed)
        {
          this.uxEditAmplifier = new AmplifierClass(this.AmplifierParameter, this.DriverParameter.Re);
          this.uxEditAmplifier.Show();
        }
        else
          this.uxEditAmplifier.Close();
      }
    }

    private void FilterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.uxEditFilter == null)
      {
        this.uxEditFilter = new FilterClass(this.FilterParameter);
        this.uxEditFilter.Show();
        this.FilterToolStripMenuItem.Checked = true;
      }
      else
      {
        this.FilterToolStripMenuItem.Checked = this.uxEditFilter.IsDisposed;
        if (this.uxEditFilter.IsDisposed)
        {
          this.uxEditFilter = new FilterClass(this.FilterParameter);
          this.uxEditFilter.Show();
        }
        else
          this.uxEditFilter.Close();
      }
    }

    private void GeometryViewerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.uxGeometryDisplay == null)
      {
        this.uxGeometryDisplay = new GeometryDisplayClass(this.TLParameter, this.SettingsParameter, this.DriverParameter, this.DriverSetupParameter);
        this.uxGeometryDisplay.Show();
        this.GeometryViewerToolStripMenuItem.Checked = true;
      }
      else
      {
        this.GeometryViewerToolStripMenuItem.Checked = this.uxGeometryDisplay.IsDisposed;
        if (this.uxGeometryDisplay.IsDisposed)
        {
          this.uxGeometryDisplay = new GeometryDisplayClass(this.TLParameter, this.SettingsParameter, this.DriverParameter, this.DriverSetupParameter);
          this.uxGeometryDisplay.Show();
        }
        else
          this.uxGeometryDisplay.Close();
      }
    }

    private void uxEditDriver_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.DriverToolStripMenuItem.Checked = false;
      this.uxEditDriver = (DriverClass) null;
    }

    private void uxEditAmplifier_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.AmplifierToolStripMenuItem.Checked = false;
      this.uxEditAmplifier = (AmplifierClass) null;
    }

    private void uxEditFilter_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.FilterToolStripMenuItem.Checked = false;
      this.uxEditFilter = (FilterClass) null;
    }

    private void uxGeometryDisplay_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.GeometryViewerToolStripMenuItem.Checked = false;
      this.uxGeometryDisplay = (GeometryDisplayClass) null;
    }

    private void uxSettingsDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.SettingsToolStripMenuItem.Checked = false;
      this.uxSettingsDialog = (SettingsClass) null;
    }

    private void uxGeometry_TLParameterUpdated(object Sender, TLParameterUpdatedEventArgs e)
    {
      this.TLParameter = e.ReturnTLParameter;
      this.DriverSetupParameter = e.ReturnDriverSetupParameter;
      if (this.SettingsParameter.AutoUpdate)
        this.ReCalc();
      else
        this.ChangeRoutine();
      if (Information.IsNothing((object) this.uxEditDriver))
        return;
      this.uxEditDriver.DriverSetupParameterFromParent = this.DriverSetupParameter;
    }

    private void uXGeometryDisplay_SettingsUpdated(object Sender, SettingsUpdatedEventArgs e)
    {
      this.SettingsParameter = e.ReturnSettings;
      if (Information.IsNothing((object) this.uxSettingsDialog))
        return;
      this.uxSettingsDialog.SettingsFromParent = this.SettingsParameter;
    }

    private void uxEditDriver_DriverParameterUpdated(
      object Sender,
      DriverParameterUpdatedEventArgs e)
    {
      this.DriverParameter = e.ReturnDriverParameter;
      this.DriverSetupParameter = e.ReturnDriverSetupParameter;
      if (!Information.IsNothing((object) this.uxEditAmplifier))
        this.uxEditAmplifier.ReFromParent = this.DriverParameter.Re;
      if (!Information.IsNothing((object) this.uxGeometryDisplay))
      {
        this.uxGeometryDisplay.DriverFromParent = this.DriverParameter;
        this.uxGeometryDisplay.DriverSetupFromParent = this.DriverSetupParameter;
      }
      this.ReCalc();
    }

    private void uxEditAmplifier_AmplifierParameterUpdated(
      object Sender,
      AmplifierParameterUpdatedEventArgs e)
    {
      this.AmplifierParameter = e.ReturnAmplifierParameter;
      this.ReCalc();
    }

    private void uxEditFilter_FilterParameterUpdated(
      object Sender,
      FilterParameterUpdatedEventArgs e)
    {
      this.FilterParameter = e.ReturnFilterParameter;
      this.ReCalc();
    }

    private void uxSettingsDialog_SettingsParameterUpdated(
      object Sender,
      SettingsParameterUpdatedEventArgs e)
    {
      SettingsParameters settingsParameter = this.SettingsParameter;
      this.SettingsParameter = e.ReturnSettingsParameter;
      if (this.SettingsParameter.UndoRedoHistory != settingsParameter.UndoRedoHistory)
      {
        this.DeleteTempFiles();
        this.SetupTempFiles();
      }
      if (!Information.IsNothing((object) this.uxEditDriver))
        this.uxEditDriver.SettingsParameterFromParent = this.SettingsParameter;
      if (!Information.IsNothing((object) this.uxGeometryDisplay))
        this.uxGeometryDisplay.SettingsFromParent = this.SettingsParameter;
      this.UpdateSettingstoFile();
      this.SetupGraphs();
      this.ReCalc(true);
    }

    private void UpdateOpenWindows()
    {
      if (!Information.IsNothing((object) this.uxEditDriver))
      {
        this.uxEditDriver.SettingsParameterFromParent = this.SettingsParameter;
        this.uxEditDriver.DriverParameterFromParent = this.DriverParameter;
        this.uxEditDriver.DriverSetupParameterFromParent = this.DriverSetupParameter;
      }
      if (!Information.IsNothing((object) this.uxEditAmplifier))
      {
        this.uxEditAmplifier.ReFromParent = this.DriverParameter.Re;
        this.uxEditAmplifier.AmplifierParameterFromParent = this.AmplifierParameter;
      }
      if (!Information.IsNothing((object) this.uxEditFilter))
        this.uxEditFilter.FilterParameterFromParent = this.FilterParameter;
      if (!Information.IsNothing((object) this.uxSettingsDialog))
        this.uxSettingsDialog.SettingsFromParent = this.SettingsParameter;
      if (Information.IsNothing((object) this.uxGeometryDisplay))
        return;
      this.uxGeometryDisplay.TLGeometryFromParent = this.TLParameter;
      this.uxGeometryDisplay.SettingsFromParent = this.SettingsParameter;
    }

    private void AboutToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      int num = (int) new AboutBox1().ShowDialog((IWin32Window) this);
    }

    private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e) => Application.Exit();

    private void ToolStripOpenProject_Click(object sender, EventArgs e) => this.OpenProject();

    private void ToolStripSaveAs_Click(object sender, EventArgs e) => this.SaveProjectAs();

    private void ToolStripRunButton_Click(object sender, EventArgs e) => this.ReCalc(true);

    private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e) => this.NewProject();

    private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e) => this.SaveProject();

    private void UndoToolStripMenuItem_Click(object sender, EventArgs e) => this.Undo();

    private void RedoToolStripMenuItem_Click(object sender, EventArgs e) => this.Redo();

    private void SaveProject()
    {
      if (!Information.IsNothing((object) this.CurrentFile))
      {
        this.SaveFromPath(this.CurrentFile);
        this.Saved = true;
        this.Open = true;
        this.TitleChange();
      }
      else
        this.SaveProjectAs();
    }

    private void InsertToTree(TLElement Tag, string Path)
    {
      string[] strArray = Path.Split('.');
      TreeNode treeNode = Operators.CompareString(strArray[0], "Rear", false) != 0 ? this.TLParameter.FrontEnclosure : this.TLParameter.RearEnclosure;
      int index1 = 0;
      int upperBound = strArray.GetUpperBound(0);
      int index2 = 1;
      while (index2 <= upperBound)
      {
        int integer = Conversions.ToInteger(strArray[index2]);
        if (index2 == strArray.GetUpperBound(0))
          index1 = integer;
        else
          treeNode = treeNode.Nodes[integer];
        checked { ++index2; }
      }
      treeNode.Nodes.Insert(index1, "").Tag = (object) Tag;
    }

    private void OpenProject()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Project Files (*.tlp)|*.tlp";
      openFileDialog.FilterIndex = 1;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.OpenProjectFile(openFileDialog.FileName);
    }

    private void OpenProjectFile(string FILE_NAME)
    {
      this.DeleteTempFiles();
      this.SetupTempFiles();
      this.OpenFromPath(FILE_NAME, true);
      this.Open = true;
      this.CurrentFile = FILE_NAME;
      this.Saved = true;
      this.TitleChange();
      if (!Information.IsNothing((object) MySettingsProperty.Settings.RecentFiles))
      {
        for (int index = MySettingsProperty.Settings.RecentFiles.IndexOf(FILE_NAME); index > -1; index = MySettingsProperty.Settings.RecentFiles.IndexOf(FILE_NAME))
          MySettingsProperty.Settings.RecentFiles.RemoveAt(index);
      }
      else
        MySettingsProperty.Settings.RecentFiles = new StringCollection();
      MySettingsProperty.Settings.RecentFiles.Insert(0, FILE_NAME);
      this.UpdateRecentFiles();
    }

    private void FileParser(StreamReader objreader)
    {
      this.DriverSetupParameter.DriverPosition = 0.0;
      this.TLParameter.FrontEnclosure = new TreeNode();
      this.TLParameter.FrontEnclosure.Nodes.Clear();
      this.TLParameter.FrontEnclosure.Tag = (object) "Front";
      this.TLParameter.RearEnclosure = new TreeNode();
      this.TLParameter.RearEnclosure.Nodes.Clear();
      this.TLParameter.RearEnclosure.Tag = (object) "Rear";
      while (!objreader.EndOfStream)
      {
        string str1 = objreader.ReadLine();
        if (Operators.CompareString(Strings.Left(str1, 1), "#", false) != 0)
        {
          int num = Strings.InStr(str1, " ");
          string str2;
          string Expression;
          if (num == 0)
          {
            if (Strings.Len(str1) > 0)
            {
              str2 = str1;
              Expression = "";
            }
            else
              continue;
          }
          else
          {
            str2 = Strings.Left(str1, checked (num - 1));
            Expression = Strings.Mid(str1, checked (num + 1));
          }
          string Left1 = str2;
          if (Operators.CompareString(Left1, "AmplifierPower", false) == 0)
            this.AmplifierParameter.Power = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "AmplifierRg", false) == 0)
            this.AmplifierParameter.Rg = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "FilterLowPassActive", false) == 0)
            this.FilterParameter.LowPass.Active = Conversions.ToBoolean(Expression);
          else if (Operators.CompareString(Left1, "FilterLowPassQ", false) == 0)
            this.FilterParameter.LowPass.Q = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "FilterLowPassfo", false) == 0)
            this.FilterParameter.LowPass.fo = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "FilterLowPassOrder", false) == 0)
            this.FilterParameter.LowPass.Order = int.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "FilterHighPassActive", false) == 0)
            this.FilterParameter.HighPass.Active = Conversions.ToBoolean(Expression);
          else if (Operators.CompareString(Left1, "FilterHighPassQ", false) == 0)
            this.FilterParameter.HighPass.Q = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "FilterHighPassfo", false) == 0)
            this.FilterParameter.HighPass.fo = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "FilterHighPassOrder", false) == 0)
            this.FilterParameter.HighPass.Order = int.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverTitle", false) == 0)
            this.DriverParameter.Title = Expression;
          else if (Operators.CompareString(Left1, "DriverFilePath", false) == 0)
            this.DriverParameter.FilePath = Expression;
          else if (Operators.CompareString(Left1, "DriverSd", false) == 0)
            this.DriverParameter.Sd = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverQes", false) == 0)
            this.DriverParameter.Qes = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverQms", false) == 0)
            this.DriverParameter.Qms = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverLvc", false) == 0)
            this.DriverParameter.Lvc = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverRe", false) == 0)
            this.DriverParameter.Re = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverFs", false) == 0)
            this.DriverParameter.Fs = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverVas", false) == 0)
            this.DriverParameter.Vas = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "DriverIsobaric", false) == 0)
            this.DriverSetupParameter.Isobaric = Conversions.ToBoolean(Expression);
          else if (Operators.CompareString(Left1, "DriverSeries", false) == 0)
            this.DriverSetupParameter.Series = Conversions.ToBoolean(Expression);
          else if (Operators.CompareString(Left1, "TLWidth", false) == 0)
            this.TLParameter.Width = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "TLDriverPosition", false) == 0)
            this.DriverSetupParameter.DriverPosition = double.Parse(Expression.Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          else if (Operators.CompareString(Left1, "TLTappedHorn", false) == 0)
            this.DriverSetupParameter.Tapped = Conversions.ToBoolean(Expression);
          else if (Operators.CompareString(Left1, "TLTappedHornPosition", false) == 0)
            this.DriverSetupParameter.TapPosition = Conversions.ToDouble(Expression);
          else if (Operators.CompareString(Left1, "TLNode", false) == 0)
          {
            string Path = "";
            string[] strArray1 = Strings.Split(Expression);
            int index = 0;
            TLElement Tag = default;
            while (index < strArray1.Length)
            {
              string[] strArray2 = Strings.Split(strArray1[index], "=");
              string Left2 = strArray2[0];
              if (Operators.CompareString(Left2, "Path", false) == 0)
                Path = strArray2[1];
              else if (Operators.CompareString(Left2, "Length", false) == 0)
                Tag.Length = double.Parse(strArray2[1].Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
              else if (Operators.CompareString(Left2, "StartArea", false) == 0)
                Tag.StartArea = double.Parse(strArray2[1].Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
              else if (Operators.CompareString(Left2, "EndArea", false) == 0)
                Tag.EndArea = double.Parse(strArray2[1].Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
              else if (Operators.CompareString(Left2, "Taper", false) == 0)
                Tag.Taper = Conversions.ToInteger(strArray2[1]);
              else if (Operators.CompareString(Left2, "StuffingDensity", false) == 0)
                Tag.StuffingDensity = double.Parse(strArray2[1].Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
              else if (Operators.CompareString(Left2, "OpenEnd", false) == 0)
                Tag.OpenEnd = Conversions.ToBoolean(strArray2[1]);
              else if (Operators.CompareString(Left2, "Angle", false) == 0)
                Tag.Angle = double.Parse(strArray2[1].Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
              checked { ++index; }
            }
            this.InsertToTree(Tag, Path);
          }
        }
      }
    }

    private void OpenFromPath(string FILE_NAME, bool NoStackChange = false)
    {
      if (System.IO.File.Exists(FILE_NAME))
      {
        try
        {
          StreamReader objreader = new StreamReader(FILE_NAME);
          if (double.Parse(objreader.ReadLine().Replace(',', '.'), (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat) < 3.6)
          {
            int num = (int) Interaction.MsgBox((object) "Files from software versions before v3.6 are no longer supported.");
          }
          else
            this.FileParser(objreader);
          objreader.Close();
        }
        catch (OverflowException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "OverflowException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "The file is corrupted or not compatible with this software version. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (ArgumentNullException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "ArgumentNullException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "No file was selected. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "ArgumentException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "No file was selected. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (FileNotFoundException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "FileNotFoundException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "File could not be found. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (DirectoryNotFoundException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "DirectoryNotFoundException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "The specified path is invalid, such as being on an unmapped drive. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (FileLoadException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "FileLoadException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "The specified file cannot be loaded. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (EndOfStreamException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "EndOfStreamException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "An error has occured. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (PathTooLongException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "PathTooLongException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "Path name is too long. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (InsufficientMemoryException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "OutOfMemoryException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "There is insufficient memory to allocate a buffer. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (OutOfMemoryException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ReportError((Exception) ex, "OutOfMemoryException during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "There is insufficient memory to allocate a buffer. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.ReportError(ex, "Exception during OpenFromPath() File:" + FILE_NAME);
          if (Interaction.MsgBox((object) "An error has occured. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
            this.OpenFromPath(FILE_NAME, NoStackChange);
          ProjectData.ClearProjectError();
        }
        finally
        {
          this.ReCalc(NoStackChange);
          this.UpdateOpenWindows();
        }
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "File does not exist and cannot be opened", Title: ((object) "Error"));
      }
    }

    private void WriteTreeToFile(StreamWriter objwriter)
    {
      try
      {
        foreach (TreeNode node in this.TLParameter.RearEnclosure.Nodes)
          this.WriteTreeRecursive(objwriter, node);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (TreeNode node in this.TLParameter.FrontEnclosure.Nodes)
          this.WriteTreeRecursive(objwriter, node);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void WriteTreeRecursive(StreamWriter objwriter, TreeNode n)
    {
      string str1 = "TLNode" + " Path=" + Functions.GetTreeString(n);
      object tag1 = n.Tag;
      TLElement tlElement1 = default;
      TLElement tlElement2 = tag1 != null ? (TLElement) tag1 : tlElement1;
      string str2 = tlElement2.Length.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      string str3 = str1 + " Length=" + str2;
      object tag2 = n.Tag;
      tlElement2 = tag2 != null ? (TLElement) tag2 : tlElement1;
      string str4 = tlElement2.StartArea.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      string str5 = str3 + " StartArea=" + str4;
      object tag3 = n.Tag;
      tlElement2 = tag3 != null ? (TLElement) tag3 : tlElement1;
      string str6 = tlElement2.EndArea.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      string str7 = str5 + " EndArea=" + str6;
      object tag4 = n.Tag;
      tlElement2 = tag4 != null ? (TLElement) tag4 : tlElement1;
      string str8 = Conversions.ToString(tlElement2.Taper);
      string str9 = str7 + " Taper=" + str8;
      object tag5 = n.Tag;
      tlElement2 = tag5 != null ? (TLElement) tag5 : tlElement1;
      string str10 = tlElement2.StuffingDensity.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      string str11 = str9 + " StuffingDensity=" + str10;
      object tag6 = n.Tag;
      tlElement2 = tag6 != null ? (TLElement) tag6 : tlElement1;
      string str12 = tlElement2.OpenEnd.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      string str13 = str11 + " OpenEnd=" + str12;
      object tag7 = n.Tag;
      tlElement2 = tag7 != null ? (TLElement) tag7 : tlElement1;
      string str14 = tlElement2.Angle.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      string str15 = str13 + " Angle=" + str14;
      objwriter.WriteLine(str15);
      try
      {
        foreach (TreeNode node in n.Nodes)
          this.WriteTreeRecursive(objwriter, node);
      }
      finally
      {
        IEnumerator enumerator = null;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SaveFromPath(string FILE_NAME)
    {
      try
      {
        StreamWriter objwriter = new StreamWriter(FILE_NAME, false);
        objwriter.WriteLine(Conversions.ToString(MyProject.Application.Info.Version.Major) + "." + Conversions.ToString(MyProject.Application.Info.Version.Minor));
        objwriter.WriteLine("# This is a model file for Leonard Audio Transmission Line Modelling Software");
        objwriter.WriteLine("#-----Amplifier Settings-----#");
        objwriter.WriteLine("AmplifierPower " + this.AmplifierParameter.Power.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("AmplifierRg " + this.AmplifierParameter.Rg.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("#-----Filter Settings-----#");
        objwriter.WriteLine("FilterLowPassActive " + this.FilterParameter.LowPass.Active.ToString());
        objwriter.WriteLine("FilterLowPassQ " + this.FilterParameter.LowPass.Q.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("FilterLowPassfo " + this.FilterParameter.LowPass.fo.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("FilterLowPassOrder " + this.FilterParameter.LowPass.Order.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("FilterHighPassActive " + this.FilterParameter.HighPass.Active.ToString());
        objwriter.WriteLine("FilterHighPassQ " + this.FilterParameter.HighPass.Q.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("FilterHighPassfo " + this.FilterParameter.HighPass.fo.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("FilterHighPassOrder " + this.FilterParameter.HighPass.Order.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("#-----Driver Settings-----#");
        objwriter.WriteLine("DriverTitle " + this.DriverParameter.Title);
        objwriter.WriteLine("DriverFilePath " + this.DriverParameter.FilePath);
        objwriter.WriteLine("DriverSd " + this.DriverParameter.Sd.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverQes " + this.DriverParameter.Qes.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverQms " + this.DriverParameter.Qms.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverLvc " + this.DriverParameter.Lvc.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverRe " + this.DriverParameter.Re.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverFs " + this.DriverParameter.Fs.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverVas " + this.DriverParameter.Vas.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("DriverIsobaric " + this.DriverSetupParameter.Isobaric.ToString());
        objwriter.WriteLine("DriverSeries " + this.DriverSetupParameter.Series.ToString());
        objwriter.WriteLine("#-----Enclosure Settings-----#");
        objwriter.WriteLine("TLWidth " + this.TLParameter.Width.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("TLTappedHorn " + this.DriverSetupParameter.Tapped.ToString());
        objwriter.WriteLine("TLTappedHornPosition " + this.DriverSetupParameter.TapPosition.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        objwriter.WriteLine("TLDriverPosition " + this.DriverSetupParameter.DriverPosition.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
        this.WriteTreeToFile(objwriter);
        objwriter.Close();
      }
      catch (ObjectDisposedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ObjectDisposedException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured writing to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "UnauthorizedAccessException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "Access to file has been denied. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentNullException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "File path is nothing. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "Invalid File Path. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (DirectoryNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "DirectoryNotFoundException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "The specified path is invalid (for example, it is on an unmapped drive). Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "PathTooLongException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured writing to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "IOException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured writing to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (SecurityException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "SecurityException during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "Access to file has been denied - Security Exception. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.ReportError(ex, "Exception during SaveFromPath() - File Name: " + FILE_NAME);
        if (Interaction.MsgBox((object) "An error has occured attempting to write to file. Retry or Cancel", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SaveFromPath(FILE_NAME);
        ProjectData.ClearProjectError();
      }
    }

    private void SaveProjectAs()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Project Files (*.tlp)|*.tlp";
      saveFileDialog.FilterIndex = 1;
      saveFileDialog.RestoreDirectory = true;
      saveFileDialog.OverwritePrompt = true;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
      this.SaveFromPath(fileName);
      this.Saved = true;
      this.Open = true;
      this.CurrentFile = fileName;
      this.TitleChange();
    }

    private void SetupTempFiles()
    {
      try
      {
        this.UndoStack = new string[checked (this.SettingsParameter.UndoRedoHistory + 1)];
        this.RedoStack = new string[checked (this.SettingsParameter.UndoRedoHistory + 1)];
        int upperBound1 = this.UndoStack.GetUpperBound(0);
        int index1 = 0;
        while (index1 <= upperBound1)
        {
          this.UndoStack[index1] = Path.GetTempFileName();
          checked { ++index1; }
        }
        int upperBound2 = this.RedoStack.GetUpperBound(0);
        int index2 = 0;
        while (index2 <= upperBound2)
        {
          this.RedoStack[index2] = Path.GetTempFileName();
          checked { ++index2; }
        }
        this.CurrentState = Path.GetTempFileName();
        this.UndoStackPosition = -1;
        this.RedoStackPosition = -1;
        this.UndoEnable(false);
        this.RedoEnable(false);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "IOException during SetupTempFiles()");
        if (Interaction.MsgBox((object) "Could not create temporary files for Undo/Redo functionality. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.SetupTempFiles();
        ProjectData.ClearProjectError();
      }
    }

    private void DeleteTempFiles()
    {
      try
      {
        if (!Information.IsNothing((object) this.UndoStack))
        {
          int upperBound = this.UndoStack.GetUpperBound(0);
          int index = 0;
          while (index <= upperBound)
          {
            if (System.IO.File.Exists(this.UndoStack[index]))
              System.IO.File.Delete(this.UndoStack[index]);
            checked { ++index; }
          }
        }
        if (!Information.IsNothing((object) this.RedoStack))
        {
          int upperBound = this.RedoStack.GetUpperBound(0);
          int index = 0;
          while (index <= upperBound)
          {
            if (System.IO.File.Exists(this.RedoStack[index]))
              System.IO.File.Delete(this.RedoStack[index]);
            checked { ++index; }
          }
        }
        if (!System.IO.File.Exists(this.CurrentState))
          return;
        System.IO.File.Delete(this.CurrentState);
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "OverflowException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
      catch (DirectoryNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "DirectoryNotFoundException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "PathTooLongException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "IOException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
      catch (NotSupportedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "NotSupportedException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "UnauthorizedAccessException during DeleteTempFiles()");
        if (Interaction.MsgBox((object) "Error occured deleting tempory files. Retry or cancel:", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.DeleteTempFiles();
        ProjectData.ClearProjectError();
      }
    }

    public void Undo()
    {
      try
      {
        if (this.RedoStackPosition < this.RedoStack.GetUpperBound(0))
        {
          checked { ++this.RedoStackPosition; }
          System.IO.File.Copy(this.CurrentState, this.RedoStack[this.RedoStackPosition], true);
        }
        else
        {
          int upperBound = this.RedoStack.GetUpperBound(0);
          int index = 1;
          while (index <= upperBound)
          {
            System.IO.File.Copy(this.RedoStack[index], this.RedoStack[checked (index - 1)], true);
            checked { ++index; }
          }
          System.IO.File.Copy(this.CurrentState, this.RedoStack[this.RedoStackPosition], true);
        }
        this.OpenFromPath(this.UndoStack[this.UndoStackPosition], true);
        checked { --this.UndoStackPosition; }
        if (this.UndoStackPosition == -1)
          this.UndoEnable(false);
        this.RedoEnable(true);
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "UnauthorizedAccessException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentNullException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "PathTooLongException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (DirectoryNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "DirectoryNotFoundException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (FileNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "FileNotFoundException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "IOException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
      catch (NotSupportedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "NotSupportedException during Undo()");
        if (Interaction.MsgBox((object) "Undo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Undo();
        ProjectData.ClearProjectError();
      }
    }

    public void Redo()
    {
      try
      {
        if (this.UndoStackPosition < this.UndoStack.GetUpperBound(0))
        {
          checked { ++this.UndoStackPosition; }
          System.IO.File.Copy(this.CurrentState, this.UndoStack[this.UndoStackPosition], true);
        }
        else
        {
          int upperBound = this.UndoStack.GetUpperBound(0);
          int index = 1;
          while (index <= upperBound)
          {
            System.IO.File.Copy(this.UndoStack[index], this.UndoStack[checked (index - 1)], true);
            checked { ++index; }
          }
          System.IO.File.Copy(this.CurrentState, this.UndoStack[this.UndoStackPosition], true);
        }
        this.OpenFromPath(this.RedoStack[this.RedoStackPosition], true);
        checked { --this.RedoStackPosition; }
        this.UndoEnable(true);
        if (this.RedoStackPosition != -1)
          return;
        this.RedoEnable(false);
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "UnauthorizedAccessException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentNullException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "ArgumentException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "PathTooLongException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (DirectoryNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "DirectoryNotFoundException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (FileNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "FileNotFoundException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "IOException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
      catch (NotSupportedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ReportError((Exception) ex, "NotSupportedException during Redo()");
        if (Interaction.MsgBox((object) "Redo failed. Error accessing temporary file", MsgBoxStyle.RetryCancel, (object) "Error") == MsgBoxResult.Retry)
          this.Redo();
        ProjectData.ClearProjectError();
      }
    }

    private void UndoEnable(bool Bool)
    {
      this.UndoToolStripMenuItem.Enabled = Bool;
      this.ToolStripUndo.Enabled = Bool;
    }

    private void RedoEnable(bool Bool)
    {
      this.RedoToolStripMenuItem.Enabled = Bool;
      this.ToolStripRedo.Enabled = Bool;
    }
  }
}
