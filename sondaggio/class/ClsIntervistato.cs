using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsIntervistato:ClsUtente //Contini Lorenzo
    {
        public ClsIntervistato()
        {

        }

        public ClsIntervistato(string username, string password, string nome, string cognome, DateTime dataDiNascita, eCOMUNE comuneDiNascita, eSESSO sesso, string email)
        {
            Username = username;
            Password = password;
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            ComuneDiNascita = comuneDiNascita;
            Sesso = sesso;
            Email = email;
        }
    }
}
