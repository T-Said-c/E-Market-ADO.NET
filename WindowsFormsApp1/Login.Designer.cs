namespace WindowsFormsApp1
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbmdp = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btmn = new System.Windows.Forms.Button();
            this.btCl = new System.Windows.Forms.Button();
            this.checkstatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.shoppinglogo;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.shoppinglogo;
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.tbmdp);
            this.panel1.Controls.Add(this.tbemail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 134);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(490, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // tbmdp
            // 
            this.tbmdp.Location = new System.Drawing.Point(246, 76);
            this.tbmdp.Name = "tbmdp";
            this.tbmdp.PasswordChar = '*';
            this.tbmdp.Size = new System.Drawing.Size(184, 22);
            this.tbmdp.TabIndex = 9;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(246, 28);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(184, 22);
            this.tbemail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(82, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de Passe :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email :";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(218, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log-In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmn
            // 
            this.btmn.BackColor = System.Drawing.Color.DarkGray;
            this.btmn.FlatAppearance.BorderSize = 0;
            this.btmn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmn.Location = new System.Drawing.Point(473, -2);
            this.btmn.Name = "btmn";
            this.btmn.Size = new System.Drawing.Size(175, 36);
            this.btmn.TabIndex = 3;
            this.btmn.Text = "Manageur";
            this.btmn.UseVisualStyleBackColor = false;
            this.btmn.Click += new System.EventHandler(this.btmn_Click);
            // 
            // btCl
            // 
            this.btCl.BackColor = System.Drawing.Color.Crimson;
            this.btCl.FlatAppearance.BorderSize = 0;
            this.btCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCl.Location = new System.Drawing.Point(-4, -2);
            this.btCl.Name = "btCl";
            this.btCl.Size = new System.Drawing.Size(175, 36);
            this.btCl.TabIndex = 4;
            this.btCl.Text = "Client";
            this.btCl.UseVisualStyleBackColor = false;
            this.btCl.Click += new System.EventHandler(this.btCl_Click);
            // 
            // checkstatus
            // 
            this.checkstatus.AutoSize = true;
            this.checkstatus.Location = new System.Drawing.Point(12, 306);
            this.checkstatus.Name = "checkstatus";
            this.checkstatus.Size = new System.Drawing.Size(18, 17);
            this.checkstatus.TabIndex = 5;
            this.checkstatus.UseVisualStyleBackColor = true;
            this.checkstatus.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(644, 343);
            this.Controls.Add(this.checkstatus);
            this.Controls.Add(this.btCl);
            this.Controls.Add(this.btmn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbmdp;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btmn;
        private System.Windows.Forms.Button btCl;
        private System.Windows.Forms.CheckBox checkstatus;
    }
}