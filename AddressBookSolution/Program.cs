using System;
using AddressBookSolution;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
    AddressBookContact address=new AddressBookContact ();
        address.FirstName =Console.ReadLine();
        address.LastName =Console.ReadLine();
        address.Address=Console.ReadLine();
        address.State = Console.ReadLine();
        address.EmailAddress = Console.ReadLine();
        address.PostalCode =Convert.ToInt32(Console.ReadLine());
        address.MobileNumber =Convert.ToInt64 (Console.ReadLine());
        Console.WriteLine(address.FirstName+" "+ address.LastName+" "+ address.Address+" "+ address.State+" "+ address.EmailAddress+" "+ address.PostalCode+" "+ address.MobileNumber);
        
    }
}