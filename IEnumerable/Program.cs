using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ss
{
    //https://blog.csdn.net/riyuedangkong1/article/details/53350554
    public class LinkListNode  //链表节点  
    {
        public object Value;    //节点内容  
        public LinkListNode(object node)   //构造函数  
        {
            this.Value = node;
        }
        public LinkListNode next;    //指向后继节点  
        public LinkListNode prev;   //指向前驱节点  
    }
    public class LinkList : IEnumerable
    {
        public LinkListNode first;    //链表的第一个节点指针  
        public LinkListNode last;     //链表的最后一个节点指针  
        public LinkListNode AddLast(object node)  //添加一个节点  
        {
            var newNode = new LinkListNode(node);
            if (first == null)
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
        public IEnumerator GetEnumerator()
        {
            LinkListNode temp = first;
            while (temp != null)
            {
                yield return temp.Value;
                temp = temp.next;
            }
        }
    }
    class Program
    {        
        static void Main()
        {
            LinkList list1 = new LinkList();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
        }
    }
}