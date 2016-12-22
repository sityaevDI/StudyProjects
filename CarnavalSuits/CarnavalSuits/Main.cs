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
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new Client();
            client.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.logic = new Logic("DENIS-PC", "CarnavalCostumes_IIS");

            dataGridView1.DataSource = Globals.logic.getDataTable(@"SELECT        dbo.Costume.id, dbo.Costume.name as 'Название костюма', dbo.Type.name AS 'Тип костюма', dbo.Costume.daylyPrice as 'Цена за день', dbo.Costume.price as 'Стоимость'
                            FROM            dbo.Costume INNER JOIN
                         dbo.Type ON dbo.Costume.type_id = dbo.Type.id");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Refresh();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void типыКостюмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tp = new CostumeType();
            tp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CostumeDetails c = new CostumeDetails();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basket f1 = new basket();
            f1.ShowDialog();
        }

        private void актВозвратаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var returnAct = new ReturnAct();
            returnAct.Show();
        }
    }
}