using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation01.ViewModel {
    public class LogInViewModel: ViewModelBase {

        private MainViewModel _mainViewModel;
        public LogInViewModel(MainViewModel mainViewModel) {
            _mainViewModel = mainViewModel;

            To3rdCommand = new RelayCommand(To3rdExecute);
        }

        private void To3rdExecute(object obj) {
            _mainViewModel.CurrentViewModel = new ThirdViewModel(_mainViewModel);
        }

        public ICommand To3rdCommand { get; set; }
    }
}
