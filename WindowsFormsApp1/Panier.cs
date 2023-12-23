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
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Panier : Form
    {
        string cUser;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Panier(string currentuser)
        {
            InitializeComponent();
            cUser = currentuser;
        }

     
        string codecl = String.Empty;
        //new string numcom;
        

        string codeart;
        private void getcodeart(int i)
        {
            cmd = new SqlCommand("select CodeArt from Detail where NumCom = @NumCom", con);
            cmd.Parameters.AddWithValue("@NumCom", dgvData.Rows[i].Cells[0].Value.ToString());
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                codeart = dr[0].ToString();
            }
            dr.Close();
            con.Close();
        }

        int QCom;
        private void getQComm(int i)
        {
            cmd = new SqlCommand("select QteCommandee from Detail where NumCom=@NumCom", con);
            cmd.Parameters.AddWithValue("@NumCom", dgvData.Rows[i].Cells[0].Value.ToString());
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                QCom = int.Parse(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        int QSt;
        private void getQStock(string cdart)
        {
            cmd = new SqlCommand("select QStock from Article where CodeArt=@CodeArt", con);
            cmd.Parameters.AddWithValue("@CodeArt",cdart);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                QSt = int.Parse(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir annuler cette commande?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
                    getcodeart(i);
                    getQComm(i);
                    getQStock(codeart);
                    cmd = new SqlCommand("delete Facture where NumCom=@NumCom ; delete Detail where NumCom=@NumCom ; delete Commande where NumCom=@NumCom;update Article set QStock=@QStock where CodeArt=@CodeArt", con);
                    cmd.Parameters.AddWithValue("@NumCom", dgvData.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@CodeArt", codeart);
                    cmd.Parameters.AddWithValue("@QStock", QSt + QCom);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    SqlCommand cmdab = new SqlCommand("select CodeCl from Client where Nom = @Nom", con);
                    cmdab.Parameters.AddWithValue("@Nom", cUser);

                    con.Open();
                    SqlDataReader sqlar = cmdab.ExecuteReader();

                    while (sqlar.Read())
                    {
                        codecl = sqlar[0].ToString();
                    }
                    sqlar.Close();
                    SqlCommand cmda = new SqlCommand("select * from Commande  where CodeCl = '" + codecl + "'", con);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataReader sqlr = cmda.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(sqlr);
                    dgvData.DataSource = t;
                    sqlr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

 


        private void Panier_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tab = new DataTable();
                dgvData.DataSource = tab;
                cmd = new SqlCommand("select CodeCl from Client where Nom = @Nom", con);
                cmd.Parameters.AddWithValue("@Nom", cUser);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    codecl = dr[0].ToString();
                }

                dr.Close();
                con.Close();
                SqlCommand cmda = new SqlCommand("select * from Commande where CodeCl = '" + codecl + "'", con);
                con.Open();
                SqlDataReader sqlr = cmda.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlr);
                dgvData.DataSource = dt;
                sqlr.Close();
                con.Close();
                //SqlCommand cmdab = new SqlCommand("select NumCom from Commande where CodeCl = '" + codecl + "'", con);
                //con.Open();
                //SqlDataReader sqler = cmdab.ExecuteReader();
                //while (sqler.Read())
                //{
                //    codecl =sqler[0].ToString();
                //}
                //sqler.Close();
                //con.Close();
                //SqlCommand cmdaba = new SqlCommand("select * from Detail where NumCom = '" + numcom + "'", con);
                //con.Open();
                //SqlDataReader sqlera = cmdaba.ExecuteReader();
                //DataTable tob = new DataTable();
                //tob.Load(sqlera);
                //dgvData.DataSource=tob;
                //sqlera.Close();
                //con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            getQComm(i);
            lbqc.Text = QCom.ToString();
            getcodeart(i);  
            cmd = new SqlCommand("select photo,designation from Article where CodeArt = @CodeArt", con);
            cmd.Parameters.AddWithValue("@CodeArt", codeart);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var data = (Byte[])(dr[0]);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
                lbdes.Text = dr[1].ToString();
            }
            dr.Close();
            con.Close();
            cmd = new SqlCommand("select MontantFact from Facture where NumCom = @NumCom", con);
            cmd.Parameters.AddWithValue("@NumCom", dgvData.Rows[i].Cells[0].Value.ToString());
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lbmt.Text = sdr[0].ToString();
            }
            sdr.Close();
            con.Close();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
