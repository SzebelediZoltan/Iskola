using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaszinoProjekt;

namespace KaszinoProjektForm
{
    public partial class Form1 : Form
    {
        Asztal asztal = new Asztal(5, new Rulett());
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && asztal.jatekosok.Count < 5 && !asztal.jatekosok.ContainsKey(new Jatekos(100, textBox1.Text)))
            {
                asztal.jatekosok.Add(new Jatekos(100, textBox1.Text),
                    new int[2]);
            }

            listBox1.Items.Clear();
            JatekosKiiratasListBoxba();
        }

        private void JatekosKiiratasListBoxba()
        {
            foreach (var item in asztal.jatekosok)
            {
                listBox1.Items.Add(item.Key);
            }
        }
    }
}
