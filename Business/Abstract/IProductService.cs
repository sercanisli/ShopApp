using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Update(Product product);
        void Delete(int productId);
        void Add(Product product);
        Product GetById(int productId);
    }
}
