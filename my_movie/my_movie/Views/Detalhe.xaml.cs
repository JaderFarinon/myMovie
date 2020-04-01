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
        //Recebe o objeto tipo Filme
        public Detalhe(Filme selFilme)
        {
            InitializeComponent();
            //Título do filme na barra
            page.Title = selFilme.title;
            //Imagem do poster
            imgposter.Source = selFilme.poster_path;
            //Resumo do filme
            lbloverview.Text = selFilme.overview;
            //Barra indicando avaliação
            imgbarra.WidthRequest = selFilme.bar_widht;
            //Data de lançamento
            lblrelease.Text = "Lançamento: " + DateTime.Parse(selFilme.release_date).ToString("dd/MM/yyyy");
            //Gênero
            lblgenero.Text = "Gênero: " + selFilme.genre_ids;
            //Imagem maior backdrop
            imgbg.Source = selFilme.backdrop_path;
        }
    }
}