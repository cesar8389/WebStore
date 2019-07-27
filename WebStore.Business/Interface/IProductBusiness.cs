using StoreWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Business.Interface
{
    public interface IProductBusiness
    {
        bool Add(Product product);

        List<Product> GetProductByName(string name);
        IEnumerable<Product> GetList();
    }
}
