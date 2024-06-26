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
    public partial class TelaItemForm : Form
    {
        private Item item;
        public Item Item
        {
            set
            {

                txtId.Text = value.Id.ToString();
                txtDescricao.Text = value.Descricao;
                txtValor.Text = Convert.ToString(value.Valor);

            }
            get { return item; }
        }
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            decimal valor = txtValor.Value;
            
            item = new Item(descricao, valor, false);
        }
    }
}
