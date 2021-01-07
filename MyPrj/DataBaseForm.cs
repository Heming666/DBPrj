using Common.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrj
{
    public partial class DataBaseForm : Form
    {
        private DBModel dbmodel;
       private IRepository repository;
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            BindComboBox();
        }


        /// <summary>
        /// 数据库切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //取得当前选择的项
            ListItem selectedItem = (ListItem)comboBox1.SelectedItem;
            string value = selectedItem.Value;    //值
            string text = selectedItem.Text;    //显示的文字
            if (text == "Oracle")
            {
                txt_Port.Text = "1521";
            }
            else if( text== "MySql")
            {
                txt_Port.Text = "3306";
            }
        }

        /// <summary>
        /// 绑定下拉菜单的数据库选项
        /// </summary>
        private void BindComboBox()
        {
            List<ListItem> list = new List<ListItem>();
            list.Add(new ListItem { Text = "MySql", Value = "MySql" });
            list.Add(new ListItem { Text = "Oracle", Value = "Oracle" });
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = list;
            comboBox1.SelectedValue = "MySql";        //设定选择项
        }



        /// <summary>
        /// 测试链接数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Test_Click(object sender, EventArgs e)
        {
            DBModel dB = new DBModel()
            {
                DBType = ((ListItem)comboBox1.SelectedItem).Value,
                IP = txt_IP.Text,
                UserName = txt_userId.Text,
                Password = txt_Pwd.Text,
                Port = txt_Port.Text,
                Database = "",
            };
          
            switch (dB.DBType)
            {
                case "MySql":
                    repository = new MysqlRepository(dB);
                    DataTable dt  = repository.ExecuteDataTable("select  TABLE_SCHEMA  from information_schema.tables group by TABLE_SCHEMA").Result;
                    if (dt != null && dt.Rows.Count>0)
                    {
                        var enumerator = dt.Rows.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            DataRow dr = enumerator.Current as DataRow;
                            dB.DbList.Add(new ListItem(dr["TABLE_SCHEMA"].ToString(), dr["TABLE_SCHEMA"].ToString()));
                        }
                    }
                    break;
                case "Oracle":
                    repository = new OracleRepository(dB);
                    break;
                default:
                    break;
            }
            if (dB.DbList != null && dB.DbList.Count>0)
            {
                cbx_Db.DisplayMember = "Text";
                cbx_Db.ValueMember = "Value";
                cbx_Db.DataSource = dB.DbList;
                cbx_Db.SelectedValue = dB.DbList.FirstOrDefault().Text;        //设定选择项
            }
            dbmodel = dB;
        }

        public event Action<DBModel,IRepository> GetDB;
        /// <summary>
        /// 选择完数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ListItem selectedItem = (ListItem)cbx_Db.SelectedItem;
            string value = selectedItem.Value;    //值
            dbmodel.Database = value;
            //此时需要重新生成一下repository  因为链接字符串里面的数据库未生成
            switch (dbmodel.DBType)
            {
                case "MySql":
                    repository = new MysqlRepository(dbmodel);

                    break;
                case "Oracle":
                    repository = new OracleRepository(dbmodel);
                    break;
                default:
                    break;
            }
            GetDB?.Invoke(dbmodel, repository);
            this.Close();
        }
    }
}
