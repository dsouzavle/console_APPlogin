
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login");
            Console.Write("Type your username:");
            string myUsername = Console.ReadLine();

            if (myUsername == "Victor")
            {
                Console.Write("And now type your password:");
                string myPassword = Console.ReadLine();
                if (myPassword == "Comida")
                {
                    Console.WriteLine("Welcome to CSharp Programming " + myUsername);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Sorry Incorrect Password, try again");
                }
            }





            else
            {
                Console.WriteLine("Sorry " + myUsername + " you type a incorrect Username, try again please");
                Console.ReadLine();
                Console.Write("Login (Attempt number two):");
                Console.Write("Type your username please:");
                string userLogin = Console.ReadLine();

                string[] messagesFields = new string[4];
                messagesFields[0] = "Okay lets do it ";
                messagesFields[1] = "you are not able anymore to have access on this application";
                messagesFields[2] = "What do you wanna do now?";
                messagesFields[3] = "Sorry that's wrong " + messagesFields[1];


                if (userLogin == "Victor")
                {

                    Console.Write(messagesFields[0] + "Type your password please:");
                    string myPasswordTwo = Console.ReadLine();
                    if (myPasswordTwo == "Comida")
                    {
                        Console.Write(messagesFields[2]);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write(messagesFields[3]);
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write(messagesFields[1]);
                    Console.ReadLine();
                }
            }

            
        } 
    }
}
