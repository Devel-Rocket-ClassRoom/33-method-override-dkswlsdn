using System;

{
    Console.WriteLine("\n==============================");

    Parent parent = new Parent();
    Child child = new Child();

    parent.Work();
    child.Work();
}

{
    Console.WriteLine("\n==============================");

    Animal animal = new Animal();
    Animal cat = new Cat();

    animal.Eat();
    cat.Eat();
}

{
    Console.WriteLine("\n==============================");

    Child2 child = new Child2();
    Parent2 parent = child;

    child.Say();
    child.Run();
    child.Walk();

    parent.Say();
    parent.Run();
    parent.Walk();
}

{
    Console.WriteLine("\n==============================");
    
    Calculator calculator = new Calculator();

    Console.WriteLine(calculator.Add(1, 2));
    Console.WriteLine(calculator.Add(1.5, 2.5));
    Console.WriteLine(calculator.Add(1, 2, 3));
}

{
    Console.WriteLine("\n==============================");

    Animal2 animal = new Animal2();
    Animal2 dog = new Dog2();
    Animal2 cat = new Cat2();

    animal.Speak();
    dog.Speak();
    cat.Speak();
}

{
    Console.WriteLine("\n==============================");

    Child3 child3 = new Child3();
    child3.Greet();
}

{
    Console.WriteLine("\n==============================");

    Parent4 parent4 = new Parent4();
    Child4 child4 = new Child4();
    GrandChild grandChild = new GrandChild();

    parent4.Work();
    child4.Work();
    grandChild.Work();
}

{
    Console.WriteLine("\n==============================");

    new Parent5().Work();
    new Child5().Work();
    new GrandChild5().Work();
    new GrandChild5().Play();
}

{
    Console.WriteLine("\n==============================");

    Person person = new Person { Name = "홍길동" };

    Console.WriteLine(person);
    Console.WriteLine(person.ToString());
}

{
    Console.WriteLine("\n==============================");

    Person2 person = new Person2("박용준");

    Console.WriteLine(person);
}

{
    Console.WriteLine("\n==============================");

    Character hero = new Character("용사", 10, 100);
    Character mage = new Character("마법사", 8, 70);

    Console.WriteLine(hero);
    Console.WriteLine(mage);
}

{
    Console.WriteLine("\n==============================");

    Warrior warrior = new Warrior { Name = "전사", AttackPower = 50 };
    Mage mage = new Mage { Name = "마법사", AttackPower = 60 };
    Archer archer = new Archer { Name = "궁수", AttackPower = 40 };

    Console.WriteLine(warrior);
    Console.WriteLine(mage);
    Console.WriteLine(archer);

    Console.WriteLine();

    warrior.Attack();
    mage.Attack();
    archer.Attack();
}

{
    Console.WriteLine("\n==============================");

    GameCharacter[] gameCharacters = new GameCharacter[]
    {
        new Warrior { Name = "전사", AttackPower = 50 },
        new Mage { Name = "마법사", AttackPower = 60 },
        new Archer { Name = "궁수", AttackPower = 40 }
    };

    Console.WriteLine("=== 파티 공격 ===");

    foreach (GameCharacter character in gameCharacters)
    {
        character.Attack();
    }
}