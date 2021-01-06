using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class TerminalDataSetEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unint { get; set; }
        /// <summary>
        /// 是否启用 0禁用  1启用
        /// </summary>
        public int IsOpen { get; set; }

        /// <summary>
        /// 排序字段，越小越靠前
        /// </summary>
        public int? Sort { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 是否是班组指标 0 不是  1是
        /// </summary>
        public string IsBZ { get; set; }

        /// <summary>
        /// 绑定的功能模块的Id
        /// </summary>
        public string BindModuleId { get; set; }

        /// <summary>
        /// 自定义编码（双控指标需配置）
        /// </summary>
        public string CustomCode { get; set; }

        /// <summary>
        /// 指标分类 
        /// 0或者null 是安卓终端指标  
        /// 1 app指标
        /// </summary>
        public string DataSetType { get; set; }
        /// <summary>
        /// 指标图标
        /// </summary>
        public string IconUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
