using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat
{
    public partial class FormFacultati : Form
    {

        private int AngajatID;
        private string SelectedOras = "";
        private List<string> Orase;
        public FormFacultati(int angajatId)
        {
            AngajatID = angajatId;
            Orase = new List<string>();
            InitializeComponent();
            GetOrase();

            foreach (string nume in Orase)
                comboBoxOraseFacultate.Items.Add(nume);
        }
        private void GetOrase()
        {
            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT DISTINCT Oras FROM Facultate;" , Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string nume = dataReader.GetValue(0).ToString();

                Orase.Add(nume);
            }
            dataReader.Close();
        }
        private void FormFacultati_Load(object sender, EventArgs e)
        {
            GetDataFacultatiFromSql();
        }


        private void GetDataFacultatiFromSql(string oras = "", string nume = "")
        {
            string query = @"SELECT Facultate.Nume AS Facultate, Domeniu.Nume AS Domeniu,
                                             Facultate.Adresa, Facultate.Oras, Domeniu.Nr_ani AS Ani,
                                             Domeniu.Nr_locuri AS Locuri, TipAdmitere.Nume AS Admitere, Program.Nume AS Program
                                             FROM Domeniu JOIN Facultate ON Facultate.id = domeniu.FacultateID
                                             JOIN TipAdmitere ON Domeniu.TipAdmitereID = TipAdmitere.id
                                             JOIN Program ON Domeniu.ProgramID = Program.id ";

            if (oras != "")
            {
                query += " AND Oras LIKE '%" + SelectedOras + "%'";
            }
            else if (nume != "")
            {
                query += " AND Facultate.Nume LIKE '%" + nume + "%'";
            }

            query += ";";

            SqlCommand cmd = new SqlCommand(query, Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dataReader);

            FacultateDataGridView.DataSource = dt;
        }

        private void comboBoxOraseFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {

            string numeOras = comboBoxOraseFacultate.Text;

            foreach (var o in Orase)
            {
                if (o == numeOras)
                {
                    SelectedOras = o;
                    break;
                }
            }
            
            GetDataFacultatiFromSql(SelectedOras);
        }

        private void btnCautaFacultateNume_Click(object sender, EventArgs e)
        {

            GetDataFacultatiFromSql("", txtNumeFacultate.Text);
        }
    }
}
