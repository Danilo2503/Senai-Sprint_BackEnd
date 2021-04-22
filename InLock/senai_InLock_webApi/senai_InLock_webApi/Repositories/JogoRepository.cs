using senai_InLock_webApi.Domains;
using senai_InLock_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_InLock_webApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetros
        /// </summary>
        private string stringConexao = "Data Source=DESKTOP-SBKVIFR\\SQLEXPRESS; initial catalog=InLock_Games_Manha; user Id=sa; pwd=agera555";

        public void AtualizaIdCorpo(JogoDomain jogo)
        {
            throw new NotImplementedException();
        }

        public JogoDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(JogoDomain novoJogo)
        {
        }
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<JogoDomain> ListarTodos()
        {
            //Cria uma lista ListaJogos onde serão armazenados os dados
            List<JogoDomain> listaJogos = new List<JogoDomain>();

            //Decvlara a SqlConnection com a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelecyAll = "SELECT idJogo, Nome FROM Jogos";

                con.Open();

                SqlDataReader rdr;

                //Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmento
                using (SqlCommand cmd = new SqlCommand(querySelecyAll, con))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();


                    //Enquanto houver  registros para serem lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain()
                        {
                            //Atribui a propriedade idJogo o valor da primeira coluna da tabela do banco de dados
                            idJogo = Convert.ToInt32(rdr[0]),

                            //Atribui à propriedade nome o valor da seguynda coluna da tabela do banco de dados
                            nomeJogo = rdr[1].ToString()
                        };

                        // Adiciona o objeto genero a lista listaJogos
                        listaJogos.Add(jogo);
                    }

                }

                //Retorna a lista de jogo
                return listaJogos;
            }
        }
    }
}

