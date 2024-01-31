using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto? Get(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        void Create(ProductDto product);
        void Edit(ProductDto product);
        void Delete(int id);
    }
}
