public static int SumOfTen(int min, int max)
{
    return CalcuSum(min, max);
}

public static int CalcuSum(int min, int val)
{
    if (val == min)
        return val;
    return val + CalcuSum(min, val - 1);
}