using StoreWeb.Domain.Entities.Abstract;
using System;

namespace StoreWeb.Domain.Entities
{
    public class Costumer:Entity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
