using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Todo.ViewModel
{
    internal class MainViewModel
    {
        public TodoListViewModel TodoListViewModel { get; set; } = new TodoListViewModel();
        public TodoDetailViewModel TodoDetailViewModel { get; set; } = new TodoDetailViewModel();

        public string Title { get; set; } = "Todo Application";

        public MainViewModel()
        {
            TodoListViewModel.PropertyChanged += TodoListViewModel_PropertyChanged;
            TodoListViewModel.IsEnabled = true;
        }

        private void TodoListViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    TodoDetailViewModel.IsEnabled = true;
                    TodoListViewModel.IsEnabled = false;
                    break;
            }
        }
    }
}
