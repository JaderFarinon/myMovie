using my_movie.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace my_movie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            //Desabilita barra de navegação na tela da lista
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            //Deserializa o json e passa como fonte da lista
            moviesList.ItemsSource = Deserialize.Deserializar(Request.jsonReq());

            //Ao selecionar item da lista
            moviesList.ItemSelected += ListaFilmes_ItemSelected;
            

        }

        //Ao selecionar item da lista
        private async void ListaFilmes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //obtem dados so filme selecionado
            var selFilme = e.SelectedItem as Filme;
            //Chama a view de detalhamento do filme passando o objeto de tipo Filme
            await Navigation.PushAsync(new Detalhe(selFilme));
        }
    }
}