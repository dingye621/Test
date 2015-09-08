using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDateTime
{
    public enum TestEnum
    {
        /// <summary>
        /// 典当销售
        /// </summary>
        [Description("典当销售")]
        PawnSale = 1,
        /// <summary>
        /// 寄卖商品销售
        /// </summary>
        [Description("寄卖商品销售")]
        AgentSale = 2,
        /// <summary>
        /// 鉴定
        /// </summary>
        [Description("鉴定")]
        Appraisal = 3,
        /// <summary>
        /// 维修
        /// </summary>
        [Description("维修")]
        Repair = 4,
        /// <summary>
        /// 典当业务
        /// </summary>
        [Description("典当业务")]
        Pawn = 5,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 6
    }
}
