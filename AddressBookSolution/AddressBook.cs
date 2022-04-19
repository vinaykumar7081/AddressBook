using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSolution
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                State = Console.ReadLine(),
                EmailAddress = Console.ReadLine(),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
                MobileNumber = Convert.ToInt64(Console.ReadLine())
            };
           
            addressBook.Add(address1);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                { 
                Console.WriteLine("Enter the Option To Update");
                    Random random = new Random();
                    int option = random.Next(1, 7);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Information to Update");
                            contact.LastName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter the Information to Update");
                            contact.Address = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter the Information to Update");
                            contact.State = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter the Information to Update");
                            contact.EmailAddress = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter the Information to Update");
                            contact.PostalCode = Convert.ToInt32(Console.ReadLine()); break;
                        case 6:
                            Console.WriteLine("Enter the Information to Update");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine()); break;


                    }
                }
                Display();
            }
        }
    }
}
