using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASSWORD__Problema_4._5_
{
    internal class Password
    {
        //ATRIBUTOS
        private int longitud = 8;
        private string valor;

        //PROPIEDADES
        public int Longitud { get { return longitud; } }
        public string Valor { get { return valor; } set { valor = value; } }

        //CONSTRUCTOR SIN PARAMETROS
        public Password() { }

        //--------------METODOS PARA RESOLVER EL PROBLEMA----------------------------//

        //verificar si la contraseña es fuerte 
        public bool EsFuerte(string contrasena)
        {
            int mayus = 0;
            int minus = 0;
            int numeros = 0;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) mayus++;
                else if (char.IsLower(c)) minus++;
                else if (char.IsDigit(c)) numeros++;
            }


            return mayus > 2 && minus > 1 && numeros > 5;
        }

        //verificar que cumpla el minimo de longitud
        public bool LongitudMinima(string constraseña)
        { 
            return constraseña.Length > Longitud;
        }

        //generar una contraseña aleatoria 
        public void GenerarPassword()
        { 
            const string caracteres  = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random rnd = new Random ();
            char[] clave = new char[Longitud];

            for (int i = 0; i < clave.Length; i++)
            {
                clave[i] = caracteres[rnd.Next (caracteres.Length)];
            }
            valor = new string(clave);

        }

        public string getValor()
        {
            return Valor;
        }
    }
}
