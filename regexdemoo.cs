using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class regexdemoo
    {

        static public void FirstName()
        {
            Console.WriteLine("Enter the first name");
            String Firstname = Console.ReadLine();
            String Namepatterm = "^[A-Z]{1}[a-zA-z]{2,}$";
            Regex regexobj = new Regex(Namepatterm);
            if (regexobj.IsMatch(Firstname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(Firstname);

        }
        static public void LastName()
        {
            Console.WriteLine("Enter the first name");
            String LastName = Console.ReadLine();
            String Namepatterm = "^[A-Z]{1}[a-zA-z]{2,}$";
            Regex regexobj = new Regex(Namepatterm);
            if (regexobj.IsMatch(LastName))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("LastName is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("LastName is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(LastName);

        }
        static public void Email()
        {
            Console.WriteLine("Enter the first name");
            String Email = Console.ReadLine();
            String Namepatterm = "^[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            Regex regexobj = new Regex(Namepatterm);
            if (regexobj.IsMatch(Email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email is valid");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(Email);

        }
        static public void MobileNumber()
        {
            Console.WriteLine("Enter the mobile number");
            String Email = Console.ReadLine();
            String mobilepatterm = @"\b\d{10}\b$";
            Regex regexobj = new Regex(mobilepatterm);
            if (regexobj.IsMatch(Email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Number is valid");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(Email);
        }
        static public void Password()
        {
            Console.WriteLine("Enter the Password");
            String password = Console.ReadLine();
            String mobilepatterm = @"^.{8}$";
            Regex regexobj = new Regex(password);
            if (regexobj.IsMatch(password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("password is valid");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("password is not valid");
                Console.ResetColor();
            }
            Console.WriteLine(password);
        }
        static public void Uppercaseletter()
        {
            Console.WriteLine("Enter the Password");
            String ucletter = Console.ReadLine();
            String mobilepatterm = @"^(?=.*[A-Z]).*\b\d{10}\b";
            Regex regexobj = new Regex(ucletter);
            if (regexobj.IsMatch(ucletter))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("password is valid");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("password is not valid");
                Console.ResetColor();
            }

            Console.WriteLine(ucletter);
        }
        static public void Atleastonenumeric()
        {
            Console.WriteLine("Enter the Password");
            String onenumeric = Console.ReadLine();
            String mobilepatterm = @"^(?=.*\d).+$";
            Regex regexobj = new Regex(onenumeric);
            if (regexobj.IsMatch(onenumeric))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("password is valid");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("password is not valid");
                Console.ResetColor();
            }

            Console.WriteLine(onenumeric);

        }
        static public void OneSpecialChar()
        {
            Console.WriteLine("Enter the Password");
            String onechar = Console.ReadLine();
            String mobilepatterm = @"^(?=.*[\W_]).+$";
            Regex regexobj = new Regex(onechar);
            if (regexobj.IsMatch(onechar))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("char is valid");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("char is not valid");
                Console.ResetColor();
            }

            Console.WriteLine(onechar);
        }
    }
}
