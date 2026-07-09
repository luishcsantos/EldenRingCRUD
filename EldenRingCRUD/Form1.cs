using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EldenRingCRUD.Models;
using EldenRingCRUD.Services;
using EldenRingCRUD.Data;
using System.Net;

namespace EldenRingCRUD
{
    public partial class Form1 : Form
    {
        private BossAPIService apiService = new BossAPIService();
        private BossRepository repo = new BossRepository();
        private Boss bossAtual = null;

        public Form1()
        {
            InitializeComponent();
            btnSalvar.Enabled = false; // botão desabilitado até buscar algo
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string busca = txtBusca.Text.Trim();

            // validação caso a pessoa não digite nada no campo
            if (string.IsNullOrEmpty(busca))
            {
                MessageBox.Show("Digite o nome ou ID do boss!");
                return;
            }

            // desativa o botão para evitar cliques duplos
            btnBuscar.Enabled = false;
            btnBuscar.Text = "Buscando...";

            bossAtual = await apiService.BuscarBoss(busca);

            if(bossAtual == null)
            {
                MessageBox.Show("Boss não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBuscar.Enabled = true;
                btnBuscar.Text = "Buscar";
            }
            else
            {
                ExibirBoss(bossAtual);
                btnBuscar.Enabled = true;
                btnBuscar.Text = "Buscar";
                btnSalvar.Enabled = true;
            }
        }

        // Método para preencher os campos da tela
        private void ExibirBoss(Boss b)
        {
            lblName.Text = $"Name: {b.Name}";
            lblHp.Text = $"HP: {b.HealthPoints}";
            lblLocation.Text = $"Location: {b.Location}";
            lblDrops.Text = $"Drops: {b.Drops}\n";
            lblDescription.Text = $"Description: {Environment.NewLine}{b.Description}";

            // Carrega a imagem
            if (!string.IsNullOrEmpty(b.Image))
            {
                using (WebClient  wc = new WebClient())
                {
                    byte[] bytes = wc.DownloadData(b.Image);
                    using (var ms = new System.IO.MemoryStream(bytes))
                    {
                        picBoss.Image = Image.FromStream(ms);
                        picBoss.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (bossAtual == null) { return; }
            //Verificar se o boss existe no banco
            if (repo.Existe(bossAtual.Name))
            {
                var resposta = MessageBox.Show(
                    $"{bossAtual.Name} já está salvo! Deseja atualizar?",
                    "Já existe",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    //atualizado por lista //TODO: REFATORAR
                    var lista = repo.ListarTodos();
                    var existente = lista.Find(x => x.Name == bossAtual.Name);
                    bossAtual.Id = existente.Id;
                    repo.Atualizar(bossAtual);
                    MessageBox.Show("Boss atualizado!");
                }
                return;
            }

            repo.Salvar(bossAtual);
            MessageBox.Show($"{bossAtual.Name} salvo!");
        }

        private void btnVerSalvos_Click(object sender, EventArgs e)
        {
            new FormLista().ShowDialog();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBoss_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblHp_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }

        private void lblDrops_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
