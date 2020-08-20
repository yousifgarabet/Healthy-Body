using System;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Healthy_Body.Portable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void BtnTips_OnClicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new TipsPage.TipsPage(btnTips.Text), true);
        }

        private void AboutToolBarItem_OnClicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new About(),true);
            // DisplayAlert("About Yousif", "Teacher at UoZ, iOS & Android Developer, Web developer", "OK");
        }
    }
}
