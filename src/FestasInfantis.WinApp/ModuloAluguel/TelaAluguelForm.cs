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
                txtCliente.SelectedItem = value.Cliente;
                txtTema.SelectedItem = value.Tema;
                txtStatus.SelectedItem = value.Status;
            }
            get { return aluguel; }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        private TelaAluguelForm(object sender, EventArgs e)
        {
            //Cliente cliente = txtCliente.Text;
            //Tema tema = txtTema;
            //Festa festa = txtFesta.Text;
            //bool status = txtStatus.Text;
            //decimal pEntrada = txtPorcentagemEntrada.Text;
            //decimal pSaida = txtPorcentagemSaida.Text;
            //DateTime dataPagamento = txtPagemento.Text;

            //aluguel = new Aluguel(cliente, tema, festa, status, pSaida, pEntrada, dataPagamento);
        }
    }
}
