// Decompiled with JetBrains decompiler
// Type: TransmissionLine.FilterClass
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

namespace TransmissionLine
{
  [DesignerGenerated]
  public class FilterClass : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("LowPassCheckBox")]
    private CheckBox _LowPassCheckBox;
    [AccessedThroughProperty("LowPassQBox")]
    private TextBox _LowPassQBox;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("LowPassfoBox")]
    private TextBox _LowPassfoBox;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("HighPassfoBox")]
    private TextBox _HighPassfoBox;
    [AccessedThroughProperty("HighPassQBox")]
    private TextBox _HighPassQBox;
    [AccessedThroughProperty("HighPassCheckBox")]
    private CheckBox _HighPassCheckBox;
    [AccessedThroughProperty("LowPass24dBRadio")]
    private RadioButton _LowPass24dBRadio;
    [AccessedThroughProperty("LowPass12dBRadio")]
    private RadioButton _LowPass12dBRadio;
    [AccessedThroughProperty("HighPass24dBRadio")]
    private RadioButton _HighPass24dBRadio;
    [AccessedThroughProperty("HighPass12dBRadio")]
    private RadioButton _HighPass12dBRadio;
    private FilterParameters FilterParameterEdit;

    [DebuggerNonUserCode]
    static FilterClass()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (FilterClass.__ENCList)
      {
        if (FilterClass.__ENCList.Count == FilterClass.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (FilterClass.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (FilterClass.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                FilterClass.__ENCList[index1] = FilterClass.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          FilterClass.__ENCList.RemoveRange(index1, checked (FilterClass.__ENCList.Count - index1));
          FilterClass.__ENCList.Capacity = FilterClass.__ENCList.Count;
        }
        FilterClass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.GroupBox1 = new GroupBox();
      this.LowPass24dBRadio = new RadioButton();
      this.LowPass12dBRadio = new RadioButton();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.LowPassfoBox = new TextBox();
      this.LowPassQBox = new TextBox();
      this.LowPassCheckBox = new CheckBox();
      this.GroupBox2 = new GroupBox();
      this.HighPass24dBRadio = new RadioButton();
      this.HighPass12dBRadio = new RadioButton();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.HighPassfoBox = new TextBox();
      this.HighPassQBox = new TextBox();
      this.HighPassCheckBox = new CheckBox();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox1.Controls.Add((Control) this.LowPass24dBRadio);
      this.GroupBox1.Controls.Add((Control) this.LowPass12dBRadio);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.LowPassfoBox);
      this.GroupBox1.Controls.Add((Control) this.LowPassQBox);
      this.GroupBox1.Controls.Add((Control) this.LowPassCheckBox);
      GroupBox groupBox1_1 = this.GroupBox1;
      Point point1 = new Point(12, 13);
      Point point2 = point1;
      groupBox1_1.Location = point2;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      Size size1 = new Size(186, 99);
      Size size2 = size1;
      groupBox1_2.Size = size2;
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Low Pass Filter";
      this.LowPass24dBRadio.AutoSize = true;
      RadioButton lowPass24dBradio1 = this.LowPass24dBRadio;
      point1 = new Point(129, 20);
      Point point3 = point1;
      lowPass24dBradio1.Location = point3;
      this.LowPass24dBRadio.Name = "LowPass24dBRadio";
      RadioButton lowPass24dBradio2 = this.LowPass24dBRadio;
      size1 = new Size(50, 17);
      Size size3 = size1;
      lowPass24dBradio2.Size = size3;
      this.LowPass24dBRadio.TabIndex = 3;
      this.LowPass24dBRadio.TabStop = true;
      this.LowPass24dBRadio.Text = "24dB";
      this.LowPass24dBRadio.UseVisualStyleBackColor = true;
      this.LowPass12dBRadio.AutoSize = true;
      RadioButton lowPass12dBradio1 = this.LowPass12dBRadio;
      point1 = new Point(73, 20);
      Point point4 = point1;
      lowPass12dBradio1.Location = point4;
      this.LowPass12dBRadio.Name = "LowPass12dBRadio";
      RadioButton lowPass12dBradio2 = this.LowPass12dBRadio;
      size1 = new Size(50, 17);
      Size size4 = size1;
      lowPass12dBradio2.Size = size4;
      this.LowPass12dBRadio.TabIndex = 3;
      this.LowPass12dBRadio.TabStop = true;
      this.LowPass12dBRadio.Text = "12dB";
      this.LowPass12dBRadio.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(70, 73);
      Point point5 = point1;
      label2_1.Location = point5;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(113, 13);
      Size size5 = size1;
      label2_2.Size = size5;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Cut-off Frequency (Hz)";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(70, 47);
      Point point6 = point1;
      label1_1.Location = point6;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(72, 13);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Quality Factor";
      TextBox lowPassfoBox1 = this.LowPassfoBox;
      point1 = new Point(7, 70);
      Point point7 = point1;
      lowPassfoBox1.Location = point7;
      this.LowPassfoBox.Name = "LowPassfoBox";
      TextBox lowPassfoBox2 = this.LowPassfoBox;
      size1 = new Size(57, 20);
      Size size7 = size1;
      lowPassfoBox2.Size = size7;
      this.LowPassfoBox.TabIndex = 2;
      TextBox lowPassQbox1 = this.LowPassQBox;
      point1 = new Point(7, 44);
      Point point8 = point1;
      lowPassQbox1.Location = point8;
      this.LowPassQBox.Name = "LowPassQBox";
      TextBox lowPassQbox2 = this.LowPassQBox;
      size1 = new Size(57, 20);
      Size size8 = size1;
      lowPassQbox2.Size = size8;
      this.LowPassQBox.TabIndex = 1;
      this.LowPassCheckBox.AutoSize = true;
      CheckBox lowPassCheckBox1 = this.LowPassCheckBox;
      point1 = new Point(7, 20);
      Point point9 = point1;
      lowPassCheckBox1.Location = point9;
      this.LowPassCheckBox.Name = "LowPassCheckBox";
      CheckBox lowPassCheckBox2 = this.LowPassCheckBox;
      size1 = new Size(59, 17);
      Size size9 = size1;
      lowPassCheckBox2.Size = size9;
      this.LowPassCheckBox.TabIndex = 0;
      this.LowPassCheckBox.Text = "On/Off";
      this.LowPassCheckBox.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.HighPass24dBRadio);
      this.GroupBox2.Controls.Add((Control) this.HighPass12dBRadio);
      this.GroupBox2.Controls.Add((Control) this.Label3);
      this.GroupBox2.Controls.Add((Control) this.Label4);
      this.GroupBox2.Controls.Add((Control) this.HighPassfoBox);
      this.GroupBox2.Controls.Add((Control) this.HighPassQBox);
      this.GroupBox2.Controls.Add((Control) this.HighPassCheckBox);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(12, 118);
      Point point10 = point1;
      groupBox2_1.Location = point10;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(186, 99);
      Size size10 = size1;
      groupBox2_2.Size = size10;
      this.GroupBox2.TabIndex = 0;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "High Pass Filter";
      this.HighPass24dBRadio.AutoSize = true;
      RadioButton highPass24dBradio1 = this.HighPass24dBRadio;
      point1 = new Point(129, 20);
      Point point11 = point1;
      highPass24dBradio1.Location = point11;
      this.HighPass24dBRadio.Name = "HighPass24dBRadio";
      RadioButton highPass24dBradio2 = this.HighPass24dBRadio;
      size1 = new Size(50, 17);
      Size size11 = size1;
      highPass24dBradio2.Size = size11;
      this.HighPass24dBRadio.TabIndex = 6;
      this.HighPass24dBRadio.TabStop = true;
      this.HighPass24dBRadio.Text = "24dB";
      this.HighPass24dBRadio.UseVisualStyleBackColor = true;
      this.HighPass12dBRadio.AutoSize = true;
      RadioButton highPass12dBradio1 = this.HighPass12dBRadio;
      point1 = new Point(73, 20);
      Point point12 = point1;
      highPass12dBradio1.Location = point12;
      this.HighPass12dBRadio.Name = "HighPass12dBRadio";
      RadioButton highPass12dBradio2 = this.HighPass12dBRadio;
      size1 = new Size(50, 17);
      Size size12 = size1;
      highPass12dBradio2.Size = size12;
      this.HighPass12dBRadio.TabIndex = 6;
      this.HighPass12dBRadio.TabStop = true;
      this.HighPass12dBRadio.Text = "12dB";
      this.HighPass12dBRadio.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(70, 73);
      Point point13 = point1;
      label3_1.Location = point13;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(113, 13);
      Size size13 = size1;
      label3_2.Size = size13;
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Cut-off Frequency (Hz)";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(70, 47);
      Point point14 = point1;
      label4_1.Location = point14;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(72, 13);
      Size size14 = size1;
      label4_2.Size = size14;
      this.Label4.TabIndex = 2;
      this.Label4.Text = "Quality Factor";
      TextBox highPassfoBox1 = this.HighPassfoBox;
      point1 = new Point(7, 70);
      Point point15 = point1;
      highPassfoBox1.Location = point15;
      this.HighPassfoBox.Name = "HighPassfoBox";
      TextBox highPassfoBox2 = this.HighPassfoBox;
      size1 = new Size(57, 20);
      Size size15 = size1;
      highPassfoBox2.Size = size15;
      this.HighPassfoBox.TabIndex = 5;
      TextBox highPassQbox1 = this.HighPassQBox;
      point1 = new Point(7, 44);
      Point point16 = point1;
      highPassQbox1.Location = point16;
      this.HighPassQBox.Name = "HighPassQBox";
      TextBox highPassQbox2 = this.HighPassQBox;
      size1 = new Size(57, 20);
      Size size16 = size1;
      highPassQbox2.Size = size16;
      this.HighPassQBox.TabIndex = 4;
      this.HighPassCheckBox.AutoSize = true;
      CheckBox highPassCheckBox1 = this.HighPassCheckBox;
      point1 = new Point(7, 20);
      Point point17 = point1;
      highPassCheckBox1.Location = point17;
      this.HighPassCheckBox.Name = "HighPassCheckBox";
      CheckBox highPassCheckBox2 = this.HighPassCheckBox;
      size1 = new Size(59, 17);
      Size size17 = size1;
      highPassCheckBox2.Size = size17;
      this.HighPassCheckBox.TabIndex = 3;
      this.HighPassCheckBox.Text = "On/Off";
      this.HighPassCheckBox.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(210, 229);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FilterClass);
      this.RightToLeft = RightToLeft.No;
      this.Text = "Filter";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
    }

    internal GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get => this._GroupBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal CheckBox LowPassCheckBox
    {
      [DebuggerNonUserCode] get => this._LowPassCheckBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LowPassCheckBox_CheckedChanged);
        if (this._LowPassCheckBox != null)
          this._LowPassCheckBox.CheckedChanged -= eventHandler;
        this._LowPassCheckBox = value;
        if (this._LowPassCheckBox == null)
          return;
        this._LowPassCheckBox.CheckedChanged += eventHandler;
      }
    }

    internal TextBox LowPassQBox
    {
      [DebuggerNonUserCode] get => this._LowPassQBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LowPassQBox_LostFocus);
        if (this._LowPassQBox != null)
          this._LowPassQBox.LostFocus -= eventHandler;
        this._LowPassQBox = value;
        if (this._LowPassQBox == null)
          return;
        this._LowPassQBox.LostFocus += eventHandler;
      }
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

    internal TextBox LowPassfoBox
    {
      [DebuggerNonUserCode] get => this._LowPassfoBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LowPassfoBox_LostFocus);
        if (this._LowPassfoBox != null)
          this._LowPassfoBox.LostFocus -= eventHandler;
        this._LowPassfoBox = value;
        if (this._LowPassfoBox == null)
          return;
        this._LowPassfoBox.LostFocus += eventHandler;
      }
    }

    internal GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get => this._GroupBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox2 = value;
    }

    internal Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal TextBox HighPassfoBox
    {
      [DebuggerNonUserCode] get => this._HighPassfoBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HighPassfoBox_LostFocus);
        if (this._HighPassfoBox != null)
          this._HighPassfoBox.LostFocus -= eventHandler;
        this._HighPassfoBox = value;
        if (this._HighPassfoBox == null)
          return;
        this._HighPassfoBox.LostFocus += eventHandler;
      }
    }

    internal TextBox HighPassQBox
    {
      [DebuggerNonUserCode] get => this._HighPassQBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HighPassQBox_LostFocus);
        if (this._HighPassQBox != null)
          this._HighPassQBox.LostFocus -= eventHandler;
        this._HighPassQBox = value;
        if (this._HighPassQBox == null)
          return;
        this._HighPassQBox.LostFocus += eventHandler;
      }
    }

    internal CheckBox HighPassCheckBox
    {
      [DebuggerNonUserCode] get => this._HighPassCheckBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HighPassCheckBox_CheckedChanged);
        if (this._HighPassCheckBox != null)
          this._HighPassCheckBox.CheckedChanged -= eventHandler;
        this._HighPassCheckBox = value;
        if (this._HighPassCheckBox == null)
          return;
        this._HighPassCheckBox.CheckedChanged += eventHandler;
      }
    }

    internal RadioButton LowPass24dBRadio
    {
      [DebuggerNonUserCode] get => this._LowPass24dBRadio;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LowPass24dBRadio = value;
    }

    internal RadioButton LowPass12dBRadio
    {
      [DebuggerNonUserCode] get => this._LowPass12dBRadio;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LowPass12dBRadio_CheckedChanged);
        if (this._LowPass12dBRadio != null)
          this._LowPass12dBRadio.CheckedChanged -= eventHandler;
        this._LowPass12dBRadio = value;
        if (this._LowPass12dBRadio == null)
          return;
        this._LowPass12dBRadio.CheckedChanged += eventHandler;
      }
    }

    internal RadioButton HighPass24dBRadio
    {
      [DebuggerNonUserCode] get => this._HighPass24dBRadio;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HighPass24dBRadio = value;
    }

    internal RadioButton HighPass12dBRadio
    {
      [DebuggerNonUserCode] get => this._HighPass12dBRadio;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HighPass12dBRadio_CheckedChanged);
        if (this._HighPass12dBRadio != null)
          this._HighPass12dBRadio.CheckedChanged -= eventHandler;
        this._HighPass12dBRadio = value;
        if (this._HighPass12dBRadio == null)
          return;
        this._HighPass12dBRadio.CheckedChanged += eventHandler;
      }
    }

    public event FilterClass.FilterParameterUpdatedEventHandler FilterParameterUpdated;

    public FilterClass(FilterParameters FilterParameter)
    {
      FilterClass.__ENCAddToList((object) this);
      this.InitializeComponent();
      this.FilterParameterFromParent = FilterParameter;
    }

    public FilterParameters FilterParameterFromParent
    {
      set
      {
        this.FilterParameterEdit = value;
        this.UpdateValuesOnForm();
      }
    }

    private void UpdateValuesOnForm()
    {
      this.LowPassCheckBox.Checked = this.FilterParameterEdit.LowPass.Active;
      this.LowPassQBox.Text = this.FilterParameterEdit.LowPass.Q.ToString();
      this.LowPassfoBox.Text = this.FilterParameterEdit.LowPass.fo.ToString();
      this.HighPassCheckBox.Checked = this.FilterParameterEdit.HighPass.Active;
      this.HighPassQBox.Text = this.FilterParameterEdit.HighPass.Q.ToString();
      this.HighPassfoBox.Text = this.FilterParameterEdit.HighPass.fo.ToString();
      if (this.FilterParameterEdit.LowPass.Order == 2)
        this.LowPass12dBRadio.Checked = true;
      else if (this.FilterParameterEdit.LowPass.Order == 4)
      {
        this.LowPass24dBRadio.Checked = true;
      }
      else
      {
        this.FilterParameterEdit.LowPass.Order = 2;
        this.LowPass12dBRadio.Checked = true;
      }
      if (this.FilterParameterEdit.HighPass.Order == 2)
        this.HighPass12dBRadio.Checked = true;
      else if (this.FilterParameterEdit.HighPass.Order == 4)
      {
        this.HighPass24dBRadio.Checked = true;
      }
      else
      {
        this.FilterParameterEdit.HighPass.Order = 2;
        this.HighPass12dBRadio.Checked = true;
      }
    }

    private void SendValues()
    {
      FilterParameterUpdatedEventArgs e = new FilterParameterUpdatedEventArgs(this.FilterParameterEdit);
      FilterClass.FilterParameterUpdatedEventHandler parameterUpdatedEvent = this.FilterParameterUpdated;
      if (parameterUpdatedEvent == null)
        return;
      parameterUpdatedEvent((object) this, e);
    }

    private void LowPassQBox_LostFocus(object sender, EventArgs e)
    {
      this.FilterParameterEdit.LowPass.Q = Conversions.ToDouble(this.LowPassQBox.Text);
      this.SendValues();
    }

    private void HighPassQBox_LostFocus(object sender, EventArgs e)
    {
      this.FilterParameterEdit.HighPass.Q = Conversions.ToDouble(this.HighPassQBox.Text);
      this.SendValues();
    }

    private void LowPassfoBox_LostFocus(object sender, EventArgs e)
    {
      this.FilterParameterEdit.LowPass.fo = Conversions.ToDouble(this.LowPassfoBox.Text);
      this.SendValues();
    }

    private void HighPassfoBox_LostFocus(object sender, EventArgs e)
    {
      this.FilterParameterEdit.HighPass.fo = Conversions.ToDouble(this.HighPassfoBox.Text);
      this.SendValues();
    }

    private void LowPassCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.FilterParameterEdit.LowPass.Active = this.LowPassCheckBox.Checked;
      this.SendValues();
    }

    private void HighPassCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.FilterParameterEdit.HighPass.Active = this.HighPassCheckBox.Checked;
      this.SendValues();
    }

    private void LowPass12dBRadio_CheckedChanged(object sender, EventArgs e)
    {
      this.FilterParameterEdit.LowPass.Order = !this.LowPass12dBRadio.Checked ? 4 : 2;
      this.SendValues();
    }

    private void HighPass12dBRadio_CheckedChanged(object sender, EventArgs e)
    {
      this.FilterParameterEdit.HighPass.Order = !this.HighPass12dBRadio.Checked ? 4 : 2;
      this.SendValues();
    }

    public delegate void FilterParameterUpdatedEventHandler(
      object Sender,
      FilterParameterUpdatedEventArgs e);
  }
}
