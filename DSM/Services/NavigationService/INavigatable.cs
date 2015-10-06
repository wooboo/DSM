using System.Threading.Tasks;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Navigation;

namespace DSM.Services.NavigationService
{
    public interface INavigatable
    {
        void OnNavigatedTo(string parameter, NavigationMode mode, IPropertySet state);
        //void OnNavigatedFrom(Dictionary<string, object> state, bool suspending);
        void OnNavigatingFrom(NavigatingEventArgs args);
        Task OnNavigatedFromAsync(IPropertySet state, bool suspending);
    }
}
