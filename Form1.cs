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

            // Abrir conexão com o banco de dados
            conexao.AbrirConexao();

            // Verificar se o CPF já existe
            string verificarCpfSql = "SELECT COUNT(*) FROM clientes WHERE CPF = @CPF";
            MySqlCommand verificarCpfCmd = new MySqlCommand(verificarCpfSql, conexao.connection);
            verificarCpfCmd.Parameters.AddWithValue("@CPF", txtCpf.Text);

            // Executa a consulta e retorna o número de registros encontrados com o CPF
            int existeCpf = Convert.ToInt32(verificarCpfCmd.ExecuteScalar());

            if (existeCpf > 0)
            {
                // Se já existe um CPF igual, exibir mensagem e cancelar a operação
                MessageBox.Show("CPF já cadastrado! Por favor, insira um CPF diferente.");
            }
            else
            {
                // CPF não existe, prosseguir com o INSERT
                sql = "INSERT INTO clientes " +
                    "(Nome, Numero, CPF, Endereco, Altura, Peso, DataInicio, DataFim, DataNascimento, Plano, Doenca, Prioridade, TipoSangue)" +
                    "VALUES (@Nome, @Numero, @CPF, @Endereco, @Altura, @Peso, @DataInicio, @DataFim, @DataNascimento, @Plano, @Doenca, @Prioridade, @TipoSangue)";

                cmd = new MySqlCommand(sql, conexao.connection);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Numero", txtTel.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@Altura", int.Parse(txtAltura.Text));
                cmd.Parameters.AddWithValue("@Peso", int.Parse(txtPeso.Text));
                cmd.Parameters.AddWithValue("@DataInicio", DateTime.Parse(dateTimeInicio.Text));
                cmd.Parameters.AddWithValue("@DataFim", DateTime.Parse(dateTimeFim.Text));
                cmd.Parameters.AddWithValue("@DataNascimento", DateTime.Parse(dateTimeNascimento.Text));
                cmd.Parameters.AddWithValue("@Plano", comboBoxPlano.Text);
                cmd.Parameters.AddWithValue("@Doenca", txtDoenca.Text);
                cmd.Parameters.AddWithValue("@Prioridade", comboBoxPrioridade.Text);
                cmd.Parameters.AddWithValue("@TipoSangue", comboBoxTipoSangue.Text);

                cmd.ExecuteNonQuery(); // Executa o INSERT

                MessageBox.Show("Cliente cadastrado com sucesso!");

                // Desabilitar e limpar campos após o sucesso
                Desabilitar();
                DesabilitarCampos();
                Limpar();
                btnNovo.Enabled = true;
            }

            // Fechar a conexão
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


    }
}
