using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    /// <summary>
    /// 公司
    /// </summary>
    public class Company : BaseModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreatorId { get; set; }
        public int LastModifierId { get; set; }
        public DateTime? LastModifyTime { get; set; }
    }
}
