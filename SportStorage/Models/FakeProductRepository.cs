using System.Collections.Generic;
using System.Linq;

namespace SportStorage.Models
{
    public class FakeProductRepository: IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product
            {
                Name = "Footbal",
                Price = 23
            },
            new Product()
            {
                Name = "Surf board",
                Price = 179,
            },
            new Product()
            {
                Name = "Running shoes",
                Price = 95
            }
        }.AsQueryable();
    }
}