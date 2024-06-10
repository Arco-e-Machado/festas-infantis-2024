using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        internal void AtualizarRegistros(List<Tema> temas)
        {
            throw new NotImplementedException();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
                };
        }
    }
}
