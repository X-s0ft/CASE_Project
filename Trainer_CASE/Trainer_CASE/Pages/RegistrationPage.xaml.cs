using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using System.Net.Mime;


namespace Trainer_CASE.Resourses.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.mail.ru");
                smtpClient.UseDefaultCredentials = true;
                smtpClient.EnableSsl = false;

                System.Net.NetworkCredential basicauto = new System.Net.NetworkCredential("DriftHakerNinja@mail.ru", "davaking48372337"); 
                smtpClient.Credentials = basicauto;

                MailAddress from = new MailAddress("DriftHakerNinja@mail.ru", "Тренеруйся");
                MailAddress to = new MailAddress("DriftHakerNinja@mail.ru", "Новому пользователю");
                MailMessage mail = new MailMessage(from, to);

                MailAddress mailAddress = new MailAddress("DriftHakerNinja@mail.ru"); 
                mail.ReplyToList.Add(mailAddress);

                mail.Subject = "Ваш код 1234";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                mail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
                mail.BodyEncoding = System.Text.Encoding.UTF8;

                mail.IsBodyHtml = true;

                smtpClient.Send(mail);
            }
            catch(SmtpException ex)
            {
                throw new ApplicationException("SmtpException has occured: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
