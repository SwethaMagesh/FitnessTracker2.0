namespace FitnessTracker2._0
{
    partial class ChangePassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentPWD = new System.Windows.Forms.TextBox();
            this.ConfirmPWD = new System.Windows.Forms.TextBox();
            this.NewPWD = new System.Windows.Forms.TextBox();
            this.UpdatePWD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(279, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(168, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label3.Location = new System.Drawing.Point(168, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label4.Location = new System.Drawing.Point(169, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // CurrentPWD
            // 
            this.CurrentPWD.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CurrentPWD.Location = new System.Drawing.Point(493, 160);
            this.CurrentPWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentPWD.Name = "CurrentPWD";
            this.CurrentPWD.Size = new System.Drawing.Size(169, 35);
            this.CurrentPWD.TabIndex = 4;
            this.CurrentPWD.UseSystemPasswordChar = true;
            this.CurrentPWD.TextChanged += new System.EventHandler(this.CurrentPWD_TextChanged);
            // 
            // ConfirmPWD
            // 
            this.ConfirmPWD.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ConfirmPWD.Location = new System.Drawing.Point(493, 339);
            this.ConfirmPWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmPWD.Name = "ConfirmPWD";
            this.ConfirmPWD.Size = new System.Drawing.Size(169, 35);
            this.ConfirmPWD.TabIndex = 5;
            this.ConfirmPWD.UseSystemPasswordChar = true;
            this.ConfirmPWD.TextChanged += new System.EventHandler(this.ConfirmPWD_TextChanged);
            // 
            // NewPWD
            // 
            this.NewPWD.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NewPWD.Location = new System.Drawing.Point(493, 243);
            this.NewPWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewPWD.Name = "NewPWD";
            this.NewPWD.Size = new System.Drawing.Size(169, 35);
            this.NewPWD.TabIndex = 6;
            this.NewPWD.UseSystemPasswordChar = true;
            this.NewPWD.TextChanged += new System.EventHandler(this.NewPWD_TextChanged);
            // 
            // UpdatePWD
            // 
            this.UpdatePWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdatePWD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePWD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdatePWD.Location = new System.Drawing.Point(353, 448);
            this.UpdatePWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdatePWD.Name = "UpdatePWD";
            this.UpdatePWD.Size = new System.Drawing.Size(195, 71);
            this.UpdatePWD.TabIndex = 7;
            this.UpdatePWD.Text = "Update";
            this.UpdatePWD.UseVisualStyleBackColor = false;
            this.UpdatePWD.Click += new System.EventHandler(this.UpdatePWD_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(876, 539);
            this.Controls.Add(this.UpdatePWD);
            this.Controls.Add(this.NewPWD);
            this.Controls.Add(this.ConfirmPWD);
            this.Controls.Add(this.CurrentPWD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentPWD;
        private System.Windows.Forms.TextBox ConfirmPWD;
        private System.Windows.Forms.TextBox NewPWD;
        private System.Windows.Forms.Button UpdatePWD;
    }
}