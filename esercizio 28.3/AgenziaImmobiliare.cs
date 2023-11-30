using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_28._3
{
    internal class AgenziaImmobiliare
    {
        private List<immobile> immobili;
        public AgenziaImmobiliare()
        {
            immobili = new List<immobile>();
        }
        public void AggiungiImmobile(immobile immobile)
        {
            immobili.Add(immobile);
        }
        public void RicercaPerChiave (string chiave)
        {
            foreach (var immobile in immobili)
            {
                if (ContieneChiave(immobile,chiave))
                {
                    VisualizzaScheda(immobile);
                }
            }
        }
        private bool ContieneChiave (immobile immobile, string chiave)
        {
            return immobile.Codice.Contains(chiave)||immobile.Indirizzo.Contains(chiave)||immobile.CAP.Contains(chiave)||immobile.Città.Contains(chiave)||immobile.Superficie.ToString().Contains(chiave);
        }
        private void VisualizzaScheda(immobile immobile)
        {
            Console.WriteLine($"Codice: {immobile.Codice}");
            Console.WriteLine($"Indirizzo: {immobile.Indirizzo}");
            Console.WriteLine($"CAP: {immobile.CAP}");
            Console.WriteLine($"Città: {immobile.Città}");
            Console.WriteLine($"Superficie: {immobile.Superficie} mq");
            Console.WriteLine();
        }
    }
}
