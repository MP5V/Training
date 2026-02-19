using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace testing
{
    internal class Program
    {
        /*Задача 5: Проверка пароля (простая валидация)
Метод string ValidatePassword(string password) возвращает:

Если password == null или пустая строка → "Password is required"
Длина < 8 → "Too short (min 8 characters)"
Нет хотя бы одной цифры → "Must contain at least one digit"
Нет хотя бы одной заглавной буквы → "Must contain at least one uppercase letter"
Всё ок → "Strong password"

Можно использовать несколько условий в switch, но проще через if-else или цепочку switch (или даже if, если switch неудобно)*/
        static string ValidatePassword(string password)
        {

            if (string.IsNullOrEmpty(password))
            {
                return("Password is required");
            };

            int PasswordSize = password.Length;

            if (PasswordSize < 8)
            {
                return("Too short (min 8 characters)");
            }
            else if (!password.Any(char.IsDigit))
            {
                return ("Must contain at least one digit");
            }
            else if (!password.Any(char.IsUpper))
            {
                return ("Must contain at least one uppercase letter");
            }
            else return ("Strong password");
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("Testing1Password"));   
            Console.WriteLine(ValidatePassword("")); 
            Console.WriteLine(ValidatePassword("testing2password"));
            Console.WriteLine(ValidatePassword("TestingThreePassword"));
            Console.WriteLine(ValidatePassword("mini"));
        }
    }
}
