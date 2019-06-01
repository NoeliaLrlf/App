using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using RestSharp;
using RestSharp.Authenticators;

namespace RestApi.Client
{
    public class RestApiClient
    {
        private string _uriBase = ConfigurationManager.AppSettings["url"];
        private static RestApiClient _instance = null;

        private RestApiClient()
        {
           

        }
        public IRestResponse post(string uri, Object json)
        {
            var client = new RestClient(_uriBase);
          
            var request = new RestRequest(uri, Method.POST);
            request.AddHeader("Authorization", RestHeader.GetPassword());
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(json);
            var response = client.Execute(request);
            return response;

        }

        public IRestResponse get(string uri)
        {
            var client = new RestClient();
            client.BaseUrl= new Uri(_uriBase);

            var request = new RestRequest(_uriBase + uri, Method.GET);
            request.AddHeader("Authorization", RestHeader.GetPassword());
            var response = client.Execute(request);
            return response;

        }

        public static RestApiClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RestApiClient();
                }
                return _instance;
            }
        }
    }
}
