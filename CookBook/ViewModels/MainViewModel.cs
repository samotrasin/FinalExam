using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CookBook.Models;

namespace CookBook.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        [ObservableProperty]
        private string title="";

        private CuisineList cuisineList = new CuisineList();

        [ObservableProperty]
        private ObservableCollection<Cuisine> cuisines;

        [ObservableProperty]
        private Cuisine selectedCuisine;
        public MainViewModel()
        {
            Title = "CookBook";
            cuisines = new ObservableCollection<Cuisine>(cuisineList.Cuisines);
            SelectedCuisine = selectedCuisine;
        }
    }
}
