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
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Articleform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Articleform()
        {
            InitializeComponent();
        }
        private void Datagridload()
        {
        
            cmd = new SqlCommand("select * from Article", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvData.DataSource = t;
            dr.Close();
            con.Close();


        }
        private void Articleform_Load(object sender, EventArgs e)
        {
            Datagridload();
        }


        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            var data = (Byte[])(dgvData.Rows[i].Cells[4].Value);
            var stream = new MemoryStream(data);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            tbcdar.Text = dgvData.Rows[i].Cells[0].Value.ToString();
            tbdes.Text = dgvData.Rows[i].Cells[1].Value.ToString();
            tbpu.Text = dgvData.Rows[i].Cells[2].Value.ToString();
            tbqs.Text = dgvData.Rows[i].Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromStream(stream);
            tbcdca.Text = dgvData.Rows[i].Cells[5].Value.ToString();
            
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            try
            {
                if (tbcdar.Text == String.Empty || tbcdca.Text == String.Empty || tbdes.Text == String.Empty || tbpu.Text == String.Empty || tbqs.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    cmd = new SqlCommand("insert into Article(CodeArt,Designation,PU,QStock,Photo,CodeCategorie) values (@CodeArticle,@Des,@PU,@QS,@photo,@CodeCat)", con);
                    cmd.Parameters.AddWithValue("@CodeArticle", tbcdar.Text);
                    cmd.Parameters.AddWithValue("@Des", tbdes.Text);
                    cmd.Parameters.AddWithValue("@PU", tbpu.Text);
                    cmd.Parameters.AddWithValue("@QS", tbqs.Text);
                    cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
                    MemoryStream mem = new MemoryStream();
                    pictureBox1.Image.Save(mem, pictureBox1.Image.RawFormat);
                    byte[] img = mem.ToArray();
                    cmd.Parameters.AddWithValue("@photo", img);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }

            }
            catch (Exception) { MessageBox.Show("Veuillez entrer des valeurs correctes"); con.Close(); }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbcdar.Text == String.Empty || tbcdca.Text == String.Empty || tbdes.Text == String.Empty || tbpu.Text == String.Empty || tbqs.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
                    cmd = new SqlCommand("update Article set Designation=@Des ,PU=@PU ,QStock=@QS ,Photo=@photo ,CodeCategorie=@CodeCat where CodeArt=@CodeArticle ", con);
                    cmd.Parameters.AddWithValue("@CodeArticle", tbcdar.Text);
                    cmd.Parameters.AddWithValue("@Des", tbdes.Text);
                    cmd.Parameters.AddWithValue("@PU", tbpu.Text);
                    cmd.Parameters.AddWithValue("@QS", tbqs.Text);
                    cmd.Parameters.AddWithValue("@CodeCat", tbcdca.Text);
                    MemoryStream mem = new MemoryStream();
                    pictureBox1.Image.Save(mem, pictureBox1.Image.RawFormat);
                    byte[] img = mem.ToArray();
                    cmd.Parameters.AddWithValue("@photo", img);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    Datagridload();
                }
            }
            catch (Exception) { MessageBox.Show("Veuillez entrer des valeurs correctes"); con.Close(); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int i = dgvData.Rows.IndexOf(dgvData.CurrentRow);
            cmd = new SqlCommand("delete Article where CodeArt=@CodeArticle ", con);
            cmd.Parameters.AddWithValue("@CodeArticle", tbcdar.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            Datagridload();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }
    }
}
