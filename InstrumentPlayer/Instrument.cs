using System;
using System.Collections.Generic;
using System.Text;

public class Instrument
{
    protected string _name;


    public Instrument(string name)
    {
        _name = name;
    }


    public virtual void Play() => Console.WriteLine($"{_name}을(를) 연주합니다");

    public virtual void Tune() => Console.WriteLine($"{_name}을(를) 조율합니다");


}


public class Piano : Instrument
{
    public Piano() : base("피아노") { }

    public override void Play() => Console.WriteLine($"{_name} 건반을 누릅니다 - 딩동댕~");

    public override void Tune() => Console.WriteLine($"{_name} 현을 조율합니다");
}

public class Guitar : Instrument
{
    public Guitar() : base("기타") { }

    public override void Play() => Console.WriteLine($"{_name} 줄을 튕깁니다 - 통통통~");

    public override void Tune() => Console.WriteLine($"{_name} 줄을 조율합니다");
}

public class Drum : Instrument
{
    public Drum() : base("드럼") { }

    public override void Play() => Console.WriteLine($"{_name}을 두드립니다 - 둥둥둥~");

    public override void Tune() => Console.WriteLine($"{_name}을(를) 조율합니다");
}