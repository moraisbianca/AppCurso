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
                    Nome = "Programação Web II",
                    Atribuicoes = "Planejar projetos de sistemas de informação para Web.",
                    ValoresAtitudes = "Incentivar a criatividade.\r\n" + 
                                      "Responsabilizar-se pela produção, utilização e divulgação de informações.\r\n" + 
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Desenvolver sistemas para internet utilizando persistência em banco de dados, interface com o usuário e programação em lado servidor.",
                    Habilidades = "Codificar software em linguagem para Web.\r\n" + 
                                  "Utilizar banco de dados relacionais para persistência dos dados.\r\n" + 
                                  "Utilizar interface baseada em navegador para interação com usuário.",
                    BasesTecnologicas = "Introdução a scripts lado servidor\n" +
                                        "Variáveis e tipos de dados\n" +
                                        "Comunicação entre navegador e aplicação\n" +
                                        "Persistência em banco de dados\n" +
                                        "Modularização e organização dos programas \n"

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
                    Nome = "Banco de Dados II",
                    Atribuicoes = "Implementar banco de dados.",
                    ValoresAtitudes = "Incentivar a criatividade.\r\n" + 
                                      "Desenvolver a criticidade.\r\n" + 
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Implementar banco de dados relacional utilizando o Sistema Gerenciador de banco de dados.\r\n" + 
                                   "Otimizar a linguagem de consulta estruturada como forma de informação relevante para a tomada de decisão",
                    Habilidades = "Utilizar sistema de gerenciamento para banco de dados.\r\n" + 
                                  "Executar linguagem de consulta estruturada objetivando melhor desempenho.\r\n" + 
                                  "Compilar relatórios analíticos a partir dos dados coletados",
                    BasesTecnologicas = "Implementação de banco de dados\r\n" + 
                                        "Criação e exclusão de banco de dados. \r\n" + 
                                        "Variáveis e constantes\r\n" + 
                                        "Conceitos e utilização.\r\n" + 
                                        "Comandos SQL\r\n" + 
                                        "Linguagem de definição de dados – DDL.\r\n" + 
                                        "Linguagem de manipulação de dados – DML\r\n" + 
                                        "Linguagem de consulta de dados – DQL\r\n" + 
                                        "Blocos de linguagem de consulta estruturada (SQL)\r\n" + 
                                        "Exceções (tratamento de erros)\r\n" + 
                                        "Funções\r\n" + "Gatilhos\r\n" + "Visões controladas\r\n" + "Índices\r\n" + "Merge e permissões"

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
                    Nome = "Desenvolvimento de Sistemas",
                    Atribuicoes = "Codificar e depurar programas.\r\n" + 
                    "Selecionar linguagens de programação e ambientes de desenvolvimento de acordo com as \r\nespecificidades do projeto.",
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