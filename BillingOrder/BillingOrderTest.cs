using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace BillingOrder
{
    class BillingOrderTest
    {
        public static string baseUrl = "http://localhost:8080/BillingOrder";
        [Test]
        public void CreateTest()
        {
            string data = "{\r\n  \"addressLine1\": \"Mt wellington highway\",\r\n  \"addressLine2\": \"mt wellington\",\r\n  \"city\": \"auckland\",\r\n  \"comment\": \"testing\",\r\n  \"email\": \"lathi@gmail.com\",\r\n  \"firstName\": \"La\",\r\n  \"id\": 0,\r\n  \"itemNumber\": 0,\r\n  \"lastName\": \"s\",\r\n  \"phone\": \"1234567890\",\r\n  \"state\": \"AL\",\r\n  \"zipCode\": \"123123\"\r\n}";
            dynamic expected = JsonConvert.DeserializeObject(data);
            IRestResponse response = Post(data);
            dynamic actual = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual(expected.firstnme, actual.firstname);
            Assert.AreEqual(expected.lastname, actual.lastname);
            IRestResponse getResponse = GetOneId(actual.id);
        }
        public IRestResponse Post(string data)
        {
            var client = new RestClient(baseUrl);
           // client.Timeout = -1;
            //method type
            var request = new RestRequest(Method.POST);
            //header
            request.AddHeader("Content-Type", "application/json");
            //content
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            //when we click send on postman ie execution
            
            return client.Execute(request);

        }

        public IRestResponse GetOneId(string id)
        {
            var client = new RestClient($"{baseUrl}/{ id }");
            client.Timeout = -1;
            //method type
            var request = new RestRequest(Method.GET);
            //header
            request.AddHeader("Content-Type", "application/json");
            //content
            //request.AddParameter("application/json", postData, ParameterType.RequestBody);
            //when we click send on postman ie executioN
            return client.Execute(request);

        }
        public IRestResponse GetAll()
        {
            var client = new RestClient($"baseUrl");
            client.Timeout = -1;
            //method type
            var request = new RestRequest(Method.GET);
            //header
            request.AddHeader("Content-Type", "application/json");
            //content
            //request.AddParameter("application/json", postData, ParameterType.RequestBody);
            //when we click send on postman ie execution
            return client.Execute(request);

        }
    }

    
}