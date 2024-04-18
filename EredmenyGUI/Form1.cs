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
            EredmenyRepositroy.Path = "eredmeny.txt";
            dataGridView1.DataSource = EredmenyRepositroy.FindAll();
        }
    }
}
