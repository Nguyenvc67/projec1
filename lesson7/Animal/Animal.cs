public abstract class Animal{
    public string Name{set;get;}
    public Animal(){
        Name = "No Name";
    }
    public abstract string MakeSound();
}