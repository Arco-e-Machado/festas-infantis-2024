namespace FestasInfantis.WinApp.ModuloItem
{
    partial class TelaItemForm
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
            lblDescricao = new Label();
            lblValor = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtDescricao = new TextBox();
            txtId = new TextBox();
            txtValor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblId.Location = new Point(52, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDescricao.Location = new Point(12, 73);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(68, 17);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblValor.Location = new Point(34, 104);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(42, 17);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(463, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(371, 129);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 40);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(105, 73);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(444, 23);
            txtDescricao.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonFace;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 9.75F);
            txtId.Location = new Point(105, 39);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 25);
            txtId.TabIndex = 11;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Location = new Point(105, 105);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(61, 23);
            txtValor.TabIndex = 13;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 195);
            Controls.Add(txtValor);
            Controls.Add(txtId);
            Controls.Add(txtDescricao);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblValor);
            Controls.Add(lblDescricao);
            Controls.Add(lblId);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro De Itens";
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblDescricao;
        private Label lblValor;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtDescricao;
        private TextBox txtId;
        private NumericUpDown txtValor;
    }
}