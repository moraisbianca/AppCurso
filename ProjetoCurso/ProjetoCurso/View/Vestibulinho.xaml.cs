using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoCurso.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
            vestibulinho2.Source = ImageSource.FromResource("ProjetoCurso.Images.vestibulinho2.jpg");
            calendario.Source = ImageSource.FromResource("ProjetoCurso.Images.calendario.jpg");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("http://www.vestibulinhoetec.com.br"));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}