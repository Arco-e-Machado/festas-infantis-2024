﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaCadastroForm : Form
    {
        private Cliente cliente;
        public Cliente Cliente
        {
            set
            {

                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtFone.Text = value.Telefone;
                txtCpf.Text = value.Cpf;
            }
            get { return cliente; }
        }


        public TelaCadastroForm()
        {
            InitializeComponent();
        }

        private btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtFone.Text;
            string cpf = txtCpf.Text;

            cliente = new Cliente(nome, telefone, cpf);
        }
    }
}
