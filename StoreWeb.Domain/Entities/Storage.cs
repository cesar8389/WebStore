using StoreWeb.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreWeb.Domain.Entities
{
    public class Storage:Entity
    {
        public int Id_product { get; set; }
        public int quantity { get; set; }
        public int qnt_reserved { get; set; }
    }
}
