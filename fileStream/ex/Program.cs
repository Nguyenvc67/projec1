using System;
using System.IO;
namespace FileIOApplication{
    class Program{
        static void Main(string[] args){
            FileStream fs = new FileStream("sample.dat", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            for(int i=0; i <= 20; i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Position=0;
            for(int i=0; i <= 20; i++)
            {
                Console.Write(fs.ReadByte()+ " ");
            }
            fs.Close();
        }
    }
}
