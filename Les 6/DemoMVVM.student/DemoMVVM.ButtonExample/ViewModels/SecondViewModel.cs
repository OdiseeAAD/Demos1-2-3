using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class SecondViewModel: BaseViewModel
    {
        public RelayCommand FirstButtonCommand { get; set; }
        public RelayCommand ThirdButtonCommand { get; set; }

        public event EventHandler<int> ButtonClicked;

        public SecondViewModel()
        {
            FirstButtonCommand = new RelayCommand(GotoPage1);
            Title = "Second View";
            ThirdButtonCommand = new RelayCommand(GotoPage3);
        }

        private void GotoPage3()
        {
            ButtonClicked?.Invoke(this, 3);
        }

        private void GotoPage1()
        {
            ButtonClicked?.Invoke(this, 1);
        }
    }
}
