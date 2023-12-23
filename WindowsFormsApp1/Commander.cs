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
    public partial class Commander : Form
    {
        string cUser;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B;Initial Catalog=Vente;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Commander(string currentUser)
        {
            InitializeComponent();
            cUser = currentUser;    
        }

        private void tabTV_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct designation from Article", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Close();
            con.Close();
        }




        private void tabPC_Click(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { if (numericUpDown1.Value == 0)
            {
                label5.Text = "16999";
            }
            else
            {
                label5.Text = (numericUpDown1.Value * 16999).ToString();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                label9.Text = "2199";
            }
            else
            {
                label9.Text = (numericUpDown2.Value * 2199).ToString();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 0)
            {
                label11.Text = "8999";
            }
            else
            {
                label11.Text = (numericUpDown3.Value * 8999).ToString();
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value == 0)
            {
                label13.Text = "6799";
            }
            else
            {
                label13.Text = (numericUpDown4.Value * 6799).ToString();
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value == 0)
            {
                label15.Text = "21690";
            }
            else
            {
                label15.Text = (numericUpDown5.Value * 21690).ToString();
            }
        }
        string codecl = String.Empty;
        private void getcodecl()
        {
            cmd = new SqlCommand("select CodeCl from Client where Nom = @Nom", con);
            cmd.Parameters.AddWithValue("@Nom",cUser );
           
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                codecl = dr[0].ToString();
            }
            dr.Close(); 
            con.Close();
        }
        

       
        
        
        Random rnd = new Random();
        private void btCom_Click(object sender, EventArgs e)
        { if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ce produit n'est pas disponible au moment");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir commander ce produit?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    getcodecl();
                    int num = rnd.Next(10000);
                    int randomnum = int.Parse(codecl) + num;
                    cmd = new SqlCommand("insert into Commande(NumCom,Datecom,CodeCl) values (@Numcom,@date,@codecl) ; " +
                        "insert into Detail(NumCom,CodeArt,QteCommandee) values (@Numcom,'20',@QC) ;" +
                        "insert into Facture(NumeroFact,DateFact,MontantFact,NumCom) values (@Facnum,@date,@montant,@Numcom);" +
                        "update Article set QStock = @Qstock where CodeArt = '20' ", con);
                    cmd.Parameters.AddWithValue("@codecl", codecl);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@QC", numericUpDown1.Value.ToString());
                    cmd.Parameters.AddWithValue("@Numcom", randomnum.ToString());
                    cmd.Parameters.AddWithValue("@Facnum", num.ToString());
                    cmd.Parameters.AddWithValue("@montant", label5.Text);
                    cmd.Parameters.AddWithValue("@Qstock", (numericUpDown1.Maximum - numericUpDown1.Value).ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La commande est effectuée");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                MessageBox.Show("Ce produit n'est pas disponible au moment");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir commander ce produit?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    getcodecl();
                    int num = rnd.Next(10000);
                    int randomnum = int.Parse(codecl) + num;
                    cmd = new SqlCommand("insert into Commande(NumCom,Datecom,CodeCl) values (@Numcom,@date,@codecl) ; " +
                        "insert into Detail(NumCom,CodeArt,QteCommandee) values (@Numcom,'9',@QC) ;" +
                        "insert into Facture(NumeroFact,DateFact,MontantFact,NumCom) values (@Facnum,@date,@montant,@Numcom);" +
                        "update Article set QStock = @Qstock where CodeArt = '9' ", con);
                    cmd.Parameters.AddWithValue("@codecl", codecl);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@QC", numericUpDown2.Value.ToString());
                    cmd.Parameters.AddWithValue("@Numcom", randomnum.ToString());
                    cmd.Parameters.AddWithValue("@Facnum", num.ToString());
                    cmd.Parameters.AddWithValue("@montant", label9.Text);
                    cmd.Parameters.AddWithValue("@Qstock", (numericUpDown2.Maximum - numericUpDown2.Value).ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La commande est effectuée");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 0)
            {
                MessageBox.Show("Ce produit n'est pas disponible au moment");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir commander ce produit?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    getcodecl();
                    int num = rnd.Next(10000);
                    int randomnum = int.Parse(codecl) + num;
                    cmd = new SqlCommand("insert into Commande(NumCom,Datecom,CodeCl) values (@Numcom,@date,@codecl) ; " +
                        "insert into Detail(NumCom,CodeArt,QteCommandee) values (@Numcom,'32',@QC) ;" +
                        "insert into Facture(NumeroFact,DateFact,MontantFact,NumCom) values (@Facnum,@date,@montant,@Numcom);" +
                        "update Article set QStock = @Qstock where CodeArt = '32' ", con);
                    cmd.Parameters.AddWithValue("@codecl", codecl);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@QC", numericUpDown3.Value.ToString());
                    cmd.Parameters.AddWithValue("@Numcom", randomnum.ToString());
                    cmd.Parameters.AddWithValue("@Facnum", num.ToString());
                    cmd.Parameters.AddWithValue("@montant", label11.Text);
                    cmd.Parameters.AddWithValue("@Qstock", (numericUpDown3.Maximum - numericUpDown3.Value).ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La commande est effectuée");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value == 0)
            {
                MessageBox.Show("Ce produit n'est pas disponible au moment");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir commander ce produit?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    getcodecl();
                    int num = rnd.Next(10000);
                    int randomnum = int.Parse(codecl) + num;
                    cmd = new SqlCommand("insert into Commande(NumCom,Datecom,CodeCl) values (@Numcom,@date,@codecl) ; " +
                        "insert into Detail(NumCom,CodeArt,QteCommandee) values (@Numcom,'74',@QC) ;" +
                        "insert into Facture(NumeroFact,DateFact,MontantFact,NumCom) values (@Facnum,@date,@montant,@Numcom);" +
                        "update Article set QStock = @Qstock where CodeArt = '74' ", con);
                    cmd.Parameters.AddWithValue("@codecl", codecl);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@QC", numericUpDown4.Value.ToString());
                    cmd.Parameters.AddWithValue("@Numcom", randomnum.ToString());
                    cmd.Parameters.AddWithValue("@Facnum", num.ToString());
                    cmd.Parameters.AddWithValue("@montant", label13.Text);
                    cmd.Parameters.AddWithValue("@Qstock", (numericUpDown4.Maximum - numericUpDown4.Value).ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La commande est effectuée");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown5.Value == 0)
            {
                MessageBox.Show("Ce produit n'est pas disponible au moment");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir commander ce produit?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    getcodecl();
                    int num = rnd.Next(10000);
                    int randomnum = int.Parse(codecl) + num;
                    cmd = new SqlCommand("insert into Commande(NumCom,Datecom,CodeCl) values (@Numcom,@date,@codecl) ; " +
                        "insert into Detail(NumCom,CodeArt,QteCommandee) values (@Numcom,'49',@QC) ;" +
                        "insert into Facture(NumeroFact,DateFact,MontantFact,NumCom) values (@Facnum,@date,@montant,@Numcom) ;" +
                        "update Article set QStock=@Qstock where CodeArt='49'", con);
                    cmd.Parameters.AddWithValue("@codecl", codecl);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@QC", numericUpDown5.Value.ToString());
                    cmd.Parameters.AddWithValue("@Numcom", randomnum.ToString());
                    cmd.Parameters.AddWithValue("@Facnum", num.ToString());
                    cmd.Parameters.AddWithValue("@montant", label15.Text);
                    cmd.Parameters.AddWithValue("@Qstock", (numericUpDown5.Maximum - numericUpDown5.Value).ToString());
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La commande est effectuée");
                }
            }
        }
      
        private void Commander_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select distinct QStock from Article where CodeArt = '20'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                numericUpDown1.Maximum = Convert.ToInt32(dr[0].ToString());
                dr.Close();
                con.Close();
                cmd = new SqlCommand("select distinct QStock from Article where CodeArt = '9'", con);
                con.Open();
                SqlDataReader dra = cmd.ExecuteReader();
                dra.Read();
                numericUpDown2.Maximum = Convert.ToInt32(dra[0].ToString());
                dra.Close();
                con.Close();
                cmd = new SqlCommand("select distinct QStock from Article where CodeArt = '32'", con);
                con.Open();
                SqlDataReader draz = cmd.ExecuteReader();
                draz.Read();
                numericUpDown3.Maximum = Convert.ToInt32(draz[0].ToString());
                draz.Close();
                con.Close();
                cmd = new SqlCommand("select distinct QStock from Article where CodeArt = '74'", con);
                con.Open();
                SqlDataReader draze = cmd.ExecuteReader();
                draze.Read();
                numericUpDown4.Maximum = Convert.ToInt32(draze[0].ToString());
                draze.Close();
                con.Close();
                cmd = new SqlCommand("select distinct QStock from Article where CodeArt = '49'", con);
                con.Open();
                SqlDataReader drazer = cmd.ExecuteReader();
                drazer.Read();
                numericUpDown5.Maximum = Convert.ToInt32(drazer[0].ToString());
                drazer.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
