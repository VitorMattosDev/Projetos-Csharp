using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//IMPORTANDO SQL SERVER CE
using System.Data.SqlServerCe;
using System.IO;
//SQLITE
using System.Data.SQLite;

//MySQL
using MySql.Data.MySqlClient;
namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL SERVER CE

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeEngine db = new SqlCeEngine(strConection);

            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            ////conexao.ConnectionString = strConection;

            //try
            //{

            //    conexao.Open();

            //    labelResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar Sql Server CE\n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLITE

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";


            //if (!File.Exists(baseDados))
            //{
            //    SQLiteConnection.CreateFile(baseDados);
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            ////conexao.ConnectionString = strConection;

            //try
            //{

            //    conexao.Open();

            //    labelResultado.Text = "Conectado SQLite";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar SQLite\n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection1 = "server=127.0.0.1;User Id=root;password=";
            ////string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=";
            //MySqlConnection conexao = new MySqlConnection(strConnection1);

            //try
            //{

            //    conexao.Open();

            //    labelResultado.Text = "Conectado MySql";

            //    MySqlCommand comando = new MySqlCommand();

            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";

            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Base de dados criada com sucesso";
            //    comando.Dispose();

            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar MySql\n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region SQL SERVER CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela criada Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLITE
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";


            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela criada SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela criada MySQL";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQL SERVER CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = $"INSERT INTO pessoas VALUES({id}, '{nome}', '{email}');";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLITE
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = $"INSERT INTO pessoas VALUES({id}, '{nome}', '{email}');";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = $"INSERT INTO pessoas VALUES({id}, '{nome}', '{email}');";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido MySQL";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            labelResultado.Text = "";
            lista.Rows.Clear();

            #region SQL SERVER CE

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{

            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "';";
            //    }

            //    DataTable dados = new DataTable();
            //    SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lista.Rows.Clear();
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{

            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "';";
            //    }

            //    DataTable dados = new DataTable();
            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lista.Rows.Clear();
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{

            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "';";
            //    }

            //    DataTable dados = new DataTable();
            //    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lista.Rows.Clear();
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SQL SERVER CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = $"DELETE FROM pessoas WHERE id = {id};";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro excluído Sql Server Ce";
            //    btnProcurar_Click(sender, e);
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLITE
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = $"DELETE FROM pessoas WHERE id = {id};"; 
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro Excluido SQLite";
            //    btnProcurar_Click(sender, e);
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = $"INSERT INTO pessoas VALUES({id}, '{nome}', '{email}');";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido MySQL";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }
    }
}
