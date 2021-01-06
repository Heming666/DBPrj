using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class DBModel
    {
        private List<ListItem> _dbList;
        private List<ListItem> _tableList;
        private string _connStr;
        public DBModel()
        {
            _dbList = new List<ListItem>();
            _tableList = new List<ListItem>();
        }

        /// <summary>
        /// IP
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// 数据库集合
        /// </summary>
        public List<ListItem> DbList { get => _dbList; set => _dbList = value; }

        /// <summary>
        /// 表集合
        /// </summary>
        public List<ListItem> TableList { get => _tableList; set => _tableList = value; }
        /// <summary>
        /// 数据库
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// 数据表
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DBType { get; set; }
        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServerName { get; set; }

        public string ConnStr { get => _connStr; set => _connStr = value; }
        public string Port { get; set; }

        public void BuidConStr()
        {
            switch (this.DBType)
            {
                case "MySql":
                    this.ConnStr = $"Server={this.IP};port={this.Port}; Database={this.Database};Uid={this.UserName};Pwd={this.Password};pooling=false; sslmode=none;charset=utf8";
                    break;
                case "Oracle":
                   this.ConnStr = $"User Id={this.UserName};Password={this.Password};Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={this.IP})(PORT={this.Port})))(CONNECT_DATA=(SERVICE_NAME={this.ServerName})))";
                    break;
                default:
                    break;
            }
         
        }
    }
}
