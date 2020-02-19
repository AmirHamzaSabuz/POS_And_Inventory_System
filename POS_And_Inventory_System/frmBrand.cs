using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_And_Inventory_System
{
    public partial class frmBrand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dBCon = new DBConnection();
        frmBrandList frmList;
        public frmBrand(frmBrandList fList)
        {
            InitializeComponent();
            cn = new SqlConnection(dBCon.MyConnection());
            frmList = fList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }

        private void Clear() {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBrand(Brand)VALUEs(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved");
                    Clear();
                    frmList.LoadRecords();
                }
               
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
