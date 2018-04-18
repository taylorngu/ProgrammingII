using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books
{
    abstract class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public virtual double PRICE {get; set;}

        public override bool Equals(object obj)
        {

            if (obj == null)
            { 
            
            return false;

            }
            else if (obj.GetType() == obj.GetType() && obj.ToString() == this.ToString())
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

    class TextBook : Book
    {
        public string grade { get; set; }

        private double price;
        public override double PRICE
        {
            get { return price; }
            set
            {
                if ((value >= 20.00) && (value <= 80.00))
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

            public override string  ToString()
            {
                return String.Format("Type of Book: Textbook \nISBN: {0} \nTitle: {1} \nAuthor: {2}  \nGrade Level: {3} \nPrice: {4:F2}", isbn, title, author, price, grade);
            }

        }

        class CoffeeTableBook : Book
        {
            private double price;
            public override double PRICE
            {
                get { return price; }
                set
                {
                    if ((value >= 35.00) && (value <= 100.00))
                    {
                        price = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
            }

                public override string ToString()
            {
 	            return String.Format("Type of Book: Coffee Table Book \nISBN: {0} \nTitle: {1} \nAuthor: {2} \nPrice: {3:F2}", isbn, title, author, price);
            }




        }
        class Program
        {
            static void Main(string[] args)
            {

                try 
                
                { 
                
                    Console.WriteLine("Please enter the type of book (textbook/coffee)");
                    string check = Console.ReadLine();

                    if (check == "textbook")
                    { 
                    
                        TextBook txt = new TextBook();
                        Console.WriteLine("Enter the ISBN of your book");
                        txt.isbn = Console.ReadLine();
                        Console.WriteLine("Enter the title of your book");
                        txt.title = Console.ReadLine();
                        Console.WriteLine("Enter the author of your book");
                        txt.author = Console.ReadLine();
                        Console.WriteLine("Enter price of your book");
                        txt.PRICE = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter grade level");
                        txt.grade = Console.ReadLine();

                        Console.WriteLine(txt.ToString());

                    
                    }
                    else if (check == "coffee")
                    {
                        CoffeeTableBook coffee = new CoffeeTableBook();
                        Console.WriteLine("Enter the ISBN of your book");
                        coffee.isbn = Console.ReadLine();
                        Console.WriteLine("Enter the title of your book");
                        coffee.title = Console.ReadLine();
                        Console.WriteLine("Enter the author of your book");
                        coffee.author = Console.ReadLine();
                        Console.WriteLine("Enter price of your book");
                        coffee.PRICE = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(coffee.ToString());

                    }
                    else
                    {

                        Console.WriteLine("Please enter a correct book type");

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

                catch (ArgumentException)
                {

                    Console.WriteLine("The price of your book is is less than or exceeds \n the price limitations for your book type");

                }


            }
        }
    


