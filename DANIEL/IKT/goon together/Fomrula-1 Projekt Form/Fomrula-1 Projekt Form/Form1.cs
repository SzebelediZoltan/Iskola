using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fomrula_1_Projekt_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateEvekLista();
        }

        private void CreateEvekLista()
        {

        }

        private void EvekLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatePalyakLista(EvekLista.SelectedItem.ToString());
        }
        
        private void CreatePalyakLista(string ev)
        {

        }

        private void PalyakLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDataGrid(PalyakLista.SelectedItem.ToString());
        }

        private void CreateDataGrid(string palya)
        {
            
        }

        private void VersenyData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
