using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class MainViewModel: BaseViewModel
    {
        private BaseViewModel currentViewModel;

        private FirstViewModel firstViewModel = new FirstViewModel();
        private SecondViewModel secondViewModel = new SecondViewModel();
        private ThirdViewModel thirdViewModel = new ThirdViewModel();

        public BaseViewModel CurrentViewModel { get => currentViewModel; set => SetProperty(ref currentViewModel, value); }

        public MainViewModel()
        {
            CurrentViewModel = firstViewModel;

            firstViewModel.ButtonClicked += ButtonClicked;
            secondViewModel.ButtonClicked += ButtonClicked;
            thirdViewModel.ButtonClicked += ButtonClicked;
        }

        private void ButtonClicked(object? sender, int e)
        {
            switch (e)
            {
                case 1:
                    CurrentViewModel = firstViewModel;
                    break;
                case 2:
                    CurrentViewModel = secondViewModel;
                    break;
                case 3:
                    CurrentViewModel = thirdViewModel;
                    break;
            }
        }
    }
}
