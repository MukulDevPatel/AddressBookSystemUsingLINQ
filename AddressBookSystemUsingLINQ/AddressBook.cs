using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemUsingLINQ
{
    public class AddressBook
    {
        public void EditContact()
        {
            Person list = new Person();
            Console.WriteLine("Edit using First name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter option to edit\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. ZIP\n7. Phone Number\n8. Email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    list.FirstName = Console.ReadLine();
                    break;
                case 2:
                    list.LastName = Console.ReadLine();
                    break;
                case 3:
                    list.Address = Console.ReadLine();
                    break;
                case 4:
                    list.City = Console.ReadLine();
                    break;
                case 5:
                    list.State = Console.ReadLine();
                    break;
                case 6:
                    list.Zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case 7:
                    list.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                case 8:
                    list.Email = Console.ReadLine();
                    break;
            }
        }
        
    }  
}
