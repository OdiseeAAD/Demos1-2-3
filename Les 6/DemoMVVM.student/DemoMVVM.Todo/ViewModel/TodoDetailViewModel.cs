using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Todo.ViewModel
{
    internal class TodoDetailViewModel: ObservableObject
    {
        private bool isEnabled = false;

        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }
    }
}
