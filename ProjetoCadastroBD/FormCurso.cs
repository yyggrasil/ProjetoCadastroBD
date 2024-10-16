using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastroBD
{
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCurso()
        {
            InitializeComponent();
        }
        private MySqlConnection GetConnection() {
            string c = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=admin;" +
                        "database=academico";
            return new MySqlConnection(c);
        }
        private bool VerificaCampos()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(TextCodigo.Text))
            {
                MessageBox.Show("Código Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Nome Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboNivel.Text))
            {
                MessageBox.Show("Nível Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextDuracao.Text))
            {
                MessageBox.Show("Duração Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboPeriodo.Text))
            {
                MessageBox.Show("Período Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboArea.Text))
            {
                MessageBox.Show("Estado Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            return ret;
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        private void Salvar()
        {
            var con = GetConnection();
            con.Open();
            string sql;
            if (isAlteracao) {
                sql = "UPDATE curso SET" +
                    " codigo = @codigo," +
                    " nome = @nome," +
                    " nivel = @nivel," +
                    " duracao = @duracao," +
                    " periodo = @periodo," +
                    " area = @area" +
                    " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO curso " +
                    "(codigo, nome, nivel, duracao, periodo, area) " +
                    "VALUES " +
                    "(@codigo, @nome, @nivel, @duracao, @periodo, @area)";
            }
            
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", TextCodigo.Text);
            cmd.Parameters.AddWithValue("@nome", TextNome.Text);
            cmd.Parameters.AddWithValue("@nivel", ComboNivel.Text);
            cmd.Parameters.AddWithValue("@duracao", TextDuracao.Text);
            cmd.Parameters.AddWithValue("@periodo", ComboPeriodo.Text);
            cmd.Parameters.AddWithValue("@area", ComboArea.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", TextID.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();

        }
        private void Editar()
        {
            if(dataGridViewCurso.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewCurso.SelectedRows[0];
                TextID.Text = linha.Cells["id"].Value.ToString();
                TextCodigo.Text = linha.Cells["codigo"].Value.ToString();
                TextNome.Text = linha.Cells["nome"].Value.ToString();
                ComboNivel.Text = linha.Cells["nivel"].Value.ToString();
                TextDuracao.Text = linha.Cells["duracao"].Value.ToString();
                ComboPeriodo.Text = linha.Cells["periodo"].Value.ToString();
                ComboArea.Text = linha.Cells["area"].Value.ToString();
                TabControlCadastro.SelectedIndex = 0;
                TextCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CarregaGrid()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }
        private void Excluir(int id)
        {
            var con = GetConnection();
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas.\r\n" +
                "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TextCodigo.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewCurso.SelectedRows[0].Cells[0].Value;
                    Excluir(id);
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CarregaGrid();
        }
    }
}
