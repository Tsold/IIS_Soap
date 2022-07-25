using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Soap_Service.Model
{
    [DataContract(Name = "ListOfPeople", Namespace = "http://schemas.datacontract.org/2004/07/RestService.Models")]
    public class People
    {
        [DataMember(Name = "People")]
        public List<Person> people { get; set; }

        public People(List<Person> people)
        {
            this.people = people;
        }
    }
}