// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа

Console.WriteLine("Введите элементы массива, разделив их пробелом");
string InitString = Console.ReadLine();
string[] InitArray;
if (InitString.Contains(" ")) {
    InitArray = InitString.Split(" ");
} else {
    InitArray = new string[] { InitString };
}
int StringsCount = 0;
for (int i = 0; i < InitArray.Length; i++) {
    if (InitArray[i].Length <= 3) StringsCount++;
}
string[] ResultArray = new string[StringsCount];
int CurrentElement = 0;
for (int m = 0; m < InitArray.Length; m++) {
    if (InitArray[m].Length <= 3) {
        ResultArray[CurrentElement] = InitArray[m];
        CurrentElement++;
    }
}
Console.WriteLine($"{PrintArray(InitArray)} -> {PrintArray(ResultArray)}");

string PrintArray(string[] array) {
    string arr = "[";
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length > 0) {
            arr += "\"" + array[i] + "\"";
            if (i < array.Length - 1) arr += ", ";
        }
    }
    arr += "]";
    return arr;
}
