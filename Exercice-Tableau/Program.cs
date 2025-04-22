using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Text;

namespace Exercice_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region moyenne des scores
            // Écrire un algorithme demandant à l’utilisateur le nombre de joueurs
            // (max 10 joueurs).
            // Ensuite, l’algorithme doit demander à l’utilisateur le score de
            // chaque joueur.
            // Une fois ceci fini, il faut afficher la moyenne des scores.

            //int nbUtilisateur, score;
            //double moyenne = 0;

            //do
            //{
            //    Console.WriteLine("Combien de joueur ? (max 10)");
            //    nbUtilisateur = int.Parse(Console.ReadLine());
            //} while (nbUtilisateur <= 0 || nbUtilisateur > 10);

            //int[] tabPlayer = new int[nbUtilisateur];
            //int index = 0;
            //while (index < nbUtilisateur)
            //{
            //    Console.WriteLine($"Entrer le score du joueur {index + 1} :");
            //    tabPlayer[index] = int.Parse(Console.ReadLine());
            //    index++;
            //}
            //// Le calcul de la moyenne
            //index = 0;
            //while (index < nbUtilisateur)
            //{
            //    moyenne = tabPlayer[index] + moyenne;
            //    index++;
            //}
            //moyenne = moyenne / nbUtilisateur;
            //Console.WriteLine($"La moyenne est égale à {moyenne}");
            #endregion

            #region Inversion d'un tableau
            // Inverser un tableau: soit un tableau T.
            // Saisir ce tableau.Changer de place les éléments de ce tableau
            // de façon à ce que le nouveau tableau soit une
            // sorte de miroir de l'ancien et afficher le nouveau tableau.
            // [4,3,2,1] => [1,2,3,4]

            //int i, j = 0;
            //int[] tab1 = new int[5], tab2 = new int[5];

            //for (i = 0; i < tab1.Length; i++)
            //{
            //    Console.WriteLine("Entrez une valeur");
            //    tab1[i] = int.Parse(Console.ReadLine());
            //}

            ////3 façon d'inverser notre tableau

            ////for (i = tab1.Length - 1; i >= 0; i--)
            ////{
            ////    tab2[j] = tab1[i];
            ////    j++;
            ////}

            ////for (j = 0; j < tab1.Length;j++)
            ////{
            ////    i--;
            ////    tab2[j] = tab1[i];
            ////}

            ////for (j = 0; j < tab1.Length; j++)
            ////{
            ////    tab2[j] = tab1[tab1.Length - 1 - j];
            ////}

            //for (i = 0; i < tab2.Length; i++)
            //{
            //    Console.Write($"{tab2[i]}  ");
            //}
            //Console.WriteLine();
            #endregion

            #region Tri d'un tableau
            // À l’aide des boucles, réalisez un algorithme permettant 
            // de trier un tableau d’entier dans l’ordre croissant.

            //int[] tab1 = new int[5];

            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    Console.WriteLine("Entrez une valeur");
            //    tab1[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    Console.Write($"{tab1[i]}  ");
            //}

            //for(int i = tab1.Length -1 ; i >= 0; i--)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        if (tab1[j] > tab1[j+1])
            //        {
            //            int temp = tab1[j];
            //            tab1[j] = tab1[j + 1];
            //            tab1[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    Console.Write($"{tab1[i]}  ");
            //}

            #endregion

            #region fusion et tri de 2 tableaux
            // En considérant deux tableaux d'entiers (non triés),
            // réalisez un algorithme qui place tous les éléments des
            // deux tableaux dans un troisième.
            // Ce dernier doit être trié une fois l'algorithme terminé.
            // Notez que le tri doit être fait en même temps que la
            // fusion des deux tableaux et pas après.
            #endregion

            #region deplacer un pion
            //Réalisez un algorithme nous permettant de déplacer un pion
            //dans un tableau de 10 éléments.
            //Au début, le pion se trouve dans la première case du tableau.
            //Nous pouvons ensuite le déplacer par la gauche(g),
            //par la droite(d) ou de stopper l'algorithme (q).
            #endregion

            #region recherche la position d'un élément
            // Réalisez un algorithme permettant de rechercher une
            // valeur dans un tableau.Si la valeur se trouve bien
            // dans la tableau, nous affichons sa position.
            #endregion

            #region le plus nombre de 10 valeurs
            // Refaites l'algorithme qui demande à l’utilisateur de taper
            // 10 entiers et qui affiche le plus petit de ces entiers mais
            // cette fois - ci à l'aide d'un tableau et sans retenir le
            // minimum lors de la saisie.
            #endregion

            #region ajout d'un valeur à un tableau trié
            // En considérant un tableau d'entiers trié dans l'ordre croissant,
            // réaliser un algorithme étant capable d'insérer une nouvelle
            // valeur dans le tableau de façon à ce que la tableau reste trié.
            // Le but n'est évidemment pas d'insérer la valeur à la fin
            // et de trier après mais bien de l'insérer au bon endroit directement.
            #endregion

            #region supprimer une valeur
            // Réalisez un algorithme dans lequel nous devons rechercher
            // une valeur (entrée par l'utilisateur) dans un tableau d'entiers.
            // Si on trouve cette valeur, nous devons la supprimer du tableau. 
            #endregion
        }
    }
}
