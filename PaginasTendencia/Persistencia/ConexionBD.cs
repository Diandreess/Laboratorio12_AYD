using ModeloDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ConexionBD
    {
        string cadenaConexion = @"Persist Security Info=False;User ID=Admin;Password=hola123;Database=Lab12AYD;Server=LAPTOP-BIKSR615\SQLEXPRESS;TrustServerCertificate=true;";
        
        SqlConnection conexion;

        public void Conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public Pagina ObtenerPagina(string nombrePagina)
        {
            Pagina pagina = new Pagina();
            try
            {
                Conectar();

                string instruccion = $"{Instrucciones.SP_ObtenerInformacionPagina} {nombrePagina}";
                SqlDataAdapter adapter = new SqlDataAdapter(instruccion, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Pagina respuesta = new Pagina();
                    respuesta.Titulo = dt.Rows[0]["Titulo"].ToString();
                    respuesta.FechaPublicacion = dt.Rows[0]["FechaPublicacion"].ToString();

                    return respuesta;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally { conexion.Close(); }
            return new Pagina();
        }
    }
}
