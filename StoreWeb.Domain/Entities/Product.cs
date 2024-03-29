﻿using StoreWeb.Domain.Entities.Abstract;
using StoreWeb.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreWeb.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Guid Key { get;}
        public int Id { get; set; }
        public Product()
        {
            Key = Guid.NewGuid();
        }
    }
}
