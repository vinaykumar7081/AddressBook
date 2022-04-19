using System;
using AddressBookSolution;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
        AddressBook  editCode = new  AddressBook();
        editCode.Display();
        Console.WriteLine("Enter the First Name to Edit The information");
        string name = Console.ReadLine();
        editCode.EditContactInAddressBook(name);

    }
}