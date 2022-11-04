using ProyectoDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kibernum.Data
{
    public class PersonaData
    {
        public bool Insertar(PersonaDTO persona)
        {
            using (SqlConnection connection = new SqlConnection("Data source=DESKTOP-7T3SDNA\\SQLEXPRESS;initial catalog='Personas';integrated security=true"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"INSERT INTO [dbo].[Persona]
                                               ([Documento]
                                               ,[Nombres]
                                               ,[Apellidos]
                                               ,[FechaNacimiento]
                                               ,[NumerosTelefonicos]
                                               ,[CorreosElectronicos]
                                               ,[DirecionesFisicas])
                                         VALUES
                                               (@Documento 
                                               ,@Nombres
                                               ,@Apellidos 
                                               ,@FechaNacimiento
                                               ,@NumerosTelefonicos
                                               ,@CorreosElectronicos
                                               ,@DirecionesFisicas)";
                    command.Parameters.AddWithValue("@Documento", persona.Documento);
                    command.Parameters.AddWithValue("@Nombres", persona.Nombres);
                    command.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);
                    command.Parameters.AddWithValue("@NumerosTelefonicos", persona.NumerosTelefonicos);
                    command.Parameters.AddWithValue("@CorreosElectronicos", persona.CorreosElectronicos);
                    command.Parameters.AddWithValue("@DirecionesFisicas", persona.DirecionesFisicas);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        if (recordsAffected > 0)
                            return true;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("UniqueConstraint"))
                            throw new Exception("No pueden registrarse dos personas con el mismo documento");

                        throw;
                    }
                }
            }
            return false;
        }
    }
}
