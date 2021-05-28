using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class EncapsulationExample
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;

            }
        }
        public void getDetails()
        {
            Console.WriteLine($"The user name is {name} and age is {age}");
        }

    }
    
}
