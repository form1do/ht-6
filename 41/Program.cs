// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 string Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

double [] CreateArray (int lenght)
{
    var array = new double[lenght];
    for (var i = 0; i < array.Length; i++) { 
      
        Console.WriteLine($"Введите  {i+1}ое число");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void PromtArray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.Write($"{array[array.Length-1]}]");
    System.Console.WriteLine();
}

int CountPositiveNumbers (double [] array)
{
   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count += 1;
    }
    return count;
}

int lengthArray = Convert.ToInt32(Prompt("Введите длину массива > "));
double [] array = CreateArray(lengthArray);
PromtArray(array);
Console.WriteLine($"{CountPositiveNumbers(array)} чисел больше нуля"); 
