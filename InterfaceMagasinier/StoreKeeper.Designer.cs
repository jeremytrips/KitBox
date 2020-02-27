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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.GroupBox();
            this.listOfOrders = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.StockPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.OrderPage.SuspendLayout();
            this.MagasinGroupBcx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Orders.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(508, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 567);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(380, 26);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mail :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(231, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 50);
            this.label2.TabIndex = 16;
            this.label2.Text = "Firstname :";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(28, 528);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Print the order";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Finish";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(11, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 340);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Numbre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(24, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(416, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Components :";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 50);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Details";
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.listOfOrders);
            this.Orders.Controls.Add(this.vScrollBar1);
            this.Orders.Controls.Add(this.label1);
            this.Orders.Controls.Add(this.button3);
            this.Orders.Controls.Add(this.button2);
            this.Orders.Controls.Add(this.button1);
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
            this.vScrollBar1.Size = new System.Drawing.Size(23, 535);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Orders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StockPage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.GroupBox MagasinGroupBcx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Orders;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listOfOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ListBox listOfComponents;
    }
}

