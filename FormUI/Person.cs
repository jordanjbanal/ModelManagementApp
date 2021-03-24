using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Gender { get; set; }
        public int Adult { get; set; }
        public string City { get; set; }
        public string EyeColor { get; set; }
        public string SkinColor { get; set; }
        public string HairColor { get; set; }
        public string Comments { get; set; }

        string genderString;
        string adultString;

        public string FullInfo
        {
            get
            {
                /*
                if(Adult == 0)
                {
                    adultString = "Mineur(e)";
                }
                if (Adult == 1)
                {
                    adultString = "Majeur(e)";
                }

                if (Gender == 0)
                {
                    genderString = "M";
                }
                if (Gender == 1)
                {
                    genderString = "F";
                }
                */

                return $"{ FirstName } { LastName } ({ EmailAddress })";
            }
        }

    }
}
