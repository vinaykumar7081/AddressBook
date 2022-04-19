using System;
using AddressBookSolution;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
          AddressBook addressBook = new AddressBook();
        addressBook.Display();
        Console.WriteLine("Enter the First Name");
        string name = Console.ReadLine();
        Console.WriteLine("Display after Deleting information ");
        addressBook.DeletingContactINAddressBook(name);
    }
}