public class ClassManager
{
    public string ClassName{set; get;}
    public string ClassRoom{set; get;}
    public string StudyDay{set; get;}
    public string StudyTime{set; get;}
    public string Status{set; get;}
    public void AddClass(string ClassName, string ClassRoom, string StudyDay, string StudyTime, string Status)
    {
        this.ClassName = ClassName;
        this.ClassRoom = ClassRoom;
        this.StudyDay = StudyDay;
        this.StudyTime = StudyTime;
        this.Status = Status;
    }
    public ClassManager()
    {
        this.ClassName = "";
        this.ClassRoom = "";
        this.StudyDay = "";
        this.StudyTime = "";
        this.Status = "";
    }
    public virtual void InputClass()
    {
        Console.Write("Class Name:");
        this.ClassName = Console.ReadLine()??"";
        Console.Write("Class Room:");
        this.ClassRoom = Console.ReadLine()??"";
        Console.Write("StudyDay:");
        this.StudyDay = Console.ReadLine()??"";
        Console.Write("StudyTime:");
        this.StudyTime = Console.ReadLine()??"";
        Console.Write("Status:");
        this.Status = Console.ReadLine()??"";
    }
    public virtual void OutPutClass()
         {
            Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-10:c} {4,-10:c}",this.ClassName,this.StudyDay,this.StudyTime,this.ClassRoom,this.Status);
         }
         
}