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

                lblId.Text = value.Id.ToString();
                lblDescricao.Text = value.Descricao;
                lblValor.Text = Convert.ToString(value.Valor);

            }
            get { return item; }
        }
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private TelaItemForm(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            decimal valor = txtValor.Value;

            item = new Item(descricao, valor);
        }

        private void TelaItemForm_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
