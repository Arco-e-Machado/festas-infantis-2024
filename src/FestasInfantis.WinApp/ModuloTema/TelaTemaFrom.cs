
using FestasInfantis.WinApp.ModuloItem;
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
            get => tema;
        }
        public TelaTemaFrom()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            List<Item> repositorio = ListItens.Items.Cast<Item>().ToList();

            foreach (Item i in ListItens.CheckedItems)
            {
                repositorio.Add(i);
                i.Locado = true;
            }

            tema = new Tema(nome, repositorio);
        }

        public void MostrarItens(List<Item> itens)
        {
            foreach (Item i in itens)
                if (i.Locado == false)
                    ListItens.Items.Add(i);
        }
    }
}
