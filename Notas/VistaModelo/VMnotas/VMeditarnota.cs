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
    public class VMeditarnota : BaseViewModel
    {
        #region VARIABLES

        string _TxtTitulo;
        string _TxtTexto;
        public Mnotas _Pokemon { get; set; }
        #endregion
        #region Contructor
        public VMeditarnota(INavigation navigation, Mnotas pokemon)
        {
            Navigation = navigation;
            _Pokemon = pokemon;
        }
        #endregion
        #region Objetivo;

        public string TxtTitulo
        {
            get { return _Pokemon.Titulo; }
            set { SetValue(ref _TxtTitulo, value); }
        }
        public string TxtTexto
        {
            get { return _Pokemon.Texto; }
            set { SetValue(ref _TxtTexto, value); }
        }


        #endregion
        #region PROCESOS

        public async Task Editar()
        {
            var funcion = new DNotas();
            var parametros = new Mnotas();
            parametros.Idnotas = _Pokemon.Idnotas;
            parametros.Titulo = TxtTitulo;
            parametros.Texto = TxtTexto;

            await funcion.Actualizar(parametros);
            await Volver();
        }

        public async Task Eliminar()
        {

            var funcion = new DNotas();
            await funcion.Eliminarpokemon(_Pokemon);
            await Volver(); ;
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }



        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        public ICommand Editarcommand => new Command(async () => await Editar());
        public ICommand Eliminarcommand => new Command(async () => await Eliminar());

        public ICommand Volvercommand => new Command(async () => await Volver());

        #endregion

    }
}
