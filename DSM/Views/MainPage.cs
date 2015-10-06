using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DSM.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            _webView.ContentLoading += _webView_ContentLoading;
            _webView.DOMContentLoaded += _webView_DOMContentLoaded;
            _webView.LoadCompleted += _webView_LoadCompleted;
            _webView.NavigationCompleted += _webView_NavigationCompleted;
            _webView.NavigationStarting += _webView_NavigationStarting;
            _webView.NavigationFailed += _webView_NavigationFailed;
            
        }

        private void _webView_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
        }

        private void _webView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
        }

        private void _webView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
        }

        private void _webView_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _webView.Navigate(new Uri("http://pz.myds.me:5000"));
            //_webView.Navigate(new Uri("http://www.facebook.com"));
        }

        private void _webView_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
        }

        private void _webView_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            
        }


    }
}
