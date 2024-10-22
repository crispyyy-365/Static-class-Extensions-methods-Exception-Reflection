using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public static class Helper
    {
        public static bool IsOdd(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int n = num % 2;
                if (n == 0)
                {
                    return false;
                }
                num /= 2;
            }
            return true;
        }
        public static bool IsEven(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int n = num % 2;
                if (n == 1)
                {
                    return false;
                }
                num /= 2;
            }
            return true;
        }
        public static bool HasDIgit(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return false;
            }
            foreach(char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length >= 8)
            {
                return true;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
                else if (char.IsUpper(password[i]))
                {
                    return true;
                }
                else if (char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string Capitalise(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "The string is either null or empty !";
            }
            return str.ToUpper();
        }
    }
}
