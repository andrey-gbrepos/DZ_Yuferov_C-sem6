//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите c клавиатуры несколько разных чисел через пробел и нажмите 'Enter'");
string elements = Console.ReadLine();
Console.WriteLine($"Введен массив из {numArr(elements).Length} чисел. Из них {posQuant(numArr(elements))} положительных.");


int posQuant (double[] arr) //Подсчет положительных значений в массиве
{
    int i = 0;
    for (int j = 0; j < arr.Length; j++)
    {
      if (arr[j] >= 0) i++;
    }
    return i;
}

double[] numArr (string elem)// Перевод строки в массив double
{
    string[] num = elem.Split(" ");
    double[] sz = new double[num.Length];
    for (int i =0; i < sz.Length; i++)
    {
        sz[i] = Convert.ToDouble(num[i]);
    }
    return sz;
}