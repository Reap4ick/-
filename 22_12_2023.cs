using System;

namespace YourNamespace
{
    class Account
    {
        private string email;
        private string password;

        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email");
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (IsValidPassword(value))
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Invalid password");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@') && email.Length >= 4 && email.Length <= 50;
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 6 && ContainsDigit(password) && ContainsLetter(password);
        }

        private bool ContainsDigit(string input)
        {
            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsLetter(string input)
        {
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            Account userAccount = new Account();

            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Enter email: ");
                try
                {
                    userAccount.Email = Console.ReadLine();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                Console.Write("Enter password: ");
                try
                {
                    userAccount.Password = Console.ReadLine();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                isValidInput = true;
            }

            Console.WriteLine($"Email: {userAccount.Email}");
            Console.WriteLine($"Password: {userAccount.Password}");
        }
    }
}



// using System;

// class CreditCard
// {
//     private string cardHolderName;
//     private string cardNumber;
//     private string expirationDate;
//     private string cvv;

//     public string CardHolderName
//     {
//         get { return cardHolderName; }
//         set
//         {
//             if (IsValidCardHolderName(value))
//             {
//                 cardHolderName = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Invalid cardholder name");
//             }
//         }
//     }

//     public string CardNumber
//     {
//         get { return cardNumber; }
//         set
//         {
//             if (IsValidCardNumber(value))
//             {
//                 cardNumber = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Invalid card number");
//             }
//         }
//     }

//     public string ExpirationDate
//     {
//         get { return expirationDate; }
//         set
//         {
//             if (IsValidExpirationDate(value))
//             {
//                 expirationDate = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Invalid expiration date");
//             }
//         }
//     }

//     public string CVV
//     {
//         get { return cvv; }
//         set
//         {
//             if (IsValidCVV(value))
//             {
//                 cvv = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Invalid CVV");
//             }
//         }
//     }

//     private bool IsValidCardHolderName(string name)
//     {
//         return !string.IsNullOrEmpty(name);
//     }

//     private bool IsValidCardNumber(string number)
//     {
//         return !string.IsNullOrEmpty(number) && number.Length == 16 && IsNumeric(number);
//     }

//     private bool IsValidExpirationDate(string date)
//     {
//         return !string.IsNullOrEmpty(date) && date.Length == 5 && IsNumeric(date.Substring(0, 2)) && IsNumeric(date.Substring(3, 2)) && date[2] == '/';
//     }

//     private bool IsValidCVV(string cvv)
//     {
//         return !string.IsNullOrEmpty(cvv) && cvv.Length == 3 && IsNumeric(cvv);
//     }

//     private bool IsNumeric(string input)
//     {
//         foreach (char character in input)
//         {
//             if (!char.IsDigit(character))
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         CreditCard creditCard = new CreditCard();

//         try
//         {
//             Console.Write("Enter cardholder name: ");
//             creditCard.CardHolderName = Console.ReadLine();

//             Console.Write("Enter card number: ");
//             creditCard.CardNumber = Console.ReadLine();

//             Console.Write("Enter expiration date (MM/YY): ");
//             creditCard.ExpirationDate = Console.ReadLine();

//             Console.Write("Enter CVV: ");
//             creditCard.CVV = Console.ReadLine();

//             Console.WriteLine("Credit card data is valid.");
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }