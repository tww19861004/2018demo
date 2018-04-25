using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
    static string dataFromServer = "";

    static void Main(string[] args)
    {
        /*
         *下面的例子展示了如何使用AutoResetEvent来释放线程。在Main方法中，我们用Task Factory创建了一个线程，
         * 它调用了GetDataFromServer方法。调用该方法后，我们调用AutoResetEvent的WaitOne方法将主线程变为等待状态。
         * 在调用GetDataFromServer方法时，
         * 我们调用了AutoResetEvent对象的Set方法，它释放了主线程，并控制台打印输出dataFromServer方法返回的数据。
         */
        Task task = Task.Factory.StartNew(() =>
        {
            GetDataFromServer();
        });

        //Put the current thread into waiting state until it receives the signal
        autoResetEvent.WaitOne();

        //Thread got the signal
        Console.WriteLine(dataFromServer);

        Console.ReadKey();
    }

    static void GetDataFromServer()
    {
        //Calling any webservice to get data
        Thread.Sleep(TimeSpan.FromSeconds(4));
        dataFromServer = "Webservice data";
        autoResetEvent.Set();
    }
}