using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




class Program
{
    static void Main(string[] args)
    {
        Stack<int> s = new Stack<int>(4);
        s.Push(5);
        s.Push(6);
        s.Push(7);

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());

        Console.ReadKey();
    }
    public class Stack<T>
    {
        readonly int m_size;
        int m_StackPointer = 0;
        T[] m_items;

        public Stack()
            : this(100)
        {
        }

        public Stack(int size)
        {
            m_size = size;
            m_items = new T[m_size];
        }

        public void Push(T item)
        {
            if (m_StackPointer >= m_size)
                throw new StackOverflowException();
            m_items[m_StackPointer] = item;
            m_StackPointer++;
        }

        public T Pop()
        {
            m_StackPointer--;
            if (m_StackPointer >= 0)
            {
                return m_items[m_StackPointer];
            }
            else
            {
                m_StackPointer = 0;
                throw new InvalidOperationException();
            }
        }
    }
}
    

