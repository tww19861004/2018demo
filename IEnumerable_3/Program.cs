using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 泛型 约束 默认综合运用 
/// </summary>
namespace IEnumerable_3
{
    // *********************************文档定义  
    public interface IDocument       //定义一个借口  
    {
        string Title { get; set; }
        string Content { get; set; }
    }
    public class Document : IDocument
    {
        public string Title { get; set; }      //实现借口  
        public string Content { get; set; }    //实现借口  
        public Document(string title, string content) //构造函数  
        {
            this.Title = title;
            this.Content = content;
        }
    }

    public class DocumentManager<T> where T : IDocument     //T为文档类型  并且T必须实现IDocument接口 
    {
        private readonly Queue<T> documentQueue = new Queue<T>();   //建立一个泛型队列
        public void AddDocument(T doc)  //添加一个文档  
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }
        public bool IsDocuementAvailable   //字段  
        {
            get { return documentQueue.Count > 0; }
        }
        public T GetDocument()   //获取文档  
        {
            T doc = default(T); //默认值  
            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }
        public void DisplayAllDocuments()   //展示文档Title属性  
        {
            foreach (T doc in documentQueue)
            {
                Console.WriteLine(((IDocument)doc).Title);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager<Document> dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Sample A")); //添加文档  
            dm.AddDocument(new Document("Title B", "Sample B"));
            dm.DisplayAllDocuments();  //展示文档  
            if (dm.IsDocuementAvailable)
            {
                Document d = dm.GetDocument();  //获取一个文档，即出栈一个元素  
                Console.WriteLine(d.Content);
            }
        }
    }
}
