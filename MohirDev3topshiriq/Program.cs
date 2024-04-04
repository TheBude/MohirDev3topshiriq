//2-misol yoshni toifalash
Console.Write("Salom!\nIsmingizni kiriting =>  ");
string name = Console.ReadLine();

Console.Write($"{name} bu dastur yoshingizni toifalaydi\nYoshingizni Kirting => ");
int age = Convert.ToInt32( Console.ReadLine() );

if (age >= 0 && age <= 12)
{
    Console.WriteLine($"{name} Sizning yoshingiz <bola> lar toifasiga to'g'ri keldi ");
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine($"{name} Sizning yoshingiz <o'smir> lar toifasiga to'g'ri keldi");
}
else if (age >= 20 && age <= 59)
{
    Console.WriteLine($"{name} Sizning yoshingiz <katta> lar toifasiga to'g'ri keldi");
}
else
{
    Console.WriteLine($"{name} Sizning yoshingiz <qariya> lar toifasiga to'g'ri keldi");
}