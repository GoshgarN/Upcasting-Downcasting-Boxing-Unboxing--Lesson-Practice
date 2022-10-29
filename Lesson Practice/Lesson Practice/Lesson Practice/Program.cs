using Lesson_Practice.Models;
using Service.Helpers.Extantions;
using Service.Services;
using Service.Services.Interface;
using System;

namespace Lesson_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Homework
            //static void Login()
            //{
            //    Console.WriteLine("Add email");
            //    string email = Console.ReadLine();

            //    Console.WriteLine("Add passwword");
            //    string password = Console.ReadLine();

            //    int role = 1;

            //    IAccountService account = new AccountService();

            //    var result = account.Login(email, password, role);

            //    Console.WriteLine(result);
            //}

            //Login();

            //int num = 5;

            //if (num < 0)
            //{
            //    Console.WriteLine("Enter correct digit");
            //    return;
            //}

            //Console.WriteLine(num.Factorial()); 

            #endregion

            //Eagle eagle1 = new Eagle();

            //Animal animal1 = eagle1;

            //Animal animal2 = new Eagle();

            //animal2.Eat(); 

            //Animal animal = eagle1;

            //Animal t1 = new Eagle();

            //int num1 = 5;

            //byte num2 =(byte) num1;

            //Console.WriteLine(num2);

            //int a = 10;

            //object b = a;

            //int c = (int)b;

            //Console.WriteLine(b);

            //string a = "50";
            //object b = a;
            //string c = b.ToString();

            //Eagle eagle1 = new Eagle();

            //Animal eagle2 = new Eagle();

            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();

            //Shark shark3 =(Shark) shark2;


            //Animal[] animals = { eagle1, eagle2, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Animal shark1 = new Shark();

            Animal eagle1 = new Eagle();

            object[] objects = { 1, 2, "P414", shark1, eagle1 };

            foreach (var item in objects)
            {

                Animal animal = item as Animal;

               

                bool isCast = animal == null ? true : false;

                if (isCast)
                {
                    string result = animal.Name ?? "Someting";
                    Console.WriteLine(result);
                }

                //string result = animal == null ? "Can't casting" : "Success casting";

                //if (animal == null)
                //{
                //    Console.WriteLine("Can't casting");
                //}
                //else
                //{
                //    animal.Name = "Test2";
                //    Console.WriteLine(animal.Name);
                //}



                //if(item is Animal)
                //{
                //    ((Animal)item).Name = "test";
                //    Console.WriteLine(((Animal)item).Name);

                //}
                //else
                //{
                //    Console.WriteLine("Can't casting");
                //    //Console.WriteLine(item);
                //}





            }




        }


    }


}
