using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ss
{
    public class LinkListNode<T>
    {
        public T Value;    //节点值  
        public LinkListNode<T> next;  //后继节点指针  
        public LinkListNode<T> prev;  //前驱节点指针  
        public LinkListNode(T value)  //构造函数  
        {
            this.Value = value;
        }
    }
    public class LinkList<T> : IEnumerable<T>
    {
        public LinkListNode<T> first;
        public LinkListNode<T> last;
        public LinkListNode<T> AddLast(T node)
        {
            LinkListNode<T> newNode = new LinkListNode<T>(node);
            if (first == null)  //此链表无内容  
            {
                first = newNode;
                last = first;
            }
            else
            {
                last.next = newNode;
                newNode.prev = last;
                last = newNode;
            }
            return newNode;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkListNode<T> current = first;
            while (current != null)
            {
                yield return current.Value;
                current = current.next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main()
        {
            LinkList<int> list1 = new LinkList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
        }
    }
}