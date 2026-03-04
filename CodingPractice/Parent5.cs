using System;
using System.Collections.Generic;
using System.Text;

public class Parent5
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

public class Child5 : Parent5
{
    public sealed override void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

public class GrandChild5 : Child5
{
    public void Play()
    {
        Console.WriteLine("프로게이머");
    }
}