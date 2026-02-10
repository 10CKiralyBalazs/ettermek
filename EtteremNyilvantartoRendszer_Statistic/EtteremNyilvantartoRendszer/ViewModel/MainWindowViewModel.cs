using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EtteremNyilvantartoRendszer.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly RestaurantViewModel _restaurantViewModel = new RestaurantViewModel();
        private readonly ControlPanelViewModel _controlPanelViewModel = new ControlPanelViewModel();


        [ObservableProperty]
        private object _currentView = new object();
        public MainWindowViewModel()
        {
            CurrentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowRestaurantView()
        {
            CurrentView = _restaurantViewModel;
        }

        [RelayCommand]
        private void ShowControlPanelView()
        {
            CurrentView = _controlPanelViewModel;
        }
    }
}
