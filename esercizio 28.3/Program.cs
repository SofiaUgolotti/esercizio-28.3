using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_28._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgenziaImmobiliare agenzia = new AgenziaImmobiliare();

            // immobili di esempio
            agenzia.AggiungiImmobile(new Box { Codice = "B001", Indirizzo = "Via Roma 1", CAP = "00100", Città = "Roma", Superficie = 20, NumeroPostiAuto = 2 });
            agenzia.AggiungiImmobile(new Appartamento { Codice = "A002", Indirizzo = "Via Milano 2", CAP = "00200", Città = "Milano", Superficie = 80, NumeroVani = 3, NumeroBagni = 2 });

            Console.WriteLine("inserisci la chiave di ricerca: ");
            string chiaveRicerca = Console.ReadLine();
            agenzia.RicercaPerChiave(chiaveRicerca);
            Console.ReadLine();
        }
    }
    }

