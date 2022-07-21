// See https://aka.ms/new-console-template for more information
using DieRoller;
Die myDie = new Die();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);

myDie.IsHeld = true;
Console.WriteLine("Holding the die********************");
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);

Console.ReadKey();