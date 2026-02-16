using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace sondaggio
{
    public static class DB
    {
        private static ClsUtente utenteLoggato;
        public static List<ClsAdmin> Admin = new List<ClsAdmin>();
        public static List<ClsIntervistato> Intervistati = new List<ClsIntervistato>();
        public static List<ClsSondaggio> Sondaggi = new List<ClsSondaggio>();
        public static List<ClsCategoria> Categorie = new List<ClsCategoria>();
        public static List<ClsRispondere> Rispondere = new List<ClsRispondere>();

        public static int ContIDsondaggio = 1;
        public static int ContIDrisp = 1;

        private const string FileAdmin = "Admin.json";
        private const string FileIntervistati = "Intervistati.json";
        private const string FileSondaggi = "Sondaggi.json";
        private const string FileCategorie = "Categorie.json";
        private const string FileRispondere = "Rispondere.json";
        private const string FileContIDsondaggio = "ContIDsondaggio.txt";
        private const string FileContIDrisp = "ContIDrisp.txt";

        public static ClsUtente UtenteLoggato { get => utenteLoggato; set => utenteLoggato = value; }

        static DB()
        {
            CaricaUtenti();
            CaricaDati();

            if (Admin.Count == 0 && Intervistati.Count == 0)
            {
                Admin.Add(new ClsAdmin("mango", "MangoDB!", "ERCOLE", "MARX", new DateTime(1923, 12, 12), ClsUtente.eCOMUNE.Ancona, ClsUtente.eSESSO.femmina, "123123123@email.it"));
                Intervistati.Add(new ClsIntervistato("mattia", "MattiaDB!", "Mattia", "DB", new DateTime(1995, 1, 1), ClsUtente.eCOMUNE.Ancona, ClsUtente.eSESSO.maschio, "bdms@email.it"));
                SalvaUtenti();
            }
        }

        public static void CaricaUtenti()
        {
            try
            {
                if (File.Exists(FileAdmin))
                    Admin = JsonConvert.DeserializeObject<List<ClsAdmin>>(File.ReadAllText(FileAdmin)) ?? new List<ClsAdmin>();

                if (File.Exists(FileIntervistati))
                    Intervistati = JsonConvert.DeserializeObject<List<ClsIntervistato>>(File.ReadAllText(FileIntervistati)) ?? new List<ClsIntervistato>();
            }
            catch { }
        }

        public static void SalvaUtenti()
        {
            try
            {
                File.WriteAllText(FileAdmin, JsonConvert.SerializeObject(Admin, Formatting.Indented));
                File.WriteAllText(FileIntervistati, JsonConvert.SerializeObject(Intervistati, Formatting.Indented));
            }
            catch { }
        }

        public static void CaricaDati()
        {
            try
            {
                if (File.Exists(FileSondaggi))
                    Sondaggi = JsonConvert.DeserializeObject<List<ClsSondaggio>>(File.ReadAllText(FileSondaggi)) ?? new List<ClsSondaggio>();

                if (File.Exists(FileCategorie))
                    Categorie = JsonConvert.DeserializeObject<List<ClsCategoria>>(File.ReadAllText(FileCategorie)) ?? new List<ClsCategoria>();

                if (File.Exists(FileRispondere))
                    Rispondere = JsonConvert.DeserializeObject<List<ClsRispondere>>(File.ReadAllText(FileRispondere)) ?? new List<ClsRispondere>();

                if (File.Exists(FileContIDsondaggio))
                    ContIDsondaggio = int.Parse(File.ReadAllText(FileContIDsondaggio));

                if (File.Exists(FileContIDrisp))
                    ContIDrisp = int.Parse(File.ReadAllText(FileContIDrisp));
            }
            catch { }
        }

        public static void SalvaDati()
        {
            try
            {
                File.WriteAllText(FileSondaggi, JsonConvert.SerializeObject(Sondaggi, Formatting.Indented));
                File.WriteAllText(FileCategorie, JsonConvert.SerializeObject(Categorie, Formatting.Indented));
                File.WriteAllText(FileRispondere, JsonConvert.SerializeObject(Rispondere, Formatting.Indented));
                File.WriteAllText(FileContIDsondaggio, ContIDsondaggio.ToString());
                File.WriteAllText(FileContIDrisp, ContIDrisp.ToString());
            }
            catch { }
        }
    }
}