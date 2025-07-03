namespace MediaAlunosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos alunos? ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[qtdAlunos];

            Console.Clear();


            for (int i = 0; i < qtdAlunos; i++)
            {

                Console.Write("Aluno #" + (i+1) + " Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Aluno #" + (i+1) + " Provas: ");
                int qtdProvas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, qtdProvas);
                alunos[i].CalculaMedia();

                Console.Clear();

            }


            double somaMedia = 0;

            foreach (Aluno aluno in alunos)
            {

                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + (aluno.Media).);
                Console.WriteLine();
                somaMedia += aluno.Media;
            }

            Console.WriteLine("Media geral dos alunos: " + (somaMedia / qtdAlunos));

        }
    }
}
