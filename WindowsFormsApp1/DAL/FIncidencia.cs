using System.Data;
using System.Data.SqlClient;
using ProyectoBD;
using WindowsFormsApp1.BLL;

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

        public static DataSet Insertar(IncidenteBLL incidente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Estado", SqlDbType.VarChar, 0,incidente.Estado),
                    FDBHelper.MakeParam("@Fecha", SqlDbType.DateTime, 0,incidente.Fecha),
                    FDBHelper.MakeParam("@Comentario", SqlDbType.VarChar, 0,incidente.Comentario),
                };
            return FDBHelper.ExecuteDataSet("sp_add_incidentes", dbParams);
            //crear procedure de incertar incidente ir a base de datos.
        }
    }
}
