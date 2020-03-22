using my_movie.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace my_movie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhe : ContentPage
    {
        public Detalhe(Filme selFilme)
        {
            InitializeComponent();
            page.Title = selFilme.title;
            imgposter.Source = selFilme.poster_path;
            lbloverview.Text = selFilme.overview;
            imgbarra.WidthRequest = selFilme.bar_widht;
            lblrelease.Text = "Lançamento: " + DateTime.Parse(selFilme.release_date).ToString("dd/MM/yyyy");
            lblgenero.Text = "Gênero: " + selFilme.genre_ids;
            imgbg.Source = selFilme.backdrop_path;
        }
    }
}