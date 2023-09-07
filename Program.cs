using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Group_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Age_group obj_age_group = new Age_group();
            string name, age_group;
            DateTime dob;

            Console.WriteLine("Please enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the Date of Birth (yyyy-mm-dd)");
            dob = Convert.ToDateTime(Console.ReadLine());

            //DateTime Obj_today = DateTime.Today;
            //int age = Obj_today.Year - dob.Year;

            int age = obj_age_group.person_age(dob);
            age_group = obj_age_group.Person_Age_Group(age);
            

            switch(age_group)
            {
                case "Senior Citizen":
                {
                        Console.WriteLine("Walk is good for you");
                        break;
                }
                case "Middle Adult":
                    {
                        Console.WriteLine("2 days a week of activities that strengthen muscles is good for you");
                        break;
                    }
                case "Young Adult":
                    {
                        Console.WriteLine("5 days a week of activities that strengthen muscles is good for you");
                        break;
                    }
                case "Adolescents":
                    {
                        Console.WriteLine("Play more outdoor games");
                        break;
                    }
                case "Children":
                    {
                        Console.WriteLine("Eating less sugar is good for you’");
                        break;
                    }
                case "Toddlers":
                    {
                        Console.WriteLine("Don’t go with stranger");
                        break;
                    }
                case "Infants":
                    {
                        Console.WriteLine("Enjoy");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid");
                            break; }
            }
           
            Console.ReadKey();
        }



        
    }
}
