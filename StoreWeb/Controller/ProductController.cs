using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Service;
using WebStore.Service.Interface;

namespace WebStore.Controller
{
        [Route("api/v1/product/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            private readonly IProductService _productServices;
            private readonly ILogger<ProductController> _logger;
            public ProductController(ProductService productServices, ILogger<ProductController> logger)
            {
                _productServices = productServices;
                _logger = logger;
            }
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_productServices.List());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
    }
