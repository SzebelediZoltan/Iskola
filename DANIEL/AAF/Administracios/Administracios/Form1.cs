namespace Administracios
{
    public partial class Form1 : Form
    {
        List<TextBox> szerzok = new List<TextBox>();
        int i = 1;

        public Form1()
        {
            InitializeComponent();
            szerzok.Add(szerzo1);
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szoveg = $"{(felujitando.Checked ? "True" : "False")}; {cim.Text}; {evszam.Value}{getSzerzokString()}";
            konyvek.Items.Add(szoveg);

            felujitando.Checked = false;
            cim.Text = "";
            evszam.Value = 0;
        }

        private string getSzerzokString()
        {
            string szoveg = "";

            for (int i = 0; i < szerzok.Count; i++)
            {
                szoveg += "; " + szerzok[i].Text;
            }

            return szoveg;
        }

        private void addSzerzo_Click(object sender, EventArgs e)
        {
            TextBox b = new TextBox();
            b.Location = new Point(84, 134 + i * 29);
            szerzok.Add(b);
            this.Controls.Add(b);
            this.Size = new Size(413, 202 + i * 29);
            i++;
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mentes();
        }

        private void mentes()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fw = new StreamWriter(saveFileDialog1.FileName);

                for (int i = 0; i < konyvek.Items.Count; i++)
                {
                    fw.WriteLine(konyvek.Items[i]);
                }

                fw.Close();
            }

        }

        private void lOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konyvek.Items.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader fr = new StreamReader(openFileDialog1.FileName);

                while (!fr.EndOfStream)
                {
                    konyvek.Items.Add(fr.ReadLine());
                }

                fr.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Menti?", "Mentes", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                mentes();
            }
        }
    }
}
