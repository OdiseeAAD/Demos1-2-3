using DemoMVVM.Todo.Enumerations;
using DemoMVVM.Todo.Repositories;
using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Todo.ViewModel
{
    internal class TodoListViewModel:ObservableObject
    {
        private TodoListStatus? status;
        private bool isEnabled;

        public RelayCommand CreateCommand { get; set; }
        public TodoListStatus? Status { get => status; set => SetProperty(ref status, value); }
        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }
        public ObservableCollection<Models.Todo> Todos { get; set; }

        public TodoListViewModel()
        {
            CreateCommand = new RelayCommand(CreateClicked);
            Todos = TodoRepository.GetAll();
        }

        private void CreateClicked()
        {
            Status = TodoListStatus.Create; 
        }
    }
}
