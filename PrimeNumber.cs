using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp
{
    public class PrimeNumber
    {
        public bool IsPrime(int n)
        {
            if (n <= 1) 
                return false; 
            if(n == 2)
                return true;

            for (int i = 2; i <= n/2; i++)
            {
                if(n%i == 0)
                    return false;
            }
            return true;

        }

    }
}
