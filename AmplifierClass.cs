// Decompiled with JetBrains decompiler
// Type: TransmissionLine.AmplifierClass
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
  public class AmplifierClass : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("PowerBox")]
    private TextBox _PowerBox;
    [AccessedThroughProperty("RgBox")]
    private TextBox _RgBox;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("UpdateButton")]
    private Button _UpdateButton;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("PowerButton")]
    private RadioButton _PowerButton;
    [AccessedThroughProperty("VoltageButton")]
    private RadioButton _VoltageButton;
    [AccessedThroughProperty("VoltageBox")]
    private TextBox _VoltageBox;
    [AccessedThroughProperty("ReBox")]
    private TextBox _ReBox;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    private AmplifierParameters AmplifierParameterEdit;
    private double ReEdit;

    [DebuggerNonUserCode]
    static AmplifierClass()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (AmplifierClass.__ENCList)
      {
        if (AmplifierClass.__ENCList.Count == AmplifierClass.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (AmplifierClass.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (AmplifierClass.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                AmplifierClass.__ENCList[index1] = AmplifierClass.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          AmplifierClass.__ENCList.RemoveRange(index1, checked (AmplifierClass.__ENCList.Count - index1));
          AmplifierClass.__ENCList.Capacity = AmplifierClass.__ENCList.Count;
        }
        AmplifierClass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.GroupBox3 = new GroupBox();
      this.Label2 = new Label();
      this.PowerButton = new RadioButton();
      this.VoltageButton = new RadioButton();
      this.PowerBox = new TextBox();
      this.VoltageBox = new TextBox();
      this.ReBox = new TextBox();
      this.RgBox = new TextBox();
      this.Label1 = new Label();
      this.Label13 = new Label();
      this.Label6 = new Label();
      this.UpdateButton = new Button();
      this.GroupBox3.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox3.Controls.Add((Control) this.Label2);
      this.GroupBox3.Controls.Add((Control) this.PowerButton);
      this.GroupBox3.Controls.Add((Control) this.VoltageButton);
      this.GroupBox3.Controls.Add((Control) this.PowerBox);
      this.GroupBox3.Controls.Add((Control) this.VoltageBox);
      this.GroupBox3.Controls.Add((Control) this.ReBox);
      this.GroupBox3.Controls.Add((Control) this.RgBox);
      this.GroupBox3.Controls.Add((Control) this.Label1);
      this.GroupBox3.Controls.Add((Control) this.Label13);
      this.GroupBox3.Controls.Add((Control) this.Label6);
      GroupBox groupBox3_1 = this.GroupBox3;
      Point point1 = new Point(12, 12);
      Point point2 = point1;
      groupBox3_1.Location = point2;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      Size size1 = new Size(187, 136);
      Size size2 = size1;
      groupBox3_2.Size = size2;
      this.GroupBox3.TabIndex = 14;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Amplifier Parameters";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(84, 30);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(19, 13);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 5;
      this.Label2.Text = "Re";
      this.PowerButton.AutoSize = true;
      this.PowerButton.Checked = true;
      RadioButton powerButton1 = this.PowerButton;
      point1 = new Point(6, 104);
      Point point4 = point1;
      powerButton1.Location = point4;
      this.PowerButton.Name = "PowerButton";
      RadioButton powerButton2 = this.PowerButton;
      size1 = new Size(14, 13);
      Size size4 = size1;
      powerButton2.Size = size4;
      this.PowerButton.TabIndex = 4;
      this.PowerButton.TabStop = true;
      this.PowerButton.UseVisualStyleBackColor = true;
      this.VoltageButton.AutoSize = true;
      RadioButton voltageButton1 = this.VoltageButton;
      point1 = new Point(6, 78);
      Point point5 = point1;
      voltageButton1.Location = point5;
      this.VoltageButton.Name = "VoltageButton";
      RadioButton voltageButton2 = this.VoltageButton;
      size1 = new Size(14, 13);
      Size size5 = size1;
      voltageButton2.Size = size5;
      this.VoltageButton.TabIndex = 2;
      this.VoltageButton.UseVisualStyleBackColor = true;
      TextBox powerBox1 = this.PowerBox;
      point1 = new Point(26, 101);
      Point point6 = point1;
      powerBox1.Location = point6;
      this.PowerBox.Name = "PowerBox";
      TextBox powerBox2 = this.PowerBox;
      size1 = new Size(57, 20);
      Size size6 = size1;
      powerBox2.Size = size6;
      this.PowerBox.TabIndex = 5;
      TextBox voltageBox1 = this.VoltageBox;
      point1 = new Point(26, 75);
      Point point7 = point1;
      voltageBox1.Location = point7;
      this.VoltageBox.Name = "VoltageBox";
      TextBox voltageBox2 = this.VoltageBox;
      size1 = new Size(57, 20);
      Size size7 = size1;
      voltageBox2.Size = size7;
      this.VoltageBox.TabIndex = 3;
      TextBox reBox1 = this.ReBox;
      point1 = new Point(26, 23);
      Point point8 = point1;
      reBox1.Location = point8;
      this.ReBox.Name = "ReBox";
      this.ReBox.ReadOnly = true;
      TextBox reBox2 = this.ReBox;
      size1 = new Size(57, 20);
      Size size8 = size1;
      reBox2.Size = size8;
      this.ReBox.TabIndex = 0;
      TextBox rgBox1 = this.RgBox;
      point1 = new Point(26, 49);
      Point point9 = point1;
      rgBox1.Location = point9;
      this.RgBox.Name = "RgBox";
      TextBox rgBox2 = this.RgBox;
      size1 = new Size(57, 20);
      Size size9 = size1;
      rgBox2.Size = size9;
      this.RgBox.TabIndex = 1;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(84, 78);
      Point point10 = point1;
      label1_1.Location = point10;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(88, 13);
      Size size10 = size1;
      label1_2.Size = size10;
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Ouput Voltage (V)";
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label13_1 = this.Label13;
      point1 = new Point(84, 105);
      Point point11 = point1;
      label13_1.Location = point11;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(90, 13);
      Size size11 = size1;
      label13_2.Size = size11;
      this.Label13.TabIndex = 3;
      this.Label13.Text = "Output Power (W)";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label6_1 = this.Label6;
      point1 = new Point(84, 53);
      Point point12 = point1;
      label6_1.Location = point12;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(33, 13);
      Size size12 = size1;
      label6_2.Size = size12;
      this.Label6.TabIndex = 3;
      this.Label6.Text = "Rg (Ω)";
      Button updateButton1 = this.UpdateButton;
      point1 = new Point(12, 154);
      Point point13 = point1;
      updateButton1.Location = point13;
      this.UpdateButton.Name = "UpdateButton";
      Button updateButton2 = this.UpdateButton;
      size1 = new Size(75, 23);
      Size size13 = size1;
      updateButton2.Size = size13;
      this.UpdateButton.TabIndex = 6;
      this.UpdateButton.Text = "Update";
      this.UpdateButton.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(210, 187);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.UpdateButton);
      this.Controls.Add((Control) this.GroupBox3);
      this.DataBindings.Add(new Binding("Location", (object) MySettings.Default, "AmplifierLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Location = MySettings.Default.AmplifierLocation;
      this.Name = nameof (AmplifierClass);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Amplifier";
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.ResumeLayout(false);
    }

    internal GroupBox GroupBox3
    {
      [DebuggerNonUserCode] get => this._GroupBox3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox3 = value;
    }

    internal TextBox PowerBox
    {
      [DebuggerNonUserCode] get => this._PowerBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PowerBox_LostFocus);
        if (this._PowerBox != null)
          this._PowerBox.LostFocus -= eventHandler;
        this._PowerBox = value;
        if (this._PowerBox == null)
          return;
        this._PowerBox.LostFocus += eventHandler;
      }
    }

    internal TextBox RgBox
    {
      [DebuggerNonUserCode] get => this._RgBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RgBox_LostFocus);
        if (this._RgBox != null)
          this._RgBox.LostFocus -= eventHandler;
        this._RgBox = value;
        if (this._RgBox == null)
          return;
        this._RgBox.LostFocus += eventHandler;
      }
    }

    internal Label Label13
    {
      [DebuggerNonUserCode] get => this._Label13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
    }

    internal Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

    internal Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal RadioButton PowerButton
    {
      [DebuggerNonUserCode] get => this._PowerButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PowerButton = value;
    }

    internal RadioButton VoltageButton
    {
      [DebuggerNonUserCode] get => this._VoltageButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VoltageButton_CheckedChanged);
        if (this._VoltageButton != null)
          this._VoltageButton.CheckedChanged -= eventHandler;
        this._VoltageButton = value;
        if (this._VoltageButton == null)
          return;
        this._VoltageButton.CheckedChanged += eventHandler;
      }
    }

    internal TextBox VoltageBox
    {
      [DebuggerNonUserCode] get => this._VoltageBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.VoltageBox_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.RgBox_LostFocus);
        if (this._VoltageBox != null)
        {
          this._VoltageBox.LostFocus -= eventHandler1;
          this._VoltageBox.LostFocus -= eventHandler2;
        }
        this._VoltageBox = value;
        if (this._VoltageBox == null)
          return;
        this._VoltageBox.LostFocus += eventHandler1;
        this._VoltageBox.LostFocus += eventHandler2;
      }
    }

    internal TextBox ReBox
    {
      [DebuggerNonUserCode] get => this._ReBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RgBox_LostFocus);
        if (this._ReBox != null)
          this._ReBox.LostFocus -= eventHandler;
        this._ReBox = value;
        if (this._ReBox == null)
          return;
        this._ReBox.LostFocus += eventHandler;
      }
    }

    internal Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    public event AmplifierClass.AmplifierParameterUpdatedEventHandler AmplifierParameterUpdated;

    public AmplifierClass(AmplifierParameters AmplifierParameter, double Re)
    {
      AmplifierClass.__ENCAddToList((object) this);
      this.InitializeComponent();
      this.AmplifierParameterFromParent = AmplifierParameter;
      this.ReFromParent = Re;
      this.VoltageBox.ReadOnly = true;
      this.VoltageButton.Checked = false;
      this.PowerBox.ReadOnly = false;
      this.PowerButton.Checked = true;
    }

    public AmplifierParameters AmplifierParameterFromParent
    {
      set
      {
        this.AmplifierParameterEdit = value;
        this.UpdateValuesOnForm();
      }
    }

    public double ReFromParent
    {
      set
      {
        this.ReEdit = value;
        this.UpdateValuesOnForm();
      }
    }

    private void SendValues()
    {
      AmplifierParameterUpdatedEventArgs e = new AmplifierParameterUpdatedEventArgs(this.AmplifierParameterEdit);
      AmplifierClass.AmplifierParameterUpdatedEventHandler parameterUpdatedEvent = this.AmplifierParameterUpdated;
      if (parameterUpdatedEvent == null)
        return;
      parameterUpdatedEvent((object) this, e);
    }

    private void UpdateValuesOnForm()
    {
      this.PowerBox.Text = this.AmplifierParameterEdit.Power.ToString();
      this.RgBox.Text = this.AmplifierParameterEdit.Rg.ToString();
      this.ReBox.Text = this.ReEdit.ToString();
      this.VoltageBox.Text = Math.Round(Math.Sqrt(this.AmplifierParameterEdit.Power * this.ReEdit), 3).ToString();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
      this.AmplifierParameterEdit.Power = Conversions.ToDouble(this.PowerBox.Text);
      this.AmplifierParameterEdit.Rg = Conversions.ToDouble(this.RgBox.Text);
      this.SendValues();
    }

    private void PowerBox_LostFocus(object sender, EventArgs e)
    {
      if (!Functions.ErrorCheckNum(this.PowerBox.Text, 0.1, 10000.0))
        this.PowerBox.Text = this.AmplifierParameterEdit.Power.ToString();
      this.VoltageBox.Text = Math.Round(Math.Sqrt(Conversions.ToDouble(this.PowerBox.Text) * this.ReEdit), 3).ToString();
    }

    private void RgBox_LostFocus(object sender, EventArgs e)
    {
      if (Functions.ErrorCheckNum(this.RgBox.Text, 0.0, 10.0))
        return;
      this.RgBox.Text = this.AmplifierParameterEdit.Rg.ToString();
    }

    private void VoltageButton_CheckedChanged(object sender, EventArgs e)
    {
      this.VoltageBox.ReadOnly = !this.VoltageButton.Checked;
      this.PowerBox.ReadOnly = this.VoltageButton.Checked;
    }

    private void VoltageBox_LostFocus(object sender, EventArgs e) => this.PowerBox.Text = Math.Round(Math.Pow(Conversions.ToDouble(this.VoltageBox.Text), 2.0) / this.ReEdit, 3).ToString();

    public delegate void AmplifierParameterUpdatedEventHandler(
      object Sender,
      AmplifierParameterUpdatedEventArgs e);
  }
}
