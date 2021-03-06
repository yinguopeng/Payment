using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertCommissionClausePercentage Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClausePercentage : AlipayObject
    {
        /// <summary>
        /// 分佣比例结束范围(100以内精度2位的非负小数)
        /// </summary>
        [JsonProperty("commission_rate_end")]
        [XmlElement("commission_rate_end")]
        public string CommissionRateEnd { get; set; }

        /// <summary>
        /// 分佣比例开始范围(100以内精度2位的非负小数)
        /// </summary>
        [JsonProperty("commission_rate_start")]
        [XmlElement("commission_rate_start")]
        public string CommissionRateStart { get; set; }

        /// <summary>
        /// 封顶金额结束范围(精度2位的非负小数)
        /// </summary>
        [JsonProperty("max_limit_end")]
        [XmlElement("max_limit_end")]
        public string MaxLimitEnd { get; set; }

        /// <summary>
        /// 封顶金额开始范围(精度2位的非负小数)
        /// </summary>
        [JsonProperty("max_limit_start")]
        [XmlElement("max_limit_start")]
        public string MaxLimitStart { get; set; }
    }
}
