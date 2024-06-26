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
            groupBox3 = new GroupBox();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtStatus = new ComboBox();
            lblStatus = new Label();
            txtTema = new ComboBox();
            txtCliente = new ComboBox();
            lblTema = new Label();
            lblCliente = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
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
            txtId.Location = new Point(45, 15);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 25);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(16, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 2;
            lblId.Text = "ID:";
            // 
            // tabCadastroAlugueis
            // 
            tabCadastroAlugueis.Controls.Add(tabDadosFesta);
            tabCadastroAlugueis.Controls.Add(tabDadosAluguel);
            tabCadastroAlugueis.Location = new Point(12, 46);
            tabCadastroAlugueis.Name = "tabCadastroAlugueis";
            tabCadastroAlugueis.RightToLeftLayout = true;
            tabCadastroAlugueis.SelectedIndex = 0;
            tabCadastroAlugueis.Size = new Size(478, 358);
            tabCadastroAlugueis.TabIndex = 3;
            // 
            // tabDadosFesta
            // 
            tabDadosFesta.Controls.Add(groupBox2);
            tabDadosFesta.Controls.Add(groupBox1);
            tabDadosFesta.Location = new Point(4, 24);
            tabDadosFesta.Name = "tabDadosFesta";
            tabDadosFesta.Padding = new Padding(3, 3, 3, 3);
            tabDadosFesta.Size = new Size(470, 330);
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
            groupBox2.Location = new Point(17, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 148);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 25);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 25);
            textBox1.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(56, 74);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(359, 25);
            txtDescricao.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(255, 113);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 5;
            label8.Text = "Número:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 79);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 4;
            label7.Text = "Rua:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 113);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 3;
            label6.Text = "Bairro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 43);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 2;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 43);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
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
            groupBox1.Location = new Point(17, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.hora_e_data;
            pictureBox1.Location = new Point(247, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.Location = new Point(124, 98);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.Size = new Size(105, 25);
            txtHorarioTermino.TabIndex = 2;
            txtHorarioTermino.Text = "__:__";
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.Location = new Point(124, 67);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.Size = new Size(105, 25);
            txtHorarioInicio.TabIndex = 1;
            txtHorarioInicio.Text = "__:__";
            // 
            // DtpData
            // 
            DtpData.CalendarMonthBackground = Color.Transparent;
            DtpData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpData.Format = DateTimePickerFormat.Short;
            DtpData.Location = new Point(124, 37);
            DtpData.Name = "DtpData";
            DtpData.RightToLeft = RightToLeft.No;
            DtpData.Size = new Size(105, 23);
            DtpData.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 103);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Horário de Termino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Horário de início:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
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
            tabDadosAluguel.Location = new Point(4, 24);
            tabDadosAluguel.Name = "tabDadosAluguel";
            tabDadosAluguel.Padding = new Padding(3, 3, 3, 3);
            tabDadosAluguel.Size = new Size(470, 330);
            tabDadosAluguel.TabIndex = 1;
            tabDadosAluguel.Text = "Dados Do Aluguel";
            tabDadosAluguel.UseVisualStyleBackColor = true;
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
            groupBox3.Location = new Point(5, 153);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(460, 175);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados de Pagamento:";
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(334, 112);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 23);
            textBox9.TabIndex = 1;
            textBox9.Text = "0";
            textBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(115, 114);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 23);
            textBox7.TabIndex = 1;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(333, 76);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 23);
            textBox8.TabIndex = 1;
            textBox8.Text = "0";
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(115, 79);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 1;
            textBox6.Text = "0";
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(115, 45);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(51, 23);
            textBox5.TabIndex = 1;
            textBox5.Text = "0";
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(230, 112);
            label16.Name = "label16";
            label16.Size = new Size(89, 15);
            label16.TabIndex = 0;
            label16.Text = "Valor pendente:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 114);
            label14.Name = "label14";
            label14.Size = new Size(81, 15);
            label14.TabIndex = 0;
            label14.Text = "Valor do Sinal:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(236, 76);
            label15.Name = "label15";
            label15.Size = new Size(86, 30);
            label15.TabIndex = 0;
            label15.Text = "Valor do Tema\r\ncom desconto:\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 79);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 0;
            label13.Text = "Valor do Tema:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 45);
            label12.Name = "label12";
            label12.Size = new Size(89, 15);
            label12.TabIndex = 0;
            label12.Text = "% de Desconto:";
            // 
            // txtStatus
            // 
            txtStatus.FormattingEnabled = true;
            txtStatus.Location = new Point(78, 69);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(133, 23);
            txtStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(32, 71);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(35, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Sinal:";
            // 
            // txtTema
            // 
            txtTema.FormattingEnabled = true;
            txtTema.Location = new Point(295, 35);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(133, 23);
            txtTema.TabIndex = 1;
            // 
            // txtCliente
            // 
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(78, 35);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(133, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(248, 38);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(38, 15);
            lblTema.TabIndex = 0;
            lblTema.Text = "Tema:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(19, 38);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(403, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(311, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 40);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 451);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tabCadastroAlugueis);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
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