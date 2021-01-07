using Aspose.Cells;
using Common.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrj.DoMain
{
    /// <summary>
    /// 班组首页指标
    /// </summary>
    public class IndexManageMethod
    {
        /// <summary>
        /// 数据库交互
        /// </summary>
        private IRepository _service;
        private DBModel _dbmodel;
        public event Action<string> WriteMsg;
        public IndexManageMethod(IRepository repository,DBModel dBModel)
        {
            _service = repository;
            _dbmodel = dBModel;
        }

        /// <summary>
        ///  初始化指标
        /// </summary>
        public void InitIndexData()
        {
            //先获取所有的指标 
            List<DepartmentEntity> deptList = _service.GetList<DepartmentEntity>("select * from base_department").Result.ToList();
            List<IndexManageEntity> indexManages = this.ReadIndex();
            List<IndexAssocationEntity> assocationEntities = this.ReadAssocation();
            List<string> indexSqlList = new List<string>();
            List<string> asscocationSqlList = new List<string>();
            Dictionary<string, string> dic = new Dictionary<string, string>();  //index  Key 新的ID ，value  旧的Id

            #region 指标
            if (indexManages !=null && indexManages.Count>0)
            {
                indexManages.ForEach(index =>
                {
                    List<DepartmentEntity> natureList = deptList.Where(x => x.Nature == index.Nature).ToList();
                    if (natureList != null && natureList.Count > 0)
                    {
                        natureList.ForEach(dept =>
                        {
                            string guidId = Guid.NewGuid().ToString();
                            string indexInsert = @"INSERT INTO BASE_INDEXMANAGE(ID, DEPTID, TITLE, DEPTCODE, DEPTNAME, SORT, ISSHOW, CREATEUSERID, CREATEDATE, CREATEUSERNAME, MODIFYUSERID, MODIFYDATE, MODIFYUSERNAME, INDEXTYPE) 
VALUES ('" + guidId + "', '" + dept.DepartmentId + "', '" + index.Title + "', '" + dept.EnCode + "', '" + dept.FullName + "', " + index.Sort + ", " + index.IsShow + ", 'SYSTEM',{0} , 'Software', 'SYSTEM', {0}, 'Software', " + index.IndexType + ")";
                            if (_dbmodel.DBType == "Oracle")
                            {
                                indexInsert = string.Format(indexInsert, $"to_date('{DateTime.Now:yyyy-MM-dd HH:mm:ss}','yyyy-mm-dd hh24:mi:ss')");
                            }
                            else
                            {
                                indexInsert = string.Format(indexInsert, $"'{DateTime.Now:yyyy-MM-dd HH:mm-ss}'");
                            }
                            indexSqlList.Add(indexInsert);
                            dic.Add(guidId,index.Id);

                        });
                    }
                });
            }
            #endregion
            #region  指标的关联关系
            assocationEntities.ForEach(ass =>
            {
                string indexId = dic.FirstOrDefault(x => x.Value == ass.TitleId).Key;
            List<DepartmentEntity> natureList = deptList.Where(x => x.Nature == ass.Nature).ToList();
                if (natureList != null && natureList.Count > 0)
                {
                    natureList.ForEach(dept =>
                    {
                        string insertSql = $"INSERT INTO base_indexassociation(Id, TitleId, DataSetId, DeptId) VALUES ('{Guid.NewGuid().ToString()}', '{indexId}', '{ass.DataSetId}', '{dept.DepartmentId}')";
                        asscocationSqlList.Add(insertSql);
                    });
                    }
            });

            #endregion
            List<Task> taskList = new List<Task>();
            indexSqlList.ForEach(x =>
            {
                var task = Task.Run(() => { _service.ExecuteNonQuery(x); });
                taskList.Add(task);
            });
            asscocationSqlList.ForEach(x =>
            {
                var task = Task.Run(() => { _service.ExecuteNonQuery(x); });
                taskList.Add(task);
            });
            WriteMsg?.Invoke("指标配置执行完毕");
        }



        /// <summary>
        /// 读取指标分类信息
        /// </summary>
        /// <returns></returns>
        private List<IndexManageEntity> ReadIndex()
        {
            List<IndexManageEntity> data = new List<IndexManageEntity>();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/指标分类.xlsx");
            if (!System.IO.File.Exists(path))
            {
                WriteMsg?.Invoke("未找到“指标分类.xlsx文件”，请检查文件在不在程序根目录下");
                WriteMsg?.Invoke("==用navicat执行下面sql语句导出Excel文件放到根目录下的Content/指标 里面==");
                WriteMsg?.Invoke(@"select b.NATURE,a.* from base_indexmanage a
				 left join base_department b
				 on a.deptid= b.DEPARTMENTID");
                WriteMsg?.Invoke("=============附件名称：指标分类.xlsx================");
                throw new ArgumentNullException("未找到附件");
            }
            var book = new Workbook(path);
            var sheet = book.Worksheets[0];
            for (int i = 1; i <= sheet.Cells.MaxDataRow; i++)
            {

                IndexManageEntity indexEntity = new IndexManageEntity()
                {
                    Nature = sheet.Cells[i, 0].StringValue.Trim(),
                    Id = sheet.Cells[i, 1].StringValue.Trim(),
                    DeptId = sheet.Cells[i, 2].StringValue.Trim(),
                    Title = sheet.Cells[i, 3].StringValue.Trim(),
                    DeptCode = sheet.Cells[i, 4].StringValue.Trim(),
                    DeptName = sheet.Cells[i, 5].StringValue.Trim(),
                    Sort = sheet.Cells[i, 6].IntValue,
                    IsShow = sheet.Cells[i, 7].IntValue,
                    CreateUserId = sheet.Cells[i, 8].StringValue.Trim(),
                    CreateDate = DateTime.Parse(sheet.Cells[i, 9].StringValue),
                    CreateUserName = sheet.Cells[i, 10].StringValue.Trim(),
                    ModifyUserId = sheet.Cells[i, 11].StringValue.Trim(),
                    ModifyDate = DateTime.Parse(sheet.Cells[i, 12].StringValue),
                    ModifyUserName = sheet.Cells[i, 13].StringValue.Trim(),
                    IndexType = sheet.Cells[i, 14].IntValue,
                };
                data.Add(indexEntity);
            }
            return data;
        }

        /// <summary>
        /// 读取指标与分类的关联关系
        /// </summary>
        /// <returns></returns>
        private List<IndexAssocationEntity> ReadAssocation()
        {
            List<IndexAssocationEntity> data = new List<IndexAssocationEntity>();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content/指标/关联关系.xlsx");
            if (!System.IO.File.Exists(path))
            {
                WriteMsg?.Invoke("未找到“指标分类.xlsx文件”，请检查文件在不在程序根目录下");
                WriteMsg?.Invoke("==用navicat执行下面sql语句导出Excel文件放到根目录下的Content/指标 里面==");
                WriteMsg?.Invoke(@"select b.NATURE,a.* from base_indexassociation a 
inner join base_department b
on a.deptid=b.DEPARTMENTID ");
                WriteMsg?.Invoke("===========附件名称：关联关系.xlsx=============");
                throw new ArgumentNullException("未找到附件");
            }
            var book = new Workbook(path);
            var sheet = book.Worksheets[0];
            for (int i = 1; i <= sheet.Cells.MaxDataRow; i++)
            {

                IndexAssocationEntity indexEntity = new IndexAssocationEntity()
                {
                    Nature = sheet.Cells[i, 0].StringValue.Trim(),
                    Id = sheet.Cells[i, 1].StringValue.Trim(),
                    TitleId = sheet.Cells[i, 2].StringValue.Trim(),
                    DataSetId = sheet.Cells[i, 3].StringValue.Trim(),
                    DeptId = sheet.Cells[i, 4].StringValue.Trim(),
                };
                data.Add(indexEntity);
            }
            return data;
        }
    }
}
