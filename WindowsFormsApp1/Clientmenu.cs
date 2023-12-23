using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clientmenu : Form
    {
        string cUser;
        public Clientmenu(string currentUser)
        {
            InitializeComponent();
            cUser = currentUser;
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

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkGray;

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var log = new Login();
            log.Closed += (s, args) => this.Close();
            log.Show();
        }

       
        private void frmde_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Panier(cUser));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         

        private void Clientmenu_Load(object sender, EventArgs e)
        {
            lbnc.Text = cUser;


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void frmCl_Click(object sender, EventArgs e)
        {
                try
                {
                 pictureBox1.Hide();
                 label2.Hide();
                 loadform(new Commander(cUser));

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chargerinfoform();


        }

        private void panel2_Click(object sender, EventArgs e)
        {
            chargerinfoform();
        }



            private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Crimson;

        }

        private void lbnom_Click(object sender, EventArgs e)
        {
            chargerinfoform();
        }
        private void chargerinfoform()
        {
            try
            {
                pictureBox1.Hide();
                label2.Hide();
                loadform(new Mesinfo(cUser));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbnom_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;

        }

        private void lbnom_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Crimson;

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Crimson;

        }
    }
}
