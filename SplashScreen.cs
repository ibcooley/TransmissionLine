// Decompiled with JetBrains decompiler
// Type: TransmissionLine.SplashScreen
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TransmissionLine.My;

namespace TransmissionLine
{
  [DesignerGenerated]
  public sealed class SplashScreen : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    [AccessedThroughProperty("ApplicationTitle")]
    private Label _ApplicationTitle;
    [AccessedThroughProperty("Version")]
    private Label _Version;
    [AccessedThroughProperty("Copyright")]
    private Label _Copyright;
    [AccessedThroughProperty("MainLayoutPanel")]
    private TableLayoutPanel _MainLayoutPanel;
    [AccessedThroughProperty("DetailsLayoutPanel")]
    private TableLayoutPanel _DetailsLayoutPanel;
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [DebuggerNonUserCode]
    static SplashScreen()
    {
    }

    [DebuggerNonUserCode]
    public SplashScreen()
    {
      this.Load += new EventHandler(this.SplashScreen_Load);
      SplashScreen.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (SplashScreen.__ENCList)
      {
        if (SplashScreen.__ENCList.Count == SplashScreen.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (SplashScreen.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (SplashScreen.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                SplashScreen.__ENCList[index1] = SplashScreen.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          SplashScreen.__ENCList.RemoveRange(index1, checked (SplashScreen.__ENCList.Count - index1));
          SplashScreen.__ENCList.Capacity = SplashScreen.__ENCList.Count;
        }
        SplashScreen.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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

    internal Label ApplicationTitle
    {
      [DebuggerNonUserCode] get => this._ApplicationTitle;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ApplicationTitle = value;
    }

    internal Label Version
    {
      [DebuggerNonUserCode] get => this._Version;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Version = value;
    }

    internal Label Copyright
    {
      [DebuggerNonUserCode] get => this._Copyright;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Copyright = value;
    }

    internal TableLayoutPanel MainLayoutPanel
    {
      [DebuggerNonUserCode] get => this._MainLayoutPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MainLayoutPanel = value;
    }

    internal TableLayoutPanel DetailsLayoutPanel
    {
      [DebuggerNonUserCode] get => this._DetailsLayoutPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DetailsLayoutPanel = value;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.MainLayoutPanel = new TableLayoutPanel();
      this.DetailsLayoutPanel = new TableLayoutPanel();
      this.Version = new Label();
      this.Copyright = new Label();
      this.ApplicationTitle = new Label();
      this.PictureBox1 = new PictureBox();
      this.MainLayoutPanel.SuspendLayout();
      this.DetailsLayoutPanel.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.MainLayoutPanel.BackColor = Color.White;
      this.MainLayoutPanel.BackgroundImageLayout = ImageLayout.None;
      this.MainLayoutPanel.ColumnCount = 2;
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243f));
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253f));
      this.MainLayoutPanel.Controls.Add((Control) this.DetailsLayoutPanel, 1, 1);
      this.MainLayoutPanel.Controls.Add((Control) this.ApplicationTitle, 1, 0);
      this.MainLayoutPanel.Controls.Add((Control) this.PictureBox1, 0, 0);
      this.MainLayoutPanel.Dock = DockStyle.Fill;
      TableLayoutPanel mainLayoutPanel1 = this.MainLayoutPanel;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      mainLayoutPanel1.Location = point2;
      this.MainLayoutPanel.Name = "MainLayoutPanel";
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 218f));
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
      TableLayoutPanel mainLayoutPanel2 = this.MainLayoutPanel;
      Size size1 = new Size(496, 303);
      Size size2 = size1;
      mainLayoutPanel2.Size = size2;
      this.MainLayoutPanel.TabIndex = 0;
      this.DetailsLayoutPanel.Anchor = AnchorStyles.None;
      this.DetailsLayoutPanel.BackColor = Color.Transparent;
      this.DetailsLayoutPanel.ColumnCount = 1;
      this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247f));
      this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142f));
      this.DetailsLayoutPanel.Controls.Add((Control) this.Version, 0, 0);
      this.DetailsLayoutPanel.Controls.Add((Control) this.Copyright, 0, 1);
      TableLayoutPanel detailsLayoutPanel1 = this.DetailsLayoutPanel;
      point1 = new Point(246, 221);
      Point point3 = point1;
      detailsLayoutPanel1.Location = point3;
      this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
      this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
      this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
      TableLayoutPanel detailsLayoutPanel2 = this.DetailsLayoutPanel;
      size1 = new Size(247, 79);
      Size size3 = size1;
      detailsLayoutPanel2.Size = size3;
      this.DetailsLayoutPanel.TabIndex = 1;
      this.Version.Anchor = AnchorStyles.None;
      this.Version.BackColor = Color.Transparent;
      this.Version.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label version1 = this.Version;
      point1 = new Point(3, 9);
      Point point4 = point1;
      version1.Location = point4;
      this.Version.Name = "Version";
      Label version2 = this.Version;
      size1 = new Size(241, 20);
      Size size4 = size1;
      version2.Size = size4;
      this.Version.TabIndex = 1;
      this.Version.Text = "Version {0}.{1:00}";
      this.Copyright.Anchor = AnchorStyles.None;
      this.Copyright.BackColor = Color.Transparent;
      this.Copyright.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label copyright1 = this.Copyright;
      point1 = new Point(3, 39);
      Point point5 = point1;
      copyright1.Location = point5;
      this.Copyright.Name = "Copyright";
      Label copyright2 = this.Copyright;
      size1 = new Size(241, 40);
      Size size5 = size1;
      copyright2.Size = size5;
      this.Copyright.TabIndex = 2;
      this.Copyright.Text = "Copyright";
      this.ApplicationTitle.Anchor = AnchorStyles.None;
      this.ApplicationTitle.BackColor = Color.Transparent;
      this.ApplicationTitle.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label applicationTitle1 = this.ApplicationTitle;
      point1 = new Point(246, 3);
      Point point6 = point1;
      applicationTitle1.Location = point6;
      this.ApplicationTitle.Name = "ApplicationTitle";
      Label applicationTitle2 = this.ApplicationTitle;
      size1 = new Size(247, 212);
      Size size6 = size1;
      applicationTitle2.Size = size6;
      this.ApplicationTitle.TabIndex = 0;
      this.ApplicationTitle.Text = "Application Title";
      this.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft;
      this.PictureBox1.Image = (Image) TransmissionLine.My.Resources.Resources.Box1;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(3, 3);
      Point point7 = point1;
      pictureBox1_1.Location = point7;
      this.PictureBox1.Name = "PictureBox1";
      this.MainLayoutPanel.SetRowSpan((Control) this.PictureBox1, 2);
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(237, 297);
      Size size7 = size1;
      pictureBox1_2.Size = size7;
      this.PictureBox1.TabIndex = 2;
      this.PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(496, 303);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.MainLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SplashScreen);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.MainLayoutPanel.ResumeLayout(false);
      this.DetailsLayoutPanel.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    internal PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SplashScreen_Load(object sender, EventArgs e)
    {
      this.ApplicationTitle.Text = Operators.CompareString(MyProject.Application.Info.Title, "", false) == 0 ? Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : MyProject.Application.Info.Title;
      this.Version.Text = string.Format("Version {0}", (object) MyProject.Application.Info.Version.ToString());
      this.Copyright.Text = MyProject.Application.Info.Copyright;
    }
  }
}
