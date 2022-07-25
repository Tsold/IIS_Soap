using Soap_Service.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Soap_Service
{
    /// <summary>
    /// Summary description for XmlGetterService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class XmlGetterService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetXml(int id)
        {
            
            XmlHandler.PrintXml();
            return XmlHandler.GetGivenData(id);
        }
    }
}
