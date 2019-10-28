using System.Linq;

namespace SportStorage.Models
{
    public class EfProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _ctx;

        public EfProductRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Product> Products => _ctx.Products;
    }
}