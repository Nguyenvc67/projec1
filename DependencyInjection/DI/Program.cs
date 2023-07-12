//dependency phu thuoc
using System;

namespace DependencyInjection
{
    class ClassA
    {
        public void actionA(){
            Console.WriteLine("actionA");
        }
    }
    class ClassB
    {
        public void actionB(){
            Console.WriteLine("actionB");
            var a = new ClassA();
            a.actionA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var b = new ClassB();
            b.actionB();
        }
    }
}
