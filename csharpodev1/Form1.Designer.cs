namespace csharpodev1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblkullanilanharfler = new System.Windows.Forms.Label();
            this.numHarfSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_basla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelkalanhak = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtharfgir = new System.Windows.Forms.TextBox();
            this.button_gir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelskor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttoncikar = new System.Windows.Forms.Button();
            this.txtkelimegir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonoyunabasla = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarfSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblkullanilanharfler);
            this.panel2.Location = new System.Drawing.Point(406, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 67);
            this.panel2.TabIndex = 1;
            // 
            // lblkullanilanharfler
            // 
            this.lblkullanilanharfler.AutoSize = true;
            this.lblkullanilanharfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanilanharfler.Location = new System.Drawing.Point(4, 4);
            this.lblkullanilanharfler.Name = "lblkullanilanharfler";
            this.lblkullanilanharfler.Size = new System.Drawing.Size(0, 20);
            this.lblkullanilanharfler.TabIndex = 0;
            // 
            // numHarfSayisi
            // 
            this.numHarfSayisi.Enabled = false;
            this.numHarfSayisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numHarfSayisi.Location = new System.Drawing.Point(335, 75);
            this.numHarfSayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHarfSayisi.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numHarfSayisi.Name = "numHarfSayisi";
            this.numHarfSayisi.Size = new System.Drawing.Size(48, 20);
            this.numHarfSayisi.TabIndex = 3;
            this.numHarfSayisi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Harf Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(625, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanılan Harfler";
            // 
            // button_basla
            // 
            this.button_basla.Enabled = false;
            this.button_basla.Location = new System.Drawing.Point(279, 116);
            this.button_basla.Name = "button_basla";
            this.button_basla.Size = new System.Drawing.Size(75, 23);
            this.button_basla.TabIndex = 6;
            this.button_basla.Text = "Başla";
            this.button_basla.UseVisualStyleBackColor = true;
            this.button_basla.Click += new System.EventHandler(this.button_basla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(625, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aranılan Kelime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalan Hak Sayısı :";
            // 
            // labelkalanhak
            // 
            this.labelkalanhak.AutoSize = true;
            this.labelkalanhak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkalanhak.Location = new System.Drawing.Point(266, 198);
            this.labelkalanhak.Name = "labelkalanhak";
            this.labelkalanhak.Size = new System.Drawing.Size(0, 16);
            this.labelkalanhak.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(423, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Harf Girin";
            // 
            // txtharfgir
            // 
            this.txtharfgir.Enabled = false;
            this.txtharfgir.Location = new System.Drawing.Point(406, 142);
            this.txtharfgir.MaxLength = 1;
            this.txtharfgir.Name = "txtharfgir";
            this.txtharfgir.Size = new System.Drawing.Size(107, 20);
            this.txtharfgir.TabIndex = 11;
            this.txtharfgir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharfgir_KeyPress);
            // 
            // button_gir
            // 
            this.button_gir.Enabled = false;
            this.button_gir.Location = new System.Drawing.Point(534, 140);
            this.button_gir.Name = "button_gir";
            this.button_gir.Size = new System.Drawing.Size(75, 23);
            this.button_gir.TabIndex = 12;
            this.button_gir.Text = "Gir";
            this.button_gir.UseVisualStyleBackColor = true;
            this.button_gir.Click += new System.EventHandler(this.button_gir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(142, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Skor :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(406, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 82);
            this.panel1.TabIndex = 16;
            // 
            // labelskor
            // 
            this.labelskor.AutoSize = true;
            this.labelskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelskor.Location = new System.Drawing.Point(196, 229);
            this.labelskor.Name = "labelskor";
            this.labelskor.Size = new System.Drawing.Size(0, 16);
            this.labelskor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(140, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kelime Listesi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(129, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 134);
            this.listBox1.TabIndex = 19;
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(12, 12);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(75, 23);
            this.buttonekle.TabIndex = 20;
            this.buttonekle.Text = "Ekle >";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttoncikar
            // 
            this.buttoncikar.Location = new System.Drawing.Point(12, 116);
            this.buttoncikar.Name = "buttoncikar";
            this.buttoncikar.Size = new System.Drawing.Size(75, 23);
            this.buttoncikar.TabIndex = 21;
            this.buttoncikar.Text = "< Çıkar";
            this.buttoncikar.UseVisualStyleBackColor = true;
            this.buttoncikar.Click += new System.EventHandler(this.buttoncikar_Click);
            // 
            // txtkelimegir
            // 
            this.txtkelimegir.Location = new System.Drawing.Point(12, 74);
            this.txtkelimegir.MaxLength = 10;
            this.txtkelimegir.Name = "txtkelimegir";
            this.txtkelimegir.Size = new System.Drawing.Size(100, 20);
            this.txtkelimegir.TabIndex = 22;
            this.txtkelimegir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharfgir_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Yeni Kelime";
            // 
            // buttonoyunabasla
            // 
            this.buttonoyunabasla.Location = new System.Drawing.Point(279, 28);
            this.buttonoyunabasla.Name = "buttonoyunabasla";
            this.buttonoyunabasla.Size = new System.Drawing.Size(75, 23);
            this.buttonoyunabasla.TabIndex = 24;
            this.buttonoyunabasla.Text = "Oyuna Başla";
            this.buttonoyunabasla.UseVisualStyleBackColor = true;
            this.buttonoyunabasla.Click += new System.EventHandler(this.buttonoyunabasla_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 189);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 69);
            this.listBox2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Skor Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 266);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonoyunabasla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtkelimegir);
            this.Controls.Add(this.buttoncikar);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelskor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_gir);
            this.Controls.Add(this.txtharfgir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelkalanhak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_basla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHarfSayisi);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarfSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numHarfSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_basla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelkalanhak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtharfgir;
        private System.Windows.Forms.Button button_gir;
        private System.Windows.Forms.Label lblkullanilanharfler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelskor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttoncikar;
        private System.Windows.Forms.TextBox txtkelimegir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonoyunabasla;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label9;
    }
}

