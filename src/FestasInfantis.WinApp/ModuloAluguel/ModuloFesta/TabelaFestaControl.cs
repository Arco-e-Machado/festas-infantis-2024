using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
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

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class TabelaFestaControl : UserControl
    {
        public TabelaFestaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(CriarColunas());

        }
        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Columns.Clear();

            foreach (Festa f in festas)
            {
                grid.Rows.Add(f.Id, f.Endereco, f.Data, f.HoraInicio, f.HoraTermino);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]{
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Inicio", HeaderText = "Horário de início"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Termino", HeaderText = "Horário de Término"}
        };

        }
    }
}