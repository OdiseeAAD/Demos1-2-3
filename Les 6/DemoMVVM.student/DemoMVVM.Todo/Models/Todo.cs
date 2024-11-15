using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Todo.Models
{
    internal class Todo: ObservableObject
    {
        private Guid id;
        private string? title;
        private DateTime? dueDate;
        private bool _checked;

        public Todo()
        {
            Id = Guid.NewGuid();
        }
        public Todo(Todo selectedTodo)
        {
            Id = selectedTodo.Id; 
            Title = selectedTodo.Title;
            DueDate = selectedTodo.DueDate;
            Checked = selectedTodo.Checked;
        }

        public Todo(string? title, DateTime? dueDate, bool isChecked)
        {
            Id = Guid.NewGuid();
            Title = title;
            DueDate = dueDate;
            Checked = isChecked;
        }

        public string? Title { get => title; set => SetProperty(ref title, value); }
        public DateTime? DueDate { get => dueDate; set => SetProperty(ref dueDate, value); }
        public bool Checked { get => _checked; set => SetProperty(ref _checked, value); }
        public Guid Id { get => id; set => id = value; }
    }
}
