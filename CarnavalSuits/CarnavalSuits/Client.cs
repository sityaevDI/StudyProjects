using System;
using System.Windows.Forms;

namespace CarnavalSuits
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public Client(bool selectionMode)
        {
            this.selectionMode = selectionMode; 
            InitializeComponent();
        }

        public void showEdit()
        {
            gbEdit.Visible = true;
            gbList.Visible = false;
            gbSearch.Enabled = false;
            gbLeftButtons.Enabled = false;

            tbAdress.Text = tbName.Text = tbPassport.Text =
                tbPassportGiven.Text = tbPhone.Text = "";
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

            tbAdress.Text = row.Cells[3].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
            tbPassport.Text = row.Cells[4].Value.ToString();
            tbPassportGiven.Text = row.Cells[5].Value.ToString();
            tbPhone.Text = row.Cells[2].Value.ToString();
            var date = row.Cells[6].Value;
            dtPassportDate.Value = new DateTime();
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
            string name = tbName.Text,
                phone = tbPhone.Text,
                adress = tbAdress.Text,
                paspNum = tbPassport.Text,
                paspGiven = tbPassportGiven.Text,
                paspDate = dtPassportDate.Value.Date.ToString("yyyy-MM-dd"); 

            string query = "";
            if (!edit)
                query = string.Format(@"insert into [Client] (name, phone, adress,documentNum, 
                documentGivenPlace, DocumentGivenDate) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                 name, phone, adress, paspNum, paspGiven, paspDate);
            else
            {
                var idRow = dgvMain.CurrentRow.Index;
                var idDt = Convert.ToInt32(dgvMain.Rows[idRow].Cells[0].Value);
                query = string.Format(@"update [Client] set name = '{1}', phone = '{2}', adress = '{3}',documentNum = '{4}', 
                    documentGivenPlace = '{5}', DocumentGivenDate = '{6}' where id = {0}",
                    idDt, name, phone, adress, paspNum, paspGiven, paspDate);
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
            var query = "select * from Client_View";
            Globals.logic.loadDgv(ref dgvMain, query);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadDataGrid();
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
    }
}