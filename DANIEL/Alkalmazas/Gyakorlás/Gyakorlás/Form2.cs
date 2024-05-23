using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlás
{
    public partial class Form2 : Form
    {
        public Form2(Adat akt)
        { 
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        class Adat
        {
            public int korzet, szavazatok;
            public string nev, part;

            public Adat(int korzet, int szavazatok, string vez, string ker, string part)
            {
                this.korzet = korzet;
                this.szavazatok = szavazatok;
                this.nev = vez + " " + ker;
                if (part == "-")
                {
                    this.part = "Független";
                }
                else
                {
                    this.part = part;
                }
            }
        }
    }
}
