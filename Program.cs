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
string[] arrstrfin = new string[LengthOfArray];


//Формирование стартового массива из строк и решения
for (int i = 0; i < LengthOfArray; i++)
{
    
    arrstr[i] = PromptString("введите элемент массива: ");
    if (arrstr[i].Length <=3)
    {
    arrstrfin[i] = arrstr[i];
    
    }
}
//Вывод только нужных элементов в правильном формате
for (int j = 0; j < arrstrfin.Length; j++)
{
   if(string.IsNullOrEmpty(arrstrfin[j])) 
   {
    System.Console.Write("");
   }else{
System.Console.Write(arrstrfin[j] + "; ");
   }
   
}

