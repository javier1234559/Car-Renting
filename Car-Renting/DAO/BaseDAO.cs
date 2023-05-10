using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting.DAO
{
    public abstract class BaseDAO<T>
    {
        public abstract DataTable GetAllDataTable();
        public abstract T GetById(int id);
        public abstract int Insert(T entity);
        public abstract int Update(T entity);
        public abstract int Delete(T entity);
    }

}
