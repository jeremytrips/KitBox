using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceMagasinier
{
    public partial class StoreKeeper : Form
    {
        private string id_Order;
        private string Order_name;
        private string date;
        public StoreKeeper()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewOrderProgress.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewOrderProgress.CurrentRow.Selected = true;
                id_Order = dataGridViewOrderProgress.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Order_name = dataGridViewOrderProgress.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                date = dataGridViewOrderProgress.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();


            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitboxDataSet.component' table. You can move, or remove it, as needed.
            this.componentTableAdapter.Fill(this.kitboxDataSet.component);
            // TODO: This line of code loads data into the 'kitboxDataSet.client_order' table. You can move, or remove it, as needed.
            this.client_orderTableAdapter.Fill(this.kitboxDataSet.client_order);

            Dictionary<string, int> GetDetails = userInterface.Database.FetchClearedBill(Int16.Parse(this.id_Order));
            foreach (var item in GetDetails.Keys)
            {
                this.dataGridViewOutStock.Rows.Add(item, GetDetails[item]);
            }

            /*private string OutOfStock;

            foreach(DataGridViewRow row in dataGridViewStock.Rows)
            {
                 if(dataGridViewStock.Rows[e.RowIndex].Cells[1].Value<MySqlDataReader rdr = Fetch(String.Format("SELECT stock_min_required FROM kitbox.component WHERE code LIKE '{0}';", component)); )
            {
               OutOfStock  = dataGridViewOrderStock.Rows[e.RowIndex].FormattedValue.ToString();

            }*/

}

        private void MagasinGroupBcx_Enter(object sender, EventArgs e)
        {

        }


        private void ListOfComponents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            var newForm = new Details(id_Order, Order_name, date);
            newForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }


        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientorderBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

