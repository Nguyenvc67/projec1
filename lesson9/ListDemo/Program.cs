using System.Collections;
ArrayList al = new ArrayList();

al.Add(new Contact(){
    FirsName = "A",
    MiddName = "Cong",
    LastName = "Tran"
});

al.Add(new Contact(){
    FirsName = "A",
    MiddName = "Cong",
    LastName = "Nguyen"
});

al.Add(new Contact(){
    FirsName = "B",
    MiddName = "Cong",
    LastName = "Tran"
});

al.Add(new Contact(){
    FirsName = "A",
    MiddName = "Cong",
    LastName = "Tran"
});
foreach(var e in al){
    Console.WriteLine(e);
}

Contact c = new Contact(){
    FirsName = "A",
    MiddName = "Cong",
    LastName = "Nguyen"
};
Console.WriteLine($"Index of c in al: {al.IndexOf(c)}");

al.Sort();
foreach(var e in al){
    Console.WriteLine(e);
}