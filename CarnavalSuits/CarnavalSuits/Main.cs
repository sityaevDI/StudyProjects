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
    }

    public static class Globals
    {
        public static Logic logic; 
    }
}