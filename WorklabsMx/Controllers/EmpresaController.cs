using System;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class EmpresaController : DataBaseModel
    {
        public EmpresaController(): base()
        {
        }
		/// <summary>
		/// Obtiene los datos de la empresa
		/// </summary>
		/// <returns>Datos de la empresa</returns>
		/// <param name="miembro_id">Identificador del miembro</param>
		public EmpresaModel GetEmpresaMiembro(string miembro_id)
		{
			EmpresaModel empresa = new EmpresaModel();
			string query = "SELECT Giro_Descripcion, Empresa_Miembro_Red_Social_3, Empresa_Miembro_Red_Social_2, " +
				"Empresa_Miembro_Red_Social_1, Empresa_Miembro_Pagina_Web, Empresa_Miembro_Telefono, " +
				"Empresa_Miembro_Correo_Electronico, Empresa_Miembro_Numero_Interior, " +
				"Empresa_Miembro_Numero_Exterior, Empresa_Miembro_Calle, Empresa_Miembro_Nombre, " +
				"Empresa_Miembro_Rfc, Empresa_Miembro_Razon_Social, Empresa_Miembro_Id, Territorio_Estado_Descripcion, " +
				"Territorio_Municipio_Descripcion, Territorio_Colonia_Descripcion, Territorio_Cp, Empresa_Miembro_Logotipo " +
				"FROM vw_cat_Miembros_Empresas WHERE Miembro_Id = @miembro_id";

			try
			{
				conn.Open();
				command = CreateCommand(query);
				command.Parameters.AddWithValue("@miembro_id", miembro_id);
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					empresa = new EmpresaModel
					{
						Giro_Descripcion = reader["Giro_Descripcion"].ToString(),
						Empresa_Miembro_Red_Social_3 = reader["Empresa_Miembro_Red_Social_3"].ToString(),
						Empresa_Miembro_Red_Social_2 = reader["Empresa_Miembro_Red_Social_2"].ToString(),
						Empresa_Miembro_Red_Social_1 = reader["Empresa_Miembro_Red_Social_1"].ToString(),
						Empresa_Miembro_Pagina_Web = reader["Empresa_Miembro_Pagina_Web"].ToString(),
						Empresa_Miembro_Telefono = reader["Empresa_Miembro_Telefono"].ToString(),
						Empresa_Miembro_Correo_Electronico = reader["Empresa_Miembro_Correo_Electronico"].ToString(),
						Empresa_Miembro_Numero_Interior = reader["Empresa_Miembro_Numero_Interior"].ToString(),
						Empresa_Miembro_Numero_Exterior = reader["Empresa_Miembro_Numero_Exterior"].ToString(),
						Empresa_Miembro_Calle = reader["Empresa_Miembro_Calle"].ToString(),
						Empresa_Miembro_Nombre = reader["Empresa_Miembro_Nombre"].ToString(),
						Empresa_Miembro_Rfc = reader["Empresa_Miembro_Rfc"].ToString(),
						Empresa_Miembro_Razon_Social = reader["Empresa_Miembro_Razon_Social"].ToString(),
                        Empresa_Miembro_Logotipo = reader["Empresa_Miembro_Logotipo"].ToString(),
						Empresa_Miembro_Id = reader["Empresa_Miembro_Id"].ToString(),
						Territorio_Estado_Descripcion = reader["Territorio_Estado_Descripcion"].ToString(),
						Territorio_Municipio_Descripcion = reader["Territorio_Municipio_Descripcion"].ToString(),
						Territorio_Colonia_Descripcion = reader["Territorio_Colonia_Descripcion"].ToString(),
						Territorio_Cp = reader["Territorio_Cp"].ToString()
					};
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				conn.Close();
			}

			return empresa;
		}
    }
}
