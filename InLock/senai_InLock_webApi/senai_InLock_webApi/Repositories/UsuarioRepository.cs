using senai_InLock_webApi.Domains;
using senai_InLock_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_InLock_webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=DESKTOP-SBKVIFR\\SQLEXPRESS; initial catalog=InLock_Games_Manha; user Id=sa; pwd=agera555";

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryLogin = "SELECT IdUsuario, Email, Senha, IdTipoUsuario " +
                                   "FROM Usuarios " +
                                   "WHERE Email = @Email AND Senha = @Senha";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuarioBuscado = new UsuarioDomain()
                        {
                            idUsuario = Convert.ToInt32(rdr[0]),
                            email = rdr[1].ToString(),
                            senha = rdr[2].ToString(),
                            idTipoUsuario = Convert.ToInt32(rdr[3])
                        };
                        return usuarioBuscado;
                    }
                    return null;
                }

            }

        }

    }

}

