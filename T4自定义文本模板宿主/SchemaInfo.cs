using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4Generator
{
    /// <summary>
    /// 表结构信息
    /// </summary>
    [Serializable]
    public class SchemaInfo
    {
        /// <summary>
        /// 列描述信息
        /// </summary>
        public string ColumnDesc { get; set; }

        /// <summary>
        /// 列数据类型
        /// </summary>
        public string ColumnType { get; set; }

        /// <summary>
        /// 列名称
        /// </summary>
        public string ColumnName { get; set; }
    }
}
