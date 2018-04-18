using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";  
            string firstname = "";
            string middlename = "";
            string lastname = "";

            Console.WriteLine("Please enter the name: first middle last (Enter 'QQQ' to stop)");
            fullname = Console.ReadLine();
            
            do
            {

                string[] name = fullname.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                

                if (name.Length >= 3)
                {

                    firstname = name[0].Substring(0, 1).ToUpper() + name[0].Substring(1);
                    middlename = name[1].Substring(0, 1).ToUpper() + name[1].Substring(1);

                    if (name.Length == 4)
                    {
                        lastname = String.Format("{0}-{1}", name[2].Substring(0, 1).ToUpper() + name[2].Substring(1), name[3].Substring(0, 1).ToUpper() + name[3].Substring(1));

                    }
                    else
                    {
                        lastname = name[2].Substring(0, 1).ToUpper() + name[2].Substring(1);
                    }

                    //name plate

                    Console.WriteLine(String.Format("The name for the name plate is {0} {1} {2}", firstname, middlename, lastname));

                    //company directory

                    Console.WriteLine(String.Format("The name for the company directory is {0}, {1} {2}.", lastname, firstname, middlename.Substring(0, 1)));

                    //user id

                    string id = firstname.Substring(0, 1) + middlename.Substring(0, 1) + lastname.Substring(0, 1);

                    Console.WriteLine(String.Format("The initials for the user id are {0}", id.ToLower()));

                    //email address

                    string email = lastname.Substring(0, Math.Min(5, lastname.Length)).ToLower() + firstname.Substring(0, Math.Min(2, firstname.Length)).ToLower() + (firstname.Length - 1) + (middlename.Length - 1) + (lastname.Length - 1);

                    Console.WriteLine("The new email address is {0}@apexpaper.com", email);

                }
                else
                {
                    firstname = name[0].Substring(0, 1).ToUpper() + name[0].Substring(1);
                    lastname = name[1].Substring(0, 1).ToUpper() + name[1].Substring(1);

                    //name plate

                    Console.WriteLine(String.Format("The name for the name plate is {0} {1}", firstname, lastname));

                    //company directory

                    Console.WriteLine(String.Format("The name for the company directory is {0}, {1}", lastname, firstname));

                    //user id

                    string id = firstname.Substring(0, 1) + lastname.Substring(0, 1);

                    Console.WriteLine(String.Format("The initials for the user id are {0}", id.ToLower()));

                    //email address

                    string email = lastname.Substring(0, Math.Min(5, lastname.Length)).ToLower() + firstname.Substring(0, Math.Min(2, lastname.Length)).ToLower() + (firstname.Length - 1) + (lastname.Length - 1);

                    Console.WriteLine("The new email address is {0}@apexpaper.com", email);

                }


                fullname = Console.ReadLine();

            } while (fullname != "QQQ"); 

        }
    }
}
