using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShiftEx
{
    public partial class MainPage : ContentPage
    {
        Config configPage;
        public MainPage()
        {
            configPage = new Config();
            InitializeComponent();
            BindingContext = configPage;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(configPage);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (configPage.Enviar)
                DisplayAlert("Teste", $"Email enviado para {configPage.Email}", "Ok");
            else
                DisplayAlert("Teste", "Email não configurado", "Ok");
        }
    }
}
