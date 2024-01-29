using Notas.Datos;
using Notas.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Notas.VistaModelo.VMnotas
{
    public class VMregistrarnota : BaseViewModel
    {
        #region
        string _TxtTitulo;
        string _TxtTexto;
        string _TxtID;
        #endregion
        #region Contructor
        public VMregistrarnota(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;

        public string TxtTitulo
        {
            get { return _TxtTitulo; }
            set { SetValue(ref _TxtTitulo, value); }
        }
        public string TxtTexto
        {
            get { return _TxtTexto; }
            set { SetValue(ref _TxtTexto, value); }
        }

        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new DNotas();
            var parametros = new Mnotas();
            parametros.Titulo = TxtTitulo;
            parametros.Texto = TxtTexto;
            await funcion.Insertarpokemon(parametros);
            await Volver();
        }


        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        #endregion.

        #region CONTRUCTOR
        #endregion.

        #region COMANDOS
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        #endregion
    }
}
