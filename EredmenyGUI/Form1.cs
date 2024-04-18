using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EredmenyGUI
{
    public partial class EredmenyForm : Form
    {
        public EredmenyForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EredmenyForm_Load(object sender, EventArgs e)
        {
            EredmenyRepositroy.Path = "eredmenyek.txt";
            dataGridView1.DataSource = EredmenyRepositroy.FindAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eredmények 1.0\n© Olajkár Ákos ");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogEredmeny.ShowDialog() == DialogResult.OK)
            {
                EredmenyRepositroy.Path = openFileDialogEredmeny.FileName;
                dataGridView1.DataSource = EredmenyRepositroy.FindAll();
            }
            {

            }
        }
    }
}
