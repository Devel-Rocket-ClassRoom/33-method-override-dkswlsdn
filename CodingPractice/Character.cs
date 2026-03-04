using System;
using System.Collections.Generic;
using System.Text;

public class Character
{
    public string Name;
    public int Level;
    public int Health;


    public Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }


    public override string ToString()
    {
        return $"[{Name}] Lv.{Level} HP:{Health}";
    }
}