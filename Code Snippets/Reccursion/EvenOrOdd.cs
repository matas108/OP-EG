   // EvenAndOdd(2, n); for even numbers
   // EvenAndOdd(1, n); for odd numbers
   // n - until how many numbers to check

   static void EvenAndOdd(int stVal, int n)
   {
       if (stVal > n)
           return;

       EvenAndOdd(stVal + 2, n);
   }