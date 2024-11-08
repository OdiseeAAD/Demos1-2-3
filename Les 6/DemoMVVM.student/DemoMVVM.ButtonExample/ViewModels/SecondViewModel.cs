using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class SecondViewModel
    {
        public RelayCommand FirstButtonCommand { get; set; }
        public RelayCommand ThirdButtonCommand { get; set; }

        public SecondViewModel()
        {
            FirstButtonCommand = new RelayCommand(GotoPage1);
            ThirdButtonCommand = new RelayCommand(GotoPage3);
        }

        private void GotoPage3()
        {
        }

        private void GotoPage1()
        {
        }
    }
}
