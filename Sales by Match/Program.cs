using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_by_Match
{
    class Program
    {
        /* Complete the 'sockMerchant' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER n
    *  2. INTEGER_ARRAY ar
    *  9
    *  10 20 20 10 10 30 50 10 20
    */

        //public static int sockMerchant(int n, List<int> ar)
        //{
        //    int evencount = 0;
        //    int max = ar.Max()+1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (ar[i] == max)
        //            continue;
        //            for (int j = i+1; j < n; j++)
        //            {
        //                if (ar[i] == ar[j])
        //                {
        //                    evencount++;
        //                    ar[i] = max;
        //                    ar[j] = max;
        //                    break;
        //                }
        //        }

                  
               

        //    }

        //    return evencount;
        //}

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(A);
            int ans = 0;
            for (int i = 1; i < n; i++)
            {
                if (A[i] == A[i - 1]) { ans++; i++; }
            }
            Console.WriteLine(ans);

        }
    }
}
