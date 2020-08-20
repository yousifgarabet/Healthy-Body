using System.ComponentModel;
using System.Runtime.CompilerServices;
using Healthy_Body.Portable.Annotations;

namespace Healthy_Body.Portable.TipsPage
{
    public class Tips: INotifyPropertyChanged
    {
        private string tipstitle;
        private string tipsDetail;
        private string tipsID;
        private bool showDetails;

        public string TipsHeader
        {
            get { return tipstitle; }
            set { tipstitle = value; OnPropertyChanged(); }
        }

        public string TipsDetail
        {
            get { return tipsDetail; }
            set { tipsDetail = value; OnPropertyChanged(); }
        }
        public string TipsID
        {
            get { return tipsID; }
            set { tipsID = value; OnPropertyChanged(); }
        }
        public bool ShowDetails
        {
            get { return showDetails; }
            set { showDetails = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}