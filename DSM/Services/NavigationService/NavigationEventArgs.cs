using System;
using Windows.UI.Xaml.Navigation;

namespace DSM.Services.NavigationService
{
    public class NavigationEventArgs : EventArgs
    {
        public NavigationMode NavigationMode { get; set; }

        public string Parameter { get; set; }
        public Type SourcePageType { get; set; }
    }
}
