namespace ElVegetarianoFurio.Menu
{
    public interface IMenuService
    {
        Task<List<Category>> GetCategoriesAsync();
        Task<Dish> GetDishAsync(int id);
        Task<List<Dish>> GetDishesAsync(int? categoryId = null);
    }
}