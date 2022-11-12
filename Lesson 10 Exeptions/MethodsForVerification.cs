using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Exeptions
{
    public class MethodsForVerification
    {
        public void testForLogin(string login)
        {
            char[] toChar = login.ToCharArray();

            CheckingForEmptyChar(toChar, "login");

            CheckLengthOfInput(toChar.Length, "login");

        }

        public void testForPassword(string password)
        {

            char[] toChar = password.ToCharArray();

            CheckingForEmptyChar(toChar, "password");

            CheckPasswordForNumber(toChar);

            CheckLengthOfInput(toChar.Length, "password");

        }

        public void ConfirmPassword(string confirmPassword, string password)
        {

            if (confirmPassword != password)
                throw new WrongPasswordException("Password is not confirmed!");

        }

        public void CheckPasswordForNumber(char[] toChar)
        {

            bool check = false;

            for (int i = 0; i < toChar.Length; i++)
            {
                check = false;
                if (toChar[i] == '0' || toChar[i] == '1' || toChar[i] == '2' || toChar[i] == '3' || toChar[i] == '4' || toChar[i] == '5' || toChar[i] == '6' || toChar[i] == '7' || toChar[i] == '8' || toChar[i] == '9')
                {
                    check = true;
                    break;
                }
            }

            if (check == false)
            {
                throw new WrongPasswordException("There is no number in password!");
            }

        }

        public void CheckingForEmptyChar(char[] toChar, string kindOfData)
        {

            for (int i = 0; i < toChar.Length; i++)
            {
                if (toChar[i] == ' ')
                    throw new WrongPasswordException($"There is empty char in {kindOfData}!");

            }

        }

        public void CheckLengthOfInput(int arrayLength, string kindOfData)
        {

            if (arrayLength > 20)
                throw new WrongPasswordException($"Wrong lenth of {kindOfData}!");

        }
    }
}
