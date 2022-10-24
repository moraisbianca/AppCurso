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
            logo.Source = ImageSource.FromResource("ProjetoCurso.Images.logo.png");
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
                    ValoresAtitudes = "Incentivar a criatividade.\n" + 
                                      "Desenvolver a criticidade.\n" + 
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Implementar banco de dados relacional utilizando o Sistema Gerenciador de banco de dados.\n" + 
                                   "Otimizar a linguagem de consulta estruturada como forma de informação relevante para a tomada de decisão",
                    Habilidades = "Utilizar sistema de gerenciamento para banco de dados.\n" + 
                                  "Executar linguagem de consulta estruturada objetivando melhor desempenho.\n" + 
                                  "Compilar relatórios analíticos a partir dos dados coletados",
                    BasesTecnologicas = "Implementação de banco de dados\n" + 
                                        "Criação e exclusão de banco de dados.\n" + 
                                        "Variáveis e constantes\n" + 
                                        "Conceitos e utilização.\n" + 
                                        "Comandos SQL\n" + 
                                        "Linguagem de definição de dados – DDL.\n" + 
                                        "Linguagem de manipulação de dados – DML\n" + 
                                        "Linguagem de consulta de dados – DQL\n" + 
                                        "Blocos de linguagem de consulta estruturada (SQL)\n" + 
                                        "Exceções (tratamento de erros)\n" + 
                                        "Funções\n" + "Gatilhos\n" + "Visões controladas\n" + "Índices\n" + "Merge e permissões"

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
                    Atribuicoes = "Codificar e depurar programas.\n" + 
                    "Selecionar linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto.",
                    ValoresAtitudes = "Desenvolver a criatividade.\n" + 
                                      "Incentivar ações que promovam a cooperação.\n" + 
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto.",
                    Habilidades = "Codificar programas orientados a objetos.\n" + 
                                  "Utilizar ambientes de desenvolvimento para desenvolvimento desktop.\n" + 
                                  "Conectar aplicações com banco de dados.\n" + 
                                  "Aplicar técnicas de orientação a objetos.\n" +
                                  "Construir interface gráfica",
                    BasesTecnologicas = "Programação orientada a objetos\n" +
                                        "Padrão de projeto MVC (Model-View-Controller)\n" +
                                        "Construção de interface gráfica com o usuário (GUI)\n" +
                                        "Persistência em bancos de dados"

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
                    Nome = "Programação de Aplicativos Mobile",
                    Atribuicoes = "Elaborar projetos de aplicativos para plataformas móveis.\n",
                    ValoresAtitudes = "Incentivar a criatividade.\n" + 
                                      "Estimular a organização.\n" + 
                                      "Responsabilizar-se pela produção, utilização e divulgação de informações",
                    Competencias = "Projetar aplicativos, selecionando linguagens de programação e ambientes de desenvolvimento.",
                    Habilidades = "Utilizar ambientes de desenvolvimento de software mobile.\n" + 
                                  "Construir interface gráfica para aplicativos mobile\n" + 
                                  "Utilizar recursos de aparelhos celulares e tablets.\n",
                    BasesTecnologicas = "Conceitos de dispositivos móveis e mercado\n" +
                                        "Desenvolvimento de Layout de Aplicativo Mobile\n" +
                                        "Manipulação de banco de dados no dispositivo"

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
                    Nome = "Sistemas Embarcados",
                    Atribuicoes = "Desenvolver sistemas embarcados.",
                    ValoresAtitudes = "Incentivar a criatividade.\n" + 
                                      "Estimular a organização.\n" + 
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Analisar modelos de sistemas embarcados.\n" + 
                                   "Desenvolver aplicações com microcontroladores.",
                    Habilidades = "Identificar as características de sistemas embarcados.\n" + 
                                  "Programar sistemas para microcontroladores.\n" + 
                                  "Executar instruções para microcontroladores.",
                    BasesTecnologicas = "Introdução aos microcontroladores\n" + 
                                        "Princípios de elétrica e eletrônica\n" + 
                                        "Descrição da plataforma de desenvolvimento\n" + 
                                        "Escrita de programa para microcontroladores\n" + 
                                        "Conceitos de entrada e saída digital\n" + 
                                        "Utilização de controle de tempo\n" + 
                                        "Entrada e saída analógica\n" + 
                                        "Manipulação de memória física e lógica\n" + 
                                        "Controle de fluxo de programa\n" + 
                                        "Laços de repetição\n" + 
                                        "Programação modular\n" + 
                                        "Funções predefinidas\n" + 
                                        "Sensores, sons, interrupções e comunicação serial"

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