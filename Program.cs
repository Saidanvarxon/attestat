// Итоговая контрольная работа по основному блоку

/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/



using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод первоначального массива с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        
         // Фильтрация массива
        string[] result = FilterShortStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Результат:");
        Console.WriteLine("[{0}]", string.Join(", ", result));
       
    }
    static string[] FilterShortStrings(string[] arr)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
    }
}