using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class ClassAndConstructor
    {
        private string name;
        private int age;
        //Default constructor
        public ClassAndConstructor()
        {
            name = default;
            age = default;
        }

        // This will gives you an error in creation of object
        //private ClassAndConstructor()
        //{
        //    name = default;
        //    age = default;
        //}

        //Parameterized constructor
        public ClassAndConstructor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //Copy constructor
        public ClassAndConstructor(ClassAndConstructor obj)
        {
            this.name = obj.name;
            this.age = obj.age;
        }
        //Static constructor
        static ClassAndConstructor()
        {
            Console.WriteLine("Static constructor");
        }
        ~ ClassAndConstructor()
        {
            Console.WriteLine("Iam destructor");
        }
        public void getDetails()
        {
            Console.WriteLine($"Name is {name} and age is {age}");
        }


    }
}
