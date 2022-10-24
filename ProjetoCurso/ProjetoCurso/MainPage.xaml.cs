using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using ProjetoCurso.View;

namespace ProjetoCurso
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("ProjetoCurso.Images.logo.png");
            logocps.Source = ImageSource.FromResource("ProjetoCurso.Images.logocps.png");
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private async void Open_Inicial(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Open_Primeiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PrimeiroAno)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Segundo(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SegundoAno)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Terceiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TerceiroAno)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Vestibulinho(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Contato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
