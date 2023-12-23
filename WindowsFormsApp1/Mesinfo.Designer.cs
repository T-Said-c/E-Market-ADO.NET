namespace WindowsFormsApp1
{
    partial class Mesinfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbville = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbadresse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbprenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.bten = new System.Windows.Forms.Button();
            this.btan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 51);
            this.panel1.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(269, -5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(528, 56);
            this.label8.TabIndex = 133;
            this.label8.Text = "MES INFORMATIONS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbville
            // 
            this.tbville.Location = new System.Drawing.Point(427, 332);
            this.tbville.Margin = new System.Windows.Forms.Padding(4);
            this.tbville.Name = "tbville";
            this.tbville.ReadOnly = true;
            this.tbville.Size = new System.Drawing.Size(132, 22);
            this.tbville.TabIndex = 151;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(427, 298);
            this.tbemail.Margin = new System.Windows.Forms.Padding(4);
            this.tbemail.Name = "tbemail";
            this.tbemail.ReadOnly = true;
            this.tbemail.Size = new System.Drawing.Size(201, 22);
            this.tbemail.TabIndex = 150;
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(427, 266);
            this.tbtel.Margin = new System.Windows.Forms.Padding(4);
            this.tbtel.Name = "tbtel";
            this.tbtel.ReadOnly = true;
            this.tbtel.Size = new System.Drawing.Size(201, 22);
            this.tbtel.TabIndex = 149;
            // 
            // tbadresse
            // 
            this.tbadresse.Location = new System.Drawing.Point(427, 230);
            this.tbadresse.Margin = new System.Windows.Forms.Padding(4);
            this.tbadresse.Name = "tbadresse";
            this.tbadresse.ReadOnly = true;
            this.tbadresse.Size = new System.Drawing.Size(201, 22);
            this.tbadresse.TabIndex = 148;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(326, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 147;
            this.label7.Text = "Ville  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(326, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 146;
            this.label6.Text = "Email :";
            // 
            // tbprenom
            // 
            this.tbprenom.Location = new System.Drawing.Point(427, 187);
            this.tbprenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbprenom.Name = "tbprenom";
            this.tbprenom.ReadOnly = true;
            this.tbprenom.Size = new System.Drawing.Size(132, 22);
            this.tbprenom.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(326, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 144;
            this.label5.Text = "Tel :";
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(427, 144);
            this.tbnom.Margin = new System.Windows.Forms.Padding(4);
            this.tbnom.Name = "tbnom";
            this.tbnom.ReadOnly = true;
            this.tbnom.Size = new System.Drawing.Size(132, 22);
            this.tbnom.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(326, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 142;
            this.label4.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(326, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 141;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 139;
            this.label2.Text = "Nom :";
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(844, 230);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(142, 28);
            this.btnModifier.TabIndex = 152;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // bten
            // 
            this.bten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bten.ForeColor = System.Drawing.Color.Black;
            this.bten.Location = new System.Drawing.Point(844, 190);
            this.bten.Margin = new System.Windows.Forms.Padding(4);
            this.bten.Name = "bten";
            this.bten.Size = new System.Drawing.Size(142, 28);
            this.bten.TabIndex = 153;
            this.bten.Text = "Enregistrer";
            this.bten.UseVisualStyleBackColor = true;
            this.bten.Visible = false;
            this.bten.Click += new System.EventHandler(this.bten_Click);
            // 
            // btan
            // 
            this.btan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btan.ForeColor = System.Drawing.Color.Black;
            this.btan.Location = new System.Drawing.Point(844, 269);
            this.btan.Margin = new System.Windows.Forms.Padding(4);
            this.btan.Name = "btan";
            this.btan.Size = new System.Drawing.Size(142, 28);
            this.btan.TabIndex = 154;
            this.btan.Text = "Annuler";
            this.btan.UseVisualStyleBackColor = true;
            this.btan.Visible = false;
            this.btan.Click += new System.EventHandler(this.btan_Click);
            // 
            // Mesinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btan);
            this.Controls.Add(this.bten);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbville);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.tbadresse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbprenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mesinfo";
            this.Text = "Mesinfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mesinfo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbville;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbadresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbprenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button bten;
        private System.Windows.Forms.Button btan;
    }
}