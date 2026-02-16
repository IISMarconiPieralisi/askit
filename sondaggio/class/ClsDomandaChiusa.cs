using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsDomandaChiusa: ClsDomanda // Michael Luminari
    {
        public enum eTIPOLOGIA
        {
            VF,     // Vero/Falso
            S,      // Singola
            M       // Multipla
        }

        // Attributi
        eTIPOLOGIA _tipologia;

        // Proprietà
        public eTIPOLOGIA Tipologia
        {
            get => _tipologia;
            set => _tipologia = value;
        }

        // Costruttori
        public ClsDomandaChiusa()
        {
        }

        public ClsDomandaChiusa(eTIPOLOGIA tipologia)
        {
            Tipologia = tipologia;
        }

        public ClsDomandaChiusa(int id, string testo, int ordine, eTIPOLOGIA tipologia, List<ClsRisposta> risposte) : base(id, testo, ordine, risposte)
        {
            Tipologia = tipologia;
        }
    }
}
