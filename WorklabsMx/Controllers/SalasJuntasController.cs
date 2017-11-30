using System;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class SalasJuntasController : DataBaseModel
    {
        public bool AsignarSalaJuntas()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_cat_Miembros_Empresas_Domicilios_Fiscales";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Trasaccion", "ALTA");
                /*command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Id", Domicilio_Fiscal_Empresa_Id);
                command.Parameters.AddWithValue("@Empresa_Miembro_Id", empresa_miembro_id);
                command.Parameters.AddWithValue("@Territorio_Id", territorio_id);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Calle", calle);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Numero_Exterior", numExterior);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Numero_Interior", numInterior);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Correo_Electronico", correo);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Estatus", 1);
                command.Parameters.Add("@Domicilio_Fiscal_Empresa_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;*/

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();


            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return true;
        }
    }
}
