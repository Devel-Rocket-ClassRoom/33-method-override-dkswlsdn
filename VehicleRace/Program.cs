using System;

Vihicle[] vihicles = new Vihicle[3];
vihicles[0] = new Car("스포츠카");
vihicles[1] = new Airplane("보잉747");
vihicles[2] = new Boat("요트");

foreach (var v in vihicles)
{
    v.Move();
}