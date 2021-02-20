using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    public static class TestAnonymousMethods
    {
        public delegate void Print(int value);
        public static void DoFunction()
        {
            Print print = delegate (int value)
            {
                Console.WriteLine($"Inside Anonymous methods. Value: {value}");
            };

            if(DateTime.Now.Day % 2 == 0)
            {
                print(100);
            }
            else
            {
                print(101);
            }

            //pass delegate function to other function
            PassDelegateFunctionAsArgument(delegate (int val)
            {
                Console.WriteLine("Inside Function passed delegate function! Value: {0}", val);
            }, 1000);

        }

        public static void PassDelegateFunctionAsArgument(Print print, int val)
        {
            print(val);
        }
    }
}
