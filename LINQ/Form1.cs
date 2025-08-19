using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {

        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;

        public Form1()
        {
            InitializeComponent();

            #region Lista Nomes
            lista_nomes = new List<string>();

            lista_nomes.Add("Amanda");
            lista_nomes.Add("Bruno");
            lista_nomes.Add("Barbara");
            lista_nomes.Add("Barbaroti");
            lista_nomes.Add("Beatriz");
            lista_nomes.Add("Cristian");
            lista_nomes.Add("Danilo");
            lista_nomes.Add("Elias");
            lista_nomes.Add("Fabio");
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Heitor");
            lista_nomes.Add("Igor");
            lista_nomes.Add("João");

            #endregion

            #region Lista Números
            lista_numeros = new List<int>();

            lista_numeros.Add(669);
            lista_numeros.Add(8718);
            lista_numeros.Add(889);
            lista_numeros.Add(8143);
            lista_numeros.Add(656);
            lista_numeros.Add(9828);
            lista_numeros.Add(988);
            lista_numeros.Add(98178);
            lista_numeros.Add(065);
            lista_numeros.Add(6898);

            #endregion

            #region Lista Produtos
            lista_produtos = new Dictionary<string, double>();

            lista_produtos.Add("Abajur", 200);
            lista_produtos.Add("Bala", 0.5);
            lista_produtos.Add("Capacete", 439.90);
            lista_produtos.Add("Doritos", 7.25);
            lista_produtos.Add("Esmalte", 5.60);
            lista_produtos.Add("Faca", 37);
            lista_produtos.Add("Galaxy", 3978.30);
            lista_produtos.Add("Cadeira", 299);
            lista_produtos.Add("Mesa", 670);
            lista_produtos.Add("TV", 3850.70);


            #endregion

            #region Lista Estados
            lista_estados = new Dictionary<string, string>();

            lista_estados.Add("Maranhão", "Brasil");
            lista_estados.Add("Piaui", "Brasil");

            lista_estados.Add("Oregon", "EUA");
            lista_estados.Add("Texas", "EUA");

            lista_estados.Add("Sardenha", "Italia");
            lista_estados.Add("Sicilia", "Italia");

            lista_estados.Add("Bretagne", "França");
            lista_estados.Add("Occitanie", "França");

            lista_estados.Add("Madrid", "Espanha");
            lista_estados.Add("Sevilla", "Espanha");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // Obter a fonte de dados.
            // Criar a consulta.
            // Executar a consulta.

            #region Filtrando Números
            //IEnumerable<int> resultado = from num in lista_numeros where num % 2 == 0 select num;

            //foreach (int numero in resultado)
            //{
            //    lista.Items.Add(numero);
            //}
            #endregion

            #region Filtrando Nomes

            string txt = txtConsulta.Text;
            
            // A consulta abaixo retorna todas as ocorrências que iniciam com as palavras digitadas no TextBox. Se não digitar nada, vai retornar a lista inteira.
            IEnumerable<string> res2 = from nome in lista_nomes 
                                       where nome.StartsWith(txt) 
                                       select nome;


            lista.Items.AddRange(res2.ToArray()); //Converter o enumerável para um Array, evita utilizar o foreach. Basta utilizar o AddRange
            #endregion


        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            string txt = txtConsulta.Text.ToLower();

            var res = from nome in lista_nomes 
                      where nome.ToLower().Contains(txt) 
                      select nome;

            lista.Items.AddRange(res.ToArray());    
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();


            //var txtNum = Convert.ToInt32(txtConsulta.Text);
            var txtNome = txtConsulta.Text;

            //Ordenando Lista de números

            //var resNum = from num in lista_numeros 
            //          orderby num descending 
            //          where num >= txtNum 
            //          select num;

            //foreach(var item in resNum)
            //{
            //    lista.Items.Add(item);
            //}

            //var resNome = from nome in lista_nomes
            //              orderby nome descending
            //              select nome;

            var resProduto = from produto in lista_produtos
                             orderby produto.Value
                             select produto;

            foreach (KeyValuePair<string, double> produto in resProduto)
            {
                lista.Items.Add(produto.Key + " R$" + produto.Value);
            }
        }
    }
}
