using Repository;
using System;
using System.Collections.Generic;
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
            _service.ExecuteDataTable("");
        }
    }
}
