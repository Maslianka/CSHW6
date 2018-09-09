using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber. 

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            #endregion

            #region From file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into file "Phones.txt".
            
            string[] parts;
            StreamReader reader = new StreamReader("phones.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                parts = line.Split(',');
                phoneBook.Add(parts[0], parts[1]);
                
            }
            using (StreamWriter sw = new StreamWriter("Phoness.txt", false, System.Text.Encoding.Default))
            {
                foreach (var current in phoneBook)
                {
                    sw.WriteLine(current.Value);
                }
            }
            #endregion

            #region Find and print phone number by the given name (name input from console)
            string lookingFor = Console.ReadLine();
            string myValue = phoneBook[lookingFor];
            Console.WriteLine(myValue);
            #endregion

            #region Change all phone numbers, which are in format 80######### into new format +380#########. The result write into file "New.txt"
            using (StreamWriter sw = new StreamWriter("New.txt", false, Encoding.Default))
            {

                foreach (string s in phoneBook.Values)
                {
                    if (s.Length < 13)
                    {
                        sw.WriteLine($"+3{s}");
                    }
                }
            }
            #endregion

            Console.ReadKey();
        }        
    }
}

