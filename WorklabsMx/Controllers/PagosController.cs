using System;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class PagosController : DataBaseModel
    {
        public PromocionModel AplicarCupon(string cupon)
        {
            PromocionModel promo = new PromocionModel();
            string query = "SELECT Descuento_Id, Promocion_Descripcion, Descuento_Descripcion, Descuento_Porcentaje, Codigo_Promocion_Descripcion " +
                "FROM vw_cat_Promociones_Codigos WHERE Codigo_Promocion_Descripcion = @cupon AND " +
                "GETDATE() Between Promocion_Fecha_Inicio AND Promocion_Fecha_Fin";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@cupon", cupon);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    promo = new PromocionModel
                    {
                        Descuento_Id = reader["Descuento_Id"].ToString(),
                        Descuento_Descripcion = reader["Descuento_Descripcion"].ToString(),
                        Descuento_Porcentaje = Convert.ToDecimal(reader["Descuento_Porcentaje"].ToString()),
                        Promocion_Descripcion = reader["Promocion_Descripcion"].ToString(),
                        Codigo_Promocion_Descripcion = reader["Codigo_Promocion_Descripcion"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return promo;
        }

        public bool RealizarPago()
        {
            try
            {
                
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            return true;
        }
    }
}
