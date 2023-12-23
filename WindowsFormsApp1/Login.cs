using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }


        string name= string.Empty;
        public void button1_Click(object sender, EventArgs e)
        {           
                bool a = false;
                bool b = false;
                if (checkstatus.Checked == true)
                {
                    if (tbemail.Text == "tahir@gmail.com" && tbmdp.Text == "admin")
                    {

                        this.Hide();
                        var menu = new Menuform();
                        menu.Closed += (s, args) => this.Close();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("L'email  ou Le mot de passe est incorrecte");
                        tbemail.Clear();
                        tbmdp.Clear();
                    }
                }
                if (checkstatus.Checked == false)
                {
                    cmd = new SqlCommand("Select distinct Email from Client", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (tbemail.Text == dr[0].ToString())
                        {
                            a = true;
                            Nom = tbemail.Text;
                            break;

                        }
                       
                    }
                    dr.Close();
                    SqlCommand cmda = new SqlCommand("Select distinct prenom from Client", con);
                    SqlDataReader sqlr = cmda.ExecuteReader();
                    while (sqlr.Read())
                    {
                        if (tbmdp.Text == sqlr[0].ToString())
                        {
                            b = true;
                            
                        }
                        
                    }     
                    sqlr.Close();
                    con.Close();
                    if(a == true && b == true)
                    {
                    SqlCommand cmdaz = new SqlCommand("Select distinct nom from Client where email=@email", con);
                    cmdaz.Parameters.AddWithValue("@email", tbemail.Text);
                    con.Open();
                    SqlDataReader sqler = cmdaz.ExecuteReader();
                    while (sqler.Read())
                    {
                        name = sqler[0].ToString();

                    }
                    sqler.Close();
                    con.Close();
                    this.Hide();
                        var menu = new Clientmenu(name);
                        menu.Closed += (s, args) => this.Close();
                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Le Username ou Le mot de passe est incorrecte");
                        tbemail.Clear();
                        tbmdp.Clear();
                    }
                }
               
           
        }
        public string Nom = string.Empty;

        public string _Nom
        {
            get { return Nom; }
            set { if(Nom != value ) Nom = value; }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbmdp.PasswordChar = '\0';
            }
            else
            {
                tbmdp.PasswordChar = '*';
            }
        }

        private void btCl_Click(object sender, EventArgs e)
        {
            checkstatus.Checked = false;
            btCl.BackColor = Color.Crimson;
            btmn.BackColor = Color.DarkGray;
        }

        private void btmn_Click(object sender, EventArgs e)
        {
            checkstatus.Checked = true;
            btmn.BackColor = Color.Crimson;
            btCl.BackColor = Color.DarkGray;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
