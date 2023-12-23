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
    public partial class Categorieform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Categorieform()
        {
            InitializeComponent();
        }
        private void Datagridload()
        {

            cmd = new SqlCommand("select * from Categorie",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvData.DataSource = t;
            dr.Close();
            con.Close();

        }
        private void Categorieform_Load(object sender, EventArgs e)
        {
            Datagridload();
        }




        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbcdca.Text == String.Empty || tblibelle.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    cmd = new SqlCommand("insert into Categorie(CodeCat,Libelle) values (@CodeCat,@Libelle)", con);
                    cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
                    cmd.Parameters.AddWithValue("@Libelle", tblibelle.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }

            }
            catch (Exception) { MessageBox.Show("Veuillez entrer des valeurs correctes"); con.Close(); }


        }



        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            tbcdca.Text = dgvData.Rows[i].Cells[0].Value.ToString();
            tblibelle.Text = dgvData.Rows[i].Cells[1].Value.ToString();
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbcdca.Text == String.Empty || tblibelle.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    cmd = new SqlCommand("update Categorie set Libelle=@Libelle where  CodeCat=@CodeCat ", con);
                    cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
                    cmd.Parameters.AddWithValue("@Libelle", tblibelle.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }
            }
            catch (Exception) { MessageBox.Show("Veuillez entrer des valeurs correctes"); con.Close(); 
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {

            cmd = new SqlCommand("delete Categorie where CodeCat=@CodeCat ", con);
            cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            Datagridload();
        }

       
        
    }
}


