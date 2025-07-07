using AgendaADONET.Classes;
using AgendaADONET.DAO;
using System.Data;

namespace AgendaADONET
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            //ContatoDAO contatoDAO = new ContatoDAO();
            ////DataTable dataTable = contatoDAO.GetContatos();
            ////dgvAgenda.DataSource = dataTable;
            //DataSet ds = contatoDAO.GetContatos();
            //dgvAgenda.DataSource = ds.Tables["CONTATOS"];

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            int id = (int)dgvAgenda.CurrentRow.Cells[0].Value;
            ContatoDAO contatoDAO = new ContatoDAO();
            contatoDAO.Excluir(id);
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            DataSet ds = contatoDAO.GetContatos();
            dgvAgenda.DataSource = ds.Tables["CONTATOS"];
            dgvAgenda.Refresh();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmIncluirAlterarContato form = new frmIncluirAlterarContato();
            form.ShowDialog();
            CarregarDataGridView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Id = (int)dgvAgenda.CurrentRow.Cells[0].Value,
                Nome = dgvAgenda.CurrentRow.Cells[1].Value.ToString(),
                Email = dgvAgenda.CurrentRow.Cells[2].Value.ToString(),
                Telefone = Convert.ToInt32(dgvAgenda.CurrentRow.Cells[3].Value.ToString())
            };
            frmIncluirAlterarContato form = new frmIncluirAlterarContato(contato);
            form.ShowDialog();
            CarregarDataGridView();
        }
    }
}
