int n = 1;
int m = 3;

// 1 + 2 + 3 = 6

int sum = CalculateSumRecursively(n, m);

public static int CalculateSumRecursively(int n, int m)
{
    int sum = n;

    if (n < m)
    {
        n++;
        return sum += CalculateSumRecursively(n, m);
    }

    return sum;
}