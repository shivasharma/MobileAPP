using System;
using MSTL.Model;
using MSTL.Services;
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

        public ContactInfo contactinfo { get; set; } = new ContactInfo();

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var name = Ename.Text;
            var email = Eemail.Text;
            var message = Emessage.Text;


            if (name == null || email == null || message == null)
            {
                await DisplayAlert("Message", "Please enter name, email and messsage.", "OK");
            }
            else
            {
                contactinfo.Name = name;
                contactinfo.Email = email;
                contactinfo.Message = message;

                var contact = new AppService();

                var status = await contact.SendEmail(contactinfo);

                if (status == "message sent")
                {
                    await DisplayAlert("Alert", "Message Sent Successfully.", "OK");
                }
                else
                {
                    await DisplayAlert("Alert", "Message Failed. Please Try Again Later", "OK");
                    Ename.Text = string.Empty;
                    Eemail.Text = string.Empty;
                    Emessage.Text = string.Empty;
                }
            }
        }
    }
}
