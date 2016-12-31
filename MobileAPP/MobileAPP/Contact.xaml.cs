using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;

namespace MobileAPP
{
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var emailMessage = CrossMessaging.Current.EmailMessenger;
           
               // emailMessage.SendEmail("info@mstl.us","Contact Us from Mobile","This is message from mobile");

                var email = new EmailMessageBuilder()
                    .To("info@mstl.us")
                    .Subject("Contact Us from mobile")
                    .Body(message.Text)
                    .Build();
                emailMessage.SendEmail(email);



            
        }

    }
}
