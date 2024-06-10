using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
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
    public partial class TelaTemaFrom : Form
    {
        private Tema tema;
        public Tema Tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get { return tema; }
        }
        public TelaTemaFrom()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            List<Item> itens = new List<Item>();

            tema = new Tema(nome, itens);
        }

    }
}
