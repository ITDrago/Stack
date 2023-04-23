namespace Stack
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var mystack = new LinkedListStack<int>();

            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            WriteStack(mystack);
            Console.WriteLine();
            Console.WriteLine(mystack.Peek());
            Console.WriteLine();
            mystack.Pop();
            WriteStack(mystack);
        }

        public static void WriteStack(LinkedListStack<int> stack)
        { 
            foreach(var i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}