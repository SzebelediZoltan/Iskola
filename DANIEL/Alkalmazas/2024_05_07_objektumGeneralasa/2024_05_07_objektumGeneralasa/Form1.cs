using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_05_07_objektumGeneralasa
{
    public partial class Form1 : Form
    {
        static double osszeg = 0;
        static int muvelet = 1;
        public Form1()
        {
            InitializeComponent();
            SzamokGeneralasa();
            textBox1.TextAlign = HorizontalAlignment.Right;
        }
        private void SzamokGeneralasa()
        {
            int n = 3;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    GombKeszites(12 + 60 * (i+1), 120 + 60 * j, 60, 60, "" + (j * n + i + 1));
                }
            }
            GombKeszites(12 + 60 * 1, 120 + 60 * n, 60, 60, "C");
            GombKeszites(12 + 60 * 2, 120 + 60 * n, 60, 60, "0");
            GombKeszites(12 + 60 * 3, 120 + 60 * n, 60, 60, ",");
        }

        private void GombKeszites(int x, int y, int w, int h, string v)
        {
            Button b1 = new Button();
            b1.Text = v;
            b1.Location = new Point(x, y);
            b1.Size = new Size(w, h);
            b1.Click += new EventHandler(GombraKattintas);
            this.Controls.Add(b1);
        }

        private void GombraKattintas(object sender, EventArgs e)
        {
            Button gomb = (Button) sender;
            //MessageBox.Show(gomb.Text, "Gomb értéke");
            if (muvelet == 5)
            {
                textBox1.Text = "";
                muvelet = 1;
            }
            if (gomb.Text == "C")
            {
                textBox1.Text = "";
                osszeg = 0;
                muvelet = 1;
            } else
            {
                textBox1.Text += gomb.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElozoMuvelet();
            textBox1.Text = "";
            muvelet = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElozoMuvelet();
            textBox1.Text = Convert.ToString(osszeg);
            osszeg = 0;
            muvelet = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElozoMuvelet();
            textBox1.Text = "";
            muvelet = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ElozoMuvelet();
            textBox1.Text = "";
            muvelet = 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ElozoMuvelet();
            textBox1.Text = "";
            muvelet = 4;
        }

        private void ElozoMuvelet()
        {
            switch (muvelet)
            {
                case 1:
                    osszeg += Convert.ToDouble(textBox1.Text);
                    break;
                case 2:
                    osszeg -= Convert.ToDouble(textBox1.Text);
                    break;
                case 3:
                    osszeg = osszeg * Convert.ToDouble(textBox1.Text);
                    break;
                case 4:
                    osszeg = osszeg / Convert.ToDouble(textBox1.Text);
                    break;
                case 5:
                    osszeg += Convert.ToDouble(textBox1.Text);
                    break;
            }
        }

        private void Szam(object sender, EventArgs e)
        {
            string szam = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (Char.IsDigit(textBox1.Text[i]) || textBox1.Text[i] == ',')
                {
                    szam += textBox1.Text[i];
                }
            }

            textBox1.Text = szam;
        }
    }
}
