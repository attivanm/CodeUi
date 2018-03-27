using RestSharp;
using RestSharp.Authenticators;

namespace WordPress.RestClient
{
    public class RestClientManager
    {
        public string Create<T>(T objectToCreate) {
            // Authenticate
            var client = Authenticate();

            //Request
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(objectToCreate);

            //Response
            var response = client.Execute(request);
            return response.StatusCode.ToString();
        }

        private RestSharp.RestClient Authenticate()
        {
            var client = new RestSharp
                .RestClient("http://wpautomation.azurewebsites.net/wp-json/wp/v2/");
            client.Authenticator = new HttpBasicAuthenticator("Gonzalo","Control123!");
            return client;
        }
    }
}
