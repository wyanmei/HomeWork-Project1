using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Interface
{

    public interface IDbHelper
    {
        T Find<T>(int id) where T : BaseModel;

        List<T> Get<T>() where T : BaseModel;

        int Insert<T>(T entity) where T : BaseModel;

        bool Update<T>(T entity) where T : BaseModel;

        bool Delete<T>(T entity) where T : BaseModel;
    }
}
