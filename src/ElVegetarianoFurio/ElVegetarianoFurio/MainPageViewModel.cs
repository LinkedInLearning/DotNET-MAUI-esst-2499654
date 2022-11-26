using CommunityToolkit.Mvvm.ComponentModel;
using ElVegetarianoFurio.Menu;
using System.Collections.ObjectModel;

namespace ElVegetarianoFurio;

[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    private readonly IMenuService _menuService;

    ObservableCollection<Category> Categories { get; } = new ObservableCollection<Category>();

	public MainPageViewModel(IMenuService menuService)
	{
        _menuService = menuService;
    }

    public async Task InitializeAsync()
    {
        Categories.Clear();
        var categories = await _menuService.GetCategoriesAsync();

        foreach (var category in categories)
        {
            Categories.Add(category);
        }
    }
}
