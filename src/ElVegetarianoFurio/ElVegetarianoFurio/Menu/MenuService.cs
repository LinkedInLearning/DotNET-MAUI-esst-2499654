using System.Text.Json;

namespace ElVegetarianoFurio.Menu;

public class MenuService : IMenuService
{
    private Menu _menu;

    private async Task<Menu> GetMenuAsync()
    {

        if (_menu is not null)
        {
            return _menu;
        }

        using var stream = await FileSystem.OpenAppPackageFileAsync("db.json");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        _menu = JsonSerializer.Deserialize<Menu>(stream, options);

        return _menu;
    }

    public async Task<List<Category>> GetCategoriesAsync()
    {
        var menu = await GetMenuAsync();
        return menu.Categories;
    }

    public async Task<List<Dish>> GetDishesAsync(int? categoryId = null)
    {
        var menu = await GetMenuAsync();
        if (categoryId.HasValue)
        {
            return menu.Dishes.Where(d => d.CategoryId == categoryId).ToList();
        }
        return menu.Dishes;
    }

    public async Task<Dish> GetDishAsync(int id)
    {
        var menu = await GetMenuAsync();
        return menu.Dishes.SingleOrDefault(d => d.Id == id);
    }

    private record Menu
    {
        public List<Category> Categories { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
