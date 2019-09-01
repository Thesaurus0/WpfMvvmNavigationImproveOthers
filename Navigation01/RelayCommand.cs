using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation01 {
    public class RelayCommand : ICommand {
        public event EventHandler CanExecuteChanged;

        private Action<object> _execute;
        private Predicate<object> _canExecute;
        public RelayCommand(Action<object> execute) {
            _execute = execute;
            _canExecute = DefaultCanExecute;
        }

        public bool CanExecute(object parameter) {
            return _canExecute(parameter);
        }

        public void Execute(object parameter) {
            _execute(parameter);
        }

        private bool DefaultCanExecute(object param) {
            return true;
        }
    }
}
