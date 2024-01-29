using Notas.Datos;
using Notas.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Notas.Vista.Notas;

namespace Notas.VistaModelo.VMnotas
{
    public class VMlistarnota : BaseViewModel
    {
        #region VARIABLES


        List<Mnotas> _Listapokemon;
        #endregion
        #region Contructor
        public VMlistarnota(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region Objetivo;
       
        public List<Mnotas> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnpropertyChanged();//es nesario para actualizar tus datos si despues de hacer algun cambio a tus registros o tiempo real

            }
        }
        #endregion
        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new DNotas();
            Listapokemon = await funcion.MostrarPokemon2();//Cambiar esto a MostrarPokemon 2 para que saea en tiempo real
        }

        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new RegistarNota());
        }
        public async Task IraEditar(Mnotas Pokemon)
        {
            await Navigation.PushAsync(new EditarNota(Pokemon));
        }

        #endregion.

        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        public ICommand IraEditarcommand => new Command<Mnotas>(async (p) => await IraEditar(p));
        #endregion



    }
}
