﻿using FestasInfantis.WinApp.ModuloAluguel;
using System;
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
    public partial class TelaClienteForm : Form
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


        public TelaClienteForm()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtFone.Text;
            string cpf = txtCpf.Text;

            List<Aluguel> alugueis = new List<Aluguel>();

            cliente = new Cliente(nome, telefone, cpf, alugueis);
        }
    }
}
