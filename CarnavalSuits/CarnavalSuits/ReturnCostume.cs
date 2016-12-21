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
        public ReturnCostume()
        {
            InitializeComponent();
        }

        private void ReturnCostume_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int state = 0;
            if (radioButton1.Checked)
                state = 0;
            else if (radioButton2.Checked)
                state = 1;
            else if (radioButton3.Checked)
                state = 2;
            string date = 
        }
    }
}
