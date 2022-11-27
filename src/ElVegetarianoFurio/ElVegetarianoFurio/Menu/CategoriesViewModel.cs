using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ElVegetarianoFurio.Menu;

[INotifyPropertyChanged]
[QueryProperty("Category", "Category")]
public partial class CategoriesViewModel
{
    [ObservableProperty]
    private Category _category;

    public ObservableCollection<Dish> Dishes { get;  } = new ObservableCollection<Dish>();

    public async Task InitializeAsync()
    {
        // TODO: Liste der Speisen laden
    }
}
