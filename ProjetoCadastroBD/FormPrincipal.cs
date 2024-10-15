using ReaLTaiizor.Forms;

namespace ProjetoCadastroBD
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aluno = new FormAluno();
            aluno.MdiParent = this;
            aluno.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Curso = new FormCurso();
            Curso.MdiParent = this;
            Curso.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
