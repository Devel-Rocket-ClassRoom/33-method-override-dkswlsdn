using System;
using System.Collections.Generic;
using System.Text;

public class Parent2
{
    public void Say() => Console.WriteLine("부모_안녕하세요.");

    public void Run() => Console.WriteLine("부모_달리다.");

    public virtual void Walk() => Console.WriteLine("부모_걷다");
}

public class Child2 : Parent2
{
    public new void Say() => Console.WriteLine("자식_안녕하세요.");

    public new void Run() => Console.WriteLine("자식_달리다.");

    public override void Walk() => Console.WriteLine("자식_걷다");
}
