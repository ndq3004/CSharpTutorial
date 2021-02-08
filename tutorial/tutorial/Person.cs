using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    abstract class Person
    {
        int age;
        string name;
        //public Person(int age, string name)
        //{
        //    //this.age = age;
        //    //this.name = name;
        //}
        //public static int countPerson;
        public virtual void callMe()
        {
            Console.WriteLine("person call");
        }

        public virtual void callMe(string message)
        {
            Console.WriteLine($"Person call with message: {message}");
        }

        public virtual void overrideMe()
        {
            Console.WriteLine("call me babe");
        }

        public abstract void raiseHand();

        ~ Person()
        {
            Console.WriteLine("Huy Person");
        }
    }

    class AsianPerson : Person
    {
        //int age;
        //string name;
        //string skin;
        public static int countAP;
        public AsianPerson()
        {
            countAP++;
        }
        public override void callMe()
        {
            Console.WriteLine("AsianPerson call");
        }

        public override void raiseHand()
        {

        }

        public override void overrideMe()
        {
            //base.overrideMe();
            Console.WriteLine("hey dont forget!");
        }

        ~ AsianPerson()
        {
            Console.WriteLine("huy!");
        }
    }

    class EropeanPerson
    {
        //EropeanPerson()
        //{
        //    Console.WriteLine("create");
        //}
        ~EropeanPerson()
        {
            Console.WriteLine("call des");
        }
    }

    class Animal
    {
        protected int age;
        public Animal()
        {

        }
        public Animal(int age)
        {
            this.age = age;
        }

        public void info()
        {
            Console.WriteLine("This is animal!");
        }
    }

    class Cat : Animal
    {
        public string color;
        public Cat()
        {
            age = 10;
            color = "Blue";
            base.info();
        }

        public Cat(int age) : base(age)
        {
            this.age += 5;
            base.info();
            Console.WriteLine(base.age);
        }

        public void info()
        {
            Console.WriteLine("This is cat!");
        }

        public void catInfo()
        {
            Console.WriteLine("Cat info here!");
        }
    }
}
