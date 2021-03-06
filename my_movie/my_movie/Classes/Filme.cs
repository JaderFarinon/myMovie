﻿using System;
using System.Collections.Generic;
using System.Text;

namespace my_movie.Classes
{
    public class Filme
    {
        public double Popularity { get; set; }
        public int Id { get; set; }
        public bool Video { get; set; }
        public int Vote_count { get; set; }
        public double Vote_average { get; set; }
        public string Title { get; set; }
        public string Release_date { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public List<int> Genre_ids { get; set; }
        public string Backdrop_path { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public string Poster_path { get; set; }
        public string Release_year { get; set; }
        public double Bar_widht { get; set; }
    }


}

