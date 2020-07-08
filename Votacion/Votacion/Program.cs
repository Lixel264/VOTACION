using System;
using System.Runtime.Intrinsics;

namespace Votacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int ep = 0, jjb = 0, el = 0, voto;
            double total, op1, op2, op3;
            string ganador;

            Console.WriteLine("Estos son los candidatos: \n" + "\n1.El Penco. \n" + "\n2.EL Jojoto Blanco. \n" + "\n3.El Lidel. \n");
            Console.WriteLine("Si quieres cerrarlo pulsa 4 \n");

            do
            {
                Console.Write("Seleccione el número de su candidato: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    ep += 1;
                }
                else if (voto == 2)
                {
                    jjb += 1;
                }
                else if (voto == 3)
                {
                    el += 1;
                }
                else if (voto > 4 || voto < 0)
                {
                    Console.WriteLine("ERROR, ingrese un número válido");
                }
            } while (voto != 4);
            Console.WriteLine();

            total = ep + jjb + el;
            op1 = (ep / total) * 100;
            op2 = (jjb / total) * 100;
            op3 = (el / total) * 100;

            Console.WriteLine("El Penco tiene: " + op1 + "\n" +"\nEl Jojoto Blanco tiene: " + op2 + "\n" + "\nEl Lidel tiene: " + op3 + "\n");

            if(ep > jjb && ep > el)
            {
                ganador = "El Penco";
                Console.WriteLine("El ganador es: " + ganador);
            }
            if(jjb > ep && jjb > el)
            {
                ganador = "El Jojoto Blanco";
                Console.WriteLine("El ganador es: " + ganador);
            }
            if (el > jjb && el > ep)
            {
                ganador = "El Lidel";
                Console.WriteLine("El ganador es: " + ganador);
            }
            if (ep == jjb)
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL PENCO Y EL JOJOTO BLANCO");
            }
            if (ep == el)
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL PENCO Y EL LIDEL");
            }
            if (el == jjb)
            {
                Console.WriteLine("HUBO UN EMPATE ENTRE EL LIDEL Y EL JOJOTO BLANCO");
            }
            Console.ReadKey();
        }
    }
}
