using Aspose.Cells;
using Common.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// 班组首页指标
    /// </summary>
   public  class IndexManageMethod
    {
        /// <summary>
        /// 数据库交互
        /// </summary>
        private IRepository _service;
        public IndexManageMethod(IRepository repository)
        {
            _service = repository;
        }

        /// <summary>
        ///  初始化指标
        /// </summary>
        public void InitIndexData()
        {
            //先获取所有的指标 
            List<DepartmentEntity> deptList = _service.GetList<DepartmentEntity>("select * from base_department").Result.ToList();
            //List<IndexManageEntity> indexManages = _service.GetList<IndexManageEntity>("select * from base_indexmanage").Result.ToList();
            //List<base_indexassociation> indexManages = _service.GetList<base_indexassociation>("select * from base_indexmanage").Result.ToList();

            var book = new Workbook(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Content/指标/指标分类.xlsx"));
            var sheet = book.Worksheets[0];
            for (int i = 1; i <= sheet.Cells.MaxDataRow; i++)
            {

                string nature = sheet.Cells[i, 0].StringValue.Trim();
                if (!string.IsNullOrWhiteSpace(nature)) continue;
               
                    var natureList = deptList.Where(p => p.Nature == nature).ToList();
                if (natureList != null && natureList.Count > 0)
                {
                    natureList.ForEach(dept =>
                    {
                        

                    });
                }




                var userEntity = users.FirstOrDefault(x => x.RealName == UserName);
                if (userEntity != null)
                {
                    var currentTask = Task.Run(() =>
                    {
                        try
                        {
                            var updateSql = $" UPDATE base_user SET ACCOUNT='{ACCOUNT}'  WHERE realname='{userEntity.RealName}'";
                            var count = MySqlHelper.ExecuteNonQuery(updateSql).Result;
                            Console.WriteLine($"<<<<<<<<<<<<<<{userEntity.RealName}  添加 {(count > 0 ? "成功" : "失败")}>>>>>>>>>>>>>>");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "=============================");
                        }

                    });
                    taskList.Add(currentTask);
                }
                else
                {
                    Console.WriteLine($"{UserName}在数据库不存在==========================================");
                }
                execCount++;
            }

        }
    }
}
