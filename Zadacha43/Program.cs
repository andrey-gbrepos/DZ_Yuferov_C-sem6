//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Программа выведет координаты точки пересечения двух прямых заданных уравнениями");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2;");
Console.WriteLine("");
Console.WriteLine("Введите через пробел k1 b1 k2 b2");
string newdata = Console.ReadLine();
double[] kbMas = numArr(newdata);

if (parallel(kbMas))//Проверка на параллельность
{ 
Console.WriteLine("Прямые параллельны или совпадают");
return;
}
Console.WriteLine();
Console.WriteLine($"Координаты точки пересечения: X {XYcoord(kbMas)[0]}  Y {XYcoord(kbMas)[1]}");

bool parallel (double[] mas) //Проверка на параллельность
{
if (mas[0] == mas[2])
return true;
else 
return false;
}

double[] XYcoord (double[] koef)//Вычисление координат
{
    double[] coord = new double[2];
    coord[0] =Math.Round((koef[3] - koef[1])/(koef[0] - koef[2]), 2);
    coord[1] = Math.Round(koef[0]*coord[0] + koef[1], 2);
    return coord;
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