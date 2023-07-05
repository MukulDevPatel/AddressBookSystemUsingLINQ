using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemUsingLINQ
{
    public class AddressBook
    {
        public void EditContact(List<Person> person)
        {
            Person list = new Person();
            Console.WriteLine("Enter option to edit\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. ZIP\n7. Phone Number\n8. Email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter Replace First Name: ");
                    list.FirstName = Console.ReadLine();
                    var FirstNameEdit = from c in person where c.FirstName=="" select c.FirstName;
                    break;
                case 2:
                    Console.Write("Enter Replace Last Name: ");
                    list.LastName = Console.ReadLine();
                    var LastNameEdit = from c in person where c.LastName == "" select c.LastName;
                    break;
                case 3:
                    Console.Write("Enter Replace Address: ");
                    list.Address = Console.ReadLine();
                    var AddressEdit = from c in person where c.Address == "" select c.Address;
                    break;
                case 4:
                    Console.Write("Enter Replace City: ");
                    list.City = Console.ReadLine();
                    var CityEdit = from c in person where c.FirstName == "" select c.FirstName;
                    break;
                case 5:
                    Console.Write("Enter Replace State: ");
                    list.State = Console.ReadLine();
                    var StateEdit = from c in person where c.State == "" select c.State;
                    break;
                case 6:
                    Console.Write("Enter Replace Zip: ");
                    list.Zip = Convert.ToInt32(Console.ReadLine());
                    var ZipEdit = from c in person orderby c.Zip select c.Zip;
                    break;
                case 7:
                    Console.Write("Enter Replace Phone Number: ");
                    list.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    var PhoneNumberEdit = from c in person orderby c.PhoneNumber select c.PhoneNumber;
                    break;
                case 8:
                    Console.Write("Enter Replace Email: ");
                    list.Email = Console.ReadLine();
                    var EmailEdit = from c in person where c.Email == "" select c.Email;
                    break;
            }
        }

        public void DeleteContact(List<Person> person)
        {
            Console.Write("Enter a name for delete contact: ");
            string name = Console.ReadLine();
            person = person.Where(c => c.FirstName != name).ToList();
            if(person.Find(c => c.FirstName == name) != null)
            {
                person.Remove(person.Find(c => c.FirstName == name));
            }
        }
        
    }  
}
