using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation01.ViewModel {
    public class ThirdViewModel:ViewModelBase {

        private MainViewModel _main;
        public ThirdViewModel(MainViewModel main) {
            this._main = main;
            GobackCommand = new RelayCommand(GobackExecute);
        }

        private void GobackExecute(object obj) {
            _main.CurrentViewModel = new LogInViewModel(_main);
        }

        public ICommand GobackCommand { get; set; }
    }
}
