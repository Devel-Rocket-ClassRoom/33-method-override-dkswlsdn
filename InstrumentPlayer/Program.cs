using System;

Console.WriteLine("=== 악기 연주회 ===");

Instrument[] instruments = new Instrument[3];
instruments[0] = new Piano();
instruments[1] = new Guitar();
instruments[2] = new Drum();

foreach (var instrument in instruments)
{
    instrument.Tune();
    instrument.Play();
    Console.WriteLine();
}