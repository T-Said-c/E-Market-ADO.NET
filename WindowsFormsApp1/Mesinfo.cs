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
    public partial class Mesinfo : Form
    {
        string cUser;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Mesinfo(string currentUser)
        {
            InitializeComponent();
            cUser = currentUser;
        }
        private void infoload()
        {

            cmd = new SqlCommand("select Nom,Prenom,Adresse,Tel,Email,Ville from Client where Nom=@Nom", con);
            cmd.Parameters.AddWithValue("@Nom", cUser);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tbnom.Text = dr[0].ToString();
                tbprenom.Text = dr[1].ToString();
                tbadresse.Text = dr[2].ToString();
                tbtel.Text = dr[3].ToString();
                tbemail.Text = dr[4].ToString();
                tbville.Text = dr[5].ToString();
            }
            dr.Close();
            con.Close();

        }

        private void Mesinfo_Load(object sender, EventArgs e)
        {
            infoload();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            bten.Visible = true;
            btan.Visible = true;
            tbnom.ReadOnly = false;
            tbprenom.ReadOnly = false;
            tbadresse.ReadOnly = false;
            tbtel.ReadOnly = false;
            tbemail.ReadOnly = false;
            tbville.ReadOnly = false;
        }
        private void tbreadtrue()
        {
            tbnom.ReadOnly = true;
            tbprenom.ReadOnly = true;
            tbadresse.ReadOnly = true;
            tbtel.ReadOnly = true;
            tbemail.ReadOnly = true;
            tbville.ReadOnly = true;
        }
        private void bten_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnom.Text == String.Empty || tbprenom.Text == String.Empty || tbemail.Text == String.Empty || tbadresse.Text == String.Empty || tbtel.Text == String.Empty || tbville.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir modifier vos informations?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("update Client set Nom=@Nom ,Prenom=@Prenom ,Adresse=@adresse ,Tel=@tel ,Email=@email ,Ville=@ville where Nom=@user ", con);
                        cmd.Parameters.AddWithValue("@Nom", tbnom.Text);
                        cmd.Parameters.AddWithValue("@Prenom", tbprenom.Text);
                        cmd.Parameters.AddWithValue("@adresse", tbadresse.Text);
                        cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                        cmd.Parameters.AddWithValue("@email", tbemail.Text);
                        cmd.Parameters.AddWithValue("@ville", tbville.Text);
                        cmd.Parameters.AddWithValue("@user", cUser);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                        con.Close();
                        btnModifier.Visible = true;
                        bten.Visible = false;
                        btan.Visible = false;
                        tbreadtrue();
                        infoload();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes"); MessageBox.Show(ex.Message); con.Close();
            }
        }

        private void btan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûr ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnModifier.Visible = true;
                bten.Visible = false;
                btan.Visible = false;
                tbreadtrue();
                infoload();

            }
        }
    }
}
