namespace _20221003
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSum = new System.Windows.Forms.Button();
            this.felirat1 = new System.Windows.Forms.Label();
            this.szam1 = new System.Windows.Forms.TextBox();
            this.szam2 = new System.Windows.Forms.TextBox();
            this.felirat2 = new System.Windows.Forms.Label();
            this.Eredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(340, 92);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Összead";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // felirat1
            // 
            this.felirat1.AutoSize = true;
            this.felirat1.Location = new System.Drawing.Point(54, 100);
            this.felirat1.Name = "felirat1";
            this.felirat1.Size = new System.Drawing.Size(41, 15);
            this.felirat1.TabIndex = 2;
            this.felirat1.Text = "Szám1";
            // 
            // szam1
            // 
            this.szam1.Location = new System.Drawing.Point(148, 92);
            this.szam1.Name = "szam1";
            this.szam1.Size = new System.Drawing.Size(100, 23);
            this.szam1.TabIndex = 3;
            // 
            // szam2
            // 
            this.szam2.Location = new System.Drawing.Point(148, 148);
            this.szam2.Name = "szam2";
            this.szam2.Size = new System.Drawing.Size(100, 23);
            this.szam2.TabIndex = 4;
            // 
            // felirat2
            // 
            this.felirat2.AutoSize = true;
            this.felirat2.Location = new System.Drawing.Point(54, 156);
            this.felirat2.Name = "felirat2";
            this.felirat2.Size = new System.Drawing.Size(41, 15);
            this.felirat2.TabIndex = 5;
            this.felirat2.Text = "Szám2";
            // 
            // Eredmeny
            // 
            this.Eredmeny.AutoSize = true;
            this.Eredmeny.Location = new System.Drawing.Point(345, 151);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(0, 15);
            this.Eredmeny.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.felirat2);
            this.Controls.Add(this.szam2);
            this.Controls.Add(this.szam1);
            this.Controls.Add(this.felirat1);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSum;
        private Label felirat1;
        private TextBox szam1;
        private TextBox szam2;
        private Label felirat2;
        private Label Eredmeny;
    }
}