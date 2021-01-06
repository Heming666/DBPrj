using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    /// <summary>
    /// 首页配置表
    /// </summary>
    public class IndexManageEntity 
    {
        public string Id { get; set; }
        public string DeptId { get; set; }
        /// <summary>
        /// 配置的标题
        /// </summary>
        public string Title { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserName { get; set; }
        public string ModifyUserId { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUserName { get; set; }
        public int? Sort { get; set; }
        public int? IsShow { get; set; }
        /// <summary>
        /// 分类类型 0平台端  1 安卓终端
        /// </summary>
        public int? IndexType { get; set; }

    }
}
