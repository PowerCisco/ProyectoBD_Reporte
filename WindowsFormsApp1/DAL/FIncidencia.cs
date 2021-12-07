using System.Data;
using System.Data.SqlClient;
using ProyectoBD;
using WindowsFormsApp1.BLL;
using System;


namespace WindowsFormsApp1.DAL
{
    internal class FIncidencia
    {
      public static DataSet GetAll()
        { 
           SqlParameter[] dbParams = new SqlParameter[]
               {
                  
               };
           return FDBHelper.ExecuteDataSet("sp_getall_incidentes", dbParams);
        
        }

        public static int Insertar(IncidenteBLL incidente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Estado", SqlDbType.VarChar, 0,incidente.Estado),
                    FDBHelper.MakeParam("@Fecha", SqlDbType.DateTime, 0,incidente.Fecha),
                    FDBHelper.MakeParam("@Comentario", SqlDbType.VarChar, 0,incidente.Comentario),
                    FDBHelper.MakeParam("@IDcliente", SqlDbType.Int, 0,incidente.IDCliente),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("sp_add_incidentes", dbParams));
           
        }

        public static int Actualizar(IncidenteBLL incidente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                     FDBHelper.MakeParam("@ID", SqlDbType.Int, 0,incidente.ID),

                    FDBHelper.MakeParam("@Estado", SqlDbType.VarChar, 0, incidente.Estado),
                    FDBHelper.MakeParam("@Fecha", SqlDbType.DateTime, 0, incidente.Fecha),
                   FDBHelper.MakeParam("@Comentario", SqlDbType.VarChar, 0,incidente.Comentario),
           

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("sp_update_incidentes", dbParams));

        }
    }
}
