//Метод для ввода строк с клавиатуры
string PromptString(string message)
{
    System.Console.WriteLine($"{message} >");
    return Console.ReadLine();
}
//Метод для ввода чисел
int PromptInt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

//Введите количество строк:
int LengthOfArray = PromptInt("Введите количество строк: ");
string[] arrstr = new string[LengthOfArray];

//Формирование стартового массива из сток
for (int i = 0; i < arrstr.Length; i++)
{
    arrstr[i] = PromptString("введите элемент массива: ");
}
