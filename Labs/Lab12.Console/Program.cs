using Lab12.Stack;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mystack = new MyStack<string>();

            mystack.OnPush += (string t) => Console.WriteLine("On Push: " + t);
            mystack.OnPop += (string t) => Console.WriteLine("On Pop: " + t);
            mystack.OnClear += () => Console.WriteLine("On Clear");

            mystack.Push("test");
            mystack.Push("qew");
            mystack.Push("adfwef");
            mystack.Push("wefewf");
            mystack.Push("12312312");

            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
        }
    }
}
