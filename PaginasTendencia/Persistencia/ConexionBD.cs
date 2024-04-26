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
        string cadenaConexion = @"Persist Security Info=False;User ID=diego;Password=123456.;Database=BattleRoyale;Server=CAMILA\SQLEXPRESS;TrustServerCertificate=true;";
        
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

        public Pagina ObtenerPagina(string busqueda)
        {
            Pagina pagina = new Pagina();
            try
            {
                Conectar();

                //string instruccion = $"{Instrucciones.SP_ObtenerPagina} {busqueda}";
                string instruccion = " EXEC Obtenerjugadores";
                SqlDataAdapter adapter = new SqlDataAdapter(instruccion, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Todo bien
                    if (true)
                    {
                        //todo bein
                    }
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
