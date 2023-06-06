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
    public partial class FormCadreDidactice : Form
    {
        private int AngajatID;
        private int FacultateID;
        private int SelectedDomeniuID = -1;
        private Dictionary<int, string> Domenii;

        public FormCadreDidactice(int angajatId)
        {
            AngajatID = angajatId;
            Domenii = new Dictionary<int, string>();
            InitializeComponent();
            GetFacultateID();
            GetDomains();

            foreach (string nume in Domenii.Values)
                comboBoxDomeniuCadreDidactice.Items.Add(nume);
        }

        private void FormCadreDidactice_Load(object sender, EventArgs e)
        {
            GetDataProfesoriFromSql();
        }

        private void GetFacultateID()
        {
            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT FacultateID FROM Angajat WHERE id  = " + AngajatID + ";", Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                // salvam id-ul ca string
                string t = dataReader.GetValue(0).ToString();
                FacultateID = int.Parse(t);
            }
            dataReader.Close();
        }

        private void GetDomains()
        {
            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT id, Nume FROM Domeniu WHERE FacultateID = " + FacultateID + ";", Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                // salvam id-ul ca string
                string id = dataReader.GetValue(0).ToString();
                string nume = dataReader.GetValue(1).ToString();

                int nId = int.Parse(id);

                Domenii[nId] = nume;
            }
            dataReader.Close();
        }

        //trebuie sa vada cadrele didactice din facultatea lui
        private void GetDataProfesoriFromSql(int domeniu = -1, string nume = "")
        {
            //facem query-ul de SQL
            string query = @"SELECT Angajat.id, CONCAT(Angajat.Nume, ' ', Angajat.Prenume) as Nume, Angajat.Data_nasterii, 
                             Angajat.CNP,Angajat.Telefon, Angajat.Email, Domeniu.Nume, Facultate.Nume
                             FROM Angajat
                             JOIN Facultate ON Angajat.FacultateID = Facultate.id
                             JOIN Domeniu ON Angajat.DomeniuID = Domeniu.id
                             WHERE Angajat.FacultateID = " + FacultateID;

            if (domeniu != -1)
            {
                query += " AND DomeniuID = " + SelectedDomeniuID;
            }
            else if (nume != "")
            {
                query += " AND(Angajat.Nume LIKE '%" + nume + "%' OR Angajat.Prenume LIKE '%" + nume + "%')";
            }

            query += ";";

            SqlCommand cmd = new SqlCommand(query , Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dataReader);

            ProfesorDataGridView.DataSource = dt;
        }

        private void comboBoxDomeniuCadreDidactice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeDomeniu = comboBoxDomeniuCadreDidactice.Text;

            foreach (KeyValuePair<int,string> d in Domenii)
            {
                if (d.Value == numeDomeniu)
                {
                    SelectedDomeniuID = d.Key;
                    break;
                }
            }

            GetDataProfesoriFromSql(SelectedDomeniuID);
        }

        private void btnCautaNumeProfesor_Click(object sender, EventArgs e)
        {
            GetDataProfesoriFromSql(-1, txtNumeProfesor.Text);
        }
    }
}