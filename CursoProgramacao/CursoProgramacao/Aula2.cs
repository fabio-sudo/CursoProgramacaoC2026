namespace CursoProgramacao
{
    public class Aula2
    {
        public void ValorPar()
        {
            Console.WriteLine("Informe um valor:");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }

        public void MaiorIdade()
        {
            int idade = 0;
            Console.WriteLine("Informe sua idade:");
            
            idade =
                int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Maior");
            }
            else 
            {
                Console.WriteLine("Menor");
            }

        }

        public void Avalicao()
        {
            int nota;
            Console.WriteLine("Informe sua nota");

            nota = int.Parse(Console.ReadLine());

            if(nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if(nota >= 5)
            {
                Console.WriteLine("Recuperação");
            }
            else if (nota >= 3)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }




    }
}
