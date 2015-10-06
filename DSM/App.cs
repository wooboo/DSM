using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using DSM.Common;

namespace DSM
{
    sealed partial class App : BootStrapper
    {
        public App() : base()
        {
            this.InitializeComponent();
        }

        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            this.NavigationService.Navigate(typeof(Views.MainPage));
            return Task.FromResult<object>(null);
        }

        public override Task OnInitializeAsync()
        {
            // use splitview shell
            Window.Current.Content = new Views.Shell(this.RootFrame);
            return base.OnInitializeAsync();
        }
    }
}
