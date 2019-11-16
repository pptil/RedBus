using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace DatosTarjeta
{
    public class DatosRedBus : DatosConexionBD
    {
        public int Saldo(string accion, Tarjeta objtarjeta)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Sumar")
            { orden = "update Tarjetas set Saldo= " + objtarjeta.Saldo + "where NroTarjeta =" + objtarjeta.NroTarjeta; }
            if (accion == "Restar")
            { orden = "update Tarjetas set Saldo= " + objtarjeta.Saldo + "where NroTarjeta =" + objtarjeta.NroTarjeta; }

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar o Restar Saldo", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }
        public int abmTarjetas(string accion, Tarjeta objtarjeta)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            { orden = "insert into Tarjetas values (" + objtarjeta.NroTarjeta + ", " + objtarjeta.Saldo + ");"; }

            if (accion == "Modificar")
            { orden = "update Tarjetas set Saldo = " + objtarjeta.Saldo + "where NroTarjeta=" + objtarjeta.NroTarjeta + ";"; }



            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar Tarjetas", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

      
        public DataSet listadoTarjetas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select NroTarjeta, Saldo from Tarjetas where NroTarjeta = " + int.Parse(cual) + ";";
            else 
                orden = "select NroTarjeta, Saldo, a.DNI, Nombre from Tarjetas b, Persona a where b.DNI = a.DNI;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion(); cmd.ExecuteNonQuery();

                da.SelectCommand = cmd; da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Tarjetas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
} 
    

