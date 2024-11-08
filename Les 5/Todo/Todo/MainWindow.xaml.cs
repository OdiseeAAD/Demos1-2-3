using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string TodoTitle
        {
            get;
            set;
        }

        public string TodoDescription { get; set; }

        public DateTime TodoDueDate { get; set; } = DateTime.Now;

        public ObservableCollection<Todo> TodoItems { get; set; } = new ObservableCollection<Todo>();

        public ICommand SaveTodo { get; set; }

        public MainWindow()
        {
            DataContext = this;
            SaveTodo = new RelayCommand(Save, CheckSave);
        }

        private void Save()
        {
            Todo newTodo = new Todo(TodoTitle, TodoDescription, TodoDueDate);
            TodoItems.Add(newTodo);
        }

        private bool CheckSave()
        {
            return !string.IsNullOrEmpty(TodoTitle) && !string.IsNullOrEmpty(TodoDescription);

        }
    }
}