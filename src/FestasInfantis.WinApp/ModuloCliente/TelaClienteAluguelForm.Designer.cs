namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteAluguelForm
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
            txtId = new TextBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            grid = new DataGridView();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(63, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(89, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(92, 23);
            txtId.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(39, 74);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(89, 71);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(355, 23);
            txtCliente.TabIndex = 1;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(12, 135);
            grid.Name = "grid";
            grid.Size = new Size(499, 172);
            grid.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(425, 320);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 40);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // TelaClienteAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 372);
            Controls.Add(btnOk);
            Controls.Add(grid);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaClienteAluguelForm";
            Text = "TelaClienteAluguelForm";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblCliente;
        private TextBox txtCliente;
        private DataGridView grid;
        private Button btnOk;
    }
}