using System;

namespace StackSimulation
{
    public class StackClass
    {
        private const int STACK_SIZE = 100;
        private int _top;
        private int[] stackArray = new int[STACK_SIZE];

        public StackClass()
        {
            _top = -1;
        }

        public void Push(int data)
        {
            if (_top < STACK_SIZE - 1)
            {
                _top++;
                stackArray[_top] = data;
            }
            else
            {
                Console.WriteLine("\n*Push Error: Stack Overflow");
            }
        }

        public int Pop()
        {
            int data = -1;
            if (_top >= 0)
            {
                data = stackArray[_top];
                _top--;
            }
            else
            {
                Console.WriteLine("\n* Pop Error: Stack Empty");
            }
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StackClass stack = new StackClass();
            Random random = new Random();
            int value;

            Console.WriteLine("Push 10 items");
            for (int i = 0; i < 10; i++)
            {
                value = random.Next(0, 100);
                Console.WriteLine("{1}: Push {0}", value, i);
                stack.Push(value);
            }
            Console.WriteLine("Pop 5 items");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{1}: Pop {0}", stack.Pop(), i);
            }
            Console.WriteLine("Push 3 items");
            for (int i = 0; i < 3; i++)
            {
                value = random.Next(0, 100);
                Console.WriteLine("{1}: Push {0}", value, i);
                stack.Push(value);
            }
            Console.WriteLine("Pop 8 Items");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("{1}: Pop {0}", stack.Pop(), i);
            }
            Console.ReadLine();
        }
    }
}
