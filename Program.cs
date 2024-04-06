namespace Parcial2_ejerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego Adivina el número");

            int numJugadores;

            do
            {
                Console.WriteLine("Por favor, ingrese el numero de jugadores ( entre 2 y 4):");
                int.TryParse(Console.ReadLine(), out numJugadores);

             } while (numJugadores > 0);


        }
    }
}
