namespace InterfaceMagasinier
{
    partial class StoreKeeper
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StockPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.listOfComponents = new System.Windows.Forms.ListBox();
            this.OrderPage = new System.Windows.Forms.TabPage();
            this.MagasinGroupBcx = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.GroupBox();
            this.listOfOrders = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.StockPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.OrderPage.SuspendLayout();
            this.MagasinGroupBcx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Orders.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.StockPage);
            this.tabControl1.Controls.Add(this.OrderPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // StockPage
            // 
            this.StockPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StockPage.Controls.Add(this.groupBox3);
            this.StockPage.Controls.Add(this.groupBox2);
            this.StockPage.Location = new System.Drawing.Point(4, 34);
            this.StockPage.Name = "StockPage";
            this.StockPage.Padding = new System.Windows.Forms.Padding(3);
            this.StockPage.Size = new System.Drawing.Size(992, 632);
            this.StockPage.TabIndex = 0;
            this.StockPage.Text = "Manage Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(494, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 300);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suggestion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vScrollBar2);
            this.groupBox2.Controls.Add(this.listOfComponents);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 619);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(457, 25);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(25, 584);
            this.vScrollBar2.TabIndex = 1;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar2_Scroll);
            // 
            // listOfComponents
            // 
            this.listOfComponents.FormattingEnabled = true;
            this.listOfComponents.ItemHeight = 20;
            this.listOfComponents.Location = new System.Drawing.Point(6, 25);
            this.listOfComponents.Name = "listOfComponents";
            this.listOfComponents.Size = new System.Drawing.Size(451, 584);
            this.listOfComponents.TabIndex = 11;
            this.listOfComponents.SelectedIndexChanged += new System.EventHandler(this.ListOfComponents_SelectedIndexChanged);
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderPage.Controls.Add(this.MagasinGroupBcx);
            this.OrderPage.Location = new System.Drawing.Point(4, 34);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderPage.Size = new System.Drawing.Size(992, 632);
            this.OrderPage.TabIndex = 1;
            this.OrderPage.Text = "Manage Orders";
            // 
            // MagasinGroupBcx
            // 
            this.MagasinGroupBcx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MagasinGroupBcx.Controls.Add(this.groupBox4);
            this.MagasinGroupBcx.Controls.Add(this.groupBox1);
            this.MagasinGroupBcx.Controls.Add(this.Orders);
            this.MagasinGroupBcx.Location = new System.Drawing.Point(3, 6);
            this.MagasinGroupBcx.Name = "MagasinGroupBcx";
            this.MagasinGroupBcx.Size = new System.Drawing.Size(982, 629);
            this.MagasinGroupBcx.TabIndex = 3;
            this.MagasinGroupBcx.TabStop = false;
            this.MagasinGroupBcx.Text = "Manage Orders";
            this.MagasinGroupBcx.Enter += new System.EventHandler(this.MagasinGroupBcx_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(500, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Show More ...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Closed Orders";
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.button1);
            this.Orders.Controls.Add(this.textBox4);
            this.Orders.Controls.Add(this.vScrollBar1);
            this.Orders.Controls.Add(this.label1);
            this.Orders.Controls.Add(this.button5);
            this.Orders.Controls.Add(this.listOfOrders);
            this.Orders.Location = new System.Drawing.Point(6, 52);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(485, 567);
            this.Orders.TabIndex = 1;
            this.Orders.TabStop = false;
            this.Orders.Text = "Orders";
            // 
            // listOfOrders
            // 
            this.listOfOrders.FormattingEnabled = true;
            this.listOfOrders.ItemHeight = 20;
            this.listOfOrders.Location = new System.Drawing.Point(11, 32);
            this.listOfOrders.Name = "listOfOrders";
            this.listOfOrders.Size = new System.Drawing.Size(451, 524);
            this.listOfOrders.TabIndex = 10;
            this.listOfOrders.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(462, 32);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 524);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(157, 524);
            this.textBox4.MinimumSize = new System.Drawing.Size(100, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 30);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "Search...";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.Image = global::InterfaceMagasinier.Properties.Resources.loupe;
            this.button1.Location = new System.Drawing.Point(124, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(445, 35);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(23, 204);
            this.vScrollBar3.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(11, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 204);
            this.listBox1.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vScrollBar4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(502, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 246);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(445, 35);
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(23, 204);
            this.vScrollBar4.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oder in progress";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(11, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(431, 204);
            this.listBox2.TabIndex = 24;
            // 
            // StoreKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.tabControl1);
            this.Name = "StoreKeeper";
            this.Text = "StoreKeeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.StockPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.OrderPage.ResumeLayout(false);
            this.MagasinGroupBcx.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StockPage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.GroupBox MagasinGroupBcx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Orders;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox listOfOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ListBox listOfComponents;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

