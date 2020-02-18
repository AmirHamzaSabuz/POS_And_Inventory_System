using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_And_Inventory_System
{
    public partial class frmBrandList : Form
    {
        public frmBrandList()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++) 
            {
                dataGridView1.Rows.Add(i, "1", "Brand " + i);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
