using System.Text.RegularExpressions;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Enter the first name");
            Console.WriteLine("please select options :"+
                "1. To check the firstname\n" +
                "2. To check the lastname\n"+
                "3. to check email\n"+
                "4. to check mobilenumber\n"+
                "5. to check password\n"+
                "6. to check Uppercaseletter\n"+
                "7. to check Atleastonenumeric\n"+
               "8. to check OneSpecialChar\n");
                
                
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    regexdemoo.FirstName();
                    break;
                case 2:
                    regexdemoo.LastName();
                    break;
                case 3:
                    regexdemoo.Email();
                    break;
                case 4:
                    regexdemoo.MobileNumber();
                    break;
                case 5:
                    regexdemoo.Password();      
                    break;
                case 6:
                    regexdemoo.Uppercaseletter();
                    break;
                    case 7:
                    regexdemoo.Atleastonenumeric();
                    break;
                    case 8:
                    regexdemoo.OneSpecialChar();
                        break;


            }
          
        }
    }
}