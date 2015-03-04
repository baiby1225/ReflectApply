using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 用反射_Attribute控制属性的值
{
    public class CheckAttribute : Attribute
    {
        /// <summary>
        /// 检查是否可以为空
        /// </summary>
        public bool CheckEmpty { get; set; }

        /// <summary>
        /// 检查字符串长度区间
        /// </summary>
        public bool CheckLengthArea { get; set; }

        /// <summary>
        /// 检查数字大小区间
        /// </summary>
        public bool CheckNumberArea { get; set; }

        /// <summary>
        /// 正则检测
        /// </summary>
        public bool CheckRegex { get; set; }

        /// <summary>
        /// 字符串最大长度
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// 字符串最小长度
        /// </summary>
        public int MinLength { get; set; }

        /// <summary>
        /// 数字最大值
        /// </summary>
        public int MaxNumber { get; set; }

        /// <summary>
        /// 数字最小值
        /// </summary>
        public int MinNumber { get; set; }

        /// <summary>
        /// 正则表达式
        /// </summary>
        public string Regex { get; set; }
    }
}
