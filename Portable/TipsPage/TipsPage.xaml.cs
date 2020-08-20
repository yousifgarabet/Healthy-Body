using Com.Telerik.Widget.List;
using System.Collections;
using System.Collections.Generic;
using Telerik.XamarinForms.Chart;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace Healthy_Body.Portable.TipsPage
{
    public partial class TipsPage : ContentPage
    {
        private IList<Tips> tipses;
        GetTipses getTipses = new GetTipses();

        public TipsPage(string tipsType)
        {
            InitializeComponent();
            if (tipsType.Contains("gain"))
            {
                FadeItemAnimator fadeItemAnimator = new FadeItemAnimator();
                fadeItemAnimator.Type = ListViewItemAnimator.Add;
                listView.ItemsSource = getTipses.GetKeepTipses();
               
                this.Title = "Tips to gain weight";

            }
            else if (tipsType.Contains("keep"))
            {
                ScaleItemAnimator scaleItemAnimator = new ScaleItemAnimator();
                scaleItemAnimator.Type = ListViewItemAnimator.Add;
                listView.ItemsSource = getTipses.GetKeepTipses();
                this.Title = "Tips to keep weight";

            }
            else if (tipsType.Contains("lose"))
            {
                listView.ItemsSource = getTipses.GetLoseTipses();
                FadeItemAnimator fadeItemAnimator = new FadeItemAnimator();
                fadeItemAnimator.Type = ListViewItemAnimator.Add;
                this.Title = "Tips to lose weight";

            }


        }

        private void ListView_OnItemTapped(object sender, ItemTapEventArgs e)
        {
            var book = e.Item as Tips;

            if (book == null)
                return;

            // Simply toggle the flag to show or hide content and effectively expand and collapse the cell area
            // This happens because of <StackLayout IsVisible="{Binding ShowDetails}"... >
            book.ShowDetails = !book.ShowDetails;

        }
    }
}
