using Notas.VistaModelo.VMnotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notas.Vista.Notas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarNota : ContentPage
    {
        VMlistarnota vM;//esto es para cuando este usando lista
        public ListarNota()
        {
            InitializeComponent();
            vM = new VMlistarnota(Navigation);
            BindingContext = vM;
            this.Appearing += Listapokemon_Appearing;
        }

        //desactivarlo cuando este usando la aplicacion en tiempo real
        private async void Listapokemon_Appearing(object sender, EventArgs e)
        {
            await vM.Mostrarpokemon();
        }
    }
}