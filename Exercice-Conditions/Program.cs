namespace Exercice_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region année bissextile
            //Année bissextile(Pseudo-Code + C#)
            //Réaliser un petit algorithme qui sur base d’une année donnée va déterminer s’il s’agit d’une année bissextile.Une
            //année est bissextile si elle est divisible par 4, mais non divisible par 100.Ou si elle est divisible par 400.

            //Console.WriteLine("Donnez une année");
            //int annee = int.Parse(Console.ReadLine());

            //if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
            //{
            //    Console.WriteLine($"L'année {annee} est bissextile");
            //}
            //else
            //{
            //    Console.WriteLine($"L'année {annee} n'est pas bissextile");
            //}

            #endregion

            #region lanceur de balle
            //            Lanceur de balles de tennis(Pseudo - Code)
            //Réaliser l’algorithme d’un lanceur de balles de tennis. Ce lanceur possède deux états:
            //– prêt: permet de savoir si le tennisman est prêt. Il ne faut pas lancer de balles dans le cas contraire
            //– panierVide: permet de savoir s’il y a encore des balles disponibles
            //Le lanceur de balle possède l’opération « lancerBalle » qui, vous l’aurez compris, permet de lancer une balle.

            //bool pret = true, panierVide = false, lancerDeBalle = false;

            //lancerDeBalle = pret && !panierVide;
            //Console.WriteLine(lancerDeBalle);
            #endregion

            #region distributeur
            //            Distributeur de boissons(Pseudo - Code)
            //Réaliser l’algorithme d’un distributeur de boissons. Ce dernier propose plusieurs boissons et l’utilisateur choisit celle
            //qu’il désire en entrant le numéro correspondant.Ne pas oublier de vérifier s’il y a encore des boissons en stock.

            Console.WriteLine("Quelle boisson désirez vous ? coca, fanta");
            int stockCoca = 5, stockFanta = 1;

            string entreeUtilisateur = Console.ReadLine();
            switch (entreeUtilisateur.ToLower())
            {
                case "coca":
                    if (stockCoca > 0)
                    {
                        Console.WriteLine("Voici votre coca");
                        stockCoca--;
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus de coca");
                    }
                    break;
                case "fanta":
                    if (stockFanta > 0)
                    {
                        Console.WriteLine("Voici votre fanta");
                        stockFanta--;
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus de fanta");
                    }
                    break;
                default:
                    Console.WriteLine("boisson inconnue");
                    break;

            }



            // /* Version avancé (avec tableau et boucle pour affichage */

            //string[] nomBoisson = new string[] { "coca", "fanta" };
            //int[] stock = new int[] { 5, 0 };

            //string message = "Choisissez une boisson :";
            //for(int i = 0 ; i < nomBoisson.Length ; i++)
            //{
            //    message += $" {nomBoisson[i]}";
            //}
            //Console.WriteLine(message);

            //string entreeUtilisateur = Console.ReadLine();
            //int index = -1;
            //for(int i = 0; i < nomBoisson.Length; i++)
            //{
            //    if (nomBoisson[i] == entreeUtilisateur.ToLower())
            //    {
            //        index = i;
            //    }
            //}
            //if (index != -1)
            //{
            //    // Cas où la bisson a été trouvé
            //    if (stock[index] > 0)
            //    {
            //        Console.WriteLine($"Voici votre {nomBoisson[index]}");
            //        stock[index]--;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Il n'y a plus de {nomBoisson[index]}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Boisson non distribué");
            //}

            #endregion

            #region calculatrice
            //            Calculatrice(Pseudo - Code + C#)
            //Réaliser l’algorithme d’une calculatrice basique.L’utilisateur est invité à saisir un nombre, un opérateur, et un
            //deuxième nombre.La calculatrice affiche ensuite le résultat.

            int nombre1, nombre2;
            float resultat = 0;
            char operateur;
            bool calculValide = true;

            Console.WriteLine("Quel est le premier nombre ?");
            nombre1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quel est l'opération ?");
            operateur = char.Parse(Console.ReadLine());

            Console.WriteLine("Quel est le deuxiéme nombre ?");
            nombre2 = int.Parse(Console.ReadLine());

            switch (operateur)
            {
                case '+':
                    resultat = nombre1 + nombre2;
                    break;
                case '-':
                    resultat = nombre1 - nombre2;
                    break;
                case 'x':
                case '*':
                    resultat = nombre1 * nombre2;
                    break;
                case '/':
                    if (nombre2 == 0)
                    {
                        Console.WriteLine("Erreur division par zero");
                        calculValide = false;
                        break;
                    }
                    resultat = (float)nombre1 / nombre2;
                    break;
                default:
                    Console.WriteLine("operateur inconnu");
                    calculValide = false;
                    break;
            }
            if (calculValide)
            {
                Console.WriteLine($"{nombre1} {operateur} {nombre2} = {resultat}");
            }

            #endregion
        }
    }
}
