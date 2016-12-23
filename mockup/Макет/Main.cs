using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макет
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Position pos = new Position();
            pos.Show();
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments dep = new Departments();
            dep.Show();
        }

        private void приказыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void обычныйПриказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders ord = new Orders();
            ord.Show();
        }

        private void обычныйОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
