using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("1. List all contacts");
        Console.WriteLine("2. Search a contact");
        Console.WriteLine("3. Add a contact");
        Console.WriteLine("4. Delete a contact");

        Console.Write("Enter a choice: ");

        Hashtable contacts = new Hashtable();
        contacts["Nikolay"] = "0225656";
        contacts["Martin"] = "0224821";
        contacts["Georgi"] = "0229956";
        contacts["Ivan"] = "0225600";

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
        {
            if (choice == 1)
            {
                foreach (DictionaryEntry entry in contacts)
                {
                    string name = (string)entry.Key;
                    string phoneNum = (string)entry.Value;

                    Console.WriteLine($"Name: {name}, Phone Number: {phoneNum}");
                }
            }

            if (choice == 2)
            {
                Console.WriteLine("Enter the name you want to search: ");
                string searchName = Console.ReadLine();

                if (contacts.ContainsKey(searchName))
                {
                    string phoneNum = (string)contacts[searchName];
                    Console.WriteLine($"Name: {searchName}, Phone Number: {phoneNum}");
                }
                else
                {
                    Console.WriteLine($"Contact {searchName} not found.");
                }
            }

            if (choice == 3)
            {
                Console.Write("How many people would you like to add: ");
                int contactNumA = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < contactNumA; i++)
                {
                    Console.Write("Enter the name of the person you want to add: ");
                    string nameAdd = Console.ReadLine();
                    Console.Write("Enter the phone number of the person: ");
                    string phoneNumAdd = Console.ReadLine();
                    contacts.Add(nameAdd, phoneNumAdd);
                }

                Console.WriteLine("Here's the updated phonebook: ");
                foreach (DictionaryEntry entry in contacts)
                {
                    string name = (string)entry.Key;
                    string phoneNum = (string)entry.Value;

                    Console.WriteLine($"Name: {name}, Phone Number: {phoneNum}");
                }

            }

            if (choice == 4)
            {
                Console.Write("How many people would you like to delete: ");
                int contactNumD = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < contactNumD; i++)
                {
                    Console.Write("Enter the name of the person you want to delete: ");
                    string contactDelete = Console.ReadLine();
                    if (contacts.ContainsKey(contactDelete))
                    {
                        contacts.Remove(contactDelete);
                        Console.WriteLine($"Contact '{contactDelete}' deleted.");
                    }
                    else
                    {
                        Console.WriteLine($"Contact '{contactDelete}' not found.");
                    }
                }

                Console.WriteLine("Here's the updated phonebook: ");
                foreach (DictionaryEntry entry in contacts)
                {
                    string name = (string)entry.Key;
                    string phoneNum = (string)entry.Value;

                    Console.WriteLine($"Name: {name}, Phone Number: {phoneNum}");
                }
            }
        }
        else
        {
            Console.WriteLine("Enter a valid number!");
                int newChoice = Convert.ToInt32(Console.ReadLine());
                newChoice = choice;
        }
    }
}

