
class StudenManager
{
    public string StudenID{set; get;}
    public string FastName{set; get;}
    public string MiddName{set; get;}
    public string LastName{set; get;}
    public string Phone{set; get;}
    public string Address{set; get;}
    public string Birthday{set; get;}
    public string Email{set; get;}
    public string Note{set; get;}
    public void AddStuden(string FastName, string MiddName, string LastName, string Birthday, string Email, string Address, string Note, string Phone,string StudenID)
    {
        this.StudenID = StudenID;
        this.FastName = FastName;
        this.MiddName = MiddName;
        this.LastName = LastName;
        this.Address = Address;
        this.Birthday = Birthday;
        this.Email = Email;
        this.Phone = Phone;
        this.Note = Note;
    }
    public StudenManager()
    {
        this.StudenID = "";
        this.FastName = "";
        this.MiddName = "";
        this.LastName = "";
        this.Address = "";
        this.Birthday = "";
        this.Email = "";
        this.Note = "";
        this.Phone = "";
    }
    public virtual void InputStuden()
    {
        Console.Write("Fast Name:");
        this.FastName = Console.ReadLine()??"";
        Console.Write("Midd Name:");
        this.MiddName = Console.ReadLine()??"";
        Console.Write("Last Name:");
        this.LastName = Console.ReadLine()??"";
        Console.Write("Address:");
        this.Address = Console.ReadLine()??"";
        Console.Write("Birthday:");
        this.Birthday = Console.ReadLine()??"";
        Console.Write("Email:");
        this.Email = Console.ReadLine()??"";
        Console.Write("Phone:");
        this.Phone = Console.ReadLine()??"";
        Console.Write("Note:");
        this.Note = Console.ReadLine()??"";
    }
    public virtual void OutPutStuden()
         {
            Console.WriteLine("{0,-10:c} {1,-10:c} {2,-10:c} {3,-10:c}",this.StudenID,this.LastName,this.Phone,this.Email);
         }
    
}
