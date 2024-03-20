using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
//通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(Action<T> action)
        {
            Node<T>current = head;
            while(current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            Random random = new Random();
            int num = 0;
            Console.WriteLine("Input number:");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                list.Add(random.Next(1,200));
            }
            int index = 1;
            list.Foreach(item=> { Console.WriteLine($"第{index++}个元素为{item}");});
            int max = int.MinValue;
            int min = int.MaxValue;
            list.Foreach(item=> { if (item > max) max = item; });
            Console.WriteLine("最大值为{0}",max);
            list.Foreach(item => { if(item < min) min = item; });
            Console.WriteLine("最小值为{0}", min);
            int sum = 0;
            list.Foreach(item=>sum += item);
            Console.WriteLine("和为{0}", sum);


        }

    }
}