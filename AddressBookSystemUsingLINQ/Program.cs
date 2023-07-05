namespace AddressBookSystemUsingLINQ;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Address Book System Using LINQ");
        List<Person> list = new List<Person>()
        { 
          new Person() { FirstName = "Saurabh", LastName = "Patel", Address = "Vidya nagar", City = "Mumbai", State = "Maharashtra", Zip = 456431, PhoneNumber = 6424545863, Email = "saurabhpatel@gmail.com\n" },
          new Person() { FirstName = "Vikas", LastName = "Patel", Address = "Andheri", City = "Hydrabad", State = "Aandhra Pradesh", Zip = 456231, PhoneNumber = 6524555863, Email = "vikaspatel@gmail.com\n" },
          new Person() { FirstName = "Saurabh", LastName = "Patel", Address = "Visnsh", City = "Chennai", State = "Tamilnadu", Zip = 436231, PhoneNumber = 6524445863, Email = "vikaspatel@gmail.com\n" },
          new Person() {FirstName = "Dev", LastName = "Patel", Address = "Vidya nagar",City = "Mumbai",State = "Maharashtra",Zip = 456231,PhoneNumber = 6524545863,Email = "devpatel@gmail.com\n"}
        };

        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nSelect options");
            Console.WriteLine("1. Insert New Contacts \n2. Edit Contacts \n3. Delete Contacts\n4. Retreive Data By City or State\n5. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    list = list.ToList();
                    foreach (var contact in list)
                    {
                        Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" +
                        contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
                    }
                    break;
                case 2:
                    AddressBook addressBook = new AddressBook();
                    addressBook.EditContact(list);
                    break;
                case 3:
                    AddressBook addressBook1 = new AddressBook();
                    addressBook1.DeleteContact(list);
                    break;
                case 4:
                    AddressBook addressBook2 = new AddressBook();
                    addressBook2.RetrieveDetails(list);
                    break;
                case 5:
                    flag = false;
                    break;
            }
        }
    }
} 
