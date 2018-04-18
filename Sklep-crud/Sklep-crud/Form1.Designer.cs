namespace Sklep_crud
{
    partial class FormStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenLaptopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenLaptopy
            // 
            this.OpenLaptopy.Location = new System.Drawing.Point(52, 49);
            this.OpenLaptopy.Name = "OpenLaptopy";
            this.OpenLaptopy.Size = new System.Drawing.Size(168, 104);
            this.OpenLaptopy.TabIndex = 0;
            this.OpenLaptopy.Text = "Laptopy";
            this.OpenLaptopy.UseVisualStyleBackColor = true;
            this.OpenLaptopy.Click += new System.EventHandler(this.OpenLaptopy_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 514);
            this.Controls.Add(this.OpenLaptopy);
            this.Name = "FormStart";
            this.Text = "Formularz startowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenLaptopy;
    }
}

