using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Academia;

namespace Academia
{
    public partial class FrmPrincipal : Form
    {
        Conexao conexao = new Conexao();
        string connectionString = "Server=localhost;Database=academia;Uid=root;Pwd=admin;";
        string sql;
        MySqlCommand cmd;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            Habilitar();
            HabilitarCampos();
            Limpar();
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            DesabilitarCampos();
            Limpar();
            btnNovo.Enabled = true;



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            conexao.AbrirConexao();

            string verificarCpfSql = "SELECT COUNT(*) FROM clientes WHERE CPF = @CPF";
            MySqlCommand verificarCpfCmd = new MySqlCommand(verificarCpfSql, conexao.connection);
            verificarCpfCmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
            
            int existeCpf = Convert.ToInt32(verificarCpfCmd.ExecuteScalar());

            if (txtNome.Text.Trim() == string.Empty || txtNome.Text.Length < 3)
            {
                MessageBox.Show("Insira um nome válido");
                txtNome.Text = string.Empty;
                txtNome.Focus();                
                return;
            }
            if (txtCpf.Text == "   .   .   -" || txtCpf.Text.Length < 14 )
            {
                MessageBox.Show("Necessita de um CPF");
                txtCpf.Focus();
                return;
            }
            
            if (txtTel.Text == "(  )     -" || txtTel.Text.Length < 14)
            {
                MessageBox.Show("Insira um número válido");
                txtTel.Focus();
                return;
            }

            if (existeCpf > 0)
            {
                MessageBox.Show("CPF já cadastrado! Por favor, insira um CPF diferente.");
            }
            else
            {

                sql = "INSERT INTO clientes " +
                    "(Nome, Numero, CPF, Endereco, Altura, Peso, DataInicio, DataFim, DataNascimento, Plano, Doenca, Prioridade, TipoSangue)" +
                    "VALUES (@Nome, @Numero, @CPF, @Endereco, @Altura, @Peso, @DataInicio, @DataFim, @DataNascimento, @Plano, @Doenca, @Prioridade, @TipoSangue)";

                cmd = new MySqlCommand(sql, conexao.connection);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Numero", txtTel.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@Altura", txtAltura.Text);
                cmd.Parameters.AddWithValue("@Peso", txtPeso.Text);
                cmd.Parameters.AddWithValue("@DataInicio", DateTime.Parse(dateTimeInicio.Text));
                cmd.Parameters.AddWithValue("@DataFim", DateTime.Parse(dateTimeFim.Text));
                cmd.Parameters.AddWithValue("@DataNascimento", DateTime.Parse(dateTimeNascimento.Text));
                cmd.Parameters.AddWithValue("@Plano", comboBoxPlano.Text);
                cmd.Parameters.AddWithValue("@Doenca", txtDoenca.Text);
                cmd.Parameters.AddWithValue("@Prioridade", comboBoxPrioridade.Text);
                cmd.Parameters.AddWithValue("@TipoSangue", comboBoxTipoSangue.Text);

                cmd.ExecuteNonQuery(); 

                MessageBox.Show("Cliente cadastrado com sucesso!");

                Desabilitar();
                DesabilitarCampos();
                Limpar();
                btnNovo.Enabled = true;
            }

            conexao.FecharConexao();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            DesabilitarCampos();
            Limpar();
            btnNovo.Enabled = true;

        }

        private void Desabilitar() 
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = false;           
        }

        private void Habilitar()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void Limpar()
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtDoenca.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtTel.Text = string.Empty;
            dateTimeFim.Text = string.Empty;
            dateTimeInicio.Text = string.Empty;
            dateTimeNascimento.Text = string.Empty;
            comboBoxPlano.Text = string.Empty;
            comboBoxPrioridade.Text = string.Empty;
            comboBoxTipoSangue.Text = string.Empty;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtDoenca.Enabled = false;
            txtAltura.Enabled = false;
            txtCpf.Enabled = false;
            txtPeso.Enabled = false;
            txtTel.Enabled = false;
            dateTimeFim.Enabled = false;
            dateTimeInicio.Enabled = false;
            dateTimeNascimento.Enabled = false;
            comboBoxPlano.Enabled = false;
            comboBoxPrioridade.Enabled = false;
            comboBoxTipoSangue.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtDoenca.Enabled = true;
            txtAltura.Enabled = true;
            txtCpf.Enabled = true;
            txtPeso.Enabled = true;
            txtTel.Enabled = true;
            dateTimeFim.Enabled = true;
            dateTimeInicio.Enabled = true;
            dateTimeNascimento.Enabled = true;
            comboBoxPlano.Enabled = true;
            comboBoxPrioridade.Enabled = true;
            comboBoxTipoSangue.Enabled = true;
        }

        private void comboBoxPlano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            conexao.AbrirConexao();

            string verificarCpfSql = "SELECT COUNT(*) FROM clientes WHERE CPF = @CPF";
            MySqlCommand verificarCpfCmd = new MySqlCommand(verificarCpfSql, conexao.connection);
            verificarCpfCmd.Parameters.AddWithValue("@CPF", txtCpf.Text);

            int existeCpf = Convert.ToInt32(verificarCpfCmd.ExecuteScalar());

            if (txtNome.Text.Trim() == string.Empty || txtNome.Text.Length < 3)
            {
                MessageBox.Show("Insira um nome válido");
                txtNome.Text = string.Empty;
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text == "   .   .   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Necessita de um CPF");
                txtCpf.Focus();
                return;
            }

            if (txtTel.Text == "(  )     -" || txtTel.Text.Length < 14)
            {
                MessageBox.Show("Insira um número válido");
                txtTel.Focus();
                return;
            }

            if (existeCpf > 0)
            {
                MessageBox.Show("CPF já cadastrado! Por favor, insira um CPF diferente.");
            }
            else
            {

                sql = "UPDATE clientes SET Nome=@Nome, Numero=@Numero, CPF=@CPF, Endereco=@Endereco, Altura=@Altura, Peso=@Peso, DataInicio=@DataInicio, DataFim=@DataFim, DataNascimento=@DataNascimento, Plano=@Plano, Doenca=@Doenca, Prioridade=@Prioridade, TipoSangue=@TipoSangue";

                cmd = new MySqlCommand(sql, conexao.connection);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Numero", txtTel.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@Altura", txtAltura.Text);
                cmd.Parameters.AddWithValue("@Peso", txtPeso.Text);
                cmd.Parameters.AddWithValue("@DataInicio", DateTime.Parse(dateTimeInicio.Text));
                cmd.Parameters.AddWithValue("@DataFim", DateTime.Parse(dateTimeFim.Text));
                cmd.Parameters.AddWithValue("@DataNascimento", DateTime.Parse(dateTimeNascimento.Text));
                cmd.Parameters.AddWithValue("@Plano", comboBoxPlano.Text);
                cmd.Parameters.AddWithValue("@Doenca", txtDoenca.Text);
                cmd.Parameters.AddWithValue("@Prioridade", comboBoxPrioridade.Text);
                cmd.Parameters.AddWithValue("@TipoSangue", comboBoxTipoSangue.Text);

                cmd.ExecuteNonQuery(); 

                MessageBox.Show("Cliente cadastrado com sucesso!");

                Desabilitar();
                DesabilitarCampos();
                Limpar();
                btnNovo.Enabled = true;
            }

            conexao.FecharConexao();

        
    }


    }
}
