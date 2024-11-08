using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDemo
{
    internal class RelayCommand : ICommand
    {

        Func<bool> _canExecute;
        Action _execute;

        public RelayCommand(Action execute, Func<bool> canExecute = null )
        {
            _canExecute = canExecute ?? (() => execute!=null);
            _execute = execute;
        }

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
               CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute();
        }

        public void Execute(object? parameter)
        {
            _execute();
        }
    }
}
