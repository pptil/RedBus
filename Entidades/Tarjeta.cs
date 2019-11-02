using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        public class Tarjeta
        {
            #region atributos         
            private int nrotarjeta;
            private int dni;
            private int saldo;
           // private int addres;
            private string nombre;
            #endregion

            #region Constructor         
            public Tarjeta()
            {
                nrotarjeta = 0;
                dni = 0;
                saldo = 0;
                nombre = string.Empty;
                //addres = 0;
            }
            
        
            #endregion

            #region propiedades/encapsulamiento         
            public int NroTarjeta { get { return nrotarjeta; } set { nrotarjeta = value; } }
            public int Dni { get { return dni; } set { dni = value; } }
            public int Saldo { get { return saldo; } set { saldo = value; } }
            //public int AddRes { get { return addres; } set { addres = value; } }
            public string Nombre { get { return nombre; } set { nombre = value; } }
            #endregion
        
        
            #region Metodos
            public int Sumar(int monto)
            {
                saldo += monto;
                return saldo;  
            }
            
            public int Restar(int monto)
            {
            saldo -= monto;
            return monto;
            }
            #endregion
        }


}

