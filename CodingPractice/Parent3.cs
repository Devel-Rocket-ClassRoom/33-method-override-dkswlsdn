using System;
using System.Collections.Generic;
using System.Text;

public class Parent3
{
    public virtual void Greet() => Console.WriteLine("안녕하세요");
}

public class Child3 : Parent3
{
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다");
    }
}