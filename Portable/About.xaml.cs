using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using System.ComponentModel;
using System.Linq;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace Healthy_Body.Portable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : PopupPage
    {
        public About()
        {
            InitializeComponent();
        }

        private async void BtnSendEmail_OnClicked(object sender, EventArgs e)
        {
            // await Email.ComposeAsync("Email Title", "Write your message here", "yousifgarabet@gmail.com");
            var subject = "Email Title";
            var body = "Write your message here";
            List<string> recipients = new List<string>();
            recipients.Add("yousifgarabet@gmail.com");

            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }
            catch (Exception ex)
            {
                // Some other exception occurred
            }
        }

        private void BtnOK_OnClicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);

        }
    }
}