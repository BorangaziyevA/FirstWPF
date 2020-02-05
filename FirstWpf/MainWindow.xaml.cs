using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Mail;
using System.Net;

namespace FirstWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSendMail_Click(object sender,RoutedEventArgs e)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("alish_b@mail.ru");
            msg.Body = TxtBox1.Text;
            msg.Subject = TxtBox2.Text;
            msg.To.Add(new MailAddress(TxtBox1.Text));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            //smtp.EnableSsl = true;
            smtp.DeliveryMethod
                = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(
                "alish3383@gmail.com",
                "alish0405");

            try
            {
                smtp.Send(msg);
                lblMessage.Content = "Письмо успешно отправлено";
                lblMessage.Foreground = new SolidColorBrush(Colors.Green);
            }
            catch(Exception ex)
            {
                lblMessage.Content = "Ошибка, письмо не отправлено. Причина:" + ex.Message;
                lblMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
            //msg.To = new MailAddressCollection().Add(new MailAddress(TxtBox1.Text));
        }
    }
}
