using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;


namespace UniqueCollectionPractice
{
    public class Program
    {
        public static void GetStudentsList(StudetsList studetsList)
        {
            foreach (User user in studetsList)
            {
                Console.WriteLine($"Current ICollection List Row: {user}");
            }
        }
        static void Main(string[] args)
        {
            bool breakFlag = false;
            User user;
            string userActionListiner;
            string userActionList = "\nWhat action would you like to take in ICollection List?\na - Add\nd - Remove\ne - Enumerate\nb - Contains\nc - Clear\nq - Quit";
            StudetsList a1 = new StudetsList();
            //
            while (!breakFlag)
            {
                try
                {
                    Console.WriteLine(userActionList);
                    userActionListiner = Console.ReadLine().ToLower();
                    //-->
                    switch (userActionListiner)
                    {
                        case "a":
                            Console.WriteLine("Set new name:");
                            userActionListiner = Console.ReadLine().ToLower();
                            a1.Add(new User(userActionListiner));
                            GetStudentsList(a1);
                            break;
                        //
                        case "d":
                            if (a1.Count > 0)
                            {
                                Console.WriteLine("The name you would like to delete:");
                                userActionListiner = Console.ReadLine().ToLower();
                                a1.Remove(userActionListiner);
                                GetStudentsList(a1);
                            }
                            else
                                Console.WriteLine("There is no record in the selected collection");

                            break;
                        //
                        case "e":
                            GetStudentsList(a1);
                            break;
                        //
                        case "b":
                            if (a1.Count > 0)
                            {
                                Console.WriteLine("Set The Search Input Student Name Please:");
                                userActionListiner = Console.ReadLine().ToLower();
                                user = new User(userActionListiner);

                                if (!(a1.Contains(user)))
                                    Console.WriteLine("The Element NOT Exists In Collection List");
                                else
                                    Console.WriteLine("The Element Exists In Collection List");
                            }
                            break;
                        //
                        case "c":
                            a1.Clear();
                            Console.WriteLine("The Students Collection List are Cleared!");
                            break;
                        //
                        case "q":
                            breakFlag = true;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The Operation is failure!");
                }
            }
        }
    }
}