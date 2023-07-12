using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
namespace StudenManager
{
    class Program
    {
        static void Main(string[] agrs)
        {
            string path = "class.dat";
            using var stream = new FileStream(path: path,FileMode.OpenOrCreate);
            string path1 = "studens.dat";
            using var stream1 = new FileStream(path: path1,FileMode.OpenOrCreate);
            StudenManager.ListStuden s = new StudenManager.ListStuden();
            s.studen();
            s.Save1(stream1);
            s.Save(stream);
            Console.ReadKey();
        }
    }
    
    public class ListStuden
     {      
         public string StudenID {set;get;}
         public string FirstName {set;get;}
         public string MiddName{set;get;}
         public string LastName{set;get;}
         public string Birthday{set;get;}
         public string Address{set;get;}
         public string Phone{set;get;}
         public string Email{set;get;}
         public string ClassName{set;get;}
         public string Note{set;get;}
         public string Status{set;get;}
         public string StudyDay{set;get;}
         public string StudyTime{set;get;}
         public string ClassRoom{set;get;}
         public void Save(Stream stream)
         {
            var bytes_ClassName = Encoding.UTF8.GetBytes(ClassName);
            var bytes_lengClassName = BitConverter.GetBytes(bytes_ClassName.Length);
            stream.Write(bytes_lengClassName, 0, 4);
            stream.Write(bytes_ClassName, 0, bytes_ClassName.Length);

            var bytes_StudyDay = Encoding.UTF8.GetBytes(StudyDay);
            var bytes_lengStudyDay = BitConverter.GetBytes(bytes_StudyDay.Length);
            stream.Write(bytes_lengStudyDay, 0, 4);
            stream.Write(bytes_StudyDay, 0, bytes_StudyDay.Length);

            var bytes_StudyTime = Encoding.UTF8.GetBytes(StudyTime);
            var bytes_lengStudyTime = BitConverter.GetBytes(bytes_StudyTime.Length);
            stream.Write(bytes_lengStudyTime, 0, 4);
            stream.Write(bytes_StudyTime, 0, bytes_StudyTime.Length);

            var bytes_ClassRoom = Encoding.UTF8.GetBytes(ClassRoom);
            var bytes_lengClassRoom = BitConverter.GetBytes(bytes_ClassRoom.Length);
            stream.Write(bytes_lengClassRoom, 0, 4);
            stream.Write(bytes_ClassRoom, 0, bytes_ClassRoom.Length);
         }
         public void Save1(Stream stream)
         {
            var bytes_StudenID = Encoding.UTF8.GetBytes(StudenID);
            var bytes_leng = BitConverter.GetBytes(bytes_StudenID.Length);
            stream.Write(bytes_leng, 0, 4);
            stream.Write(bytes_StudenID, 0, bytes_StudenID.Length);

            var bytes_FirstName = Encoding.UTF8.GetBytes(FirstName);
            var bytes_lengName = BitConverter.GetBytes(bytes_FirstName.Length);
            stream.Write(bytes_lengName, 0, 4);
            stream.Write(bytes_FirstName, 0, bytes_FirstName.Length);

            var bytes_MiddName = Encoding.UTF8.GetBytes(MiddName);
            var bytes_lengMName = BitConverter.GetBytes(bytes_MiddName.Length);
            stream.Write(bytes_lengMName, 0, 4);
            stream.Write(bytes_MiddName, 0, bytes_MiddName.Length);

            var bytes_LastName = Encoding.UTF8.GetBytes(LastName);
            var bytes_lengLName = BitConverter.GetBytes(bytes_LastName.Length);
            stream.Write(bytes_lengLName, 0, 4);
            stream.Write(bytes_LastName, 0, bytes_LastName.Length);

            var bytes_Birthday = Encoding.UTF8.GetBytes(Birthday);
            var bytes_lengBirthday = BitConverter.GetBytes(bytes_Birthday.Length);
            stream.Write(bytes_lengBirthday, 0, 4);
            stream.Write(bytes_Birthday, 0, bytes_Birthday.Length);

            var bytes_Address = Encoding.UTF8.GetBytes(Address);
            var bytes_lengAddress = BitConverter.GetBytes(bytes_Address.Length);
            stream.Write(bytes_lengAddress, 0, 4);
            stream.Write(bytes_Address, 0, bytes_Address.Length);

            var bytes_Phone = Encoding.UTF8.GetBytes(Phone);
            var bytes_lengPhone = BitConverter.GetBytes(bytes_Phone.Length);
            stream.Write(bytes_lengPhone, 0, 4);
            stream.Write(bytes_Phone, 0, bytes_Phone.Length);

            var bytes_Email = Encoding.UTF8.GetBytes(Email);
            var bytes_lengEmail = BitConverter.GetBytes(bytes_Email.Length);
            stream.Write(bytes_lengEmail, 0, 4);
            stream.Write(bytes_Email, 0, bytes_Email.Length);

            var bytes_Note = Encoding.UTF8.GetBytes(Note);
            var bytes_lengNote = BitConverter.GetBytes(bytes_Note.Length);
            stream.Write(bytes_lengNote, 0, 4);
            stream.Write(bytes_Note, 0, bytes_Note.Length);

            var bytes_Status = Encoding.UTF8.GetBytes(Status);
            var bytes_lengStatus = BitConverter.GetBytes(bytes_Status.Length);
            stream.Write(bytes_lengStatus, 0, 4);
            stream.Write(bytes_Status, 0, bytes_Status.Length);
 
         }

