namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            lblId = new Label();
            tabCadastroAlugueis = new TabControl();
            tabDadosFesta = new TabPage();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtDescricao = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtHorarioTermino = new TextBox();
            txtHorarioInicio = new TextBox();
            DtpData = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabDadosAluguel = new TabPage();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblCliente = new Label();
            txtCliente = new ComboBox();
            lblStatus = new Label();
            txtStatus = new ComboBox();
            lblTema = new Label();
            txtTema = new ComboBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label14 = new Label();
            textBox7 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            tabCadastroAlugueis.SuspendLayout();
            tabDadosFesta.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabDadosAluguel.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonFace;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 9.75F);
            txtId.Location = new Point(51, 20);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(69, 29);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(18, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 20);
            lblId.TabIndex = 2;
            lblId.Text = "ID:";
            // 
            // tabCadastroAlugueis
            // 
            tabCadastroAlugueis.Controls.Add(tabDadosFesta);
            tabCadastroAlugueis.Controls.Add(tabDadosAluguel);
            tabCadastroAlugueis.Location = new Point(14, 61);
            tabCadastroAlugueis.Margin = new Padding(3, 4, 3, 4);
            tabCadastroAlugueis.Name = "tabCadastroAlugueis";
            tabCadastroAlugueis.RightToLeftLayout = true;
            tabCadastroAlugueis.SelectedIndex = 0;
            tabCadastroAlugueis.Size = new Size(546, 477);
            tabCadastroAlugueis.TabIndex = 3;
            // 
            // tabDadosFesta
            // 
            tabDadosFesta.Controls.Add(groupBox2);
            tabDadosFesta.Controls.Add(groupBox1);
            tabDadosFesta.Location = new Point(4, 29);
            tabDadosFesta.Margin = new Padding(3, 4, 3, 4);
            tabDadosFesta.Name = "tabDadosFesta";
            tabDadosFesta.Padding = new Padding(3, 4, 3, 4);
            tabDadosFesta.Size = new Size(538, 444);
            tabDadosFesta.TabIndex = 0;
            tabDadosFesta.Text = "Dados Da Festa";
            tabDadosFesta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(19, 235);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(494, 197);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 144);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 29);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 144);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 29);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 51);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 51);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 29);
            textBox1.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(64, 99);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(410, 29);
            txtDescricao.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(291, 151);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 5;
            label8.Text = "Número:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 105);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 4;
            label7.Text = "Rua:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 151);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 3;
            label6.Text = "Bairro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 57);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 2;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 57);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "Cidade:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtHorarioTermino);
            groupBox1.Controls.Add(txtHorarioInicio);
            groupBox1.Controls.Add(DtpData);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 21);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(494, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.hora_e_data;
            pictureBox1.Location = new Point(282, 51);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.Location = new Point(142, 131);
            txtHorarioTermino.Margin = new Padding(3, 4, 3, 4);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.Size = new Size(119, 29);
            txtHorarioTermino.TabIndex = 2;
            txtHorarioTermino.Text = "__:__";
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.Location = new Point(142, 89);
            txtHorarioInicio.Margin = new Padding(3, 4, 3, 4);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.Size = new Size(119, 29);
            txtHorarioInicio.TabIndex = 1;
            txtHorarioInicio.Text = "__:__";
            // 
            // DtpData
            // 
            DtpData.CalendarMonthBackground = Color.Transparent;
            DtpData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpData.Format = DateTimePickerFormat.Short;
            DtpData.Location = new Point(142, 49);
            DtpData.Margin = new Padding(3, 4, 3, 4);
            DtpData.Name = "DtpData";
            DtpData.RightToLeft = RightToLeft.No;
            DtpData.Size = new Size(119, 27);
            DtpData.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 137);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Horário de Termino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Horário de início:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 57);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Data da Festa:";
            // 
            // tabDadosAluguel
            // 
            tabDadosAluguel.Controls.Add(groupBox3);
            tabDadosAluguel.Controls.Add(txtStatus);
            tabDadosAluguel.Controls.Add(lblStatus);
            tabDadosAluguel.Controls.Add(txtTema);
            tabDadosAluguel.Controls.Add(txtCliente);
            tabDadosAluguel.Controls.Add(lblTema);
            tabDadosAluguel.Controls.Add(lblCliente);
            tabDadosAluguel.Location = new Point(4, 29);
            tabDadosAluguel.Margin = new Padding(3, 4, 3, 4);
            tabDadosAluguel.Name = "tabDadosAluguel";
            tabDadosAluguel.Padding = new Padding(3, 4, 3, 4);
            tabDadosAluguel.Size = new Size(538, 444);
            tabDadosAluguel.TabIndex = 1;
            tabDadosAluguel.Text = "Dados Do Aluguel";
            tabDadosAluguel.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(461, 541);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 53);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(355, 541);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 53);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(22, 50);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(89, 47);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(151, 28);
            txtCliente.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(36, 95);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Sinal:";
            // 
            // txtStatus
            // 
            txtStatus.FormattingEnabled = true;
            txtStatus.Location = new Point(89, 92);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(151, 28);
            txtStatus.TabIndex = 1;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(283, 50);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(48, 20);
            lblTema.TabIndex = 0;
            lblTema.Text = "Tema:";
            // 
            // txtTema
            // 
            txtTema.FormattingEnabled = true;
            txtTema.Location = new Point(337, 47);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(151, 28);
            txtTema.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(6, 204);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(526, 233);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados de Pagamento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 60);
            label12.Name = "label12";
            label12.Size = new Size(112, 20);
            label12.TabIndex = 0;
            label12.Text = "% de Desconto:";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(131, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(58, 27);
            textBox5.TabIndex = 1;
            textBox5.Text = "0";
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 105);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 0;
            label13.Text = "Valor do Tema:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(131, 105);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 1;
            textBox6.Text = "0";
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 152);
            label14.Name = "label14";
            label14.Size = new Size(104, 20);
            label14.TabIndex = 0;
            label14.Text = "Valor do Sinal:";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(131, 152);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 1;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(270, 102);
            label15.Name = "label15";
            label15.Size = new Size(106, 40);
            label15.TabIndex = 0;
            label15.Text = "Valor do Tema\r\ncom desconto:\r\n";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(263, 149);
            label16.Name = "label16";
            label16.Size = new Size(113, 20);
            label16.TabIndex = 0;
            label16.Text = "Valor pendente:";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(381, 101);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 1;
            textBox8.Text = "0";
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(382, 149);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 1;
            textBox9.Text = "0";
            textBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 601);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tabCadastroAlugueis);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Aluguéis";
            tabCadastroAlugueis.ResumeLayout(false);
            tabDadosFesta.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabDadosAluguel.ResumeLayout(false);
            tabDadosAluguel.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TabControl tabCadastroAlugueis;
        private TabPage tabDadosFesta;
        private TabPage tabDadosAluguel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker DtpData;
        private TextBox txtHorarioTermino;
        private TextBox txtHorarioInicio;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtDescricao;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblCliente;
        private ComboBox txtStatus;
        private Label lblStatus;
        private ComboBox txtTema;
        private ComboBox txtCliente;
        private Label lblTema;
        private GroupBox groupBox3;
        private Label label12;
        private TextBox textBox9;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label16;
        private Label label14;
        private Label label15;
        private Label label13;
    }
}