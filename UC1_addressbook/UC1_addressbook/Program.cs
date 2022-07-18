using System;


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

    private LinkedList<Contacts> contactlist;

    public Addressbook()
    {
        this.contactlist = new LinkedList<Contacts>();
    }
    public void addcontact(string firstname, string lastname, string email, int phone, int zip, string city, string state, string address)
    {
        Contacts contacts = new Contacts(firstname, lastname, email, phone, zip, city, state, address);
        this.contactlist.AddLast(contacts);

    }
    public void display()
    {
        
        foreach (Contacts contact in this.contactlist) { 
            
            Console.WriteLine("name : {0} {1}", contact.firstname , contact.lastname);
            //Console.WriteLine($"last name {contact.lastname}");
            Console.WriteLine("emaailaddress :{0}", contact.email);
            Console.WriteLine("mobile number : {0}",contact.phone);
            Console.WriteLine("zipcode : {0}", contact.zip);
            Console.WriteLine("address : {0}, {1} , {2}", contact.address, contact.city , contact.state);
            /*Console.WriteLine(contact.city);
            Console.WriteLine(contact.state);
            Console.WriteLine(contact.address);
            */
        }
    }
    public static void Main(string[] args)
    {

        // printing Welcome Message
        Console.WriteLine("\t\t\t******* WELCOME TO ADDRESS BOOK SYSTEM PROGRAM ******");
        Console.WriteLine(" ");
        Console.WriteLine( " ");

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
        addressbook.display();

        //to holde the screen
        Console.ReadKey();
    }

}
   
