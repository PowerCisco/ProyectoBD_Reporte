using System.Data;
using System.Data.SqlClient;
using ProyectoBD;
using WindowsFormsApp1.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    internal class FCliente
    {
      public static DataSet GetAll()
        { 
           SqlParameter[] dbParams = new SqlParameter[]
               {
                  
               };
           return FDBHelper.ExecuteDataSet("sp_getall_clientes", dbParams);
        
        }

        public static int Insertar(ClienteBLL cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,cliente.Nombre),
                    FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0,cliente.Apellido),
                    FDBHelper.MakeParam("@Cedula", SqlDbType.VarChar, 0,cliente.Cedula),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0,cliente.Telefono),
                     FDBHelper.MakeParam("@Email", SqlDbType.VarChar, 0,cliente.Email)


                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("sp_add_cliente", dbParams));
      
        }

        public static int Actualizar(ClienteBLL cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                                        FDBHelper.MakeParam("@ID", SqlDbType.Int, 0,cliente.ID),

                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,cliente.Nombre),
                    FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0,cliente.Apellido),
                    FDBHelper.MakeParam("@Cedula", SqlDbType.VarChar, 0,cliente.Cedula),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0,cliente.Telefono),
                     FDBHelper.MakeParam("@Email", SqlDbType.VarChar, 0,cliente.Email)


                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("sp_update_cliente", dbParams));
                    }
    }

}
 