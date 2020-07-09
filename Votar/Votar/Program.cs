using System;

namespace Votar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es un sistema de votación aleatorio. \n" + "\nLos candidatos son: \n" + "\n1.El Penco (Presidente). Partido: Partido Ladrones Dominicanos (PLD). Año: 1233. \n" + "2.El Jojoto Blanco (Presidente). Partido: Partido Rico de Mami (PRM). Año: 2039. \n" + "3.El Lidel (Presidente). Fucking Para (FP). Año: 2078. \n" + "4.El Moreno (Presidente). Abusadores del País (ALPAÍS). Año: 2000. \n");
            Random rng = new Random();
            int[] nc = {0, 0, 0, 0};
            double total, op1, op2, op3, op4;

            for (int i = 1; i < 1001; i++)
            {
                int vr = rng.Next(1, 5);
                if(vr == 1)
                {
                    nc[0] += 1;
                }
                if (vr == 2)
                {
                    nc[1] += 1;
                }
                if (vr == 3)
                {
                    nc[2] += 1;
                }
                if (vr == 4)
                {
                    nc[3] += 1;
                }
            }
            Console.WriteLine("Aqui están los votos: \n" + "\nEl Penco tiene: " + nc[0] + " votos." + "\n" + "El Jojoto Blanco tiene: " + nc[1] + " votos." + "\n" + "El Lidel tiene: " + nc[2] + " votos." + "\n" + "El Moreno tiene: " + nc[3] + " votos." + "\n");

            total = nc[0] + nc[1] + nc[2] + nc[3];
            op1 = (nc[0] / total) * 100;
            op2 = (nc[1] / total) * 100;
            op3 = (nc[2] / total) * 100;
            op4 = (nc[3] / total) * 100;

            Console.WriteLine("\nEl porcentaje sería: \n" + "\nEl Penco tiene: " + op1.ToString("N2") + "%" + "\n" + "El Jojoto Blanco tiene: " + op2.ToString("N2") + "%" + "\n" + "El Lidel tiene: " + op3.ToString("N2") + "%" + "\n" + "El Moreno tiene: " + op4.ToString("N2") + "%" + "\n");

            if (nc[0] > nc[1] && nc[0] > nc[2] && nc[0] > nc[3])
            {
                Console.WriteLine("El ganador es: El Penco.");
            }
            if (nc[1] > nc[0] && nc[1] > nc[2] && nc[1] > nc[3])
            {
                Console.WriteLine("El ganador es: El Jojoto Blanco.");
            }
            if (nc[2] > nc[1] && nc[2] > nc[0] && nc[2] > nc[3])
            {
                Console.WriteLine("El ganador es: El Lidel.");
            }
            if (nc[3] > nc[2] && nc[3] > nc[0] && nc[3] > nc[1])
            {
                Console.WriteLine("El ganador es: El Moreno.");
            }
            if (nc[0] == nc[1])
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL PENCO Y EL JOJOTO BLANCO");
            }
            if (nc[0] == nc[2])
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL PENCO Y EL LIDEL");
            }
            if (nc[0] == nc[3])
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL PENCO Y EL MORENO");
            }
            if (nc[2] == nc[1])
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL LIDEL Y EL JOJOTO BLANCO");
            }
            if (nc[2] == nc[3])
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL LIDEL Y EL MORENO");
            }
            if (nc[1] == nc[3])
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL JOJOTO BLANCO Y EL MORENO");
            }
            Console.WriteLine("\nOrden por total de votos: " + "\n");
            for (int i = 0; i < nc.Length; i++)
            {
                for (int j = i + 1; j < nc.Length; j++)
                {
                    int aux;
                    if (nc[i] > nc[j])
                    {
                        aux = nc[i];
                        nc[i] = nc[j];
                        nc[j] = aux;
                    }
                }

            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(nc[i]);
            }
            Console.ReadKey();

        }
    }
}
