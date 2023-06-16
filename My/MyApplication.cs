// Decompiled with JetBrains decompiler
// Type: TransmissionLine.My.MyApplication
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TransmissionLine.My
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [GeneratedCode("MyTemplate", "10.0.0.0")]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();

    [DebuggerNonUserCode]
    static MyApplication()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (MyApplication.__ENCList)
      {
        if (MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (MyApplication.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (MyApplication.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                MyApplication.__ENCList[index1] = MyApplication.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          MyApplication.__ENCList.RemoveRange(index1, checked (MyApplication.__ENCList.Count - index1));
          MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
        }
        MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [STAThread]
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      MyApplication.__ENCAddToList((object) this);
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.Form1;

    [DebuggerStepThrough]
    protected override void OnCreateSplashScreen() => this.SplashScreen = (Form) MyProject.Forms.SplashScreen;
  }
}
