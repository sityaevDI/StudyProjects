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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подтвержен");
        }
    }
}
