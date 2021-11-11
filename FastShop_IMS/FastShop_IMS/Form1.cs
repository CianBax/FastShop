using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastShop_IMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fastShopDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fastShopDBDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.fastShopDBDataSet.Stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
