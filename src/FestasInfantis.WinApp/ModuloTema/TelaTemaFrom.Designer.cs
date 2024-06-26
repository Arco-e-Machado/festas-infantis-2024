namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaFrom
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            TabDBasicos = new TabPage();
            txtId = new TextBox();
            txtNome = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            tabControl1 = new TabControl();
            TabItens = new TabPage();
            ListItens = new CheckedListBox();
            TabDBasicos.SuspendLayout();
            tabControl1.SuspendLayout();
            TabItens.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(430, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(338, 348);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 40);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TabDBasicos
            // 
            TabDBasicos.Controls.Add(txtId);
            TabDBasicos.Controls.Add(txtNome);
            TabDBasicos.Controls.Add(lblId);
            TabDBasicos.Controls.Add(lblNome);
            TabDBasicos.Location = new Point(4, 24);
            TabDBasicos.Name = "TabDBasicos";
            TabDBasicos.Padding = new Padding(3);
            TabDBasicos.Size = new Size(496, 239);
            TabDBasicos.TabIndex = 0;
            TabDBasicos.Text = "Dados Básicos";
            TabDBasicos.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(82, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(295, 23);
            txtNome.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(56, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(33, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabDBasicos);
            tabControl1.Controls.Add(TabItens);
            tabControl1.Location = new Point(12, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(504, 267);
            tabControl1.TabIndex = 2;
            // 
            // TabItens
            // 
            TabItens.Controls.Add(ListItens);
            TabItens.Location = new Point(4, 24);
            TabItens.Name = "TabItens";
            TabItens.Padding = new Padding(3);
            TabItens.Size = new Size(496, 239);
            TabItens.TabIndex = 1;
            TabItens.Text = "Lista de Itens";
            TabItens.UseVisualStyleBackColor = true;
            // 
            // ListItens
            // 
            ListItens.Dock = DockStyle.Fill;
            ListItens.FormattingEnabled = true;
            ListItens.Location = new Point(3, 3);
            ListItens.Name = "ListItens";
            ListItens.Size = new Size(490, 233);
            ListItens.TabIndex = 0;
            // 
            // TelaTemaFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 400);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tabControl1);
            Name = "TelaTemaFrom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaTemaFrom";
            TabDBasicos.ResumeLayout(false);
            TabDBasicos.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabItens.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private Button btnSalvar;
        private TabPage TabDBasicos;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lblId;
        private Label lblNome;
        private TabControl tabControl1;
        private TabPage TabItens;
        private CheckedListBox ListItens;
    }
}