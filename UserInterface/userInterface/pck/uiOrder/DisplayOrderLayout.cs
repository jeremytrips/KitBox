using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class DisplayOrderLayout:System.Windows.Forms.Panel
    {
        private ClientOrder order;
        private List<List<object>> billDescription;
        private float totalPrice = 0F;

        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TableLayoutPanel displayOrderPanel;
        private TableLayoutPanel displayUserPanel;
        private BackOrderAlert backOrderAlert = new BackOrderAlert();
        private InStockPanel inStockPanel = new InStockPanel();
        
        public DisplayOrderLayout()
        {
            this.MountLayout();
        }

        public ClientOrder Order
        {
            get => order; set
            {
                order = value;
                this.billDescription = value.BillDescription;
                this.FillData();
                this.FillUserData();
            }
        }

        private void FillData()
        {
            int index = 0;
            foreach (List<object> l in this.billDescription)
            {
                index = this.displayOrderPanel.RowCount;
                this.displayOrderPanel.RowCount++;
                this.displayOrderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                this.displayOrderPanel.Controls.Add(StringToForms((string)l[0]), 0, index);
                this.displayOrderPanel.Controls.Add(StringToForms(l[5].ToString()), 5, index);
                this.displayOrderPanel.Controls.Add(StringToForms((string)l[1]), 1, index);
                this.displayOrderPanel.Controls.Add(StringToForms((bool)l[2] ? "Yes" : "No"), 2, index);
                this.displayOrderPanel.Controls.Add(StringToForms(l[3].ToString()), 3, index);
                this.displayOrderPanel.Controls.Add(StringToForms(l[4].ToString()), 4, index);
                this.totalPrice += (float)l[5];
            }
            this.displayOrderPanel.RowCount++;
            this.displayOrderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.displayOrderPanel.Controls.Add(StringToForms("Total price"), 4, index+1);
            this.order.Price = Math.Round(this.totalPrice, 2);
            this.displayOrderPanel.Controls.Add(StringToForms(Math.Round(this.totalPrice, 2).ToString()), 5, index + 1);
        }

        private Label StringToForms (string text)
        {
            return new Label
            {
                Text = text,
                Anchor = System.Windows.Forms.AnchorStyles.None,
                AutoSize = true
            };
        }


        private void FillUserData()
        {
            foreach(KeyValuePair<string, string> keyValue in this.order.User.DescribeUser())
            {
                int index = this.displayUserPanel.RowCount;
                this.displayUserPanel.RowCount++;
                this.displayUserPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                this.displayUserPanel.Controls.Add(this.StringToForms(keyValue.Key), 0, index);
                this.displayUserPanel.Controls.Add(this.StringToForms(keyValue.Value),1, index);
            }
        }

        private void MountLayout()
        {
            this.label6 = new Label();
            this.label3 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.displayOrderPanel = new TableLayoutPanel();
            this.displayUserPanel = new TableLayoutPanel();
            this.label11 = new Label();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reference";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Availability";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Unit price";
            // 
            // label10
            // 
            this.label10.Anchor = AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Unit needed";
            // 
            // displayOrderPanel
            // 
            this.displayOrderPanel.AutoSize = true;
            this.displayOrderPanel.ColumnCount = 6;
            this.displayOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.displayOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            this.displayOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            this.displayOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            this.displayOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            this.displayOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            this.displayOrderPanel.Controls.Add(this.label6, 0, 0);
            this.displayOrderPanel.Controls.Add(this.label7, 1, 0);
            this.displayOrderPanel.Controls.Add(this.label8, 2, 0);
            this.displayOrderPanel.Controls.Add(this.label9, 3, 0);
            this.displayOrderPanel.Controls.Add(this.label10, 4, 0);
            this.displayOrderPanel.Controls.Add(this.label11, 5, 0);
            this.displayOrderPanel.Location = new System.Drawing.Point(50, 140);
            this.displayOrderPanel.Name = "displayOrderPanel";
            this.displayOrderPanel.RowCount = 1;
            this.displayOrderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.displayOrderPanel.Size = new System.Drawing.Size(512, 430);
            this.displayOrderPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.displayOrderPanel.BorderStyle = BorderStyle.FixedSingle;

            this.displayUserPanel.AutoSize = true;
            this.displayUserPanel.ColumnCount = 2;
            this.displayUserPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            this.displayUserPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            this.displayUserPanel.BorderStyle = BorderStyle.FixedSingle;
            this.displayUserPanel.Location = new System.Drawing.Point(600, 140);
            this.displayUserPanel.Size = new System.Drawing.Size(1, 1);

            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.Text = "Price";

            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.displayOrderPanel);
            this.Controls.Add(this.inStockPanel);
            this.Controls.Add(this.displayUserPanel);
        }
    }
}
