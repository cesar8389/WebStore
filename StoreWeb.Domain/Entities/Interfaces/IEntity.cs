using System;
using System.Collections.Generic;
using System.Text;

namespace StoreWeb.Domain.Entities.Interfaces
{
    public interface IEntity
    {
        Guid Key { get; }
        int Id { get; set; }
    }
}
