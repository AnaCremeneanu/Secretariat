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

//trebuie sa adaug userID-ul profesorului

namespace Secretariat
{
    public partial class FormExamene : Form
    {
        private int AngajatId;
        private int DomeniuAni;
        private int SelectedCursId;
        private Dictionary<int, string> Cursuri;
        List<string> Examene;

        public FormExamene(int angajatId)
        {
            AngajatId = angajatId;
            Cursuri = new Dictionary<int, string>();
            Examene = new List<string>();

            InitializeComponent();

            GetDomainYears();
            if (comboBoxAnExamen.Items.Count > 0)
                comboBoxAnExamen.SelectedIndex = 0;

            GetCursuriForAngajat();

            GetExamenList();
        }

        private void FormExamene_Load(object sender, EventArgs e)
        {
            GetDataExameneFromSQL();
        }

        private void GetDomainYears()
        {
            //facem query-ul de SQL
            string query = @"SELECT Domeniu.Nr_ani 
                                FROM Angajat 
                                JOIN Domeniu ON Angajat.DomeniuID = Domeniu.id
                                where Angajat.id = " + AngajatId + ";";

            SqlCommand cmd = new SqlCommand(query, Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
                DomeniuAni = int.Parse(dataReader.GetValue(0).ToString());
            else
                DomeniuAni = 0;

            dataReader.Close();

            for (int i = 1; i <= DomeniuAni; i++)
                comboBoxAnExamen.Items.Add(i);
        }

        private void GetCursuriForAngajat()
        {
            Cursuri.Clear();
            //facem query-ul de SQL
            string query = @"SELECT id, Nume from Curs WHERE AngajatID =" + AngajatId + " AND An = " + comboBoxAnExamen.Text + ";";

            SqlCommand cmd = new SqlCommand(query, Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int  id = int.Parse(dataReader.GetValue(0).ToString());
                string nume = dataReader.GetValue(1).ToString();

                Cursuri[id] = nume;
            }
            
            dataReader.Close();

            comboBoxCursExamen.Items.Clear();
            foreach (KeyValuePair<int, string> c in Cursuri)
                comboBoxCursExamen.Items.Add(c.Value);
        }

        private void GetExamenList()
        {
            Examene.Clear();

            //facem query-ul de SQL
            string query = @"SELECT DISTINCT Nume from Examen WHERE CursID = " + SelectedCursId + ";";

            SqlCommand cmd = new SqlCommand(query, Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string nume = dataReader.GetValue(0).ToString();

                Examene.Add(nume);
            }

            comboBoxNrExamen.Items.Clear();
            foreach (string examen in Examene)
                comboBoxNrExamen.Items.Add(examen);

            dataReader.Close();
        }

        private void GetDataExameneFromSQL()
        {
            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT CONCAT (Student.Nume , ' ', Student.Prenume) AS Student, Curs.Nume, Examen.Nume, Examen.Nota, Curs.Credite
                                             FROM Examen
                                             JOIN Student ON Examen.StudentID = Student.id
                                             JOIN Curs ON Examen.CursID = Curs.id AND Curs.AngajatID = " + AngajatId + ";"
                                                , Program.databaseConnection);
            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dataReader);
            
            ExameneDataGridView.DataSource = dt;
            dataReader.Close();
        }

        private void comboBoxAnExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCursuriForAngajat();
        }

        private void comboBoxCursExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeCurs  = comboBoxCursExamen.Text;

            foreach (KeyValuePair<int, string> c in Cursuri)
            {
                if (c.Value == numeCurs)
                {
                    SelectedCursId = c.Key;
                    break;
                }
            }

            GetExamenList();
        }

        private void btnCautaExamen_Click(object sender, EventArgs e)
        {
            GetDataExameneFromSQL();
        }

        private void btnRefreshExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Momentan optiunea de modificare/introducere a notelor nu este posibila!", "Eroare", MessageBoxButtons.OK);
        }
    }
}
