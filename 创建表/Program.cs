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
            //string dropQuery = "DROP TABLE qrtz_operatelog";
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
                        @"DROP TABLE qrtz_operatelog;
                            CREATE TABLE IF NOT EXISTS
                            [qrtz_operatelog] (
                            [id]           INTEGER       NOT NULL PRIMARY KEY AUTOINCREMENT,
                            [TableName]    VARCHAR(255)  ,
                            [Describe]     VARCHAR(255)  ,
                            [Type]         INTEGER       NOT NULL,
                            [CreateTime]   datetime      NOT NULL,
                            [UpdateTime]   datetime      
                            )";
            db.Execute(createQuery);


            createQuery =
                        @"DROP TABLE Schedule;
                            CREATE TABLE IF NOT EXISTS
                            [Schedule] (
                            [JobId]        INTEGER       NOT NULL PRIMARY KEY AUTOINCREMENT,
                            [JobName]    VARCHAR(255)  ,
                            [JobGroup]     VARCHAR(255)  ,
                            [JobStatus]         INTEGER       NOT NULL,
                            [Cron]   varchar(50)      ,
                            [AssemblyName]   varchar(50)      NOT NULL,
                            [ClassName]   varchar(50)      NOT NULL,
                            [Remark]     VARCHAR(255)  ,
                            [CreateTime]   datetime      NOT NULL,
                            [UpdateTime]   datetime  ,
                            [RunTimes]         INTEGER       NOT NULL,
                            [BeginTime]   datetime      NOT NULL,
                            [EndTime]   datetime      ,
                            [TriggerType]         INTEGER       NOT NULL,
                            [IntervalSecond]         INTEGER       NOT NULL,
                            [Url]     VARCHAR(255)
                            )";
            db.Execute(createQuery);

        }
    }
}
#endregion