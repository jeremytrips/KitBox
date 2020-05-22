using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userInterface;

namespace InterfaceMagasinier
{
    public partial class Details : Form
    {
        private string id_Order;
        private string Order_name;
        private string date;
        public Details(string id_order, string order_name, string date)
        {
            this.id_Order = id_order;
            this.Order_name = order_name;
            this.date = date;

           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.labelOrderName.Text = this.Order_name;
            this.LabelIdName.Text = this.id_Order;
            this.labelDate.Text = this.date;

            Dictionary<string, int> GetDetails = Database.FetchClearedBill(Int16.Parse(this.id_Order));
            foreach (var item in GetDetails.Keys)
            {
                this.dataGridView1.Rows.Add(item, GetDetails[item]);
            }
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


        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument prntdoc = new PrintDocument();
        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
            
        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;  
            getprintarea(pnl);
            prntprvw.Document = prntdoc;
            prntdoc.PrintPage += new PrintPageEventHandler(prntdoc_printpage);
            prntprvw.ShowDialog();

        }

        public void prntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void getprintarea(Panel pnl)
        {
            bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
} 
