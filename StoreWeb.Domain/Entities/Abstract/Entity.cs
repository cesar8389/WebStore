using StoreWeb.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreWeb.Domain.Entities.Abstract
{
    public abstract class Entity : IEntity
    {
        public Guid Key { get; }
        public int Id { get; set; }

        protected Entity()
        {
            Key = Guid.NewGuid();
        }
    }
}
