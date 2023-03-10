using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting.DAO
{
    interface IBaseDAO <T>
    {
        List<T> GetAllList();
        DataTable GetAllDataTable();
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);

    }
}
