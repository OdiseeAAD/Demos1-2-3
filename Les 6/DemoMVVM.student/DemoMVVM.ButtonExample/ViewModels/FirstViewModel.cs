using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class FirstViewModel: BaseViewModel
    {
        public RelayCommand SecondButtonCommand { get; set; }
        public RelayCommand ThirdButtonCommand { get; set; }

        public event EventHandler<int> ButtonClicked;

        public FirstViewModel()
        {
            SecondButtonCommand = new RelayCommand(GotoPage2);
            ThirdButtonCommand = new RelayCommand(GotoPage3);
            Title = "First View";
        }

        private void GotoPage3()
        {
            ButtonClicked?.Invoke(this, 3);
        }

        private void GotoPage2()
        {
            ButtonClicked?.Invoke(this, 2);
        }
    }
}
