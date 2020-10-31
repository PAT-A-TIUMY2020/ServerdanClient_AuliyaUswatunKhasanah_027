namespace Client_AuliyaUswatunKhasanah_027
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
            this.hasilbagi = new System.Windows.Forms.Label();
            this.hasilkali = new System.Windows.Forms.Label();
            this.hasilkurang = new System.Windows.Forms.Label();
            this.hasiljumlah = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.angka2 = new System.Windows.Forms.Label();
            this.angka1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.Label();
            this.kurang = new System.Windows.Forms.Label();
            this.kali = new System.Windows.Forms.Label();
            this.bagi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hasilbagi
            // 
            this.hasilbagi.AutoSize = true;
            this.hasilbagi.Location = new System.Drawing.Point(387, 247);
            this.hasilbagi.Name = "hasilbagi";
            this.hasilbagi.Size = new System.Drawing.Size(115, 17);
            this.hasilbagi.TabIndex = 15;
            this.hasilbagi.Text = "Hail Pembagian :";
            // 
            // hasilkali
            // 
            this.hasilkali.AutoSize = true;
            this.hasilkali.Location = new System.Drawing.Point(387, 213);
            this.hasilkali.Name = "hasilkali";
            this.hasilkali.Size = new System.Drawing.Size(103, 17);
            this.hasilkali.TabIndex = 14;
            this.hasilkali.Text = "Hail Perkalian :";
            // 
            // hasilkurang
            // 
            this.hasilkurang.AutoSize = true;
            this.hasilkurang.Location = new System.Drawing.Point(387, 183);
            this.hasilkurang.Name = "hasilkurang";
            this.hasilkurang.Size = new System.Drawing.Size(137, 17);
            this.hasilkurang.TabIndex = 13;
            this.hasilkurang.Text = "Hasil Pengurangan :";
            // 
            // hasiljumlah
            // 
            this.hasiljumlah.AutoSize = true;
            this.hasiljumlah.Location = new System.Drawing.Point(387, 147);
            this.hasiljumlah.Name = "hasiljumlah";
            this.hasiljumlah.Size = new System.Drawing.Size(133, 17);
            this.hasiljumlah.TabIndex = 12;
            this.hasiljumlah.Text = "Hasil Penjumlahan :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 11;
            // 
            // angka2
            // 
            this.angka2.AutoSize = true;
            this.angka2.Location = new System.Drawing.Point(148, 233);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(60, 17);
            this.angka2.TabIndex = 10;
            this.angka2.Text = "Angka 2";
            // 
            // angka1
            // 
            this.angka1.AutoSize = true;
            this.angka1.Location = new System.Drawing.Point(148, 147);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(60, 17);
            this.angka1.TabIndex = 9;
            this.angka1.Text = "Angka 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 8;
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Location = new System.Drawing.Point(527, 146);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(0, 17);
            this.jumlah.TabIndex = 16;
            // 
            // kurang
            // 
            this.kurang.AutoSize = true;
            this.kurang.Location = new System.Drawing.Point(531, 183);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(0, 17);
            this.kurang.TabIndex = 17;
            // 
            // kali
            // 
            this.kali.AutoSize = true;
            this.kali.Location = new System.Drawing.Point(497, 213);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(0, 17);
            this.kali.TabIndex = 18;
            // 
            // bagi
            // 
            this.bagi.AutoSize = true;
            this.bagi.Location = new System.Drawing.Point(508, 247);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(0, 17);
            this.bagi.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.hasilbagi);
            this.Controls.Add(this.hasilkali);
            this.Controls.Add(this.hasilkurang);
            this.Controls.Add(this.hasiljumlah);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hasilbagi;
        private System.Windows.Forms.Label hasilkali;
        private System.Windows.Forms.Label hasilkurang;
        private System.Windows.Forms.Label hasiljumlah;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label angka2;
        private System.Windows.Forms.Label angka1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.Label kurang;
        private System.Windows.Forms.Label kali;
        private System.Windows.Forms.Label bagi;
    }
}

