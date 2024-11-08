using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Todo.Repositories
{
    static class TodoRepository
    {

        static ObservableCollection<Models.Todo> todos = new ObservableCollection<Models.Todo>();
        public static void Add(Models.Todo todo)
        {
            todos.Add(todo);
        }

        public static void Remove(Models.Todo todo)
        {
            todos.Remove(todo);
        }

        public static void Update(Models.Todo todo)
        {
            Models.Todo toUpdate = todos.First(item => item.Id == todo.Id);
            toUpdate.Title = todo.Title;
            toUpdate.DueDate = todo.DueDate;
            toUpdate.Checked = todo.Checked;
        }

        public static ObservableCollection<Models.Todo> GetAll()
        {
            return todos;
        }
    }
}
