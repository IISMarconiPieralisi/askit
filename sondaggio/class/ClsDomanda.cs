using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsDomanda //Dellabella Mattia
    {
        // Attributi 
        int _id;
        string _testo;
        int _ordine;
        List<ClsRisposta> _risposte = new List<ClsRisposta>();
        List<string> _risposteStandard = new List<string>();

        // Proprietà
        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ID non può essere negativo");
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string Testo
        {
            get => _testo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Il testo non può essere vuoto");
                }
                else
                {
                    _testo = value;
                }
            }
        }

        public int Ordine
        {
            get => _ordine;
            set
            {
                if (value < 0)
                {
                    throw new Exception("L'ordine non può essere negativo");
                }
                else
                {
                    _ordine = value;
                }
            }
        }

        public List<ClsRisposta> Risposte
        {
            get => _risposte;
            set => _risposte = value;
        }

        public List<string> RisposteStandard
        {
            get => _risposteStandard;
            set => _risposteStandard = value;
        }

        // Costruttori 
        public ClsDomanda()
        {
            _risposteStandard = new List<string>();
        }

        public ClsDomanda(int id, string testo, int ordine, List<ClsRisposta> risposte)
        {
            Id = id;
            Testo = testo;
            Ordine = ordine;
            Risposte = risposte;
            _risposteStandard = new List<string>();
        }
    }
}