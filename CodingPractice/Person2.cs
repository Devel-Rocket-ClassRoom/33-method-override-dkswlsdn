using System;
using System.Collections.Generic;
using System.Text;

public class Person2
{
    private string _name;


    public Person2(string name)
    {
        _name = name;
    }


    public override string ToString()
    {
        return $"[Person 클래스: {_name}]";
    }
}