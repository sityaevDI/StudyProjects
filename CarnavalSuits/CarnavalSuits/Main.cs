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
    }
}