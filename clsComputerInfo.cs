// Decompiled with JetBrains decompiler
// Type: TransmissionLine.clsComputerInfo
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace TransmissionLine
{
  public class clsComputerInfo
  {
    [DebuggerNonUserCode]
    public clsComputerInfo()
    {
    }

    internal string getMD5Hash(string strToHash)
    {
      byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(strToHash));
      string md5Hash = "";
      byte[] numArray = hash;
      int index = 0;
      while (index < numArray.Length)
      {
        byte num = numArray[index];
        md5Hash += num.ToString("x2");
        checked { ++index; }
      }
      return md5Hash;
    }

    internal string GetProcessorId()
    {
      string empty = string.Empty;
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher((ObjectQuery) new SelectQuery("Win32_processor"));
      try
      {
        foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
          empty = managementBaseObject["processorId"].ToString();
      }
      finally
      {
        ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator = null;
        objectEnumerator?.Dispose();
      }
      return empty;
    }

    internal string GetMACAddress()
    {
      ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
      string macAddress = string.Empty;
      try
      {
        foreach (ManagementObject managementObject in instances)
        {
          if (macAddress.Equals(string.Empty))
          {
            if (Conversions.ToBoolean(managementObject["IPEnabled"]))
              macAddress = managementObject["MacAddress"].ToString();
            managementObject.Dispose();
          }
          macAddress = macAddress.Replace(":", string.Empty);
        }
      }
      finally
      {
        ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator = null;
        objectEnumerator?.Dispose();
      }
      return macAddress;
    }

    internal string GetVolumeSerial(string strDriveLetter = "C")
    {
      ManagementObject managementObject = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", (object) strDriveLetter));
      managementObject.Get();
      return managementObject["VolumeSerialNumber"].ToString();
    }

    internal string GetMotherBoardID()
    {
      string empty = string.Empty;
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher((ObjectQuery) new SelectQuery("Win32_BaseBoard"));
      try
      {
        foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
          empty = managementBaseObject["SerialNumber"].ToString();
      }
      finally
      {
        ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator = null;
        objectEnumerator?.Dispose();
      }
      return empty;
    }
  }
}
