using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.BLL;


namespace WindowsFormsApp1.DAL
{/*
    internal class ConexionDAL
    {
        private string ConnectionString = "Server=tcp:itsc.database.windows.net,1433;Initial Catalog=sof108;Persist Security Info=False;User ID=fcastillo;Password=GarminBibsMoga48$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.ConnectionString);
            return this.Conexion;

        }
        public bool PruebaConectar()
        {
            try
            {
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "SELECT * FROM cliente";
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

                //DataTable dataTable = new DataTable();

            }
            catch
            {
                return false;
            }

        }
 /*
        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch(Exception e)
            {

                throw new Exception(e.Message)
                {
                    

                };
            }
        }
        //Agregar datos a Cliente
   
}
    */
}
