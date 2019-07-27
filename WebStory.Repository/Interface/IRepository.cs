using StoreWeb.Domain.Entities;
using StoreWeb.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebStory.Repository.Interface
{
    public interface IRepository<T>
    {
        bool Add(T obj);
        IEnumerable<T> List();
    }
}
