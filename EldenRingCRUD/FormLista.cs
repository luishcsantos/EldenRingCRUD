using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EldenRingCRUD.Data;

namespace EldenRingCRUD
{
    public partial class FormLista : Form
    {
        private BossRepository repo = new BossRepository();
        public FormLista()
        {
            InitializeComponent();
            CarregarDados();

            // Configurações visuais do DataGridView
            // expandir as colunas para a largura disponível
            dgvBosses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // seleciona a linha toda ao clicar
            dgvBosses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // impedir a edição direto na grid
            dgvBosses.ReadOnly = true;
        }

        // buscar dados no banco e exibir na tabela
        private void CarregarDados()
        {
            var lista = repo.ListarTodos();
            dgvBosses.DataSource = null; // limpa antes de carregar
            dgvBosses.DataSource = lista;
        }

        private void dvgBosses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvBosses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Boss para deletar!");
                return;
            }

            // pegar os dados da linha selecionada
            var row = dgvBosses.SelectedRows[0];
            string id = (string)row.Cells["Id"].Value;
            string name = row.Cells["Name"].Value.ToString();

            // pede uma confirmação antes de deletar
            var confirm = MessageBox.Show(
                $"Deseja deletar {name} ?",
                "Confirmar deleção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                repo.Deletar(id);
                MessageBox.Show("Boss deletado!");
                CarregarDados();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
