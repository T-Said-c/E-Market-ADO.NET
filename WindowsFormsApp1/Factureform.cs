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
    public partial class Factureform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Factureform()
        {
            InitializeComponent();
        }
        private void Datagridload()
        {

            cmd = new SqlCommand("select * from Facture", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvData.DataSource = t;
            dr.Close();
            con.Close();

        }
        private void Factureform_Load(object sender, EventArgs e)
        {
            Datagridload();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnc.Text == String.Empty || tbcdfa.Text == String.Empty || tbmo.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    cmd = new SqlCommand("insert into Facture(NumeroFact,DateFact,MontantFact,NumCom) values (@CodeFac,@Datef,@MF,@Numco)", con);
                    cmd.Parameters.AddWithValue("@CodeFac", tbcdfa.Text);
                    cmd.Parameters.AddWithValue("@Datef", dtpf.Value);
                    cmd.Parameters.AddWithValue("@MF", tbmo.Text);
                    cmd.Parameters.AddWithValue("@Numco", tbnc.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }

            }
            catch (Exception) {
                MessageBox.Show("Veuillez entrer des valeurs correctes");
                     con.Close();
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            tbcdfa.Text = dgvData.Rows[i].Cells[0].Value.ToString();
            dtpf.Value = DateTime.Parse(dgvData.Rows[i].Cells[1].Value.ToString());
            tbmo.Text = dgvData.Rows[i].Cells[2].Value.ToString();
            tbnc.Text = dgvData.Rows[i].Cells[3].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnc.Text == String.Empty || tbcdfa.Text == String.Empty || tbmo.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    cmd = new SqlCommand("update Facture set DateFact=@Datef ,MontantFact=@MF ,NumCom=@Numco where  NumeroFact=@CodeFac ", con);
                    cmd.Parameters.AddWithValue("@CodeFac", tbcdfa.Text);
                    cmd.Parameters.AddWithValue("@Datef", dtpf.Value);
                    cmd.Parameters.AddWithValue("@MF", tbmo.Text);
                    cmd.Parameters.AddWithValue("@Numco", tbnc.Text);
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

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete Facture where NumeroFact=@CodeFac ", con);
            cmd.Parameters.AddWithValue("@CodeFac", tbcdfa.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            Datagridload();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
