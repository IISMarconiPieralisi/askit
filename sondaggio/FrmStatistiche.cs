using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Newtonsoft.Json;

namespace sondaggio
{
    public partial class FrmStatistiche : Form
    {
        public FrmStatistiche()
        {
            InitializeComponent();
        }

        private void FrmStatistiche_Load(object sender, EventArgs e)
        {
            CaricaSondaggi();
        }

        private void CaricaSondaggi()
        {
            List<ClsSondaggio> sondaggi = DB.Sondaggi;
            cbSondaggi.DataSource = sondaggi;
            cbSondaggi.DisplayMember = "Nome";
            cbSondaggi.ValueMember = "ID";
        }

        private void cbSondaggi_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaListaDomande();
        }

        private void AggiornaListaDomande()
        {
            ClsSondaggio sondaggioSelezionato = (ClsSondaggio)cbSondaggi.SelectedItem;

            if (sondaggioSelezionato != null)
            {
                List<ClsDomanda> tutteLeDomande = sondaggioSelezionato.TutteDomandeOrdinate();
                lbDomande.DataSource = tutteLeDomande;
                lbDomande.DisplayMember = "Testo";
            }
        }

        private void lbDomande_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsDomanda domandaSelezionata = (ClsDomanda)lbDomande.SelectedItem;
            if (domandaSelezionata != null)
                MostraStatistiche(domandaSelezionata);
        }

        private void MostraStatistiche(ClsDomanda domandaSelezionata)
        {
            if (domandaSelezionata is ClsDomandaChiusa chiusa)
            {
                if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                {
                    CaricaRisposteVF(domandaSelezionata);
                    MostraStatisticheVF(domandaSelezionata);
                }
                else
                    MostraStatisticheChiuse(domandaSelezionata);
            }
            else
                MostraStatisticheAperte(domandaSelezionata);
        }

        private void CaricaRisposteVF(ClsDomanda domandaSelezionata)
        {
            ClsSondaggio sondaggioSelezionato = (ClsSondaggio)cbSondaggi.SelectedItem;
            if (sondaggioSelezionato == null) return;

            string nomeFile = $"Risposte_S{sondaggioSelezionato.ID}_D{domandaSelezionata.Id}.json";

            if (File.Exists(nomeFile))
            {
                try
                {
                    string json = File.ReadAllText(nomeFile);
                    domandaSelezionata.Risposte = JsonConvert.DeserializeObject<List<ClsRisposta>>(json);

                    if (domandaSelezionata.Risposte == null || domandaSelezionata.Risposte.Count == 0)
                        InizializzaRisposteVF(domandaSelezionata);
                }
                catch
                {
                    InizializzaRisposteVF(domandaSelezionata);
                }
            }
            else
                InizializzaRisposteVF(domandaSelezionata);
        }

        private void InizializzaRisposteVF(ClsDomanda domanda)
        {
            domanda.Risposte = new List<ClsRisposta>();
            domanda.Risposte.Add(new ClsRisposta(1, "Vero", 0));
            domanda.Risposte.Add(new ClsRisposta(2, "Falso", 0));
        }

        private void MostraStatisticheChiuse(ClsDomanda domandaSelezionata)
        {
            ConfiguraGrafico(domandaSelezionata.Testo, "Risposte");

            if (domandaSelezionata.Risposte != null && domandaSelezionata.Risposte.Count > 0)
            {
                AggiungiRisposteAlGrafico(domandaSelezionata.Risposte);
                chtRisposte.ChartAreas[0].AxisX.Interval = 1;
            }
            else
                MessageBox.Show("Nessuna statistica disponibile per questa domanda chiusa.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostraStatisticheVF(ClsDomanda domandaSelezionata)
        {
            ConfiguraGrafico(domandaSelezionata.Testo, "Risposte");

            int contatoreVero = OttieniContatoreVF(domandaSelezionata, "Vero");
            int contatoreFalso = OttieniContatoreVF(domandaSelezionata, "Falso");

            AggiungiPuntoAlGrafico("Vero", contatoreVero);
            AggiungiPuntoAlGrafico("Falso", contatoreFalso);

            chtRisposte.ChartAreas[0].AxisX.Interval = 1;
        }

        private int OttieniContatoreVF(ClsDomanda domanda, string testoRisposta)
        {
            int contatore=0;
            if (domanda.Risposte != null && domanda.Risposte.Count > 0)
            {
                for (int i = 0; i < domanda.Risposte.Count; i++)
                {
                    if (domanda.Risposte[i].Testo == testoRisposta)
                        contatore = domanda.Risposte[i].Contatore;
                }
            }
            return contatore;
        }

        private void MostraStatisticheAperte(ClsDomanda domandaSelezionata)
        {
            MostraRisposteAperteStandardizzate(domandaSelezionata);
        }

        private void MostraRisposteAperteStandardizzate(ClsDomanda domandaSelezionata)
        {
            ClsSondaggio sondaggioSelezionato = (ClsSondaggio)cbSondaggi.SelectedItem;
            if (sondaggioSelezionato != null)
            {
                string nomeFile = $"RisposteAperte_S{sondaggioSelezionato.ID}_D{domandaSelezionata.Id}.txt";

                if (!File.Exists(nomeFile))
                    MessageBox.Show("Nessuna risposta aperta disponibile per questa domanda.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        List<string> risposteOriginali = LeggiRisposteAperte(nomeFile);

                        List<string> standardTrovati = new List<string>();
                        List<int> conteggiStandard = new List<int>();
                        int nonClassificate = 0;

                        for (int i = 0; i < risposteOriginali.Count; i++)
                        {
                            string risposta = risposteOriginali[i];
                            string rispostaStandard = TrovaRispostaStandard(risposta, domandaSelezionata);

                            if (rispostaStandard != "-" && rispostaStandard != risposta)
                            {
                                int indiceStandard = -1;
                                int j = 0;

                                while (j < standardTrovati.Count && indiceStandard == -1)
                                {
                                    if (standardTrovati[j] == rispostaStandard)
                                        indiceStandard = j;
                                    j++;
                                }

                                if (indiceStandard >= 0)
                                    conteggiStandard[indiceStandard]++;
                                else
                                {
                                    standardTrovati.Add(rispostaStandard);
                                    conteggiStandard.Add(1);
                                }
                            }
                            else
                                nonClassificate++;
                        }

                        ConfiguraGrafico(domandaSelezionata.Testo, "RisposteStandard");

                        for (int i = 0; i < standardTrovati.Count; i++)
                            AggiungiPuntoAlGrafico(standardTrovati[i], conteggiStandard[i]);

                        if (nonClassificate > 0)
                            AggiungiPuntoAlGrafico("Non classificate", nonClassificate);

                        chtRisposte.ChartAreas[0].AxisX.Interval = 1;

                        if (standardTrovati.Count == 0 && nonClassificate == 0)
                            MessageBox.Show("Nessuna risposta standardizzata trovata per questa domanda aperta.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore nel caricamento delle risposte aperte: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private List<string> LeggiRisposteAperte(string nomeFile)
        {
            List<string> risposteOriginali = new List<string>();
            string[] righe = File.ReadAllLines(nomeFile);

            for (int i = 0; i < righe.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(righe[i]))
                {
                    int indiceChiusura = righe[i].IndexOf(']');
                    if (indiceChiusura >= 0 && indiceChiusura < righe[i].Length - 1)
                    {
                        string testoRisposta = righe[i].Substring(indiceChiusura + 1).Trim();
                        risposteOriginali.Add(testoRisposta);
                    }
                }
            }

            return risposteOriginali;
        }

        private string TrovaRispostaStandard(string testoRisposta, ClsDomanda domanda)
        {
            string risultato = "-";

            if (domanda.RisposteStandard != null && domanda.RisposteStandard.Count > 0)
            {
                const string SEPARATORE = "|||";
                int i = 0;

                while (i < domanda.RisposteStandard.Count && risultato == "-")
                {
                    string entry = domanda.RisposteStandard[i];

                    if (entry.Contains(SEPARATORE))
                    {
                        int separatorePos = entry.IndexOf(SEPARATORE);
                        if (separatorePos > 0)
                        {
                            string rispostaOriginale = entry.Substring(0, separatorePos);
                            string rispostaStandard = entry.Substring(separatorePos + SEPARATORE.Length);

                            if (rispostaOriginale == testoRisposta)
                                risultato = rispostaStandard;
                        }
                    }

                    i++;
                }
            }

            return risultato;
        }

        private void ConfiguraGrafico(string titolo, string nomeSerie)
        {
            chtRisposte.Titles.Clear();
            chtRisposte.Titles.Add(titolo);
            chtRisposte.Series.Clear();
            chtRisposte.Series.Add(nomeSerie);
            chtRisposte.Series[0].ChartType = SeriesChartType.Column;
            chtRisposte.Series[0].IsValueShownAsLabel = true;
            chtRisposte.Series[0].IsVisibleInLegend = false;
            chtRisposte.Legends[0].Enabled = false;
        }

        private void AggiungiRisposteAlGrafico(List<ClsRisposta> risposte)
        {
            for (int i = 0; i < risposte.Count; i++)
                AggiungiPuntoAlGrafico(risposte[i].Testo, risposte[i].Contatore);
        }

        private void AggiungiPuntoAlGrafico(string etichetta, int valore)
        {
            DataPoint p = new DataPoint();
            p.SetValueXY(etichetta, valore);
            p.Color = OttieniColore(valore);
            chtRisposte.Series[0].Points.Add(p);
        }

        private Color OttieniColore(int valore)
        {
            Color color;
            if (valore <= 3)
                color = Color.LightCoral;
            else if (valore <= 5)
                color = Color.MediumPurple;
            else
                color = Color.DodgerBlue;
            return color;
        }

        private void btnTornaIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStatistiche_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }
    }
}