using System.IO;
try{
BinaryReader src = new BinaryReader(new FileStream("../../Baitap9.zip", FileMode.Open, FileAccess.Read));

BinaryWriter des = new BinaryWriter(new FileStream("./Baitap9.zip",FileMode.OpenOrCreate, FileAccess.Write));
int count = 1024;
byte[] buf;
while((buf=src.ReadBytes(count)).Length>0){
    des.Write(buf);
}
src.Close();
des.Close();
Console.WriteLine("Copy file comlete!");
}catch(IOException ex){
    Console.WriteLine("Copy file Error:"+ ex.Message);
}
