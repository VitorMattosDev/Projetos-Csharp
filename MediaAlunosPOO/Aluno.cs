using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunosPOO
{
    internal class Aluno
    {

        public string Nome { get; set; }
        public double[] Notas { get; set; }
        public double Media { get; private set; }

        public Aluno(string nome, int qtdProvas)
        {
            Nome = nome;
            Notas = new double[qtdProvas];
        }

        public void CalculaMedia()
        {
            Console.WriteLine("Insira as notas do aluno " + Nome);
            double somaNota = 0;

            for(int i = 0; i < Notas.Length; i++)
            {
                Console.Write("Nota " + (i+1) + ":");
                somaNota += double.Parse(Console.ReadLine());
            }

            Media = somaNota / Notas.Length;
        }
    }
}
