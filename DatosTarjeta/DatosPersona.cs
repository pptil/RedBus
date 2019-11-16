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
    public class DatosPersona : DatosConexionBD
    {
        public int abmPersona(string accion, Persona objpersona)
        {
            int resultado = -1;
            string orden = string.Empty;
            
                   
            if (accion == "Verify")
            { 
                orden = "select NroTarjeta from Tarjetas where NroTarjeta = " + objpersona.NroTarjeta + " ;";

                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al tratar de guardar la Persona", e);
                }

                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }                
            }

            if (resultado == -1)
            {
                if (accion == "Alta")
                { orden = "insert into Persona values (" + objpersona.DNI + ", '" + objpersona.Nombre + "', '" + objpersona.Sexo + "', '" + objpersona.FechaNac.ToString("yyyy/MM/dd") + "', " + objpersona.CUIT.ToString() + ", '" + objpersona.Tdni + "' ) insert into Tarjetas values ( " + objpersona.NroTarjeta + ", 0, " + objpersona.DNI + ");"; }
                SqlCommand cmd = new SqlCommand(orden, conexion);


                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al tratar de guardar la Persona", e);
                }

                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
               
            }
            else
            {
                resultado = -1;
            }
            return resultado;
        }

           


        public DataSet listadopersonas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select Nombre from Persona where DNI= " + int.Parse(cual) + ";";
            else orden = "select Nombre from Persona;";

            if (cual != "Todos" && cual == orden)
            {

            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet(); SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion(); cmd.ExecuteNonQuery();

                da.SelectCommand = cmd; da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Personas", e);
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

