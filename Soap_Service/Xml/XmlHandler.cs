using Soap_Service.Model;
using Soap_Service.SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;
using System.Xml.Linq;


namespace Soap_Service.Xml
{
    public class XmlHandler
    {

        private static string XML_Path = HttpContext.Current.Server.MapPath("~/App_Data/SqlData.xml");
       

        public static void PrintXml()
        {
            Type[] knownTypes = new Type[] { typeof(Person) };
            List<Person> people = SqlRepo.GetPeople().ToList();
            using (XmlWriter xmlWriter = CreateWriter())
            {
                    People peps = new People(people);
                
                    DataContractSerializer serijaliziraj = new DataContractSerializer(typeof(People), knownTypes);

                    serijaliziraj.WriteObject(xmlWriter, peps);
            }
           
            
        }

        private static XmlWriter CreateWriter()
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };
            return XmlWriter.Create(XML_Path, settings);
        }





        
        public static string GetGivenData(int id)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(XML_Path);
            string result = "";
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("plp", "http://schemas.datacontract.org/2004/07/RestService.Models");


            try
            {
                XmlNode node = doc.SelectSingleNode($"descendant::plp:People/plp:Person[plp:IDPerson ='{id}']/plp:PictureUrl", nsmgr);
                

                result = node.InnerText;

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                result = e.Message;
            }

           
            return result;

        }




    }
}