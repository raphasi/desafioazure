using ShopTFTEC.WebApp.Models;

namespace ShopTFTEC.WebApp.Services.Contracts;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories(string token);

}
