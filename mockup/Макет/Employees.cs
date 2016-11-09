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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уволен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report rt = new Report();
            rt.Show();
        }
    }
}
