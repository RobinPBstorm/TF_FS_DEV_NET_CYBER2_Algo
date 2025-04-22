namespace Exercice_Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exposant 10
            //À l’aide de la boucle de votre choix,
            //réaliser un algorithme calculant le résultat de
            //N10.N étant un nombre saisi par l’utilisateur.

            //int n, exposant = 10, i = 0, resultat = 1;

            //Console.WriteLine("Donnez moi un chiffre");
            //n = int.Parse(Console.ReadLine());

            //while (i < exposant)
            //{
            //    resultat *= n;
            //    i++;
            //}

            //Console.WriteLine($"{n} exposant {exposant} vaut {resultat}");

            #endregion

            #region exposant libre
            //Reprenez l’exercice précédent et modifiez le pour que
            //l’utilisateur entre également
            //l’exposent qu’il désire calculer.

            //int n, exposant, i = 0, resultat = 1;

            //Console.WriteLine("Donnez moi un chiffre");
            //n = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("Donnez moi un exposant");
            //    exposant = int.Parse(Console.ReadLine());
            //} while (exposant < 0);

            //while (i < exposant)
            //{
            //    resultat *= n;
            //    i++;
            //}

            //Console.WriteLine($"{n} exposant {exposant} vaut {resultat}");
            #endregion

            #region Pierre Papier Ciseaux
            // Programmer le jeu du pierre papier ciseaux
            // Pour rappel : la pierre l'emporte sur les ciseaux,
            //      les ciseaux bât le papier et
            //      le papier gagnent face à la pierre.
            // La partie s'arrête quand un joueur a 3 points

            int pointJoueur = 0, pointMachine = 0;
            // 0 => pierre
            string[] choix = new string[] { "pierre", "papier", "ciseaux" };
            int choixUtilisateur, choixMachine;

            while (pointJoueur < 3 && pointMachine < 3)
            {
                // choix utilisateur
                do
                {
                    Console.WriteLine("Choisissez entre pierre (0), papier (1) ou ciseaux (2)");
                    choixUtilisateur = int.Parse(Console.ReadLine());
                } while (choixUtilisateur != 0 && choixUtilisateur != 1 && choixUtilisateur != 2);

                // choix machine
                choixMachine = new Random().Next(3);

                // Affichage des choix
                Console.WriteLine($"Vous avez choisit {choix[choixUtilisateur]}");
                Console.WriteLine($"L'ordinateur a choisit {choix[choixMachine]}");

                // Vérifier les différents
                if (choixMachine == choixUtilisateur)
                {
                    Console.WriteLine("C'est une égalité");
                }
                else if ((choixUtilisateur == 0 && choixMachine == 2) ||
                    (choixUtilisateur == 1 && choixMachine == 0) ||
                    (choixUtilisateur == 2 && choixMachine == 1))
                {
                    Console.WriteLine("vous avez gagné ce tour-ci.");
                    pointJoueur++;
                }
                else
                {
                    Console.WriteLine("Vous avez perdu cette fois-ci");
                    pointMachine++;
                }

                // Affichage du score final
                Console.WriteLine($"Actuellement le score est de {pointJoueur} pour le joueur et {pointMachine} pour l'ordinateur");

            }
            #endregion
        }
    }
}
