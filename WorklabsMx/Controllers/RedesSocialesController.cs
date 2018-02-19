using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class RedesSocialesController : DataBaseModel
    {
        public List<RedSocialModel> GetRedSocial(string usuario_id, string usuario_tipo)
        {
            List<RedSocialModel> redes = new List<RedSocialModel>();
            try
            {
                conn.Open();
                command = CreateCommand("select * from vw_pro_Miembros_Redes_Sociales WHERE Miembro_Red_Social_Estatus = 1 AND Usuario_Id = @Usuario_Id AND Usuario_Tipo = @Usuario_Tipo");
                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    redes.Add(new RedSocialModel
                    {
                        Usuario_Red_Social_Id = reader["Miembro_Red_Social_Id"].ToString(),
                        Red_Social_Id = reader["Red_Social_Id"].ToString(),
                        Red_Social_Enlace = reader["Miembro_Red_Social_Enlace"].ToString(),
                        Red_Social_Nombre = reader["Red_Social_Nombre"].ToString(),
                        Red_Social_Icono_Android = reader["Red_Social_Icono_Android"].ToString(),
                        Red_Social_Icono_iOS = reader["Red_Social_Icono_iOS"].ToString(),
                        Red_Social_Icono_Web = reader["Red_Social_Icono_Web"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            return redes;
        }

        public int SetRedSocial(string usuario_id, string usuario_tipo, string red_social_id = null, string red_social_enlace = null, string usuario_red_social_id = null)
        {
            try
            {

                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Usuarios_Etiquetas";

                command.Parameters.AddWithValue("@Trasaccion", string.IsNullOrEmpty(usuario_red_social_id) ? "ALTA" : !string.IsNullOrEmpty(red_social_enlace) ? "MODIFICAR" : "BAJA");

                if (((int)TiposUsuarios.Miembro).ToString() == usuario_tipo)
                {
                    command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                    command.Parameters.AddWithValue("@Colaborador_Id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Colaborador_Id", usuario_id);
                    command.Parameters.AddWithValue("@Miembro_Id", DBNull.Value);
                }
                command.Parameters.AddWithValue("@Red_Social_Id", red_social_id);
                command.Parameters.AddWithValue("@Miembro_Red_Social_Enlace", red_social_enlace);
                if (string.IsNullOrEmpty(usuario_red_social_id))
                    command.Parameters.AddWithValue("@Miembro_Etiqueta_Id", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Miembro_Etiqueta_Id", usuario_red_social_id);
                command.Parameters.Add("@Miembro_Red_Social_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Miembro_Red_Social_Id_Salida"].Value);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
