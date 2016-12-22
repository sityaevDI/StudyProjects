using System;
using System.Windows.Forms;

namespace CarnavalSuits
{
    public partial class SizeTypes : Form
    {
        public SizeTypes()
        {
            InitializeComponent();
        }

        public void showEdit()
        {
            gbEdit.Visible = true;
            gbList.Visible = false;
            gbSearch.Enabled = false;
            gbLeftButtons.Enabled = false;
            tbName.Text = "";

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
            tbName.Text = row.Cells[1].Value.ToString();
        }

        int clientId;
        bool edit = false;
        bool selectionMode = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            showEdit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;

            string query = "";
            if (!edit)
                query = string.Format(@"insert into [Type] (name) values ('{0}')",
                 name);
            else
            {
                var idRow = dgvMain.CurrentRow.Index;
                var idDt = Convert.ToInt32(dgvMain.Rows[idRow].Cells[0].Value);
                query = string.Format(@"update [Type] set name = '{1}' where id = {0}",
                    idDt, name);
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
                clientId = Convert.ToInt16(currentLine.Cells[0].Value);
                showEdit(currentLine);
            }
            catch { }
        }

        private void loadDataGrid()
        {
            var query = "select id, name as [Наименование] from [SizeTypes]";
            Globals.logic.loadDgv(ref dgvMain, query);
        }

        private void Type_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[0].Value);
                var query = @"delete from [SizeTypes] where id = " + id;
                Globals.logic.executeNonQuery(query);
            }
            catch { }
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Globals.valueMember = -1;
                int idType = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[0].Value);
                if (selectionMode == true)
                {
                    Globals.valueMember = idType;
                    Close();
                }
            }
            catch { }
        }
    }
}