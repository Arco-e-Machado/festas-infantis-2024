
using FestasInfantis.WinApp.ModuloItem;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaFrom : Form
    {

        TabPage tabPage;
        CustomCheckedListBox lb;


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
            InitializeCustomComponents();
            
        }
        private CustomCheckedListBox InitializeCustomComponents()
        {
            lb = new CustomCheckedListBox();

            tabPage = new TabPage("Seleção de Itens");


            tabPage.Controls.Add(lb);

            lb.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tabPage);

            Controls.Add(tabControl1);

            return lb;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text;

            List<Item> repositorio = InitializeCustomComponents().Items.Cast<Item>().ToList();

            foreach (CheckBoxItem i in repositorio)
            {
                repositorio.Add(i);
                i.Locado = true;

            }

            tema = new Tema(nome, repositorio);
        }

        public void MostrarItens(List<Item> itens)
        {

            foreach (Item i in itens)
            {
                lb.Items.Add(new CheckBoxItem(i));
            }
        }
    }
}
