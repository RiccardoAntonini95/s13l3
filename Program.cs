namespace s13l3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quale esercizio vuoi verificare? <es1,es2,es3> ");
            string esercizioDaVerificare = Console.ReadLine();
            if(esercizioDaVerificare == "es1")
            {
                Console.WriteLine("Vuoi aprire un conto corrente? Digita <si/no> ");
                string ccBankOn = Console.ReadLine();
                if (ccBankOn == "si")
                {
                    Console.WriteLine("Effettua il primo versamento: ");
                    int primoVersamento = int.Parse(Console.ReadLine());
                    ContoCorrente nuovoConto = new ContoCorrente();
                    nuovoConto.Versamento(primoVersamento);
                    Console.Clear();
                    Console.WriteLine($"Hai versato {primoVersamento} euro. Grazie per aver scelto la nostra banca!");
                    Console.WriteLine("Vuoi effettuare altre operazioni? <preleva/versa/saldo> ");
                    string operazioneNuova = Console.ReadLine();
                    if (operazioneNuova == "preleva")
                    {
                        Console.WriteLine("Quanto vuoi prelevare? ");
                        int prelievo = int.Parse(Console.ReadLine());
                        nuovoConto.Prelievo(prelievo);
                        Console.WriteLine($"Hai prelevato {prelievo} euro, il tuo conto ammonta a {nuovoConto.SaldoAttuale} euro");
                    }
                    else if (operazioneNuova == "versa")
                    {
                        Console.WriteLine("Quanto vuoi depositare? ");
                        int versamento = int.Parse(Console.ReadLine());
                        nuovoConto.Versamento(versamento);
                        Console.WriteLine($"Hai depositato {versamento} euro, il tuo conto ammonta a {nuovoConto.SaldoAttuale} euro");
                    }
                    if (operazioneNuova == "saldo")
                    {
                        Console.WriteLine($"Il tuo saldo disponibile è di {nuovoConto.SaldoAttuale} euro");
                    }
                } else { 
                    Console.WriteLine("Hai scelto di non aprire un nuovo conto"); 
                }
            }
            else if(esercizioDaVerificare == "es2")
            {
                Console.WriteLine("Inserire il numero di persone totali --> ");
                int personeArr = int.Parse(Console.ReadLine());
                string[] persone = new string[personeArr];
                for (int i = 0; i < persone.Length; i++)
                {
                    Console.WriteLine($"Inserisci il nome della persona {i} ");
                    persone[i] = Console.ReadLine();
                }
                Console.WriteLine("Digita il nome di una persona da cercare nell'elenco ");
                string personaDaCercare = Console.ReadLine();
                if (persone.Contains($"{personaDaCercare}"))
                {
                    Console.WriteLine($"{personaDaCercare} è presente nell'elenco");
                }
                else
                {
                    Console.WriteLine($"{personaDaCercare} non è presente nell'elenco");
                }
            }
            else if(esercizioDaVerificare == "es3")
            {
                Console.WriteLine("Quanti numeri deve contenere l'array? ");
                int lunghezzaArr = int.Parse(Console.ReadLine());
                int[] numeri = new int[lunghezzaArr];
                int somma = 0;

                for (int i = 0;i < lunghezzaArr;i++)
                {
                    Console.WriteLine("Inserisci un numero ");
                    numeri[i] = int.Parse(Console.ReadLine());
                }

                foreach (var numero in numeri) //somma dei numeri dell'array
                {
                    somma += numero;
                }

                //media aritmetica dei numeri
                double media = (double)somma/ numeri.Length;

                Console.WriteLine($"La somma dei numeri inseriti è {somma}, la media aritmetica è {media}");

            }
            else { 
                Console.WriteLine("Non ci siamo utente, devi fare una scelta tra i 3 esercizi come indicato.");
                Console.WriteLine("  ___ _ __ _ __ ___  _ __ \r\n / _ \\ '__| '__/ _ \\| '__|\r\n|  __/ |  | | | (_) | |   \r\n \\___|_|  |_|  \\___/|_|   ");
            }


        }

        public class ContoCorrente
        {
            //Field
            private int saldoDisponibile = 0;

            //Properties 
            public int SaldoAttuale
            {
                get { return saldoDisponibile; }
                set { saldoDisponibile = value; }
            }

            //Methods
            public int Versamento(int import)
            {
                SaldoAttuale = (SaldoAttuale + import);
                return SaldoAttuale;
            }

            public int Prelievo(int import)
            {
                SaldoAttuale = (SaldoAttuale - import);
                return SaldoAttuale;
            }
        }

    }

}
