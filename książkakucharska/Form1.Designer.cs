namespace książkakucharska
{
    partial class Form1
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
            this.warzywa = new System.Windows.Forms.CheckedListBox();
            this.mięso = new System.Windows.Forms.CheckedListBox();
            this.nabiał = new System.Windows.Forms.CheckedListBox();
            this.zboża = new System.Windows.Forms.CheckedListBox();
            this.inne = new System.Windows.Forms.CheckedListBox();
            this.dzialanie = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // warzywa
            // 
            this.warzywa.FormattingEnabled = true;
            this.warzywa.Items.AddRange(new object[] {
            "pomidory",
            "kapusta pekińska",
            "ogórki kiszone",
            "kukurydza",
            "kiszona kapusta",
            "ziemniaki",
            "cebula",
            "marchewka",
            "ogórek świeży",
            "sałata"});
            this.warzywa.Location = new System.Drawing.Point(12, 12);
            this.warzywa.Name = "warzywa";
            this.warzywa.Size = new System.Drawing.Size(120, 169);
            this.warzywa.TabIndex = 1;
            // 
            // mięso
            // 
            this.mięso.FormattingEnabled = true;
            this.mięso.Items.AddRange(new object[] {
            "wieprzowina",
            "kurczak",
            "kiełbasa",
            "ryba"});
            this.mięso.Location = new System.Drawing.Point(138, 12);
            this.mięso.Name = "mięso";
            this.mięso.Size = new System.Drawing.Size(120, 169);
            this.mięso.TabIndex = 2;
            // 
            // nabiał
            // 
            this.nabiał.FormattingEnabled = true;
            this.nabiał.Items.AddRange(new object[] {
            "jajka",
            "ser",
            "śmietana"});
            this.nabiał.Location = new System.Drawing.Point(264, 12);
            this.nabiał.Name = "nabiał";
            this.nabiał.Size = new System.Drawing.Size(120, 169);
            this.nabiał.TabIndex = 3;
            // 
            // zboża
            // 
            this.zboża.FormattingEnabled = true;
            this.zboża.Items.AddRange(new object[] {
            "makaron",
            "mąka",
            "placek pszenny"});
            this.zboża.Location = new System.Drawing.Point(390, 12);
            this.zboża.Name = "zboża";
            this.zboża.Size = new System.Drawing.Size(120, 169);
            this.zboża.TabIndex = 4;
            // 
            // inne
            // 
            this.inne.FormattingEnabled = true;
            this.inne.Items.AddRange(new object[] {
            "przecier pomidorowy",
            "ketchup",
            "majonez",
            "przyprawa do mięsa",
            "koncentrat pomidorowy",
            "sos pomidorowy",
            "cukier"});
            this.inne.Location = new System.Drawing.Point(516, 12);
            this.inne.Name = "inne";
            this.inne.Size = new System.Drawing.Size(135, 169);
            this.inne.TabIndex = 6;
            // 
            // dzialanie
            // 
            this.dzialanie.Location = new System.Drawing.Point(390, 237);
            this.dzialanie.Name = "dzialanie";
            this.dzialanie.Size = new System.Drawing.Size(75, 23);
            this.dzialanie.TabIndex = 7;
            this.dzialanie.Text = "dzialaj";
            this.dzialanie.UseVisualStyleBackColor = true;
            this.dzialanie.Click += new System.EventHandler(this.dzialanie_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(600, 218);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 175);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 405);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dzialanie);
            this.Controls.Add(this.inne);
            this.Controls.Add(this.zboża);
            this.Controls.Add(this.nabiał);
            this.Controls.Add(this.mięso);
            this.Controls.Add(this.warzywa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox warzywa;
        private System.Windows.Forms.CheckedListBox mięso;
        private System.Windows.Forms.CheckedListBox nabiał;
        private System.Windows.Forms.CheckedListBox zboża;
        private System.Windows.Forms.CheckedListBox inne;
        private System.Windows.Forms.Button dzialanie;
        private System.Windows.Forms.ListView listView1;
    }
}

