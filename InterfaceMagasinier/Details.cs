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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitboxDataSet.client_order' table. You can move, or remove it, as needed.
            this.client_orderTableAdapter.Fill(this.kitboxDataSet.client_order);
            // TODO: This line of code loads data into the 'kitboxDataSet.component' table. You can move, or remove it, as needed.
            this.componentTableAdapter.Fill(this.kitboxDataSet.component);
            // TODO: This line of code loads data into the 'kitboxDataSet.client_order_component' table. You can move, or remove it, as needed.
            this.client_order_componentTableAdapter.Fill(this.kitboxDataSet.client_order_component);


        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Close order => déplace dans Closed Orders

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
} 
