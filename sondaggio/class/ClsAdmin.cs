using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsAdmin:ClsUtente //Fioretti Irene
    {
        ClsAdmin()
        {

        }

        public ClsAdmin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public ClsAdmin(string username, string password, string nome, string cognome, DateTime dataDiNascita, eCOMUNE comuneDiNascita, eSESSO sesso, string email)
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
        public List<ClsSondaggio> Cerca(int scelta,int id,bool stato,bool tipo,string nome,DateTime data,List<ClsSondaggio> sondaggi)
        {
            List<ClsSondaggio> sondaggiFiltrati = new List<ClsSondaggio>();

            switch (scelta)
            {
                case 0:
                    sondaggiFiltrati = sondaggi.FindAll(s => s.ID == id);
                    break;

                case 1:
                    sondaggiFiltrati = sondaggi.FindAll(s => s.Aperto == stato);
                    break;

                case 2:
                    sondaggiFiltrati = sondaggi.FindAll(s => s.Anonimo == tipo);
                    break;

                case 3:
                    sondaggiFiltrati = sondaggi.FindAll(s =>
                        s.Nome.ToLower().Contains(nome.ToLower()));
                    break;

                case 4:
                    sondaggiFiltrati = sondaggi.FindAll(s =>
                        s.DataCreazione.Date == data.Date);
                    break;
            }

            return sondaggiFiltrati;
        }
    }
}
