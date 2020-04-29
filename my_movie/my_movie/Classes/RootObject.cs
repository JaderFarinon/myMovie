using System;
using System.Collections.Generic;
using System.Text;

namespace my_movie.Classes
{
    public class RootObject
    {
        public int Page { get; set; }
        public int Total_results { get; set; }
        public int Total_pages { get; set; }
        public List<Filme> Results { get; set; }
    }
}
