using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public void hideEdit()
        {
            gbEdit.Visible = false;
            gbList.Visible = true;
            gbSearch.Enabled = true;
        }

        bool edit = false;
        bool selectionMode = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showEdit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = tbName.Text,
                phone = tbPhone.Text,
                adress = tbAdress.Text,
                paspNum = tbPassport.Text,
                paspGiven = tbPassportGiven.Text,
                paspDate = dtPassportDate.ToString(); //neoch

            string query = "";
            if (!edit)
                query = string.Format(@"insert into [Client] (name, phone, adress,documentNum, 
                documentGivenPlace, DocumentGivenDate) values ({0}, {1}, {2}, {3}, {4}, {5})",
                 name, phone, adress, paspNum, paspGiven, paspDate);
            else
            {
                var idRow = dgvMain.CurrentRow.Index;
                var idDt = Convert.ToInt32(dgvMain.Rows[idRow].Cells[0].Value);
                query = string.Format(@"update [Client] set name = '{1}', phone = '{2}', adress = '{3}',documentNum = '{4}', 
                    documentGivenPlace = '{5}', DocumentGivenDate = '{6}' where id = {0}",
                    idDt, name, phone, adress, paspNum, paspGiven, paspDate);
            }

            Logic.executeNonQuery(query);
            hideEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hideEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
        }
    }

    public class Logic
    {
        public Logic(string dataSource,string catalog)
        {
            var connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true",dataSource,catalog);
            connection = new SqlConnection(connectionString);
        }

        SqlConnection connection;
        SqlCommand cmd;

        public void loadDgv(ref DataGridView dgv)
        {
            string query = "select * from ClientsView";
            var result = getData(query);

            dgv.DataSource = result;
            dgv.Columns[0].Visible = false;
        }

        public DataSet getData(string query)
        {
            var ds = new DataSet();
            return ds;
        }

        public void executeNonQuery(string query)
        {

        }
    }
}