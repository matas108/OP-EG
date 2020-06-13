public static int getDigits(int n1, int nodigits)
{
    if (n1 == 0)
        return nodigits;

    return getDigits(n1 / 10, ++nodigits);
}