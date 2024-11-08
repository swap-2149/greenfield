using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public interface IProductService
    {
        bool Insert(Product p);
        bool Update(Product p);
        bool Delete(Product p);
        List<Product> GetAll();
        Product GetById(int id); 
    }
}
