using System;

internal class ESPELETA_Assignment_Item_Number_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("To Sign Up, Please Provide Your Username and Password Below");
        Console.Write("\nEnter Your Username:\t");
        string username; //declaration
        username = Console.ReadLine();
        Console.Write("Enter Your Password:\t");
        string password; //declaration
        password = Console.ReadLine();

        Console.WriteLine("\nSigning Up Done! Please Sign In");

        Console.Write("\nEnter Your Username:\t");
        string Username; //declaration
        Username = Console.ReadLine();
        Console.Write("Enter Your Password:\t");
        string Password; //declaration
        Password = Console.ReadLine();

        if (Username == username && Password == password)
        {
            Console.WriteLine("\nWelcome! Log In Successful");
        }
        else
        {
            Console.WriteLine("\nCredentials You've Entered Are Incorrect!\nRemaining Attempts (3)");
            Console.Write("\nEnter Your Username:\t");
            string Username3; //declaration
            Username3 = Console.ReadLine();
            Console.Write("Enter Your Password:\t");
            string Password3; //declaration
            Password3 = Console.ReadLine();

            if (Username3 == username && Password3 == password)
            {
                Console.WriteLine("\nWelcome! Log In Successful");
            }
            else
            {
                Console.WriteLine("\nCredentials You've Entered Are Incorrect!\nRemaining Attempts (2)");
                Console.Write("\nEnter Your Username:\t");
                string Username2; //declaration
                Username2 = Console.ReadLine();
                Console.Write("Enter Your Password:\t");
                string Password2; //declaration
                Password2 = Console.ReadLine();

                if (Username2 == username && Password2 == password)
                {
                    Console.WriteLine("\nWelcome! Log In Successful");
                }
                else
                {
                    Console.WriteLine("\nCredentials You've Entered Are Incorrect!\nRemaining Attempts (1)");
                    Console.Write("\nEnter Your Username:\t");
                    string Username1; //declaration
                    Username1 = Console.ReadLine();
                    Console.Write("Enter Your Password:\t");
                    string Password1; //declaration
                    Password1 = Console.ReadLine();

                    if (Username1 == username && Password1 == password)
                    {
                        Console.WriteLine("\nWelcome! Log In Successful");
                    }
                    else
                    {
                        Console.WriteLine("\nCredentials You've Entered Are Incorrect!\nNo Remaining Attempts");
                    }
                }
            }
        }

    }
}
