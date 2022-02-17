// Задача 20: Задать номер четверти, показать диапазоны для возможных координат

int InPut(string message)
{
    int number = 0;
    bool IsError = true;
    while (IsError)
    {
        Console.WriteLine(message);
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out number)) IsError = number > 4 || number < 1;
    }
    return number;
}


void Execute(int number)
{
    if(number == 1)
        Console.WriteLine("В I четверти диапазон возможных коодинат от Х > 0 и Y > 0");
    else if (number == 2)
        Console.WriteLine("Во II четверти диапазон возможных коодинат от Х < 0 и Y > 0");
    else if (number == 3)
        Console.WriteLine("В III четверти диапазон возможных коодинат от Х < 0 и Y < 0");
    else 
        Console.WriteLine("В IV четверти диапазон возможных коодинат от Х > 0 и Y < 0");

}
int number = InPut("Введите число от 1 до 4: ");
Execute(number);

