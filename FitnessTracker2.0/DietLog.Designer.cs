using System;

namespace FitnessTracker2._0
{
    partial class DietLog
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dietsubmit = new System.Windows.Forms.Button();
            this.remarks = new System.Windows.Forms.TextBox();
            this.serving_no = new System.Windows.Forms.NumericUpDown();
            this.diet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diettoday = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cal_in = new System.Windows.Forms.TextBox();
            this.fat_in = new System.Windows.Forms.TextBox();
            this.vitamin_in = new System.Windows.Forms.TextBox();
            this.protein_in = new System.Windows.Forms.TextBox();
            this.carbo_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serving_no)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dietsubmit);
            this.panel1.Controls.Add(this.remarks);
            this.panel1.Controls.Add(this.serving_no);
            this.panel1.Controls.Add(this.diet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 212);
            this.panel1.TabIndex = 0;
            // 
            // dietsubmit
            // 
            this.dietsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dietsubmit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietsubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.dietsubmit.Location = new System.Drawing.Point(388, 90);
            this.dietsubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dietsubmit.Name = "dietsubmit";
            this.dietsubmit.Size = new System.Drawing.Size(133, 75);
            this.dietsubmit.TabIndex = 8;
            this.dietsubmit.Text = "Add in my log";
            this.dietsubmit.UseVisualStyleBackColor = false;
            this.dietsubmit.Click += new System.EventHandler(this.dietsubmit_Click_1);
            // 
            // remarks
            // 
            this.remarks.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.remarks.Location = new System.Drawing.Point(246, 171);
            this.remarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(112, 30);
            this.remarks.TabIndex = 7;
            // 
            // serving_no
            // 
            this.serving_no.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.serving_no.Location = new System.Drawing.Point(246, 112);
            this.serving_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serving_no.Name = "serving_no";
            this.serving_no.Size = new System.Drawing.Size(112, 30);
            this.serving_no.TabIndex = 6;
            // 
            // diet
            // 
            this.diet.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.diet.FormattingEnabled = true;
            this.diet.Location = new System.Drawing.Point(246, 58);
            this.diet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diet.Name = "diet";
            this.diet.Size = new System.Drawing.Size(112, 31);
            this.diet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "No of serving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diet Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(160, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD NEW ITEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diettoday);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(583, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 522);
            this.panel2.TabIndex = 1;
            // 
            // diettoday
            // 
            this.diettoday.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diettoday.FormattingEnabled = true;
            this.diettoday.Location = new System.Drawing.Point(24, 80);
            this.diettoday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diettoday.Name = "diettoday";
            this.diettoday.Size = new System.Drawing.Size(246, 235);
            this.diettoday.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALREADY TAKEN TODAY";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cal_in);
            this.panel3.Controls.Add(this.fat_in);
            this.panel3.Controls.Add(this.vitamin_in);
            this.panel3.Controls.Add(this.protein_in);
            this.panel3.Controls.Add(this.carbo_in);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(15, 236);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 302);
            this.panel3.TabIndex = 2;
            // 
            // cal_in
            // 
            this.cal_in.Location = new System.Drawing.Point(246, 258);
            this.cal_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cal_in.Name = "cal_in";
            this.cal_in.Size = new System.Drawing.Size(112, 26);
            this.cal_in.TabIndex = 12;
            this.cal_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fat_in
            // 
            this.fat_in.Location = new System.Drawing.Point(246, 208);
            this.fat_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fat_in.Name = "fat_in";
            this.fat_in.Size = new System.Drawing.Size(112, 26);
            this.fat_in.TabIndex = 10;
            this.fat_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vitamin_in
            // 
            this.vitamin_in.Location = new System.Drawing.Point(246, 159);
            this.vitamin_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vitamin_in.Name = "vitamin_in";
            this.vitamin_in.Size = new System.Drawing.Size(112, 26);
            this.vitamin_in.TabIndex = 9;
            this.vitamin_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // protein_in
            // 
            this.protein_in.Location = new System.Drawing.Point(246, 111);
            this.protein_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.protein_in.Name = "protein_in";
            this.protein_in.Size = new System.Drawing.Size(112, 26);
            this.protein_in.TabIndex = 8;
            this.protein_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // carbo_in
            // 
            this.carbo_in.Location = new System.Drawing.Point(246, 60);
            this.carbo_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carbo_in.Name = "carbo_in";
            this.carbo_in.Size = new System.Drawing.Size(112, 26);
            this.carbo_in.TabIndex = 7;
            this.carbo_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "Calories";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Vitamins";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Protein";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Carbohydrates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(130, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "NUTRIENT INTAKE TODAY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 546);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(402, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "***All nutrients are in unit g per serving";
            // 
            // DietLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(885, 588);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DietLog";
            this.Text = "DietLog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serving_no)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.NumericUpDown serving_no;
        private System.Windows.Forms.ComboBox diet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox diettoday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dietsubmit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox cal_in;
        private System.Windows.Forms.TextBox fat_in;
        private System.Windows.Forms.TextBox vitamin_in;
        private System.Windows.Forms.TextBox protein_in;
        private System.Windows.Forms.TextBox carbo_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;

        public EventHandler label11_Click { get; private set; }
    }
}