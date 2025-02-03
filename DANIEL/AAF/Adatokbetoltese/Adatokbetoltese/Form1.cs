using System.ComponentModel;

namespace Adatokbetoltese
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                string[] sor = sr.ReadLine().Split(';');
                foreach (var item in sor)
                {
                    dataGridView1.Columns.Add("ASD", item);
                }
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string[] sor1 = sr.ReadLine().Split(';');
                    dataGridView1.Rows.Add(sor1);
                    dataGridView1.Rows[i].HeaderCell.Value = "" + (i);
                    i++;
                }

                sr.Close();
            }
            else
            {
                MessageBox.Show("Hiba a fájl megnyitása során!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
