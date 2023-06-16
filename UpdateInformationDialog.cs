// Decompiled with JetBrains decompiler
// Type: TransmissionLine.UpdateInformationDialog
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
  public class UpdateInformationDialog : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;
    [AccessedThroughProperty("VersionTextBox")]
    private TextBox _VersionTextBox;
    private string VersionText;

    [DebuggerNonUserCode]
    static UpdateInformationDialog()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (UpdateInformationDialog.__ENCList)
      {
        if (UpdateInformationDialog.__ENCList.Count == UpdateInformationDialog.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (UpdateInformationDialog.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (UpdateInformationDialog.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                UpdateInformationDialog.__ENCList[index1] = UpdateInformationDialog.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          UpdateInformationDialog.__ENCList.RemoveRange(index1, checked (UpdateInformationDialog.__ENCList.Count - index1));
          UpdateInformationDialog.__ENCList.Capacity = UpdateInformationDialog.__ENCList.Count;
        }
        UpdateInformationDialog.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.OK_Button = new Button();
      this.VersionTextBox = new TextBox();
      this.SuspendLayout();
      this.OK_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button okButton1 = this.OK_Button;
      Point point1 = new Point(339, 251);
      Point point2 = point1;
      okButton1.Location = point2;
      this.OK_Button.Name = "OK_Button";
      Button okButton2 = this.OK_Button;
      Size size1 = new Size(64, 24);
      Size size2 = size1;
      okButton2.Size = size2;
      this.OK_Button.TabIndex = 0;
      this.OK_Button.Text = "OK";
      this.VersionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox versionTextBox1 = this.VersionTextBox;
      point1 = new Point(0, 0);
      Point point3 = point1;
      versionTextBox1.Location = point3;
      this.VersionTextBox.Multiline = true;
      this.VersionTextBox.Name = "VersionTextBox";
      this.VersionTextBox.ScrollBars = ScrollBars.Vertical;
      TextBox versionTextBox2 = this.VersionTextBox;
      size1 = new Size(403, 245);
      Size size3 = size1;
      versionTextBox2.Size = size3;
      this.VersionTextBox.TabIndex = 1;
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(404, 276);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.VersionTextBox);
      this.Controls.Add((Control) this.OK_Button);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (UpdateInformationDialog);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Version Update Information";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal Button OK_Button
    {
      [DebuggerNonUserCode] get => this._OK_Button;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
        if (this._OK_Button != null)
          this._OK_Button.Click -= eventHandler;
        this._OK_Button = value;
        if (this._OK_Button == null)
          return;
        this._OK_Button.Click += eventHandler;
      }
    }

    internal TextBox VersionTextBox
    {
      [DebuggerNonUserCode] get => this._VersionTextBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VersionTextBox = value;
    }

    public UpdateInformationDialog(string Version)
    {
      this.Load += new EventHandler(this.UpdateInformationDialog_Load);
      UpdateInformationDialog.__ENCAddToList((object) this);
      this.InitializeComponent();
      this.VersionText = Version;
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void UpdateInformationDialog_Load(object sender, EventArgs e)
    {
      string str1 = "";
      string[] strArray = this.VersionText.Split('.');
      if (strArray.GetUpperBound(0) == 3)
      {
        int integer1 = Conversions.ToInteger(strArray[0]);
        int integer2 = Conversions.ToInteger(strArray[1]);
        int integer3 = Conversions.ToInteger(strArray[2]);
        int integer4 = Conversions.ToInteger(strArray[3]);
        string str2 = str1 + "You have upgraded to version " + MyProject.Application.Info.Version.ToString() + " from version " + this.VersionText + "\r\n\r\nFollow us on Twitter (@leonardaudio) for updates." + "\r\n\r\nEmail us at peter@leonardaudio.co.uk with any problems / suggestions / comments you may have.";
        int num1 = 3;
        int num2 = 6;
        int num3 = 1;
        int num4 = 7;
        if (integer1 < 3 | integer1 == num1 & integer2 < num2 | integer1 == num1 & integer2 == num2 & integer3 < num3 | integer1 == num1 & integer2 == num2 & integer3 == num3 & integer4 < num4)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num1.ToString() + "." + num2.ToString() + "." + num3.ToString() + "." + num4.ToString() + " ----- \r\n" + "\r\nWhen altering a Start/End Area in the Geometry Display Window, holding Ctrl will also change the area of adjoining elements and branches if they originally had the same area\r\n" + "\r\nWhen a new element or branch is created it is now automatically selected.\r\n" + "\r\nThe driver library can now read .wdr (WinISD Driver) files. We suggest that you copy these from your WinISD directory to your folder library directory as this application will not have permission to write to files in the WinISD folder.\r\n" + "\r\nRecently accessed files can now be opened via File -> Recent Files\r\n";
        int num5 = 3;
        int num6 = 6;
        int num7 = 1;
        int num8 = 8;
        if (integer1 < 3 | integer1 == num5 & integer2 < num6 | integer1 == num5 & integer2 == num6 & integer3 < num7 | integer1 == num5 & integer2 == num6 & integer3 == num7 & integer4 < num8)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num5.ToString() + "." + num6.ToString() + "." + num7.ToString() + "." + num8.ToString() + " ----- \r\n" + "\r\nFixed bug where the element split/drag feature would not work. This happened when the user was not using meters as their unit\r\n";
        int num9 = 3;
        int num10 = 6;
        int num11 = 1;
        int num12 = 9;
        if (integer1 < 3 | integer1 == num9 & integer2 < num10 | integer1 == num9 & integer2 == num10 & integer3 < num11 | integer1 == num9 & integer2 == num10 & integer3 == num11 & integer4 < num12)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num9.ToString() + "." + num10.ToString() + "." + num11.ToString() + "." + num12.ToString() + " ----- \r\n" + "\r\nThe split move feature is available when you select an element to either the left or right of a split (Previously only worked on the element to the left of split.)\r\n" + "\r\nWhen changing the start or end area of an element, holding down Shift makes the other area the same (Making/Keeping the element straight)\r\n" + "\r\nAdded 'Create Tapped Horn' option in geometry editor\r\n" + "\r\nLength, Area and Split Handles are now orientated correctly\r\n" + "\r\nThe number of Undo/Redo steps can be edited within the Tool -> Settings menu\r\n" + "\r\nAltered the graph displays so that they are resizable. Also enabled Driver/IB/System selection for Displacement and Group Delay graphs\r\n";
        int num13 = 3;
        int num14 = 6;
        int num15 = 1;
        int num16 = 10;
        if (integer1 < 3 | integer1 == num13 & integer2 < num14 | integer1 == num13 & integer2 == num14 & integer3 < num15 | integer1 == num13 & integer2 == num14 & integer3 == num15 & integer4 < num16)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num13.ToString() + "." + num14.ToString() + "." + num15.ToString() + "." + num16.ToString() + " ----- \r\n" + "\r\nThe status bar now gives Frequency and Value (SPL etc.) informtaion when clicking on a graph\r\n" + "\r\nRight clicking on a graph gives the option to copy the graph image to the clipboard or save it as a picture\r\n" + "\r\nIn the Geometry editor, the enter key will update the form when editing a value\r\n";
        int num17 = 3;
        int num18 = 6;
        int num19 = 1;
        int num20 = 11;
        if (integer1 < 3 | integer1 == num17 & integer2 < num18 | integer1 == num17 & integer2 == num18 & integer3 < num19 | integer1 == num17 & integer2 == num18 & integer3 == num19 & integer4 < num20)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num17.ToString() + "." + num18.ToString() + "." + num19.ToString() + "." + num20.ToString() + " ----- \r\n" + "\r\nFixed bug where during a length 'drag', the wrong units were displayed in the status bar.\r\n" + "\r\nPressing Enter to update now works in the Depth field of the Enclosure Window.\r\n" + "\r\nThe main form now remembers its size as well as position.\r\n" + "\r\nThe name of the driver is now displayed in the Enclosure Window's toolbar.\r\n" + "\r\nUndo and Redo shortcuts (Ctrl+Z and Ctrl+Y) now work from within the Enclosure Window.\r\n" + "\r\nWhen right-clicking on over-lapping elements in the Enclosure Window, the 'Select-Element' menu is not displayed if one of those elements is already selected\r\n";
        int num21 = 3;
        int num22 = 6;
        int num23 = 1;
        int num24 = 12;
        if (integer1 < 3 | integer1 == num21 & integer2 < num22 | integer1 == num21 & integer2 == num22 & integer3 < num23 | integer1 == num21 & integer2 == num22 & integer3 == num23 & integer4 < num24)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num21.ToString() + "." + num22.ToString() + "." + num23.ToString() + "." + num24.ToString() + " ----- \r\n" + "\r\nAdded a 'Reset View' option to the right-click menu of the Enclosure Window. This should help users who 'lose' their enclosure from excessive zooming/panning.\r\n" + "\r\nFixed a bug where the Driver Isobaric setting kept resetting to Series.\r\n" + "\r\nFixed a bug where minimising the main window would cause an error.\r\n" + "\r\nFixed a bug where drawing Terminus cursor lines when there is no Terminus would cause an error.\r\n";
        int num25 = 3;
        int num26 = 6;
        int num27 = 2;
        int num28 = 0;
        if (integer1 < 3 | integer1 == num25 & integer2 < num26 | integer1 == num25 & integer2 == num26 & integer3 < num27 | integer1 == num25 & integer2 == num26 & integer3 == num27 & integer4 < num28)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num25.ToString() + "." + num26.ToString() + "." + num27.ToString() + "." + num28.ToString() + " ----- \r\n" + "\r\nImplemented the ability to drag the driver along the length of teh transmission line. This allows for much easier driver offsets. The downside to this update is that the changes cannot work with the Tapped Horn feature so this has been disabled for now.\r\n";
        int num29 = 3;
        int num30 = 6;
        int num31 = 3;
        int num32 = 0;
        if (integer1 < 3 | integer1 == num29 & integer2 < num30 | integer1 == num29 & integer2 == num30 & integer3 < num31 | integer1 == num29 & integer2 == num30 & integer3 == num31 & integer4 < num32)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num29.ToString() + "." + num30.ToString() + "." + num31.ToString() + "." + num32.ToString() + " ----- \r\n" + "\r\nAdded a DriverPosition box to the enclosure geometry window to enable accurate editing of the driver position\r\n" + "\r\nAdded a Filter Window. Here you can implement a low-pass and/or high-pass filter. Filters are currently only 2nd order (12dB/Octave).\r\n" + "\r\nUpdated the tab order on all forms.\r\n";
        int num33 = 3;
        int num34 = 6;
        int num35 = 3;
        int num36 = 1;
        if (integer1 < 3 | integer1 == num33 & integer2 < num34 | integer1 == num33 & integer2 == num34 & integer3 < num35 | integer1 == num33 & integer2 == num34 & integer3 == num35 & integer4 < num36)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num33.ToString() + "." + num34.ToString() + "." + num35.ToString() + "." + num36.ToString() + " ----- \r\n" + "\r\nModel Upgrade: More accurate radiation impedance calculation implemented.\r\n" + "\r\nFixed Bug: DriverPosition edit box not updating model properly.\r\n" + "\r\nAdded Feature: Filters can now be 2nd order (12dB/Octave) or 4th order (24dB/Octave).\r\n";
        int num37 = 3;
        int num38 = 6;
        int num39 = 3;
        int num40 = 2;
        if (integer1 < 3 | integer1 == num37 & integer2 < num38 | integer1 == num37 & integer2 == num38 & integer3 < num39 | integer1 == num37 & integer2 == num38 & integer3 == num39 & integer4 < num40)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num37.ToString() + "." + num38.ToString() + "." + num39.ToString() + "." + num40.ToString() + " ----- \r\n" + "\r\nGUI Update: Added a decimal place to the graph cursor readout\r\n" + "\r\nFixed Bug: Branches on the first element were not being modelled.\r\n" + "\r\nModel Upgrade: Stuffing model has been altered to give increased absorption at high frequencies. Stuffing extent has been altered and is now approximately equal to stuffing density in kg/m\u00B3\r\n";
        int num41 = 3;
        int num42 = 6;
        int num43 = 3;
        int num44 = 3;
        if (integer1 < 3 | integer1 == num41 & integer2 < num42 | integer1 == num41 & integer2 == num42 & integer3 < num43 | integer1 == num41 & integer2 == num42 & integer3 == num43 & integer4 < num44)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num41.ToString() + "." + num42.ToString() + "." + num43.ToString() + "." + num44.ToString() + " ----- \r\n" + "\r\nGUI Update: When dragging the driver, it's position is now displayed in the status bar\r\n" + "\r\nGUI Update: Geometry Display window title changed to 'Enclosure' to match its name in the Window menu\r\n" + "\r\nModel Upgrade: Tapped Horn facility has been reintroduced. Click on the Tapped Horn button in the Enclosure window to enable the 'Tap'. Drag the Tap position in the same way as the Driver.\r\n";
        int num45 = 3;
        int num46 = 6;
        int num47 = 3;
        int num48 = 4;
        if (integer1 < 3 | integer1 == num45 & integer2 < num46 | integer1 == num45 & integer2 == num46 & integer3 < num47 | integer1 == num45 & integer2 == num46 & integer3 == num47 & integer4 < num48)
          str2 = str2 + "\r\n\r\n" + "\r\n ----- Updates in version " + num45.ToString() + "." + num46.ToString() + "." + num47.ToString() + "." + num48.ToString() + " ----- \r\n" + "\r\nGUI Update: The progress bar now resets to zero upon completion rather than staying at 100%\r\n" + "\r\nGUI Update: Auxillary windows are now not always on top\r\n" + "\r\nWe have created a help file which can be accessed via the Help menu or on the leonardaudio.co.uk website.\r\n" + "\r\nNew Feature: In the Enclosure editing window there is a 'Wizard' drop down menu to automatically create some simple enclosure designs.\r\n";
        this.VersionTextBox.Text = str2;
      }
      else
      {
        if (Operators.CompareString(this.VersionText, "0", false) != 0)
          return;
        this.VersionTextBox.Text = str1 + "This appears to be the first time you have used this software. Please contact peter@leonardaudio.co.uk if you require assistance. You can also visit an active discussion regarding the software over at the DIYaudio forums:" + "\r\nhttp://www.diyaudio.com/forums/software-tools/220421-transmission-line-modelling-software.html";
      }
    }
  }
}
