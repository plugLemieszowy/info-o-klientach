namespace Info_o_klientach
{
    partial class StronaGlowna
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
            this.otworz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.zapisz = new System.Windows.Forms.Button();
            this.wybierz = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.edytuj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // otworz
            // 
            this.otworz.Location = new System.Drawing.Point(1899, 28);
            this.otworz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otworz.Name = "otworz";
            this.otworz.Size = new System.Drawing.Size(139, 31);
            this.otworz.TabIndex = 0;
            this.otworz.Text = "Otwórz plik";
            this.otworz.UseVisualStyleBackColor = true;
            this.otworz.Click += new System.EventHandler(this.otworz_plik);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID klienta";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(465, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(619, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kod pocztowy";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1245, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numer nakładki";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(775, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numer wodomierza";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(930, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kraj";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1090, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data instalacji";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(1555, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "ID wodociągów";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1400, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Odczyty godzinowe ";
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(1899, 65);
            this.zapisz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(139, 31);
            this.zapisz.TabIndex = 12;
            this.zapisz.Text = "Zapisz plik";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_plik);
            // 
            // wybierz
            // 
            this.wybierz.Location = new System.Drawing.Point(1899, 137);
            this.wybierz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wybierz.Name = "wybierz";
            this.wybierz.Size = new System.Drawing.Size(139, 31);
            this.wybierz.TabIndex = 14;
            this.wybierz.Text = "Wybierz klineta";
            this.wybierz.UseVisualStyleBackColor = true;
            this.wybierz.Click += new System.EventHandler(this.wybierz_klienta);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(1899, 102);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(139, 31);
            this.dodaj.TabIndex = 13;
            this.dodaj.Text = "Dodaj wpis";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_wpis);
            // 
            // edytuj
            // 
            this.edytuj.Location = new System.Drawing.Point(1899, 173);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(139, 31);
            this.edytuj.TabIndex = 16;
            this.edytuj.Text = "Edytuj linie";
            this.edytuj.UseVisualStyleBackColor = true;
            this.edytuj.Click += new System.EventHandler(this.edytuj_linie);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1890, 1000);
            this.panel1.TabIndex = 17;
            // 
            // StronaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.wybierz);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otworz);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StronaGlowna";
            this.Text = "Nazwa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
         
        private System.Windows.Forms.Button otworz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Button wybierz;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Panel panel1;
    }
}

