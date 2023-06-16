// Decompiled with JetBrains decompiler
// Type: TransmissionLine.AboutBox1
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using TransmissionLine.My;

namespace TransmissionLine
{
  [DesignerGenerated]
  public sealed class AboutBox1 : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    [AccessedThroughProperty("TableLayoutPanel")]
    private TableLayoutPanel _TableLayoutPanel;
    [AccessedThroughProperty("LogoPictureBox")]
    private PictureBox _LogoPictureBox;
    [AccessedThroughProperty("LabelProductName")]
    private Label _LabelProductName;
    [AccessedThroughProperty("LabelVersion")]
    private Label _LabelVersion;
    [AccessedThroughProperty("LabelCompanyName")]
    private Label _LabelCompanyName;
    [AccessedThroughProperty("OKButton")]
    private Button _OKButton;
    [AccessedThroughProperty("LabelCopyright")]
    private Label _LabelCopyright;
    private IContainer components;
    [AccessedThroughProperty("UpdateLabel")]
    private Label _UpdateLabel;
    [AccessedThroughProperty("UpdateButton")]
    private Button _UpdateButton;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("WebLink")]
    private LinkLabel _WebLink;
    [AccessedThroughProperty("EmailLink")]
    private LinkLabel _EmailLink;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("TwitterLink")]
    private LinkLabel _TwitterLink;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    private ApplicationDeployment AD;

    [DebuggerNonUserCode]
    static AboutBox1()
    {
    }

    [DebuggerNonUserCode]
    public AboutBox1()
    {
      this.Load += new EventHandler(this.AboutBox1_Load);
      AboutBox1.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (AboutBox1.__ENCList)
      {
        if (AboutBox1.__ENCList.Count == AboutBox1.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (AboutBox1.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (AboutBox1.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                AboutBox1.__ENCList[index1] = AboutBox1.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          AboutBox1.__ENCList.RemoveRange(index1, checked (AboutBox1.__ENCList.Count - index1));
          AboutBox1.__ENCList.Capacity = AboutBox1.__ENCList.Count;
        }
        AboutBox1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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

    internal TableLayoutPanel TableLayoutPanel
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel = value;
    }

    internal PictureBox LogoPictureBox
    {
      [DebuggerNonUserCode] get => this._LogoPictureBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LogoPictureBox = value;
    }

    internal Label LabelProductName
    {
      [DebuggerNonUserCode] get => this._LabelProductName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LabelProductName = value;
    }

    internal Label LabelVersion
    {
      [DebuggerNonUserCode] get => this._LabelVersion;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LabelVersion = value;
    }

    internal Label LabelCompanyName
    {
      [DebuggerNonUserCode] get => this._LabelCompanyName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LabelCompanyName = value;
    }

    internal Button OKButton
    {
      [DebuggerNonUserCode] get => this._OKButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OKButton_Click);
        if (this._OKButton != null)
          this._OKButton.Click -= eventHandler;
        this._OKButton = value;
        if (this._OKButton == null)
          return;
        this._OKButton.Click += eventHandler;
      }
    }

    internal Label LabelCopyright
    {
      [DebuggerNonUserCode] get => this._LabelCopyright;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LabelCopyright = value;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.TableLayoutPanel = new TableLayoutPanel();
      this.LogoPictureBox = new PictureBox();
      this.LabelProductName = new Label();
      this.LabelVersion = new Label();
      this.LabelCopyright = new Label();
      this.LabelCompanyName = new Label();
      this.OKButton = new Button();
      this.UpdateLabel = new Label();
      this.UpdateButton = new Button();
      this.Panel1 = new Panel();
      this.TwitterLink = new LinkLabel();
      this.WebLink = new LinkLabel();
      this.EmailLink = new LinkLabel();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.TableLayoutPanel.SuspendLayout();
      ((ISupportInitialize) this.LogoPictureBox).BeginInit();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel.ColumnCount = 3;
      this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, (float) sbyte.MaxValue));
      this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207f));
      this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83f));
      this.TableLayoutPanel.Controls.Add((Control) this.LogoPictureBox, 0, 0);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelProductName, 1, 0);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelVersion, 1, 1);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelCopyright, 1, 2);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelCompanyName, 1, 3);
      this.TableLayoutPanel.Controls.Add((Control) this.OKButton, 1, 5);
      this.TableLayoutPanel.Controls.Add((Control) this.UpdateLabel, 1, 6);
      this.TableLayoutPanel.Controls.Add((Control) this.UpdateButton, 2, 6);
      this.TableLayoutPanel.Controls.Add((Control) this.Panel1, 1, 4);
      this.TableLayoutPanel.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel;
      Point point1 = new Point(9, 9);
      Point point2 = point1;
      tableLayoutPanel1.Location = point2;
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 7;
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.892679f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.892679f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.892679f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.46977f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44537f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.40681f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 74f));
      TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel;
      Size size1 = new Size(417, 257);
      Size size2 = size1;
      tableLayoutPanel2.Size = size2;
      this.TableLayoutPanel.TabIndex = 0;
      this.LogoPictureBox.Image = (Image) TransmissionLine.My.Resources.Resources.Box21;
      PictureBox logoPictureBox1 = this.LogoPictureBox;
      point1 = new Point(3, 3);
      Point point3 = point1;
      logoPictureBox1.Location = point3;
      this.LogoPictureBox.Name = "LogoPictureBox";
      this.TableLayoutPanel.SetRowSpan((Control) this.LogoPictureBox, 7);
      PictureBox logoPictureBox2 = this.LogoPictureBox;
      size1 = new Size(119, 250);
      Size size3 = size1;
      logoPictureBox2.Size = size3;
      this.LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
      this.LogoPictureBox.TabIndex = 0;
      this.LogoPictureBox.TabStop = false;
      this.TableLayoutPanel.SetColumnSpan((Control) this.LabelProductName, 2);
      this.LabelProductName.Dock = DockStyle.Fill;
      Label labelProductName1 = this.LabelProductName;
      point1 = new Point(133, 0);
      Point point4 = point1;
      labelProductName1.Location = point4;
      Label labelProductName2 = this.LabelProductName;
      Padding padding1 = new Padding(6, 0, 3, 0);
      Padding padding2 = padding1;
      labelProductName2.Margin = padding2;
      Label labelProductName3 = this.LabelProductName;
      size1 = new Size(0, 17);
      Size size4 = size1;
      labelProductName3.MaximumSize = size4;
      this.LabelProductName.Name = "LabelProductName";
      Label labelProductName4 = this.LabelProductName;
      size1 = new Size(281, 17);
      Size size5 = size1;
      labelProductName4.Size = size5;
      this.LabelProductName.TabIndex = 0;
      this.LabelProductName.Text = "Product Name";
      this.LabelProductName.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel.SetColumnSpan((Control) this.LabelVersion, 2);
      this.LabelVersion.Dock = DockStyle.Fill;
      Label labelVersion1 = this.LabelVersion;
      point1 = new Point(133, 18);
      Point point5 = point1;
      labelVersion1.Location = point5;
      Label labelVersion2 = this.LabelVersion;
      padding1 = new Padding(6, 0, 3, 0);
      Padding padding3 = padding1;
      labelVersion2.Margin = padding3;
      Label labelVersion3 = this.LabelVersion;
      size1 = new Size(0, 17);
      Size size6 = size1;
      labelVersion3.MaximumSize = size6;
      this.LabelVersion.Name = "LabelVersion";
      Label labelVersion4 = this.LabelVersion;
      size1 = new Size(281, 17);
      Size size7 = size1;
      labelVersion4.Size = size7;
      this.LabelVersion.TabIndex = 0;
      this.LabelVersion.Text = "Version";
      this.LabelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel.SetColumnSpan((Control) this.LabelCopyright, 2);
      this.LabelCopyright.Dock = DockStyle.Fill;
      Label labelCopyright1 = this.LabelCopyright;
      point1 = new Point(133, 36);
      Point point6 = point1;
      labelCopyright1.Location = point6;
      Label labelCopyright2 = this.LabelCopyright;
      padding1 = new Padding(6, 0, 3, 0);
      Padding padding4 = padding1;
      labelCopyright2.Margin = padding4;
      Label labelCopyright3 = this.LabelCopyright;
      size1 = new Size(0, 17);
      Size size8 = size1;
      labelCopyright3.MaximumSize = size8;
      this.LabelCopyright.Name = "LabelCopyright";
      Label labelCopyright4 = this.LabelCopyright;
      size1 = new Size(281, 17);
      Size size9 = size1;
      labelCopyright4.Size = size9;
      this.LabelCopyright.TabIndex = 0;
      this.LabelCopyright.Text = "Copyright";
      this.LabelCopyright.TextAlign = ContentAlignment.MiddleLeft;
      this.TableLayoutPanel.SetColumnSpan((Control) this.LabelCompanyName, 2);
      this.LabelCompanyName.Dock = DockStyle.Fill;
      Label labelCompanyName1 = this.LabelCompanyName;
      point1 = new Point(133, 54);
      Point point7 = point1;
      labelCompanyName1.Location = point7;
      Label labelCompanyName2 = this.LabelCompanyName;
      padding1 = new Padding(6, 0, 3, 0);
      Padding padding5 = padding1;
      labelCompanyName2.Margin = padding5;
      Label labelCompanyName3 = this.LabelCompanyName;
      size1 = new Size(0, 17);
      Size size10 = size1;
      labelCompanyName3.MaximumSize = size10;
      this.LabelCompanyName.Name = "LabelCompanyName";
      Label labelCompanyName4 = this.LabelCompanyName;
      size1 = new Size(281, 17);
      Size size11 = size1;
      labelCompanyName4.Size = size11;
      this.LabelCompanyName.TabIndex = 0;
      this.LabelCompanyName.Text = "Company Name";
      this.LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
      this.OKButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.TableLayoutPanel.SetColumnSpan((Control) this.OKButton, 2);
      this.OKButton.DialogResult = DialogResult.Cancel;
      Button okButton1 = this.OKButton;
      point1 = new Point(339, 158);
      Point point8 = point1;
      okButton1.Location = point8;
      this.OKButton.Name = "OKButton";
      Button okButton2 = this.OKButton;
      size1 = new Size(75, 20);
      Size size12 = size1;
      okButton2.Size = size12;
      this.OKButton.TabIndex = 0;
      this.OKButton.Text = "&OK";
      this.UpdateLabel.AutoSize = true;
      Label updateLabel1 = this.UpdateLabel;
      point1 = new Point(130, 181);
      Point point9 = point1;
      updateLabel1.Location = point9;
      this.UpdateLabel.Name = "UpdateLabel";
      Label updateLabel2 = this.UpdateLabel;
      size1 = new Size(39, 13);
      Size size13 = size1;
      updateLabel2.Size = size13;
      this.UpdateLabel.TabIndex = 1;
      this.UpdateLabel.Text = "Label1";
      this.UpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.UpdateButton.Enabled = false;
      Button updateButton1 = this.UpdateButton;
      point1 = new Point(339, 184);
      Point point10 = point1;
      updateButton1.Location = point10;
      this.UpdateButton.Name = "UpdateButton";
      Button updateButton2 = this.UpdateButton;
      size1 = new Size(75, 25);
      Size size14 = size1;
      updateButton2.Size = size14;
      this.UpdateButton.TabIndex = 2;
      this.UpdateButton.Text = "Update";
      this.UpdateButton.UseVisualStyleBackColor = false;
      this.TableLayoutPanel.SetColumnSpan((Control) this.Panel1, 2);
      this.Panel1.Controls.Add((Control) this.TwitterLink);
      this.Panel1.Controls.Add((Control) this.WebLink);
      this.Panel1.Controls.Add((Control) this.EmailLink);
      this.Panel1.Controls.Add((Control) this.Label4);
      this.Panel1.Controls.Add((Control) this.Label3);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Dock = DockStyle.Fill;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(130, 77);
      Point point11 = point1;
      panel1_1.Location = point11;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(284, 75);
      Size size15 = size1;
      panel1_2.Size = size15;
      this.Panel1.TabIndex = 3;
      this.TwitterLink.AutoSize = true;
      LinkLabel twitterLink1 = this.TwitterLink;
      point1 = new Point(50, 49);
      Point point12 = point1;
      twitterLink1.Location = point12;
      this.TwitterLink.Name = "TwitterLink";
      LinkLabel twitterLink2 = this.TwitterLink;
      size1 = new Size(79, 13);
      Size size16 = size1;
      twitterLink2.Size = size16;
      this.TwitterLink.TabIndex = 2;
      this.TwitterLink.TabStop = true;
      this.TwitterLink.Text = "@leonardaudio";
      this.WebLink.AutoSize = true;
      LinkLabel webLink1 = this.WebLink;
      point1 = new Point(50, 33);
      Point point13 = point1;
      webLink1.Location = point13;
      this.WebLink.Name = "WebLink";
      LinkLabel webLink2 = this.WebLink;
      size1 = new Size(98, 13);
      Size size17 = size1;
      webLink2.Size = size17;
      this.WebLink.TabIndex = 2;
      this.WebLink.TabStop = true;
      this.WebLink.Text = "leonardaudio.co.uk";
      this.EmailLink.AutoSize = true;
      LinkLabel emailLink1 = this.EmailLink;
      point1 = new Point(50, 17);
      Point point14 = point1;
      emailLink1.Location = point14;
      this.EmailLink.Name = "EmailLink";
      LinkLabel emailLink2 = this.EmailLink;
      size1 = new Size(133, 13);
      Size size18 = size1;
      emailLink2.Size = size18;
      this.EmailLink.TabIndex = 2;
      this.EmailLink.TabStop = true;
      this.EmailLink.Text = "peter@leonardaudio.co.uk";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(9, 49);
      Point point15 = point1;
      label4_1.Location = point15;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(42, 13);
      Size size19 = size1;
      label4_2.Size = size19;
      this.Label4.TabIndex = 1;
      this.Label4.Text = "Twitter:";
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(9, 33);
      Point point16 = point1;
      label3_1.Location = point16;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(33, 13);
      Size size20 = size1;
      label3_2.Size = size20;
      this.Label3.TabIndex = 1;
      this.Label3.Text = "Web:";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(9, 17);
      Point point17 = point1;
      label2_1.Location = point17;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(35, 13);
      Size size21 = size1;
      label2_2.Size = size21;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Email:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(6, 0);
      Point point18 = point1;
      label1_1.Location = point18;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(118, 13);
      Size size22 = size1;
      label1_2.Size = size22;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Contact Information";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.CancelButton = (IButtonControl) this.OKButton;
      size1 = new Size(435, 275);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TableLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AboutBox1);
      padding1 = new Padding(9);
      this.Padding = padding1;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = " ";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((ISupportInitialize) this.LogoPictureBox).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal Label UpdateLabel
    {
      [DebuggerNonUserCode] get => this._UpdateLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._UpdateLabel = value;
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

    internal Panel Panel1
    {
      [DebuggerNonUserCode] get => this._Panel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
    }

    internal LinkLabel WebLink
    {
      [DebuggerNonUserCode] get => this._WebLink;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.WebLink_LinkClicked);
        if (this._WebLink != null)
          this._WebLink.LinkClicked -= clickedEventHandler;
        this._WebLink = value;
        if (this._WebLink == null)
          return;
        this._WebLink.LinkClicked += clickedEventHandler;
      }
    }

    internal LinkLabel EmailLink
    {
      [DebuggerNonUserCode] get => this._EmailLink;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.EmailLink_LinkClicked);
        if (this._EmailLink != null)
          this._EmailLink.LinkClicked -= clickedEventHandler;
        this._EmailLink = value;
        if (this._EmailLink == null)
          return;
        this._EmailLink.LinkClicked += clickedEventHandler;
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

    internal Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal LinkLabel TwitterLink
    {
      [DebuggerNonUserCode] get => this._TwitterLink;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.Twitter_LinkClicked);
        if (this._TwitterLink != null)
          this._TwitterLink.LinkClicked -= clickedEventHandler;
        this._TwitterLink = value;
        if (this._TwitterLink == null)
          return;
        this._TwitterLink.LinkClicked += clickedEventHandler;
      }
    }

    internal Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void AboutBox1_Load(object sender, EventArgs e)
    {
      this.Text = string.Format("About {0}", Operators.CompareString(MyProject.Application.Info.Title, "", false) == 0 ? (object) Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : (object) MyProject.Application.Info.Title);
      this.LabelProductName.Text = MyProject.Application.Info.ProductName;
      this.LabelVersion.Text = string.Format("Version {0}", (object) MyProject.Application.Info.Version.ToString());
      this.LabelCopyright.Text = MyProject.Application.Info.Copyright;
      this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
      this.UpdateButton.Enabled = false;
      this.UpdateLabel.Text = "Checking for Updates...";
      try
      {
        new Thread(new ThreadStart(this.CheckForUpdates)).Start();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.Form1.ReportError(ex, "Error during AboutBox1_Load");
        ProjectData.ClearProjectError();
      }
    }

    private void CheckForUpdates()
    {
      if (ApplicationDeployment.IsNetworkDeployed)
      {
        this.AD = ApplicationDeployment.CurrentDeployment;
        UpdateCheckInfo updateCheckInfo;
        try
        {
          updateCheckInfo = this.AD.CheckForDetailedUpdate();
        }
        catch (DeploymentDownloadException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.UpdateLabelText(this.UpdateLabel, "Cannot check for updates. \r\n\r\nPlease check your network connection, or try again later.\r\nError: " + ex.Message.ToString());
          ProjectData.ClearProjectError();
          return;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          MyProject.Forms.Form1.ReportError(ex, "Error during CheckForUpdates()");
          ProjectData.ClearProjectError();
          return;
        }
        if (updateCheckInfo.UpdateAvailable)
        {
          if (!updateCheckInfo.IsUpdateRequired)
          {
            this.UpdateLabel.Text = "An update is available to version " + updateCheckInfo.AvailableVersion.ToString();
            this.UpdateButton.Enabled = true;
          }
          else
          {
            int num = (int) MessageBox.Show("This application has detected a mandatory update from your current version to version " + updateCheckInfo.MinimumRequiredVersion.ToString() + ". The application will now install the update and restart.", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.UpdateNow();
          }
        }
        else
          this.UpdateLabelText(this.UpdateLabel, "There are no updates currently available");
      }
      else
        this.UpdateLabelText(this.UpdateLabel, "Application is not a ClickOnce application. Updates not available");
    }

    private void UpdateLabelText(Label ThisLabel, string NewText)
    {
      if (ThisLabel.InvokeRequired)
        ThisLabel.BeginInvoke((Delegate) new Action<Label, string>(this.UpdateLabelText), (object) ThisLabel, (object) NewText);
      else
        ThisLabel.Text = NewText;
    }

    private void InstallThread()
    {
      try
      {
        this.AD.Update();
        int num = (int) MessageBox.Show("Update installed. Application will now restart.", "Update Successful");
        System.Windows.Forms.Application.Restart();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.Form1.ReportError(ex, "Error during InstallThread()");
        this.UpdateLabelText(this.UpdateLabel, "Cannot install the latest version of the application. \r\nPlease check your network connection, or try again later.");
        ProjectData.ClearProjectError();
      }
    }

    private void UpdateNow()
    {
      this.UpdateLabelText(this.UpdateLabel, "Installing update...");
      this.UpdateButton.Enabled = false;
      try
      {
        new Thread(new ThreadStart(this.InstallThread)).Start();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.Form1.ReportError(ex, "Error during UpdateNow() in Aboutbox1.vb");
        ProjectData.ClearProjectError();
      }
    }

    private void OKButton_Click(object sender, EventArgs e) => this.Close();

    private void UpdateButton_Click(object sender, EventArgs e) => this.UpdateNow();

    private void WebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://www.leonardaudio.co.uk");

    private void Twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://twitter.com/leonardaudio");

    private void EmailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("mailto:peter@leonardaudio.co.uk");
  }
}
