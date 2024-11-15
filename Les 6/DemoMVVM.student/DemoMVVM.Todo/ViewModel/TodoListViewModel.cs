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
        private Models.Todo? selectedTodo;

        public RelayCommand CreateCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public TodoListStatus? Status { get => status; set => SetProperty(ref status, value); }
        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }
        public ObservableCollection<Models.Todo> Todos { get; set; }
        public Models.Todo? SelectedTodo { get => selectedTodo; set => SetProperty(ref selectedTodo, value); }

        public TodoListViewModel()
        {
            CreateCommand = new RelayCommand(CreateClicked);
            EditCommand = new RelayCommand(Edit, CanEdit);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
            Todos = TodoRepository.GetAll();
        }

        private bool CanDelete()
        {
            return SelectedTodo != null;
        }

        private void Delete()
        {
            TodoRepository.Remove(SelectedTodo);
        }

        private bool CanEdit()
        {
            return SelectedTodo != null;
        }

        private void Edit()
        {
            Status = TodoListStatus.Edit;
        }

        private void CreateClicked()
        {
            Status = TodoListStatus.Create; 
        }
    }
}
