using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class FirstViewModel
    {
        public RelayCommand SecondButtonCommand { get; set; }
        public RelayCommand ThirdButtonCommand { get; set; }

        public FirstViewModel()
        {
            SecondButtonCommand = new RelayCommand(GotoPage2);
            ThirdButtonCommand = new RelayCommand(GotoPage3);
        }

        private void GotoPage3()
        {
        }

        private void GotoPage2()
        {
        }
    }
}
