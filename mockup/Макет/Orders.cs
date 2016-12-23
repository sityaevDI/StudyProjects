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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            newOrder.Show();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            string query = "select * from Order_View";
            dataGridView1.DataSource = DBConnect.getTableAsDT(query);
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idOrder = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Order ord = new Order(idOrder);
        }
    }
}
