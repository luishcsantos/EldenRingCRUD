using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Misc;

namespace EldenRingCRUD.Data
{
    public class ConexaoDB
    {
        private static string connectionString = "Server=localhost;port=3306;Database=eldenringdb;Uid=root;Pwd=LhS@159753;";

        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
