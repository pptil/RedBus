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
            { orden = "insert into Tarjetas values (" + objtarjeta.NroTarjeta + ", " + objtarjeta.Saldo + ", " + objtarjeta.Dni + ");"; }

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

        #region GET TARJETAS, DNI Y SALDO
        public int GetTarjeta(string cual)
        {
            int resultado = -1;          
            var selectString = "IF EXISTS(SELECT 1 FROM Tarjetas WHERE NroTarjeta = @guid) SELECT 1 ELSE SELECT 0";
            SqlCommand cmd = new SqlCommand(selectString, conexion);

            try
            {
                Abrirconexion();           
                
                cmd.Parameters.AddWithValue("@guid", cual);

                var itExists = (Int32)cmd.ExecuteScalar() > 0;

                if (itExists)
                {
                    resultado = 1;
                }                
              
            }
            catch (Exception e)
            {
                throw new Exception("Error al Encontrar la tarjeta", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
           

            return resultado;
        }
       
        public int GetDNI(string dni)
        {
            int resultado = -1;            
            var selectString = "IF EXISTS(SELECT 1 FROM Persona WHERE DNI = @dni) SELECT 1 ELSE SELECT 0";
            SqlCommand cmd = new SqlCommand(selectString, conexion);

            try
            {
                Abrirconexion();

                cmd.Parameters.AddWithValue("@dni", dni);

                var itExists = (Int32)cmd.ExecuteScalar() > 0;

                if (itExists)
                {
                    resultado = 1;
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error al Encontrar la persona", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }


            return resultado;
        }

        public DataSet GetSaldo(string saldo)
        {          
            string select = ("SELECT Saldo from Tarjetas where NroTarjeta = " + int.Parse(saldo));

            SqlCommand cmd = new SqlCommand(select, conexion);
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
        public bool Comparison(string tar, string per)
        {
           bool resultado = false;

            string select = "select NroTarjeta, DNI from Tarjetas where NroTarjeta like @tar and DNI = @per;";
            SqlCommand cmd = new SqlCommand(select, conexion);
            cmd.Parameters.AddWithValue("@tar", tar);
            cmd.Parameters.AddWithValue("@per", per);

            try
            {
                Abrirconexion();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al Comparar DNI y Tarjeta", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }
        #endregion

        #region DELETE
        public int DeleteTarjeta(Tarjeta tarjeta)
        {

            int resultado = -1;
            string orden = ("DELETE from Tarjetas where NroTarjeta = " + tarjeta.NroTarjeta);

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar borrar la tarjeta", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
    
        #endregion
    }
} 
    

