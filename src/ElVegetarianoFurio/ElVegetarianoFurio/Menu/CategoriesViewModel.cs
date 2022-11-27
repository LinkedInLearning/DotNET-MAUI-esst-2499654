using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ElVegetarianoFurio.Menu;

[INotifyPropertyChanged]
[QueryProperty("Category", "Category")]
public partial class CategoriesViewModel
{
    private readonly IMenuService _menuService;
    [ObservableProperty]
    private Category _category;

    public CategoriesViewModel(IMenuService menuService)
    {
        _menuService = menuService;
    }


    public ObservableCollection<Dish> Dishes { get;  } = new ObservableCollection<Dish>();

    public async Task InitializeAsync()
    {
        var dishes = await _menuService.GetDishesAsync(Category?.Id);

        Dishes.Clear();
        foreach (var dish in dishes)
        {
            Dishes.Add(dish);
        }
    }

    [RelayCommand]
    private async Task NavigateToDish(Dish dish)
    {
        var navigationParameter = new Dictionary<string, object>
        {
            { "Dish", dish}
        };
        await Shell.Current.GoToAsync(nameof(DishPage), navigationParameter);
    }
}
