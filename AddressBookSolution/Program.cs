using System;
using AddressBookSolution;
class program
{
    public static void Main(String[] args)
    { 
    AddressBookMain address=new AddressBookMain();
        string message = address.WelcomeMessage();
        Console.WriteLine("******** "+message+" **********");
    }
}