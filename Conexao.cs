using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    class Conexao
    {
        public string connectionString = "Server=localhost;Database=academia;Uid=root;Pwd=admin;";
        
        public MySqlConnection connection = null;

        public void AbrirConexao()
        { 
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

            }
            catch (Exception ex) {
                MessageBox.Show("Erro de Conexão" + ex.Message);
            }

        }

        public void FecharConexao()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Conexão" + ex.Message);
            }
        }
    }
}
