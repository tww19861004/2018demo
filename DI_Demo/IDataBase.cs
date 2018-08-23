using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Demo
{
    public interface IDataBase
    {
        string DbName { get; }
        void Select();
        void Update();
        void Delete();
        void Add();
    }
}
