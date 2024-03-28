// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size, int min, int max) {
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

int CountEvenNum(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count += 1;
        }
    }

    return count;
}

int[]array =  CreateArray(10, 100, 999);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(CountEvenNum(array));