using Common;
using Common.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OracleRepository : IRepository
    {
        public readonly string conString;
        public OracleRepository(string ConStr)
        {
            conString = ConStr;
        }
        public OracleRepository(DBModel db)
        {
            db.BuidConStr();
            conString = db.ConnStr;
        }
        public async Task<DataTable> ExecuteDataTable(string sql)
        {
            DataTable datatable = new DataTable();
            using (OracleConnection conn = new OracleConnection(conString))
            {
                await conn.OpenAsync();
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(datatable);
                }
                conn.Close();
            }
            return datatable;
        }

        public async Task<int> ExecuteNonQuery(string sql)
        {
            int count = 0;
            using (OracleConnection conn = new OracleConnection(conString))
            {
                await conn.OpenAsync();
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    count = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return count;
        }

        public async Task<IList<T>> GetList<T>(string sql) where T : class, new()
        {
            DataTable dt = await this.ExecuteDataTable(sql);
            return Util.ConvertTo<T>(dt);
        }
    }
}
