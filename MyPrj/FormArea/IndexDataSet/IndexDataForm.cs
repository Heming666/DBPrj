using Common.Models;
using Newtonsoft.Json;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrj.FormArea.IndexDataSet
{
    public partial class IndexDataForm : Form
    {
        private IRepository _repository;
        private DBModel _dbmodel;
        public IndexDataForm()
        {
            
            InitializeComponent();
        }

        public event Action<string> WriteMsg;

        /// <summary>
        /// 检验数据模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckData_Click(object sender, EventArgs e)
        {
            bool result = true;
            List<TerminalDataSetEntity> terminalDataSetEntities;
            List<IndexManageEntity> indexManageEntities;
            List<IndexAssocationEntity> assocationEntities;
            WriteMsg?.Invoke("开始检验");
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/基础指标数据.txt")))
            {
                WriteMsg?.Invoke("基础指标数据.txt文件正常");
                terminalDataSetEntities =  ReadIndexList().Result;
                if (terminalDataSetEntities != null && terminalDataSetEntities.Count > 0)
                {
                    WriteMsg?.Invoke("基础指标数据.txt数据正常");
                }
                else
                {
                    WriteMsg?.Invoke("基础指标数据.txt无数据");
                    result = false;
                }
            }
            else
                WriteMsg?.Invoke("基础指标数据.txt文件不存在"); result = false;
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/标题配置.txt")))
            { WriteMsg?.Invoke("标题配置.txt文件正常");
                indexManageEntities = ReadIndexManageList().Result;
                if (indexManageEntities != null && indexManageEntities.Count > 0)
                {
                    WriteMsg?.Invoke("标题配置.txt数据正常");
                }
                else
                {
                    WriteMsg?.Invoke("标题配置.txt无数据");
                    result = false;
                }
            }
            else
                WriteMsg?.Invoke("标题配置.txt文件不存在"); result = false;
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/关联关系.txt")))
            { WriteMsg?.Invoke("关联关系.txt文件正常");
                assocationEntities = ReadAssocationList().Result;
                if (assocationEntities != null && assocationEntities.Count > 0)
                {
                    WriteMsg?.Invoke("关联关系.txt数据正常");
                }
                else
                {
                    WriteMsg?.Invoke("关联关系.txt无数据");
                    result = false;
                }
            }
            else
                WriteMsg?.Invoke("关联关系.txt文件不存在"); result = false;

            if (result == false)
            {
                WriteMsg?.Invoke("数据检验完毕，数据有问题，忽略并执行初始化请点击“开始初始化”按钮，或点击“重新读取并存储数据”");
            }
            else
            {
                WriteMsg?.Invoke("数据检验完毕，点击“重新读取并存储数据”");
            }
        }
        /// <summary>
        /// 读取模板数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReadData_Click(object sender, EventArgs e)
        {
            pnl_DBInfo.Visible = true;
            pnl_DBInfo.Show();
        }

        /// <summary>
        /// 开始初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Begin_Click(object sender, EventArgs e)
        {
            if (_dbmodel == null && _repository == null)
            {
                WriteMsg?.Invoke("未选择目标数据库，请在主界面选择要初始化的数据库"); 
                return;
            }
            WriteMsg?.Invoke("开始备份数据");
            List<TerminalDataSetEntity> terminalDataSetEntities = _repository.GetList<TerminalDataSetEntity>("select * from base_terminaldataset").Result.ToList();
            WriteMsg?.Invoke("base_terminaldataset数据读取完毕");
            List<IndexManageEntity> indexManageEntities = _repository.GetList<IndexManageEntity>("select * from base_indexmanage").Result.ToList();
            WriteMsg?.Invoke("base_indexmanage数据读取完毕");
            List<IndexAssocationEntity> assocationEntities = _repository.GetList<IndexAssocationEntity>("select * from base_indexassociation").Result.ToList();
            WriteMsg?.Invoke("base_indexassociation数据读取完毕");
            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/备份"))) Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/备份"));
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/备份/基础指标数据.txt"), JsonConvert.SerializeObject(terminalDataSetEntities));
            WriteMsg?.Invoke("base_terminaldataset数据备份完毕");
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/备份/标题配置.txt"), JsonConvert.SerializeObject(indexManageEntities));
            WriteMsg?.Invoke("base_indexmanage数据备份完毕");
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/备份/关联关系.txt"), JsonConvert.SerializeObject(assocationEntities));
            WriteMsg?.Invoke("base_indexassociation数据备份完毕");

            WriteMsg?.Invoke("开始删除目标服务器里的数据");

        }
        /// <summary>
        /// 开始读取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_read_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ConStr.Text.Trim()))
            {
                WriteMsg?.Invoke("数据库链接字符串不能为空");
            }
            else
            {
                try
                {
                    IRepository repository = new MysqlRepository(txt_ConStr.Text.Trim());
                    List<TerminalDataSetEntity> terminalDataSetEntities = repository.GetList<TerminalDataSetEntity>("select * from base_terminaldataset").Result.ToList();
                    List<IndexManageEntity> indexManageEntities = repository.GetList<IndexManageEntity>("select * from base_indexmanage").Result.ToList();
                    List<IndexAssocationEntity> assocationEntities = repository.GetList<IndexAssocationEntity>("select * from base_indexassociation").Result.ToList();
                    File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/基础指标数据.txt"), JsonConvert.SerializeObject(terminalDataSetEntities));
                    File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/标题配置.txt"), JsonConvert.SerializeObject(indexManageEntities));
                    File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/关联关系.txt"), JsonConvert.SerializeObject(assocationEntities));
                    WriteMsg?.Invoke("数据读取并存储完毕");
                }
                catch (Exception ex)
                {
                    WriteMsg?.Invoke(ex.Message);
                }
                
            }
        }
        /// <summary>
        /// 读取基础指标数据
        /// </summary>
        /// <returns></returns>

        private  Task<List<TerminalDataSetEntity>> ReadIndexList()
        {
            return Task.Run(() =>
            {
                String indexStr = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/基础指标数据.txt"));

                var data = JsonConvert.DeserializeObject<List<TerminalDataSetEntity>>(indexStr);
                return data;
            });
          
        }

        /// <summary>
        /// 读取标题配置数据
        /// </summary>
        /// <returns></returns>
        private Task<List<IndexManageEntity>> ReadIndexManageList()
        {
            return Task.Run(() =>
            {
                String indexStr = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/标题配置.txt"));

                var data = JsonConvert.DeserializeObject<List<IndexManageEntity>>(indexStr);
                return data;
            });
        }

        /// <summary>
        /// 读取关关系
        /// </summary>
        /// <returns></returns>
        private Task<List<IndexAssocationEntity>> ReadAssocationList()
        {
            return Task.Run(() =>
            {
                String indexStr = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/关联关系.txt"));

                var data = JsonConvert.DeserializeObject<List<IndexAssocationEntity>>(indexStr);
                return data;
            });
        }
        /// <summary>
        /// 获取数据库选择窗体的数据库信息
        /// </summary>
        /// <param name="db"></param>
        public void GetDbInfo(DBModel db, IRepository repository)
        {
            _dbmodel = db;
            _dbmodel.BuidConStr();
            _repository = repository;
        }

    }
}
