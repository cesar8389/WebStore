using StoreWeb.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreWeb.Domain.Entities
{
    public class Store:Entity
    {
        public string Token { get; set; }
        public string Cnpj { get; set; }
        public string Razao_Social { get; set; }
    }
}
