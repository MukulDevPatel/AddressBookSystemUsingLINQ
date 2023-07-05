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
            Email = "devpatel@gmail.com"
        };
        Console.WriteLine(person.FirstName+"\n"+ person.LastName + "\n" + person.Address+ "\n" + person.City+ "\n" +
            person.State+ "\n" + person.Zip+ "\n" + person.PhoneNumber+ "\n" + person.Email);
    }
} 
