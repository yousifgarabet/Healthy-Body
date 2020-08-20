using System.Net.Mime;
using Xamarin.Forms;

namespace Healthy_Body.Portable
{
    public class SplashScreen : ContentPage
    {
        private Image splashImage;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image()
            {
                Source = "Splash.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.Azure;
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //splashImage.Opacity = 0;
            await splashImage.ScaleTo(1, 1000, Easing.Linear); // time consuming
            await splashImage.ScaleTo(2, 1000, Easing.Linear);
            await splashImage.ScaleTo(4, 1200, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}