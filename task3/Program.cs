// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] ReverseArray(int[] array) {
    for (int i = 0; i <= array.Length / 2; i++) {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

    return array;
}

int[] array = CreateArray(9, 1, 10);
PrintArray(array);
ReverseArray(array);
Console.WriteLine("");
PrintArray(array);