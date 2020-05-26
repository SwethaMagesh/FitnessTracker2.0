namespace FitnessTracker2._0
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.SendMail = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GoLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(424, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(322, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Username";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(519, 133);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(168, 20);
            this.Usertxt.TabIndex = 3;
            this.Usertxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SendMail
            // 
            this.SendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SendMail.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendMail.Location = new System.Drawing.Point(357, 208);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(140, 54);
            this.SendMail.TabIndex = 5;
            this.SendMail.Text = "Send Mail";
            this.SendMail.UseVisualStyleBackColor = false;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(328, 409);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(0, 19);
            this.LblText.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FitnessTracker2._0.Properties.Resources.WhatsApp_Image_2020_05_21_at_13_10_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 369);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GoLogin
            // 
            this.GoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GoLogin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.GoLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoLogin.Location = new System.Drawing.Point(559, 208);
            this.GoLogin.Name = "GoLogin";
            this.GoLogin.Size = new System.Drawing.Size(128, 54);
            this.GoLogin.TabIndex = 8;
            this.GoLogin.Text = "Go to Login";
            this.GoLogin.UseVisualStyleBackColor = false;
            this.GoLogin.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 369);
            this.Controls.Add(this.GoLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GoLogin;
    }
}