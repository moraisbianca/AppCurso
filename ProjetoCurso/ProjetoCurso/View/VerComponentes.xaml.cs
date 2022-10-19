using ProjetoCurso.Model;
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
    public partial class VerComponentes : ContentPage
    {
        public VerComponentes(Componente c)
        {
            InitializeComponent();

            BindingContext = c;
        }
    }
}