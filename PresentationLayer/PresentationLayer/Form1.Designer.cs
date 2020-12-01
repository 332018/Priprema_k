namespace PresentationLayer
{
    partial class FormIspis
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
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.labelProsek = new System.Windows.Forms.Label();
            this.textBoxProsek = new System.Windows.Forms.TextBox();
            this.buttonVrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.ItemHeight = 20;
            this.listBoxIspis.Location = new System.Drawing.Point(13, 159);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(290, 204);
            this.listBoxIspis.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(39, 103);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 38);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(31, 13);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(36, 20);
            this.labelIme.TabIndex = 3;
            this.labelIme.Text = "Ime";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(35, 63);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(48, 20);
            this.labelIndex.TabIndex = 4;
            this.labelIndex.Text = "Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(402, 25);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(56, 20);
            this.labelOcena.TabIndex = 6;
            this.labelOcena.Text = "Ocena";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(101, 13);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 26);
            this.textBoxIme.TabIndex = 7;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(101, 56);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 26);
            this.textBoxIndex.TabIndex = 8;
            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(489, 25);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(100, 26);
            this.textBoxOcena.TabIndex = 9;
            // 
            // labelProsek
            // 
            this.labelProsek.AutoSize = true;
            this.labelProsek.Location = new System.Drawing.Point(315, 61);
            this.labelProsek.Name = "labelProsek";
            this.labelProsek.Size = new System.Drawing.Size(58, 20);
            this.labelProsek.TabIndex = 10;
            this.labelProsek.Text = "Prosek";
            // 
            // textBoxProsek
            // 
            this.textBoxProsek.Location = new System.Drawing.Point(402, 63);
            this.textBoxProsek.Name = "textBoxProsek";
            this.textBoxProsek.Size = new System.Drawing.Size(100, 26);
            this.textBoxProsek.TabIndex = 11;
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(575, 86);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(75, 40);
            this.buttonVrati.TabIndex = 12;
            this.buttonVrati.Text = "Vrati";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.buttonVrati_Click);
            // 
            // FormIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVrati);
            this.Controls.Add(this.textBoxProsek);
            this.Controls.Add(this.labelProsek);
            this.Controls.Add(this.textBoxOcena);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.listBoxIspis);
            this.Name = "FormIspis";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.FormIspis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIspis;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.Label labelProsek;
        private System.Windows.Forms.TextBox textBoxProsek;
        private System.Windows.Forms.Button buttonVrati;
    }
}

