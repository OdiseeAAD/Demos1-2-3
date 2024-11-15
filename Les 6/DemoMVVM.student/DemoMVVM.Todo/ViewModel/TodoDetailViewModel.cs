using DemoMVVM.Todo.Enumerations;
using DemoMVVM.Todo.Repositories;
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
        private TodoDetailStatus status;
        private string title;
        private DateTime? dueDate;
        private bool isChecked;

        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }

        public string Title { get => title; set => SetProperty(ref title, value); }
        public DateTime? DueDate { get => dueDate; set => SetProperty(ref dueDate, value); }
        public bool IsChecked { get => isChecked; set => SetProperty(ref isChecked, value); }
        public TodoDetailStatus Status { get => status; set => SetProperty(ref status, value); }


        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }

        public TodoDetailViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
            CancelCommand = new RelayCommand(Cancel);
        }

        private void Cancel()
        {
            throw new NotImplementedException();
        }

        private bool CanSave()
        {
            return !String.IsNullOrEmpty(Title) && (DueDate== null || DueDate >  DateTime.Today);
        }

        private void Save()
        {
            Models.Todo todo = new Models.Todo(Title, DueDate, IsChecked);
            TodoRepository.Add(todo);
            Status = TodoDetailStatus.ItemCreated;
        }
    }
}
