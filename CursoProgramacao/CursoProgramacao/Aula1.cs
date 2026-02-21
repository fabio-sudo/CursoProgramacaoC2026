using System.IO;

namespace CursoProgramacao
{
    public class Aula1
    {
        int valor1;
        int valor2;

        //Método Somar
        public void Soma()
        {
            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 + valor2}");
        }

        //Multiplicar
        public void Multiplicar() { 
        
            Console.WriteLine("Informe Primeiro Valor");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Segundo Valor");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 * valor2}");
        }

        //Subtrair
        public void Subtrair()
        {
            Console.WriteLine("Informe Primeiro Valor");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Segundo Valor");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 - valor2}");
        }

        //Divisão
        public void Dividir()
        {
            Console.WriteLine("Informe Primeiro Valor");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Segundo Valor");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 / valor2}");
        }
    }
}
