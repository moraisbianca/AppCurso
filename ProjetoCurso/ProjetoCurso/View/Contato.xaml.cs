using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace ProjetoCurso.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
            escola.Source = ImageSource.FromResource("ProjetoCurso.Images.escola.jpg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:551436223566"));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+551436223566", "Olá! Tenho interesse no Curso de Desenvolvimento de Sistemas, como posso me inscrever?");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}