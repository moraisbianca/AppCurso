using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoCurso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {
        public Inicial()
        {
            InitializeComponent();
            FotoSala2.Source = ImageSource.FromResource("ProjetoCurso.Images.FotoSala2.jpg");
            logo.Source = ImageSource.FromResource("ProjetoCurso.Images.logo.png");            
        }
    }
}