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
    }
}
