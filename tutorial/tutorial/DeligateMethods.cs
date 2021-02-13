using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    class DeligateMethods
    {
        public delegate void MyDeligate(string msg);
        public delegate int MyDeligateInt();

        MyDeligate del1 = new MyDeligate(MethodA);
        MyDeligate del2 = new MyDeligate(MethodA);
        MyDeligateInt del3 = new MyDeligateInt(MethodB);
        MyDeligateInt del4 = new MyDeligateInt(MethodC);


        public DeligateMethods()
        {
            MyDeligate del = del1 + del2;
            del.Invoke("hello world!");
            MyDeligateInt delInt = del3 + del4;
            Console.WriteLine(delInt());
        }
        static void MethodA(string msg)
        {
            Console.WriteLine(msg);
        }
        static int MethodB()
        {
            return 200;
        }

        static int MethodC()
        {
            return 100;
        }
    }
}
