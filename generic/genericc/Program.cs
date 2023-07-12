using System;
namespace generic{
    class program{
        class produc<A>{
        A ID;
        public void SetID(A id)
        {
            this.ID = id;
        }
        public void PrintID()
        {
            Console.WriteLine($"ID = {this.ID}");
        }
        }
        static void Swap(ref int x,ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
            
        }
        static void Swap(ref float x,ref float y)
        {
            float t;
            t = x;
            x = y;
            y = t;
        }
        static void AllSwap<T>(ref T x,ref T y)
        {
            T t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            float a=2;
            float b=3;
            Console.WriteLine($"a={a},b={b}");
            Swap(ref a, ref b);
            AllSwap<float>(ref a, ref b);
            Console.WriteLine($"a={a},b={b}");
            produc<int> sanpham1 = new produc<int>();
            sanpham1.SetID(123);
            sanpham1.PrintID();
            List<int> List1 = new List<int>();
            List<string> List2 = new List<string>();
            List<ID> List3 = new List<ID>();
        }
    }
}