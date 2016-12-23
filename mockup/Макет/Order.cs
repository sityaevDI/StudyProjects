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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        int order = -1;
        public Order(int order)
        {
            this.order = order;
            InitializeComponent();
        }

        public void setWorker(int id)
        {
            refreshComboBox();
            cbEmployee.SelectedValue = id;
        }

        public void refreshComboBox()
        {
            var query = "select id,name from Employee";
            cbEmployee.DisplayMember = "name";
            cbEmployee.ValueMember = "id";
            cbEmployee.DataSource = DBConnect.getTableAsDT(query);

            query = "select id,name from Post";
            cbPost.DisplayMember = "name";
            cbPost.ValueMember = "id";
            cbPost.DataSource = DBConnect.getTableAsDT(query);

            query = "select id,name from Department";
            cbDep.DisplayMember = "name";
            cbDep.ValueMember = "id";
            cbDep.DataSource = DBConnect.getTableAsDT(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dtSt = dtpStart.Value.ToString("yyyy-MM-dd"),
                dtNd = dtpEnd.Value.ToString("yyyy-MM-dd"),
                emp = cbEmployee.SelectedValue.ToString(),
                desc = tbDescription.Text;
            string query = "";
            if (cbHasEndDate.Checked)
                query = string.Format("insert into [Order] (empl_id,dateStart,dateEnd,description) values ({0}, '{1}', '{2}', '{3}');",
                        emp, dtSt, dtNd, desc);
            else
                query = string.Format("insert into [Order] (empl_id,dateStart,description) values ({0}, '{1}', '{2}');",
                       emp, dtSt, desc);

            if (radioButton2.Checked & (checkBox1.Checked | checkBox2.Checked))
            {
                string addQuery = "";
                if (checkBox2.Checked & checkBox1.Checked)
                {
                    var post = cbPost.SelectedValue;
                    var empl = cbEmployee.SelectedValue;
                    var dep = cbDep.SelectedValue;
                     addQuery = string.Format("update Employee set post_id = {0},dep_id={1} where id = {2};", post, dep, empl);
                }
                else if (checkBox1.Checked)
                {
                    var post = cbPost.SelectedValue;
                    var empl = cbEmployee.SelectedValue;
                     addQuery = string.Format("update Employee set post_id = {0} where id = {1};", post, empl);
                }
                else if (checkBox2.Checked)
                {
                    var empl = cbEmployee.SelectedValue;
                    var dep = cbDep.SelectedValue;
                     addQuery = string.Format("update Employee set dep_id={1} where id = {2};", dep, empl);
                }
                DBConnect.ExecuteNonQuery(addQuery);
            }
            if (radioButton3.Checked)
            {
                var empl = cbEmployee.SelectedValue;
                var addQuery = string.Format("update Employee set fired=1 where id = {0};", empl);
                DBConnect.ExecuteNonQuery(addQuery);
            }
            DBConnect.ExecuteNonQuery(query);
            Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            refreshComboBox();
          }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cbEmployee.Enabled = false;
                btnAddEmployee.Enabled = true;
                groupBox1.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                groupBox1.Enabled = true;
                btnAddEmployee.Enabled = false;
                cbEmployee.Enabled = true;
            }
            if (radioButton3.Checked)
            {
                groupBox1.Enabled = false;
                cbEmployee.Enabled = true;
                btnAddEmployee.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbPost.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cbDep.Enabled = checkBox2.Checked;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee empl = new Employee(true);
            empl.Owner = this;
            empl.Show();
        }
    }
}