using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace ManagerStuden
{
    class Program
    {
        static void Main(string[] args)
        {
            StudenManager s = new StudenManager();
            ClassManager c = new ClassManager();
            List<StudenManager> studens = new List<StudenManager>();
            List<ClassManager> classes = new List<ClassManager>();
            string path = "class.dat";
            using var stream = new FileStream(path: path,FileMode.OpenOrCreate);
            string path1 = "studens.dat";
            using var stream1 = new FileStream(path: path1,FileMode.OpenOrCreate);
            MainMenu menu = new MainMenu();
            menu.MenuManager();
            var chon = 0;
            var chon1 = 0;
            var chon2 = 0;
             do{
                Console.Write("#YOUR CHOICE:");
                chon = int.Parse(Console.ReadLine()??"");
            switch(chon){
                 case 1:{
                    MainMenu menu1 = new MainMenu();
                    menu1.MenuStuden();
                    do{
                    Console.Write("#YOUR CHOICE:");
                    chon1 = int.Parse(Console.ReadLine()??"");
                    switch(chon1){
                        case 1:{
                            Console.WriteLine("========================================");
                            Console.WriteLine("NEW STUDEN");
                            Console.WriteLine("========================================");
                            s.InputStuden();
                            
                            studens.Add(s);
                            string k;
                            do{
                                Console.WriteLine("Add studen complete!");
                                Console.Write("Do you want to cotinue?(Y/N):");
                                k=Console.ReadLine()??"";
                                if(k!="N")
                                {
                                    break;
                                }
                            }while(k!="Y");
                            break;
                        }
                         
                        case 2:{
                            Console.Write("studen to search:");
                            string search=Console.ReadLine()??"";
                            break;
                        }
                        case 3:{
                            Console.WriteLine("==================================================");
                            Console.WriteLine("STUDEN LIST");
                            Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-10:c}","|StudenID","|LastName","|Phone","|Email");
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
                        chon2 = int.Parse(Console.ReadLine()??"");
                        switch(chon2)
                        {
                            case 1:
                            {
                                Console.WriteLine("========================================");
                                Console.WriteLine("NEW CLASS");
                                Console.WriteLine("========================================");
                                c.InputClass();
                                
                                classes.Add(c);
                            string c1;
                            do{
                                Console.WriteLine("Add class complete!");
                                Console.Write("Do you want to cotinue?(Y/N):");
                                c1=Console.ReadLine()??"";
                                if(c1!="N"){
                                    break;
                                }
                            }
                            while(c1!="Y");
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("========================================");
                                Console.WriteLine("STUDYING CLASSES");
                                Console.WriteLine("========================================");
                                Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-11:c} {4,-12:c}","|Class","|Study day","|Study time","|Class room","|Status");
                                int n = classes.Count();
                            for(int i=0;i<n;i++)
                            {
                                classes[i].OutPutClass();
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
                                close=Console.ReadLine()??"";

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
