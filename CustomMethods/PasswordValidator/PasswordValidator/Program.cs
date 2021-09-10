using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        static void ValidatePassword(string password)
        {
            bool lenValid = PasswordLength(password);
            bool charValid = PasswordCharacters(password);
            bool digitValid = PasswordDigits(password);

            if (lenValid && charValid && digitValid)
                Console.WriteLine("Password is valid");
            if (lenValid == false)
                Console.WriteLine("Password must be between 6 and 10 characters");
            if (charValid == false)
                Console.WriteLine("Password must consist only of letters and digits");
            if (digitValid == false)
                Console.WriteLine("Password must have at least 2 digits");
        }

        static bool PasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
                return true;
            else
                return false;   
        }

        static bool PasswordCharacters(string password)
        {
            for (int i = 0; i <= password.Length - 1; i++)
                if (!Char.IsLetterOrDigit(password[i]))
                    return false;

            return true;
        }

        static bool PasswordDigits(string password)
        {
            int digitCount = 0;
            for (int i = 0; i <= password.Length - 1; i++)
                if (Char.IsDigit(password[i]))
                    digitCount++;
            if (digitCount >= 2)
                return true;
            else
                return false;
        }
    }
}
