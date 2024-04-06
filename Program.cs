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

             } while (numJugadores < 2 || numJugadores > 4);

            int rangInicio = 0;
            int rangFin = 0;


            switch (numJugadores)
            {
                case 2:
                    rangFin = 50;
                    break;

                case 3:
                    rangFin = 100;
                    break;

                case 4:
                    rangFin = 200;
                    break;


            }
            Random random = new Random();
            int numeroAleatorio = 
        }
    }
}
