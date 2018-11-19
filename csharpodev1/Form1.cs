using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace csharpodev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Label[] lbl = new Label[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            numHarfSayisi.Value = rnd.Next(3, 10);

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            FileStream fs = new FileStream("kelime.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            string dosya = sr.ReadLine();
            while (dosya != null)
            {
                listBox1.Items.Add(dosya);
                dosya = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream("skor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);

            string dosya2 = sr2.ReadLine();
            while (dosya2 != null)
            {
                listBox2.Items.Add(dosya2);
                dosya2 = sr2.ReadLine();
            }

            sr2.Close();
            fs2.Close();
        }

        String[] kelimeler = new String[25];
        String aranilankelime;
        int kalanhak;
        int skor = 0;
        int acilanharf = 0;

        private void button_basla_Click(object sender, EventArgs e)
        {
            kalanhak = (int)numHarfSayisi.Value + 2;
            labelkalanhak.Text = kalanhak.ToString();

            FileStream fs = new FileStream("kelime.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            int sayac = 0;
            string dosya = sr.ReadLine();
            while (dosya != null)
            {
                if (numHarfSayisi.Value==dosya.Length)
                {
                    kelimeler[sayac] = dosya.ToString();
                    sayac++;
                }
                dosya = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            aranilankelime = kelimeler[rnd.Next(0, sayac)].ToString();

            for (int i = 0; i < (int)numHarfSayisi.Value; i++)
            {
                lbl[i] = new Label();
                lbl[i].AutoSize = false;
                lbl[i].BackColor = Color.White;
                lbl[i].BorderStyle = BorderStyle.Fixed3D;
                lbl[i].TextAlign = ContentAlignment.MiddleCenter;
                lbl[i].Font = new Font("Microsoft Sans Serif", 18);
                lbl[i].Width = 50;
                lbl[i].Height = 50;
                lbl[i].Location = new Point((i * lbl[i].Width) + 20, 13);

                panel1.Controls.Add(lbl[i]);
            }

            //MessageBox.Show(aranilankelime.ToString());

            label1.Enabled = false;
            numHarfSayisi.Enabled = false;
            button_basla.Enabled = false;
            button_gir.Enabled = true;
            txtharfgir.Enabled = true;
        }

        private void button_gir_Click(object sender, EventArgs e)
        {
            if (txtharfgir.Text.Length==0)
            {
                MessageBox.Show("Lütfen harf girin.");
            }
            else if (lblkullanilanharfler.Text.IndexOf(txtharfgir.Text) != -1)
            {
                MessageBox.Show("Bu harfi zaten kullandınız.");
            }
            else
            {
                lblkullanilanharfler.Text += txtharfgir.Text + " ";
                kalanhak--;
                labelkalanhak.Text = kalanhak.ToString();

                for (int i = 0; i < aranilankelime.Length; i++)
                {
                    if (aranilankelime[i].ToString() == txtharfgir.Text)
                    {
                        lbl[i].Text = aranilankelime[i].ToString();
                        skor += 10;
                        labelskor.Text = skor.ToString();
                        acilanharf++;
                    }
                    else if (acilanharf==aranilankelime.Length)
                    {
                        MessageBox.Show("Kazandınız! Doğru kelime: "+aranilankelime.ToString());

                        listBox2.Items.Add(skor);

                        FileStream fs = new FileStream("skor.txt", FileMode.Truncate, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);

                        foreach (var item in listBox2.Items)
                        {
                            sw.WriteLine(item);
                        }

                        sw.Flush();
                        sw.Close();
                        fs.Close();

                        Temizle();
                    }
                    else if (kalanhak==0)
                    {
                        MessageBox.Show("Kaybettiniz! Doğru kelime: " + aranilankelime.ToString());
                        Temizle();
                    }
                }
                txtharfgir.Clear();
            }
        }

        public void Temizle()
        {
            numHarfSayisi.Value = rnd.Next(3, 10);
            kalanhak = 0;
            labelkalanhak.Text = kalanhak.ToString();
            skor = 0;
            labelskor.Text = skor.ToString();
            acilanharf = 0;
            lblkullanilanharfler.Text = "";
            aranilankelime = String.Empty;
            txtkelimegir.ResetText();
            txtkelimegir.Enabled = true;
            buttonekle.Enabled = true;
            buttoncikar.Enabled = true;
            buttonoyunabasla.Enabled = true;
            numHarfSayisi.Enabled = false;
            button_basla.Enabled = false;
            txtharfgir.Enabled = false;
            button_gir.Enabled = false;
            panel1.Controls.Clear();
        }

        private void txtharfgir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            if (txtkelimegir.Text.Length < 3)
            {
                MessageBox.Show("Lütfen en az 3 harfli kelime girin.");
            }
            else if(listBox1.Items.Contains(txtkelimegir.Text))
            {
                MessageBox.Show("Bu kelime zaten var.");
            }
            else
            {
                listBox1.Items.Add(txtkelimegir.Text);
            }
            txtkelimegir.Clear();
        }

        private void buttoncikar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem==null)
            {
                MessageBox.Show("Lütfen çıkarılacak kelimeyi seçin.");
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void buttonoyunabasla_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("kelime.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));

            foreach (var item in listBox1.Items)
            {
                sw.WriteLine(item);
            }

            sw.Flush();
            sw.Close();
            fs.Close();

            txtkelimegir.ResetText();
            txtkelimegir.Enabled = false;
            buttonekle.Enabled = false;
            buttoncikar.Enabled = false;
            buttonoyunabasla.Enabled = false;
            numHarfSayisi.Enabled = true;
            button_basla.Enabled = true;
        }
    }
}
