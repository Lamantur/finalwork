string Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Console.ReadLine();
}

string[] arrstr = new string[10];

for (int i = 0; i < arrstr.Length; i++)
{
    arrstr[i] = Prompt("введите элемент массива");
}
