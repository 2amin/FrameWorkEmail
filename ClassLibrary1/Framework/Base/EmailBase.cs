using System;
using System.Net.Mail;

namespace ClassLibrary1.Framework.Base
{
    public class EmailBase<T> : Interface.IEmail<T>
    {
        #region [-ctor-]
        public EmailBase()
        {

        }

        public EmailBase(T text, T youremail, T yourpassword, T freindemail)
        {
            Text = text;
            YourPassword = yourpassword;
            YourEmail = youremail;
            FreindEmail = freindemail;
        }
        public EmailBase(T youremail, T yourpassword, T freindemail)
        {
            YourPassword = yourpassword;
            YourEmail = youremail;
            FreindEmail = freindemail;
        }
        public EmailBase(T youremail, T yourpassword)
        {
            YourPassword = yourpassword;
            YourEmail = youremail;

        }
        public EmailBase(T freindemail)
        {
            FreindEmail = freindemail;
        }
        
        #endregion
        public T Text { get; set; }
        public T YourEmail { get; set; }
        public T YourPassword { get; set; }
        public T FreindEmail { get; set; }

        public void Send()
        {
            //Text = text;
            //YourPassword = yourpassword;
            //YourEmail = youremail;
            //FreindEmail = freindemail;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(Convert.ToString(YourEmail));
            mail.To.Add(Convert.ToString(FreindEmail));
            mail.Subject = "Hi";
            mail.Body = Convert.ToString(Text);
            SmtpServer.Port = 587;//پورت مورد استفاده
            SmtpServer.Credentials = new System.Net.NetworkCredential(Convert.ToString(YourEmail),
            Convert.ToString(YourPassword));
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
           

        }

       
    }
}
