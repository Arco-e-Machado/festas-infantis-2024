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

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(CriarColuna());

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void AtualizarRegistros(List<Item> itens)
        {
            grid.Rows.Clear();

            foreach (Item i in itens)
            {
                grid.Rows.Add(i.Id, i.Descricao, i.Valor, i.Tema);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        DataGridViewColumn[] CriarColuna()
        {
            return new DataGridViewColumn[]{
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema"}
            };
        }
    }
}
