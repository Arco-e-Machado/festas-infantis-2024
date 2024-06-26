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
                cmbCliente.SelectedItem = value.Cliente;
                cmbTema.SelectedItem = value.Tema;
                cmbStatus.SelectedItem = value.Status;

            }
            get { return aluguel; }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string endereco = $"Rua:{txtRua.Text}" +
                                      $"Nº{txtNumero.Text}" +
                                      $", Bairro:{txtBairro}," +
                                      $" Cidade:{txtCidade.Text}," +
                                      $" Estado: {txtEstado.Text}";
            DateTime data = DtpData.Value;
            DateTime inicioFesta = dtHorarioInicio.Value;
            DateTime terminoFesta = dtHorarioTermino.Value;

            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;
            bool status = (bool)cmbStatus.SelectedItem;

            decimal pSaida = 0;
            decimal pEntrada = 0;

            DateTime dataPagamento = DateTime.Now;

            Festa festa = new Festa(endereco, tema, data, inicioFesta, terminoFesta);
            aluguel = new Aluguel(cliente, tema, festa, status, pSaida, pEntrada, dataPagamento, cliente);
        }

        public void MostrarDados(List<Cliente> clientes, List<Tema> temas)
        {
            foreach (Cliente c in clientes)
                cmbCliente.Items.Add(c);

            foreach (Tema t in temas)
                cmbTema.Items.Add(t);

        }
    }
}
