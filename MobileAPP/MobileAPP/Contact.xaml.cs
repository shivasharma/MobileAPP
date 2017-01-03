using System;
using Plugin.Messaging;
using Xamarin.Forms;

namespace MSTL
{
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            //var message = new MimeMessage();

            // message.From.Add (new MailboxAddress (name.Text, email.Text));
            //message.To.Add (new MailboxAddress ("MSTL", "info@mstl.us"));
            //message.Subject = "Email from MSLT mobile APP?";

            //message.Body = new TextPart("plain")
            //{
            //    Text = message.TextBody

            //};
            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.google.com", 587, false);

            //    // Note: since we don't have an OAuth2 token, disable
            //    // the XOAUTH2 authentication mechanism.
            //    client.AuthenticationMechanisms.Remove("XOAUTH2");

            //    // Note: only needed if the SMTP server requires authentication
            //    client.Authenticate("joey", "password");

            //    client.Send(message);
            //    client.Disconnect(true);
            //}
            // var emailMessage = CrossMessaging.Current.EmailMessenger;


            try
            {
                var emailTask = MessagingPlugin.EmailMessenger;
                var email = new EmailMessageBuilder()
                    .To("info@mstl.us")
                    .Subject("Contact Us from mobile")
                    .Body(message.Text)
                    .Build();
                emailTask.SendEmail(email);
            }

            catch (Exception ex)
            {
            }
        }
    }
}