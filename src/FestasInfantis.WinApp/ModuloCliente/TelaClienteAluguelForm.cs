using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
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
    public partial class TelaClienteAluguelForm : Form
    {
        public TelaClienteAluguelForm()
        {
            InitializeComponent();
            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel a in alugueis)
            {
                grid.Rows.Add(a.Id, a.Tema, a.PorcentagemSaida, a.DataPagamento);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "porcentagemSaida", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DataPagamento", HeaderText = "Data de Pagamento" }
                };
        }
    }
}
