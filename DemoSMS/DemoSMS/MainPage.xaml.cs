using System;
using Plugin.Messaging;
using Xamarin.Forms;

namespace DemoSMS
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Send(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms(Number.Text, Message.Text);
        }
    }
}
