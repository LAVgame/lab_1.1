
Console.WriteLine("Напиши своё имя прохожий");
string e = Console.ReadLine();
Console.WriteLine($"Привет {e}");
Console.WriteLine("Будем дружить?");
e = Console.ReadLine();
if (e == "да" || e == "Да") 
Console.WriteLine($"CУПЕР привет друг!!");
if (e == "нет" || e == "нет")
    Console.WriteLine($"Ну зато у тебя новый знакомый появился :)");


Console.WriteLine($"Сколько будет 2+2х2 ?");
e = Console.ReadLine();
if (e == "6") Console.WriteLine("Молодец правильно");
else Console.WriteLine("Увы попробуй вследущий раз лучше");
Console.WriteLine($"Хорошо до скорой встречи приятель)");

Console.ReadLine();
