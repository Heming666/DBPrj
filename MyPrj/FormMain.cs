using Common.Models;
using MyPrj.DoMain;
using MyPrj.FormArea.IndexDataSet;
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
        private MsgForm msgForm;

        public event Action<string> WriteMsg;
        public From1()
        {
            InitializeComponent();
             msgForm = new MsgForm();
            this.WriteMsg += msgForm.WriteMsg;
            msgForm.Show();
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
            WriteMsg?.Invoke("数据库选择完毕");
        }






        /// <summary>
        /// 初始化指标数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_BuidIndex_Click(object sender, EventArgs e)
        {
            IndexDataForm indexDataForm = new IndexDataForm();
            indexDataForm.WriteMsg += msgForm.WriteMsg;
            indexDataForm.Show();
            // var  indexManageMethod =  new IndexManageMethod(_repository,_dbmodel);
            //indexManageMethod.WriteMsg += msgForm.WriteMsg;
            //try
            //{
            //    indexManageMethod.InitIndexData();
            //}
            //catch (Exception ex)
            //{
            //    WriteMsg?.Invoke(ex.Message+"\r\n"+JsonConvert.SerializeObject(ex.InnerException));
            //}
           
        }
    }
}
