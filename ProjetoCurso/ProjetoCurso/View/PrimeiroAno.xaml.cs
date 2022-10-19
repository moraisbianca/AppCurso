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
    public partial class PrimeiroAno : ContentPage
    {
        public PrimeiroAno()
        {
            InitializeComponent();
        }

        private async void Fundamentos(object sender, EventArgs e)
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

        private async void ProAlg(object sender, EventArgs e)
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

        private async void ProWeb(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",
                    CargaHoraria = 80,
                    Atribuicoes = "Desenvolver sites para web",
                    ValoresAtitudes = "Incentivar a criatividade" + 
                                      "Estimular a organização" +
                                      "Fortalecer a persistência na resolução de situações-problema",
                    Competencias = "Desenvolver páginas para a internet",
                    Habilidades = "Construir páginas para internet utilizando linguagem de marcação de texto" +
                                  "Utilizar linguagem de script para web" +
                                  "aplicar formatação através dee folhas de estilo",
                    BasesTecnologicas = " - Conceitos de desenvolvimento para a web" +
                                        " - Linguagem de marcação para a web (HTML)" +
                                        " - Documento HTML mínimo, tags, atributos e conteúdo" +
                                        " - Estilos em Cascata"


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

        private async void Analise(object sender, EventArgs e)
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

        private async void Design(object sender, EventArgs e)
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