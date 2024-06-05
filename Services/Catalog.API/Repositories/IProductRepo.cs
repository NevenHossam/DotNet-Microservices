using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
	public interface IProductRepo
	{
		Task<Product> GetProductById(string id);
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByCategory(string category);
		Task<IEnumerable<Product>> GetProducts();

		Task CreateProduct(Product product);
		Task<bool> UpdateProduct(Product product);
		Task<bool> DeleteProduct(string id);
    }
}

