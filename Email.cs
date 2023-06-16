// Decompiled with JetBrains decompiler
// Type: TransmissionLine.Email
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace TransmissionLine
{
  public class Email
  {
    private string _smtpHost;
    private string _smtpUser;
    private string _smtpPass;
    private string _message;
    private string _subject;
    private List<string> _toEmail;
    private List<string> _ccs;
    private List<string> _bccs;
    private List<string> _attachments;
    private int _smtpPort;
    private bool _useEncryption;
    private bool _htmlEmail;

    public Email()
    {
      this._toEmail = new List<string>();
      this._ccs = new List<string>();
      this._bccs = new List<string>();
      this._attachments = new List<string>();
      this._smtpPort = 525;
      this._htmlEmail = false;
    }

    public Email(string smtpHost, string smtpUser, string smtpPass)
    {
      this._toEmail = new List<string>();
      this._ccs = new List<string>();
      this._bccs = new List<string>();
      this._attachments = new List<string>();
      this._smtpPort = 525;
      this._htmlEmail = false;
      this._smtpHost = smtpHost;
      this._smtpPass = smtpPass;
      this._smtpUser = smtpUser;
    }

    public Email(
      string smtpHost,
      string smtpUser,
      string smtpPass,
      string subject,
      string message)
    {
      this._toEmail = new List<string>();
      this._ccs = new List<string>();
      this._bccs = new List<string>();
      this._attachments = new List<string>();
      this._smtpPort = 525;
      this._htmlEmail = false;
      this._smtpHost = smtpHost;
      this._smtpPass = smtpPass;
      this._smtpUser = smtpUser;
      this._subject = subject;
      this._message = message;
    }

    public string smtpHost
    {
      get => this._smtpHost;
      set => this._smtpHost = value;
    }

    public string smtpUser
    {
      get => this._smtpUser;
      set => this._smtpUser = value;
    }

    public string smtpPass
    {
      get => this._smtpPass;
      set => this._smtpPass = value;
    }

    public string message
    {
      get => this._message;
      set => this._message = value;
    }

    public string subject
    {
      get => this._subject;
      set => this._subject = value;
    }

    public List<string> CCs
    {
      get => this._ccs;
      set => this._ccs = value;
    }

    public List<string> BCCs
    {
      get => this._bccs;
      set => this._bccs = value;
    }

    public List<string> Tos
    {
      get => this._toEmail;
      set => this._toEmail = value;
    }

    public int SMTPPort
    {
      get => this._smtpPort;
      set => this._smtpPort = value;
    }

    public bool UseEncryption
    {
      get => this._useEncryption;
      set => this._useEncryption = value;
    }

    public bool HTMLEmail
    {
      get => this._htmlEmail;
      set => this._htmlEmail = value;
    }

    [Obsolete("This method should no longer be used, instead use the Tos property", true)]
    public void addToEmail(string emailAddress) => this.Tos.Add(emailAddress);

    public bool addAttachment(string fileLocation)
    {
      bool flag = false;
      if (System.IO.File.Exists(fileLocation))
      {
        flag = true;
        this._attachments.Add(fileLocation);
      }
      return flag;
    }

    public List<string> getAttachments() => this._attachments;

    public void removeAttachment(string fileLocation) => this._attachments.Remove(fileLocation);

    private bool attachmentsAreAvailable()
    {
      bool flag = true;
      try
      {
        foreach (string attachment in this._attachments)
        {
          if (!System.IO.File.Exists(attachment))
          {
            flag = false;
            break;
          }
        }
      }
      finally
      {
        List<string>.Enumerator enumerator = default;
        enumerator.Dispose();
      }
      return flag;
    }

    public Email.sendEmailResult sendEmail()
    {
      Email.sendEmailResult sendEmailResult = Email.sendEmailResult.successful;
      if (this._subject.Length > 0)
      {
        if (this._message.Length > 0)
        {
          if (this.Tos.Count > 0)
          {
            if (this._smtpHost.Length > 0 & this._smtpPass.Length > 0 & this._smtpUser.Length > 0)
            {
              if (this.attachmentsAreAvailable())
              {
                MailMessage message = new MailMessage();
                message.Body = this._message;
                message.Subject = this._subject;
                message.From = new MailAddress(this._smtpUser);
                if (this._htmlEmail)
                {
                  message.IsBodyHtml = this._htmlEmail;
                  message.BodyEncoding = Encoding.UTF8;
                }
                try
                {
                  foreach (string to in this.Tos)
                    message.To.Add(to);
                }
                finally
                {
                  List<string>.Enumerator enumerator = default;
                  enumerator.Dispose();
                }
                try
                {
                  foreach (string cc in this.CCs)
                    message.CC.Add(cc);
                }
                finally
                {
                  List<string>.Enumerator enumerator = default;
                  enumerator.Dispose();
                }
                try
                {
                  foreach (string bcC in this.BCCs)
                    message.Bcc.Add(bcC);
                }
                finally
                {
                  List<string>.Enumerator enumerator = default;
                  enumerator.Dispose();
                }
                try
                {
                  foreach (string attachment in this._attachments)
                    message.Attachments.Add(new Attachment(attachment));
                }
                finally
                {
                  List<string>.Enumerator enumerator = default;
                  enumerator.Dispose();
                }
                SmtpClient smtpClient = new SmtpClient(this._smtpHost);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(this._smtpUser, this._smtpPass);
                smtpClient.EnableSsl = this.UseEncryption;
                smtpClient.Port = this.SMTPPort;
                bool flag;
                try
                {
                  smtpClient.Send(message);
                  sendEmailResult = Email.sendEmailResult.successful;
                  flag = true;
                }
                catch (SmtpException ex)
                {
                  ProjectData.SetProjectError((Exception) ex);
                  flag = false;
                  smtpClient.Send(message);
                  ProjectData.ClearProjectError();
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  sendEmailResult = Email.sendEmailResult.unknownError;
                  flag = false;
                  ProjectData.ClearProjectError();
                }
                if (!flag)
                {
                  Thread.Sleep(1000);
                  try
                  {
                    smtpClient.Send(message);
                    sendEmailResult = Email.sendEmailResult.successful;
                  }
                  catch (SmtpException ex)
                  {
                    ProjectData.SetProjectError((Exception) ex);
                    sendEmailResult = Email.sendEmailResult.unableToConnect;
                    ProjectData.ClearProjectError();
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    sendEmailResult = Email.sendEmailResult.unknownError;
                    ProjectData.ClearProjectError();
                  }
                }
                message.Dispose();
              }
              else
                sendEmailResult = Email.sendEmailResult.attachmentNotAvailable;
            }
            else
              sendEmailResult = Email.sendEmailResult.noSMTPDetails;
          }
          else
            sendEmailResult = Email.sendEmailResult.noToEmails;
        }
        else
          sendEmailResult = Email.sendEmailResult.noMessage;
      }
      else
        sendEmailResult = Email.sendEmailResult.noSubject;
      return sendEmailResult;
    }

    public enum sendEmailResult
    {
      successful = 0,
      noToEmails = 1,
      noMessage = 2,
      noSubject = 3,
      noSMTPDetails = 4,
      unableToConnect = 5,
      attachmentNotAvailable = 6,
      unknownError = 99, // 0x00000063
    }
  }
}
