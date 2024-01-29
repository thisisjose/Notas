using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;
using Notas.Conexion;
using Notas.Modelo;
using Firebase.Database;



namespace Notas.Datos
{
    public class DNotas
    {
        public async Task Insertarpokemon(Mnotas parametros)
        {
            await Cconexion.firebase.Child("Pokemon").PostAsync(new Mnotas
            {

                Titulo = parametros.Titulo,
                Texto = parametros.Texto

            });

        }

        public async Task<List<Mnotas>> MostrarPokemon2()
        {
            return (await Cconexion.firebase.Child("Pokemon")
                    .OnceAsync<Mnotas>())
                    .Select(item => new Mnotas
                    {
                        Idnotas = item.Key,
                        Titulo = item.Object.Titulo,
                        Texto = item.Object.Texto
                    }).ToList();
        }
        public async Task Eliminarpokemon(Mnotas mnotas)
        {
            string id = mnotas.Idnotas;
            await Cconexion.firebase.Child("Pokemon").Child(id).DeleteAsync();
        }
        public async Task Actualizar(Mnotas parametros)
        {
            await Cconexion.firebase.Child("Pokemon").Child(parametros.Idnotas).PutAsync(new Mnotas
            {
                Titulo = parametros.Titulo,
                Texto = parametros.Texto

            });

        }

    }
}
