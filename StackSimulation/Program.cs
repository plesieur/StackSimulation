using System;

namespace StackSimulation
{
    //Class to simulate a stack of integers
    public class StackClass
    {
        private const int STACK_SIZE = 100;   //Size of stack
        private int _top;                     //Pointer to Top of stck
        private int[] stackArray = new int[STACK_SIZE];     //Actual Stack

        public StackClass()
        {
            _top = -1;
        }

        //Push an integer onto the stack
        //Prints an error if stack is full
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

        //Pop the top item of the stack
        //Returns -1 if stack is empty
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
            StackClass stack = new StackClass();  //Instance of StackClass to test
            Random random = new Random();
            int value;

            //Test code below
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
            Console.ReadLine();  //Wait for user input to exit CLI
        }
    }
}
