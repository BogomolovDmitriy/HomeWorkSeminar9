


int Number(int num1, int num2)
{
    if (num1 > num2 )
    {
        return 0;
    }
    
    return num1 + Number(num1 + 1, num2);
}

Console.WriteLine(Number(1, 15));
