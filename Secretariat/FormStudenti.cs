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
    public partial class FormStudenti : Form
    {


        private int AngajatID;
        private string SelectedFacultate = "";
        private List<string> Facultati;
        public FormStudenti(int angajatId)
        {
            InitializeComponent();

            AngajatID = angajatId;
            Facultati = new List<string>();
            GetFacultate();

            foreach (string facultate in Facultati)
                comboBoxFacultateStudent.Items.Add(facultate);
        }

        private void GetFacultate()
        {

            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT DISTINCT Nume FROM Facultate;", Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string facultate = dataReader.GetValue(0).ToString();

                Facultati.Add(facultate);
            }
            dataReader.Close();
        }

        private void FormStudenti_Load(object sender, EventArgs e)
        {
            GetDataStudentFromSql();
        }

        private void GetDataStudentFromSql(string facultate = "", string nume = "")
        {
            string query = @"SELECT Student.id, CONCAT(Student.Nume, ' ', Student.Prenume) as Student, Student.Telefon, Student.Email,
                            Student.Adresa, Grupa, An_studiu AS An, Facultate.Nume AS Facultate, Domeniu.Nume AS Domeniu
                            FROM Student JOIN Facultate ON Student.FacultateID = Facultate.id
			                JOIN Domeniu ON Student.DomeniuID = Domeniu.id ";


            if (facultate != "")
            {
                query += " WHERE Facultate.Nume LIKE '%" + SelectedFacultate + "%'";
            }
            else if (nume != "")
            {
                query += " WHERE(Student.Nume LIKE '%" + nume + "%' OR Student.Prenume LIKE '%" + nume + "%')";
            }

            query += ";";

            SqlCommand command = new SqlCommand(query, Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dataReader);

            StudentDataGridView.DataSource = dt;
        }

        private void comboBoxFacultateStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeFacultate = comboBoxFacultateStudent.Text;

            foreach (var f in Facultati)
            {
                if (f == numeFacultate)
                {
                    SelectedFacultate = f;
                    break;
                }
            }

            GetDataStudentFromSql(SelectedFacultate);
        }

        private void btnCautaStudent2_Click(object sender, EventArgs e)
        {
            GetDataStudentFromSql("", txtNumeStudent.Text);
        }
    }
}
