using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionsort
{
      class insertionsortdemo

    {
        static void insert(int[] arr)
        {
            int i, j, temp;
            int n=arr.Length;
            for(i=0;i<n;i++)
            {
                temp=arr[i];
                j = i - 1;
                while (j>=0 && temp <= arr[j])
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = temp;
            }
        }
            static void printsortedarray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
         
         static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 25, 64, 79, 89, 43,1 };
            insert(arr);
            printsortedarray(arr);
            Console.ReadLine();
        }
        
    }
}
