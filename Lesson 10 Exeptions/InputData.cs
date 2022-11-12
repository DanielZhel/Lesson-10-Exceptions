using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Exeptions
{
    public class User : MethodsForVerification
    {
        public bool InputValues(string login, string password, string confirmPassword)
        {
            bool check =true;
            try
            {
                testForLogin(login);
                testForPassword(password);
                ConfirmPassword(confirmPassword, password);
            }
            catch (Exception ex)
            {
                check = false;
                Console.WriteLine(ex.Message);
            }
            return check;

        }
  
    }
}
