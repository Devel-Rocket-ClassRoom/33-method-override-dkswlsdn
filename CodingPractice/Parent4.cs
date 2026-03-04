using System;
using System.Collections.Generic;
using System.Text;

public class Parent4
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

public class Child4 : Parent4
{
    public override void Work()
    {
        base.Work();
    }
}

public class GrandChild : Child4
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}