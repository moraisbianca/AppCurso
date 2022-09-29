using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjetoCurso.Model;

namespace ProjetoCurso.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundoAno : ContentPage
    {
        public SegundoAno()
        {
            InitializeComponent();
        }

        private async void ProWeb(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    CargaHoraria = 0,
                    Atribuicoes = "",
                    ValoresAtitudes = "",
                    Competencias = "",
                    Habilidades = "",
                    BasesTecnologicas = ""

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void BancoDados(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    CargaHoraria = 0,
                    Atribuicoes = "",
                    ValoresAtitudes = "",
                    Competencias = "",
                    Habilidades = "",
                    BasesTecnologicas = ""

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void DesSist(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    CargaHoraria = 0,
                    Atribuicoes = "",
                    ValoresAtitudes = "",
                    Competencias = "",
                    Habilidades = "",
                    BasesTecnologicas = ""

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void ProMob(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    CargaHoraria = 0,
                    Atribuicoes = "",
                    ValoresAtitudes = "",
                    Competencias = "",
                    Habilidades = "",
                    BasesTecnologicas = ""

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void SistEmb(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    CargaHoraria = 0,
                    Atribuicoes = "",
                    ValoresAtitudes = "",
                    Competencias = "",
                    Habilidades = "",
                    BasesTecnologicas = ""

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}