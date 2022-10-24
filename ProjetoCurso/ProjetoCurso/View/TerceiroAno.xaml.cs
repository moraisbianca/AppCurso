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
    public partial class TerceiroAno : ContentPage
    {
        public TerceiroAno()
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
                    Nome = "Programação Web III",
                    Atribuicoes = "Documentar, construir e manter sistemas de informação para web.",
                    ValoresAtitudes = "Incentivar a criatividade.\r\n" +
                                      "Responsabilizar-se pela produção, utilização e divulgação de informações.\r\n" +
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Desenvolver sistemas multicamadas, utilizando framework de desenvolvimento web." + 
                                   "Desenvolver serviços para o usuário utilizando recursos dos dispositivos móveis.",
                    Habilidades = "Utilizar conjunto de bibliotecas (framework) para o desenvolvimento Web\n" +
                                  "Utilizar recursos dos dispositivos móveis na integração de aplicativos para internet.\n" +
                                  "Construir aplicativos para internet.",
                    BasesTecnologicas = "Integração de sistemas com serviços para a Web\n" +
                                        "Padrão de arquitetura de software Model - View - Controller(MVC)\n" +
                                        "Utilização de frameworks Model-View-Controller (MVC) para o desenvolvimento Web\n" +
                                        "Técnicas adicionais para o desenvolvimento Web"

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
                    Nome = "Programação de Aplicativos Mobile II",
                    Atribuicoes = "Documentar, construir e manter sistemas de informação para plataformas móveis.\n",
                    ValoresAtitudes = "Incentivar a criatividade.\n" +
                                      "Estimular a organização.\n" +
                                      "Responsabilizar-se pela produção, utilização e divulgação de informações",
                    Competencias = "Projetar aplicativos, selecionando linguagens de programação e ambientes de desenvolvimento.",
                    Habilidades = "Utilizar ambientes de desenvolvimento mobile.\n" +
                                  "Elaborar aplicativos com acesso a banco de dados\n" +
                                  "Construir layout de aplicativos dispositivos móveis.\n" +
                                  "Utilizar recursos avançados do dispositivo (smartphones e tablets)",
                    BasesTecnologicas = "Consumindo APIs e serviços Web\n" +
                                        "Localização e mapas\n" +
                                        "Sensores\n" + "Widgets\n" + "Notificações\n" + "Permissões\n" + "Interação com outros apps\n" + 
                                        "Concorrência\n" +
                                        "Interação com dispositivos sem fio"

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }


        private async void SegSistInfo(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Internet, Protocolos e segurança de sistemas da informação",
                    Atribuicoes = "Implementar rotinas de segurança da informação.\n" +
                                  "Utilizar protocolos de redes e internet para comunicação de dados.",
                    ValoresAtitudes = "Incentivar comportamentos éticos.\n" +
                                      "Promover ações que considerem o respeito às normas estabelecidas.\n" +
                                      "Fortalecer a persistência e o interesse na resolução de situações-problema.",
                    Competencias = "Configurar os principais serviços de redes de comunicação de dados e internet para o desenvolvimento de sistemas.\n" +
                                   "Desenvolver sistemas implementando rotinas de segurança de dados.",
                    Habilidades = "Identificar modelo de referência de arquitetura de redes de comunicação de dados e internet para a escolha de protocolos adequados aos sistemas em desenvolvimento.\n" +
                                  "Utilizar protocolos de rede e de comunicação de dados que auxiliem no desenvolvimento de sistemas." +
                                  "Identificar ameaças à segurança da informação.\n" +
                                  "Utilizar técnicas de segurança da informação.\n" +
                                  "Operar mecanismos de segurança da informação no desenvolvimento de sistemas.",
                    BasesTecnologicas = "Introdução aos modelos de referência de arquiteturas de redes (OSI/ISO)\n" +
                                        "Camadas física, de enlace e de rede\n" +
                                        "Camadas de transporte e aplicação\n" + "Protocolo de transferência de Hipertexto\n" + "Conceitos de Segurança da Informação\n" + "Cartilha de Segurança para Internet\n" + "Mecanismos de Segurança\n" +
                                        "Características de segurança da informação\n" + "Políticas de segurança\n" + "Criptografia e Firewall\n" + "Segurança em redes de computadores e dispositivos móveis\n" +
                                        "Identificação de vulnerabilidades\n" + "Engenharia social\n" + "Varredura/análise\n" + "Negação de serviço - DoS e DDoS\n" + "Testes de penetração e de vulnerabilidades\n" +
                                        "Injection SQL\n" + "Footprint - descoberta de informações"

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void PlanejTCC(object sender, EventArgs e)
        {



            try
            {
                var c = new Componente
                {
                    Nome = "Planejamento e Desenvolvimento do Trabalho de Conclusão de Curso (TCC)",
                    Atribuicoes = "Planejar e desenvolver projetos de sistemas computacionais.\n" + 
                                  "Comunicar-se com a equipe com clareza e objetividade.\n" + 
                                  "Demonstrar comprometimento com a equipe e o trabalho.\n" + 
                                  "Planejar ações mais eficazes no desenvolvimento de sistemas.\n" + 
                                  "Organizar procedimentos de maneira diversa, visando melhor eficiência.",
                    ValoresAtitudes = "Estimular a organização.\n" + 
                                      "Incentivar comportamentos éticos.\n" + 
                                      "Responsabilizar-se pela produção, utilização e divulgação de informações.\n",
                    Competencias = "Analisar dados e informações obtidas de pesquisas empíricas e bibliográficas.",
                    Habilidades = "Identificar demandas e situações-problema no âmbito da área profissional.\n" +
                                  "Identificar fontes de pesquisa sobre o objeto em estudo.\n" +
                                  "Elaborar instrumentos de pesquisa para desenvolvimento de projetos.\n" +
                                  "Constituir amostras para pesquisas técnicas e científicas, de forma criteriosa e explicitada.\n" +
                                  "Aplicar instrumentos de pesquisa de campo.\n" + 
                                  "Consultar legislação, normas e regulamentos relativos ao projeto.\n" + 
                                  "Registrar as etapas do trabalho\n"  + "Organizar os dados obtidos na forma de textos, planilhas, gráficos e esquemas.\n" +
                                  "Consultar legislação, normas e regulamentos relativos ao projeto.\n" +
                                  "Elaborar modelo de negócio para uma empresa de software.\n" +
                                  "Articular conhecimentos de empreendedorismo na construção de projetos de software",
                    BasesTecnologicas = "Consultar legislação, normas e regulamentos relativos ao projeto.\n" +
                                        "Estudo do cenário da área profissional\n" +
                                        "Normas e regulamentos para a gestão ambiental e Segurança do Trabalho aplicados aos projetos da área de Desenvolvimento de Sistemas\n" +
                                        "Identificação e definição de temas para o TCC\n" + "Definição do cronograma de trabalho\n" + "Técnicas de pesquisa\n" + "Problematização\n" +
                                        "Utilização de ferramentas como, por exemplo, Instrumentos de Modelagem de Negócios Business Model Generation, Lean Canvas, dentre outras\n"

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void TesteSoftware(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Qualidade e Teste de Software",
                    Atribuicoes = "Testar softwares para melhoria da qualidade de sistemas.\n" + "Elaborar registros e planilhas de acompanhamento e controle das atividades.",
                    ValoresAtitudes = "Desenvolver criticidade.\n" +
                                      "Incentivar comportamentos éticos.\n" +
                                      "Responsabilizar-se pela produção, utilização e divulgação de informações",
                    Competencias = "Avaliar e selecionar técnicas de teste de software.",
                    Habilidades = "Utilizar softwares de apoio ao teste de sistemas.\n" +
                                  "Verificar e validar correspondência entre a especificação e o produto testado.",
                    BasesTecnologicas = "Qualidade e teste de Software\n" + "Testes de Software\n" + "Processo de Teste\n" + "Ferramentas e execução de testes\n" + "Desenvolvimento guiado por testes (TDD)"
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