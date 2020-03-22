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
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            moviesList.ItemsSource = Deserialize.Deserializar(Request.jsonReq());
            moviesList.ItemSelected += ListaFilmes_ItemSelected;
        }

        private async void ListaFilmes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selFilme = e.SelectedItem as Filme;
            await Navigation.PushAsync(new Detalhe(selFilme));
        }
    }
}