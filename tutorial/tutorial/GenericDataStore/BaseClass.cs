using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.GenericDataStore
{
    public class BaseClass
    {
        protected int age;

        public BaseClass(int age)
        {
            Age = age;
        }

        public int Age { get => age; set => age = value; }
    }

    class ExtendClass : BaseClass
    {
        public ExtendClass(int age) : base(age)
        {
            Age = age;
        }

        public ExtendClass(string name, int age) : base(age)
        {
            Name1 = name;
            Age = age;
        }

        public string Name1 { get; set; }
    }

    class ExtendClassNoBase
    {

    }
}
