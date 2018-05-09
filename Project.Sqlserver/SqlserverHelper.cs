using Project.Framework;
using Project.Interface;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Sqlserver
{
    public class SqlserverHelper : IDbHelper
    {
        public bool Delete<T>(T entity) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public T Find<T>(int id) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public int Insert<T>(T entity) where T :BaseModel
        {
            throw new NotImplementedException();
        }

        public List<T> Get<T>() where T :BaseModel
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T entity) where T :BaseModel
        {
            throw new NotImplementedException();
        }
    }
}
