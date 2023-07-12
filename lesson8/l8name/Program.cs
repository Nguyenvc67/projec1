using Animal;

Mouse m1 = new Mouse();
Console.WriteLine($"m1.MakeSound() -> {m1.MakeSound()}");

Hardware.Mouse m2 = new Hardware.Mouse();
Console.WriteLine($"21.click() -> {m2.Click(1)}");
