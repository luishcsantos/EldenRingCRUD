using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EldenRingCRUD.Models;

namespace EldenRingCRUD.Data
{
    public class BossRepository
    {
        // CRUD

        #region SALVAR

        public void Salvar(Boss b)
        {
            //using garante que a conexão seja fechada após o uso
            using (var conn = ConexaoDB.ObterConexao())
            {
                conn.Open(); // Abre a conexão com o banco

                string sql = @"INSERT INTO bosses
                       (id, name, image, description, location, drops, healthPoints) 
                        VALUES(@id, @name, @image, @description, @location, @drops, @healthPoints)";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", b.Id);
                cmd.Parameters.AddWithValue("@name", b.Name);
                cmd.Parameters.AddWithValue("@image", b.Image);
                cmd.Parameters.AddWithValue("@description", b.Description);
                cmd.Parameters.AddWithValue("@location", b.Location);
                cmd.Parameters.AddWithValue("@drops", b.Drops);
                cmd.Parameters.AddWithValue("@healthPoints", b.HealthPoints);

                cmd.ExecuteNonQuery(); // não retorna linhas
                // apenas executa a ação INSERT, SELECT
            }
        }

        #endregion

        #region LISTAR

        // método que retorna uma lista de bosses
        public List<Boss> ListarTodos()
        {
            var lista = new List<Boss>(); // cria uma lista vazia
            using (var conn = ConexaoDB.ObterConexao())
            {
                conn.Open(); //abre a conexão com o banco
                var cmd = new MySqlCommand("SELECT * FROM bosses", conn);
                //percorre os resultados linha por linha
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Boss
                    {
                        Id = reader.GetString("id"),
                        Name = reader.GetString("name"),
                        Image = reader.GetString("image"),
                        Description = reader.GetString("description"),
                        Location = reader.GetString("location"),
                        Drops = reader.GetString("drops"),
                        HealthPoints = reader.GetString("healthPoints")
                    });
                }
            }
            return lista; // devolve a lista preenchida
        }

        #endregion

        #region ATUALIZAR

        public void Atualizar(Boss b)
        {
            using (var conn = ConexaoDB.ObterConexao())
            {
                conn.Open();
                string sql = @"UPDATE bosses SET 
                                name=@name, 
                                image=@image, 
                                description=@description, 
                                location=@location, 
                                drops=@drops, 
                                healthPoints=@healthPoints
                               WHERE id=@id";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", b.Id);
                cmd.Parameters.AddWithValue("@name", b.Name);
                cmd.Parameters.AddWithValue("@image", b.Image);
                cmd.Parameters.AddWithValue("@description", b.Description);
                cmd.Parameters.AddWithValue("@location", b.Location);
                cmd.Parameters.AddWithValue("@drops", b.Drops);
                cmd.Parameters.AddWithValue("@healthPoints", b.HealthPoints);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region DELETAR

        public void Deletar(string id)
        {
            using (var conn = ConexaoDB.ObterConexao())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "DELETE FROM bosses WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region EXISTE

        public bool Existe(string name)
        {
            using (var conn = ConexaoDB.ObterConexao())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM bosses WHERE name=@name", conn);
                cmd.Parameters.AddWithValue("@name", name);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        #endregion

    }
}
