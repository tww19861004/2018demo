using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Demo
{    
    

    class Program
    {
        static void Main(string[] args)
        {
            //实例化Ninject对象
            IKernel Kerner = new StandardKernel();
            //绑定对象
            Kerner.Bind<IDataBase>().To<SqlServer>();
            Kerner.Bind<IShowDBInfo>().To<ShowDBInfo>();
            Kerner.Bind<DataManager>().ToSelf();
            var dataManager = Kerner.Get<DataManager>();
            dataManager.Show();
            Console.Read();

        }
    }
}
