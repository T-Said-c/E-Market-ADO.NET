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
    public partial class ConsultComm : Form
    { 
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public ConsultComm()
        {
            InitializeComponent();
        }

        private void ConsultComm_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct CodeCl from Client", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            cbcl.DataSource = t;
            cbcl.ValueMember = t.Columns[0].ToString();
            dr.Close();
            con.Close();


        }

        private void cbcl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from Commande  where CodeCl = @CodeCl", con);
                cmd.Parameters.AddWithValue("@CodeCl", cbcl.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dgvcomm.DataSource = t;
                dr.Close();
                SqlCommand cmda = new SqlCommand("select nom,ville from Client where CodeCl = @CodeCl", con);
                cmda.Parameters.AddWithValue("@CodeCl", cbcl.Text);
                SqlDataReader sqlr = cmda.ExecuteReader();
                while (sqlr.Read())
                {
                    tbnom.Text = sqlr[0].ToString();
                    tbville.Text = sqlr[1].ToString();


                }
                sqlr.Close();
                con.Close();
                if (dgvcomm.Rows[0].Cells[0].Value == null )
                {
                    DataTable tab = new DataTable();
                    dgvdet.DataSource = tab;
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void cbcl_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void dgvcomm_SelectionChanged(object sender, EventArgs e)
        {
            try
            {   
                int i = dgvcomm.Rows.IndexOf(dgvcomm.CurrentRow);
                
                    
                    cmd = new SqlCommand("select * from Detail where NumCom = @NumCom", con);
                    cmd.Parameters.AddWithValue("@NumCom", dgvcomm.Rows[i].Cells[0].Value.ToString());
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(dr);
                    dgvdet.DataSource = t;
                    dr.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvcomm.Rows.IndexOf(dgvcomm.CurrentRow);
                cmd = new SqlCommand("delete Facture where NumCom=@NumCom ; delete Detail where NumCom=@NumCom ; delete Commande where NumCom=@NumCom ", con);
                cmd.Parameters.AddWithValue("@NumCom", dgvcomm.Rows[i].Cells[0].Value.ToString());
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                con.Close();
                SqlCommand cmda = new SqlCommand("select * from Commande  where CodeCl = @CodeCl", con);
                cmda.Parameters.AddWithValue("@CodeCl", cbcl.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sqlr = cmda.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(sqlr);
                dgvcomm.DataSource = t;
                sqlr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
