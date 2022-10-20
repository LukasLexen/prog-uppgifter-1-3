// See https://aka.ms/new-console-template for more information
using drip;
/*
{
    Console.WriteLine("Lower x limit");
    int lowlimx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Higher x limit");
    int highlimx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lower y limit");
    int lowlimy = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Higher y limit");
    int highlimy = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many coordinates");
    int amount = Convert.ToInt32(Console.ReadLine());

    Random Xpos = new Random();
    Random Ypos = new Random();
   
    for (int i = 0; i < amount; i++)
    {
        int x = Xpos.Next(lowlimx, highlimx);
        int y = Ypos.Next(lowlimy, highlimy);
        Console.WriteLine("[" + x + "," + y + "]");

    }
}
*/
/*
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        {

            Console.WriteLine("Create Password");
            Console.WriteLine("Password Should be 8-20 characthers");
            string Password = Console.ReadLine();
            int PasswordLength = Password.Length;
            bool NoPassword = true;
            while (NoPassword == true)
            {
                if (string.IsNullOrEmpty(Password))
                {
                    Console.WriteLine("Password Can't Be Empty: Create New Password");                 
                    Password = Console.ReadLine();
                }
                if (PasswordLength < 8) 
                {
                    Console.WriteLine("Password Is Too Short: Create New Password ");
                    Password = Console.ReadLine();
                }
                if (PasswordLength > 19)
                {
                    Console.WriteLine("Password Is Too Long: Create New Password ");
                    Password = Console.ReadLine();
                }
                if (Password == "12345678")
                {
                    Console.WriteLine("Dumb password: Create New Password ");
                    Password = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("KNAS");
                    NoPassword = true;
                }
            if (NoPassword == false)
            {
            Console.WriteLine("Your Password is: " + Password);
            }

            }
        }
    }
}


/*bool parseSuccess = int.TryParse(PassAsString, out Password);

if (parseSuccess)
   Console.WriteLine($"Your Password is: {Password}");
else
   Console.WriteLine("This is not a Valid Password!");


}
*/
Drip drip = new Drip();
Random rnd = new Random();

        string [] colors = new string[6];
        colors[0] = "blue";
        colors[1] = "green";
        colors[2] = "yellow";
        colors[3] = "red";
        colors[4] = "banana";
        colors[5] = "blood";
        colors = colors.OrderBy(x => rnd).ToArray();
Console.WriteLine(drip.shirt + ", " + drip.pants + ", " + drip.shoes);


