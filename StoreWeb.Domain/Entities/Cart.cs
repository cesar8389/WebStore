using StoreWeb.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreWeb.Domain.Entities
{
    public class Cart:Entity
    {
        public int Id_Costumer { get; set; }
        public int Id_Product { get; set; }
        public int Quantity { get; set; }
        public String Status { get; set; }
        public DateTime Created_At { get; set; }
    }
}
