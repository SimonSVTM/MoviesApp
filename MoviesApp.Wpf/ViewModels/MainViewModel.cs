using System.ComponentModel;

using System.Windows.Input;

using MoviesApp.Core.Repositories;


namespace MoviesApp.Wpf.ViewModels

{

    public class MainViewModel : ViewModelBase

    {

        // De to ViewModels — oprettes én gang og genbruges

        public MovieViewModel MovieVM { get; }



        // Den ViewModel der aktuelt vises i ContentControl

        private object _currentViewModel;

        public object CurrentViewModel

        {

            get => _currentViewModel;

            set
            {
                _currentViewModel = value;

                OnPropertyChanged(nameof(CurrentViewModel));
            }

        }


        // Navigationskommandoer

        public ICommand ShowCarsCommand { get; }

        public ICommand ShowTripsCommand { get; }


        public MainViewModel()

        {

            MovieVM = new MovieViewModel();



            // Start med biler som standardvisning

            CurrentViewModel = MovieVM;


            ShowCarsCommand = new RelayCommand(_ => CurrentViewModel = MovieVM);

            

        }


        
    }

}