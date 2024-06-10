using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
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
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
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
                grid.Rows.Add(a.Id,a.Cliente,a.Tema,a.Festa,a.Status,a.PorcentagemSaida,a.DataPagamento);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Festa", HeaderText = "Festa" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" },
                new DataGridViewTextBoxColumn { DataPropertyName = "porcentagemSaida", HeaderText = "Desconto" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DataPagamento", HeaderText = "Data de Pagamento" }
                };
        }
    }
}
