using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KerstDinerFamilieJanssen
{
    public partial class Form1 : Form
    {
        Database db = new Database();

        List<Gerecht> gerechten = new List<Gerecht>();

        string naam;
        string bereidVoor;
        string soortEten;
        string geselecteerdGerecht;
        string[] stringArray;
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateListboxes();
        }

        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            db.ConnectToDB();
            //Genereer ID
            ID = db.GetMaxID() + 1;
            
            //Als iets niet is ingevuld
            if(tbVoornaam.Text == "")
            {
                MessageBox.Show("Voornaam is niet ingevuld");
            }
            else if(tbAchternaam.Text == "")
            {
                MessageBox.Show("Achternaam is niet ingevuld");
            }
            else if(tbBereidVoor.Text == "")
            {
                MessageBox.Show("Bereid voor is niet ingevuld");
            }
            else if(cbSoortEten.Text == "")
            {
                MessageBox.Show("Soort eten is niet ingevuld");
            }
            //Anders data in database toevoegen
            else
            {
                naam = Convert.ToString(tbVoornaam.Text) + " " + Convert.ToString(tbAchternaam.Text);
                bereidVoor = Convert.ToString(tbBereidVoor.Text);
                soortEten = Convert.ToString(cbSoortEten.Text);
                db.InsertData(ID, naam, bereidVoor, soortEten);

                UpdateListboxes();
            }

            db.DisconnectFromDB();
        }

        public void UpdateListboxes()
        {
            lbWatWordtVoorbereid.Items.Clear();
            db.ConnectToDB();

            gerechten = db.GetGerechten();

            //Alle gerechten worden in de listbox gezet
            foreach (Gerecht g in gerechten)
            {
                lbWatWordtVoorbereid.Items.Add(g);
            }

            db.DisconnectFromDB();
        }

        //Verwijder het geselecteerde gerecht
        private void btnVerwijderGerecht_Click(object sender, EventArgs e)
        {
            geselecteerdGerecht = Convert.ToString(lbWatWordtVoorbereid.SelectedItem);
            stringArray = new string[3];
            stringArray = geselecteerdGerecht.Split(' ');

            naam = stringArray[0];
            bereidVoor = stringArray[1];
            soortEten = stringArray[2];

            db.VerwijderGerecht(naam, bereidVoor, soortEten);
            UpdateListboxes();
        }

        //Pas het gerecht aan
        private void btnPasGerechtAan_Click(object sender, EventArgs e)
        {
            geselecteerdGerecht = Convert.ToString(lbWatWordtVoorbereid.SelectedItem);
            stringArray = new string[3];
            stringArray = geselecteerdGerecht.Split(' ');

            //Originele data
            naam = stringArray[0];
            bereidVoor = stringArray[1];
            soortEten = stringArray[2];

            //Voor aan te passen
            tbNieuwNaam.Text = stringArray[0];
            tbNieuwBereidVoor.Text = stringArray[1];
            tbNieuwSoortEten.Text = stringArray[2];
        }

        //Pas het gerecht daadwerkelijk aan
        private void btnPasAan_Click(object sender, EventArgs e)
        {
            db.PasGerechtAan(naam, bereidVoor, soortEten, tbNieuwNaam.Text, tbNieuwBereidVoor.Text, tbNieuwSoortEten.Text);
            UpdateListboxes();
        }
    }
}
