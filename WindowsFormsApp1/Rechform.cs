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

    public partial class Rechform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Rechform()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dgvData.DataSource = dt;
            Activer();
            if(comboBox1.Text == "Client")
            {
                lab1.Text = "Code Client";
                lab2.Text = "Nom";
                lab3.Text = "Prenom";
                lab4.Text = "Adresse";
                lab5.Text = "Tel";
                lab6.Text = "Email";
                lab7.Text = "Ville";
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Categorie")
            {
                lab1.Text = "Code Catégorie";
                lab2.Text = "Libelle";
                tb3.Enabled = false;
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Detail")
            {
                lab1.Text = "Numèro Commande";
                lab2.Text = "Code Article";
                lab3.Text = "Qt Commandée";
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Facture")
            {
                lab1.Text = "Numèro Facture";
                lab2.Text = "Montant Facture";
                lab3.Text = "Numèro Commmande";
                lab8.Text = "Date Facture";
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Commande")
            {
                lab1.Text = "Numèro Commmande";
                lab2.Text = "Code Client";
                lab8.Text = "Date Commande";
                tb3.Enabled = false;
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
                tb7.Enabled = false;
            }
            else { }
            if (comboBox1.Text == "Article")
            {
                lab1.Text = "Code Article";
                lab2.Text = "Designation";
                lab3.Text = "Prix Unitaire";
                lab4.Text = "Quantité Stock";
                lab5.Text = "Code Catégorie";
                tb6.Enabled = false;
                tb7.Enabled = false;
                dt8.Enabled = false;
                cbdt.Enabled = false;
            }
            else { }
        }

        private void Activer()
        {
            lab1.Text = "";
            lab2.Text = "";
            lab3.Text = "";
            lab4.Text = "";
            lab5.Text = "";
            lab6.Text = "";
            lab7.Text = "";
            lab8.Text = "";
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            tb4.Enabled = true;
            tb5.Enabled = true;
            tb6.Enabled = true;
            tb7.Enabled = true;
            cbdt.Enabled = true;
        }

        private void Rechform_Load(object sender, EventArgs e)
        {

        }
        
        private void rechmulti_Click(object sender, EventArgs e)
        {if (comboBox1.Text == String.Empty) { MessageBox.Show("Veuillez choisir une table"); }
            else
            {
                DataTable dt = new DataTable();
                dgvData.DataSource = dt;
                string req = "";
                if (comboBox1.Text == "Client")
                {
                    req = "select * from Client where CodeCl like '" + tb1.Text + "%' and Nom like '" + tb2.Text + "%' and Prenom like '" + tb3.Text + "%' and Adresse like '" + tb4.Text + "%' and Tel like '" + tb5.Text + "%' and Email like '" + tb6.Text + "%' and Ville like '" + tb7.Text + "%'";
                }
                if (comboBox1.Text == "Categorie")
                {
                    req = "select * from Categorie where CodeCat like '" + tb1.Text + "%' and Libelle like '" + tb2.Text + "%'";
                }
                if (comboBox1.Text == "Detail")
                {
                    req = "select * from Detail where NumCom like '" + tb1.Text + "%' and CodeArt like '" + tb2.Text + "%'and QteCommandee like '" + tb3.Text + "%'";
                }
                if (comboBox1.Text == "Commande")
                {
                    if (dt8.Enabled == true)
                    {
                        req = "select * from Commande where NumCom like '" + tb1.Text + "%' and DateCom =@Date and CodeCl like '" + tb2.Text + "%'";
                    }
                    else
                    {
                        req = "select * from Commande where NumCom like '" + tb1.Text + "%' and CodeCl like '" + tb2.Text + "%'";
                    }
                }
                if (comboBox1.Text == "Facture")
                {
                    if (dt8.Enabled == true)
                    {
                        req = "select * from Facture where NumeroFact like '" + tb1.Text + "%' and DateFact =@Date and MontantFact like '" + tb2.Text + "%'and NumCom like '" + tb3.Text + "%'";
                    }
                    else
                    {
                        req = "select * from Facture where NumeroFact like '" + tb1.Text + "%' and MontantFact like '" + tb2.Text + "%'and NumCom like '" + tb3.Text + "%'";
                    }
                }
                if (comboBox1.Text == "Article")
                {
                    req = "select * from Article where CodeArt like '" + tb1.Text + "%' and Designation like '" + tb2.Text + "%'and PU like '" + tb3.Text + "%'and QStock like '" + tb4.Text + "%'and CodeCategorie like '" + tb5.Text + "%'";
                }
                cmd = new SqlCommand(req, con);
                cmd.Parameters.AddWithValue("@Date", dt8.Value.Date);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dgvData.DataSource = t;
                dr.Close();
                con.Close();
            }
            

        }

        private void cbdt_CheckedChanged(object sender, EventArgs e)
        {
            if(cbdt.Checked == true)
            {
                dt8.Enabled = true;
            }
            if (cbdt.Checked == false)
            {
                dt8.Enabled = false;
            }
        }
    }
}
