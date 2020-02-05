using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpf
{
    class Helper
    {
        //public static bool SendMail(MailMessage msg, out string result)
        //{
        //    result = "";

        //    msg.From 

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.Port = 587;
        //    //smtp.EnableSsl = true;
        //    smtp.DeliveryMethod
        //        = SmtpDeliveryMethod.Network;
        //    smtp.UseDefaultCredentials = false;
        //    smtp.Credentials = new NetworkCredential(
        //        "alish3383@gmail.com",
        //        "alish0405");

        //    try
        //    {
        //        smtp.Send(msg);
        //        lblMessage.Content = "Письмо успешно отправлено";
        //        lblMessage.Foreground = new SolidColorBrush(Colors.Green);
        //    }
        //    catch (Exception ex)
        //    {
        //        lblMessage.Content = "Ошибка, письмо не отправлено. Причина:" + ex.Message;
        //        lblMessage.Foreground = new SolidColorBrush(Colors.Red);
        //    }
        //    //msg.To = new MailAddressCollection().Add(new MailAddress(TxtBox1.Text));
        //}
    }
}
