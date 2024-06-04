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
    public partial class TelaFestaForm : Form
    {

        private Festa festa;
        public Festa Festa
        {
            set
            {

                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Endereco;
                dtData.value = value.Data;
                dsInicio.value = value.HoraInicio;
                dsTermino.value = value.HoraTermino;
            }
            get { return festa; }
        }

        public TelaFestaForm()
        {
            InitializeComponent();
        }

        private TelaFestaForm(object sender, EventArgs e)
        {
            string endereco = txtEndereco.Text;
            DateTime data = dtData.value;
            TimeSpan inicio = dsInicio.value;
            TimeSpan termino = dsTermino.value;

            festa = new Festa(endereco, data, inicio, termino);
        }
    }
}
