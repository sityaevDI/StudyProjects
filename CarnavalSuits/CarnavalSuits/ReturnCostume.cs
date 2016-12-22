using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnavalSuits
{
    public partial class ReturnCostume : Form
    {
        int order, days, act;
        DateTime startDay;
        int[] costumesInAct;
        double price, daylyRent;
        List< string> costumes = new List<string>();

        public ReturnCostume(int order, int[] returned)
        {
            this.order = order;
            costumesInAct = returned;
            InitializeComponent();
        }

        private void ReturnCostume_Load(object sender, EventArgs e)
        {
            loadCostumes();
        }

        void loadCostumes()
        {
            string costumes = "";
            foreach (int c in costumesInAct)
                costumes += c.ToString() + ',';
            string query = string.Format("select * from CostumesInOrder_View where(order_id = {0})",
                order, costumes);
            cbCostume.ValueMember = "id";
            cbCostume.DisplayMember = "name";

            var dataset = Globals.logic.getDataTable(query);
            cbCostume.DataSource = dataset;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("YYYY-MM-DD");
            double rent = Convert.ToDouble(tbRent.Text),
                shtraf = Convert.ToDouble(tbUsherb.Text);
            string sum = (rent + shtraf).ToString();
            var costume = cbCostume.SelectedValue;
            costumes.Add(string.Format("insert into ReturnActBody (act_id, actSum, orderbody_id) values ({0},{1},{2})", sum, costume));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double shtraf = 0;
            if (radioButton1.Checked)
                shtraf = 0;
            else if (radioButton2.Checked)
                shtraf = 0.5;
            else if (radioButton3.Checked)
                shtraf = 1;

            tbUsherb.Text = Math.Round(price * shtraf, 2).ToString();
        }

        private void cbCostume_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = cbCostume.SelectedValue;
            var query = string.Format("select price, daylyPrice, returnDatePlan from OrderedCostumes where id = {0}", value);
            var costumePrices = Globals.logic.getDataTable(query);
            price = Math.Round(Convert.ToDouble(costumePrices.Rows[0][0]), 2);
            daylyRent = Math.Round(Convert.ToDouble(costumePrices.Rows[0][1]), 2);
            startDay = (DateTime)costumePrices.Rows[0][2];
            TimeSpan dt = dateTimePicker1.Value - startDay;
            days = dt.Days;
            lbDeposit.Text = price.ToString();
            tbRent.Text = Math.Round(daylyRent * days, 2).ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan dt = dateTimePicker1.Value - startDay;
            days = dt.Days;
            lbDeposit.Text = price.ToString();
            tbRent.Text = Math.Round(daylyRent * days, 2).ToString();
        }
    }
}
