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
        bool ret;
        int worker = -1;
        public Employee()
        {
            InitializeComponent();
        }
        public Employee(bool need_return)
        {
            ret = need_return;
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
            string name = tbName.Text,
                birth = dtpBirth.Value.ToString("yyyy-MM-dd"),
                tab = textBox3.Text,
                inn = tbInn.Text,
                snils = tbSnils.Text,
                dep = cbDep.SelectedValue.ToString(),
                post = cbPost.SelectedValue.ToString(),
                pasp = tbPasp.Text,
                query = string.Format(@"insert into Employee (name,birth,inn,snils,pasp,post_id,dep_id,tabNumber) 
                        values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", name, birth, inn, snils, pasp, post, dep, tab);
            if (!ret)
                DBConnect.ExecuteNonQuery(query);
            else
            {
                query += "SELECT CAST(scope_identity() AS int)";
                worker = Convert.ToInt16(DBConnect.ExecuteScalar(query));
            }
            Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            var query = "select id, name from Department";
            cbDep.DisplayMember = "name";
            cbDep.ValueMember = "id";
            cbDep.DataSource = DBConnect.getTableAsDT(query);

            query = "select id,name from Post";
            cbPost.DisplayMember = "name";
            cbPost.ValueMember = "id";
            cbPost.DataSource = DBConnect.getTableAsDT(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ret)
            {
                Order form = (Order)Owner;
                form.setWorker(worker);
            }
        }
    }
}
