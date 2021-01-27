using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            ValidateNames();
            ValidateEmails();
            ValidatePhoneNumber();
            ValidateDate();

        }

        public static void ValidateNames()
        {
            bool validName = false;
            Console.WriteLine("Please enter a valid name");
            string name = "";
            while (validName == false)
            {
                name = Console.ReadLine();
                if (name.Length > 30)
                {
                    Console.WriteLine("Sorry, name is not valid. Please Enter a valid name.");
                    continue;
                }
                if (Regex.IsMatch(name, @"^[A-Z]{1,}[A-z]{0,}$"))
                {
                    Console.WriteLine("Name Accepted, thank you");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, name is not valid. Please Enter a valid name.");
                    continue;
                }

            }
        }
        public static void ValidateEmails()
        {
            bool validEmail = false;
            Console.WriteLine("Please enter a valid email");
            string email;
            while (validEmail == false)
            {
                email = Console.ReadLine();

                if (Regex.IsMatch(email, @"^[A-z]{5,30}[@][A-z]{5,10}[.][A-z]{2,3}$"))
                {
                    Console.WriteLine("Email Accepted, thank you");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, email is not valid. Please Enter a valid email.");
                    continue;
                }


            }
        }
        public static void ValidatePhoneNumber()
        {
            bool validPhone = false;
            Console.WriteLine("Please enter a valid phone number");
            string phoneNumber;
            while (validPhone == false)
            {
                phoneNumber = Console.ReadLine();
                if (Regex.IsMatch(phoneNumber, @"^\d\d\d-\d\d\d-\d\d\d\d$"))
                {
                    Console.WriteLine("Phone number accepted. Thank you!");
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid Phone number format. Please Enter a phone number 'XXX-XXX-XXXX'");
                    continue;
                }

            }

        }
        public static void ValidateDate()
        {
            bool validDate = false;
            Console.WriteLine("Please enter a valid Date");
            string date;
            while (validDate == false)
            {
                date = Console.ReadLine();
                if (Regex.IsMatch(date, @"^(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[0-2])[/]\d{4}$"))
                {
                    Console.WriteLine("Date Accepted. Thank you.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Phone number format. Please Enter a phone number 'XXX-XXX-XXXX'");
                    continue;
                }

            }
        }
    }
  
}

