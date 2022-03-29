Console.WriteLine("Сколько лет тебе, путник?");
double Age = Convert.ToDouble(Console.ReadLine());
var Numbered_days = (100.00 * 365.25)-Age;
Random rnd = new Random();
double Smert = Math.Floor((0 + rnd.NextDouble() * (Numbered_days)));
Console.WriteLine($"Жить тебе осталось {Smert}");