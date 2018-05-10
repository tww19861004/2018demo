using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 创建表
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"D:\test.db";
            // create a database "context" object t
            String connectionString = String.Format("Data Source={0};Version=3", fileName);
            DbProviderFactory sqlFactory = new System.Data.SQLite.SQLiteFactory();
            PetaPoco.Database db = new PetaPoco.Database(connectionString, sqlFactory);

            #region 创建测试表1
            //string dropQuery = "IF EXISTS qrtz_operatelog DROP TABLE qrtz_operatelog";
            //db.Execute(dropQuery);
            //String createQuery =
            //            @"CREATE TABLE IF NOT EXISTS
            //                [User] (
            //                [id]           INTEGER      NOT NULL PRIMARY KEY AUTOINCREMENT,
            //                [Name]         VARCHAR(20)  NOT NULL DEFAULT 'tww',
            //                [Phone]        VARCHAR(20)  NOT NULL,
            //                [Email]        VARCHAR(20)  NOT NULL,
            //                [Password]     VARCHAR(20)  NOT NULL,
            //                [Active]       INTEGER      NOT NULL DEFAULT 1,
            //                [CreateTime]   TEXT         NOT NULL                           
            //                )";
            String createQuery =
                        @"CREATE TABLE IF NOT EXISTS
                            [qrtz_operatelog] (
                            [id]           INTEGER       NOT NULL PRIMARY KEY AUTOINCREMENT,
                            [TableName]    VARCHAR(255)  ,
                            [Describe]     VARCHAR(255)  ,
                            [Type]         INTEGER       NOT NULL,
                            [CreateTime]   datetime      NOT NULL,
                            [UpdateTime]   datetime      NOT NULL
                            )";
            db.Execute(createQuery);


            createQuery =
                        @"CREATE TABLE IF NOT EXISTS
                            [Schedule] (
                            [JobId]        INTEGER       NOT NULL ,
                            [TableName]    VARCHAR(255)  ,
                            [Describe]     VARCHAR(255)  ,
                            [Type]         INTEGER       NOT NULL,
                            [CreateTime]   datetime      NOT NULL,
                            [UpdateTime]   datetime      NOT NULL
                            )";
            db.Execute(createQuery);

        }
    }
}
#endregion