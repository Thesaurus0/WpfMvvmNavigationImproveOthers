using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation01.ViewModel {
    public class MainViewModel: ViewModelBase {
        public MainViewModel() {
            LogInCommand = new RelayCommand(LogInExecute);
        }

        private ViewModelBase _currentViewModelBase;

        public ViewModelBase CurrentViewModel {
            get {
                return _currentViewModelBase;
            }
            set {
                if (_currentViewModelBase != value) {
                    _currentViewModelBase = value;
                    OnPropertyChanged();
                }
            }
        }

        //public ViewModelBase CurrentViewModel { get; set; }

        private void LogInExecute(object obj) {
            CurrentViewModel = new LogInViewModel(this);
        }

        public ICommand LogInCommand { get; set; }


    }
}
