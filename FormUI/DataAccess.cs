using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Person>($"select * from People where InstaHandle LIKE '%{ input }%' OR FirstName LIKE '%{ input }%' OR LastName LIKE '%{ input }%' OR EmailAddress LIKE '%{ input }%' OR Comments LIKE '%{ input }%'").ToList();
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        public List<Person> GetPeopleByFilters(string input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Person>(input).ToList();
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }


        public void InsertPerson(string instaHandle, string firstName, string lastName, string emailAddress, int adult, int gender, string eyeColor, string skinColor, string hairColor, string city, string comments)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress};
                List<Person> people = new List<Person>();

                people.Add(new Person { InstaHandle = instaHandle, FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, Adult = adult, Gender = gender, City = city, EyeColor = eyeColor, SkinColor = skinColor, HairColor = hairColor, Comments = comments }) ;

                connection.Execute("dbo.People_Insert @InstaHandle, @FirstName, @LastName, @EmailAddress, @Adult, @Gender, @EyeColor, @SkinColor, @HairColor, @City, @Comments", people);

            }
        }

        public List<Person> ViewPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Person>($"select * from People;").ToList();
                
                return output;
            }
        }

        public List<Person> UpdatePeople(int idNumber, string instaHandle, string firstName, string lastName, string emailAddress, int adult, int gender, string eyeColor, string skinColor, string hairColor, string city, string comments)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress};
                List<Person> people = new List<Person>();

                people.Add(new Person { id = idNumber, InstaHandle = instaHandle, FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, Adult = adult, Gender = gender, City = city, EyeColor = eyeColor, SkinColor = skinColor, HairColor = hairColor, Comments = comments });

                connection.Execute("dbo.People_Modify @id, @InstaHandle, @FirstName, @LastName, @EmailAddress, @Adult, @Gender, @EyeColor, @SkinColor, @HairColor, @City, @Comments", people);

                var output = connection.Query<Person>($"select * from People;").ToList();

                return output;
            }
        }

        public List<Person> DeletePeople(int idNumber, string instaHandle, string firstName, string lastName, string emailAddress, int adult, int gender, string eyeColor, string skinColor, string hairColor, string city, string comments)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress};
                List<Person> people = new List<Person>();

                people.Add(new Person { id = idNumber, InstaHandle = instaHandle, FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, Adult = adult, Gender = gender, City = city, EyeColor = eyeColor, SkinColor = skinColor, HairColor = hairColor, Comments = comments });

                connection.Execute("dbo.People_Delete @id, @InstaHandle, @FirstName, @LastName, @EmailAddress, @Adult, @Gender, @EyeColor, @SkinColor, @HairColor, @City, @Comments", people);

                var output = connection.Query<Person>($"select * from People;").ToList();

                return output;
            }
        }

    }
}
