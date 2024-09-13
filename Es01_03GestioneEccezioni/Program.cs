namespace Es01_03GestioneEccezioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string? riga;
			
			int ris;

			try
			{
				StreamReader sr = new StreamReader("C:\\Users\\Utente\\source\\repos\\Es01_03GestioneEccezioni\\Es01_03GestioneEccezioni\\numeri.txt");


				riga = sr.ReadLine();
				ris = Convert.ToInt32(riga);

				while (riga != null) 
				{
					riga = sr.ReadLine();

					ris += Convert.ToInt32(riga);
				}
				sr.Close();
                Console.WriteLine($"La somma dei numeri nel file è: {ris}");
					
			}
			catch (System.FormatException)
			{

                Console.WriteLine("C'è una lettera nel file");
			}
        }
    }
}
