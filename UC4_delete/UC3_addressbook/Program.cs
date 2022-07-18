using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_addressbook
{

    class Contactadd
    {


        public static void Main(string[] args)
        {

            // printing Welcome Message
            Console.WriteLine("\t\t\t******* WELCOME TO ADDRESS BOOK SYSTEM PROGRAM ******");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("enter your first name - ");
            String firstname = (Console.ReadLine());
            Console.WriteLine("enter your last name - ");
            String lastname = Console.ReadLine();
            Console.WriteLine("enter your email - ");
            String email = Console.ReadLine();
            Console.WriteLine("enter your phone number - ");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your zip code - ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your city - ");
            String city = Console.ReadLine();
            Console.WriteLine("enter your state - ");
            String state = Console.ReadLine();
            Console.WriteLine("enter your address - ");
            String address = Console.ReadLine();
            Addressbook addressbook = new Addressbook();

            addressbook.addcontact(firstname, lastname, email, phone, zip, city, state, address);
            Console.WriteLine("write 1 to diplay your contact book");
            int ans = Convert.ToInt32(Console.ReadLine());
            if(ans == 1)
            {
                addressbook.display();
            }
            else
            {
                Console.WriteLine("invalid");
            }
            

            //to holde the screen
            Console.ReadKey();
        }


    }
}