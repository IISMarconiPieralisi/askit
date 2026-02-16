using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsRisposta //Lorenzo Lçeardini
    {
        // Attributi
        int _id;
        string _testo;
        int _contatore;

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

        public int Contatore
        {
            get => _contatore;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Il contatore non può essere negativo");
                }
                else
                {
                    _contatore = value;
                }
            }
        }

        // Costruttori
        public ClsRisposta()
        {
        }

        public ClsRisposta(int id, string testo, int contatore)
        {
            Id = id;
            Testo = testo;
            Contatore = contatore;
        }
    }
}

