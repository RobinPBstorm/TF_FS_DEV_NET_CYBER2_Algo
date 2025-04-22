namespace Demo_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // des variables
            int maVariable1 = 5, maVariable2 = 8, maVariable3 = 1;

            // L'équivaent des variables en un tableau
            int[] monTableau = new int[3];
            monTableau[0] = 5;
            monTableau[1] = 8;
            monTableau[2] = 1;
            // et voici une autre façon de créer un tableau avec des valeurs
            int[] monTableau2 = new int[] { 5, 8, 1 };

            // Boucles pour afficher les différentes cases
            // for
            for(int i = 0; i < monTableau.Length; i++)
            {
                Console.WriteLine(monTableau[i]);
            }
            // foreach => Pour chaque valeur (int) de mon tableau
            foreach(int valeur in monTableau)
            {
                Console.WriteLine(valeur);
            }

            // Ajout d'un élément dans un tableau
            int[] monTableau3 = new int[4];
            for (int i = 0; i < monTableau2.Length; i++)
            {
                monTableau3[i] = monTableau2[i];
            }
            monTableau3[3] = 7; // ajout de la valeur dans la dernière case
            for (int i = 0; i < monTableau3.Length; i++)
            {
                Console.WriteLine(monTableau3[i]);
            }

            // les strings peuvent être employé comme des tableaux de char
            string mot = "week-end";
            for (int i = 0; i < mot.Length; i++)
            {
                Console.WriteLine(mot[i]);
            }

            // liste entiers
            List<int> mesEntiers = new List<int>();
            mesEntiers.Add(5);

            foreach(int valeur in mesEntiers)
            {
                Console.WriteLine(valeur);
            }

            mesEntiers.Remove(5);

            foreach (int valeur in mesEntiers)
            {
                Console.WriteLine(valeur);
            }

            // tableau à plusieurs
            // int[3] => [][][]
            int[,] plateau = new int[5, 5];
            int[][] mesCotes = new int[5][];
            mesCotes[0] = new int[6];
            mesCotes[1] = new int[5];
        }
    }
}
