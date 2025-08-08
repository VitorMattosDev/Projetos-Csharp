﻿using System;
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
            string strConnection1 = "server=127.0.0.1;User Id=root;password=";
            //string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=123";
            MySqlConnection conexao = new MySqlConnection(strConnection1);

            try
            {

                conexao.Open();

                labelResultado.Text = "Conectado MySql";

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";

                comando.ExecuteNonQuery();

                labelResultado.Text = "Base de dados criada com sucesso";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao Conectar MySql\n" + ex;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
