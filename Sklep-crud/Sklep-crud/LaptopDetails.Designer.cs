namespace Sklep_crud
{
    partial class LaptopDetails
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
            this.Procesor = new System.Windows.Forms.Label();
            this.Ram = new System.Windows.Forms.Label();
            this.HDD = new System.Windows.Forms.Label();
            this.Ekran = new System.Windows.Forms.Label();
            this.Cena = new System.Windows.Forms.Label();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Procesor
            // 
            this.Procesor.AutoSize = true;
            this.Procesor.Location = new System.Drawing.Point(12, 9);
            this.Procesor.Name = "Procesor";
            this.Procesor.Size = new System.Drawing.Size(49, 13);
            this.Procesor.TabIndex = 0;
            this.Procesor.Text = "Procesor";
            // 
            // Ram
            // 
            this.Ram.AutoSize = true;
            this.Ram.Location = new System.Drawing.Point(12, 35);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(29, 13);
            this.Ram.TabIndex = 1;
            this.Ram.Text = "Ram";
            // 
            // HDD
            // 
            this.HDD.AutoSize = true;
            this.HDD.Location = new System.Drawing.Point(12, 61);
            this.HDD.Name = "HDD";
            this.HDD.Size = new System.Drawing.Size(31, 13);
            this.HDD.TabIndex = 2;
            this.HDD.Text = "HDD";
            // 
            // Ekran
            // 
            this.Ekran.AutoSize = true;
            this.Ekran.Location = new System.Drawing.Point(12, 87);
            this.Ekran.Name = "Ekran";
            this.Ekran.Size = new System.Drawing.Size(35, 13);
            this.Ekran.TabIndex = 3;
            this.Ekran.Text = "Ekran";
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(12, 113);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(32, 13);
            this.Cena.TabIndex = 4;
            this.Cena.Text = "Cena";
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(108, 1);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(100, 20);
            this.txtProcesor.TabIndex = 6;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(108, 32);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(100, 20);
            this.txtRam.TabIndex = 7;
            // 
            // txtHDD
            // 
            this.txtHDD.Location = new System.Drawing.Point(108, 58);
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.Size = new System.Drawing.Size(100, 20);
            this.txtHDD.TabIndex = 8;
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(108, 84);
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(100, 20);
            this.txtEkran.TabIndex = 9;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(108, 110);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(154, 177);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // LaptopDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 261);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.txtHDD);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtProcesor);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.Ekran);
            this.Controls.Add(this.HDD);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.Procesor);
            this.Name = "LaptopDetails";
            this.Text = "LaptopSzczegóły";
            this.Load += new System.EventHandler(this.LaptopDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Procesor;
        private System.Windows.Forms.Label Ram;
        private System.Windows.Forms.Label HDD;
        private System.Windows.Forms.Label Ekran;
        private System.Windows.Forms.Label Cena;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button Save;
    }
}