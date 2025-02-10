using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp
{
    public class MainMenu : Imenu
    {
        public void display()
        {
            Console.WriteLine("Welcome. Select an option.");
            Console.WriteLine("[1] Register");
            Console.WriteLine("[0] Exit");

        }

        public void userChoice()
        {
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    input = "Register";
                    break;
                case "0":
                    input = "Exit";
                    break;
                default:
                    input = "MainMenu";
                    break;
            }
        }

        

    }
}