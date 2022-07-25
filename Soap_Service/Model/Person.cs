using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Soap_Service.Model
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/RestService.Models")]
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string surname, string gender, string imgUrl)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            PictureUrl = imgUrl;
        }

        public Person(int iDPerson, string name, string surname, string gender, string pictureUrl)
        {
            IDPerson = iDPerson;
            Name = name;
            Surname = surname;
            Gender = gender;
            PictureUrl = pictureUrl;
        }

        [DataMember(Order = 0)]
        public int IDPerson { get; set; }

        [DataMember(Order = 1)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        public string Surname { get; set; }

        [DataMember(Order = 3)]
        public string Gender { get; set; }

        [DataMember(Order = 4)]
        public string PictureUrl { get; set; }




    }
}