using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notas.Conexion
{
    internal class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmnotasjose-default-rtdb.firebaseio.com/");
    }
}
