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
        private Tema Tema;
        public Tema tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txt1.Text = value.ValorTotal;
                txt2.Text = value.Nome;
                txt3.value = value.Aluguel;
                txt4.value = value.Itens;
            }
        }
        public TelaTemaFrom()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string valor = txt1.Text;
            string nome = txt2.Text;
            Aluguel aluguel = txt3.value;
            Item item = txt4.value;

            tema = new Tema(valor, nome, item, aluguel);
        }

    }
}
