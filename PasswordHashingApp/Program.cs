using System;

namespace PasswordHashingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************Password Hashing*****************");

            PasswordHash passwordHashObj = new PasswordHash();
            byte[] passwordHash;
            byte[] passwordSalt;
            passwordHashObj.CreatePasswordHash("1qaz2wsx@", out passwordHash, out passwordSalt);
            Console.WriteLine("*****************Create hash and salt*****************");
            Console.WriteLine("check the password has and salt for password 1qaz2wsx@" );           
            Console.WriteLine("passwordHash=" + Convert.ToBase64String(passwordHash));
            Console.WriteLine("passwordSalt =" + Convert.ToBase64String(passwordSalt));
            Console.WriteLine("******************verify the password ***************");

            Console.WriteLine(passwordHashObj.VerifyPasswordHash("1qaz2wsx@", passwordHash, passwordSalt));
        }


    }
}
