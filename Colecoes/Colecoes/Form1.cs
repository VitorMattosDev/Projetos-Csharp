using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Array
            string[] nomes = new string[3];
            nomes[0] = "Gabriel";
            nomes[1] = "Arthur";
            nomes[2] = "Danny";

            // Lista Generica
            List<string> nomes2 = new List<string>();

            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes); 

            //if (nomes2.Remove("Lucas"))
            //{
            //    MessageBox.Show("Lucas removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possivel remover.");
            //}

            //if (nomes2.Contains("Danny"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém");
            //}

            //MessageBox.Show("Número de elementos: " + nomes2.Count);

            //nomes2.Sort();

            //MessageBox.Show("Gabriel está no indice: " + nomes2.IndexOf("João"));

            //nomes2.Insert(2, "João");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();

            nomes2.Add("Arthur");

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

            //MessageBox.Show(veiculos.ElementAt(2));

            //if (veiculos.Add("Moto"))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            //if (veiculos.Contains("Carro"))
            //{
            //    MessageBox.Show("Contem.");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contem.");
            //}

            // veiculos.Remove("");
            // veiculos.Count;
            // veiculos.Clear();
            // veiculos.First();
            // veiculos.Last();

            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 150, "Danny" },
                { 200, "Arthur" },
                { 80, "Danny" }
            };

            alunos.Add(100, "Gabriel");

            // alunos.ContainsKey(810);

            if (alunos.ContainsValue("Arthur"))
            {
                MessageBox.Show("Contém o aluno");
            }
            else
            {
                MessageBox.Show("Não Contém o aluno");
            }
            

            // alunos.Remove(80);
            // alunos.Clear();

            // KeyValuePair<int, string> primeiro = alunos.First();
            // MessageBox.Show("Primeiro " + primeiro.Key + " " + primeiro.Value);
            
            // MessageBox.Show("Último " + alunos.Last().Key + " " + alunos.Last().Value);
            
            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }

            //MessageBox.Show("Quantidade de alunos: " + alunos.Count);
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Danny" },
                { 10, "Gabriel" },
                { 17, "Arthur" }
            };

            alunos.Add(14, "Glória");
            //alunos.Reverse();

            //alunos.Remove(10);
            //alunos.RemoveAt(0);
            //alunos.Count;
            //alunos.ContainsKey(50);
            //alunos.ContainsValue("Danny");

            foreach (KeyValuePair<int,string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                { 4512, "Gabriel" },
                { 1542, "Arthur" },
                { 2145, "Danny" }
            };

            alunos.Add(5478, "Fávio");

            // alunos.Remove(120);
            // alunos.Count;
            // alunos.Clear();
            // alunos.ContainsKey(1542);
            // alunos.ContainsValue("Danny");
            // MessageBox.Show(alunos.ElementAt(0).ToString());

            foreach (KeyValuePair<int,string> item in alunos.Reverse())
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Gabriel", "Danny", "Arthur", "Flávio", "Beatriz"
            };

            if (!nomes.Add("Lucas"))
            {
                MessageBox.Show("Não podes repstir o valor");
            }

            //nomes.Reverse();
            //nomes.Remove("Flávio");
            //nomes.ElementAt(1);
            //nomes.First();
            //nomes.Last();
            //nomes.Count;

            //nomes.Clear();

            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Gabriel");
            fila.Enqueue("Danny");
            fila.Enqueue("Arthur");

            MessageBox.Show(fila.Count.ToString());

            foreach (string item in fila)
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show("Primeiro da fila " + fila.Peek());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila " + fila.Dequeue());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila " + fila.First());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Último da fila " + fila.Last());
            //MessageBox.Show(fila.Count.ToString());

            //fila.Clear();
            while (fila.Count > 0)
            {
                MessageBox.Show("Primeiro da fila " + fila.Dequeue());
                MessageBox.Show(fila.Count.ToString());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }            
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Gabriel");
            pilha.Push("Danny");
            pilha.Push("Arthur");

            MessageBox.Show(pilha.Count.ToString());

            foreach (string item in pilha)
            {
                lista.Items.Add(item);
            }

            // MessageBox.Show("Elemento no topo " + pilha.Peek());
            // MessageBox.Show(pilha.Count.ToString());   

            // pilha.Clear();

            while (pilha.Count > 0)
            {
                MessageBox.Show("Elemento no topo " + pilha.Pop());
                MessageBox.Show(pilha.Count.ToString());
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }
        }
    }
}
