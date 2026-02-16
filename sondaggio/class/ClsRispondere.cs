using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsRispondere //Cristian Latini
    {
        string _risposta;
        string _usernameIntervistato;
        int _idSondaggio;
        public string Risposta
        {
            get => _risposta;
            set => _risposta = value;
        }
        public int IDSondaggio { get => _idSondaggio; set => _idSondaggio = value; }
        public string UsernameIntervistato { get => _usernameIntervistato; set => _usernameIntervistato = value; }
    }
}
