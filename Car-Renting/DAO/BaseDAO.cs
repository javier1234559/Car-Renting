using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting.DAO
{
    public interface IBaseDAO <T>
    {
        DataTable GetAllDataTable();
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);

    }
}
