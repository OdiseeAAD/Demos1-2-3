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

            TodoDetailViewModel.PropertyChanged += TodoDetailViewModel_PropertyChanged;
        }

        private void TodoDetailViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    if (TodoDetailViewModel.Status == Enumerations.TodoDetailStatus.ItemCreated)
                    {
                        TodoDetailViewModel.IsEnabled = false;
                        TodoListViewModel.IsEnabled = true;
                        TodoListViewModel.Status = null;
                    }
                    break;
            }
        }

        private void TodoListViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    if (TodoListViewModel.Status == Enumerations.TodoListStatus.Create)
                    {
                        TodoDetailViewModel.IsEnabled = true;
                        TodoListViewModel.IsEnabled = false;
                        TodoDetailViewModel.Status = Enumerations.TodoDetailStatus.Create;
                    }
                    break;
                case "SelectedTodo":
                    TodoDetailViewModel.Title = TodoListViewModel.SelectedTodo?.Title;
                    TodoDetailViewModel.DueDate = TodoListViewModel.SelectedTodo?.DueDate;
                    TodoDetailViewModel.IsChecked = TodoListViewModel.SelectedTodo?.Checked ??  false;
                    break;
;            }
        }
    }
}
