using Lesson_10_Exeptions;
using System.Collections.Generic;

User correctUser = new User();
User wrongUser = new User();

var falseTrue = correctUser.InputValues("56tt", "dsf2dfe", "dsf2dfe");
Console.WriteLine(falseTrue + "\n");

var falseTrue1 = wrongUser.InputValues("56 tt", "dsf2dfe", "dsf2dfe");
Console.WriteLine(falseTrue1 + "\n");

