using System.Linq;

namespace SportStorage.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}