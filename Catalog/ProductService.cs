using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class ProductService : IProductService
    {
        List<Product> _productList;
        public ProductService() { 
            _productList = new List<Product>();
        }
        public bool Delete(Product product)
        {
            foreach(Product p in _productList)
            {
                if(product.Id == p.Id)
                {
                    return _productList.Remove(p);
                }
            }
            return false;
        }

        public List<Product> GetAll()
        {
            return _productList;
        }

        public Product GetById(int id)
        {
            foreach(Product p in _productList)
            {
                if(p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }

        public bool Insert(Product p)
        {
            _productList.Add(p);
            return true;
        }

        public bool Update(Product product)
        {   
            foreach(Product p in _productList)
            {
                if (product.Id == p.Id)
                {
                    _productList.Remove(p);
                }
            }
            _productList.Add(product);
            return true;
        }
    }
}
