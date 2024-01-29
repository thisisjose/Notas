using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notas.VistaModelo.VMnotas;

namespace Notas.Vista.Notas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistarNota : ContentPage
    {
        public RegistarNota()
        {
            InitializeComponent();
            BindingContext = new VMregistrarnota(Navigation);
        }
    }
}