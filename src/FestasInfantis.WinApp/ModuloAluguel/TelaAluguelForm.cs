using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
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
        IRepositorioTema t; IRepositorioItem i;
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
                cmbCliente.SelectedItem = value.Cliente;
                cmbTema.SelectedItem = value.Tema;
                cmbSinal.SelectedItem = value.Sinal;

                txtValorTema.Text = value.Tema.valorTotal.ToString();
            }
            get { return aluguel; }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();

            cmbSinal.Enabled = false;
            cmbTema.Enabled = false;
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
            ValorEntradaEnum sinal = (ValorEntradaEnum)cmbSinal.SelectedItem;


            string pSaida = txtValorTemaDesconto.Text;
            decimal pEntrada = 0;//mexer no calculo

            DateTime dataPagamento = DateTime.Now;

            Festa festa = new Festa(endereco, tema, data, inicioFesta, terminoFesta);
            aluguel = new Aluguel(cliente, tema, festa, sinal, pSaida, pEntrada, dataPagamento);
        }

        public void MostrarDados(List<Cliente> clientes, List<Tema> temas)
        {
            foreach (Cliente c in clientes)
                cmbCliente.Items.Add(c);

            foreach (Tema t in temas)
                cmbTema.Items.Add(t);

            Array tipoDeEntrada = Enum.GetValues(typeof(ValorEntradaEnum));

            foreach (object v in tipoDeEntrada)
                cmbSinal.Items.Add(v);
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema tema = (Tema)cmbTema.SelectedItem;
            if (tema != null)
                cmbSinal.Enabled = true;
            txtValorTema.Text = tema.valorTotal.ToString();
        }

        private void cmbSinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;
            decimal sinal = Convert.ToDecimal((ValorEntradaEnum)cmbSinal.SelectedItem);
            decimal valorFinal = (tema.valorTotal * (cliente.Desconto / 100));

            if ((ValorEntradaEnum)cmbSinal.SelectedItem == ValorEntradaEnum.total)
            {
                sinal = tema.valorTotal;
                txtValorPendente.Text = "Pago";
                txtValorParcial.Enabled = false;

            }
            else
            {
                txtValorParcial.Enabled = true;
                decimal pendente = 0;
                pendente = (tema.valorTotal - sinal);
                txtValorPendente.Text = pendente.ToString("C");
            }


            foreach (Aluguel a in cliente.alugueis)
                cliente.Desconto = 1 + cliente.alugueis.Count();//corrigir o calculo

            txtValorTemaDesconto.Text = valorFinal.ToString("C");
            txtPorcentagemDesconto.Text = cliente.Desconto.ToString() + "%";
            txtSinal.Text = sinal.ToString("C");
        }

        private void txtValorParcial_TextChanged(object sender, EventArgs e)
        {
            Tema tema = (Tema)cmbTema.SelectedItem;
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            decimal sinal = Convert.ToDecimal((ValorEntradaEnum)cmbSinal.SelectedItem);

            foreach (Aluguel a in cliente.alugueis)
                cliente.Desconto = 1 + cliente.alugueis.Count();//corrigir o calculo

            if ((ValorEntradaEnum)cmbSinal.SelectedItem == ValorEntradaEnum.parcial)
            {
                txtValorParcial.Enabled = true;
                if (txtValorParcial.Text == string.Empty)
                    txtValorParcial.Text = 0.ToString();
                sinal = Convert.ToDecimal(txtValorParcial.Text);
            }

            decimal pendente = (tema.valorTotal - sinal);
            decimal valorFinal = (tema.valorTotal * (cliente.Desconto / 100));

            txtValorTemaDesconto.Text = valorFinal.ToString("C");
            txtValorPendente.Text = pendente.ToString("C");
            txtSinal.Text = sinal.ToString("C");
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;

            if (cliente != null)
                cmbTema.Enabled = true;

        }
    }
}
