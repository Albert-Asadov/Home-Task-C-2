int naturalEded = 581;
int count = 0;

for (int i = 1; i < naturalEded; i *= 10)
{
    count = i;

}

if (count > 0)
{
    count *= 10;

    int number = 3 * count + naturalEded;
    Console.WriteLine(number);
}
