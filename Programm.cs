using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
    class Programm
    {
        Dog dog = new Dog("Cake", new DateTime(2005, 12, 12));
        Console.WriteLine($"Возраст Кейка : {dog.Age} лет ")

        Bird bidy = new Bird("Jem", new DateTime(2004, 7, 9));
        Console.WriteLine($"Возраст Джема: {bidy.Age} лет");


        Fish fsh = new Fish("Bob", new DateTime(2003, 8, 5));
        Console.WriteLine($"Возраст Боба: { fsh.Age} лет");
    }
}
