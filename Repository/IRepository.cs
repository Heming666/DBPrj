using Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        Task<int> ExecuteNonQuery(string sql);
        Task<DataTable> ExecuteDataTable(string sql);
        Task<IList<T>> GetList<T>(string sql) where T : class, new();
        DBModel GetDB();
    }
}
