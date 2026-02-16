using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsUtente //Amir Ghouzlani
    {
        public enum eSESSO
        {
            maschio,
            femmina
        }

        public enum eCOMUNE
        {
            Ancona,
            Jesi,
            Roma,
            Milano,
            Napoli,
            Torino,
            Palermo,
            Genova,
            Bologna,
            Firenze,
            Bari,
            Catania
        }

        // Attributi
        protected string _username;
        protected string _password;
        protected string _nome;
        protected string _cognome;
        protected DateTime _dataDiNascita;
        protected eCOMUNE _comuneDiNascita;
        protected eSESSO _sesso;
        protected string _email;

        // Proprietà
        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Username non può essere vuoto");
                _username = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Password non può essere vuota");
                _password = value;
            }
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nome non può essere vuoto");
                _nome = value;
            }
        }

        public string Cognome
        {
            get => _cognome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Cognome non può essere vuoto");
                _cognome = value;
            }
        }

        public DateTime DataDiNascita
        {
            get => _dataDiNascita;
            set => _dataDiNascita = value;
        }

        public eCOMUNE ComuneDiNascita
        {
            get => _comuneDiNascita;
            set => _comuneDiNascita = value;
        }

        public eSESSO Sesso
        {
            get => _sesso;
            set => _sesso = value;
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Email non può essere vuota");
                _email = value;
            }
        }

        // Costruttori
        public ClsUtente()
        {
        }

        public ClsUtente(string username, string password, string nome, string cognome, DateTime dataDiNascita, eCOMUNE comuneDiNascita, eSESSO sesso, string email)
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
