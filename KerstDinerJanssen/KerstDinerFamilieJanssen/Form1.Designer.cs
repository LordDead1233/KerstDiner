namespace KerstDinerFamilieJanssen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbBereidVoor = new System.Windows.Forms.TextBox();
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSoortEten = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWatWordtVoorbereid = new System.Windows.Forms.ListBox();
            this.btnVerwijderGerecht = new System.Windows.Forms.Button();
            this.btnPasGerechtAan = new System.Windows.Forms.Button();
            this.gbGeselecteerdGerecht = new System.Windows.Forms.GroupBox();
            this.btnPasAan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNieuwBereidVoor = new System.Windows.Forms.TextBox();
            this.tbNieuwNaam = new System.Windows.Forms.TextBox();
            this.cbNieuwSoortEten = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGeselecteerdGerecht.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bereid voor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soort Eten:";
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(76, 38);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(100, 20);
            this.tbVoornaam.TabIndex = 4;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(76, 64);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(100, 20);
            this.tbAchternaam.TabIndex = 5;
            // 
            // tbBereidVoor
            // 
            this.tbBereidVoor.Location = new System.Drawing.Point(76, 90);
            this.tbBereidVoor.Name = "tbBereidVoor";
            this.tbBereidVoor.Size = new System.Drawing.Size(100, 20);
            this.tbBereidVoor.TabIndex = 6;
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(76, 143);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(100, 23);
            this.btnInschrijven.TabIndex = 8;
            this.btnInschrijven.Text = "Inschrijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            this.btnInschrijven.Click += new System.EventHandler(this.btnInschrijven_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cbSoortEten
            // 
            this.cbSoortEten.FormattingEnabled = true;
            this.cbSoortEten.Items.AddRange(new object[] {
            "Hoofdgerecht",
            "Voorgerecht",
            "Dessert",
            "Hapjes"});
            this.cbSoortEten.Location = new System.Drawing.Point(76, 116);
            this.cbSoortEten.Name = "cbSoortEten";
            this.cbSoortEten.Size = new System.Drawing.Size(100, 21);
            this.cbSoortEten.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wat al wordt voorbereid";
            // 
            // lbWatWordtVoorbereid
            // 
            this.lbWatWordtVoorbereid.FormattingEnabled = true;
            this.lbWatWordtVoorbereid.Location = new System.Drawing.Point(191, 38);
            this.lbWatWordtVoorbereid.Name = "lbWatWordtVoorbereid";
            this.lbWatWordtVoorbereid.Size = new System.Drawing.Size(275, 394);
            this.lbWatWordtVoorbereid.TabIndex = 12;
            // 
            // btnVerwijderGerecht
            // 
            this.btnVerwijderGerecht.Location = new System.Drawing.Point(473, 38);
            this.btnVerwijderGerecht.Name = "btnVerwijderGerecht";
            this.btnVerwijderGerecht.Size = new System.Drawing.Size(174, 23);
            this.btnVerwijderGerecht.TabIndex = 13;
            this.btnVerwijderGerecht.Text = "Verwijder geselecteerd gerecht";
            this.btnVerwijderGerecht.UseVisualStyleBackColor = true;
            this.btnVerwijderGerecht.Click += new System.EventHandler(this.btnVerwijderGerecht_Click);
            // 
            // btnPasGerechtAan
            // 
            this.btnPasGerechtAan.Location = new System.Drawing.Point(472, 107);
            this.btnPasGerechtAan.Name = "btnPasGerechtAan";
            this.btnPasGerechtAan.Size = new System.Drawing.Size(174, 23);
            this.btnPasGerechtAan.TabIndex = 14;
            this.btnPasGerechtAan.Text = "Pas geselecteerd gerecht aan";
            this.btnPasGerechtAan.UseVisualStyleBackColor = true;
            this.btnPasGerechtAan.Click += new System.EventHandler(this.btnPasGerechtAan_Click);
            // 
            // gbGeselecteerdGerecht
            // 
            this.gbGeselecteerdGerecht.Controls.Add(this.cbNieuwSoortEten);
            this.gbGeselecteerdGerecht.Controls.Add(this.btnPasAan);
            this.gbGeselecteerdGerecht.Controls.Add(this.label8);
            this.gbGeselecteerdGerecht.Controls.Add(this.label7);
            this.gbGeselecteerdGerecht.Controls.Add(this.label6);
            this.gbGeselecteerdGerecht.Controls.Add(this.tbNieuwBereidVoor);
            this.gbGeselecteerdGerecht.Controls.Add(this.tbNieuwNaam);
            this.gbGeselecteerdGerecht.Location = new System.Drawing.Point(472, 136);
            this.gbGeselecteerdGerecht.Name = "gbGeselecteerdGerecht";
            this.gbGeselecteerdGerecht.Size = new System.Drawing.Size(187, 201);
            this.gbGeselecteerdGerecht.TabIndex = 15;
            this.gbGeselecteerdGerecht.TabStop = false;
            this.gbGeselecteerdGerecht.Text = "Geselecteerd Gerecht";
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(26, 172);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(127, 23);
            this.btnPasAan.TabIndex = 21;
            this.btnPasAan.Text = "Pas aan";
            this.btnPasAan.UseVisualStyleBackColor = true;
            this.btnPasAan.Click += new System.EventHandler(this.btnPasAan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Soort Eten:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bereid Voor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Naam:";
            // 
            // tbNieuwBereidVoor
            // 
            this.tbNieuwBereidVoor.Location = new System.Drawing.Point(23, 90);
            this.tbNieuwBereidVoor.Name = "tbNieuwBereidVoor";
            this.tbNieuwBereidVoor.Size = new System.Drawing.Size(100, 20);
            this.tbNieuwBereidVoor.TabIndex = 16;
            // 
            // tbNieuwNaam
            // 
            this.tbNieuwNaam.Location = new System.Drawing.Point(23, 51);
            this.tbNieuwNaam.Name = "tbNieuwNaam";
            this.tbNieuwNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNieuwNaam.TabIndex = 15;
            // 
            // cbNieuwSoortEten
            // 
            this.cbNieuwSoortEten.FormattingEnabled = true;
            this.cbNieuwSoortEten.Items.AddRange(new object[] {
            "Hoofdgerecht",
            "Voorgerecht",
            "Dessert",
            "Hapjes"});
            this.cbNieuwSoortEten.Location = new System.Drawing.Point(23, 129);
            this.cbNieuwSoortEten.Name = "cbNieuwSoortEten";
            this.cbNieuwSoortEten.Size = new System.Drawing.Size(100, 21);
            this.cbNieuwSoortEten.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 445);
            this.Controls.Add(this.gbGeselecteerdGerecht);
            this.Controls.Add(this.btnVerwijderGerecht);
            this.Controls.Add(this.lbWatWordtVoorbereid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSoortEten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPasGerechtAan);
            this.Controls.Add(this.btnInschrijven);
            this.Controls.Add(this.tbBereidVoor);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Familie Diner Familie Janssen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGeselecteerdGerecht.ResumeLayout(false);
            this.gbGeselecteerdGerecht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbBereidVoor;
        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSoortEten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbWatWordtVoorbereid;
        private System.Windows.Forms.Button btnVerwijderGerecht;
        private System.Windows.Forms.Button btnPasGerechtAan;
        private System.Windows.Forms.GroupBox gbGeselecteerdGerecht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNieuwBereidVoor;
        private System.Windows.Forms.TextBox tbNieuwNaam;
        private System.Windows.Forms.Button btnPasAan;
        private System.Windows.Forms.ComboBox cbNieuwSoortEten;
    }
}

