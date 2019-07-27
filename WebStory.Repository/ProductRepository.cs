using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StoreWeb.Domain.Entities;
using WebStory.Repository.Base;

namespace WebStory.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(IConfiguration config) : base(config)
        {
        }

        public List<Product> GetProductByName(string name)
        {
            return _list.FindAll(x => x.Name == name);
        }
    }   
}
