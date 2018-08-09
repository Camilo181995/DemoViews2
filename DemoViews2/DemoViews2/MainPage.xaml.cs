using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoViews2
{
    public partial class MainPage : ContentPage
    {
 
        public MainPage()
        {
            InitializeComponent();
           // timPickInicial.Time = new TimeSpan(17, 0, 0);
        }
        async void navegador(object sender,WebNavigatedEventArgs e)
        {
            await DisplayAlert("Completado", "Se ha completado la carga de la pagina", "Ok");
        }
    }
}
