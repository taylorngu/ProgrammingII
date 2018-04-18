using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomAnimals
{

    abstract class Animals
    {
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }
            else if (o.ToString() == this.ToString() && o.GetType() == this.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
             return base.GetHashCode();
        }

    }
    class Dog : Animals 
    {

        public override string ToString()
        {
            return "Woof woof!";
        }

    }
    class Cat : Animals 
    {

        public override string ToString()
        {
            return "Meow!";
        }
    
    }
    class Bird : Animals 
    {

        public override string ToString()
        {
            return "Tweet!";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Random gen = new System.Random();
            Object[] obj = new Object[10];
            int num = 0;

            for (int n = 0; n < obj.Length; n++)
            {

                num = gen.Next(0, 3);

                switch (num)
                {
                    case 0:

                        obj[n] = new Dog();

                        break;
                    case 1:

                        obj[n] = new Cat();

                        break;
                    case 2:

                        obj[n] = new Bird();

                        break;
                }
            }

            Object prev = null;
            int r = 1;

            foreach (Object o in obj)
            {
                
                if (o.Equals(prev) == true)
                {
                    r++;

                }
                else
                {
                    if (r > 1)
                    {
                        Console.WriteLine("You got {0} in a row!", r);
                    }
                    r = 1;
                }

                Console.WriteLine(o.ToString());


                prev = o;
            }


        }
    }
}
