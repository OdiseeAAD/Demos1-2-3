using Odisee.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.BMI
{
    internal class MainViewModel: INotifyPropertyChanged
    {
        private double bmi;

        // Properties
        public double Gewicht {
            get; 
            set; } 
        public double Lengte { get; set; }
        public double BMI
        {
            get => bmi; 
            set
            {
                bmi = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BMI"));
            }
        }
        public string Title { get; set; } = "BMI CALC";

        // Commands
        public RelayCommand CalculateBMICommand { get; set; }

        public MainViewModel()
        {
            CalculateBMICommand = new RelayCommand(CalculateBMI, CanCalculateBMI);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private bool CanCalculateBMI()
        {
            return Gewicht > 0 && Lengte > 0;
        }

        private void CalculateBMI()
        {
            BMI = Gewicht / (Lengte * Lengte);
        }
    }
}
