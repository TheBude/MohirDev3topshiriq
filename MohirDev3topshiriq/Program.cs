//1-misol minut=>soat
Console.WriteLine("Bu daqiqani soatga aylantiradigan dastur!");

Console.Write("Daqiqani Kiriting: ");
int time = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{time} daqiqa => procressing... Soat");

int hours = time / 60;
int min = hours * 60;
int cal = time - min;
Console.WriteLine($"soatga aylantirilganda: {hours} : {cal}");