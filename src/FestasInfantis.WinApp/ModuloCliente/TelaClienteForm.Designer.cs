namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblTelefone = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtFone = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(36, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(16, 69);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(29, 105);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(30, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(4, 142);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonFace;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 9.75F);
            txtId.Location = new Point(65, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 25);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F);
            txtNome.Location = new Point(65, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(357, 25);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 9.75F);
            txtCpf.Location = new Point(65, 100);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(126, 25);
            txtCpf.TabIndex = 2;
            // 
            // txtFone
            // 
            txtFone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFone.Location = new Point(65, 137);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(171, 25);
            txtFone.TabIndex = 3;
            txtFone.Text = "(__) _____-____";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(336, 122);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 40);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(428, 122);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 183);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtFone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            Text = "Cadastro De Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblTelefone;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtFone;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}