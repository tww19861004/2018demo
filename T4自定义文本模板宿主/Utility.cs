using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace T4Generator
{
    //数据库操作
    public static class DBHelper
    {
        private static SqlCommand PrepareCommand(SqlConnection conn, string cmdText, CommandType cmdType, SqlParameter[] parameters)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            if (parameters != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);
            }

            return cmd;
        }

        public static DataSet GetDataSet(string connString, string strSQL)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public static List<SchemaInfo> GetSchema(string connString, string tableName)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.AppendLine("SELECT ");
            sbSQL.AppendLine("    [Id]=C.column_id,");
            sbSQL.AppendLine("    [Name]=C.name,");
            sbSQL.AppendLine("    [Type]=T.name,");
            sbSQL.AppendLine("    [Length]=C.max_length,");
            sbSQL.AppendLine("    [Identity]=CASE WHEN C.is_identity=1 THEN N'T'ELSE N'' END,");
            sbSQL.AppendLine("    [PrimaryKey]=ISNULL(PKInfo.PrimaryKey,N''),");
            sbSQL.AppendLine("    [ForeignKey]=CASE WHEN FKInfo.parent_column_id>0 THEN N'T'ELSE N'' END,");
            sbSQL.AppendLine("    [ForeignKeyTable]=ISNULL(FKInfo.name,N''),");
            sbSQL.AppendLine("    [IsNull]=CASE WHEN C.is_nullable=1 THEN N'T'ELSE N'' END,");
            sbSQL.AppendLine("    [Default]=ISNULL(DC.definition,N''),");
            sbSQL.AppendLine("    [ColumnDesc]=ISNULL(EP.value,N'') ");
            sbSQL.AppendLine("FROM sys.columns C ");
            sbSQL.AppendLine("INNER JOIN sys.objects O ON C.object_id=o.object_id AND O.type='U' AND O.is_ms_shipped=0 ");
            sbSQL.AppendLine("INNER JOIN sys.types T ON C.user_type_id=T.user_type_id ");
            sbSQL.AppendLine("LEFT JOIN sys.default_constraints DC ON C.object_id=DC.parent_object_id AND C.column_id=DC.parent_column_id AND C.default_object_id=DC.object_id ");
            sbSQL.AppendLine("LEFT JOIN sys.extended_properties EP ON EP.class=1 AND C.object_id=EP.major_id AND C.column_id=EP.minor_id ");
            sbSQL.AppendLine("LEFT JOIN (SELECT IC.object_id,IC.column_id,PrimaryKey=CASE WHEN I.is_primary_key=1 THEN N'T'ELSE N'' END FROM sys.indexes I INNER JOIN sys.index_columns IC ON I.[object_id]=IC.[object_id] AND I.index_id=IC.index_id)PKInfo ON PKInfo.object_id=C.object_id AND PKInfo.column_id=C.column_id ");
            sbSQL.AppendLine("LEFT JOIN (SELECT FKC.parent_object_id,FKC.parent_column_id,O.name FROM sys.foreign_key_columns FKC INNER JOIN sys.objects O ON FKC.referenced_object_id=O.object_id)FKInfo ON C.object_id=FKInfo.parent_object_id AND C.column_id=FKInfo.parent_column_id ");
            sbSQL.AppendFormat("WHERE O.name='{0}' ORDER BY Id ASC", tableName);
            DataSet ds = GetDataSet(connString, sbSQL.ToString());
            List<SchemaInfo> list = new List<SchemaInfo>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                SchemaInfo info = new SchemaInfo();
                info.ColumnDesc = dr["ColumnDesc"].ToString();
                info.ColumnName = dr["Name"].ToString();
                info.ColumnType = TypeConvertor.MapType(dr["Type"].ToString());
                list.Add(info);
            }
            return list;
        }
    }

    //类型转换
    public static class TypeConvertor
    {
        //将数据库类型映射成C#类型
        public static string MapType(string dbType)
        {
            if (string.IsNullOrEmpty(dbType)) return dbType;
            dbType = dbType.ToLower();
            string csType = "object";
            switch (dbType)
            {
                case "char": csType = "string"; break;
                case "date": csType = "DateTime"; break;
                case "datetime": csType = "DateTime"; break;
                case "decimal": csType = "decimal"; break;
                case "float": csType = "double"; break;
                case "int": csType = "int"; break;
                case "money": csType = "decimal"; break;
                case "nchar": csType = "string"; break;
                case "ntext": csType = "string"; break;
                case "nvarchar": csType = "string"; break;
                case "smalldatetime": csType = "DateTime"; break;
                case "smallint": csType = "short"; break;
                case "smallmoney": csType = "decimal"; break;
                case "text": csType = "string"; break;
                case "time": csType = "TimeSpan"; break;
                case "varchar": csType = "string"; break;
                default: csType = "object"; break;
            }
            return csType;
        }
    }
}
