using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueueDemo
{
    //ConcurrentQueue的内存泄露BUG :这个BUG只存在于.net4.0的ConcurrentQueue集合，.net4.5以后的都修复了
    //这部分内容我觉得可以用在网络爬虫之类的任务上，应该是很有启发的
    //https://blog.csdn.net/huiwuhuiwu/article/details/53606682
    class Customer
    {
        public int Id { get; set; }
    }

    class Program
    {
        //“随机等待时间”任务：
        static Task GetRandomDelay()
        {
            int delay = new Random(DateTime.Now.Millisecond).Next(1, 500);
            return Task.Delay(delay);
        }

        //生成”任务：
        static async Task TaskProducer(ConcurrentQueue<Customer> queue)
        {
            for (int i = 1; i <= 20; i++)
            {
                await Task.Delay(50);
                var workItem = new Customer { Id = i };
                queue.Enqueue(workItem);//入列
                Console.WriteLine("Task {0} has been posted", workItem.Id);
            }
        }

        static async Task TaskProcessor(ConcurrentQueue<Customer> queue, string name, CancellationToken token)
        {
            Customer workItem;
            bool dequeueSuccesful = false;

            await GetRandomDelay(); //随机等待一定的时间，模拟处理操作。  
            do
            {
                dequeueSuccesful = queue.TryDequeue(out workItem); //注意：这里是按照先进先出次序出队！  
                if (dequeueSuccesful)
                {
                    Console.WriteLine("Task {0} has been processed success by {1}", workItem.Id, name);
                }
                else
                {
                    Console.WriteLine("Task {0} has been processed failed by {1}", workItem.Id, name);
                }

                await GetRandomDelay();
            }
            while (!token.IsCancellationRequested);
        }

        static async Task RunProgram()
        {
            var taskQueue = new ConcurrentQueue<Customer>();
            var cts = new CancellationTokenSource();

            //生成任务队列taskQueue  
            var taskSource = Task.Run(() => TaskProducer(taskQueue));

            //使用四个处理任务来处理。  
            Task[] taskProcessors = new Task[4];
            for (int i = 1; i <= 4; i++)
            {
                string processorId = i.ToString();
                taskProcessors[i - 1] = Task.Run(() => TaskProcessor(taskQueue, "Processor " + processorId, cts.Token));
            }
            await taskSource; //等待任务产生完毕  
            cts.CancelAfter(5000); //两秒钟后取消处理程序  

            await Task.WhenAll(taskProcessors);//等待四个任务处理程序全部处理完毕  
        }

        static void Main(string[] args)
        {
            Task t = RunProgram();
            t.Wait();
            Console.Read();
        }
    }
}
