using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace StoreApp
{
    private User _user = new User();
    public class RegisterMenu : Imenu
    {
        public void display()
        {
            Console.WriteLine("Select number to input your info");
            Console.WriteLine("[1] Username - "  + _user.Username);
            Console.WriteLine("[0] Exit");



        }

        public void userChoice()
        {
            string input = Console.ReadLine();

            switch(input)
            { 
                

            }
        }
    }
}