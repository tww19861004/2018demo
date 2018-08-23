using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Demo
{
    public class DataManager
    {
        private IDataBase _database;
        private IShowDBInfo _showDbInfo;
        public DataManager(IDataBase database, IShowDBInfo ishowdbinfo)
        {
            this._database = database;
            this._showDbInfo = ishowdbinfo;
        }

        //省略Add,Updata,Delete,Select方法
        public void Show()
        {
            _showDbInfo.Show();
        }

        public void Add()
        {
            _database.Add();
        }

        public void Delete()
        {
            _database.Delete();
        }

        public void Update()
        {
            _database.Update();
        }

        public void Select()
        {
            _database.Select();
        }
    }
}
