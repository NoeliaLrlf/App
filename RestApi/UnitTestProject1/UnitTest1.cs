using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApi.Client;
using System.Configuration;
using System.Net;
using RestSharp;
using RestApi.Requests.Projects;
using RestApi.Entity.ProjectEntity;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Project_Get_ValidValue_200IsReturned()
        {
            string password = ConfigurationManager.AppSettings["user"] + ":" + ConfigurationManager.AppSettings["user"];
            string uri = "projects.json";
            IRestResponse response = RestApiClient.Instance.get(uri);
            var responses = response.Content;
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void Project_Create_ValidValue_200IsReturned()
        {
            string password = ConfigurationManager.AppSettings["user"] + ":" + ConfigurationManager.AppSettings["user"];
            string uri = "projects.json";
           ProjectsRequest projectRequest = new ProjectsRequest();
            var response =  projectRequest.Create(uri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void Project_Get_ValidJson_200IsReturned()
        {
            string uri = "/filters.json";
            IRestResponse response = RestApiClient.Instance.get(uri);
      
            dynamic returnResponseRun = JsonConvert.DeserializeObject(response.Content);
            string  LastSunc = returnResponseRun[0].ToString();
            var actual = LastSunc.Replace("\r\n  ", "").Replace("\r\n", "").Replace(" ","");

            ProjectEntity projectEntityExpected = new ProjectEntity();
            projectEntityExpected.Id = 0;
            projectEntityExpected.Content = "Inbox";
            projectEntityExpected.ItemsCount = 22;
            projectEntityExpected.Icon = 15;
            projectEntityExpected.ItemType = 4;
            projectEntityExpected.Children = new Object[0];

            string expected = projectEntityExpected.GetObjectAsJson();
            Assert.AreEqual(actual, expected);
         
        }
        
        
    }
}
