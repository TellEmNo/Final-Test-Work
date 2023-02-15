void ThreeCharOrLess(int n)
{
    string[] stringArray = new string[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < n; i++)
        stringArray[i] = Convert.ToString(Console.ReadLine());
    Console.WriteLine();

    string[] newStringArray = new string[n];
    for (int i = 0, j = 0; i < n; i++, j++)
    {
        if (stringArray[i].Length <= 3)
        {
            newStringArray[j] = stringArray[i];
            Console.Write(newStringArray[j] + " ");
        }
        else j--;
    };
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
ThreeCharOrLess(n);
