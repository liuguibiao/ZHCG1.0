using System;
using System.Collections.Generic;
using System.Text;

namespace ZHCG.Data.Entity
{
    public interface IPrivilege
    {
        /// <summary>
        /// 创建人id
        /// </summary>
        long CreateUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        DateTime UpdateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        long UpdateUserId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        bool IsDelete { get; set; }
    }
}
