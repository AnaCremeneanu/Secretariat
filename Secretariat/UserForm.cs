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
    public partial class UserForm : Form
    {
        private int RolId;
        private int UserID;
        private int AngajatId;

        List<int> Permisiuni = null;

        public UserForm(int id, int rol)
        {
            InitializeComponent();
            UserID = id;
            RolId = rol;

            panelResurseUmane.Visible = false;
            panelStudenti.Visible = false;
            panelCatalog.Visible = false;
            panelDateFinanciare.Visible = false;

            GetUserAccountId();
            GetUserPermissions();
            HideDeniedPermissionButtons();
        }

        private void GetUserPermissions()
        {
            Permisiuni = new List<int>();
            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT DISTINCT MeniuID from Permisiuni WHERE AngajatRolID = " + RolId + ";", Program.databaseConnection);
            
            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                // salvam id-ul ca string
                string t = dataReader.GetValue(0).ToString();
                int meniu = int.Parse(t);
                Permisiuni.Add(meniu);
            }
            dataReader.Close();
        }

        private void GetUserAccountId()
        {
            //facem query-ul de SQL
            SqlCommand cmd = new SqlCommand(@"SELECT id from Angajat WHERE ContID = " + UserID + ";", Program.databaseConnection);

            // se executa query-ul
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                // salvam id-ul ca string
                string t = dataReader.GetValue(0).ToString();
                AngajatId = int.Parse(t);
            }
            dataReader.Close();
        }

        private void HideDeniedPermissionButtons()
        {
            if (Permisiuni.Contains(int.Parse(btnDateFinanciare.Tag.ToString())))
                btnDateFinanciare.Visible = true;

            if (Permisiuni.Contains(int.Parse(btnCatalog.Tag.ToString())) )
                btnCatalog.Visible = true;

            if (Permisiuni.Contains(int.Parse(btnResurseUmane.Tag.ToString())))
                btnResurseUmane.Visible = true;

            if (Permisiuni.Contains(int.Parse(btnFacultati.Tag.ToString())))
                btnFacultati.Visible = true;

            if (Permisiuni.Contains(int.Parse(btnStudenti.Tag.ToString())))
                btnStudenti.Visible = true;
        }

        private void HideAllSubMenus()
        {
            if (panelResurseUmane.Visible == true)
                panelResurseUmane.Visible = false;

            if (panelStudenti.Visible == true)
                panelStudenti.Visible = false;

            if (panelCatalog.Visible == true)
                panelCatalog.Visible = false;

            if (panelDateFinanciare.Visible == true)
                panelDateFinanciare.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideAllSubMenus();
                subMenu.Visible = true;
            }
            else 
                subMenu.Visible = false;
        }

#if false
        //aici trebuie sa lucrez in viitor
        private void GetDataFromSQL()
        {
            Data = new AccountData(UserID);
            Data.ReadUniversityDataFromDatabase();
            Data.ReadStudentDataFromDatabase();
            Data.ReadEmployDataFromDatabase();
            Data.ReadCatalogDataFromDatabase();
            Data.ReadTaxeStudiiDataFromDatabase();
        }
#endif

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

