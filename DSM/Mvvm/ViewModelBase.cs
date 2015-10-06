using System;
using System.Threading.Tasks;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Navigation;
using DSM.Common;
using DSM.Services.NavigationService;
using DSM;

namespace DSM.Mvvm
{
    public abstract class ViewModelBase : BindableBase, INavigatable
    {
        public ViewModelBase()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                this.Dispatch = (App.Current as BootStrapper).Dispatch;
                this.NavigationService = (App.Current as BootStrapper).NavigationService;
            }
        }
        public Action<Action> Dispatch { get; private set; }
        public NavigationService NavigationService { get; private set; }
        public virtual void OnNavigatedTo(string parameter, NavigationMode mode, IPropertySet state) { /* nothing by default */ }
        public virtual Task OnNavigatedFromAsync(IPropertySet state, bool suspending) { return Task.FromResult<object>(null); }
        //public virtual void OnNavigatedFrom(IPropertySet state, bool suspending) { }
        public virtual void OnNavigatingFrom(NavigatingEventArgs args) { /* nothing by default */ }
    
    }
}