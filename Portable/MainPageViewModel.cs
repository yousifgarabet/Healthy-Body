using System;
using System.ComponentModel;

namespace Healthy_Body.Portable
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private double height = 180;
        private double weight = 72;
        private double gauge = 18;
        private const double STEP = 1.0;

        public double Height
        {
            get => height;
            set
            {
                height = NextStep(value);
                UpdateResults();
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                weight = NextStep(value);
                UpdateResults();
            }
        }

        public double Bmi
            => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);
        public string Classification
        {
            get
            {
                if (Bmi < 18.5)
                    return "You are underweight";
                else if (Bmi < 25)
                    return "You have a normal weight";
                else if (Bmi < 30)
                    return "You are overweight";
                else
                    return "You are obese";
            }
        }
        public string Tips
        {
            get
            {
                if (Bmi < 18.5)
                    return "Tips to gain weight";
                else if (Bmi < 25)
                    return "Tips to keep weight";
                else if (Bmi < 30)
                    return "Tips to lose weight";
                else
                    return "Tips to lose weight";
            }
        }

        public double Gauge
        {
            get
            {
                if (Bmi > 40)
                {
                    gauge = 40;
                }
                else
                {
                    gauge = Bmi;
                }

                return gauge;
            }
        }
        private void UpdateResults()
        {
            RaisePropertyChanged(nameof(Tips));
            RaisePropertyChanged(nameof(Gauge));
            RaisePropertyChanged(nameof(Bmi));
            RaisePropertyChanged(nameof(Classification));
        }

        private double NextStep(double value)
            => Math.Round(value / STEP) * STEP;

        private void RaisePropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}