using System.ComponentModel;
using System.Runtime.CompilerServices;
using DSM.Common;
using DSM;

namespace DSM.Mvvm
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                return;
            (App.Current as BootStrapper).Dispatch(() =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            });
        }

        public void Set<T>(ref T storage, T value, [CallerMemberName()]string propertyName = null)
        {
            if (!object.Equals(storage, value))
            {
                storage = value;
                RaisePropertyChanged(propertyName);
            }
        }
    }
}
