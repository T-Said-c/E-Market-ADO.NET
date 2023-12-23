namespace WindowsFormsApp1
{
    partial class Menuform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frmCl = new System.Windows.Forms.Button();
            this.frmar = new System.Windows.Forms.Button();
            this.frmcat = new System.Windows.Forms.Button();
            this.frmde = new System.Windows.Forms.Button();
            this.frmfac = new System.Windows.Forms.Button();
            this.frmrech = new System.Windows.Forms.Button();
            this.panelselect = new System.Windows.Forms.Panel();
            this.btlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelselect.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Controls.Add(this.pictureBox1);
            this.mainpanel.ForeColor = System.Drawing.Color.Red;
            this.mainpanel.Location = new System.Drawing.Point(173, 34);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(663, 545);
            this.mainpanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(91, 313);
            this.label2.MaximumSize = new System.Drawing.Size(450, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "ShopMart.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.shoppinglogo;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.shoppinglogo;
            this.pictureBox1.Location = new System.Drawing.Point(91, 9);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(450, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmCl
            // 
            this.frmCl.BackColor = System.Drawing.Color.Gray;
            this.frmCl.FlatAppearance.BorderSize = 0;
            this.frmCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmCl.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmCl.Location = new System.Drawing.Point(0, 24);
            this.frmCl.Name = "frmCl";
            this.frmCl.Size = new System.Drawing.Size(177, 29);
            this.frmCl.TabIndex = 0;
            this.frmCl.Text = "Clients";
            this.frmCl.UseVisualStyleBackColor = false;
            this.frmCl.Click += new System.EventHandler(this.frmCl_Click_1);
            // 
            // frmar
            // 
            this.frmar.BackColor = System.Drawing.Color.Gray;
            this.frmar.FlatAppearance.BorderSize = 0;
            this.frmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmar.Location = new System.Drawing.Point(0, 117);
            this.frmar.Name = "frmar";
            this.frmar.Size = new System.Drawing.Size(177, 29);
            this.frmar.TabIndex = 1;
            this.frmar.Text = "Articles";
            this.frmar.UseVisualStyleBackColor = false;
            this.frmar.Click += new System.EventHandler(this.frmar_Click_1);
            // 
            // frmcat
            // 
            this.frmcat.BackColor = System.Drawing.Color.Gray;
            this.frmcat.FlatAppearance.BorderSize = 0;
            this.frmcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmcat.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmcat.Location = new System.Drawing.Point(0, 71);
            this.frmcat.Name = "frmcat";
            this.frmcat.Size = new System.Drawing.Size(177, 29);
            this.frmcat.TabIndex = 2;
            this.frmcat.Text = "Catégories";
            this.frmcat.UseVisualStyleBackColor = false;
            this.frmcat.Click += new System.EventHandler(this.frmcat_Click_1);
            // 
            // frmde
            // 
            this.frmde.BackColor = System.Drawing.Color.Gray;
            this.frmde.FlatAppearance.BorderSize = 0;
            this.frmde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmde.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmde.Location = new System.Drawing.Point(0, 165);
            this.frmde.Name = "frmde";
            this.frmde.Size = new System.Drawing.Size(177, 55);
            this.frmde.TabIndex = 4;
            this.frmde.Text = "Consultation Commande";
            this.frmde.UseVisualStyleBackColor = false;
            this.frmde.Click += new System.EventHandler(this.frmde_Click);
            // 
            // frmfac
            // 
            this.frmfac.BackColor = System.Drawing.Color.Gray;
            this.frmfac.FlatAppearance.BorderSize = 0;
            this.frmfac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmfac.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmfac.Location = new System.Drawing.Point(0, 239);
            this.frmfac.Name = "frmfac";
            this.frmfac.Size = new System.Drawing.Size(177, 29);
            this.frmfac.TabIndex = 5;
            this.frmfac.Text = "Factures";
            this.frmfac.UseVisualStyleBackColor = false;
            this.frmfac.Click += new System.EventHandler(this.frmfac_Click_1);
            // 
            // frmrech
            // 
            this.frmrech.BackColor = System.Drawing.Color.Gray;
            this.frmrech.FlatAppearance.BorderSize = 0;
            this.frmrech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmrech.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmrech.Location = new System.Drawing.Point(0, 347);
            this.frmrech.Name = "frmrech";
            this.frmrech.Size = new System.Drawing.Size(177, 47);
            this.frmrech.TabIndex = 6;
            this.frmrech.Text = "RECHERCHE";
            this.frmrech.UseVisualStyleBackColor = false;
            this.frmrech.Click += new System.EventHandler(this.frmrech_Click_1);
            // 
            // panelselect
            // 
            this.panelselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelselect.Controls.Add(this.btlogout);
            this.panelselect.Controls.Add(this.frmrech);
            this.panelselect.Controls.Add(this.frmfac);
            this.panelselect.Controls.Add(this.frmde);
            this.panelselect.Controls.Add(this.frmcat);
            this.panelselect.Controls.Add(this.frmar);
            this.panelselect.Controls.Add(this.frmCl);
            this.panelselect.Location = new System.Drawing.Point(0, 34);
            this.panelselect.Name = "panelselect";
            this.panelselect.Size = new System.Drawing.Size(176, 579);
            this.panelselect.TabIndex = 10;
            // 
            // btlogout
            // 
            this.btlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btlogout.BackColor = System.Drawing.Color.Gray;
            this.btlogout.FlatAppearance.BorderSize = 0;
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.Location = new System.Drawing.Point(0, 430);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(177, 47);
            this.btlogout.TabIndex = 7;
            this.btlogout.Text = "LOG-OUT";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 37);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(727, -12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manageur Du Base de Données";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(778, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelselect);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menuform";
            this.Text = "Menuform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelselect.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button frmCl;
        private System.Windows.Forms.Button frmar;
        private System.Windows.Forms.Button frmcat;
        private System.Windows.Forms.Button frmde;
        private System.Windows.Forms.Button frmfac;
        private System.Windows.Forms.Button frmrech;
        private System.Windows.Forms.Panel panelselect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btlogout;
    }
}