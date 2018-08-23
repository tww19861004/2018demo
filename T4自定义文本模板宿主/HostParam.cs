using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4Generator
{
    /// <summary>
    /// 参数对象
    /// </summary>
    [Serializable]
    public class HostParam
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DataBaseName { get; set; }
        /// <summary>
        /// 数据表名称
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace { get; set; }

        /// <summary>
        /// 数据表列集合
        /// </summary>
        public List<SchemaInfo> ColumnList { get; set; }
    }
}
