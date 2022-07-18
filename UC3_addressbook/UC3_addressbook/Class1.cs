﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_addressbook

{
    public class Contacts
    {
        public String firstname;
        public String lastname;
        public String email;
        public int phone;
        public int zip;
        public String city;
        public String state;
        public String address;

        public Contacts(string firstname, string lastname, string email, int phone, int zip, string city, string state, string address)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.zip = zip;
            this.city = city;
            this.state = state;
            this.address = address;
        }

    }


    public class Addressbook
    {

        //private LinkedList<Contacts> contactlist;
        private List<Contacts> contact;

        //List<Contacts> remove_boo = new List<Contacts>();
        //List<Contacts> add_book = new List<Contacts>();

        public Addressbook()
        {
            this.contact = new List<Contacts>();
        }
        public void addcontact(string firstname, string lastname, string email, int phone, int zip, string city, string state, string address)
        {
            Contacts contacts = new Contacts(firstname, lastname, email, phone, zip, city, state, address);
            this.contact.Add(contacts);

        }
        
        public void edit(string fname,string lname)
        {
            foreach (Contacts contact in this.contact)
            {
                if(fname==contact.firstname && lname == contact.lastname)
                {
                    Console.WriteLine("edit your contacts");
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
                    Console.WriteLine("write 1 if you want to display your edited address book");
                    int ans = Convert.ToInt32(Console.ReadLine());
                    if (ans == 1)
                    {
                        addressbook.display();
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }


                }
                else
                {
                    Console.WriteLine("contact not found");
                }
            }
            
            
        }
        public void display()
        {

            foreach (Contacts contact in this.contact)
            {

                Console.WriteLine("name : {0} {1}", contact.firstname, contact.lastname);
                //Console.WriteLine($"last name {contact.lastname}");
                Console.WriteLine("emaailaddress :{0}", contact.email);
                Console.WriteLine("mobile number : {0}", contact.phone);
                Console.WriteLine("zipcode : {0}", contact.zip);
                Console.WriteLine("address : {0}, {1} , {2}", contact.address, contact.city, contact.state);
                /*Console.WriteLine(contact.city);
                Console.WriteLine(contact.state);
                Console.WriteLine(contact.address);
                */
            }
            Console.WriteLine(" ");
            Console.WriteLine("want to edit the contact list (y/n)");
            char n = Convert.ToChar(Console.ReadLine());
            if (n == 'y')
            {
                Console.WriteLine("enter the first name you want to change your details : ");
                string fname = Convert.ToString(Console.ReadLine());

                Console.WriteLine("enter the first name you want to change your details : ");
                string lname = Convert.ToString(Console.ReadLine());
                edit(fname, lname);

            }
            else
            {
                Console.WriteLine("close your adress book");
            }

            
        }
    }
}
