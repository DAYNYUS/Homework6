// Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] StringToNumbers(string input)
{
    int countNumbers = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
        {
            countNumbers++;
        }
    }

    int[] numbers = new int[countNumbers];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string tempString = " ";
        
        while(input[i] != ',')
        {
            if(i != input.Length - 1)
            {
                tempString += input[i].ToString();
                i++;
            }
            else
            {
                tempString += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(tempString);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNumbers(Console.ReadLine());
/*PrintArray(numbers);*/

int num = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) num++;
}

Console.Write($"Количество чисел больше 0: {num}");








/*Console.Write("Введите пять чисел: ");
string numbers = Console.ReadLine();
char[]text = numbers.ToCharArray();


/*string Replace(string numbers, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        int count = 0;
        if(numbers[i] > 0) count++;
    }

    return result;
}

string newText = Replace(numbers, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();*/



/*newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);




