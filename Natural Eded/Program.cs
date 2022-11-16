#region Natural Eded
static void number(int naturalEded, int count)
{
    for (int i = 1; i < naturalEded; i *= 10)
    {
        count = i;
    }
    if (count > 0)
    {
        count *= 10;
        int num = 3 * count + naturalEded;
        Console.WriteLine(num);

    }
}

number(569, 0);
#endregion
