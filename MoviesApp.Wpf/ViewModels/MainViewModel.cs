using System.ComponentModel;

using System.Windows.Input;

using MoviesApp.Core.Repositories;


namespace MoviesApp.Wpf.ViewModels

{

    public class MainViewModel : INotifyPropertyChanged

    {

        // De to ViewModels — oprettes én gang og genbruges

        public FilmViewModel FilmVM { get; }



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

            FilmVM = new FilmViewModel();



            // Start med biler som standardvisning

            CurrentViewModel = FilmVM;


            ShowCarsCommand = new RelayCommand(_ => CurrentViewModel = FilmVM);

            

        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name) =>

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }

}