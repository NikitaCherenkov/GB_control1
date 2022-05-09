// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа

Console.WriteLine("Введите элементы массива, разделив их пробелом");
string InitString = Console.ReadLine();
string[] array = InitString.Split(" ");
for (int i = 0; i < array.Length; i++) {
    Console.WriteLine($"{array.Length} {array[i]}");
}