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
                Order_name = dataGridViewOrderProgress.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                date = dataGridViewOrderProgress.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
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
            this.dataGridViewOrderProgress.Rows.Clear();
            // TODO: This line of code loads data into the 'kitboxDataSet.price' table. You can move, or remove it, as needed.
            this.priceTableAdapter.Fill(this.kitboxDataSet.price);
            // TODO: This line of code loads data into the 'kitboxDataSet.component' table. You can move, or remove it, as needed.
            this.componentTableAdapter.Fill(this.kitboxDataSet.component);
            // TODO: This line of code loads data into the 'kitboxDataSet.client_order' table. You can move, or remove it, as needed.
            this.client_orderTableAdapter.Fill(this.kitboxDataSet.client_order);
            

            object[] unclosed_orders = Database.FetchUnclosedOrders(Database.GetNumberOfOrder());
            foreach(string[] item in unclosed_orders)
            {
                if(item[0] != null)
                {
                    this.dataGridViewOrderProgress.Rows.Add(item);
                }
            }

            Dictionary<string, int> OutofStock = Database.FetchOutOfStock();
            foreach (var item in OutofStock.Keys)
            {
                this.dataGridViewOutStock.Rows.Add(item, OutofStock[item]);
            }

          
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            if(id_Order != null)
            {
                var newForm = new Details(id_Order, Order_name, date);
                newForm.Show();
                id_Order = null;
                Order_name = null;
                date = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                string code = textBox1.Text;
                int number = Int16.Parse(textBox2.Text);
                Database.updatestock(code, number);
                refresh();
            }
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            DataView DV = new DataView(kitboxDataSet.client_order);
            DV.RowFilter = string.Format("order_name like '%{0}%'", textBox4.Text);
            dataGridView2.DataSource = DV;
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                id_Order = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Order_name = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                date = dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "")
            {
                string newCode = textBox6.Text;
                string newReference = textBox7.Text;
                string newColor = textBox8.Text;
                int newHeight = Int32.Parse(textBox9.Text);
                int newWidth = Int32.Parse(textBox10.Text);
                int newDepth = Int32.Parse(textBox11.Text);
                int newStock = Int32.Parse(textBox13.Text);
                int newNumberbybox = Int32.Parse(textBox14.Text);
                float newPrice = float.Parse(textBox12.Text);
                Database.AddComponent(newCode, newReference, newColor, newHeight, newWidth, newDepth, newStock, newNumberbybox, newPrice);
                System.Windows.Forms.MessageBox.Show("Your piece has been added");
            }
            refresh();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                Database.DeleteComponent(textBox6.Text);
                System.Windows.Forms.MessageBox.Show("Your piece has deleted");
            }
            refresh();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox3.Text != "")
            {
                string code = textBox5.Text;
                float number = (float)Convert.ToDouble(textBox3.Text);
                Database.updateprice(code, number);
                //, System.Globalization.CultureInfo.InvariantCulture.NumberFormat
                refresh();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

