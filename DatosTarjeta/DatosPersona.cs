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

                if (accion == "Alta")
                { orden = "insert into Persona values (" + objpersona.DNI + ", '" + objpersona.Nombre + "', '" + objpersona.Sexo + "', '" + objpersona.FechaNac.ToString("yyyy/MM/dd") + "', " + objpersona.CUIT.ToString() + ", '" + objpersona.Tdni + "');"; }
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

            return resultado;
        }

           
        public string GetNombre(string cual)
        {

            var resultado = string.Empty;
            string orden = "select Nombre from Persona where DNI = " + int.Parse(cual) + "; ";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion(); 
                resultado = cmd.ExecuteScalar().ToString();
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
            return resultado;


        }

        public DataSet listadopersonas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select Nombre from Persona where DNI= " + int.Parse(cual) + ";";
            else orden = "select Nombre from Persona;";


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

