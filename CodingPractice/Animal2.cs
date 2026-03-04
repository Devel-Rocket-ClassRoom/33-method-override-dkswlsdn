using System;
using System.Collections.Generic;
using System.Text;

public class Animal2
{
    public virtual void Speak() => Console.WriteLine("동물이 소리를 낸다");
}

public class Dog2 : Animal2
{
    public override void Speak() => Console.WriteLine("멍멍!");
}

public class Cat2 : Animal2
{
    public override void Speak() => Console.WriteLine("야옹!");
}