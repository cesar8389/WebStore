using StoreWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Service.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> List();

        IEnumerable<Product> Insert(Product product);

        List<Product> GetByName(string marca);
    }
}
