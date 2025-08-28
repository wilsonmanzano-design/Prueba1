using System;

class Program
{
    static void Main()
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 21); // Número entre 1 y 20
        int intento;
        int i = 0;
        
        Console.WriteLine("¡Adivina el número secreto entre 1 y 20!");

        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = Convert.ToInt32(Console.ReadLine());

            if (intento > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else
            {
                Console.WriteLine("¡Correcto! El número secreto era " + numeroSecreto);
            }
            i++;
            Console.WriteLine("numero de intentos " + i);

        } while (intento != numeroSecreto && i <= 5);
    }
}
