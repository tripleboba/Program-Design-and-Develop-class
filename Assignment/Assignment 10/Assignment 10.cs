using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList contactList = new ArrayList();

            // add contact
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to the Contact List Applicatioin\n");
            AddContact(contactList);

            // remove contact
            Console.ForegroundColor = ConsoleColor.Blue;
            RemoveContact(contactList);

            Console.ReadLine();
        }

        // ----methods----
        public static void AddContact(ArrayList contactList)
        {
            Console.WriteLine("Enter Contact Name: <Enter E to exit>");
            while (true)
            {
                string contactEntries = Console.ReadLine().ToUpper();
                contactList.Add(contactEntries);
                if (contactEntries == "E") { break; }
            }
           getDisplay(contactList);
        }

        public static void RemoveContact(ArrayList contactList)
        {
            Console.WriteLine("\n--------------\nEnter Contact Name to be Removed: < Enter E to exit >");
            while (true)
            {
                string contactEntries = Console.ReadLine().ToUpper();
                contactList.Remove(contactEntries.ToUpper());
                if (contactEntries == "E") { break; }
            }          
            getDisplay(contactList);
        }

        // display ordered list method
        public static void getDisplay(ArrayList contactList)
        {
            Console.WriteLine("\n--------------\nDisplaying Your Updated Contact List in Alphabetical Order:");
            contactList.Sort();
            contactList.Remove("E");
            foreach (string contact in contactList)
                Console.WriteLine(contact.ToUpper());
        }
    }
}
