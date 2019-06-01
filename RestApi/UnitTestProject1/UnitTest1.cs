using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApi.Client;
using System.Configuration;
using System.Net;
using RestSharp;
using RestApi.Requests.Projects;
using RestApi.Entity.ProjectEntity;
using Newtonsoft.Json;

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
            string password = ConfigurationManager.AppSettings["user"] + ":" + ConfigurationManager.AppSettings["user"];
            string uri = "projects/3785177.json";
            IRestResponse response = RestApiClient.Instance.get(uri);
  
            dynamic returnResponseRun = JsonConvert.DeserializeObject(response.Content);
            var actualJson = returnResponseRun;
           
            ProjectEntity projectEntityExpected = new ProjectEntity();
            projectEntityExpected.Id = 3785177;
            projectEntityExpected.Content = "New Content";
            projectEntityExpected.ItemsCount = 0;
            projectEntityExpected.Icon = 0;
            projectEntityExpected.ItemType = 2;
            Assert.AreEqual(projectEntityExpected.Id, (int)actualJson.Id);
            Assert.AreEqual(projectEntityExpected.Content, (string)actualJson.Content);
            Assert.AreEqual(projectEntityExpected.ItemsCount, (int)actualJson.ItemsCount);
            Assert.AreEqual(projectEntityExpected.Icon, (int)actualJson.Icon);
            Assert.AreEqual(projectEntityExpected.ItemType, (int)actualJson.ItemType);
        }
    }
}
