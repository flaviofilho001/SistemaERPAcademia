namespace Academia
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPlano = new System.Windows.Forms.ComboBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTipoSangue = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDoenca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(37, 48);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 16);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plano: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Altura: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data Início:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data Fim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Data Nascimento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Prioridade: ";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(115, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 22);
            this.txtNome.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(115, 130);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(263, 22);
            this.txtEndereco.TabIndex = 13;
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(413, 45);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(173, 22);
            this.txtCpf.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(115, 88);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 22);
            this.txtTel.TabIndex = 15;
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(115, 178);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(81, 22);
            this.txtAltura.TabIndex = 16;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(288, 178);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(77, 22);
            this.txtPeso.TabIndex = 17;
            // 
            // comboBoxPlano
            // 
            this.comboBoxPlano.Enabled = false;
            this.comboBoxPlano.FormattingEnabled = true;
            this.comboBoxPlano.Items.AddRange(new object[] {
            "Mensal",
            "Bimestral",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.comboBoxPlano.Location = new System.Drawing.Point(115, 285);
            this.comboBoxPlano.Name = "comboBoxPlano";
            this.comboBoxPlano.Size = new System.Drawing.Size(183, 24);
            this.comboBoxPlano.TabIndex = 20;
            this.comboBoxPlano.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlano_SelectedIndexChanged);
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.Enabled = false;
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Ganhar Peso",
            "Perder Peso",
            "Bulking",
            "Cuidados",
            "Saúde"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(115, 374);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(183, 24);
            this.comboBoxPrioridade.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tipo sanguíneo:";
            // 
            // comboBoxTipoSangue
            // 
            this.comboBoxTipoSangue.Enabled = false;
            this.comboBoxTipoSangue.FormattingEnabled = true;
            this.comboBoxTipoSangue.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBoxTipoSangue.Location = new System.Drawing.Point(152, 415);
            this.comboBoxTipoSangue.Name = "comboBoxTipoSangue";
            this.comboBoxTipoSangue.Size = new System.Drawing.Size(183, 24);
            this.comboBoxTipoSangue.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Doença pré-existente:";
            // 
            // txtDoenca
            // 
            this.txtDoenca.Enabled = false;
            this.txtDoenca.Location = new System.Drawing.Point(515, 285);
            this.txtDoenca.Name = "txtDoenca";
            this.txtDoenca.Size = new System.Drawing.Size(263, 22);
            this.txtDoenca.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(370, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "CADASTRO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(679, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Foto:";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Enabled = false;
            this.dateTimeNascimento.Location = new System.Drawing.Point(150, 331);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(279, 22);
            this.dateTimeNascimento.TabIndex = 29;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(383, 418);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 30;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(484, 418);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(586, 418);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 32;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(694, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Enabled = false;
            this.dateTimeInicio.Location = new System.Drawing.Point(115, 235);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(167, 22);
            this.dateTimeInicio.TabIndex = 34;
            // 
            // dateTimeFim
            // 
            this.dateTimeFim.Enabled = false;
            this.dateTimeFim.Location = new System.Drawing.Point(353, 234);
            this.dateTimeFim.Name = "dateTimeFim";
            this.dateTimeFim.Size = new System.Drawing.Size(167, 22);
            this.dateTimeFim.TabIndex = 35;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeFim);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDoenca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxTipoSangue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.comboBoxPlano);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.ComboBox comboBoxPlano;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipoSangue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDoenca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFim;
    }
}

