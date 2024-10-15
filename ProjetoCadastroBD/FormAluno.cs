using ReaLTaiizor.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace ProjetoCadastroBD
{
    public partial class FormAluno : MaterialForm
    {
        bool isAlteracao = false;
        int indexSelecionado = 0;
        string conexao = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=admin;" +
                        "database=academico";
        public FormAluno()
        {
            InitializeComponent();
        }
        private void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            string sql;
            if (isAlteracao)
            {
                sql = "UPDATE aluno SET " +
                    " matricula = @matricula, " +
                    " dt_nascimento = @dt_nascimento, " +
                    " nome = @nome, " +
                    " endereco = @endereco, " +
                    " bairro = @bairro, " +
                    " cidade = @cidade, " +
                    " estado = @estado, " +
                    " senha = @senha" +
                    " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
            }


            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", TextMatricula.Text);
            DateTime.TryParse(TextNascimento.Text, out DateTime dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", TextNome.Text);
            cmd.Parameters.AddWithValue("@endereco", TextEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", TextBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", TextCidade.Text);
            cmd.Parameters.AddWithValue("@estado", ComboEstado.Text);
            cmd.Parameters.AddWithValue("@senha", TextSenha.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", TextID.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();


        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in TabPageCadastro.Controls)
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
        private void Editar()
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewAluno.SelectedRows[0];
                TextID.Text = linha.Cells["id"].Value.ToString();
                TextMatricula.Text = linha.Cells["matricula"].Value.ToString();
                TextNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                TextNome.Text = linha.Cells["nome"].Value.ToString();
                TextEndereco.Text = linha.Cells["endereco"].Value.ToString();
                TextBairro.Text = linha.Cells["bairro"].Value.ToString();
                TextCidade.Text = linha.Cells["cidade"].Value.ToString();
                ComboEstado.Text = linha.Cells["estado"].Value.ToString();
                TextSenha.Text = linha.Cells["senha"].Value.ToString();
                TabControlCadastro.SelectedIndex = 0;
                TextMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool verificarVazio()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(TextMatricula.Text))
            {
                MessageBox.Show("Matrícula Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (!DateTime.TryParse(TextNascimento.Text, out _))
            {
                MessageBox.Show("Nascimento Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Nome Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextEndereco.Text))
            {
                MessageBox.Show("Endereço Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextBairro.Text))
            {
                MessageBox.Show("Bairro Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextCidade.Text))
            {
                MessageBox.Show("Cidade Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboEstado.Text))
            {
                MessageBox.Show("Estado Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextSenha.Text))
            {
                MessageBox.Show("Senha Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            return ret;
        }
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (verificarVazio())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;

            }
        }
        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var SqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            SqlAd.Fill(dt);
            dataGridViewAluno.DataSource = dt;
            con.Close();
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM  aluno WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewAluno.SelectedRows[0].Cells[0].Value;
                    Excluir(id);
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TextMatricula.Focus();
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
    }
}
