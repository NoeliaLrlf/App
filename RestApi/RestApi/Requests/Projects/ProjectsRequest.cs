using RestApi.Client;
using RestApi.Entity.ProjectEntity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Requests.Projects
{
    public class ProjectsRequest
    {
        public IRestResponse Create(string uri)
        {
            ProjectEntity project = new ProjectEntity();
            project.Id = 0;
            project.Content = "New Content";

            var response = RestApiClient.Instance.post(uri, project);
            return response;

        }
    }
}
