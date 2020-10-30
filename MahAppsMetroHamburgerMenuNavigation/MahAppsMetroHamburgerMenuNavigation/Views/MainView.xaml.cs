using System;
using System.Windows.Controls;

namespace MahAppsMetroHamburgerMenuNavigation.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            Console.WriteLine("Creating MainView");
            InitializeComponent();
            Unloaded += MainView_Unloaded;
            MainWindow.NavigationServiceEx.Navigated += NavigationServiceEx_Navigated;

        }

        private void NavigationServiceEx_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            Console.WriteLine($"Navigating to {e.Content}");
        }

        private void MainView_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Console.WriteLine("Unloading MainView");
        }
    }
}
