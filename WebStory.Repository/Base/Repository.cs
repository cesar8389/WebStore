using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using WebStory.Repository.Utility;
using WebStory.Repository.Interface;

namespace WebStory.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public static List<T> _list { get; set; }
        public static object _syncObj = new object();
        private readonly IConfiguration _config;

        public Repository(IConfiguration config)
        {
            if (_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }
            _config = config;
        }

        public bool Add(T obj)
        {
            using (var conn = ConnectionFactory.GetConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var result = conn.Insert<T>(obj);
            }
            return true;
        }

        public IEnumerable<T> List()
        {
            using (var conn = ConnectionFactory.GetConnection(_config.GetConnectionString("DefaultConnection")))
            {
                return conn.GetAll<T>();
            }
        }
    }

}
