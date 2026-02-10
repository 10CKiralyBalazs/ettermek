using CommunityToolkit.Mvvm.ComponentModel;
using EtteremNyilvantartoRendszer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteremNyilvantartoRendszer.ViewModel
{
    public partial class ControlPanelViewModel : ObservableObject
    {
        private readonly RestaurantRepo _repo = new RestaurantRepo();

        [ObservableProperty]
        private int _numberofRestaurants;

        [ObservableProperty]
        private int _totalIncome;

        [ObservableProperty]
        private double _averageIncome;

        public ControlPanelViewModel()
        {
            NumberofRestaurants = _repo.Count();
            TotalIncome = _repo.GetTotalIncome();
            AverageIncome = _repo.GetAverageIncome();
        }       
    }
}
