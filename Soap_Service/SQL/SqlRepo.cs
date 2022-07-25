using Microsoft.ApplicationBlocks.Data;
using Soap_Service.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Soap_Service.SQL
{
    public class SqlRepo
    {
        public static string cs = ConfigurationManager.ConnectionStrings["IIS_App"].ConnectionString;


        public static IEnumerable<Person> GetPeople()
        {


            DataTable tblKupci = SqlHelper.ExecuteDataset(cs, nameof(GetPeople)).Tables[0];

            foreach (DataRow row in tblKupci.Rows)
            {
                yield return new Person
                {
                    IDPerson = (int)row[nameof(Person.IDPerson)],
                    Name = (string)row[nameof(Person.Name)],
                    Surname = (string)row[nameof(Person.Surname)],
                    Gender = (string)row[nameof(Person.Gender)],
                    PictureUrl = (string)row[nameof(Person.PictureUrl)]

                };
            }


        }



    }
}