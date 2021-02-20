using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    public delegate Small corvaDel(Big mc);
    public static class Corvariance
    {
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Test Corvariance Method1.");
            return new Big();
        }

        public static Small Method2(Big bg)
        {
            Console.WriteLine("Test Corvariance Method2.");
            return new Small();
        }
    }

    

    public class Small
    {

    }

    public class Big : Small
    {

    }


    public class Bigger : Big
    {

    }
}
