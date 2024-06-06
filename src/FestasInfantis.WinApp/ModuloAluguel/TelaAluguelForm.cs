using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtCliente.Text = value.Cliente;
                txtTema.Text = value.Tema;
                txtFesta.Text = value.Festa;
                txtStatus.Text = value.Status;
                txtPorcentagemEntrada.Text = value.PorcentagemEntrada;
                txtPorcentagemSaida.Text = value.PorcentagemSaida;
                txtPagamento.Text = value.DataPagamento;
            }
            get { return aluguel; }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        private TelaAluguelForm(object sender, EventArgs e)
        {
            Cliente cliente = txtCliente.Text;
            Tema tema = txtTema.Text;
            Festa festa = txtFesta.Text;
            bool status = txtStatus.Text;
            decimal pEntrada = txtPorcentagemEntrada.Text;
            decimal pSaida = txtPorcentagemSaida.Text;
            DateTime dataPagamento = txtPagemento.Text;

            aluguel = new Aluguel(cliente, tema, festa, status, pSaida, pEntrada, dataPagamento);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TelaAluguelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
