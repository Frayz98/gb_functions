// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.WriteLine("Введите целое число, либо q для выхода");

string GetKeyboardValue() {
    return Console.ReadLine();
}

int GetNumberSum(int num) {
    int sum = 0;
    while (num > 0) {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

while (true) {
    string value = GetKeyboardValue();
    if (value == "q") {
        Console.WriteLine("Введено q. Выполняем выход из программы");
        break;
    }

    if (int.TryParse(value, out int num)) {
        int sum = GetNumberSum(num);

        if (sum % 2 == 0) {
            Console.WriteLine("Сумма цифр числа четная. Выполняем выход из программы");
            break;
        }
    } else {
        Console.WriteLine("Некорректный ввод. Повторите попытку...");
    }
}