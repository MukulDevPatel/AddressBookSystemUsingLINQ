namespace AddressBookSystemUsingLINQ;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Address Book System Using LINQ");

        Person person = new Person()
        {
            FirstName = "Dev",
            LastName = "Patel",
            Address = "Vidya nagar",
            City = "Mumbai",
            State = "Maharashtra",
            Zip = 456231,
            PhoneNumber = 6524545863,
            Email = "devpatel@gmail.com\n"
        };
        Console.WriteLine(person.FirstName+"\n"+ person.LastName + "\n" + person.Address+ "\n" + person.City+ "\n" +
            person.State+ "\n" + person.Zip+ "\n" + person.PhoneNumber+ "\n" + person.Email);

        List<Person> list = new List<Person>();
        list.Add(new Person() { FirstName= "Saurabh", LastName = "Patel", Address = "Vidya nagar",City = "Mumbai",State = "Maharashtra", Zip = 456431, PhoneNumber = 6424545863, Email = "saurabhpatel@gmail.com\n"});
        list.Add(new Person() { FirstName = "Vikas", LastName = "Patel", Address = "Andheri", City = "Pune", State = "Maharashtra", Zip = 456231, PhoneNumber = 6524555863, Email = "vikaspatel@gmail.com\n" });
        list.Add(new Person() { FirstName = "Saurabh", LastName = "Patel", Address = "Visnsh", City = "Chennai", State = "Tamilnadu", Zip = 436231, PhoneNumber = 6524445863, Email = "vikaspatel@gmail.com\n" });

        //Using LINQ for inserting new data
        list = list.ToList();

        foreach (var contact in list)
        {
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" +
            contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
} 
