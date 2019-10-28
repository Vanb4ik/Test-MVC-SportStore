using System.Collections.Generic;

namespace SportStorage.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}