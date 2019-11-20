using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DatosTarjeta;

namespace Capsula
{
    public class CapsulaPersona
    {
        DatosPersona objDatosPersona = new DatosPersona();

        public int abmPersona(string accion, Persona objpersona )
        { return objDatosPersona.abmPersona(accion, objpersona); }

        public string GetNombre(string cual)
        {
            return objDatosPersona.GetNombre(cual);
        }
        public DataSet listadopersonas(string cual) { return objDatosPersona.listadopersonas(cual); }
    }
}