#if false
        //aici trebuie sa lucrez in viitor

        public class UniversityData
        {
            public UniversityData(int facultateID, string numeFacultate, string adresa, string oras, string numeDomeniu, int nrAni, int nrLocuri, string tipAdmitere, string program)
            { //managementul unitatilor
                facultateID = FacultateID;
                numeFacultate = NumeFacultate;
                adresa = Adresa;
                oras = Oras;
                numeDomeniu = Domeniu;
                nrAni = NrAni;
                nrLocuri = NrLocuri;
                tipAdmitere = Admitere;
                program = Program;
            }
            /*public override string ToString()
            {
                return Name;
            }
            */
            public int FacultateID;
            public string NumeFacultate;
            public string Adresa;
            public string Oras;
            public string Domeniu;
            public int NrAni;
            public int NrLocuri;
            public string Admitere;
            public string Program;

        }

        public class AngajatData
        {
            public AngajatData(int angajatID, string numeAngajat, DateTime dataNasterii, int cnp, string telefon, string email, string domeniu, string facultate)
            { //pentru contul admin pentru a vedea toti angajatii
                angajatID = AngajatID;
                numeAngajat = NumeAngajat;
                dataNasterii = DataNasterii;
                cnp = CNP;
                telefon = Telefon;
                email = Email;
                domeniu = DomeniuFacultate;
                facultate = Facultate;
            }

            public int AngajatID;
            public string NumeAngajat;
            DateTime DataNasterii;
            public int CNP;
            public string Telefon;
            public string Email;
            public string DomeniuFacultate;
            public string Facultate;

        }

        public class StudentData
        {
            public StudentData(int studentID, string numeStudent, string telefonStudent, string email, string adresaStudent, int grupa, int anStudiu, string facultate, string domeniu, string program)
            {
                studentID = StudentID;
                numeStudent = NumeStudent;
                telefonStudent = TelefonStudent;
                email = Email;
                adresaStudent = AdresaStudent;
                grupa = Grupa;
                anStudiu = AnStudiu;
                facultate = Facultate;
                domeniu = Domeniu;
                program = program_facultate;

            }

            public int StudentID;
            public string NumeStudent;
            public string TelefonStudent;
            public string Email;
            public string AdresaStudent;
            public int Grupa;
            public int AnStudiu;
            public string Facultate;
            public string Domeniu;
            public string program_facultate;
        }

        public class CatalogData
        {
            public CatalogData(int idExamen, string student, int grupa, int sala, string profesor, string curs, string numeExamen, float procent, int nota, int credite)
            {
                idExamen = ExamenID;
                student = NumeStudent;
                grupa = Grupa;
                sala = Sala;
                profesor = NumeProfesor;
                curs = Curs;
                numeExamen = NumeExamen;
                procent = Procent;
                nota = Nota;
                credite = Credite;
            }
            public int ExamenID;
            public string NumeStudent;
            public int Grupa;
            public int Sala;
            public string NumeProfesor;
            public string Curs;
            public string NumeExamen;
            public float Procent;
            public int Nota;
            public int Credite;
        }

        public class TaxeData
        {
            public TaxeData(int taxaID, string nume, string domeniu, DateTime dataInceput, DateTime dataScadenta, float penalizare, int suma, string moneda)
            {
                taxaID = TaxaID;
                nume = Nume;
                domeniu = Domeniu;
                dataInceput = DataInceput;
                dataScadenta = DataScadenta;
                penalizare = Penalizare;
                suma = Suma;
                moneda = Moneda;
            }
            public int TaxaID;
            public string Nume;
            public string Domeniu;
            DateTime DataInceput;
            DateTime DataScadenta;
            public float Penalizare;
            public int Suma;
            public string Moneda;
        }

        class AccountData
        {
            public AccountData(int _userId)
            {
                UserID = _userId;
                Universitati = new List<UniversityData>();
                Angajati = new List<AngajatData>();
                Studenti = new List<StudentData>();
                Catalog = new List<CatalogData>();
                Taxe = new List<TaxeData>();
            }

            public bool ReadDataFromDatabase()
            {
                // facem query-ul de SQL
                string query = @"SELECT  Angajat.id, CONCAT(Angajat.Nume, ' ', Angajat.Prenume) AS Nume, Angajat.Data_nasterii, CNP, Email, Telefon 
                             FROM Angajat WHERE ContID = " + UserID + ";";

                SqlCommand command = new SqlCommand(query, Program.databaseConnection);

                // se executa query-ul
                SqlDataReader dataReader = command.ExecuteReader();

                // citim rezultatele returnate de catre serverul SQL
                if (dataReader.Read())
                {
                    AngajatID = (int)dataReader.GetValue(0);
                    AngajatNume = dataReader.GetValue(1).ToString();
                    AngajatDataNasterii = Convert.ToDateTime(dataReader.GetValue(2));
                    AngajatCNP = dataReader.GetValue(3).ToString();
                    AngajatEmail = dataReader.GetValue(4).ToString();
                    AngajatTelefon = dataReader.GetValue(5).ToString();
                    dataReader.Close();
                }
                else
                {
                    dataReader.Close();
                    return false;
                }

                return true;
            } //aici trebuie sa citeasca datele contului ca sa stie ce permisiuni ii da

            public void ReadUniversityDataFromDatabase()
            {

                // facem query-ul de SQL
                string query = @"SELECT Facultate.id, Facultate.Nume, Facultate.Adresa, Facultate.Oras, Domeniu.Nume, Domeniu.Nr_ani, Domeniu.Nr_locuri, TipAdmitere.Nume, Program.Nume
                            FROM Domeniu JOIN Facultate ON  Domeniu.FacultateID = Domeniu.id
			                JOIN TipAdmitere ON Domeniu.TipAdmitereID = TipAdmitere.id
			                JOIN Program ON Domeniu.ProgramID = Program.id;";

                SqlCommand command = new SqlCommand(query, Program.databaseConnection);

                // se executa query-ul
                SqlDataReader dataReader = command.ExecuteReader();

                // citim rezultatele returnate de catre serverul SQL
                while (dataReader.Read())
                {
                    // salvam id-ul ca string
                    int facultateID = (int)dataReader.GetValue(0);
                    string numeFacultate = dataReader.GetValue(1).ToString();
                    string adresa = dataReader.GetValue(2).ToString();
                    string oras = dataReader.GetValue(3).ToString();
                    string numeDomeniu = dataReader.GetValue(4).ToString();
                    int nrAni = (int)dataReader.GetValue(5);
                    int nrLocuri = (int)dataReader.GetValue(6);
                    string tipAdmitere = dataReader.GetValue(7).ToString();
                    string program = dataReader.GetValue(8).ToString();

                    UniversityData universityData = new UniversityData(facultateID, numeFacultate, adresa, oras, numeDomeniu, nrAni, nrLocuri, tipAdmitere, program);
                    Universitati.Add(universityData);
                }
                dataReader.Close();
            }

            public void ReadStudentDataFromDatabase()
            {
                // facem query-ul de SQL
                string query = @"SELECT Student.id, CONCAT(Student.Nume, ' ', Student.Prenume) as Student, Student.Telefon, Student.Email,
                            Student.Adresa, Grupa, An_studiu, Facultate.Nume, Domeniu.Nume 
                            FROM Student JOIN Facultate ON Student.FacultateID = Facultate.id
			                JOIN Domeniu ON Student.DomeniuID = Domeniu.id;";

                SqlCommand command = new SqlCommand(query, Program.databaseConnection);

                // se executa query-ul
                SqlDataReader dataReader = command.ExecuteReader();

                // citim rezultatele returnate de catre serverul SQL
                while (dataReader.Read())
                {
                    // salvam id-ul ca string
                    int studentID = (int)dataReader.GetValue(0);
                    string NumeStudent = dataReader.GetValue(1).ToString();
                    string Telefon = dataReader.GetValue(2).ToString();
                    string Email = dataReader.GetValue(3).ToString();
                    string Adresa = dataReader.GetValue(4).ToString();
                    int grupa = (int)dataReader.GetValue(5);
                    int anStudiu = (int)dataReader.GetValue(6);
                    string facultate = dataReader.GetValue(7).ToString();
                    string domeniu = dataReader.GetValue(8).ToString();
                    string program = dataReader.GetValue(9).ToString();

                    StudentData studentData = new StudentData(studentID, NumeStudent, Telefon, Email, Adresa, grupa, anStudiu, facultate, domeniu, program);
                    Studenti.Add(studentData);
                }
                dataReader.Close();
            }

            public void ReadEmployDataFromDatabase()
            {

                // facem query-ul de SQL
                string query = @"SELECT Angajat.id, CONCAT(Angajat.Nume,' ', Angajat.Prenume) as Nume, Angajat.Data_nasterii, Angajat.CNP,Angajat.Telefon, Angajat.Email, Domeniu.Nume, Facultate.Nume 
                            FROM Angajat JOIN Facultate ON Angajat.FacultateID = Facultate.id
			                JOIN Domeniu ON Angajat.DomeniuID = Domeniu.id;";

                SqlCommand command = new SqlCommand(query, Program.databaseConnection);

                // se executa query-ul
                SqlDataReader dataReader = command.ExecuteReader();

                // citim rezultatele returnate de catre serverul SQL
                while (dataReader.Read())
                {
                    // salvam id-ul ca string
                    int angajatID = (int)dataReader.GetValue(0);
                    string numeAngajat = dataReader.GetValue(1).ToString();
                    DateTime data_nasterii = Convert.ToDateTime(dataReader.GetValue(2));
                    int cnp = (int)dataReader.GetValue(3);
                    string telefon = dataReader.GetValue(4).ToString();
                    string email = dataReader.GetValue(5).ToString();
                    string domeniu = dataReader.GetValue(6).ToString();
                    string facultate = dataReader.GetValue(7).ToString();

                    AngajatData angajatData = new AngajatData(angajatID, numeAngajat, data_nasterii, cnp, telefon, email, domeniu, facultate);
                    Angajati.Add(angajatData);
                }
                dataReader.Close();
            }

            public void ReadCatalogDataFromDatabase()
            {

                // facem query-ul de SQL
                string query = @"SELECT Examen.id, CONCAT(Student.Nume,' ', Student.Prenume) as Student, Student.Grupa, Curs.Sala, CONCAT (Angajat.Nume,' ', Angajat.Prenume) as Profesor, Curs.Nume,
                            Examen.Nume, Examen.Procent, Examen.Nota, Curs.Credite
                            FROM Examen JOIN Student ON Examen.StudentID = Student.id
			                JOIN Curs ON Examen.CursID = Curs.id
			                JOIN Angajat ON Curs.AngajatID = Angajat.id;";

                SqlCommand command = new SqlCommand(query, Program.databaseConnection);

                // se executa query-ul
                SqlDataReader dataReader = command.ExecuteReader();

                // citim rezultatele returnate de catre serverul SQL
                while (dataReader.Read())
                {
                    // salvam id-ul ca string
                    int idExamen = (int)dataReader.GetValue(0);
                    string student = dataReader.GetValue(1).ToString();
                    int grupa = (int)dataReader.GetValue(2);
                    int sala = (int)dataReader.GetValue(3);
                    string profesor = dataReader.GetValue(4).ToString();
                    string curs = dataReader.GetValue(5).ToString();
                    string numeExamen = dataReader.GetValue(6).ToString();
                    float procent = (float)dataReader.GetValue(7);
                    int nota = (int)dataReader.GetValue(8);
                    int credite = (int)dataReader.GetValue(9);

                    CatalogData catalogData = new CatalogData(idExamen, student, grupa, sala, profesor, curs, numeExamen, procent, nota, credite);
                    Catalog.Add(catalogData);
                }
                dataReader.Close();
            }

            public void ReadTaxeStudiiDataFromDatabase()
            {

                // facem query-ul de SQL
                string query = @"SELECT TaxaStudii.id, Taxa.Nume, Domeniu.Nume, Taxa.Data_inceput, Taxa.Data_sfarsit, Taxa.Penalizare, TaxaStudii.Suma, Moneda.Simbol
                            FROM TaxaStudii JOIN Taxa ON TaxaStudii.TaxaID = Taxa.id
				            JOIN Moneda ON Taxa.MonedaID = Moneda.id
				            JOIN Domeniu ON TaxaStudii.DomeniuID = Domeniu.id;";

                SqlCommand command = new SqlCommand(query, Program.databaseConnection);

                // se executa query-ul
                SqlDataReader dataReader = command.ExecuteReader();

                // citim rezultatele returnate de catre serverul SQL
                while (dataReader.Read())
                {
                    // salvam id-ul ca string
                    int taxaID = (int)dataReader.GetValue(0);
                    string nume = dataReader.GetValue(1).ToString();
                    string domeniu = dataReader.GetValue(2).ToString();
                    DateTime dataInceput = Convert.ToDateTime(dataReader.GetValue(3));
                    DateTime dataScadenta = Convert.ToDateTime(dataReader.GetValue(4));
                    float penalizare = (float)dataReader.GetValue(5);
                    int suma = (int)dataReader.GetValue(6);
                    string moneda = dataReader.GetValue(7).ToString();

                    TaxeData taxeData = new TaxeData(taxaID, nume, domeniu, dataInceput, dataScadenta, penalizare, suma, moneda);
                    Taxe.Add(taxeData);
                }
                dataReader.Close();
            }


            public int UserID;
            public int AngajatID;
            public string AngajatNume;
            DateTime AngajatDataNasterii;
            public string AngajatCNP;
            public string AngajatEmail;
            public string AngajatTelefon;


            public List<UniversityData> Universitati;
            public List<StudentData> Studenti;
            public List<AngajatData> Angajati;
            public List<CatalogData> Catalog;
            public List<TaxeData> Taxe;
        }