         public void AddStuden(string StudenID,string FirstName,string MiddName,string LastName,string Birthday,string Address,
         string Phone,string Email,string Note,string ClassName,string Status,string StudyDay,string StudyTime,string ClassRoom)
         {
             this.StudenID = StudenID;
             this.FirstName = FirstName;
             this.MiddName = MiddName;
             this.LastName = LastName;
             this.Birthday = Birthday;
             this.Address = Address;
             this.Phone = Phone;
             this.Email = Email;
             this.ClassName = ClassName;
             this.Note = Note;
             this.Status = Status;
             this.StudyDay = StudyDay;
             this.StudyTime = StudyTime;
             this.ClassRoom = ClassRoom;
         }
             public virtual void InputClass()
             {
                Console.Write("Study day:");
                this.StudyDay = Console.ReadLine();
                Console.Write("Study time:");
                this.StudyTime = Console.ReadLine();
                Console.Write("Class room:");
                this.ClassRoom = Console.ReadLine();
                Console.Write("Status:");
                this.Status = Console.ReadLine();
             }
             public virtual void InputStuden()
         {
             Console.Write("Studen ID:");
             this.StudenID = Console.ReadLine();
             Console.Write("First Name:");
             this.FirstName = Console.ReadLine();
             Console.Write("Midd Name:");
             this.MiddName = Console.ReadLine();
             Console.Write("Last Name:");
             this.LastName = Console.ReadLine();
             Console.Write("Birthday:");
             this.Birthday = Console.ReadLine();
             Console.Write("Address:");
             this.Address = Console.ReadLine();
             Console.Write("Phone:");
             this.Phone = Console.ReadLine();
             Console.Write("Email:");
             this.Email = Console.ReadLine();
             Console.Write("Class Name:");
             this.ClassName = Console.ReadLine();
             Console.Write("Note:");
             this.Note = Console.ReadLine();
         }
         public virtual void OutPutClass()
         {
            Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-10:c} {4,-10:c}",this.ClassName,this.StudyDay,this.StudyTime,this.ClassRoom,this.Status);
         }
         public virtual void OutPutStuden()
         {
            Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-10:c} {4,-10:c}",this.StudenID,this.LastName,this.ClassName,this.Phone,this.Email);
         }
         public void studen()
         {
             List<ListStuden> studens = new List<ListStuden>();
             MainMenu menu = new MainMenu();
             menu.MenuManager();
             var chon = 0;
             var chon1 = 0;
             var chon2 = 0;
             do{
                 Console.Write("#YOUR CHOICE:");
                 chon = int.Parse(Console.ReadLine());
             switch(chon){
                 case 1:{
                     MainMenu menu1 = new MainMenu();
                     menu1.MenuStuden();
                     do{
                     Console.Write("#YOUR CHOICE:");
                     chon1 = int.Parse(Console.ReadLine());
                     switch(chon1){
                         case 1:{
                             Console.WriteLine("========================================");
                             Console.WriteLine("NEW STUDEN");
                             Console.WriteLine("========================================");
                             InputStuden();
                             var t = new ListStuden()
                             {
                                StudenID = this.StudenID,
                                LastName = this.LastName,
                                ClassName = this.ClassName,
                                Phone = this.Phone,
                                Email = this.Email,
                             };
                             studens.Add(t);
                             string c;
                             do{
                                Console.WriteLine("Add studen complete!");
                                Console.Write($"Do you want to cotinue?(Y/N):");
                                c=Console.ReadLine();
                             }while(c!="Y");
                            //  if(c=="N")
                            //  {
                            //     for(int i=0;i<studens.Count();i++)
                            //     {
                            //         if(studens[i].StudenID==t.StudenID)
                            //         {
                            //             studens[i]=t;
                            //         }
                            //     }
                            //  }
                            //while(c!="Y");
                             break;
                         }
                         
                         case 2:{
                             Console.Write("studen to search:");
                             //var search;
                             string search=Console.ReadLine();
                             
                                // search = studens.FindAll(
                                //     (e) => {
                                //         return studens.Count()=search;
                                //     }
                                // );
                                // foreach (var n in search)
                                // {
                                //     Console.WriteLine(n);
                                // }
                             
                             
                            //  var se=studens.Find(
                            //     (se) => {
                            //         return se==search;
                            //     }
                            //  );
                             break;
                         }
                         case 3:{
                             Console.WriteLine("==================================================");
                             Console.WriteLine("STUDEN LIST");
                             Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-10:c} {4,-10:c}","|StudenID","|LastName","|Class","|Phone","|Email");
                             int n = studens.Count();
                             for(int i=0;i<n;i++)
                             {
                                studens[i].OutPutStuden();
                             }
                             break;
                         }
                         case 4:{
                             Console.WriteLine("BACK TO MAIN MENU");
                             menu.MenuManager();
                             break;
                         }
                         default:{
                         break;
                         }
                         
                     }
                     }
                     while(chon1!=4);
                     break;
                 }
                 case 2:{
                     MainMenu menu2 = new MainMenu();
                     menu2.MenuClass();
                     do{
                        Console.Write("#YOUR CHOICE:");
                        chon2 = Int32.Parse(Console.ReadLine());
                        switch(chon2)
                        {
                            case 1:
                            {
                                Console.WriteLine("========================================");
                                Console.WriteLine("NEW CLASS");
                                Console.WriteLine("========================================");
                                InputClass();
                                var t1 = new ListStuden()
                                {
                                    ClassName = this.ClassName,
                                    StudyDay = this.StudyDay,
                                    StudyTime = this.StudyTime,
                                    ClassRoom = this.ClassRoom,
                                    Status = this.Status,
                                };
                                studens.Add(t1);
                             string c1;
                             do{
                                Console.WriteLine("Add class complete!");
                                Console.Write($"Do you want to cotinue?(Y/N):");
                                c1=Console.ReadLine();
                             }
                             while(c1!="Y");
                             //while(!(c1=="Y"||c1=="N"));
                            //   if(c1=="N")
                            //   {
                            //      for(int i=0;i<studens.Count();i++)
                            //      {
                            //          if(studens[i].ClassName==t1.ClassName)
                            //         {
                            //              studens[i]=t1;
                            //          }
                            //      }
                            //   }
                              //while(c1!="Y");
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("========================================");
                                Console.WriteLine("STUDYING CLASSES");
                                Console.WriteLine("========================================");
                                Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-11:c} {4,-12:c}","|Class","|Study day","|Study time","|Class room","|Status");
                                int n = studens.Count();
                             for(int i=1;i<n;i++)
                             {
                                studens[i].OutPutClass();
                             }
                                break;
                            }
                            case 3:
                            {
                                break;
                            }
                            case 4:
                            {
                                string close;
                                Console.Write("class to close:");
                                close=Console.ReadLine();

                                        //studens.RemoveAll(close);

                                break;
                            }
                            case 5:
                            {
                                break;
                            }
                            case 6:
                            {
                                Console.WriteLine("BACK TO MAIN MENU");
                                menu.MenuManager();
                                break;
                            }
                            default:{
                         break;
                         }
                        }
                     }
                     while(chon2!=6);
                     break;
                 }
                 case 3:{
                     Console.WriteLine("Exit!");
                     break;
                 }
                 default:{
                     break;
                 }
             }
             }while(chon!=3);
         }
    }
}

