using System;
using AddressBookSolution;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
          AddressBook addressBook = new AddressBook();
        addressBook.Display();
    }
}