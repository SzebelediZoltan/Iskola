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
        public Form1()
        {
            InitializeComponent();
            SzamokGeneralasa();
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SzamokGeneralasa();

        }

        private void SzamokGeneralasa()
        {
            int n = 3;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    GombKeszites(12 + 60 * i, 120 + 60 * j, 60, 60, "" + (j * n + i + 1));
                }
            }
            GombKeszites(12 + 60 * 1, 120 + 60 * n, 60, 60, "0");
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
            
            textBox1.Text += gomb.Text;
        }
    }
}
