using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KerstDinerFamilieJanssen
{
    public class Database
    {
        string connStr = "server=192.168.178.67;user=richard;database=kerstdb;port=3306;password=rgjj4kerst;";
        MySqlConnection myConnection;
        Gerecht gerecht;
        //80.100.207.50:3306
        private string Query;
        
        //Alle data inserten in de database
        public void InsertData(int id, string naam, string bereidvoor, string soorteten)
        {
            try
            {
                Query = "INSERT INTO Gerecht (ID, Naam, BereidVoor, SoortEten) " + "Values (" + id + ", '" + naam + "', '" + bereidvoor + "', '" + soorteten + "')";
                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        //Alle gerechten ophalen
        public List<Gerecht> GetGerechten()
        {
            List<Gerecht> gerechten = new List<Gerecht>();
            Query = "SELECT * FROM Gerecht";

            gerechten.Clear();

            try
            {
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);
                myReader = myCommand.ExecuteReader();
                using (myReader)
                {
                    while (myReader.Read())
                    {
                        gerecht = new Gerecht(myReader["Naam"].ToString(), myReader["BereidVoor"].ToString(), myReader["SoortEten"].ToString());
                        gerechten.Add(gerecht);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }

            return gerechten;
        }

        //Haal het hoogste ID nummer op
        public int GetMaxID()
        {
            int result = 0;
            Query = "SELECT MAX(ID) AS ID FROM Gerecht";

            try
            {
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);
                myReader = myCommand.ExecuteReader();
                using (myReader)
                {
                    while (myReader.Read())
                    {
                        result = Convert.ToInt32(myReader["ID"]);
                    }
                }   
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return result;
        }

        //Verwijder een gerecht
        public void VerwijderGerecht(string naam, string bereidvoor, string soorteten)
        {
            Query = "DELETE FROM Gerecht WHERE Naam = " + "'" + naam + "'" + " AND BereidVoor = " + "'" + bereidvoor + "'" + " AND SoortEten = " + "'" + soorteten + "'";

            try
            {
                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void PasGerechtAan(string naam, string bereidvoor, string soorteten, string nieuwnaam, string nieuwbereidvoor, string nieuwsoorteten)
        {
            Query = "UPDATE Gerecht SET Naam = " + "'" + nieuwnaam + "'" + ", BereidVoor = " + "'" + nieuwbereidvoor + "'" + ", SoortEten = " + "'" + nieuwsoorteten + "'" + " WHERE Naam = " + "'" + naam + "'" + " AND BereidVoor = " + "'" + bereidvoor + "'" + " AND SoortEten = " + "'" + soorteten + "'";

            try
            {
                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ConnectToDB()
        {
            try
            {
                myConnection = new MySqlConnection();
                myConnection.ConnectionString = connStr;
                myConnection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void DisconnectFromDB()
        {
            try
            {
                myConnection.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
