using StoreWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using WebStore.Business.Interface;
using WebStory.Repository.Interface;

namespace WebStore.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private IRepository<Product> _productRepository;
        public ProductBusiness(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public bool Add(Product product)
        {
            _productRepository.Add(product);
            return true;

        }

        public IEnumerable<Product> GetList()
        {
            return _productRepository.List();
        }

        public List<Product> GetProductByName(string name)
        {
            return null;
        }
    }
}
