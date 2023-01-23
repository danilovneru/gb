// See https://aka.ms/new-console-template for more information
var mass = new string[] { "name", "age", "day", "no", "numbers"};

string[] group = Array.FindAll(mass, elem => elem.Length <= 3);
foreach (var elem in group) Console.WriteLine(elem);
