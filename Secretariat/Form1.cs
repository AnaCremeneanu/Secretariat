using Secretariat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();

            webBrowser1.Navigate("about:blank");
            if (webBrowser1.Document != null)
                webBrowser1.Document.Write(Resources.animatie);

            webBrowser1.DocumentText = Resources.animatie;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string connection;
            connection = @"Server = DESKTOP-QFNANNH\SQLEXPRESS; Database = App; Integrated Security = True;";

            Program.databaseConnection = new SqlConnection(connection);

            try
            {
                Program.databaseConnection.Open();
            }
            catch
            {
                MessageBox.Show("Nu ne-am putut conecta la baza de date.");
                return;
            }

            string u = txtuser.Text;
            string p = txtpassword.Text;

            string query = "SELECT * FROM Cont WHERE Utilizator = '" + u + "' AND Parola = '" + p + "';";

            SqlCommand command = new SqlCommand(query, Program.databaseConnection);

            //se executa query-ul
            SqlDataReader dataReader = command.ExecuteReader();

            //citim datele returnate
            int userID;

            if (dataReader.Read())
            {
                string s = dataReader.GetValue(0).ToString();

                userID = int.Parse(s);
                dataReader.Close();
            }

            else
            {
                MessageBox.Show("Numele de utilizator sau parola introdusa de dvs. este incorecta. " +
                    "Va rugam sa incercati din nou. Daca nu va puteti autentifica, contactati administratorul de sistem.");
                dataReader.Close();
                return;
            }

            query = "SELECT RolId FROM AngajatRol WHERE AngajatId = '" + userID + "';";

            command = new SqlCommand(query, Program.databaseConnection);

            //se executa query-ul
            dataReader = command.ExecuteReader();

            //citim datele returnate
            int rolID;

            if (dataReader.Read())
            {
                string s = dataReader.GetValue(0).ToString();

                rolID = int.Parse(s);
                dataReader.Close();
            }

            else
            {
                // nu exista rol setat pentru userul respectiv
                dataReader.Close();
                return;
            }

            UserForm fereastra = new UserForm(userID, rolID);
            fereastra.Show();

            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.databaseConnection != null)
                Program.databaseConnection.Close();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "CONT")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "CONT";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "PAROLA")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {

            if (txtpassword.Text == "")
            {
                txtpassword.Text = "PAROLA";
                txtpassword.ForeColor = Color.DimGray;

                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
