using System;
using System.Collections.Generic;
using System.Text;

public class Vihicle
{
    public string Name { get; set; }
    public int Speed { get; set; }


    public Vihicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }


    public virtual void Move()
    {
        Console.WriteLine($"{Name}이(가) 이동합니다. 속도: {Speed}km/h");
    }
}


public class Car : Vihicle
{
    public Car(string name) : base(name, 120)
    {
        Name = name;
    }


    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}

public class Airplane : Vihicle
{
    public Airplane(string name) : base(name, 900)
    {
        Name = name;
    }


    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}

public class Boat : Vihicle
{
    public Boat(string name) : base(name, 60)
    {
        Name = name;
    }


    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도: {Speed}km/h");
    }
}