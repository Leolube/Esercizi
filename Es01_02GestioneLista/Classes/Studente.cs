using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Es01_02GestioneLista.Classes
{
    internal class Studente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public double Voto { get; set; }
        static public List<Studente> Studenti { get; set; } = new List<Studente>();

        public Studente(string? nome, string? cognome, double voto)
        {
            Nome = nome;
            Cognome = cognome;
            Voto = voto;
        }

        public void AggiungiStudente()
        {
            string? nome;
            string? cognome;
            double voto;

            Console.WriteLine("Inserisci nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome:");
            cognome = Console.ReadLine();
            Console.WriteLine("Inserisci voto:");

            voto = Convert.ToDouble(Console.ReadLine());
            if (voto <= 10 && voto >= 0)
            {
                Studente studente = new Studente(nome, cognome, voto);
                Studenti.Add(studente);
                Console.WriteLine("Studente aggiunto con successo");
            }
            else { 
                Console.WriteLine("Voto non valido, inserisci un voto da 0 a 10");
                 }

            
        }

        public void ModificaStudente(Studente studente)
        {
            Console.WriteLine("Cosa vuoi modificare? \nPremi : \nn-Nome \nc-Cognome \n v - voto");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "n":
                    Console.WriteLine("Inserisci nuovo nome");
                    studente.Nome = Console.ReadLine(); 
                    break;
                case "c":
                    Console.WriteLine("Inserisci nuovo cognome");
                    studente.Cognome = Console.ReadLine();
                    break;

                case "v":
                    Console.WriteLine("Inserisci nuovo voto");
                    studente.Voto =Convert.ToDouble(Console.ReadLine());
                    break;


                default:
                    break;
            }
        }

        public void StampaLista()
        {
            foreach (Studente st in Studenti)
            {
                Console.WriteLine($"{st.Nome} {st.Cognome} ");
            }
        }

        public void FiltraStudenti()
        {
            
            
            Console.WriteLine("Inserisci voto minimo");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci voto massimo");
            double max = Convert.ToDouble(Console.ReadLine());

            foreach (Studente st in Studenti)
            {
                if(st.Voto > min && st.Voto < max)
                {
                    Console.WriteLine($"{Nome} {Cognome} {Voto}");
                }
            }
            
        }

        public void EliminaStudente()
        {
            Console.WriteLine("Inserisci il nome dello studente da cancellare: ");
            string? cancellaNome = Console.ReadLine();
            foreach  (Studente studente in Studenti)
            {
                if (studente.Equals(cancellaNome))
                {
                    Console.WriteLine($"Studente {studente.Nome} {studente.Cognome} Cancellato. ");
                    Studenti.Remove(studente);
                }
                
            }
        }



    }
}
