namespace BillingOrder
{
    internal class BillingOrderTestBase
    {
        public IRestResponse DeletebyId(string id)

        {
            var client = new RestClient("http://localhost:8080/BillingOrder/3");
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}