namespace Demo_Fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ecrire("Hello world!");

            //int nb1 = 5, nb2 = 8;
            //Console.WriteLine($"{nb1} {nb2}");
            //Echanger2(ref nb1, ref nb2);
            //Console.WriteLine($"{nb1} {nb2}");

            int longueurMessage = Longueur("Hello world!");

            int choix;

            if (int.TryParse(Console.ReadLine(),out choix))
            {
                
            }
            Console.WriteLine(choix);

            float moyenne = Moyenne(1,2, 5, 6);

            Saluer();

            // procedure NomProcedure ()
            //      instructions
            // FinProcedure

            //  Fonction NomFonction () : Entier
            //      instructions
            //      renvoie 0
            //  FinFonction
        }
        public static void Ecrire(string message)
        {
            Console.WriteLine(message);
        }
        // passage par valeur
        // on passe une copie des valeurs
        public static void Echanger(int nombre1, int nombre2)
        {
            int temp = nombre1;
            nombre1 = nombre2;
            nombre2 = temp;
        }
        // passage par reference
        // on passe l'espace mémoire des différente variable
        public static void Echanger2(ref int nombre1, ref int nombre2)
        {
            int temp = nombre1;
            nombre1 = nombre2;
            nombre2 = temp;
        }
        public static int Longueur(string message)
        {
            return message.Length;
        }
        public static bool EssayerConverionEntier(string message, out int maSortie)
        {
            try
            {
                maSortie = int.Parse(message);
                return true;
            }
            catch(Exception exception)
            {
                maSortie = 0;
                return false;
            }
        }
        public static float Moyenne(params int[] nb)
        {
            float moyenne = 0f;
            for(int i =0; i < nb.Length; i++)
            {
                moyenne += nb[i];
            }
            moyenne /= nb.Length;
            return moyenne;
        }
        public static void Saluer(string nom = "Samuel")
        {
            Console.WriteLine($"Bonjour {nom}");
        }
    }
}
