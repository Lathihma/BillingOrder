namespace BillingOrder
{
    internal class BillingOrderTestBase1
    {
        public IRestResponse DeletebyId(string id)

        {
            var client = new RestClient("{http://localhost:8080/BillingOrder/3}/{id}");
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public IRestResponse GetOneId(string id)
        {
            var client = new RestClient("{http://localhost:8080/BillingOrder}/{ id }");
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