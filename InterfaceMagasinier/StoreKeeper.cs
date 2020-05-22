using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userInterface;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            Database.CheckStock();
            this.dataGridViewOutStock.Rows.Clear();
            // TODO: This line of code loads data into the 'kitboxDataSet.component' table. You can move, or remove it, as needed.
            this.componentTableAdapter.Fill(this.kitboxDataSet.component);
            // TODO: This line of code loads data into the 'kitboxDataSet.price' table. You can move, or remove it, as needed.
            this.priceTableAdapter.Fill(this.kitboxDataSet.price);
            // TODO: This line of code loads data into the 'kitboxDataSet.supplier_order_component' table. You can move, or remove it, as needed.
            this.supplier_order_componentTableAdapter.Fill(this.kitboxDataSet.supplier_order_component);
            // TODO: This line of code loads data into the 'kitboxDataSet.supplier_order' table. You can move, or remove it, as needed.
            this.supplier_orderTableAdapter.Fill(this.kitboxDataSet.supplier_order);
            // TODO: This line of code loads data into the 'kitboxDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.kitboxDataSet.supplier);

            List<List<object>> unclosed_orders = Database.FetchUnclosedOrders(Database.GetNumberOfOrder());
            foreach(var item in unclosed_orders)
            {
                this.dataGridViewOrderProgress.Rows.Add();
            }

            Dictionary<string, int> OutofStock = Database.FetchOutOfStock();
            foreach (var item in OutofStock.Keys)
            {
                this.dataGridViewOutStock.Rows.Add(item, OutofStock[item]);
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            var newForm = new Details(id_Order, Order_name, date);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            int number = Int16.Parse(textBox2.Text);
            Database.updatestock(code, number);
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = textBox5.Text;
            int number = Int16.Parse(textBox3.Text);
            Database.updateprice(code, number);
            refresh();
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            DataView DV = new DataView(kitboxDataSet.client_order);
            DV.RowFilter = string.Format("order_name like '%{0}%'", textBox4.Text);
            dataGridViewOrderProgress.DataSource = DV;
        }

    }
}

