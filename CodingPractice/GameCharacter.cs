using System;
using System.Collections.Generic;
using System.Text;

public class GameCharacter
{
    public string Name;
    public int AttackPower;


    public virtual void Attack()
    {
        Console.WriteLine($"데미지: {AttackPower}");
    }

    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}


public class Warrior : GameCharacter
{
    public override void Attack()
    {
        Console.Write($"{Name}이(가) 칼로 베어냅니다!");
        base.Attack();
    }
}

public class Mage : GameCharacter
{
    public override void Attack()
    {
        Console.Write($"{Name}이(가) 파이어볼을 시전합니다!");
        base.Attack();
    }
}

public class Archer : GameCharacter
{
    public override void Attack()
    {
        Console.Write($"{Name}이(가) 화살을 쏩니다!");
        base.Attack();
    }
}