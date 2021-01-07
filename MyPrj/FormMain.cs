using Common.Models;
using MyPrj.DoMain;
using Newtonsoft.Json;
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
    public partial class From1 : Form
    {
        private DBModel _dbmodel;
        private IRepository _repository;
        public From1()
        {
            InitializeComponent();
        }

        private void btn_CheckDB_Click(object sender, EventArgs e)
        {
            DataBaseForm checkDBfrom = new DataBaseForm();
            checkDBfrom.GetDB += GetDbInfo;//注册获取数控信息的时间
            checkDBfrom.ShowDialog();
        }



        /// <summary>
        /// 获取数据库选择窗体的数据库信息
        /// </summary>
        /// <param name="db"></param>
        private void GetDbInfo(DBModel db,IRepository repository)
        {
           _dbmodel = db;
            _dbmodel.BuidConStr();
            txt_checkDB.Text = _dbmodel.ConnStr;
            _repository = repository;
            WriteMsg("数据库选择完毕");
        }




        private void WriteMsg(string msg)
        {
            msg += "\r\n";
            txt_Msg.AppendText(msg);
        }

        /// <summary>
        /// 初始化指标数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_BuidIndex_Click(object sender, EventArgs e)
        {
             var  indexManageMethod =  new IndexManageMethod(_repository,_dbmodel);
            indexManageMethod.WriteMsg += this.WriteMsg;
            try
            {
                indexManageMethod.InitIndexData();
            }
            catch (Exception ex)
            {
                WriteMsg(ex.Message+"\r\n"+JsonConvert.SerializeObject(ex.InnerException));
            }
           
        }
    }
}
