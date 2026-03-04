using System;
using System.Collections.Generic;
using System.Text;

public class Parent
{
    public virtual void Work() => Console.WriteLine("프로그래머");
}

public class Child : Parent
{
    public override void Work() => Console.WriteLine("프로게이머");
}
