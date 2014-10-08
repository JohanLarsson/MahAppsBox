using System.Windows.Input;

namespace MahAppsBox.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class MainWindowViewModel : ViewModelBase
    {
        private IDialogService _dialogService;
        private bool _boolValue;
        private double _doubleValue;

        public bool BoolValue
        {
            get { return _boolValue; }
            set
            {
                if (value.Equals(_boolValue))
                {
                    return;
                }
                _boolValue = value;
                OnPropertyChanged();
            }
        }

        public double DoubleValue
        {
            get { return _doubleValue; }
            set
            {
                if (value.Equals(_doubleValue))
                {
                    return;
                }
                _doubleValue = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowSimpleMessageDialogCommand { get; private set; }

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            ShowSimpleMessageDialogCommand = new RelayCommand(ShowSimpleMessageDialog);
        }

        private async void ShowSimpleMessageDialog(object parameter)
        {
            await _dialogService.ShowMessageDialog("Hello I am a simple message dialog!");
        }
    }
}
