namespace Demo_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclaration
            /* 
             * Commentaires sur plusieurs lignes
             */
            int age = 15;
            bool isAgeRestricted = true;

            if (isAgeRestricted)
            {
                Console.WriteLine("L'age est vérifié");
            }
            else
            {
                Console.WriteLine("Aucune vérification");
            }

            // condition ternaire 
            // condition(s) ? valeur si vrai : valeur si faux
            Console.WriteLine(isAgeRestricted ? "L'age est vérifié" : "Aucune vérification");

            #region condition avec si
            if (isAgeRestricted && age < 18)
            {
                Console.WriteLine("Dehors");
            }
            else
            {
                Console.WriteLine("Bienvenue");
            }

            if (age < 18)
            {
                Console.WriteLine("A l'école");
            }
            else if (age < 67)
            {
                Console.WriteLine("Au boulot");
            }
            else
            {
                Console.WriteLine("Bonne retraite");
            }
            #endregion

            #region switch
            string dayOfTheWeek = "Vendredi";
            string message = "Bon ";
            switch (dayOfTheWeek)
            {
                case "Lundi":
                    message += "Lundi, Le jour des frites";
                    break;
                case "Mardi":
                    message += "Mardi, Le jour des pâtes!";
                    break;
                case "Mercredi":
                    message += "Mercredi, Le jour des pizzas.";
                    break;
                case "Jeudi":
                    message += "Jeudi, Le jour du Curry.";
                    break;
                case "Vendredi":
                    message += "Vendredi, Le jour du poisson.";
                    break;
                case "Samedi":
                    message += "Samedi, Au fast-food!";
                    break;
                case "Dimanche":
                    message += "Dimanche, Reposons nous";
                    break;
                default:
                    message = "Mauvais jour";
                    break;
            }
            Console.WriteLine(message);
            #endregion


            //Bonus Coalesce : prend la première valeur non-null
            int? cote = null;
            int coteFinal = cote ?? -1;

            Console.WriteLine(coteFinal);

            if (cote == null || cote is null) { }

        }
    }
}
