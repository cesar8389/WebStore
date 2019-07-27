using StoreWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Business.Interface;
using WebStore.Service.Interface;

namespace WebStore.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductBusiness _productBusiness;

        public ProductService(IProductBusiness carBusiness)
        {
            _productBusiness = carBusiness;
        }
        public IEnumerable<Product> List()
        {
            return _productBusiness.GetList();
        }


        public IEnumerable<Product> Insert(Product product)
        {
            _productBusiness.Add(product);
            return _productBusiness.GetList();
        }

        public List<Product> GetByName(string name)
        {
            return _productBusiness.GetProductByName(name);
        }
    }
}
