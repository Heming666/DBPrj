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
        public IndexManageEntity()
        {
        }

        public IndexManageEntity(string nature, string id, string deptId, string title, string deptCode, string deptName, string createUserId, DateTime createDate, string createUserName, string modifyUserId, DateTime modifyDate, string modifyUserName, int? sort, int? isShow, int? indexType, int? templet)
        {
            Nature = nature;
            Id = id;
            DeptId = deptId;
            Title = title;
            DeptCode = deptCode;
            DeptName = deptName;
            CreateUserId = createUserId;
            CreateDate = createDate;
            CreateUserName = createUserName;
            ModifyUserId = modifyUserId;
            ModifyDate = modifyDate;
            ModifyUserName = modifyUserName;
            Sort = sort;
            IsShow = isShow;
            IndexType = indexType;
            Templet = templet;
        }

        /// <summary>
        /// 所属单位性质
        /// </summary>
        public string Nature { get; set; }
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
        /// <summary>
        /// 所属的模板  1第一套  2 第二套 一次类推
        /// </summary>
        public int? Templet { get; set; }

        public override bool Equals(object obj)
        {
            return obj is IndexManageEntity entity &&
                   Nature == entity.Nature &&
                   Id == entity.Id &&
                   DeptId == entity.DeptId &&
                   Title == entity.Title &&
                   DeptCode == entity.DeptCode &&
                   DeptName == entity.DeptName &&
                   CreateUserId == entity.CreateUserId &&
                   CreateDate == entity.CreateDate &&
                   CreateUserName == entity.CreateUserName &&
                   ModifyUserId == entity.ModifyUserId &&
                   ModifyDate == entity.ModifyDate &&
                   ModifyUserName == entity.ModifyUserName &&
                   Sort == entity.Sort &&
                   IsShow == entity.IsShow &&
                   IndexType == entity.IndexType &&
                   Templet == entity.Templet;
        }
    }
}