#endif
        private void btnResurseUmane_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelResurseUmane);
        }

        private void btnCadre_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCadreDidactice(AngajatId));

            HideAllSubMenus();
        }
        
        private void btnFacultati_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFacultati(AngajatId));

            HideAllSubMenus();
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudenti);
        }

        private void btnListaStudenti_Click(object sender, EventArgs e)
        {
            openChildForm(new FormStudenti(AngajatId));

            HideAllSubMenus();
        }

        private void btnPromovare_Click(object sender, EventArgs e)
        {

            openChildForm(new FormPromovare());

            HideAllSubMenus();
            MessageBox.Show("Momentan aceasta optiune nu este posibila!", "Eroare", MessageBoxButtons.OK);
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCatalog);
        }

        private void btnExamene_Click(object sender, EventArgs e)
        {
            openChildForm(new FormExamene(AngajatId));

            HideAllSubMenus();
        }

        private void btnSituatieStudenti_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSituatieScolara());

            HideAllSubMenus();
            MessageBox.Show("Momentan aceasta optiune nu este posibila!", "Eroare", MessageBoxButtons.OK);
        }

        private void btnDateFinanciare_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDateFinanciare);
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPlati());

            HideAllSubMenus();
            MessageBox.Show("Momentan aceasta optiune nu este posibila!", "Eroare", MessageBoxButtons.OK);
        }

        private void btnTaxe_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTaxe());

            HideAllSubMenus();
            MessageBox.Show("Momentan aceasta optiune nu este posibila!", "Eroare", MessageBoxButtons.OK);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.forma.Close();
        }
    }
}