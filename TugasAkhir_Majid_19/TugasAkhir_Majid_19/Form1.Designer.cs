namespace TugasAkhir_Majid_19
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Red;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Font = new System.Drawing.Font("Brandon Grotesque Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Aqua;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(681, 46);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Program Penghitung Luas Bangun Datar";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox8.Font = new System.Drawing.Font("Brandon Grotesque Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.Location = new System.Drawing.Point(12, 72);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(171, 26);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Masukan pilihan bangun :";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox10.Font = new System.Drawing.Font("Brandon Grotesque Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox10.Location = new System.Drawing.Point(12, 120);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(262, 46);
            this.textBox10.TabIndex = 2;
            this.textBox10.Text = "Masukan nilai :\r\n(Sisi/Panjang/Alas/Diagonal1/Jari-Jari)";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox11.Font = new System.Drawing.Font("Brandon Grotesque Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox11.Location = new System.Drawing.Point(12, 184);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(262, 46);
            this.textBox11.TabIndex = 3;
            this.textBox11.Text = "Masukan nilai :\r\n(Sisi/Lebar/Tinggi/Diagonal2/Jari-Jari)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Brandon Grotesque Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "HITUNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Brandon Grotesque Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Gold;
            this.textBox12.Font = new System.Drawing.Font("Brandon Grotesque Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Indigo;
            this.textBox12.Location = new System.Drawing.Point(224, 325);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(75, 35);
            this.textBox12.TabIndex = 6;
            this.textBox12.Text = "Hasil :";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Brandon Grotesque Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(366, 330);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(214, 30);
            this.textBox13.TabIndex = 7;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Brandon Grotesque Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(366, 128);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(214, 30);
            this.textBox14.TabIndex = 8;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox14_KeyPress);
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Brandon Grotesque Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(366, 192);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(214, 30);
            this.textBox15.TabIndex = 9;
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox15_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Brandon Grotesque Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Belah Ketupat",
            "Jajar Genjang",
            "Layang-Layang",
            "Lingkaran",
            "Persegi",
            "Persegi Panjang",
            "Segitiga"});
            this.comboBox1.Location = new System.Drawing.Point(366, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 27);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Pilih Bangun Datar";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 382);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox Judul;
        private System.Windows.Forms.ComboBox Pil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox masuk1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox masuk2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

