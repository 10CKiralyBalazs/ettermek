using CommunityToolkit.Mvvm.ComponentModel;
using EtteremNyilvantartoRendszer.Model;
using EtteremNyilvantartoRendszer.Repo;
using System.Collections.ObjectModel;

namespace EtteremNyilvantartoRendszer.ViewModel
{
    public partial class RestaurantViewModel : ObservableObject
    {
        private readonly RestaurantRepo _repo = new RestaurantRepo();
        public ObservableCollection<Restaurant> Restaurants { get; }

        public RestaurantViewModel()
        {
            Restaurants = new ObservableCollection<Restaurant>(_repo.GetAll());
        }
    }
}
