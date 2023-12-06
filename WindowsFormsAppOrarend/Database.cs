using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsAppOrarend;
using static WindowsFormsAppOrarend.Program;

namespace WindowsFormsAppOrarend
{
    internal class Database
    {
        //Connection, Command
        MySqlConnection connection;
        MySqlCommand command;

        public List<Orarend> OrarendLista { get; private set; }

        //
        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();

            OrarendLista = new List<Orarend>();

            try
            {
                //Kapcsolat nyitása
                kapcsolatNyitas();

                //Kapcsolat zárása
                kapcsolatZarasa();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        //Kapcsolat zárás
        public void kapcsolatZarasa()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        //Kapcsolat nyitása
        public void kapcsolatNyitas()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        //Bejelentkezés
        public int Bejelentkezes(string nev, string jelszo)
        {
            int userid = -1;
            kapcsolatNyitas();
            command.CommandText = "SELECT tanarid, tanarnev, jelszo FROM tanarok WHERE tanarnev=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                if (taroltJelszo.Equals(jelszo))
                {
                    userid = reader.GetInt32("tanarid");
                }
            }
            Program.formLogin.Hide();
            kapcsolatZarasa();
            return userid;
        }

        //Órarend napok betöltése -- listBox
        public void napokBetoltese()
        {
            kapcsolatNyitas();
            OrarendLista.Clear(); // Törölje a listát, mielőtt újra feltöltené

            command.CommandText = "SELECT * FROM orak GROUP BY hetnapja";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    OrarendLista.Add(new Orarend(dr.GetInt32("oraid"), dr.GetString("tantargy"), dr.GetInt32("sorszam"), (HetNapja)Enum.Parse(typeof(HetNapja), dr.GetString("hetnapja"))));
                }
            }
            kapcsolatZarasa();
        }
    }
}
