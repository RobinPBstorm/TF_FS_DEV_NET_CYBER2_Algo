namespace Demo_Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while => tant que
            int compteur = 0;
            while (compteur < 10)
            {
                if (compteur == 8)
                {
                    break;
                }
                else if (compteur == 5)
                {
                    compteur++;
                    continue;
                }
                compteur++;
            }
            #endregion

            #region do while => faire tant que
            do
            {
                // effectuer au moins une fois
                compteur++;
            } while (compteur < 10);
            #endregion

            #region for => pour
            for (compteur = 0; compteur < 10 && compteur > 0; compteur++)
            {

            }
            #endregion

           
            #region foreach => pour chaque
            int[] tab = new int[] { 5, 10, 6 };
            foreach(int nb in tab)
            {
                Console.WriteLine(nb);
            }
            #endregion
        }
    }
}
