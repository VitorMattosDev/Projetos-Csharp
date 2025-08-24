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

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            txtConsulta.Text = "";

            /*
             * No Dictionary vai ordenar pelo Value (País)
             * e vai retornar um tipo IEnumerable<IGrouping<string,KeyValuePair<string, string>>>
             * onde a primeira Key do tipo string é o estado.Value. O Value é o 
             * próprio Dictionary
             */
            var res = from estado in lista_estados
                      group estado by estado.Value;

            foreach (var item in res)
            {
                /*Percorrendo o IEnumerable<IGrouping<string,KeyValuePair<string, string>>> res e retornando a Key (estado.Value)
                 */
                lista.Items.Add(item.Key);

                foreach(var estado in item)
                {
                    //Percorrendo o IGrouping e retornando o Value (KeyValuePair<string, string>)
                    lista.Items.Add(estado.Key);
                }

                lista.Items.Add("");
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            // -------CONTANDO ELEMENTOS--------
            //int cont1 = lista_nomes.Count();

            //int cont2 = (from nome in lista_nomes
            //            where nome.StartsWith("G")
            //            select nome).Count();

            //lista.Items.Add(cont2 + " Começam com G");


            // -------MÉDIA ELEMENTOS--------
            //double media1 = lista_numeros.Average();

            //var media2 = (from numero in lista_numeros
            //             select numero).Average();

            //lista.Items.Add(media2 + " - Média dos valores");


            // -------SOMA ELEMENTOS--------
            //int soma1 = lista_numeros.Sum();

            //var soma2 = (from numero in lista_numeros
            //            select numero).Sum();
            //lista.Items.Add(soma2 + " - Soma dos valores");


            // -------VALOR MÍNIMO E MÁXIMO--------
            //lista.Items.Add(lista_numeros.Max() + " É o maior");
            //lista.Items.Add(lista_numeros.Min() + " É o menor");


            // -------OPERADOR AGGREGATE--------

            var maiorNome = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) =>
            {
                if (maior.Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }

            });

            lista.Items.Add(maiorNome + " é o maior nome");

        }

        private void btnOperadoresDeElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //int primeiro = lista_numeros.First();  //Vai dar erro se a lista estiver vazia
            int primeiro2 = lista_numeros.FirstOrDefault(); //Não dá erro se lista estiver vazia (retorna 0)

            //int ultimo = lista_numeros.Last();
            int ultimo2 = lista_numeros.LastOrDefault();

            //int elementoPosicao = lista_numeros.ElementAt(3);
            int elementoPosicao2 = lista_numeros.ElementAt(3);

            var consultaPosicao = (from num in lista_numeros
                                  where num > 1000
                                  select num).ElementAtOrDefault(2);



            lista.Items.Add(primeiro2); 
            lista.Items.Add(ultimo2);
            lista.Items.Add(elementoPosicao2);
            lista.Items.Add(consultaPosicao);

        }

        private void btnLINQLambda_Click(object sender, EventArgs e)
        {
            //var cons1 = from nomes in lista_nomes select nomes;
            //var cons2 = lista_nomes.Select(nome => nome); //Lambda que equivale à consulta LINQ em cons1
            //lista.Items.AddRange(cons2.ToArray());

            //var cons3 = from nomes in lista_nomes where nomes.StartsWith("B") select nomes;
            //var cons4 = lista_nomes.Where(nome => (nome.StartsWith("G")));
            //lista.Items.AddRange(cons4.ToArray());

            //var cons5 = from nomes in lista_nomes orderby nomes descending select nomes;
            //var cons6 = lista_nomes.OrderByDescending(nome => nome);
            //lista.Items.AddRange(cons6.ToArray());

            var cons7 = from pais in lista_estados group pais by pais.Value;
            var cons8 = lista_estados.GroupBy(pais => pais.Value);

            foreach(var pais in cons8)
            {
                lista.Items.Add(pais.Key);

                foreach(var estado in pais)
                {
                    lista.Items.Add("    " + estado.Key);
                }
            }

        }
    }
}
