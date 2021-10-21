using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);
        }
        //Créer une combinaison de 4 couleurs//
        static void ChoixCombi(out int[] combi)
        {
            combi = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }

        static void Afficher(int[] combi){
            for (int i = 0; i < 4; i++){
                Console.Write(combi[i]);
            }
        }


    }
}
 