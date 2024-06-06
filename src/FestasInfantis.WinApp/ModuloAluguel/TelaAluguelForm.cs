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
                txt1.Text = value.Cliente;
                txt2.Text = value.Tema;
                txt3.Text = value.Festa;
                txt4.Text = value.Status;
                txt5.Text = value.PorcentagemEntrada;
                txt6.Text = value.PorcentagemSaida;
                txt7.Text = value.DataPagamento;
            }
            get { return aluguel; }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        private TelaAluguelForm(object sender, EventArgs e)
        {
            Cliente cliente = txt1.Text;
            Tema tema = txt2.Text;
            Festa festa = txt3.Text;
            bool status = txt4.Text;
            decimal pEntrada = txt5.Text;
            decimal pSaida = txt6.Text;
            DateTime dataPagamento = txt7.Text;

            aluguel = new Aluguel(cliente, tema, festa, status, pSaida, pEntrada, dataPagamento)
        }
    }
}
