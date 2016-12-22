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
    public partial class OrderCostumes : Form
    {
        int order;
        public OrderCostumes(int order)
        {
            this.order = order;
            InitializeComponent();
        }

        private void OrderCostumes_Load(object sender, EventArgs e)
        {
            var query = string.Format(@"SELECT        dbo.OrderBody.order_id, dbo.Costume.name AS Наименование, dbo.CostumeSizes.articul AS Артикул, dbo.OrderBody.count AS Количество, dbo.OrderBody.returnDatePlan AS [Дата возвр.], 
                         dbo.Size.russian AS Размер
                         FROM            dbo.Costume INNER JOIN
                         dbo.CostumeSizes ON dbo.Costume.id = dbo.CostumeSizes.costume_id INNER JOIN
                         dbo.OrderBody ON dbo.CostumeSizes.id = dbo.OrderBody.costumeS_id INNER JOIN
                         dbo.Size ON dbo.CostumeSizes.size_id = dbo.Size.id where order_id = {0}", order);
            Globals.logic.loadDgv(ref dataGridView1, query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderBodyID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var parent = (ReturnCostume)Owner;
            parent.setCostume(orderBodyID);
            this.Close();
        }
    }
}