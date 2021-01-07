using Common;
using Common.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MysqlRepository : IRepository
    {
        private readonly string conString;
        //private DBModel _dbModel;
        public MysqlRepository(string conStr) => conString = conStr;
        public MysqlRepository(DBModel db)
        {
            db.BuidConStr();
            conString = db.ConnStr;
        }
        public async Task<int> ExecuteNonQuery(string sql)
        {
            int count = 0;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                await con.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    count = await cmd.ExecuteNonQueryAsync();
                }
                await con.CloseAsync();
                return count;
            }
        }

        public async  Task<DataTable> ExecuteDataTable(string sql)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                await con.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (System.Data.Common.DbDataReader dr = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection))
                    {
                        DataTable dt = new DataTable();
                        for (int intCounter = 0; intCounter < dr.FieldCount; ++intCounter)
                        {
                            dt.Columns.Add(dr.GetName(intCounter), dr.GetFieldType(intCounter));
                        }
                        dt.BeginLoadData();

                        object[] objValues = new object[dr.FieldCount];
                        if (dr.HasRows)
                        {
                            while (await dr.ReadAsync())
                            {
                                dr.GetValues(objValues);
                                dt.LoadDataRow(objValues, true);
                            }
                            dr.Close();
                            dt.EndLoadData();
                        }
                        await con.CloseAsync();
                        return dt;
                    }
                }
            }
        }

        public async Task<IList<T>> GetList<T>(string sql) where T : class, new()
        {
            DataTable dt = await this.ExecuteDataTable(sql);
            return Util.ConvertTo<T>(dt);
        }

        public DBModel GetDB()
        {
            return new DBModel();
        }
    }
}
