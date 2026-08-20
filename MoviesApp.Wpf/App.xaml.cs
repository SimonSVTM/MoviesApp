
// App.xaml.cs 

using MoviesApp.Core.Repositories;

using MoviesApp.Wpf.ViewModels;

using MoviesApp.Wpf.Views;
using System.Windows;


namespace MoviesApp.Wpf
{

    public partial class App : Application

    {

        protected override void OnStartup(StartupEventArgs e)

        {

            base.OnStartup(e);


            var mainViewModel = new MainViewModel();

            var mainView = new MainView();

            mainView.DataContext = mainViewModel;

            mainView.Show();

        }

    }

}