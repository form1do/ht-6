//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

string Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

double b1 = Convert.ToDouble(Prompt("значения b1: "));
double k1 = Convert.ToDouble(Prompt("значения k1: "));
double b2 = Convert.ToDouble(Prompt("значения b2: "));
double k2 = Convert.ToDouble(Prompt("значения k2: "));
System.Console.WriteLine();
double х = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

bool Coordinate(double k1, double k2)
{
    if(k1 != k2)
    {
        return true;
    }
    return false;
}

if (Coordinate(k1, k2))
{
    Console.WriteLine($"прямые пересекаются в ({х:f1} ; {y:f1})");
}
else
{
    if (b1 == b2)
    {
        Console.WriteLine("прямые совпадают");
    }
    else
    {
        Console.WriteLine("прямые параллельны");
    }
}
