using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Karbantartás
{
    public partial class Form2 : Form
    {
        static ListBox listBox = new ListBox();
        public Form2(ListBox listBoxx)
        {
            InitializeComponent();
            listBox = listBoxx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szo = $"{textBox1.Text} {textBox2.Text} {textBox3.Text}";
            szo = szo.Trim();

            if(szo != "")
            {
                listBox.Items.Add(szo);
                this.Close();
            } else
            {
                MessageBoxManager.OK = "Jólvan na";
                MessageBoxManager.Register();
                MessageBox.Show("Írj bele valamit!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
