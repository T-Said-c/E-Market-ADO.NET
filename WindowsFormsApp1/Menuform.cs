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
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        
        private void loadform(object form)
        {
                if (this.mainpanel.Controls.Count > 0)
                {
                    this.mainpanel.Controls.RemoveAt(0);
                }
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                f.Show();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmCl_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Clientform());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmcat_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Categorieform());
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Articleform());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmcom_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new ConsultComm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmfac_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Factureform());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkGray;
        }

        private void frmde_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new ConsultComm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmrech_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Rechform());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DodgerBlue;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var log = new Login();
            log.Closed += (s, args) => this.Close();
            log.Show();
        }
    }
}
