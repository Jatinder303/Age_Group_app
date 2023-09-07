using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Group_app
{
    internal class Age_group
    {
        public int age {  get; set; }
        public string age_group { get; set; }

        public int person_age(DateTime date_of_birth)
        {
            DateTime Obj_today = DateTime.Today;
            age = Obj_today.Year - date_of_birth.Year;
            return age;
        }

        public string Person_Age_Group(int age)
        {
            
            if (age >= 65)
            {
                age_group = "Senior Citizen";
            }
            else if (age >= 30 && age < 65)
            {
                age_group = "Middle Adult";
            }
            else if (age >= 19 && age < 30)
            {
                age_group = "Young Adult";
            }
            else if (age >= 13 && age < 19)
            {
                age_group = "Adolescents";
            }
            else if (age >= 6 && age < 13)
            {
                age_group = "Children";
            }
            else if (age >= 2 && age < 6)
            {
                age_group = "Toddlers";
            }
            else if (age >= 0 && age < 2)
            {
                age_group = "Infants";
            }
            else
            {
                age_group = "Invalid";
            }

            return age_group;
        }
    }
}
