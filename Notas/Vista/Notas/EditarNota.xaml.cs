using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notas.VistaModelo.VMnotas;
using Notas.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notas.Vista.Notas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarNota : ContentPage
    {
        public EditarNota(Mnotas poquimon)
        {
            InitializeComponent();
            BindingContext = new VMeditarnota(Navigation, poquimon);
        }
    }
}