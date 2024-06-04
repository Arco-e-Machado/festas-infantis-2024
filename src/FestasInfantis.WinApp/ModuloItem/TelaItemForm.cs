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
                txtValor.Text = value.Valor;
                txtTema.Text = value.Tema;

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
            double valor = txtValor.Value;
            string tema = txtTema.Text;

            item = new Item(descricao, valor, tema);
        }
    }
}
