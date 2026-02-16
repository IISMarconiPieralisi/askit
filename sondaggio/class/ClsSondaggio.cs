using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsSondaggio
    {
        int _ID;
        bool _aperto;
        bool _anonimo;
        string _nome;
        DateTime _dataCreazione;
        List<ClsDomanda> _domandeAperte = new List<ClsDomanda>();
        List<ClsDomanda> _domande = new List<ClsDomanda>();
        List<ClsDomandaChiusa> _domandeChiuse = new List<ClsDomandaChiusa>();
        int _numeroDomande;
        ClsCategoria _categoria;

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        public bool Aperto
        {
            get => _aperto;
            set => _aperto = value;
        }

        public bool Anonimo
        {
            get => _anonimo;
            set => _anonimo = value;
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Il nome non può essere vuoto");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public DateTime DataCreazione
        {
            get => _dataCreazione;
            set
            {
                if (value <= DateTime.Now)
                {
                    _dataCreazione = value;
                }
                else
                {
                    throw new Exception("La data di creazione non può essere nel futuro");
                }
            }
        }

        public int NumeroDomande
        {
            get => _domandeAperte.Count + _domandeChiuse.Count;
            set => _numeroDomande = value;
        }

        public List<ClsDomandaChiusa> DomandaChiusa
        {
            get => _domandeChiuse;
            set => _domandeChiuse = value;
        }

        public List<ClsDomanda> DomandaAperta
        {
            get => _domandeAperte;
            set => _domandeAperte = value;
        }

        public List<ClsDomanda> Domande
        {
            get => TutteDomandeOrdinate();
            set => _domande = value;
        }
        public ClsCategoria Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        public ClsSondaggio()
        {
        }

        public ClsSondaggio(int id, bool aperto, bool anonimo, string nome, DateTime dataCreazione)
        {
            ID = id;
            Aperto = aperto;
            Anonimo = anonimo;
            Nome = nome;
            DataCreazione = dataCreazione;
        }

        public List<ClsDomanda> TutteDomandeOrdinate()
        {
            List<ClsDomanda> TutteDomande = new List<ClsDomanda>();
            TutteDomande.AddRange(_domandeAperte);
            TutteDomande.AddRange(_domandeChiuse);
            return TutteDomande.OrderBy(d => d.Ordine).ToList();
        }
    }
}
