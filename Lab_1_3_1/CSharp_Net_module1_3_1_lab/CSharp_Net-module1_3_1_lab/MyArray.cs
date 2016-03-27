using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class MyArray
    {
        int[] arr;

        public void Assign(int[] arr, int size)
        {
            // 5) add block try (outside of existing block try)
            try
            {
                try
                {
                    //size = 5;
                    this.arr = new int[size];

                    // 1) assign some value to cell of array arr, which index is out of range

                    for (int i = 0; i <= arr.Length; i++)
                        this.arr[i] = arr[i] / arr[i + 1];

                    this.arr[size + 7] = 5;

                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array

                    unchecked
                    {
                        this.arr[size - 1] = Int32.MaxValue + 1;

                    }


                    //NullReferenceException

                }
                // 2) catch exception index out of rage
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index of array is out of range");
                }

                // 4) catch devision by 0 exception
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You can not divide by zero");
                }

                // 6) add catch block for null reference exception of outside block try  
                // change the code to execute this block (any method of any class)
                catch (NullReferenceException)
                {
                    Console.WriteLine("An object can not be null");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message is {0}", ex.Message);
            }
        }
    }
}
