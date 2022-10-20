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
                    Nome = "Fundamentos da Informática",
                    Atribuicoes = "Operar sistemas computacionais.",
                    ValoresAtitudes = "Desenvolver a criticidade.\n" + 
                                      "Incentivar comportamentos éticos.\n" + 
                                      "Promover ações que considerem o respeito às normas estabelecidas.",
                    Competencias = "Articular conhecimentos de sistemas computacionais.\n" + 
                                   "Distinguir sistemas computacionais.",
                    Habilidades = "Distinguir arquiteturas de sistemas de hardware e software.\n" + 
                                  "Executar comandos em interface de linha de comando.\n" + 
                                  "Utilizar sistemas computacionais.", 
                    BasesTecnologicas = "Conceitos básicos de Tecnologia da Informação\n" +
                                        "Laboratório em sistemas operacionais\n" +
                                        "Manipulação de arquivos\n" +
                                        "Pipes, redirecionamentos e filtros (>, >>, |, head, tail, sort)\n" +
                                        "Permissões (chmod)\n" +
                                        "Execução de comandos em lote (#!, echo)\n" +
                                        "Processos (CTRL+C, kill, os)\n" +
                                        "Utilização de Interface Gráfica\n"

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
                    Nome = "Programação de Algoritmos",
                    Atribuicoes = "Verificar usabilidade no desenvolvimento de programas.\n" + 
                                  "Realizar versionamento no desenvolvimento de programas.\n" + 
                                  "Desenvolver programas de computador, utilizando princípios de boas práticas.\n" + 
                                  "Implementar algoritmos em linguagem de programação, utilizando ambientes de desenvolvimento de acordo com as necessidades.\r\n",
                    ValoresAtitudes = "Incentivar a criatividade.\n" + 
                                      "Incentivar atitudes de autonomia.\n" + 
                                      "Incentivar comportamentos éticos.\n" +
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Implementar algoritmos de programação.\n" + 
                                   "Desenvolver sistemas aplicando princípios e paradigmas de programação.",
                    Habilidades = "Elaborar algoritmos.\n" + 
                                  "Codificar programas, utilizando técnica de programação estruturada.\n" + 
                                  "Depurar e versionar programas, utilizando ambiente de desenvolvimento integrado.",
                    BasesTecnologicas = "Princípios de programação." +
                                        "Comandos da linguagem de programação." +
                                        "Programação estruturada." +
                                        "Ferramentas para o desenvolvimento." +
                                        "Verificação e depuração de código." +
                                        "Programação modular." +
                                        "Tipos de dados estruturados." +
                                        "Versionamento e colaboração." +
                                        "Práticas de programação."

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
                    Atribuicoes = "Desenvolver sites para web.",
                    ValoresAtitudes = "Incentivar a criatividade, \n" + 
                                      "Estimular a organização, \n" +
                                      "Fortalecer a persistência na resolução de situações-problema.",
                    Competencias = "Desenvolver páginas para a internet.",
                    Habilidades = "Construir páginas para internet utilizando linguagem de marcação de texto, \n" +
                                  "Utilizar linguagem de script para web, \n" +
                                  "Aplicar formatação através de folhas de estilo.",
                    BasesTecnologicas = " - Conceitos de desenvolvimento para a web. \n" +
                                        " - Linguagem de marcação para a web (HTML). \n" +
                                        " - Documento HTML mínimo, tags, atributos e conteúdo. \n" +
                                        " - Estilos em Cascata."


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
                    Nome = "Banco de Dados I",
                    Atribuicoes = "Modelar banco de dados.",
                    ValoresAtitudes = "Estimular a organização.\n" + 
                                      "Promover ações que considerem o respeito às normas estabelecidas.\n" + 
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Desenvolver modelo de banco de dados.",
                    Habilidades = "Levantar as necessidades de informações do sistema.\n" + 
                                  "Normalizar tabelas de banco de dados.\n" + 
                                  "Associar tabelas para construção de banco de dados.\n" + 
                                  "Aplicar linguagem SQL na construção de tabelas.",
                    BasesTecnologicas = "Estrutura de banco de dados \n" +
                                        "Modelo conceitual \n" +
                                        "Modelo lógico\n" +
                                        "Dicionário de dados\n" +
                                        "Grau de cardinalidade\n" +
                                        "Tipos de restrições de integridade e conceitos\n" +
                                        "Conceitos de autorrelacionamento\n" +
                                        "Normalização de tabelas\n" +
                                        "Especialização e generalização (superclasses e subclasses, supertipo e subtipos)\n" +
                                        "Conceito de domínio\n" +
                                        "Conceito de tabelas\n" +
                                        "Construção de projeto lógico de banco de dados\n" +
                                        "Introdução ao SGBD SQL Server\n" +
                                        "Interface de comando\n" +
                                        "Comandos da ferramenta x comandos SQL\n" +
                                        "Introdução a DDL"

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
                    Nome = "Análise e Projeto de Sistemas",
                    Atribuicoes = "Elaborar projetos de sistema de informação.",
                    ValoresAtitudes = "Incentivar a criatividade, \n" +
                                      "Estimular a organização.",
                    Competencias = "Modelar projeto de sistemas, \n" +
                                   "Selecionar modelos para o desenvolvimento de sistemas.",
                    Habilidades = "Coletar requisitos de usuários e sistemas, \n" +
                                  "Utilizar métodos de abordagem e coleta de dados e procedimentos de pesquisa, \n " +
                                  "Aplicar modelo Cascata no desenvolvimento de sistemas,\n" +
                                  "Aplicar modelos Ágeis a projetos de software.",
                    BasesTecnologicas = "Introdução e conceitos básicos de análise de sistemas e projetos. \r\n" +
                    "Ciclo de vida de um sistema: \n" +
                    "   - Estudo de viabilidade.\n" +
                    "   - Especificação de requisitos.\n" +
                    "   - Concepções do modelo Cascata.\n" +
                    "   - Concepções dos modelos Ágeis.\n" +
                    "   - Introdução à análise e projeto orientado a objetos."

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
                    Nome = "Design Digital",
                    Atribuicoes = "Desenvolver interfaces visuais para aplicativos e sites,\n" +
                                  "Desenvolver elementos gráficos para aplicativos e sites.",
                    ValoresAtitudes = "Incentivar a criatividade,\n" + 
                                      "Incentivar ações que promovam a cooperação,\n" +
                                      "Respeitar as manifestações culturais de outros povos.",
                    Competencias = "Desenvolver interfaces visuais para aplicativos e sites.",
                    Habilidades = "Manipular e/ou construir elementos visuais para aplicativos e sites.",
                    BasesTecnologicas = "Conceitos de Design Gráfico aplicado à construção de aplicativos e sites\n" + 
                                        "Teoria das cores, tipografia e composição\n" + 
                                        "Ferramentas de seleção e manipulação de objetos\n" +
                                        "Ferramentas de edição e tratamento\n" + 
                                        "Transformação de objeto\n" + 
                                        "Timeline, máscara e mesclagem de camadas\n" + 
                                        "Ferramentas de texto\n" + 
                                        "Estilo e filtros de imagens\n" + 
                                        "Manipulação de documentos\n" + 
                                        "Recursos para a criação/manipulação de imagens para a construção de botões, banners, logomarca\n" +
                                        "Regras (Heurísticas) de usabilidade"

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