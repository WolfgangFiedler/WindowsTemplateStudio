using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Param_ItemNamespace.ViewModels;

namespace Param_ItemNamespace.Views
{
    // TODO WTS: This page exists purely as an example of how to launch a specific page in response to a protocol launch and pass it a value. It is expected that you will delete this page once you have changed the handling of a protocol launch to meet your needs and redirected to another of your pages.
    public sealed partial class UriSchemeExamplePage : Page
    {
        private UriSchemeExampleViewModel ViewModel
        {
            get { return DataContext as UriSchemeExampleViewModel; }
        }

        public UriSchemeExamplePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Capture the passed in value and assign it to a property that's displayed on the view
            this.ViewModel.Secret = e.Parameter.ToString();
        }
    }
}