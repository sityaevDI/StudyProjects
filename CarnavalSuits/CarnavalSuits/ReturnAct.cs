using System;
using System.Windows.Forms;

namespace CarnavalSuits
{
    public partial class ReturnAct : Form
    {
        public ReturnAct()
        {
            InitializeComponent();
        }

        public void showEdit()
        {
            gbEdit.Visible = true;
            gbList.Visible = false;
            gbSearch.Enabled = false;
            gbLeftButtons.Enabled = false;

            dateTimePicker1.Value = DateTime.Today;
            dataGridView1.Rows.Clear();
        }

        public void hideEdit()
        {
            gbEdit.Visible = false;
            gbList.Visible = true;
            gbSearch.Enabled = true;
            gbLeftButtons.Enabled = true;
            loadDataGrid();
        }

        public void showEdit(DataGridViewRow row)
        {
            showEdit();

            //tbAdress.Text = row.Cells[3].Value.ToString();
            //tbName.Text = row.Cells[1].Value.ToString();
            //tbPassport.Text = row.Cells[4].Value.ToString();
            //tbPassportGiven.Text = row.Cells[5].Value.ToString();
            //tbPhone.Text = row.Cells[2].Value.ToString();
            //var date = row.Cells[6].Value;
            //dtPassportDate.Value = new DateTime();
        }

        public string[] costumes;
        int returnAct;
        bool edit = false;
        bool selectionMode = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            showEdit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string orderId = comboBox1.SelectedValue.ToString(),
                actDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = "";
            if (!edit)
                query = string.Format(@"insert into [ReturnAct] (order_id, actDate, manager_id) 
                                    values ('{0}', '{1}', '{2}', )", orderId, actDate, Globals.managerId);
            else
            {
                var idRow = dgvMain.CurrentRow.Index;
                var idDt = Convert.ToInt32(dgvMain.Rows[idRow].Cells[0].Value);
                query = string.Format(@"update [ReturnAct] set order_id = '{1}', actDate = '{2}', manager_id = '{3}'
                                where id = {0}", idDt, orderId, actDate, Globals.managerId);
            }

            Globals.logic.executeNonQuery(query);
            hideEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hideEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            try
            {
                var currentLine = dgvMain.CurrentRow;
                returnAct = Convert.ToInt16(currentLine.Cells[0].Value);
                showEdit(currentLine);
            }
            catch { }
        }

        private void loadDataGrid()
        {
            var query = "select * from [dbo].[ReturnAct_View]";
            Globals.logic.loadDgv(ref dgvMain, query);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[0].Value);
                var query = @"delete from [Client] where id = " + id;
                Globals.logic.executeNonQuery(query);
            }
            catch { }
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Globals.valueMember = -1;
                int idClient = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[0].Value);
                if (selectionMode == true)
                {
                    Globals.valueMember = idClient;
                    Close();
                }
            }
            catch { }
        }

        private void btnAddCostume_Click(object sender, EventArgs e)
        {
            var order = (int)comboBox1.SelectedValue;
            var costume = new ReturnCostume(order);
            costume.Owner = this;
            costume.Show();
        }

        private void ReturnAct_Load(object sender, EventArgs e)
        {
            loadDataGrid();
            string query = "select * from Order";
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = Globals.logic.getDataTable(query);

        }
    }
}
