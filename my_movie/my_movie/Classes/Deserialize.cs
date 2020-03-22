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

            for (int i = 0; i < listaJson.results.Count; i++)
            {
                listaApp.Add(new Filme()
                {
                    title = listaJson.results[i].title,
                    overview = listaJson.results[i].overview,
                    backdrop_path = "https://image.tmdb.org/t/p/w780" + listaJson.results[i].backdrop_path,
                    poster_path = "https://image.tmdb.org/t/p/w92" + listaJson.results[i].poster_path,
                    release_date = listaJson.results[i].release_date,
                    genre_ids = listaJson.results[i].genre_ids,
                    release_year = listaJson.results[i].release_date.Substring(0,4),
                    bar_widht = (120 * listaJson.results[i].vote_average)/10
                });
            }
            return listaApp;
        }
    }
}
