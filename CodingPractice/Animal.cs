using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
}

public class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
}