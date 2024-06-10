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
            lblId = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            tabControl1 = new TabControl();
            TabDBasicos = new TabPage();
            TabSItens = new TabPage();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabControl1.SuspendLayout();
            TabDBasicos.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(64, 63);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(94, 63);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(38, 101);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 101);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(337, 27);
            txtNome.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabDBasicos);
            tabControl1.Controls.Add(TabSItens);
            tabControl1.Location = new Point(14, 100);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(576, 356);
            tabControl1.TabIndex = 2;
            // 
            // TabDBasicos
            // 
            TabDBasicos.Controls.Add(txtId);
            TabDBasicos.Controls.Add(txtNome);
            TabDBasicos.Controls.Add(lblId);
            TabDBasicos.Controls.Add(lblNome);
            TabDBasicos.Location = new Point(4, 29);
            TabDBasicos.Margin = new Padding(3, 4, 3, 4);
            TabDBasicos.Name = "TabDBasicos";
            TabDBasicos.Padding = new Padding(3, 4, 3, 4);
            TabDBasicos.Size = new Size(568, 323);
            TabDBasicos.TabIndex = 0;
            TabDBasicos.Text = "Dados Básicos";
            TabDBasicos.UseVisualStyleBackColor = true;
            // 
            // TabSItens
            // 
            TabSItens.Location = new Point(4, 29);
            TabSItens.Margin = new Padding(3, 4, 3, 4);
            TabSItens.Name = "TabSItens";
            TabSItens.Padding = new Padding(3, 4, 3, 4);
            TabSItens.Size = new Size(568, 323);
            TabSItens.TabIndex = 1;
            TabSItens.Text = "Seleção de Itens";
            TabSItens.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(491, 464);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 53);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(386, 464);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 53);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaTemaFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 533);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaTemaFrom";
            Text = "TelaTemaFrom";
            tabControl1.ResumeLayout(false);
            TabDBasicos.ResumeLayout(false);
            TabDBasicos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblNome;
        private TextBox txtNome;
        private TabControl tabControl1;
        private TabPage TabDBasicos;
        private TabPage TabSItens;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}