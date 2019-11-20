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
    public class CapsulaTarjeta
    {
        DatosRedBus objDatosRedBus = new DatosRedBus();

        public int abmTarjetas(string accion, Tarjeta objTarjeta)
        { return objDatosRedBus.abmTarjetas(accion, objTarjeta); }

        public DataSet listadoTarjetas(string cual) 
        { return objDatosRedBus.listadoTarjetas(cual); }

        public int GetTarjeta(string cual)
        {
            return objDatosRedBus.GetTarjeta(cual);
        }

        public int GetDNI(string dni)
        {
            return objDatosRedBus.GetDNI(dni);
        }

        public bool Verificar(string tar, string per)
        {
            return objDatosRedBus.Comparison(tar, per);
        }
        public int SumRes (string accion, Tarjeta tarjeta)
        { return objDatosRedBus.Saldo(accion, tarjeta); }
    }
}
