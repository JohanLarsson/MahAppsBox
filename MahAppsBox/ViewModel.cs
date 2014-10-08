namespace MahAppsBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class ViewModel : INotifyPropertyChanged
    {
        private bool _boolValue;
        private double _doubleValue;
        public event PropertyChangedEventHandler PropertyChanged;

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

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
