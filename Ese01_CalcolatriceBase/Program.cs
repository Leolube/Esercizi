namespace Ese01_CalcolatriceBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;

            string? operazione = "";

            double ris;
            string? exit = "";

            bool on = true;

            while (on)
            {

                try
                {

                    
                    Console.WriteLine("Inserisci primo numero: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci secondo numero: ");
                    b = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Inserisci l'operazione da eseguire: (-Somma: + \n-Sottrazione: -\n-Moltiplicazione: *\n-Divisione / \n-** Per la potenza \n-sqr per la radice quadrata \n-p per aggiungere numeri per il calcolo");

                    operazione = Console.ReadLine();

                    switch (operazione)
                    {
                        case "+":
                            ris = a + b;
                            Console.WriteLine($"{a} + {b} = {ris}"); 
                            break;
                        case "-":
                            ris = a - b;
                            Console.WriteLine($"{a} - {b} = {ris}");

                            break;
                        case "*":
                            ris = a * b;
                            Console.WriteLine($"{a} * {b} = {ris}");
                            break;

                        case "/":
                            ris = a / b;
                            Console.WriteLine($"{a} / {b} = {ris}");
                            break;
                        case "**":
                            ris = Math.Pow(a,b);
                            Console.WriteLine($"{a} ** {b} = {ris}");
                            break;
                        case "sqr":
                            ris = Math.Sqrt(a);
                            Console.WriteLine($"Radice quadrata di a: {ris}");
                            ris = Math.Sqrt(b);
                            Console.WriteLine($"Radice quadrata di b: {ris}");
                            break;
                        case "p":

                            string? strNumeri = "";

                            int n = 0;

                            Console.WriteLine("Inserisci numero, per fare l'operazione premi e");
                            


                            if(Console.ReadLine()=="e")

                            int[] numeri;


                            break; 


                        default:
                            Console.WriteLine("Errore! Operazione non riconosciuta");

                            break;
                    }


                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Errore! Inserire un numero");
                }
                catch (System.DivideByZeroException)
                {

                    Console.WriteLine("Errore, non è possibile dividere per 0");

                }

                Console.WriteLine("Premi Q per uscire o N per una nuova operazione");
                exit = Console.ReadLine();

                if (exit is not null && exit.ToUpper() == "Q")
                    on = false;
            }
        }
    }

}
