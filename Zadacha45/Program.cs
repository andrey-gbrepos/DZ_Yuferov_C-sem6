/* Задача 45: Напишите программу,
которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int Sz = int.Parse(Console.ReadLine());
int[] startArr = new int[Sz]; //Исходный массив
int[] finshArr = new int[Sz]; //Массив для копирования
FillingAr (startArr); //Заполняем исходный массив
outArray (startArr); //Выводим содержимое обоих 
outArray (finshArr); //массивов для контроля
copyArray(startArr, finshArr); //поэлементное копирование массива
Console.WriteLine("Результат копирования");
outArray (startArr); 
outArray (finshArr); 



void copyArray(int[] arStart, int[] arFinish)
{
    for (int i = 0; i < arStart.Length; i++) arFinish[i] = arStart[i];
}


void outArray (int[] ar)
{                                         
    for (int j = 0; j < ar.Length; j++) Console.Write(($"{ar[j]}, ")); 
    
                                        Console.WriteLine();
}




void FillingAr (int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(0,21);
    }
}