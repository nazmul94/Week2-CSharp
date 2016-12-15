using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOfLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> languagesDictionary = new Dictionary<int, string>();
            languagesDictionary.Add(1, "C#");
            languagesDictionary.Add(2, "JAVA");
            languagesDictionary.Add(3, "C++");
            languagesDictionary.Add(4, "C");

            Console.WriteLine("This is a dictionary of programming languages.\n");

            bool run = true;

            while (run)
            {
                Console.WriteLine("What would you like to do?\n\tCheck if key is in Dictionary: K \n\tCheck if value is in Dictionary: V \n\tUse Key to search value: S \n\tSee number of items in Dictionary: C \n\tExit: E");
                char action = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (action)
                {
                    case 'K':
                        Console.WriteLine("Enter the Key you would like to check if it's in the Dictionary\n");
                        int key = Convert.ToInt16(Console.ReadLine().ToUpper());
                        if (languagesDictionary.ContainsKey(key))
                        {
                            Console.WriteLine("The key " + key + " exists within the Dictionary.\n");
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately, the key " + key + " does not exist inside the dictionary.\n");
                        }
                        break;
                    case 'V':
                        Console.WriteLine("Enter the that value would you like to check if it exists in the dictionary?");
                        string value = Console.ReadLine().ToUpper();
                        if (languagesDictionary.ContainsValue(value))
                        {
                            Console.WriteLine("The value " + value + " exists within the dictionary\n");
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately, the value " + value + " does not exists within the dictionary\n");
                        }
                        break;
                    case 'S':
                        Console.WriteLine("Enter the Key you would like to search the corresponding value for.\n");
                        int keyToSearch = Convert.ToInt16(Console.ReadLine().ToUpper());
                        if (languagesDictionary.ContainsKey(keyToSearch))
                        {
                            Console.WriteLine("The key " + keyToSearch + " has a corresponding value of " + languagesDictionary[keyToSearch]);
                        }
                        else
                        {
                            Console.WriteLine("The key " + keyToSearch + " does not exist inside the dictionary.\n");
                        }
                        break;
                    case 'C':
                        Console.WriteLine("The number of items in the list is currently: " + languagesDictionary.Count);
                        break;
                    case 'E':
                        Console.WriteLine("Thank you for using the Dictionary Programme. We hope to see you again!\n");
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}