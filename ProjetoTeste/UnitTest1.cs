using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace ProjetoTeste
{
    [TestClass]
    public class DBUnitTest
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=admin;" +
                        "database=academico";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnection()
        {
            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
        }
        [TestMethod]
        public void TestInsertAluno()
        {
            string sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";

            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@matricula", "BI3017176");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2003, 03, 16));
            cmd.Parameters.AddWithValue("@nome", "Kauê Alcântara Leivas");
            cmd.Parameters.AddWithValue("@endereco", "Mario Geraldi, 182");
            cmd.Parameters.AddWithValue("@bairro", "Aeroporto");
            cmd.Parameters.AddWithValue("@cidade", "Aracatuba");
            cmd.Parameters.AddWithValue("@estado", "SP");
            cmd.Parameters.AddWithValue("@senha", "Kleivas1603");

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestSelectAluno()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * from aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine(dr["matricula"] + " ");
                Debug.WriteLine(dr["nome"] + " ");
                Debug.WriteLine(dr["dt_nascimento"] + " ");
                Debug.WriteLine(dr["endereco"] + " ");
                Debug.WriteLine(dr["cidade"] + " ");
                Debug.WriteLine(dr["bairro"] + " ");
                Debug.WriteLine(dr["estado"] + " ");
                Debug.WriteLine(dr["senha"] + " ");
                Debug.WriteLine(" ");
            }
        }
        [TestMethod]
        public void TestInsertCurso()
        {
            string sql = "INSERT INTO curso " +
                " (codigo, nome, nivel, duracao, " +
                " periodo, area) " +
                " VALUES " +
                " (@codigo, @nome, @nivel, @duracao, " +
                " @periodo, @area)";

            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@codigo", "0011");
            cmd.Parameters.AddWithValue("@nome", "Engenharia de computação");
            cmd.Parameters.AddWithValue("@nivel", "Superior");
            cmd.Parameters.AddWithValue("@duracao", "10");
            cmd.Parameters.AddWithValue("@periodo", "Integral");
            cmd.Parameters.AddWithValue("@area", "Informática");

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestSelectCurso()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * from curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine(dr["codigo"] + " ");
                Debug.WriteLine(dr["nome"] + " ");
                Debug.WriteLine(dr["nivel"] + " ");
                Debug.WriteLine(dr["duracao"] + " ");
                Debug.WriteLine(dr["periodo"] + " ");
                Debug.WriteLine(dr["area"] + " ");
                Debug.WriteLine(" ");
            }
        }
    }
}