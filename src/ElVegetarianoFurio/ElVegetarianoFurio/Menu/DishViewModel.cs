using CommunityToolkit.Mvvm.ComponentModel;

namespace ElVegetarianoFurio.Menu
{
    [INotifyPropertyChanged]
    [QueryProperty("Dish", "Dish")]
    public partial class DishViewModel
    {
        [ObservableProperty]
        private Dish _dish;
    }
}
