using Newtonsoft.Json;
using System.Collections.Generic;

namespace my_movie.Classes
{
    public class Deserialize
    {
        static public List<Filme> Deserializar(string resp)
        {
            var listaJson = JsonConvert.DeserializeObject<RootObject>(resp);
            List<Filme> listaApp = new List<Filme>();

            for (int i = 0; i < listaJson.Results.Count; i++)
            {
                listaApp.Add(new Filme()
                {
                    Title = listaJson.Results[i].Title,
                    Overview = listaJson.Results[i].Overview,
                    Backdrop_path = "https://image.tmdb.org/t/p/w780" + listaJson.Results[i].Backdrop_path,
                    Poster_path = "https://image.tmdb.org/t/p/w92" + listaJson.Results[i].Poster_path,
                    Release_date = listaJson.Results[i].Release_date,
                    Genre_ids = listaJson.Results[i].Genre_ids,
                    Release_year = listaJson.Results[i].Release_date.Substring(0, 4),
                    Bar_widht = (120 * listaJson.Results[i].Vote_average) / 10
                });
            }
            return listaApp;
        }
    }
}
