using RestSharp;

namespace my_movie.Classes
{
    public class Request
    {
        static public string jsonReq()
        {

            string apiKey = "94a8fe7fe48487edf806bf7ddedfd641";
            string page = "452";
            string url = "https://api.themoviedb.org/3/discover/movie?api_key=" + apiKey + "&page=" + page;

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var resp = response.Content;

            return resp;
        }
    }
}
